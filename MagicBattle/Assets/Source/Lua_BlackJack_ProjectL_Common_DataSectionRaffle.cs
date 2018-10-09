using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200120B RID: 4619
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionRaffle : LuaObject
{
	// Token: 0x06017FAE RID: 98222 RVA: 0x006A47D0 File Offset: 0x006A29D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRaffle o = new DataSectionRaffle();
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

	// Token: 0x06017FAF RID: 98223 RVA: 0x006A4818 File Offset: 0x006A2A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRaffle dataSectionRaffle = (DataSectionRaffle)LuaObject.checkSelf(l);
			object o = dataSectionRaffle.SerializeToClient();
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

	// Token: 0x06017FB0 RID: 98224 RVA: 0x006A486C File Offset: 0x006A2A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRaffle dataSectionRaffle = (DataSectionRaffle)LuaObject.checkSelf(l);
			dataSectionRaffle.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FB1 RID: 98225 RVA: 0x006A48B8 File Offset: 0x006A2AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitRafflePools(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRaffle dataSectionRaffle = (DataSectionRaffle)LuaObject.checkSelf(l);
			List<RafflePool> rafflePools;
			LuaObject.checkType<List<RafflePool>>(l, 2, out rafflePools);
			dataSectionRaffle.InitRafflePools(rafflePools);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FB2 RID: 98226 RVA: 0x006A4910 File Offset: 0x006A2B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRafflePools(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRaffle dataSectionRaffle = (DataSectionRaffle)LuaObject.checkSelf(l);
			List<RafflePool> rafflePools;
			LuaObject.checkType<List<RafflePool>>(l, 2, out rafflePools);
			dataSectionRaffle.SetRafflePools(rafflePools);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FB3 RID: 98227 RVA: 0x006A4968 File Offset: 0x006A2B68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveRafflePool(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRaffle dataSectionRaffle = (DataSectionRaffle)LuaObject.checkSelf(l);
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			dataSectionRaffle.RemoveRafflePool(poolId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FB4 RID: 98228 RVA: 0x006A49C0 File Offset: 0x006A2BC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRafflePool(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRaffle dataSectionRaffle = (DataSectionRaffle)LuaObject.checkSelf(l);
			int rafflePoolId;
			LuaObject.checkType(l, 2, out rafflePoolId);
			RafflePool rafflePool = dataSectionRaffle.GetRafflePool(rafflePoolId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rafflePool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FB5 RID: 98229 RVA: 0x006A4A24 File Offset: 0x006A2C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Drawed(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRaffle dataSectionRaffle = (DataSectionRaffle)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			int darwedRaffleId;
			LuaObject.checkType(l, 3, out darwedRaffleId);
			dataSectionRaffle.Drawed(pool, darwedRaffleId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FB6 RID: 98230 RVA: 0x006A4A88 File Offset: 0x006A2C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RafflePools(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRaffle dataSectionRaffle = (DataSectionRaffle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRaffle.RafflePools);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FB7 RID: 98231 RVA: 0x006A4ADC File Offset: 0x006A2CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RafflePools(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRaffle dataSectionRaffle = (DataSectionRaffle)LuaObject.checkSelf(l);
			Dictionary<int, RafflePool> rafflePools;
			LuaObject.checkType<Dictionary<int, RafflePool>>(l, 2, out rafflePools);
			dataSectionRaffle.RafflePools = rafflePools;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FB8 RID: 98232 RVA: 0x006A4B34 File Offset: 0x006A2D34
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionRaffle");
		if (Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRaffle.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRaffle.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRaffle.InitRafflePools);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRaffle.SetRafflePools);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRaffle.RemoveRafflePool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRaffle.GetRafflePool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRaffle.Drawed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache6);
		string name = "RafflePools";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRaffle.get_RafflePools);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRaffle.set_RafflePools);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache8, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRaffle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionRaffle.<>f__mg$cache9, typeof(DataSectionRaffle), typeof(DataSection));
	}

	// Token: 0x0400E57A RID: 58746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E57B RID: 58747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E57C RID: 58748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E57D RID: 58749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E57E RID: 58750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E57F RID: 58751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E580 RID: 58752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E581 RID: 58753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E582 RID: 58754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E583 RID: 58755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
