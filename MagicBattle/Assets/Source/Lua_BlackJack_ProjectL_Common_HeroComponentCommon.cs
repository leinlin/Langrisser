using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200123C RID: 4668
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroComponentCommon : LuaObject
{
	// Token: 0x06018363 RID: 99171 RVA: 0x006BF08C File Offset: 0x006BD28C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon o = new HeroComponentCommon();
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

	// Token: 0x06018364 RID: 99172 RVA: 0x006BF0D4 File Offset: 0x006BD2D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			string name = heroComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018365 RID: 99173 RVA: 0x006BF128 File Offset: 0x006BD328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018366 RID: 99174 RVA: 0x006BF174 File Offset: 0x006BD374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018367 RID: 99175 RVA: 0x006BF1C0 File Offset: 0x006BD3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018368 RID: 99176 RVA: 0x006BF20C File Offset: 0x006BD40C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			heroComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018369 RID: 99177 RVA: 0x006BF264 File Offset: 0x006BD464
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601836A RID: 99178 RVA: 0x006BF2B0 File Offset: 0x006BD4B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetProtagonistID(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int protagonistID = heroComponentCommon.GetProtagonistID();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, protagonistID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601836B RID: 99179 RVA: 0x006BF304 File Offset: 0x006BD504
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsProtagonistHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool b = heroComponentCommon.IsProtagonistHero(heroId);
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

	// Token: 0x0601836C RID: 99180 RVA: 0x006BF368 File Offset: 0x006BD568
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsProtagonistExist(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			bool b = heroComponentCommon.IsProtagonistExist();
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

	// Token: 0x0601836D RID: 99181 RVA: 0x006BF3BC File Offset: 0x006BD5BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetProtagonist(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int protagonist;
			LuaObject.checkType(l, 2, out protagonist);
			int i = heroComponentCommon.SetProtagonist(protagonist);
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

	// Token: 0x0601836E RID: 99182 RVA: 0x006BF420 File Offset: 0x006BD620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllStarLvlMaxHeroes(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			List<Hero> allStarLvlMaxHeroes = heroComponentCommon.GetAllStarLvlMaxHeroes();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allStarLvlMaxHeroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601836F RID: 99183 RVA: 0x006BF474 File Offset: 0x006BD674
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllStarLvlMaxHeroFragments(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			List<HeroFragmentBagItem> allStarLvlMaxHeroFragments = heroComponentCommon.GetAllStarLvlMaxHeroFragments();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allStarLvlMaxHeroFragments);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018370 RID: 99184 RVA: 0x006BF4C8 File Offset: 0x006BD6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanHeroJobEquipSkill(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int jobRelatedId;
			LuaObject.checkType(l, 2, out jobRelatedId);
			int skillId;
			LuaObject.checkType(l, 3, out skillId);
			int i = heroComponentCommon.CanHeroJobEquipSkill(jobRelatedId, skillId);
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

	// Token: 0x06018371 RID: 99185 RVA: 0x006BF538 File Offset: 0x006BD738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSelectSkillHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			List<int> skills;
			LuaObject.checkType<List<int>>(l, 3, out skills);
			int i = heroComponentCommon.CanSelectSkillHero(hero, skills);
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

	// Token: 0x06018372 RID: 99186 RVA: 0x006BF5A8 File Offset: 0x006BD7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectSkills(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			List<int> skills;
			LuaObject.checkType<List<int>>(l, 3, out skills);
			int i = heroComponentCommon.SelectSkills(heroId, skills);
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

	// Token: 0x06018373 RID: 99187 RVA: 0x006BF618 File Offset: 0x006BD818
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SelectSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			int i = heroComponentCommon.SelectSoldier(heroId, soldierId);
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

	// Token: 0x06018374 RID: 99188 RVA: 0x006BF688 File Offset: 0x006BD888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanHeroSelectSolider(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int soliderId;
			LuaObject.checkType(l, 3, out soliderId);
			int i = heroComponentCommon.CanHeroSelectSolider(hero, soliderId);
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

	// Token: 0x06018375 RID: 99189 RVA: 0x006BF6F8 File Offset: 0x006BD8F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.RemoveHero(heroId);
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

	// Token: 0x06018376 RID: 99190 RVA: 0x006BF75C File Offset: 0x006BD95C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveAllHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			List<int> changedHeroIdList;
			LuaObject.checkType<List<int>>(l, 2, out changedHeroIdList);
			heroComponentCommon.RemoveAllHero(changedHeroIdList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018377 RID: 99191 RVA: 0x006BF7B4 File Offset: 0x006BD9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAllHeros(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.RemoveAllHeros();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018378 RID: 99192 RVA: 0x006BF800 File Offset: 0x006BDA00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllHeros(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			List<Hero> allHeros = heroComponentCommon.GetAllHeros();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allHeros);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018379 RID: 99193 RVA: 0x006BF854 File Offset: 0x006BDA54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindHeroJob(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int)))
			{
				HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
				int heroId;
				LuaObject.checkType(l, 2, out heroId);
				int jobRelatedId;
				LuaObject.checkType(l, 3, out jobRelatedId);
				HeroJob o = heroComponentCommon.FindHeroJob(heroId, jobRelatedId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Hero), typeof(int)))
			{
				HeroComponentCommon heroComponentCommon2 = (HeroComponentCommon)LuaObject.checkSelf(l);
				Hero hero;
				LuaObject.checkType<Hero>(l, 2, out hero);
				int jobRelatedId2;
				LuaObject.checkType(l, 3, out jobRelatedId2);
				HeroJob o2 = heroComponentCommon2.FindHeroJob(hero, jobRelatedId2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function FindHeroJob to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601837A RID: 99194 RVA: 0x006BF970 File Offset: 0x006BDB70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsUnlockedHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			bool b = heroComponentCommon.IsUnlockedHeroJob(hero, jobRelatedId);
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

	// Token: 0x0601837B RID: 99195 RVA: 0x006BF9E0 File Offset: 0x006BDBE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			Hero o = heroComponentCommon.FindHero(heroId);
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

	// Token: 0x0601837C RID: 99196 RVA: 0x006BFA44 File Offset: 0x006BDC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroFightNums(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			int i = heroComponentCommon.AddHeroFightNums(heroId, nums);
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

	// Token: 0x0601837D RID: 99197 RVA: 0x006BFAB4 File Offset: 0x006BDCB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroAllNeedJobsAchievements(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			List<int> achievements;
			LuaObject.checkType<List<int>>(l, 3, out achievements);
			int i = heroComponentCommon.AddHeroAllNeedJobsAchievements(heroId, achievements);
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

	// Token: 0x0601837E RID: 99198 RVA: 0x006BFB24 File Offset: 0x006BDD24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.AddHero(heroId);
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

	// Token: 0x0601837F RID: 99199 RVA: 0x006BFB88 File Offset: 0x006BDD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsWastefulAddExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int addExp;
			LuaObject.checkType(l, 3, out addExp);
			bool b = heroComponentCommon.IsWastefulAddExp(hero, addExp);
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

	// Token: 0x06018380 RID: 99200 RVA: 0x006BFBF8 File Offset: 0x006BDDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCurrentLevelMaxHeroLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroLevel;
			LuaObject.checkType(l, 2, out heroLevel);
			bool b = heroComponentCommon.IsCurrentLevelMaxHeroLevel(heroLevel);
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

	// Token: 0x06018381 RID: 99201 RVA: 0x006BFC5C File Offset: 0x006BDE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFullCurrentHeroExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			bool b = heroComponentCommon.IsFullCurrentHeroExp(hero);
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

	// Token: 0x06018382 RID: 99202 RVA: 0x006BFCC0 File Offset: 0x006BDEC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddHeroesExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			int exp;
			LuaObject.checkType(l, 3, out exp);
			heroComponentCommon.AddHeroesExp(heroIds, exp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018383 RID: 99203 RVA: 0x006BFD24 File Offset: 0x006BDF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAddHeroExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.CanAddHeroExp(heroId);
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

	// Token: 0x06018384 RID: 99204 RVA: 0x006BFD88 File Offset: 0x006BDF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int exp;
			LuaObject.checkType(l, 3, out exp);
			int i = heroComponentCommon.AddHeroExp(heroId, exp);
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

	// Token: 0x06018385 RID: 99205 RVA: 0x006BFDF8 File Offset: 0x006BDFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroExpByUseableBagItem(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 3, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 4, out contentId);
			int consumeNums;
			LuaObject.checkType(l, 5, out consumeNums);
			int i = heroComponentCommon.AddHeroExpByUseableBagItem(heroId, goodsTypeId, contentId, consumeNums);
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

	// Token: 0x06018386 RID: 99206 RVA: 0x006BFE80 File Offset: 0x006BE080
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComposeHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.ComposeHero(heroId);
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

	// Token: 0x06018387 RID: 99207 RVA: 0x006BFEE4 File Offset: 0x006BE0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLvlMaxHeroStar(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			bool b = heroComponentCommon.IsLvlMaxHeroStar(hero);
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

	// Token: 0x06018388 RID: 99208 RVA: 0x006BFF48 File Offset: 0x006BE148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LevelUpHeroStarLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.LevelUpHeroStarLevel(heroId);
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

	// Token: 0x06018389 RID: 99209 RVA: 0x006BFFAC File Offset: 0x006BE1AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGainHeroIds(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			HashSet<int> gainHeroIds = heroComponentCommon.GetGainHeroIds();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gainHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601838A RID: 99210 RVA: 0x006C0000 File Offset: 0x006BE200
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasGainHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool b = heroComponentCommon.HasGainHero(heroId);
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

	// Token: 0x0601838B RID: 99211 RVA: 0x006C0064 File Offset: 0x006BE264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsExistSkillId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int skillId;
			LuaObject.checkType(l, 2, out skillId);
			bool b = heroComponentCommon.IsExistSkillId(skillId);
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

	// Token: 0x0601838C RID: 99212 RVA: 0x006C00C8 File Offset: 0x006BE2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsExistSoliderId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int soliderId;
			LuaObject.checkType(l, 2, out soliderId);
			bool b = heroComponentCommon.IsExistSoliderId(soliderId);
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

	// Token: 0x0601838D RID: 99213 RVA: 0x006C012C File Offset: 0x006BE32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindTopLevelHeroes(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int topNums;
			LuaObject.checkType(l, 2, out topNums);
			LinkedList<Hero> o = heroComponentCommon.FindTopLevelHeroes(topNums);
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

	// Token: 0x0601838E RID: 99214 RVA: 0x006C0190 File Offset: 0x006BE390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActiveHeroJobRelatedIdByHeroId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int activeHeroJobRelatedIdByHeroId = heroComponentCommon.GetActiveHeroJobRelatedIdByHeroId(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activeHeroJobRelatedIdByHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601838F RID: 99215 RVA: 0x006C01F4 File Offset: 0x006BE3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GmResetHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.GmResetHeroJob(heroId);
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

	// Token: 0x06018390 RID: 99216 RVA: 0x006C0258 File Offset: 0x006BE458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAdditiveHeroAddExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int addExp;
			LuaObject.checkType(l, 2, out addExp);
			int additiveHeroAddExp = heroComponentCommon.GetAdditiveHeroAddExp(addExp);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, additiveHeroAddExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018391 RID: 99217 RVA: 0x006C02BC File Offset: 0x006BE4BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAdditiveHeroFavourabilityAddExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int addExp;
			LuaObject.checkType(l, 2, out addExp);
			int additiveHeroFavourabilityAddExp = heroComponentCommon.GetAdditiveHeroFavourabilityAddExp(addExp);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, additiveHeroFavourabilityAddExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018392 RID: 99218 RVA: 0x006C0320 File Offset: 0x006BE520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddHeroJobAchievementsAfterBattleLevelEnd(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			List<int> relatedAchievements;
			LuaObject.checkType<List<int>>(l, 2, out relatedAchievements);
			List<int> fightHeroes;
			LuaObject.checkType<List<int>>(l, 3, out fightHeroes);
			heroComponentCommon.AddHeroJobAchievementsAfterBattleLevelEnd(relatedAchievements, fightHeroes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018393 RID: 99219 RVA: 0x006C0384 File Offset: 0x006BE584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsJobLevelMax(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
				HeroJob job;
				LuaObject.checkType<HeroJob>(l, 2, out job);
				bool b = heroComponentCommon.IsJobLevelMax(job);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				HeroComponentCommon heroComponentCommon2 = (HeroComponentCommon)LuaObject.checkSelf(l);
				ConfigDataJobConnectionInfo jobConnectionInfo;
				LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
				int jobLevel;
				LuaObject.checkType(l, 3, out jobLevel);
				bool b2 = heroComponentCommon2.IsJobLevelMax(jobConnectionInfo, jobLevel);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsJobLevelMax to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018394 RID: 99220 RVA: 0x006C045C File Offset: 0x006BE65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanLevelUpHeroJobLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponentCommon.CanLevelUpHeroJobLevel(heroId, jobRelatedId);
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

	// Token: 0x06018395 RID: 99221 RVA: 0x006C04CC File Offset: 0x006BE6CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanTransferHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponentCommon.CanTransferHeroJob(heroId, jobRelatedId);
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

	// Token: 0x06018396 RID: 99222 RVA: 0x006C053C File Offset: 0x006BE73C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TransferHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponentCommon.TransferHeroJob(heroId, jobRelatedId);
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

	// Token: 0x06018397 RID: 99223 RVA: 0x006C05AC File Offset: 0x006BE7AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNeedUnlock(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			bool b = heroComponentCommon.IsNeedUnlock(jobConnectionInfo);
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

	// Token: 0x06018398 RID: 99224 RVA: 0x006C0610 File Offset: 0x006BE810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnlockedHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponentCommon.UnlockedHeroJob(heroId, jobRelatedId);
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

	// Token: 0x06018399 RID: 99225 RVA: 0x006C0680 File Offset: 0x006BE880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LevelUpHeroJobLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponentCommon.LevelUpHeroJobLevel(heroId, jobRelatedId);
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

	// Token: 0x0601839A RID: 99226 RVA: 0x006C06F0 File Offset: 0x006BE8F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			bool needExchange;
			LuaObject.checkType(l, 4, out needExchange);
			heroComponentCommon.AddSoldier(hero, soldierId, needExchange);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601839B RID: 99227 RVA: 0x006C0764 File Offset: 0x006BE964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AutoTakeOffEquipments(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.AutoTakeOffEquipments(heroId);
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

	// Token: 0x0601839C RID: 99228 RVA: 0x006C07C8 File Offset: 0x006BE9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanWearEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ulong instanceId;
			LuaObject.checkType(l, 3, out instanceId);
			int i = heroComponentCommon.CanWearEquipment(heroId, instanceId);
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

	// Token: 0x0601839D RID: 99229 RVA: 0x006C0838 File Offset: 0x006BEA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanWearEquipmentByJobAndArmy(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			BagItemBase equipment;
			LuaObject.checkType<BagItemBase>(l, 3, out equipment);
			int i = heroComponentCommon.CanWearEquipmentByJobAndArmy(hero, equipment);
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

	// Token: 0x0601839E RID: 99230 RVA: 0x006C08A8 File Offset: 0x006BEAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEquipmentWeared(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			bool b = heroComponentCommon.IsEquipmentWeared(instanceId);
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

	// Token: 0x0601839F RID: 99231 RVA: 0x006C090C File Offset: 0x006BEB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWearedEquipmentHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			Hero wearedEquipmentHero = heroComponentCommon.GetWearedEquipmentHero(instanceId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wearedEquipmentHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183A0 RID: 99232 RVA: 0x006C0970 File Offset: 0x006BEB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WearEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ulong instanceId;
			LuaObject.checkType(l, 3, out instanceId);
			int i = heroComponentCommon.WearEquipment(heroId, instanceId);
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

	// Token: 0x060183A1 RID: 99233 RVA: 0x006C09E0 File Offset: 0x006BEBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanTakeOffEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			int i = heroComponentCommon.CanTakeOffEquipment(heroId, slot);
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

	// Token: 0x060183A2 RID: 99234 RVA: 0x006C0A50 File Offset: 0x006BEC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TakeOffEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			int i = heroComponentCommon.TakeOffEquipment(heroId, slot);
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

	// Token: 0x060183A3 RID: 99235 RVA: 0x006C0AC0 File Offset: 0x006BECC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasBetterEquipmentByHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool b = heroComponentCommon.HasBetterEquipmentByHero(heroId);
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

	// Token: 0x060183A4 RID: 99236 RVA: 0x006C0B24 File Offset: 0x006BED24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasBetterEquipmentBySlotId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int slotId;
			LuaObject.checkType(l, 3, out slotId);
			bool b = heroComponentCommon.HasBetterEquipmentBySlotId(heroId, slotId);
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

	// Token: 0x060183A5 RID: 99237 RVA: 0x006C0B94 File Offset: 0x006BED94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAutoEquipmentByClient(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.CanAutoEquipmentByClient(heroId);
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

	// Token: 0x060183A6 RID: 99238 RVA: 0x006C0BF8 File Offset: 0x006BEDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAutoEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.CanAutoEquipment(heroId);
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

	// Token: 0x060183A7 RID: 99239 RVA: 0x006C0C5C File Offset: 0x006BEE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanWearCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int charSkinId;
			LuaObject.checkType(l, 3, out charSkinId);
			int i = heroComponentCommon.CanWearCharSkin(heroId, charSkinId);
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

	// Token: 0x060183A8 RID: 99240 RVA: 0x006C0CCC File Offset: 0x006BEECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WearCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int charSkinId;
			LuaObject.checkType(l, 3, out charSkinId);
			int i = heroComponentCommon.WearCharSkin(heroId, charSkinId);
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

	// Token: 0x060183A9 RID: 99241 RVA: 0x006C0D3C File Offset: 0x006BEF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanTakeOffCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.CanTakeOffCharSkin(heroId);
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

	// Token: 0x060183AA RID: 99242 RVA: 0x006C0DA0 File Offset: 0x006BEFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TakeOffCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.TakeOffCharSkin(heroId);
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

	// Token: 0x060183AB RID: 99243 RVA: 0x006C0E04 File Offset: 0x006BF004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanWearModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int modelSkinId;
			LuaObject.checkType(l, 4, out modelSkinId);
			int i = heroComponentCommon.CanWearModelSkin(heroId, jobRelatedId, modelSkinId);
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

	// Token: 0x060183AC RID: 99244 RVA: 0x006C0E80 File Offset: 0x006BF080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WearModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int modelSkinId;
			LuaObject.checkType(l, 4, out modelSkinId);
			int i = heroComponentCommon.WearModelSkin(heroId, jobRelatedId, modelSkinId);
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

	// Token: 0x060183AD RID: 99245 RVA: 0x006C0EFC File Offset: 0x006BF0FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanTakeOffModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponentCommon.CanTakeOffModelSkin(heroId, jobRelatedId);
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

	// Token: 0x060183AE RID: 99246 RVA: 0x006C0F6C File Offset: 0x006BF16C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TakeOffModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponentCommon.TakeOffModelSkin(heroId, jobRelatedId);
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

	// Token: 0x060183AF RID: 99247 RVA: 0x006C0FDC File Offset: 0x006BF1DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanWearSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			int soldierSkinId;
			LuaObject.checkType(l, 4, out soldierSkinId);
			int i = heroComponentCommon.CanWearSoldierSkin(heroId, soldierId, soldierSkinId);
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

	// Token: 0x060183B0 RID: 99248 RVA: 0x006C1058 File Offset: 0x006BF258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WearSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			int soldierSkinId;
			LuaObject.checkType(l, 4, out soldierSkinId);
			bool applyToAll;
			LuaObject.checkType(l, 5, out applyToAll);
			int i = heroComponentCommon.WearSoldierSkin(heroId, soldierId, soldierSkinId, applyToAll);
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

	// Token: 0x060183B1 RID: 99249 RVA: 0x006C10E0 File Offset: 0x006BF2E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanTakeOffSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			int i = heroComponentCommon.CanTakeOffSoldierSkin(heroId, soldierId);
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

	// Token: 0x060183B2 RID: 99250 RVA: 0x006C1150 File Offset: 0x006BF350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TakeOffSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			bool applyToAll;
			LuaObject.checkType(l, 4, out applyToAll);
			int i = heroComponentCommon.TakeOffSoldierSkin(heroId, soldierId, applyToAll);
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

	// Token: 0x060183B3 RID: 99251 RVA: 0x006C11CC File Offset: 0x006BF3CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TakeOffSoldierSkinApplyToAll(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int soldierId;
			LuaObject.checkType(l, 2, out soldierId);
			int skinId;
			LuaObject.checkType(l, 3, out skinId);
			heroComponentCommon.TakeOffSoldierSkinApplyToAll(soldierId, skinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183B4 RID: 99252 RVA: 0x006C1230 File Offset: 0x006BF430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroFavorabilityExpByUseableBagItem(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 3, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 4, out contentId);
			int consumeNums;
			LuaObject.checkType(l, 5, out consumeNums);
			int i = heroComponentCommon.AddHeroFavorabilityExpByUseableBagItem(heroId, goodsTypeId, contentId, consumeNums);
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

	// Token: 0x060183B5 RID: 99253 RVA: 0x006C12B8 File Offset: 0x006BF4B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddHeroFavorabilityLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int addExp;
			LuaObject.checkType(l, 3, out addExp);
			int i = heroComponentCommon.AddHeroFavorabilityLevel(heroId, addExp);
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

	// Token: 0x060183B6 RID: 99254 RVA: 0x006C1328 File Offset: 0x006BF528
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsFullFavorabilityExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataHeroInformationInfo heroInformationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 3, out heroInformationInfo);
			bool b = heroComponentCommon.IsFullFavorabilityExp(hero, heroInformationInfo);
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

	// Token: 0x060183B7 RID: 99255 RVA: 0x006C1398 File Offset: 0x006BF598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUnlockHeroFetter(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			int i = heroComponentCommon.CanUnlockHeroFetter(heroId, fetterId);
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

	// Token: 0x060183B8 RID: 99256 RVA: 0x006C1408 File Offset: 0x006BF608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanReachFetterUnlockCondition(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			HeroFetterCompletionCondition condition;
			LuaObject.checkType<HeroFetterCompletionCondition>(l, 2, out condition);
			int i = heroComponentCommon.CanReachFetterUnlockCondition(condition);
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

	// Token: 0x060183B9 RID: 99257 RVA: 0x006C146C File Offset: 0x006BF66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GmLevelUpHeroFetter2SpecificLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			int reachLevel;
			LuaObject.checkType(l, 4, out reachLevel);
			int i = heroComponentCommon.GmLevelUpHeroFetter2SpecificLevel(heroId, fetterId, reachLevel);
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

	// Token: 0x060183BA RID: 99258 RVA: 0x006C14E8 File Offset: 0x006BF6E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanLevelUpHeroFetter(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			int i = heroComponentCommon.CanLevelUpHeroFetter(heroId, fetterId);
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

	// Token: 0x060183BB RID: 99259 RVA: 0x006C1558 File Offset: 0x006BF758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LevelUpHeroFetter(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			int i = heroComponentCommon.LevelUpHeroFetter(heroId, fetterId);
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

	// Token: 0x060183BC RID: 99260 RVA: 0x006C15C8 File Offset: 0x006BF7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnlockHeroFetter(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			bool check;
			LuaObject.checkType(l, 4, out check);
			int i = heroComponentCommon.UnlockHeroFetter(heroId, fetterId, check);
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

	// Token: 0x060183BD RID: 99261 RVA: 0x006C1644 File Offset: 0x006BF844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ConfessHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool check;
			LuaObject.checkType(l, 3, out check);
			int i = heroComponentCommon.ConfessHero(heroId, check);
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

	// Token: 0x060183BE RID: 99262 RVA: 0x006C16B4 File Offset: 0x006BF8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanConfessHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.CanConfessHero(heroId);
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

	// Token: 0x060183BF RID: 99263 RVA: 0x006C1718 File Offset: 0x006BF918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanInteractHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.CanInteractHero(heroId);
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

	// Token: 0x060183C0 RID: 99264 RVA: 0x006C177C File Offset: 0x006BF97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroFavorabilityUpLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataHeroInformationInfo heroInformationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 3, out heroInformationInfo);
			int addExp;
			LuaObject.checkType(l, 4, out addExp);
			int heroFavorabilityUpLevel = heroComponentCommon.GetHeroFavorabilityUpLevel(hero, heroInformationInfo, addExp);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroFavorabilityUpLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183C1 RID: 99265 RVA: 0x006C17F8 File Offset: 0x006BF9F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int allHeroBattlePower = heroComponentCommon.GetAllHeroBattlePower();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allHeroBattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183C2 RID: 99266 RVA: 0x006C184C File Offset: 0x006BFA4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLastAllHeroRank(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int lastAllHeroRank = heroComponentCommon.GetLastAllHeroRank();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastAllHeroRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183C3 RID: 99267 RVA: 0x006C18A0 File Offset: 0x006BFAA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTopHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int topHeroBattlePower = heroComponentCommon.GetTopHeroBattlePower();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, topHeroBattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183C4 RID: 99268 RVA: 0x006C18F4 File Offset: 0x006BFAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLastTopHeroRank(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int lastTopHeroRank = heroComponentCommon.GetLastTopHeroRank();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastTopHeroRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183C5 RID: 99269 RVA: 0x006C1948 File Offset: 0x006BFB48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetChampionHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int championHeroBattlePower = heroComponentCommon.GetChampionHeroBattlePower();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, championHeroBattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183C6 RID: 99270 RVA: 0x006C199C File Offset: 0x006BFB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetChampionHeroId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int championHeroId = heroComponentCommon.GetChampionHeroId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, championHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183C7 RID: 99271 RVA: 0x006C19F0 File Offset: 0x006BFBF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLastChampionHeroRank(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int lastChampionHeroRank = heroComponentCommon.GetLastChampionHeroRank();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastChampionHeroRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183C8 RID: 99272 RVA: 0x006C1A44 File Offset: 0x006BFC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeBattlePower(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			bool b = heroComponentCommon.ComputeBattlePower(hero);
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

	// Token: 0x060183C9 RID: 99273 RVA: 0x006C1AA8 File Offset: 0x006BFCA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHeroBattlePowerChange(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroComponentCommon.OnHeroBattlePowerChange(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183CA RID: 99274 RVA: 0x006C1B00 File Offset: 0x006BFD00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanComposeHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.CanComposeHero(heroId);
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

	// Token: 0x060183CB RID: 99275 RVA: 0x006C1B64 File Offset: 0x006BFD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanLevelUpHeroStarLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponentCommon.CanLevelUpHeroStarLevel(heroId);
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

	// Token: 0x060183CC RID: 99276 RVA: 0x006C1BC8 File Offset: 0x006BFDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEquipedEquipments(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			List<ulong> equipedEquipments = heroComponentCommon.GetEquipedEquipments();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipedEquipments);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183CD RID: 99277 RVA: 0x006C1C1C File Offset: 0x006BFE1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSkillEnergyFromConfig(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroLevel;
			LuaObject.checkType(l, 2, out heroLevel);
			int skillEnergyFromConfig = heroComponentCommon.GetSkillEnergyFromConfig(heroLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillEnergyFromConfig);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183CE RID: 99278 RVA: 0x006C1C80 File Offset: 0x006BFE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateDefaultConfigHero_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 1, out heroInfo);
			Hero o = HeroComponentCommon.CreateDefaultConfigHero(heroInfo);
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

	// Token: 0x060183CF RID: 99279 RVA: 0x006C1CD4 File Offset: 0x006BFED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitHeroDataByCaculate(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroComponentCommon.m_luaExportHelper.InitHeroDataByCaculate(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183D0 RID: 99280 RVA: 0x006C1D30 File Offset: 0x006BFF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitHeroJobs(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroComponentCommon.m_luaExportHelper.InitHeroJobs(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183D1 RID: 99281 RVA: 0x006C1D8C File Offset: 0x006BFF8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddHeroDefaultInfos(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 3, out heroInfo);
			heroComponentCommon.m_luaExportHelper.AddHeroDefaultInfos(hero, heroInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183D2 RID: 99282 RVA: 0x006C1DF8 File Offset: 0x006BFFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGetHeroJobByRank(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int rank;
			LuaObject.checkType(l, 3, out rank);
			bool b = heroComponentCommon.m_luaExportHelper.CanGetHeroJobByRank(hero, rank);
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

	// Token: 0x060183D3 RID: 99283 RVA: 0x006C1E6C File Offset: 0x006C006C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddHeroInfos(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			Hero o = heroComponentCommon.m_luaExportHelper.AddHeroInfos(heroInfo);
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

	// Token: 0x060183D4 RID: 99284 RVA: 0x006C1ED4 File Offset: 0x006C00D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OutPutHeroLevelUpOperateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int currentLevel;
			LuaObject.checkType(l, 3, out currentLevel);
			heroComponentCommon.m_luaExportHelper.OutPutHeroLevelUpOperateLog(heroId, currentLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183D5 RID: 99285 RVA: 0x006C1F40 File Offset: 0x006C0140
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OutPutHeroUpgradeOperateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int currentStar;
			LuaObject.checkType(l, 3, out currentStar);
			List<Goods> costItems;
			LuaObject.checkType<List<Goods>>(l, 4, out costItems);
			heroComponentCommon.m_luaExportHelper.OutPutHeroUpgradeOperateLog(heroId, currentStar, costItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183D6 RID: 99286 RVA: 0x006C1FB8 File Offset: 0x006C01B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroLevelUp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int oldLevel;
			LuaObject.checkType(l, 2, out oldLevel);
			Hero hero;
			LuaObject.checkType<Hero>(l, 3, out hero);
			heroComponentCommon.m_luaExportHelper.OnHeroLevelUp(oldLevel, hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183D7 RID: 99287 RVA: 0x006C2024 File Offset: 0x006C0224
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 3, out jobConnectionInfo);
			heroComponentCommon.m_luaExportHelper.AddHeroJob(hero, jobConnectionInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183D8 RID: 99288 RVA: 0x006C2090 File Offset: 0x006C0290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanTransferHeroJobRank(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int jobRank;
			LuaObject.checkType(l, 2, out jobRank);
			int canTransferMaxRank;
			LuaObject.checkType(l, 3, out canTransferMaxRank);
			bool b = heroComponentCommon.m_luaExportHelper.CanTransferHeroJobRank(jobRank, canTransferMaxRank);
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

	// Token: 0x060183D9 RID: 99289 RVA: 0x006C2104 File Offset: 0x006C0304
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OutPutHeroJobChangeOperateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int preJobConnectionId;
			LuaObject.checkType(l, 3, out preJobConnectionId);
			int postJobConnectionId;
			LuaObject.checkType(l, 4, out postJobConnectionId);
			List<Goods> costItems;
			LuaObject.checkType<List<Goods>>(l, 5, out costItems);
			heroComponentCommon.m_luaExportHelper.OutPutHeroJobChangeOperateLog(heroId, preJobConnectionId, postJobConnectionId, costItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183DA RID: 99290 RVA: 0x006C2188 File Offset: 0x006C0388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTransferHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 3, out jobConnectionInfo);
			int jobLevel;
			LuaObject.checkType(l, 4, out jobLevel);
			heroComponentCommon.m_luaExportHelper.OnTransferHeroJob(hero, jobConnectionInfo, jobLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183DB RID: 99291 RVA: 0x006C2200 File Offset: 0x006C0400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryEquipNewSkill(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int newGotSkillId;
			LuaObject.checkType(l, 3, out newGotSkillId);
			heroComponentCommon.m_luaExportHelper.TryEquipNewSkill(hero, newGotSkillId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183DC RID: 99292 RVA: 0x006C226C File Offset: 0x006C046C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedAddAchievement(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			bool b = heroComponentCommon.m_luaExportHelper.IsNeedAddAchievement(jobConnectionInfo);
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

	// Token: 0x060183DD RID: 99293 RVA: 0x006C22D4 File Offset: 0x006C04D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OutPutHeroJobUnlockOperateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int activeJobId;
			LuaObject.checkType(l, 3, out activeJobId);
			int unlockJobId;
			LuaObject.checkType(l, 4, out unlockJobId);
			List<Goods> costItems;
			LuaObject.checkType<List<Goods>>(l, 5, out costItems);
			heroComponentCommon.m_luaExportHelper.OutPutHeroJobUnlockOperateLog(heroId, activeJobId, unlockJobId, costItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183DE RID: 99294 RVA: 0x006C2358 File Offset: 0x006C0558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanUnlockedHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 3, out jobConnectionInfo);
			int i = heroComponentCommon.m_luaExportHelper.CanUnlockedHeroJob(hero, jobConnectionInfo);
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

	// Token: 0x060183DF RID: 99295 RVA: 0x006C23CC File Offset: 0x006C05CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OutPutHeroJobLevelUpOperateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int activeJobId;
			LuaObject.checkType(l, 3, out activeJobId);
			int currentLevel;
			LuaObject.checkType(l, 4, out currentLevel);
			List<Goods> costItems;
			LuaObject.checkType<List<Goods>>(l, 5, out costItems);
			heroComponentCommon.m_luaExportHelper.OutPutHeroJobLevelUpOperateLog(heroId, activeJobId, currentLevel, costItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183E0 RID: 99296 RVA: 0x006C2450 File Offset: 0x006C0650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSkill(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int skillId;
			LuaObject.checkType(l, 3, out skillId);
			heroComponentCommon.m_luaExportHelper.AddSkill(hero, skillId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183E1 RID: 99297 RVA: 0x006C24BC File Offset: 0x006C06BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitWearedEquipments(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.m_luaExportHelper.InitWearedEquipments();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183E2 RID: 99298 RVA: 0x006C2510 File Offset: 0x006C0710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TakeOffEquipmentsOrNotWhenTransferHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroComponentCommon.m_luaExportHelper.TakeOffEquipmentsOrNotWhenTransferHeroJob(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183E3 RID: 99299 RVA: 0x006C256C File Offset: 0x006C076C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WearEquipmentBySlot(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			ulong instanceId;
			LuaObject.checkType(l, 4, out instanceId);
			heroComponentCommon.m_luaExportHelper.WearEquipmentBySlot(hero, slot, instanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183E4 RID: 99300 RVA: 0x006C25E4 File Offset: 0x006C07E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TakeOffEquipmentBySlot(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			heroComponentCommon.m_luaExportHelper.TakeOffEquipmentBySlot(hero, slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183E5 RID: 99301 RVA: 0x006C2650 File Offset: 0x006C0850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWearedEquipmentBySlotId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int slotId;
			LuaObject.checkType(l, 3, out slotId);
			BagItemBase wearedEquipmentBySlotId = heroComponentCommon.m_luaExportHelper.GetWearedEquipmentBySlotId(hero, slotId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wearedEquipmentBySlotId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183E6 RID: 99302 RVA: 0x006C26C4 File Offset: 0x006C08C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBetterEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			BagItemBase wearedEquipment;
			LuaObject.checkType<BagItemBase>(l, 2, out wearedEquipment);
			BagItemBase compareEquipment;
			LuaObject.checkType<BagItemBase>(l, 3, out compareEquipment);
			int slotId;
			LuaObject.checkType(l, 4, out slotId);
			bool b = heroComponentCommon.m_luaExportHelper.IsBetterEquipment(wearedEquipment, compareEquipment, slotId);
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

	// Token: 0x060183E7 RID: 99303 RVA: 0x006C2748 File Offset: 0x006C0948
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OutPutHeroFavourabilityOperateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int oldLvl;
			LuaObject.checkType(l, 3, out oldLvl);
			int oldExp;
			LuaObject.checkType(l, 4, out oldExp);
			int newLvl;
			LuaObject.checkType(l, 5, out newLvl);
			int newExp;
			LuaObject.checkType(l, 6, out newExp);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 7, out rewards);
			heroComponentCommon.m_luaExportHelper.OutPutHeroFavourabilityOperateLog(heroId, oldLvl, oldExp, newLvl, newExp, rewards);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183E8 RID: 99304 RVA: 0x006C27E4 File Offset: 0x006C09E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GenerateFavorabilityLevelUpReward(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int dropId;
			LuaObject.checkType(l, 3, out dropId);
			heroComponentCommon.m_luaExportHelper.GenerateFavorabilityLevelUpReward(heroId, dropId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183E9 RID: 99305 RVA: 0x006C2850 File Offset: 0x006C0A50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateProtagonistHeroFavorabilityLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.m_luaExportHelper.UpdateProtagonistHeroFavorabilityLevel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183EA RID: 99306 RVA: 0x006C28A4 File Offset: 0x006C0AA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LevelUpHeroFetterCallBack(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			heroComponentCommon.m_luaExportHelper.LevelUpHeroFetterCallBack(hero, fetterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183EB RID: 99307 RVA: 0x006C2910 File Offset: 0x006C0B10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OutPutHeroFetterOpereateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			int currentLvl;
			LuaObject.checkType(l, 4, out currentLvl);
			List<Goods> itemCost;
			LuaObject.checkType<List<Goods>>(l, 5, out itemCost);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 6, out rewards);
			heroComponentCommon.m_luaExportHelper.OutPutHeroFetterOpereateLog(heroId, fetterId, currentLvl, itemCost, rewards);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183EC RID: 99308 RVA: 0x006C29A0 File Offset: 0x006C0BA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GenerateFetterUnlockRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			heroComponentCommon.m_luaExportHelper.GenerateFetterUnlockRewards(heroId, fetterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183ED RID: 99309 RVA: 0x006C2A0C File Offset: 0x006C0C0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GenerateConfessionRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int herId;
			LuaObject.checkType(l, 2, out herId);
			ConfigDataHeroConfessionInfo confessionInfo;
			LuaObject.checkType<ConfigDataHeroConfessionInfo>(l, 3, out confessionInfo);
			heroComponentCommon.m_luaExportHelper.GenerateConfessionRewards(herId, confessionInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183EE RID: 99310 RVA: 0x006C2A78 File Offset: 0x006C0C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FlushHeroInteractNums(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.m_luaExportHelper.FlushHeroInteractNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183EF RID: 99311 RVA: 0x006C2ACC File Offset: 0x006C0CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitHeroInteractNums(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.m_luaExportHelper.InitHeroInteractNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183F0 RID: 99312 RVA: 0x006C2B20 File Offset: 0x006C0D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanFlushHeroInteractNums(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			bool b = heroComponentCommon.m_luaExportHelper.CanFlushHeroInteractNums();
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

	// Token: 0x060183F1 RID: 99313 RVA: 0x006C2B7C File Offset: 0x006C0D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFullHeroInteractNums(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			bool b = heroComponentCommon.m_luaExportHelper.IsFullHeroInteractNums();
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

	// Token: 0x060183F2 RID: 99314 RVA: 0x006C2BD8 File Offset: 0x006C0DD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddHeroInteractNums(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int addNums;
			LuaObject.checkType(l, 2, out addNums);
			bool recoveryByTime;
			LuaObject.checkType(l, 3, out recoveryByTime);
			heroComponentCommon.m_luaExportHelper.AddHeroInteractNums(addNums, recoveryByTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183F3 RID: 99315 RVA: 0x006C2C44 File Offset: 0x006C0E44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsHeroInteractNumsEqualToMax(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			bool b = heroComponentCommon.m_luaExportHelper.IsHeroInteractNumsEqualToMax();
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

	// Token: 0x060183F4 RID: 99316 RVA: 0x006C2CA0 File Offset: 0x006C0EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroInteractId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataHeroInformationInfo heroInformationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 3, out heroInformationInfo);
			int heroInteractId = heroComponentCommon.m_luaExportHelper.GetHeroInteractId(hero, heroInformationInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroInteractId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183F5 RID: 99317 RVA: 0x006C2D14 File Offset: 0x006C0F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUnlcokJobAchievements(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			List<int> unlcokJobAchievements = heroComponentCommon.m_luaExportHelper.GetUnlcokJobAchievements(jobConnectionInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unlcokJobAchievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183F6 RID: 99318 RVA: 0x006C2D7C File Offset: 0x006C0F7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHeroStarLevelUpDataFromConfig(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int fragmentId;
			LuaObject.checkType(l, 2, out fragmentId);
			int newStarLevel;
			LuaObject.checkType(l, 3, out newStarLevel);
			List<Goods> heroStarLevelUpDataFromConfig = heroComponentCommon.m_luaExportHelper.GetHeroStarLevelUpDataFromConfig(fragmentId, newStarLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroStarLevelUpDataFromConfig);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183F7 RID: 99319 RVA: 0x006C2DF0 File Offset: 0x006C0FF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSkillCostFromConfig(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int skillId;
			LuaObject.checkType(l, 2, out skillId);
			int skillCostFromConfig = heroComponentCommon.m_luaExportHelper.GetSkillCostFromConfig(skillId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillCostFromConfig);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183F8 RID: 99320 RVA: 0x006C2E58 File Offset: 0x006C1058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_AddHeroEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroComponentCommon.m_luaExportHelper.__callDele_AddHeroEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183F9 RID: 99321 RVA: 0x006C2EB4 File Offset: 0x006C10B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_AddHeroEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroComponentCommon.m_luaExportHelper.__clearDele_AddHeroEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183FA RID: 99322 RVA: 0x006C2F10 File Offset: 0x006C1110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_SpecificHeroFightMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroComponentCommon.m_luaExportHelper.__callDele_SpecificHeroFightMissionEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183FB RID: 99323 RVA: 0x006C2F7C File Offset: 0x006C117C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_SpecificHeroFightMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroComponentCommon.m_luaExportHelper.__clearDele_SpecificHeroFightMissionEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183FC RID: 99324 RVA: 0x006C2FE8 File Offset: 0x006C11E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_HeroNewJobTransferMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroComponentCommon.m_luaExportHelper.__callDele_HeroNewJobTransferMissionEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183FD RID: 99325 RVA: 0x006C3054 File Offset: 0x006C1254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_HeroNewJobTransferMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroComponentCommon.m_luaExportHelper.__clearDele_HeroNewJobTransferMissionEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183FE RID: 99326 RVA: 0x006C30C0 File Offset: 0x006C12C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_HeroJobLevelUpMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.m_luaExportHelper.__callDele_HeroJobLevelUpMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060183FF RID: 99327 RVA: 0x006C3114 File Offset: 0x006C1314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_HeroJobLevelUpMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.m_luaExportHelper.__clearDele_HeroJobLevelUpMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018400 RID: 99328 RVA: 0x006C3168 File Offset: 0x006C1368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_HeroJobMasterMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroComponentCommon.m_luaExportHelper.__callDele_HeroJobMasterMissionEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018401 RID: 99329 RVA: 0x006C31D4 File Offset: 0x006C13D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_HeroJobMasterMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroComponentCommon.m_luaExportHelper.__clearDele_HeroJobMasterMissionEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018402 RID: 99330 RVA: 0x006C3240 File Offset: 0x006C1440
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_AddHeroJobMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.m_luaExportHelper.__callDele_AddHeroJobMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018403 RID: 99331 RVA: 0x006C3294 File Offset: 0x006C1494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_AddHeroJobMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			heroComponentCommon.m_luaExportHelper.__clearDele_AddHeroJobMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018404 RID: 99332 RVA: 0x006C32E8 File Offset: 0x006C14E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_HeroLevelUpMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroComponentCommon.m_luaExportHelper.__callDele_HeroLevelUpMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018405 RID: 99333 RVA: 0x006C3344 File Offset: 0x006C1544
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_HeroLevelUpMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroComponentCommon.m_luaExportHelper.__clearDele_HeroLevelUpMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018406 RID: 99334 RVA: 0x006C33A0 File Offset: 0x006C15A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_AddHeroJobSkillMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroComponentCommon.m_luaExportHelper.__callDele_AddHeroJobSkillMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018407 RID: 99335 RVA: 0x006C33FC File Offset: 0x006C15FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_AddHeroJobSkillMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroComponentCommon.m_luaExportHelper.__clearDele_AddHeroJobSkillMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018408 RID: 99336 RVA: 0x006C3458 File Offset: 0x006C1658
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_AddHeroJobSoliderMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroComponentCommon.m_luaExportHelper.__callDele_AddHeroJobSoliderMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018409 RID: 99337 RVA: 0x006C34B4 File Offset: 0x006C16B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_AddHeroJobSoliderMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroComponentCommon.m_luaExportHelper.__clearDele_AddHeroJobSoliderMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601840A RID: 99338 RVA: 0x006C3510 File Offset: 0x006C1710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_AddHeroMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroComponentCommon.m_luaExportHelper.__callDele_AddHeroMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601840B RID: 99339 RVA: 0x006C356C File Offset: 0x006C176C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_AddHeroMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroComponentCommon.m_luaExportHelper.__clearDele_AddHeroMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601840C RID: 99340 RVA: 0x006C35C8 File Offset: 0x006C17C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_LevelUpHeroStarLevelMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroComponentCommon.m_luaExportHelper.__callDele_LevelUpHeroStarLevelMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601840D RID: 99341 RVA: 0x006C3624 File Offset: 0x006C1824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_LevelUpHeroStarLevelMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroComponentCommon.m_luaExportHelper.__clearDele_LevelUpHeroStarLevelMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601840E RID: 99342 RVA: 0x006C3680 File Offset: 0x006C1880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601840F RID: 99343 RVA: 0x006C36D8 File Offset: 0x006C18D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018410 RID: 99344 RVA: 0x006C3734 File Offset: 0x006C1934
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AddHeroEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroComponentCommon.AddHeroEvent += value;
				}
				else if (num == 2)
				{
					heroComponentCommon.AddHeroEvent -= value;
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

	// Token: 0x06018411 RID: 99345 RVA: 0x006C37B4 File Offset: 0x006C19B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018412 RID: 99346 RVA: 0x006C380C File Offset: 0x006C1A0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			heroComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018413 RID: 99347 RVA: 0x006C3868 File Offset: 0x006C1A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018414 RID: 99348 RVA: 0x006C38C0 File Offset: 0x006C1AC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			heroComponentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018415 RID: 99349 RVA: 0x006C391C File Offset: 0x006C1B1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_mission(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_mission);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018416 RID: 99350 RVA: 0x006C3974 File Offset: 0x006C1B74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_mission(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			MissionComponentCommon mission;
			LuaObject.checkType<MissionComponentCommon>(l, 2, out mission);
			heroComponentCommon.m_luaExportHelper.m_mission = mission;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018417 RID: 99351 RVA: 0x006C39D0 File Offset: 0x006C1BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018418 RID: 99352 RVA: 0x006C3A28 File Offset: 0x006C1C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			heroComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018419 RID: 99353 RVA: 0x006C3A84 File Offset: 0x006C1C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601841A RID: 99354 RVA: 0x006C3ADC File Offset: 0x006C1CDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			heroComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601841B RID: 99355 RVA: 0x006C3B38 File Offset: 0x006C1D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resource(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_resource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601841C RID: 99356 RVA: 0x006C3B90 File Offset: 0x006C1D90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_resource(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			ResourceComponentCommon resource;
			LuaObject.checkType<ResourceComponentCommon>(l, 2, out resource);
			heroComponentCommon.m_luaExportHelper.m_resource = resource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601841D RID: 99357 RVA: 0x006C3BEC File Offset: 0x006C1DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guild(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_guild);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601841E RID: 99358 RVA: 0x006C3C44 File Offset: 0x006C1E44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guild(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			GuildComponentCommon guild;
			LuaObject.checkType<GuildComponentCommon>(l, 2, out guild);
			heroComponentCommon.m_luaExportHelper.m_guild = guild;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601841F RID: 99359 RVA: 0x006C3CA0 File Offset: 0x006C1EA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_trainingGround(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_trainingGround);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018420 RID: 99360 RVA: 0x006C3CF8 File Offset: 0x006C1EF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_trainingGround(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			TrainingGroundCompomentCommon trainingGround;
			LuaObject.checkType<TrainingGroundCompomentCommon>(l, 2, out trainingGround);
			heroComponentCommon.m_luaExportHelper.m_trainingGround = trainingGround;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018421 RID: 99361 RVA: 0x006C3D54 File Offset: 0x006C1F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDS(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_heroDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018422 RID: 99362 RVA: 0x006C3DAC File Offset: 0x006C1FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDS(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			DataSectionHero heroDS;
			LuaObject.checkType<DataSectionHero>(l, 2, out heroDS);
			heroComponentCommon.m_luaExportHelper.m_heroDS = heroDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018423 RID: 99363 RVA: 0x006C3E08 File Offset: 0x006C2008
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SpecificHeroFightMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroComponentCommon.SpecificHeroFightMissionEvent += value;
				}
				else if (num == 2)
				{
					heroComponentCommon.SpecificHeroFightMissionEvent -= value;
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

	// Token: 0x06018424 RID: 99364 RVA: 0x006C3E88 File Offset: 0x006C2088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroNewJobTransferMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroComponentCommon.HeroNewJobTransferMissionEvent += value;
				}
				else if (num == 2)
				{
					heroComponentCommon.HeroNewJobTransferMissionEvent -= value;
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

	// Token: 0x06018425 RID: 99365 RVA: 0x006C3F08 File Offset: 0x006C2108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroJobLevelUpMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroComponentCommon.HeroJobLevelUpMissionEvent += value;
				}
				else if (num == 2)
				{
					heroComponentCommon.HeroJobLevelUpMissionEvent -= value;
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

	// Token: 0x06018426 RID: 99366 RVA: 0x006C3F88 File Offset: 0x006C2188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroJobMasterMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroComponentCommon.HeroJobMasterMissionEvent += value;
				}
				else if (num == 2)
				{
					heroComponentCommon.HeroJobMasterMissionEvent -= value;
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

	// Token: 0x06018427 RID: 99367 RVA: 0x006C4008 File Offset: 0x006C2208
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AddHeroJobMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroComponentCommon.AddHeroJobMissionEvent += value;
				}
				else if (num == 2)
				{
					heroComponentCommon.AddHeroJobMissionEvent -= value;
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

	// Token: 0x06018428 RID: 99368 RVA: 0x006C4088 File Offset: 0x006C2288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroLevelUpMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroComponentCommon.HeroLevelUpMissionEvent += value;
				}
				else if (num == 2)
				{
					heroComponentCommon.HeroLevelUpMissionEvent -= value;
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

	// Token: 0x06018429 RID: 99369 RVA: 0x006C4108 File Offset: 0x006C2308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AddHeroJobSkillMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroComponentCommon.AddHeroJobSkillMissionEvent += value;
				}
				else if (num == 2)
				{
					heroComponentCommon.AddHeroJobSkillMissionEvent -= value;
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

	// Token: 0x0601842A RID: 99370 RVA: 0x006C4188 File Offset: 0x006C2388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AddHeroJobSoliderMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroComponentCommon.AddHeroJobSoliderMissionEvent += value;
				}
				else if (num == 2)
				{
					heroComponentCommon.AddHeroJobSoliderMissionEvent -= value;
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

	// Token: 0x0601842B RID: 99371 RVA: 0x006C4208 File Offset: 0x006C2408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AddHeroMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroComponentCommon.AddHeroMissionEvent += value;
				}
				else if (num == 2)
				{
					heroComponentCommon.AddHeroMissionEvent -= value;
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

	// Token: 0x0601842C RID: 99372 RVA: 0x006C4288 File Offset: 0x006C2488
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LevelUpHeroStarLevelMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroComponentCommon.LevelUpHeroStarLevelMissionEvent += value;
				}
				else if (num == 2)
				{
					heroComponentCommon.LevelUpHeroStarLevelMissionEvent -= value;
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

	// Token: 0x0601842D RID: 99373 RVA: 0x006C4308 File Offset: 0x006C2508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_wearedEquipmentHeroDict(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_wearedEquipmentHeroDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601842E RID: 99374 RVA: 0x006C4360 File Offset: 0x006C2560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wearedEquipmentHeroDict(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Dictionary<ulong, int> wearedEquipmentHeroDict;
			LuaObject.checkType<Dictionary<ulong, int>>(l, 2, out wearedEquipmentHeroDict);
			heroComponentCommon.m_luaExportHelper.m_wearedEquipmentHeroDict = wearedEquipmentHeroDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601842F RID: 99375 RVA: 0x006C43BC File Offset: 0x006C25BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soliders(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_soliders);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018430 RID: 99376 RVA: 0x006C4414 File Offset: 0x006C2614
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soliders(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			HashSet<int> soliders;
			LuaObject.checkType<HashSet<int>>(l, 2, out soliders);
			heroComponentCommon.m_luaExportHelper.m_soliders = soliders;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018431 RID: 99377 RVA: 0x006C4470 File Offset: 0x006C2670
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_skills(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_skills);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018432 RID: 99378 RVA: 0x006C44C8 File Offset: 0x006C26C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_skills(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			HashSet<int> skills;
			LuaObject.checkType<HashSet<int>>(l, 2, out skills);
			heroComponentCommon.m_luaExportHelper.m_skills = skills;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018433 RID: 99379 RVA: 0x006C4524 File Offset: 0x006C2724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_atuoEquipmentTouch(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.m_luaExportHelper.m_atuoEquipmentTouch);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018434 RID: 99380 RVA: 0x006C457C File Offset: 0x006C277C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_atuoEquipmentTouch(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Dictionary<int, DateTime> atuoEquipmentTouch;
			LuaObject.checkType<Dictionary<int, DateTime>>(l, 2, out atuoEquipmentTouch);
			heroComponentCommon.m_luaExportHelper.m_atuoEquipmentTouch = atuoEquipmentTouch;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018435 RID: 99381 RVA: 0x006C45D8 File Offset: 0x006C27D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroFavorabilityLevelupMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action<Hero> action;
			int num = LuaObject.checkDelegate<Action<Hero>>(l, 2, out action);
			if (num == 0)
			{
				heroComponentCommon.HeroFavorabilityLevelupMissionEvent = action;
			}
			else if (num == 1)
			{
				HeroComponentCommon heroComponentCommon2 = heroComponentCommon;
				heroComponentCommon2.HeroFavorabilityLevelupMissionEvent = (Action<Hero>)Delegate.Combine(heroComponentCommon2.HeroFavorabilityLevelupMissionEvent, action);
			}
			else if (num == 2)
			{
				HeroComponentCommon heroComponentCommon3 = heroComponentCommon;
				heroComponentCommon3.HeroFavorabilityLevelupMissionEvent = (Action<Hero>)Delegate.Remove(heroComponentCommon3.HeroFavorabilityLevelupMissionEvent, action);
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

	// Token: 0x06018436 RID: 99382 RVA: 0x006C4680 File Offset: 0x006C2880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroFetterLevelupMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			Action<Hero, int> action;
			int num = LuaObject.checkDelegate<Action<Hero, int>>(l, 2, out action);
			if (num == 0)
			{
				heroComponentCommon.HeroFetterLevelupMissionEvent = action;
			}
			else if (num == 1)
			{
				HeroComponentCommon heroComponentCommon2 = heroComponentCommon;
				heroComponentCommon2.HeroFetterLevelupMissionEvent = (Action<Hero, int>)Delegate.Combine(heroComponentCommon2.HeroFetterLevelupMissionEvent, action);
			}
			else if (num == 2)
			{
				HeroComponentCommon heroComponentCommon3 = heroComponentCommon;
				heroComponentCommon3.HeroFetterLevelupMissionEvent = (Action<Hero, int>)Delegate.Remove(heroComponentCommon3.HeroFetterLevelupMissionEvent, action);
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

	// Token: 0x06018437 RID: 99383 RVA: 0x006C4728 File Offset: 0x006C2928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018438 RID: 99384 RVA: 0x006C477C File Offset: 0x006C297C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			HeroComponentCommon heroComponentCommon = (HeroComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			heroComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018439 RID: 99385 RVA: 0x006C47D4 File Offset: 0x006C29D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetProtagonistID);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsProtagonistHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsProtagonistExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.SetProtagonist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetAllStarLvlMaxHeroes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetAllStarLvlMaxHeroFragments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanHeroJobEquipSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanSelectSkillHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.SelectSkills);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.SelectSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanHeroSelectSolider);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.RemoveHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.RemoveAllHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.RemoveAllHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetAllHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.FindHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsUnlockedHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.FindHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHeroFightNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHeroAllNeedJobsAchievements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsWastefulAddExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsCurrentLevelMaxHeroLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsFullCurrentHeroExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHeroesExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanAddHeroExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHeroExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHeroExpByUseableBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.ComposeHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsLvlMaxHeroStar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.LevelUpHeroStarLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetGainHeroIds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.HasGainHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsExistSkillId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsExistSoliderId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.FindTopLevelHeroes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetActiveHeroJobRelatedIdByHeroId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GmResetHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetAdditiveHeroAddExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetAdditiveHeroFavourabilityAddExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHeroJobAchievementsAfterBattleLevelEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsJobLevelMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanLevelUpHeroJobLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanTransferHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.TransferHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsNeedUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.UnlockedHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.LevelUpHeroJobLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AutoTakeOffEquipments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanWearEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanWearEquipmentByJobAndArmy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsEquipmentWeared);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetWearedEquipmentHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.WearEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanTakeOffEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.TakeOffEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.HasBetterEquipmentByHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.HasBetterEquipmentBySlotId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanAutoEquipmentByClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanAutoEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanWearCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.WearCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanTakeOffCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.TakeOffCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanWearModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.WearModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanTakeOffModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.TakeOffModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanWearSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.WearSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanTakeOffSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.TakeOffSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.TakeOffSoldierSkinApplyToAll);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHeroFavorabilityExpByUseableBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHeroFavorabilityLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsFullFavorabilityExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanUnlockHeroFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanReachFetterUnlockCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GmLevelUpHeroFetter2SpecificLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanLevelUpHeroFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.LevelUpHeroFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.UnlockHeroFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.ConfessHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanConfessHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanInteractHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetHeroFavorabilityUpLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetAllHeroBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetLastAllHeroRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetTopHeroBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetLastTopHeroRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetChampionHeroBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetChampionHeroId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetLastChampionHeroRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.ComputeBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.OnHeroBattlePowerChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanComposeHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanLevelUpHeroStarLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetEquipedEquipments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetSkillEnergyFromConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CreateDefaultConfigHero_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.InitHeroDataByCaculate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.InitHeroJobs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHeroDefaultInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanGetHeroJobByRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHeroInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.OutPutHeroLevelUpOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.OutPutHeroUpgradeOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.OnHeroLevelUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanTransferHeroJobRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.OutPutHeroJobChangeOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.OnTransferHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.TryEquipNewSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsNeedAddAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.OutPutHeroJobUnlockOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanUnlockedHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.OutPutHeroJobLevelUpOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.InitWearedEquipments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.TakeOffEquipmentsOrNotWhenTransferHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.WearEquipmentBySlot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.TakeOffEquipmentBySlot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetWearedEquipmentBySlotId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsBetterEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.OutPutHeroFavourabilityOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GenerateFavorabilityLevelUpReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.UpdateProtagonistHeroFavorabilityLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.LevelUpHeroFetterCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.OutPutHeroFetterOpereateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GenerateFetterUnlockRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache88);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GenerateConfessionRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache89);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.FlushHeroInteractNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8A);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.InitHeroInteractNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8B);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.CanFlushHeroInteractNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8C);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsFullHeroInteractNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8D);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.AddHeroInteractNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8E);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.IsHeroInteractNumsEqualToMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache8F);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetHeroInteractId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache90);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetUnlcokJobAchievements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache91);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetHeroStarLevelUpDataFromConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache92);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.GetSkillCostFromConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache93);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__callDele_AddHeroEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache94);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__clearDele_AddHeroEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache95);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__callDele_SpecificHeroFightMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache96);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__clearDele_SpecificHeroFightMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache97);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__callDele_HeroNewJobTransferMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache98);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__clearDele_HeroNewJobTransferMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache99);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__callDele_HeroJobLevelUpMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9A);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__clearDele_HeroJobLevelUpMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9B);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__callDele_HeroJobMasterMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9C);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__clearDele_HeroJobMasterMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9D);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__callDele_AddHeroJobMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9E);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__clearDele_AddHeroJobMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cache9F);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__callDele_HeroLevelUpMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA0);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__clearDele_HeroLevelUpMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA1);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__callDele_AddHeroJobSkillMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA2);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__clearDele_AddHeroJobSkillMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA3);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__callDele_AddHeroJobSoliderMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA4);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__clearDele_AddHeroJobSoliderMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA5);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__callDele_AddHeroMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA6);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__clearDele_AddHeroMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA7);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__callDele_LevelUpHeroStarLevelMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA8);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.__clearDele_LevelUpHeroStarLevelMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheA9);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAB, true);
		string name2 = "AddHeroEvent";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_AddHeroEvent);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAC, true);
		string name3 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_bag);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAD;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAE, true);
		string name4 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_rift);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheAF;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB0, true);
		string name5 = "m_mission";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_mission);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB1;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_mission);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB2, true);
		string name6 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB3;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB4, true);
		string name7 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_battle);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB5;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB6, true);
		string name8 = "m_resource";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_resource);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB7;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_resource);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB8, true);
		string name9 = "m_guild";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_guild);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheB9;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_guild);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBA, true);
		string name10 = "m_trainingGround";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_trainingGround);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBB;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_trainingGround);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBC, true);
		string name11 = "m_heroDS";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_heroDS);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBD;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_heroDS);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBE, true);
		string name12 = "SpecificHeroFightMissionEvent";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_SpecificHeroFightMissionEvent);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheBF, true);
		string name13 = "HeroNewJobTransferMissionEvent";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_HeroNewJobTransferMissionEvent);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC0, true);
		string name14 = "HeroJobLevelUpMissionEvent";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_HeroJobLevelUpMissionEvent);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC1, true);
		string name15 = "HeroJobMasterMissionEvent";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_HeroJobMasterMissionEvent);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC2, true);
		string name16 = "AddHeroJobMissionEvent";
		LuaCSFunction get16 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_AddHeroJobMissionEvent);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC3, true);
		string name17 = "HeroLevelUpMissionEvent";
		LuaCSFunction get17 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_HeroLevelUpMissionEvent);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC4, true);
		string name18 = "AddHeroJobSkillMissionEvent";
		LuaCSFunction get18 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_AddHeroJobSkillMissionEvent);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC5, true);
		string name19 = "AddHeroJobSoliderMissionEvent";
		LuaCSFunction get19 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_AddHeroJobSoliderMissionEvent);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC6, true);
		string name20 = "AddHeroMissionEvent";
		LuaCSFunction get20 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_AddHeroMissionEvent);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC7, true);
		string name21 = "LevelUpHeroStarLevelMissionEvent";
		LuaCSFunction get21 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_LevelUpHeroStarLevelMissionEvent);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC8, true);
		string name22 = "m_wearedEquipmentHeroDict";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_wearedEquipmentHeroDict);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheC9;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_wearedEquipmentHeroDict);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCA, true);
		string name23 = "m_soliders";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_soliders);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCB;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_soliders);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCC, true);
		string name24 = "m_skills";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_skills);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCD;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_skills);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCE, true);
		string name25 = "m_atuoEquipmentTouch";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_m_atuoEquipmentTouch);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheCF;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_m_atuoEquipmentTouch);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD0, true);
		string name26 = "HeroFavorabilityLevelupMissionEvent";
		LuaCSFunction get26 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_HeroFavorabilityLevelupMissionEvent);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD1, true);
		string name27 = "HeroFetterLevelupMissionEvent";
		LuaCSFunction get27 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_HeroFetterLevelupMissionEvent);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD2, true);
		string name28 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.get_Owner);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD3;
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD4, true);
		if (Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroComponentCommon.<>f__mg$cacheD5, typeof(HeroComponentCommon));
	}

	// Token: 0x0400E8CD RID: 59597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E8CE RID: 59598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E8CF RID: 59599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E8D0 RID: 59600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E8D1 RID: 59601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E8D2 RID: 59602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E8D3 RID: 59603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E8D4 RID: 59604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E8D5 RID: 59605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E8D6 RID: 59606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E8D7 RID: 59607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E8D8 RID: 59608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E8D9 RID: 59609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E8DA RID: 59610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E8DB RID: 59611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E8DC RID: 59612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E8DD RID: 59613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E8DE RID: 59614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E8DF RID: 59615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E8E0 RID: 59616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E8E1 RID: 59617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E8E2 RID: 59618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E8E3 RID: 59619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E8E4 RID: 59620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E8E5 RID: 59621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E8E6 RID: 59622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E8E7 RID: 59623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E8E8 RID: 59624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E8E9 RID: 59625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E8EA RID: 59626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E8EB RID: 59627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E8EC RID: 59628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E8ED RID: 59629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E8EE RID: 59630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E8EF RID: 59631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E8F0 RID: 59632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E8F1 RID: 59633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E8F2 RID: 59634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E8F3 RID: 59635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E8F4 RID: 59636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E8F5 RID: 59637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400E8F6 RID: 59638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400E8F7 RID: 59639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400E8F8 RID: 59640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400E8F9 RID: 59641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400E8FA RID: 59642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400E8FB RID: 59643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400E8FC RID: 59644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400E8FD RID: 59645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400E8FE RID: 59646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400E8FF RID: 59647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400E900 RID: 59648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400E901 RID: 59649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400E902 RID: 59650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400E903 RID: 59651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400E904 RID: 59652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400E905 RID: 59653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400E906 RID: 59654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400E907 RID: 59655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400E908 RID: 59656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400E909 RID: 59657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400E90A RID: 59658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400E90B RID: 59659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400E90C RID: 59660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400E90D RID: 59661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400E90E RID: 59662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400E90F RID: 59663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400E910 RID: 59664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400E911 RID: 59665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400E912 RID: 59666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400E913 RID: 59667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400E914 RID: 59668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400E915 RID: 59669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400E916 RID: 59670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400E917 RID: 59671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400E918 RID: 59672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400E919 RID: 59673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400E91A RID: 59674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400E91B RID: 59675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400E91C RID: 59676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400E91D RID: 59677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400E91E RID: 59678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400E91F RID: 59679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400E920 RID: 59680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400E921 RID: 59681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400E922 RID: 59682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400E923 RID: 59683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400E924 RID: 59684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400E925 RID: 59685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400E926 RID: 59686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400E927 RID: 59687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400E928 RID: 59688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400E929 RID: 59689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400E92A RID: 59690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400E92B RID: 59691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400E92C RID: 59692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400E92D RID: 59693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400E92E RID: 59694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400E92F RID: 59695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400E930 RID: 59696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400E931 RID: 59697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400E932 RID: 59698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400E933 RID: 59699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400E934 RID: 59700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400E935 RID: 59701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400E936 RID: 59702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400E937 RID: 59703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400E938 RID: 59704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400E939 RID: 59705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400E93A RID: 59706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400E93B RID: 59707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400E93C RID: 59708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400E93D RID: 59709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400E93E RID: 59710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0400E93F RID: 59711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0400E940 RID: 59712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0400E941 RID: 59713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0400E942 RID: 59714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0400E943 RID: 59715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0400E944 RID: 59716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0400E945 RID: 59717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0400E946 RID: 59718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0400E947 RID: 59719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0400E948 RID: 59720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0400E949 RID: 59721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0400E94A RID: 59722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0400E94B RID: 59723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0400E94C RID: 59724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0400E94D RID: 59725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0400E94E RID: 59726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0400E94F RID: 59727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x0400E950 RID: 59728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0400E951 RID: 59729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0400E952 RID: 59730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0400E953 RID: 59731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0400E954 RID: 59732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0400E955 RID: 59733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0400E956 RID: 59734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0400E957 RID: 59735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0400E958 RID: 59736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0400E959 RID: 59737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0400E95A RID: 59738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0400E95B RID: 59739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0400E95C RID: 59740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0400E95D RID: 59741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0400E95E RID: 59742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x0400E95F RID: 59743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x0400E960 RID: 59744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x0400E961 RID: 59745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x0400E962 RID: 59746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x0400E963 RID: 59747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x0400E964 RID: 59748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0400E965 RID: 59749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0400E966 RID: 59750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0400E967 RID: 59751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0400E968 RID: 59752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0400E969 RID: 59753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0400E96A RID: 59754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0400E96B RID: 59755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x0400E96C RID: 59756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x0400E96D RID: 59757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x0400E96E RID: 59758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x0400E96F RID: 59759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x0400E970 RID: 59760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x0400E971 RID: 59761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x0400E972 RID: 59762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x0400E973 RID: 59763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x0400E974 RID: 59764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x0400E975 RID: 59765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x0400E976 RID: 59766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x0400E977 RID: 59767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x0400E978 RID: 59768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x0400E979 RID: 59769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x0400E97A RID: 59770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x0400E97B RID: 59771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x0400E97C RID: 59772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x0400E97D RID: 59773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x0400E97E RID: 59774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x0400E97F RID: 59775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x0400E980 RID: 59776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x0400E981 RID: 59777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x0400E982 RID: 59778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x0400E983 RID: 59779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x0400E984 RID: 59780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x0400E985 RID: 59781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x0400E986 RID: 59782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x0400E987 RID: 59783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x0400E988 RID: 59784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x0400E989 RID: 59785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x0400E98A RID: 59786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x0400E98B RID: 59787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x0400E98C RID: 59788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x0400E98D RID: 59789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x0400E98E RID: 59790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x0400E98F RID: 59791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x0400E990 RID: 59792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x0400E991 RID: 59793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x0400E992 RID: 59794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x0400E993 RID: 59795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x0400E994 RID: 59796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x0400E995 RID: 59797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x0400E996 RID: 59798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x0400E997 RID: 59799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x0400E998 RID: 59800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x0400E999 RID: 59801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x0400E99A RID: 59802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x0400E99B RID: 59803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x0400E99C RID: 59804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x0400E99D RID: 59805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x0400E99E RID: 59806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x0400E99F RID: 59807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x0400E9A0 RID: 59808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x0400E9A1 RID: 59809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x0400E9A2 RID: 59810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;
}
