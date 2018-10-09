using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001267 RID: 4711
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RandomStore : LuaObject
{
	// Token: 0x060188DF RID: 100575 RVA: 0x006E96A4 File Offset: 0x006E78A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomStore o = new RandomStore();
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

	// Token: 0x060188E0 RID: 100576 RVA: 0x006E96EC File Offset: 0x006E78EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StoreToPBStore_s(IntPtr l)
	{
		int result;
		try
		{
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 1, out store);
			ProRandomStore o = RandomStore.StoreToPBStore(store);
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

	// Token: 0x060188E1 RID: 100577 RVA: 0x006E9740 File Offset: 0x006E7940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoresToPBStores_s(IntPtr l)
	{
		int result;
		try
		{
			List<RandomStore> stores;
			LuaObject.checkType<List<RandomStore>>(l, 1, out stores);
			List<ProRandomStore> o = RandomStore.StoresToPBStores(stores);
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

	// Token: 0x060188E2 RID: 100578 RVA: 0x006E9794 File Offset: 0x006E7994
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBStoreToStore_s(IntPtr l)
	{
		int result;
		try
		{
			ProRandomStore pbStore;
			LuaObject.checkType<ProRandomStore>(l, 1, out pbStore);
			RandomStore o = RandomStore.PBStoreToStore(pbStore);
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

	// Token: 0x060188E3 RID: 100579 RVA: 0x006E97E8 File Offset: 0x006E79E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBStoresToStores_s(IntPtr l)
	{
		int result;
		try
		{
			List<ProRandomStore> pbStores;
			LuaObject.checkType<List<ProRandomStore>>(l, 1, out pbStores);
			List<RandomStore> o = RandomStore.PBStoresToStores(pbStores);
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

	// Token: 0x060188E4 RID: 100580 RVA: 0x006E983C File Offset: 0x006E7A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Items(IntPtr l)
	{
		int result;
		try
		{
			RandomStore randomStore = (RandomStore)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStore.Items);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188E5 RID: 100581 RVA: 0x006E9890 File Offset: 0x006E7A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Items(IntPtr l)
	{
		int result;
		try
		{
			RandomStore randomStore = (RandomStore)LuaObject.checkSelf(l);
			List<RandomStoreItem> items;
			LuaObject.checkType<List<RandomStoreItem>>(l, 2, out items);
			randomStore.Items = items;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188E6 RID: 100582 RVA: 0x006E98E8 File Offset: 0x006E7AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			RandomStore randomStore = (RandomStore)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStore.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188E7 RID: 100583 RVA: 0x006E993C File Offset: 0x006E7B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Id(IntPtr l)
	{
		int result;
		try
		{
			RandomStore randomStore = (RandomStore)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			randomStore.Id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188E8 RID: 100584 RVA: 0x006E9994 File Offset: 0x006E7B94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NextFlushTime(IntPtr l)
	{
		int result;
		try
		{
			RandomStore randomStore = (RandomStore)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStore.NextFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188E9 RID: 100585 RVA: 0x006E99EC File Offset: 0x006E7BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NextFlushTime(IntPtr l)
	{
		int result;
		try
		{
			RandomStore randomStore = (RandomStore)LuaObject.checkSelf(l);
			DateTime nextFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out nextFlushTime);
			randomStore.NextFlushTime = nextFlushTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188EA RID: 100586 RVA: 0x006E9A44 File Offset: 0x006E7C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ManualFlushNums(IntPtr l)
	{
		int result;
		try
		{
			RandomStore randomStore = (RandomStore)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStore.ManualFlushNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188EB RID: 100587 RVA: 0x006E9A98 File Offset: 0x006E7C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ManualFlushNums(IntPtr l)
	{
		int result;
		try
		{
			RandomStore randomStore = (RandomStore)LuaObject.checkSelf(l);
			int manualFlushNums;
			LuaObject.checkType(l, 2, out manualFlushNums);
			randomStore.ManualFlushNums = manualFlushNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188EC RID: 100588 RVA: 0x006E9AF0 File Offset: 0x006E7CF0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RandomStore");
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.StoreToPBStore_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.StoresToPBStores_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.PBStoreToStore_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.PBStoresToStores_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache3);
		string name = "Items";
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.get_Items);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.set_Items);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache5, true);
		string name2 = "Id";
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.get_Id);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.set_Id);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache7, true);
		string name3 = "NextFlushTime";
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.get_NextFlushTime);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.set_NextFlushTime);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cache9, true);
		string name4 = "ManualFlushNums";
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.get_ManualFlushNums);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.set_ManualFlushNums);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStore.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RandomStore.<>f__mg$cacheC, typeof(RandomStore));
	}

	// Token: 0x0400EDF3 RID: 60915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EDF4 RID: 60916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EDF5 RID: 60917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EDF6 RID: 60918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EDF7 RID: 60919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EDF8 RID: 60920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EDF9 RID: 60921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EDFA RID: 60922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EDFB RID: 60923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EDFC RID: 60924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EDFD RID: 60925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EDFE RID: 60926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EDFF RID: 60927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
