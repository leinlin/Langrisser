using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011D1 RID: 4561
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog : LuaObject
{
	// Token: 0x06017A9F RID: 96927 RVA: 0x0068023C File Offset: 0x0067E43C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog o = new BattleRoomBattleLog();
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

	// Token: 0x06017AA0 RID: 96928 RVA: 0x00680284 File Offset: 0x0067E484
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RoomId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomBattleLog.RoomId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AA1 RID: 96929 RVA: 0x006802D8 File Offset: 0x0067E4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoomId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			ulong roomId;
			LuaObject.checkType(l, 2, out roomId);
			battleRoomBattleLog.RoomId = roomId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AA2 RID: 96930 RVA: 0x00680330 File Offset: 0x0067E530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleRoomType(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomBattleLog.BattleRoomType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AA3 RID: 96931 RVA: 0x00680384 File Offset: 0x0067E584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleRoomType(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			int battleRoomType;
			LuaObject.checkType(l, 2, out battleRoomType);
			battleRoomBattleLog.BattleRoomType = battleRoomType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AA4 RID: 96932 RVA: 0x006803DC File Offset: 0x0067E5DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomBattleLog.BattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AA5 RID: 96933 RVA: 0x00680430 File Offset: 0x0067E630
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			battleRoomBattleLog.BattleId = battleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AA6 RID: 96934 RVA: 0x00680488 File Offset: 0x0067E688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RandomNumberSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomBattleLog.RandomNumberSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AA7 RID: 96935 RVA: 0x006804DC File Offset: 0x0067E6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RandomNumberSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			int randomNumberSeed;
			LuaObject.checkType(l, 2, out randomNumberSeed);
			battleRoomBattleLog.RandomNumberSeed = randomNumberSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AA8 RID: 96936 RVA: 0x00680534 File Offset: 0x0067E734
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArmyRandomNumberSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomBattleLog.ArmyRandomNumberSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AA9 RID: 96937 RVA: 0x00680588 File Offset: 0x0067E788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArmyRandomNumberSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			int armyRandomNumberSeed;
			LuaObject.checkType(l, 2, out armyRandomNumberSeed);
			battleRoomBattleLog.ArmyRandomNumberSeed = armyRandomNumberSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AAA RID: 96938 RVA: 0x006805E0 File Offset: 0x0067E7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Team0(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomBattleLog.Team0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AAB RID: 96939 RVA: 0x00680634 File Offset: 0x0067E834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Team0(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			List<BattleActorSetup> team;
			LuaObject.checkType<List<BattleActorSetup>>(l, 2, out team);
			battleRoomBattleLog.Team0 = team;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AAC RID: 96940 RVA: 0x0068068C File Offset: 0x0067E88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Team1(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomBattleLog.Team1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AAD RID: 96941 RVA: 0x006806E0 File Offset: 0x0067E8E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Team1(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			List<BattleActorSetup> team;
			LuaObject.checkType<List<BattleActorSetup>>(l, 2, out team);
			battleRoomBattleLog.Team1 = team;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AAE RID: 96942 RVA: 0x00680738 File Offset: 0x0067E938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Players(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomBattleLog.Players);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AAF RID: 96943 RVA: 0x0068078C File Offset: 0x0067E98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Players(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomBattleLog battleRoomBattleLog = (BattleRoomBattleLog)LuaObject.checkSelf(l);
			List<BattlePlayer> players;
			LuaObject.checkType<List<BattlePlayer>>(l, 2, out players);
			battleRoomBattleLog.Players = players;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AB0 RID: 96944 RVA: 0x006807E4 File Offset: 0x0067E9E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleRoomBattleLog");
		string name = "RoomId";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.get_RoomId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.set_RoomId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache1, true);
		string name2 = "BattleRoomType";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.get_BattleRoomType);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.set_BattleRoomType);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache3, true);
		string name3 = "BattleId";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.get_BattleId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.set_BattleId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache5, true);
		string name4 = "RandomNumberSeed";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.get_RandomNumberSeed);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.set_RandomNumberSeed);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache7, true);
		string name5 = "ArmyRandomNumberSeed";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.get_ArmyRandomNumberSeed);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.set_ArmyRandomNumberSeed);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache9, true);
		string name6 = "Team0";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.get_Team0);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.set_Team0);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheB, true);
		string name7 = "Team1";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.get_Team1);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.set_Team1);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheD, true);
		string name8 = "Players";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.get_Players);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.set_Players);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cacheF, true);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.<>f__mg$cache10, typeof(BattleRoomBattleLog));
	}

	// Token: 0x0400E0DF RID: 57567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E0E0 RID: 57568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E0E1 RID: 57569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E0E2 RID: 57570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E0E3 RID: 57571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E0E4 RID: 57572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E0E5 RID: 57573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E0E6 RID: 57574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E0E7 RID: 57575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E0E8 RID: 57576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E0E9 RID: 57577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E0EA RID: 57578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E0EB RID: 57579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E0EC RID: 57580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E0ED RID: 57581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E0EE RID: 57582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E0EF RID: 57583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
