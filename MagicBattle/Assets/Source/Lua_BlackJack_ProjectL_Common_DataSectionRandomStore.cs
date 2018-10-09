using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200120C RID: 4620
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionRandomStore : LuaObject
{
	// Token: 0x06017FBA RID: 98234 RVA: 0x006A4CC8 File Offset: 0x006A2EC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore o = new DataSectionRandomStore();
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

	// Token: 0x06017FBB RID: 98235 RVA: 0x006A4D10 File Offset: 0x006A2F10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			object o = dataSectionRandomStore.SerializeToClient();
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

	// Token: 0x06017FBC RID: 98236 RVA: 0x006A4D64 File Offset: 0x006A2F64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			dataSectionRandomStore.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FBD RID: 98237 RVA: 0x006A4DB0 File Offset: 0x006A2FB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitStore(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			dataSectionRandomStore.InitStore(store);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FBE RID: 98238 RVA: 0x006A4E08 File Offset: 0x006A3008
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddStore(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			dataSectionRandomStore.AddStore(store);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FBF RID: 98239 RVA: 0x006A4E60 File Offset: 0x006A3060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindStore(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			RandomStore o = dataSectionRandomStore.FindStore(id);
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

	// Token: 0x06017FC0 RID: 98240 RVA: 0x006A4EC4 File Offset: 0x006A30C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStore(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			dataSectionRandomStore.SetStore(store);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FC1 RID: 98241 RVA: 0x006A4F1C File Offset: 0x006A311C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyStoreItem(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			RandomStoreItem storeItem;
			LuaObject.checkType<RandomStoreItem>(l, 2, out storeItem);
			dataSectionRandomStore.BuyStoreItem(storeItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FC2 RID: 98242 RVA: 0x006A4F74 File Offset: 0x006A3174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetManualFlushNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int manualFlushNums = dataSectionRandomStore.GetManualFlushNums(storeId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, manualFlushNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FC3 RID: 98243 RVA: 0x006A4FD8 File Offset: 0x006A31D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStoreNextFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			DateTime flushTime;
			LuaObject.checkValueType<DateTime>(l, 3, out flushTime);
			dataSectionRandomStore.SetStoreNextFlushTime(store, flushTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FC4 RID: 98244 RVA: 0x006A503C File Offset: 0x006A323C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddStoreItems(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			List<RandomStoreItem> storeItems;
			LuaObject.checkType<List<RandomStoreItem>>(l, 3, out storeItems);
			dataSectionRandomStore.AddStoreItems(store, storeItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FC5 RID: 98245 RVA: 0x006A50A0 File Offset: 0x006A32A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearStoreItems(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			dataSectionRandomStore.ClearStoreItems(store);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FC6 RID: 98246 RVA: 0x006A50F8 File Offset: 0x006A32F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStoreItem(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			int index;
			LuaObject.checkType(l, 3, out index);
			RandomStoreItem storeItem = dataSectionRandomStore.GetStoreItem(store, index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FC7 RID: 98247 RVA: 0x006A5168 File Offset: 0x006A3368
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetManualFlushNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			dataSectionRandomStore.SetManualFlushNums(store, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FC8 RID: 98248 RVA: 0x006A51CC File Offset: 0x006A33CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddManualFlushNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			int addNums;
			LuaObject.checkType(l, 3, out addNums);
			dataSectionRandomStore.AddManualFlushNums(store, addNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FC9 RID: 98249 RVA: 0x006A5230 File Offset: 0x006A3430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Stores(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRandomStore.Stores);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FCA RID: 98250 RVA: 0x006A5284 File Offset: 0x006A3484
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Stores(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRandomStore dataSectionRandomStore = (DataSectionRandomStore)LuaObject.checkSelf(l);
			List<RandomStore> stores;
			LuaObject.checkType<List<RandomStore>>(l, 2, out stores);
			dataSectionRandomStore.Stores = stores;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FCB RID: 98251 RVA: 0x006A52DC File Offset: 0x006A34DC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionRandomStore");
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.InitStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.AddStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.FindStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.SetStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.BuyStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.GetManualFlushNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.SetStoreNextFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.AddStoreItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.ClearStoreItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.GetStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.SetManualFlushNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.AddManualFlushNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheD);
		string name = "Stores";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.get_Stores);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.set_Stores);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cacheF, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.<>f__mg$cache10, typeof(DataSectionRandomStore), typeof(DataSection));
	}

	// Token: 0x0400E584 RID: 58756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E585 RID: 58757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E586 RID: 58758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E587 RID: 58759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E588 RID: 58760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E589 RID: 58761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E58A RID: 58762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E58B RID: 58763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E58C RID: 58764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E58D RID: 58765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E58E RID: 58766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E58F RID: 58767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E590 RID: 58768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E591 RID: 58769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E592 RID: 58770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E593 RID: 58771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E594 RID: 58772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
