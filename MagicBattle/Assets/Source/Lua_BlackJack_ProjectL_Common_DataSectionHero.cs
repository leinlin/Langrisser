using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011FF RID: 4607
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionHero : LuaObject
{
	// Token: 0x06017E3D RID: 97853 RVA: 0x00699DF8 File Offset: 0x00697FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero o = new DataSectionHero();
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

	// Token: 0x06017E3E RID: 97854 RVA: 0x00699E40 File Offset: 0x00698040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			dataSectionHero.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E3F RID: 97855 RVA: 0x00699E8C File Offset: 0x0069808C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			object o = dataSectionHero.SerializeToClient();
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

	// Token: 0x06017E40 RID: 97856 RVA: 0x00699EE0 File Offset: 0x006980E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddHeroFightNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			dataSectionHero.AddHeroFightNums(hero, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E41 RID: 97857 RVA: 0x00699F44 File Offset: 0x00698144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHero(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int starLevel;
			LuaObject.checkType(l, 3, out starLevel);
			Hero o = dataSectionHero.AddHero(heroId, starLevel);
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

	// Token: 0x06017E42 RID: 97858 RVA: 0x00699FB4 File Offset: 0x006981B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitHero(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			dataSectionHero.InitHero(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E43 RID: 97859 RVA: 0x0069A00C File Offset: 0x0069820C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveHero(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			dataSectionHero.RemoveHero(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E44 RID: 97860 RVA: 0x0069A064 File Offset: 0x00698264
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ReplaceHero(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero oldHero;
			LuaObject.checkType<Hero>(l, 2, out oldHero);
			Hero newHero;
			LuaObject.checkType<Hero>(l, 3, out newHero);
			bool b = dataSectionHero.ReplaceHero(oldHero, newHero);
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

	// Token: 0x06017E45 RID: 97861 RVA: 0x0069A0D4 File Offset: 0x006982D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAllHeros(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			dataSectionHero.RemoveAllHeros();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E46 RID: 97862 RVA: 0x0069A120 File Offset: 0x00698320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindHero(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			Hero o = dataSectionHero.FindHero(heroId);
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

	// Token: 0x06017E47 RID: 97863 RVA: 0x0069A184 File Offset: 0x00698384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedAddAchievement(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			bool b = dataSectionHero.IsNeedAddAchievement(hero);
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

	// Token: 0x06017E48 RID: 97864 RVA: 0x0069A1E8 File Offset: 0x006983E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroDirty(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero heroDirty;
			LuaObject.checkType<Hero>(l, 2, out heroDirty);
			dataSectionHero.SetHeroDirty(heroDirty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E49 RID: 97865 RVA: 0x0069A240 File Offset: 0x00698440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroJob(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			dataSectionHero.AddHeroJob(hero, jobRelatedId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E4A RID: 97866 RVA: 0x0069A2A4 File Offset: 0x006984A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindHeroJob(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			HeroJob o = dataSectionHero.FindHeroJob(hero, jobRelatedId);
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

	// Token: 0x06017E4B RID: 97867 RVA: 0x0069A314 File Offset: 0x00698514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnlockHeroJob(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			dataSectionHero.UnlockHeroJob(hero, jobRelatedId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E4C RID: 97868 RVA: 0x0069A378 File Offset: 0x00698578
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddHeroJobAchievements(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			HeroJob heroJob;
			LuaObject.checkType<HeroJob>(l, 2, out heroJob);
			List<int> achievements;
			LuaObject.checkType<List<int>>(l, 3, out achievements);
			dataSectionHero.AddHeroJobAchievements(heroJob, achievements);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E4D RID: 97869 RVA: 0x0069A3DC File Offset: 0x006985DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActiveHeroJob(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			dataSectionHero.ActiveHeroJob(hero, jobRelatedId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E4E RID: 97870 RVA: 0x0069A440 File Offset: 0x00698640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHeroExp(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int exp;
			LuaObject.checkType(l, 3, out exp);
			dataSectionHero.SetHeroExp(hero, exp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E4F RID: 97871 RVA: 0x0069A4A4 File Offset: 0x006986A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int level;
			LuaObject.checkType(l, 3, out level);
			dataSectionHero.AddHeroLevel(hero, level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E50 RID: 97872 RVA: 0x0069A508 File Offset: 0x00698708
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddHeroStarLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int starLevel;
			LuaObject.checkType(l, 3, out starLevel);
			dataSectionHero.AddHeroStarLevel(hero, starLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E51 RID: 97873 RVA: 0x0069A56C File Offset: 0x0069876C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectSkills(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			List<int> skills;
			LuaObject.checkType<List<int>>(l, 3, out skills);
			dataSectionHero.SelectSkills(hero, skills);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E52 RID: 97874 RVA: 0x0069A5D0 File Offset: 0x006987D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SelectSolider(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int soliderId;
			LuaObject.checkType(l, 3, out soliderId);
			dataSectionHero.SelectSolider(hero, soliderId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E53 RID: 97875 RVA: 0x0069A634 File Offset: 0x00698834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSkill(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int skillId;
			LuaObject.checkType(l, 3, out skillId);
			dataSectionHero.AddSkill(hero, skillId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E54 RID: 97876 RVA: 0x0069A698 File Offset: 0x00698898
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddSoldier(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			dataSectionHero.AddSoldier(hero, soldierId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E55 RID: 97877 RVA: 0x0069A6FC File Offset: 0x006988FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LevelUpHeroJobLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			HeroJob heroJob;
			LuaObject.checkType<HeroJob>(l, 3, out heroJob);
			dataSectionHero.LevelUpHeroJobLevel(hero, heroJob);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E56 RID: 97878 RVA: 0x0069A760 File Offset: 0x00698960
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllHeroes(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			List<Hero> allHeroes = dataSectionHero.GetAllHeroes();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allHeroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E57 RID: 97879 RVA: 0x0069A7B4 File Offset: 0x006989B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitProtagonist(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			int protagonist;
			LuaObject.checkType(l, 2, out protagonist);
			dataSectionHero.InitProtagonist(protagonist);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E58 RID: 97880 RVA: 0x0069A80C File Offset: 0x00698A0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetProtagonist(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			int protagonist;
			LuaObject.checkType(l, 2, out protagonist);
			dataSectionHero.SetProtagonist(protagonist);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E59 RID: 97881 RVA: 0x0069A864 File Offset: 0x00698A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroFavorabilityLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int level;
			LuaObject.checkType(l, 3, out level);
			dataSectionHero.SetHeroFavorabilityLevel(hero, level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E5A RID: 97882 RVA: 0x0069A8C8 File Offset: 0x00698AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroFavorabilityLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int addLevel;
			LuaObject.checkType(l, 3, out addLevel);
			dataSectionHero.AddHeroFavorabilityLevel(hero, addLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E5B RID: 97883 RVA: 0x0069A92C File Offset: 0x00698B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroFavorabilityExp(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int exp;
			LuaObject.checkType(l, 3, out exp);
			dataSectionHero.SetHeroFavorabilityExp(hero, exp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E5C RID: 97884 RVA: 0x0069A990 File Offset: 0x00698B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnlockHeroFetter(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			dataSectionHero.UnlockHeroFetter(hero, fetterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E5D RID: 97885 RVA: 0x0069A9F4 File Offset: 0x00698BF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ConfessHero(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			dataSectionHero.ConfessHero(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E5E RID: 97886 RVA: 0x0069AA4C File Offset: 0x00698C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LevelUpHeroFetter(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			dataSectionHero.LevelUpHeroFetter(hero, fetterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E5F RID: 97887 RVA: 0x0069AAB0 File Offset: 0x00698CB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanInteractHero(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			bool b = dataSectionHero.CanInteractHero();
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

	// Token: 0x06017E60 RID: 97888 RVA: 0x0069AB04 File Offset: 0x00698D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitHeroInteractNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			dataSectionHero.InitHeroInteractNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E61 RID: 97889 RVA: 0x0069AB5C File Offset: 0x00698D5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitAllHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			int power;
			LuaObject.checkType(l, 2, out power);
			DateTime updateTime;
			LuaObject.checkValueType<DateTime>(l, 3, out updateTime);
			int lastRank;
			LuaObject.checkType(l, 4, out lastRank);
			DateTime lastUpdateTime;
			LuaObject.checkValueType<DateTime>(l, 5, out lastUpdateTime);
			dataSectionHero.InitAllHeroBattlePower(power, updateTime, lastRank, lastUpdateTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E62 RID: 97890 RVA: 0x0069ABDC File Offset: 0x00698DDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitTopHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			int power;
			LuaObject.checkType(l, 2, out power);
			DateTime updateTime;
			LuaObject.checkValueType<DateTime>(l, 3, out updateTime);
			int powerThreshold;
			LuaObject.checkType(l, 4, out powerThreshold);
			int lastRank;
			LuaObject.checkType(l, 5, out lastRank);
			dataSectionHero.InitTopHeroBattlePower(power, updateTime, powerThreshold, lastRank);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E63 RID: 97891 RVA: 0x0069AC5C File Offset: 0x00698E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitChampionHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			int power;
			LuaObject.checkType(l, 2, out power);
			DateTime updateTime;
			LuaObject.checkValueType<DateTime>(l, 3, out updateTime);
			int heroId;
			LuaObject.checkType(l, 4, out heroId);
			int lastRank;
			LuaObject.checkType(l, 5, out lastRank);
			dataSectionHero.InitChampionHeroBattlePower(power, updateTime, heroId, lastRank);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E64 RID: 97892 RVA: 0x0069ACDC File Offset: 0x00698EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroInteractNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			int heroInteractNums;
			LuaObject.checkType(l, 2, out heroInteractNums);
			dataSectionHero.SetHeroInteractNums(heroInteractNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E65 RID: 97893 RVA: 0x0069AD34 File Offset: 0x00698F34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHeroInteractNumsFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			DateTime heroInteractNumsFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out heroInteractNumsFlushTime);
			dataSectionHero.SetHeroInteractNumsFlushTime(heroInteractNumsFlushTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E66 RID: 97894 RVA: 0x0069AD8C File Offset: 0x00698F8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitHeroInteractNumsFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			DateTime time;
			LuaObject.checkValueType<DateTime>(l, 2, out time);
			dataSectionHero.InitHeroInteractNumsFlushTime(time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E67 RID: 97895 RVA: 0x0069ADE4 File Offset: 0x00698FE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHeroBattlePowerChange(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			DateTime time;
			LuaObject.checkValueType<DateTime>(l, 2, out time);
			Hero hero;
			LuaObject.checkType<Hero>(l, 3, out hero);
			dataSectionHero.OnHeroBattlePowerChange(time, hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E68 RID: 97896 RVA: 0x0069AE48 File Offset: 0x00699048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroInteractNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.HeroInteractNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E69 RID: 97897 RVA: 0x0069AE9C File Offset: 0x0069909C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroInteractNumsFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.HeroInteractNumsFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E6A RID: 97898 RVA: 0x0069AEF4 File Offset: 0x006990F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroInteractNumsFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			DateTime heroInteractNumsFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out heroInteractNumsFlushTime);
			dataSectionHero.HeroInteractNumsFlushTime = heroInteractNumsFlushTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E6B RID: 97899 RVA: 0x0069AF4C File Offset: 0x0069914C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GainHeroIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.GainHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E6C RID: 97900 RVA: 0x0069AFA0 File Offset: 0x006991A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GainHeroIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			HashSet<int> gainHeroIds;
			LuaObject.checkType<HashSet<int>>(l, 2, out gainHeroIds);
			dataSectionHero.GainHeroIds = gainHeroIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E6D RID: 97901 RVA: 0x0069AFF8 File Offset: 0x006991F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Heroes(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.Heroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E6E RID: 97902 RVA: 0x0069B04C File Offset: 0x0069924C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Heroes(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			HeroUpdateCache heroes;
			LuaObject.checkType<HeroUpdateCache>(l, 2, out heroes);
			dataSectionHero.Heroes = heroes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E6F RID: 97903 RVA: 0x0069B0A4 File Offset: 0x006992A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ProtagonistID(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.ProtagonistID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E70 RID: 97904 RVA: 0x0069B0F8 File Offset: 0x006992F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AllHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.AllHeroBattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E71 RID: 97905 RVA: 0x0069B14C File Offset: 0x0069934C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AllHeroBattlePowerUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.AllHeroBattlePowerUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E72 RID: 97906 RVA: 0x0069B1A4 File Offset: 0x006993A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AllHeroBattlePowerUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			DateTime allHeroBattlePowerUpdateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out allHeroBattlePowerUpdateTime);
			dataSectionHero.AllHeroBattlePowerUpdateTime = allHeroBattlePowerUpdateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E73 RID: 97907 RVA: 0x0069B1FC File Offset: 0x006993FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LastAllHeroRank(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.LastAllHeroRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E74 RID: 97908 RVA: 0x0069B250 File Offset: 0x00699450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LastAllHeroRank(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			int lastAllHeroRank;
			LuaObject.checkType(l, 2, out lastAllHeroRank);
			dataSectionHero.LastAllHeroRank = lastAllHeroRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E75 RID: 97909 RVA: 0x0069B2A8 File Offset: 0x006994A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TopHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.TopHeroBattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E76 RID: 97910 RVA: 0x0069B2FC File Offset: 0x006994FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TopHeroBattlePowerUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.TopHeroBattlePowerUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E77 RID: 97911 RVA: 0x0069B354 File Offset: 0x00699554
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TopHeroBattlePowerUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			DateTime topHeroBattlePowerUpdateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out topHeroBattlePowerUpdateTime);
			dataSectionHero.TopHeroBattlePowerUpdateTime = topHeroBattlePowerUpdateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E78 RID: 97912 RVA: 0x0069B3AC File Offset: 0x006995AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LastTopHeroRank(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.LastTopHeroRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E79 RID: 97913 RVA: 0x0069B400 File Offset: 0x00699600
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LastTopHeroRank(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			int lastTopHeroRank;
			LuaObject.checkType(l, 2, out lastTopHeroRank);
			dataSectionHero.LastTopHeroRank = lastTopHeroRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E7A RID: 97914 RVA: 0x0069B458 File Offset: 0x00699658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChampionHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.ChampionHeroBattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E7B RID: 97915 RVA: 0x0069B4AC File Offset: 0x006996AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChampionHeroId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.ChampionHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E7C RID: 97916 RVA: 0x0069B500 File Offset: 0x00699700
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChampionHeroBattlePowerUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.ChampionHeroBattlePowerUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E7D RID: 97917 RVA: 0x0069B558 File Offset: 0x00699758
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ChampionHeroBattlePowerUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			DateTime championHeroBattlePowerUpdateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out championHeroBattlePowerUpdateTime);
			dataSectionHero.ChampionHeroBattlePowerUpdateTime = championHeroBattlePowerUpdateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E7E RID: 97918 RVA: 0x0069B5B0 File Offset: 0x006997B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LastChampionHeroRank(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.LastChampionHeroRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E7F RID: 97919 RVA: 0x0069B604 File Offset: 0x00699804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LastChampionHeroRank(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			int lastChampionHeroRank;
			LuaObject.checkType(l, 2, out lastChampionHeroRank);
			dataSectionHero.LastChampionHeroRank = lastChampionHeroRank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E80 RID: 97920 RVA: 0x0069B65C File Offset: 0x0069985C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastHeroRankUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.LastHeroRankUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E81 RID: 97921 RVA: 0x0069B6B4 File Offset: 0x006998B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LastHeroRankUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			DateTime lastHeroRankUpdateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out lastHeroRankUpdateTime);
			dataSectionHero.LastHeroRankUpdateTime = lastHeroRankUpdateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E82 RID: 97922 RVA: 0x0069B70C File Offset: 0x0069990C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TopBattlePowerThreshold(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHero dataSectionHero = (DataSectionHero)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHero.TopBattlePowerThreshold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E83 RID: 97923 RVA: 0x0069B760 File Offset: 0x00699960
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionHero");
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.AddHeroFightNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.AddHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.InitHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.RemoveHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.ReplaceHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.RemoveAllHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.FindHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.IsNeedAddAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.SetHeroDirty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.AddHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.FindHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.UnlockHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.AddHeroJobAchievements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.ActiveHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.SetHeroExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.AddHeroLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.AddHeroStarLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.SelectSkills);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.SelectSolider);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.AddSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.AddSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.LevelUpHeroJobLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.GetAllHeroes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.InitProtagonist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.SetProtagonist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.SetHeroFavorabilityLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.AddHeroFavorabilityLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.SetHeroFavorabilityExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.UnlockHeroFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.ConfessHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.LevelUpHeroFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.CanInteractHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.InitHeroInteractNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.InitAllHeroBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.InitTopHeroBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.InitChampionHeroBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.SetHeroInteractNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.SetHeroInteractNumsFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.InitHeroInteractNumsFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.OnHeroBattlePowerChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache29);
		string name = "HeroInteractNums";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_HeroInteractNums);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2A, null, true);
		string name2 = "HeroInteractNumsFlushTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_HeroInteractNumsFlushTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.set_HeroInteractNumsFlushTime);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2C, true);
		string name3 = "GainHeroIds";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_GainHeroIds);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.set_GainHeroIds);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2E, true);
		string name4 = "Heroes";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_Heroes);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.set_Heroes);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache30, true);
		string name5 = "ProtagonistID";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_ProtagonistID);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache31, null, true);
		string name6 = "AllHeroBattlePower";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_AllHeroBattlePower);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache32, null, true);
		string name7 = "AllHeroBattlePowerUpdateTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_AllHeroBattlePowerUpdateTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.set_AllHeroBattlePowerUpdateTime);
		}
		LuaObject.addMember(l, name7, get4, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache34, true);
		string name8 = "LastAllHeroRank";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_LastAllHeroRank);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.set_LastAllHeroRank);
		}
		LuaObject.addMember(l, name8, get5, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache36, true);
		string name9 = "TopHeroBattlePower";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_TopHeroBattlePower);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache37, null, true);
		string name10 = "TopHeroBattlePowerUpdateTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_TopHeroBattlePowerUpdateTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.set_TopHeroBattlePowerUpdateTime);
		}
		LuaObject.addMember(l, name10, get6, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache39, true);
		string name11 = "LastTopHeroRank";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_LastTopHeroRank);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.set_LastTopHeroRank);
		}
		LuaObject.addMember(l, name11, get7, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3B, true);
		string name12 = "ChampionHeroBattlePower";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_ChampionHeroBattlePower);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3C, null, true);
		string name13 = "ChampionHeroId";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_ChampionHeroId);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3D, null, true);
		string name14 = "ChampionHeroBattlePowerUpdateTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_ChampionHeroBattlePowerUpdateTime);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.set_ChampionHeroBattlePowerUpdateTime);
		}
		LuaObject.addMember(l, name14, get8, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache3F, true);
		string name15 = "LastChampionHeroRank";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_LastChampionHeroRank);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.set_LastChampionHeroRank);
		}
		LuaObject.addMember(l, name15, get9, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache41, true);
		string name16 = "LastHeroRankUpdateTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_LastHeroRankUpdateTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.set_LastHeroRankUpdateTime);
		}
		LuaObject.addMember(l, name16, get10, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache43, true);
		string name17 = "TopBattlePowerThreshold";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.get_TopBattlePowerThreshold);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache44, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHero.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionHero.<>f__mg$cache45, typeof(DataSectionHero), typeof(DataSection));
	}

	// Token: 0x0400E421 RID: 58401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E422 RID: 58402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E423 RID: 58403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E424 RID: 58404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E425 RID: 58405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E426 RID: 58406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E427 RID: 58407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E428 RID: 58408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E429 RID: 58409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E42A RID: 58410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E42B RID: 58411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E42C RID: 58412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E42D RID: 58413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E42E RID: 58414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E42F RID: 58415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E430 RID: 58416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E431 RID: 58417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E432 RID: 58418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E433 RID: 58419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E434 RID: 58420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E435 RID: 58421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E436 RID: 58422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E437 RID: 58423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E438 RID: 58424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E439 RID: 58425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E43A RID: 58426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E43B RID: 58427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E43C RID: 58428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E43D RID: 58429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E43E RID: 58430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E43F RID: 58431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E440 RID: 58432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E441 RID: 58433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E442 RID: 58434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E443 RID: 58435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E444 RID: 58436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E445 RID: 58437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E446 RID: 58438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E447 RID: 58439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E448 RID: 58440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E449 RID: 58441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400E44A RID: 58442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400E44B RID: 58443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400E44C RID: 58444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400E44D RID: 58445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400E44E RID: 58446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400E44F RID: 58447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400E450 RID: 58448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400E451 RID: 58449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400E452 RID: 58450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400E453 RID: 58451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400E454 RID: 58452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400E455 RID: 58453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400E456 RID: 58454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400E457 RID: 58455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400E458 RID: 58456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400E459 RID: 58457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400E45A RID: 58458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400E45B RID: 58459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400E45C RID: 58460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400E45D RID: 58461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400E45E RID: 58462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400E45F RID: 58463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400E460 RID: 58464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400E461 RID: 58465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400E462 RID: 58466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400E463 RID: 58467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400E464 RID: 58468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400E465 RID: 58469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400E466 RID: 58470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;
}
