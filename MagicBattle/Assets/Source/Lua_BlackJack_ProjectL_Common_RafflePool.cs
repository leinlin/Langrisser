using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001261 RID: 4705
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RafflePool : LuaObject
{
	// Token: 0x0601889E RID: 100510 RVA: 0x006E7C04 File Offset: 0x006E5E04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			RafflePool o = new RafflePool(poolId);
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

	// Token: 0x0601889F RID: 100511 RVA: 0x006E7C58 File Offset: 0x006E5E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Drawed(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			int darwedRaffleId;
			LuaObject.checkType(l, 2, out darwedRaffleId);
			rafflePool.Drawed(darwedRaffleId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188A0 RID: 100512 RVA: 0x006E7CB0 File Offset: 0x006E5EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RafflePools2PbActivityRafflePools_s(IntPtr l)
	{
		int result;
		try
		{
			List<RafflePool> rafflePools;
			LuaObject.checkType<List<RafflePool>>(l, 1, out rafflePools);
			List<ProRafflePool> o = RafflePool.RafflePools2PbActivityRafflePools(rafflePools);
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

	// Token: 0x060188A1 RID: 100513 RVA: 0x006E7D04 File Offset: 0x006E5F04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBRafflePoolToRafflePool_s(IntPtr l)
	{
		int result;
		try
		{
			ProRafflePool pbRafflePool;
			LuaObject.checkType<ProRafflePool>(l, 1, out pbRafflePool);
			RafflePool o = RafflePool.PBRafflePoolToRafflePool(pbRafflePool);
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

	// Token: 0x060188A2 RID: 100514 RVA: 0x006E7D58 File Offset: 0x006E5F58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBRafflePoolsToRafflePools_s(IntPtr l)
	{
		int result;
		try
		{
			List<ProRafflePool> pbRafflePools;
			LuaObject.checkType<List<ProRafflePool>>(l, 1, out pbRafflePools);
			List<RafflePool> o = RafflePool.PBRafflePoolsToRafflePools(pbRafflePools);
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

	// Token: 0x060188A3 RID: 100515 RVA: 0x006E7DAC File Offset: 0x006E5FAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ActivityInstanceId(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rafflePool.ActivityInstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188A4 RID: 100516 RVA: 0x006E7E00 File Offset: 0x006E6000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActivityInstanceId(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			ulong activityInstanceId;
			LuaObject.checkType(l, 2, out activityInstanceId);
			rafflePool.ActivityInstanceId = activityInstanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188A5 RID: 100517 RVA: 0x006E7E58 File Offset: 0x006E6058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PoolId(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rafflePool.PoolId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188A6 RID: 100518 RVA: 0x006E7EAC File Offset: 0x006E60AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PoolId(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			rafflePool.PoolId = poolId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188A7 RID: 100519 RVA: 0x006E7F04 File Offset: 0x006E6104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DrawedRaffleIds(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rafflePool.DrawedRaffleIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188A8 RID: 100520 RVA: 0x006E7F58 File Offset: 0x006E6158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DrawedRaffleIds(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			HashSet<int> drawedRaffleIds;
			LuaObject.checkType<HashSet<int>>(l, 2, out drawedRaffleIds);
			rafflePool.DrawedRaffleIds = drawedRaffleIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188A9 RID: 100521 RVA: 0x006E7FB0 File Offset: 0x006E61B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DrawedCount(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rafflePool.DrawedCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188AA RID: 100522 RVA: 0x006E8004 File Offset: 0x006E6204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DrawedCount(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			int drawedCount;
			LuaObject.checkType(l, 2, out drawedCount);
			rafflePool.DrawedCount = drawedCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188AB RID: 100523 RVA: 0x006E805C File Offset: 0x006E625C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FreeDrawedCount(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rafflePool.FreeDrawedCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188AC RID: 100524 RVA: 0x006E80B0 File Offset: 0x006E62B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FreeDrawedCount(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			int freeDrawedCount;
			LuaObject.checkType(l, 2, out freeDrawedCount);
			rafflePool.FreeDrawedCount = freeDrawedCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188AD RID: 100525 RVA: 0x006E8108 File Offset: 0x006E6308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rafflePool.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188AE RID: 100526 RVA: 0x006E815C File Offset: 0x006E635C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Config(IntPtr l)
	{
		int result;
		try
		{
			RafflePool rafflePool = (RafflePool)LuaObject.checkSelf(l);
			ConfigDataRafflePoolInfo config;
			LuaObject.checkType<ConfigDataRafflePoolInfo>(l, 2, out config);
			rafflePool.Config = config;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188AF RID: 100527 RVA: 0x006E81B4 File Offset: 0x006E63B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RafflePool");
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.Drawed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.RafflePools2PbActivityRafflePools_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.PBRafflePoolToRafflePool_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.PBRafflePoolsToRafflePools_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache3);
		string name = "ActivityInstanceId";
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.get_ActivityInstanceId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.set_ActivityInstanceId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache5, true);
		string name2 = "PoolId";
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.get_PoolId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.set_PoolId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache7, true);
		string name3 = "DrawedRaffleIds";
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.get_DrawedRaffleIds);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.set_DrawedRaffleIds);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache9, true);
		string name4 = "DrawedCount";
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.get_DrawedCount);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.set_DrawedCount);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheB, true);
		string name5 = "FreeDrawedCount";
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.get_FreeDrawedCount);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.set_FreeDrawedCount);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheD, true);
		string name6 = "Config";
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.get_Config);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.set_Config);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cacheF, true);
		if (Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RafflePool.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RafflePool.<>f__mg$cache10, typeof(RafflePool));
	}

	// Token: 0x0400EDBE RID: 60862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EDBF RID: 60863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EDC0 RID: 60864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EDC1 RID: 60865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EDC2 RID: 60866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EDC3 RID: 60867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EDC4 RID: 60868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EDC5 RID: 60869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EDC6 RID: 60870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EDC7 RID: 60871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EDC8 RID: 60872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EDC9 RID: 60873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EDCA RID: 60874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EDCB RID: 60875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EDCC RID: 60876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EDCD RID: 60877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EDCE RID: 60878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
