using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001245 RID: 4677
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon : LuaObject
{
	// Token: 0x060184C6 RID: 99526 RVA: 0x006CA534 File Offset: 0x006C8734
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon o = new HeroPhantomCompomentCommon();
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

	// Token: 0x060184C7 RID: 99527 RVA: 0x006CA57C File Offset: 0x006C877C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			string name = heroPhantomCompomentCommon.GetName();
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

	// Token: 0x060184C8 RID: 99528 RVA: 0x006CA5D0 File Offset: 0x006C87D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			heroPhantomCompomentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184C9 RID: 99529 RVA: 0x006CA61C File Offset: 0x006C881C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			heroPhantomCompomentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184CA RID: 99530 RVA: 0x006CA668 File Offset: 0x006C8868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			heroPhantomCompomentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184CB RID: 99531 RVA: 0x006CA6B4 File Offset: 0x006C88B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			heroPhantomCompomentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184CC RID: 99532 RVA: 0x006CA70C File Offset: 0x006C890C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			heroPhantomCompomentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184CD RID: 99533 RVA: 0x006CA758 File Offset: 0x006C8958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckHeroPhantomAvailable(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			int heroPhantomId;
			LuaObject.checkType(l, 2, out heroPhantomId);
			int i;
			LuaObject.checkType(l, 3, out i);
			bool b = heroPhantomCompomentCommon.CheckHeroPhantomAvailable(heroPhantomId, ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184CE RID: 99534 RVA: 0x006CA7D0 File Offset: 0x006C89D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckHeroPhantomLevelAvailable(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i;
			LuaObject.checkType(l, 3, out i);
			bool b = heroPhantomCompomentCommon.CheckHeroPhantomLevelAvailable(levelId, ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184CF RID: 99535 RVA: 0x006CA848 File Offset: 0x006C8A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckPlayerOutOfBattle(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			bool b = heroPhantomCompomentCommon.CheckPlayerOutOfBattle(ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184D0 RID: 99536 RVA: 0x006CA8B4 File Offset: 0x006C8AB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckEnergy(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i;
			LuaObject.checkType(l, 3, out i);
			bool b = heroPhantomCompomentCommon.CheckEnergy(levelId, ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184D1 RID: 99537 RVA: 0x006CA92C File Offset: 0x006C8B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckBag(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i;
			LuaObject.checkType(l, 3, out i);
			bool b = heroPhantomCompomentCommon.CheckBag(levelId, ref i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184D2 RID: 99538 RVA: 0x006CA9A4 File Offset: 0x006C8BA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckChallengeHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroPhantomCompomentCommon.CheckChallengeHeroPhantomLevel(levelId);
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

	// Token: 0x060184D3 RID: 99539 RVA: 0x006CAA08 File Offset: 0x006C8C08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChallengeHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool noCheck;
			LuaObject.checkType(l, 3, out noCheck);
			int i = heroPhantomCompomentCommon.ChallengeHeroPhantomLevel(levelId, noCheck);
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

	// Token: 0x060184D4 RID: 99540 RVA: 0x006CAA78 File Offset: 0x006C8C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCommonSuccessHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			HeroPhantomLevel level;
			LuaObject.checkType<HeroPhantomLevel>(l, 2, out level);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 3, out heroes);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			List<int> newAchievementIds;
			LuaObject.checkType<List<int>>(l, 5, out newAchievementIds);
			heroPhantomCompomentCommon.SetCommonSuccessHeroPhantomLevel(level, heroes, battleTreasures, newAchievementIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184D5 RID: 99541 RVA: 0x006CAAF8 File Offset: 0x006C8CF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHeroPhantom(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			int heroPhantomId;
			LuaObject.checkType(l, 2, out heroPhantomId);
			HeroPhantom heroPhantom = heroPhantomCompomentCommon.GetHeroPhantom(heroPhantomId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184D6 RID: 99542 RVA: 0x006CAB5C File Offset: 0x006C8D5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			HeroPhantomLevel heroPhantomLevel = heroPhantomCompomentCommon.GetHeroPhantomLevel(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184D7 RID: 99543 RVA: 0x006CABC0 File Offset: 0x006C8DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCompleteHeroPhantomLevelAchievement(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			int achievementRelatedInfoID;
			LuaObject.checkType(l, 2, out achievementRelatedInfoID);
			bool b = heroPhantomCompomentCommon.IsCompleteHeroPhantomLevelAchievement(achievementRelatedInfoID);
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

	// Token: 0x060184D8 RID: 99544 RVA: 0x006CAC24 File Offset: 0x006C8E24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			List<int> allFinishedLevels = heroPhantomCompomentCommon.GetAllFinishedLevels();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allFinishedLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184D9 RID: 99545 RVA: 0x006CAC78 File Offset: 0x006C8E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishedHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			HeroPhantomLevel level;
			LuaObject.checkType<HeroPhantomLevel>(l, 2, out level);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 3, out heroes);
			heroPhantomCompomentCommon.m_luaExportHelper.FinishedHeroPhantomLevel(level, heroes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184DA RID: 99546 RVA: 0x006CACE4 File Offset: 0x006C8EE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_CompleteHeroPhantomMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			heroPhantomCompomentCommon.m_luaExportHelper.__callDele_CompleteHeroPhantomMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184DB RID: 99547 RVA: 0x006CAD5C File Offset: 0x006C8F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_CompleteHeroPhantomMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			List<int> arg3;
			LuaObject.checkType<List<int>>(l, 4, out arg3);
			heroPhantomCompomentCommon.m_luaExportHelper.__clearDele_CompleteHeroPhantomMissionEvent(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184DC RID: 99548 RVA: 0x006CADD4 File Offset: 0x006C8FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_GetBattleAchievementMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroPhantomCompomentCommon.m_luaExportHelper.__callDele_GetBattleAchievementMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184DD RID: 99549 RVA: 0x006CAE30 File Offset: 0x006C9030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_GetBattleAchievementMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroPhantomCompomentCommon.m_luaExportHelper.__clearDele_GetBattleAchievementMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184DE RID: 99550 RVA: 0x006CAE8C File Offset: 0x006C908C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomCompomentCommon.m_luaExportHelper._configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184DF RID: 99551 RVA: 0x006CAEE4 File Offset: 0x006C90E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroPhantomCompomentCommon.m_luaExportHelper._configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184E0 RID: 99552 RVA: 0x006CAF40 File Offset: 0x006C9140
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroPhantomDS(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomCompomentCommon.m_luaExportHelper.m_heroPhantomDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184E1 RID: 99553 RVA: 0x006CAF98 File Offset: 0x006C9198
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroPhantomDS(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			DataSectionHeroPhantom heroPhantomDS;
			LuaObject.checkType<DataSectionHeroPhantom>(l, 2, out heroPhantomDS);
			heroPhantomCompomentCommon.m_luaExportHelper.m_heroPhantomDS = heroPhantomDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184E2 RID: 99554 RVA: 0x006CAFF4 File Offset: 0x006C91F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomCompomentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184E3 RID: 99555 RVA: 0x006CB04C File Offset: 0x006C924C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			heroPhantomCompomentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184E4 RID: 99556 RVA: 0x006CB0A8 File Offset: 0x006C92A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomCompomentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184E5 RID: 99557 RVA: 0x006CB100 File Offset: 0x006C9300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			heroPhantomCompomentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184E6 RID: 99558 RVA: 0x006CB15C File Offset: 0x006C935C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomCompomentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184E7 RID: 99559 RVA: 0x006CB1B4 File Offset: 0x006C93B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			heroPhantomCompomentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184E8 RID: 99560 RVA: 0x006CB210 File Offset: 0x006C9410
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomCompomentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184E9 RID: 99561 RVA: 0x006CB268 File Offset: 0x006C9468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			heroPhantomCompomentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184EA RID: 99562 RVA: 0x006CB2C4 File Offset: 0x006C94C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomCompomentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184EB RID: 99563 RVA: 0x006CB31C File Offset: 0x006C951C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			heroPhantomCompomentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184EC RID: 99564 RVA: 0x006CB378 File Offset: 0x006C9578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CompleteHeroPhantomMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			Action<BattleType, int, List<int>> value;
			int num = LuaObject.checkDelegate<Action<BattleType, int, List<int>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroPhantomCompomentCommon.CompleteHeroPhantomMissionEvent += value;
				}
				else if (num == 2)
				{
					heroPhantomCompomentCommon.CompleteHeroPhantomMissionEvent -= value;
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

	// Token: 0x060184ED RID: 99565 RVA: 0x006CB3F8 File Offset: 0x006C95F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GetBattleAchievementMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroPhantomCompomentCommon.GetBattleAchievementMissionEvent += value;
				}
				else if (num == 2)
				{
					heroPhantomCompomentCommon.GetBattleAchievementMissionEvent -= value;
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

	// Token: 0x060184EE RID: 99566 RVA: 0x006CB478 File Offset: 0x006C9678
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomCompomentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184EF RID: 99567 RVA: 0x006CB4CC File Offset: 0x006C96CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			heroPhantomCompomentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184F0 RID: 99568 RVA: 0x006CB524 File Offset: 0x006C9724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomCompomentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184F1 RID: 99569 RVA: 0x006CB57C File Offset: 0x006C977C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompomentCommon heroPhantomCompomentCommon = (HeroPhantomCompomentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroPhantomCompomentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184F2 RID: 99570 RVA: 0x006CB5D8 File Offset: 0x006C97D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroPhantomCompomentCommon");
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.CheckHeroPhantomAvailable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.CheckHeroPhantomLevelAvailable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.CheckPlayerOutOfBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.CheckEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.CheckBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.CheckChallengeHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.ChallengeHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.SetCommonSuccessHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.GetHeroPhantom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.GetHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.IsCompleteHeroPhantomLevelAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.FinishedHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.__callDele_CompleteHeroPhantomMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.__clearDele_CompleteHeroPhantomMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.__callDele_GetBattleAchievementMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.__clearDele_GetBattleAchievementMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache16);
		string name = "_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.get__configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.set__configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache18, true);
		string name2 = "m_heroPhantomDS";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.get_m_heroPhantomDS);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.set_m_heroPhantomDS);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1A, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1C, true);
		string name4 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.get_m_battle);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1E, true);
		string name5 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.get_m_bag);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache20, true);
		string name6 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.get_m_hero);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache22, true);
		string name7 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.get_m_rift);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache24, true);
		string name8 = "CompleteHeroPhantomMissionEvent";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.set_CompleteHeroPhantomMissionEvent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache25, true);
		string name9 = "GetBattleAchievementMissionEvent";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.set_GetBattleAchievementMissionEvent);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache26, true);
		string name10 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.get_Owner);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.set_Owner);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache28, true);
		string name11 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache2A, true);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.<>f__mg$cache2B, typeof(HeroPhantomCompomentCommon));
	}

	// Token: 0x0400EA1E RID: 59934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EA1F RID: 59935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EA20 RID: 59936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EA21 RID: 59937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EA22 RID: 59938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EA23 RID: 59939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EA24 RID: 59940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EA25 RID: 59941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EA26 RID: 59942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EA27 RID: 59943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EA28 RID: 59944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EA29 RID: 59945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EA2A RID: 59946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EA2B RID: 59947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EA2C RID: 59948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EA2D RID: 59949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EA2E RID: 59950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EA2F RID: 59951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EA30 RID: 59952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EA31 RID: 59953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EA32 RID: 59954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EA33 RID: 59955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EA34 RID: 59956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EA35 RID: 59957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EA36 RID: 59958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EA37 RID: 59959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EA38 RID: 59960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EA39 RID: 59961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EA3A RID: 59962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EA3B RID: 59963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EA3C RID: 59964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EA3D RID: 59965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EA3E RID: 59966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EA3F RID: 59967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EA40 RID: 59968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EA41 RID: 59969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EA42 RID: 59970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EA43 RID: 59971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400EA44 RID: 59972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400EA45 RID: 59973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400EA46 RID: 59974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400EA47 RID: 59975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400EA48 RID: 59976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400EA49 RID: 59977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
