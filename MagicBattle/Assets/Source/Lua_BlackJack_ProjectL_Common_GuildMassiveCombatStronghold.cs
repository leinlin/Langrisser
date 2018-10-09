using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001230 RID: 4656
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold : LuaObject
{
	// Token: 0x06018250 RID: 98896 RVA: 0x006B730C File Offset: 0x006B550C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold o = new GuildMassiveCombatStronghold();
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

	// Token: 0x06018251 RID: 98897 RVA: 0x006B7354 File Offset: 0x006B5554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTakenOver(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			DateTime now;
			LuaObject.checkValueType<DateTime>(l, 2, out now);
			bool b = guildMassiveCombatStronghold.IsTakenOver(now);
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

	// Token: 0x06018252 RID: 98898 RVA: 0x006B73B8 File Offset: 0x006B55B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPro(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold stronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			ProGuildMassiveCombatStrongholdInfo o = stronghold.ToPro();
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

	// Token: 0x06018253 RID: 98899 RVA: 0x006B740C File Offset: 0x006B560C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TakenOverTime(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStronghold.TakenOverTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018254 RID: 98900 RVA: 0x006B7464 File Offset: 0x006B5664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TakenOverTime(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			DateTime takenOverTime;
			LuaObject.checkValueType<DateTime>(l, 2, out takenOverTime);
			guildMassiveCombatStronghold.TakenOverTime = takenOverTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018255 RID: 98901 RVA: 0x006B74BC File Offset: 0x006B56BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreferredHeroTagIds(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStronghold.PreferredHeroTagIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018256 RID: 98902 RVA: 0x006B7510 File Offset: 0x006B5710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PreferredHeroTagIds(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			List<int> preferredHeroTagIds;
			LuaObject.checkType<List<int>>(l, 2, out preferredHeroTagIds);
			guildMassiveCombatStronghold.PreferredHeroTagIds = preferredHeroTagIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018257 RID: 98903 RVA: 0x006B7568 File Offset: 0x006B5768
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConfigId(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStronghold.ConfigId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018258 RID: 98904 RVA: 0x006B75BC File Offset: 0x006B57BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigId(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			int configId;
			LuaObject.checkType(l, 2, out configId);
			guildMassiveCombatStronghold.ConfigId = configId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018259 RID: 98905 RVA: 0x006B7614 File Offset: 0x006B5814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelId(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStronghold.LevelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601825A RID: 98906 RVA: 0x006B7668 File Offset: 0x006B5868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LevelId(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			guildMassiveCombatStronghold.LevelId = levelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601825B RID: 98907 RVA: 0x006B76C0 File Offset: 0x006B58C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RandomSeed(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStronghold.RandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601825C RID: 98908 RVA: 0x006B7714 File Offset: 0x006B5914
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RandomSeed(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			int randomSeed;
			LuaObject.checkType(l, 2, out randomSeed);
			guildMassiveCombatStronghold.RandomSeed = randomSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601825D RID: 98909 RVA: 0x006B776C File Offset: 0x006B596C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnemyEliminated(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatStronghold.EnemyEliminated);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601825E RID: 98910 RVA: 0x006B77C0 File Offset: 0x006B59C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnemyEliminated(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatStronghold guildMassiveCombatStronghold = (GuildMassiveCombatStronghold)LuaObject.checkSelf(l);
			int enemyEliminated;
			LuaObject.checkType(l, 2, out enemyEliminated);
			guildMassiveCombatStronghold.EnemyEliminated = enemyEliminated;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601825F RID: 98911 RVA: 0x006B7818 File Offset: 0x006B5A18
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GuildMassiveCombatStronghold");
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.IsTakenOver);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.ToPro);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache1);
		string name = "TakenOverTime";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.get_TakenOverTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.set_TakenOverTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache3, true);
		string name2 = "PreferredHeroTagIds";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.get_PreferredHeroTagIds);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.set_PreferredHeroTagIds);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache5, true);
		string name3 = "ConfigId";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.get_ConfigId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.set_ConfigId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache7, true);
		string name4 = "LevelId";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.get_LevelId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.set_LevelId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cache9, true);
		string name5 = "RandomSeed";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.get_RandomSeed);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.set_RandomSeed);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheB, true);
		string name6 = "EnemyEliminated";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.get_EnemyEliminated);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.set_EnemyEliminated);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheD, true);
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.<>f__mg$cacheE, typeof(GuildMassiveCombatStronghold));
	}

	// Token: 0x0400E7D2 RID: 59346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E7D3 RID: 59347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E7D4 RID: 59348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E7D5 RID: 59349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E7D6 RID: 59350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E7D7 RID: 59351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E7D8 RID: 59352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E7D9 RID: 59353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E7DA RID: 59354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E7DB RID: 59355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E7DC RID: 59356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E7DD RID: 59357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E7DE RID: 59358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E7DF RID: 59359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E7E0 RID: 59360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
