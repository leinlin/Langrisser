using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012CD RID: 4813
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment : LuaObject
{
	// Token: 0x060195FD RID: 103933 RVA: 0x0074B530 File Offset: 0x00749730
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment o = new HeroPhantomCompoment();
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

	// Token: 0x060195FE RID: 103934 RVA: 0x0074B578 File Offset: 0x00749778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			heroPhantomCompoment.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195FF RID: 103935 RVA: 0x0074B5C4 File Offset: 0x007497C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			heroPhantomCompoment.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019600 RID: 103936 RVA: 0x0074B610 File Offset: 0x00749810
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			heroPhantomCompoment.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019601 RID: 103937 RVA: 0x0074B65C File Offset: 0x0074985C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			DSHeroPhantomNtf ntf;
			LuaObject.checkType<DSHeroPhantomNtf>(l, 2, out ntf);
			heroPhantomCompoment.DeSerialize(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019602 RID: 103938 RVA: 0x0074B6B4 File Offset: 0x007498B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			ushort dsversion = heroPhantomCompoment.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019603 RID: 103939 RVA: 0x0074B708 File Offset: 0x00749908
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetSuccessHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			HeroPhantomLevel level;
			LuaObject.checkType<HeroPhantomLevel>(l, 2, out level);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 3, out heroes);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			List<int> newAchievementIds;
			LuaObject.checkType<List<int>>(l, 5, out newAchievementIds);
			heroPhantomCompoment.SetSuccessHeroPhantomLevel(level, heroes, battleTreasures, newAchievementIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019604 RID: 103940 RVA: 0x0074B788 File Offset: 0x00749988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishedHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			HeroPhantomLevel level;
			LuaObject.checkType<HeroPhantomLevel>(l, 2, out level);
			bool isWin;
			LuaObject.checkType(l, 3, out isWin);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 4, out heroes);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasures);
			List<int> achievementIds;
			LuaObject.checkType<List<int>>(l, 6, out achievementIds);
			int i = heroPhantomCompoment.FinishedHeroPhantomLevel(level, isWin, heroes, battleTreasures, achievementIds);
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

	// Token: 0x06019605 RID: 103941 RVA: 0x0074B81C File Offset: 0x00749A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			string s = heroPhantomCompoment.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x06019606 RID: 103942 RVA: 0x0074B878 File Offset: 0x00749A78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			heroPhantomCompoment.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019607 RID: 103943 RVA: 0x0074B8CC File Offset: 0x00749ACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			heroPhantomCompoment.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019608 RID: 103944 RVA: 0x0074B920 File Offset: 0x00749B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			heroPhantomCompoment.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019609 RID: 103945 RVA: 0x0074B974 File Offset: 0x00749B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			heroPhantomCompoment.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601960A RID: 103946 RVA: 0x0074B9D0 File Offset: 0x00749BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			heroPhantomCompoment.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601960B RID: 103947 RVA: 0x0074BA24 File Offset: 0x00749C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckHeroPhantomAvailable(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			int heroPhantomId;
			LuaObject.checkType(l, 2, out heroPhantomId);
			int i;
			LuaObject.checkType(l, 3, out i);
			bool b = heroPhantomCompoment.m_luaExportHelper.__callBase_CheckHeroPhantomAvailable(heroPhantomId, ref i);
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

	// Token: 0x0601960C RID: 103948 RVA: 0x0074BAA0 File Offset: 0x00749CA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CheckHeroPhantomLevelAvailable(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i;
			LuaObject.checkType(l, 3, out i);
			bool b = heroPhantomCompoment.m_luaExportHelper.__callBase_CheckHeroPhantomLevelAvailable(levelId, ref i);
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

	// Token: 0x0601960D RID: 103949 RVA: 0x0074BB1C File Offset: 0x00749D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckPlayerOutOfBattle(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			bool b = heroPhantomCompoment.m_luaExportHelper.__callBase_CheckPlayerOutOfBattle(ref i);
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

	// Token: 0x0601960E RID: 103950 RVA: 0x0074BB8C File Offset: 0x00749D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckEnergy(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i;
			LuaObject.checkType(l, 3, out i);
			bool b = heroPhantomCompoment.m_luaExportHelper.__callBase_CheckEnergy(levelId, ref i);
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

	// Token: 0x0601960F RID: 103951 RVA: 0x0074BC08 File Offset: 0x00749E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckBag(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i;
			LuaObject.checkType(l, 3, out i);
			bool b = heroPhantomCompoment.m_luaExportHelper.__callBase_CheckBag(levelId, ref i);
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

	// Token: 0x06019610 RID: 103952 RVA: 0x0074BC84 File Offset: 0x00749E84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CheckChallengeHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = heroPhantomCompoment.m_luaExportHelper.__callBase_CheckChallengeHeroPhantomLevel(levelId);
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

	// Token: 0x06019611 RID: 103953 RVA: 0x0074BCEC File Offset: 0x00749EEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ChallengeHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool noCheck;
			LuaObject.checkType(l, 3, out noCheck);
			int i = heroPhantomCompoment.m_luaExportHelper.__callBase_ChallengeHeroPhantomLevel(levelId, noCheck);
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

	// Token: 0x06019612 RID: 103954 RVA: 0x0074BD60 File Offset: 0x00749F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetCommonSuccessHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			HeroPhantomLevel level;
			LuaObject.checkType<HeroPhantomLevel>(l, 2, out level);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 3, out heroes);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			List<int> newAchievementIds;
			LuaObject.checkType<List<int>>(l, 5, out newAchievementIds);
			heroPhantomCompoment.m_luaExportHelper.__callBase_SetCommonSuccessHeroPhantomLevel(level, heroes, battleTreasures, newAchievementIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019613 RID: 103955 RVA: 0x0074BDE4 File Offset: 0x00749FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FinishedHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			HeroPhantomLevel level;
			LuaObject.checkType<HeroPhantomLevel>(l, 2, out level);
			List<int> heroes;
			LuaObject.checkType<List<int>>(l, 3, out heroes);
			heroPhantomCompoment.m_luaExportHelper.__callBase_FinishedHeroPhantomLevel(level, heroes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019614 RID: 103956 RVA: 0x0074BE50 File Offset: 0x0074A050
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetHeroPhantom(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			int heroPhantomId;
			LuaObject.checkType(l, 2, out heroPhantomId);
			HeroPhantom o = heroPhantomCompoment.m_luaExportHelper.__callBase_GetHeroPhantom(heroPhantomId);
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

	// Token: 0x06019615 RID: 103957 RVA: 0x0074BEB8 File Offset: 0x0074A0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			HeroPhantomLevel o = heroPhantomCompoment.m_luaExportHelper.__callBase_GetHeroPhantomLevel(levelId);
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

	// Token: 0x06019616 RID: 103958 RVA: 0x0074BF20 File Offset: 0x0074A120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsCompleteHeroPhantomLevelAchievement(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			int achievementRelatedInfoID;
			LuaObject.checkType(l, 2, out achievementRelatedInfoID);
			bool b = heroPhantomCompoment.m_luaExportHelper.__callBase_IsCompleteHeroPhantomLevelAchievement(achievementRelatedInfoID);
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

	// Token: 0x06019617 RID: 103959 RVA: 0x0074BF88 File Offset: 0x0074A188
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCompoment heroPhantomCompoment = (HeroPhantomCompoment)LuaObject.checkSelf(l);
			List<int> o = heroPhantomCompoment.m_luaExportHelper.__callBase_GetAllFinishedLevels();
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

	// Token: 0x06019618 RID: 103960 RVA: 0x0074BFE4 File Offset: 0x0074A1E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.HeroPhantomCompoment");
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.SetSuccessHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.FinishedHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_CheckHeroPhantomAvailable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_CheckHeroPhantomLevelAvailable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_CheckPlayerOutOfBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_CheckEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_CheckBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_CheckChallengeHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_ChallengeHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_SetCommonSuccessHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_FinishedHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_GetHeroPhantom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_GetHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_IsCompleteHeroPhantomLevelAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.__callBase_GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.<>f__mg$cache1A, typeof(HeroPhantomCompoment), typeof(HeroPhantomCompomentCommon));
	}

	// Token: 0x0400FA45 RID: 64069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400FA46 RID: 64070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400FA47 RID: 64071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400FA48 RID: 64072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400FA49 RID: 64073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400FA4A RID: 64074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400FA4B RID: 64075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400FA4C RID: 64076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400FA4D RID: 64077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400FA4E RID: 64078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400FA4F RID: 64079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400FA50 RID: 64080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400FA51 RID: 64081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400FA52 RID: 64082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400FA53 RID: 64083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400FA54 RID: 64084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400FA55 RID: 64085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400FA56 RID: 64086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400FA57 RID: 64087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400FA58 RID: 64088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400FA59 RID: 64089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400FA5A RID: 64090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400FA5B RID: 64091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400FA5C RID: 64092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400FA5D RID: 64093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400FA5E RID: 64094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400FA5F RID: 64095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
