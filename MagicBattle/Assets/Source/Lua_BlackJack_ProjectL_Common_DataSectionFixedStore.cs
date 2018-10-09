using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011FC RID: 4604
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionFixedStore : LuaObject
{
	// Token: 0x06017DEB RID: 97771 RVA: 0x00697894 File Offset: 0x00695A94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore o = new DataSectionFixedStore();
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

	// Token: 0x06017DEC RID: 97772 RVA: 0x006978DC File Offset: 0x00695ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			object o = dataSectionFixedStore.SerializeToClient();
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

	// Token: 0x06017DED RID: 97773 RVA: 0x00697930 File Offset: 0x00695B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			dataSectionFixedStore.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DEE RID: 97774 RVA: 0x0069797C File Offset: 0x00695B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStores(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			List<FixedStore> stores;
			LuaObject.checkType<List<FixedStore>>(l, 2, out stores);
			dataSectionFixedStore.SetStores(stores);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DEF RID: 97775 RVA: 0x006979D4 File Offset: 0x00695BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitStores(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			List<FixedStore> stores;
			LuaObject.checkType<List<FixedStore>>(l, 2, out stores);
			dataSectionFixedStore.InitStores(stores);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DF0 RID: 97776 RVA: 0x00697A2C File Offset: 0x00695C2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitStore(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			FixedStore store;
			LuaObject.checkType<FixedStore>(l, 2, out store);
			dataSectionFixedStore.InitStore(store);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DF1 RID: 97777 RVA: 0x00697A84 File Offset: 0x00695C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddStore(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			FixedStore store;
			LuaObject.checkType<FixedStore>(l, 2, out store);
			dataSectionFixedStore.AddStore(store);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DF2 RID: 97778 RVA: 0x00697ADC File Offset: 0x00695CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetStore(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			FixedStore newStore;
			LuaObject.checkType<FixedStore>(l, 2, out newStore);
			dataSectionFixedStore.ResetStore(newStore);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DF3 RID: 97779 RVA: 0x00697B34 File Offset: 0x00695D34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindStore(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			FixedStore o = dataSectionFixedStore.FindStore(id);
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

	// Token: 0x06017DF4 RID: 97780 RVA: 0x00697B98 File Offset: 0x00695D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyStoreItem(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			FixedStoreItem storeItem;
			LuaObject.checkType<FixedStoreItem>(l, 2, out storeItem);
			int count;
			LuaObject.checkType(l, 3, out count);
			dataSectionFixedStore.BuyStoreItem(storeItem, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DF5 RID: 97781 RVA: 0x00697BFC File Offset: 0x00695DFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsFirstBuy(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			FixedStoreItem storeItem;
			LuaObject.checkType<FixedStoreItem>(l, 2, out storeItem);
			bool b = dataSectionFixedStore.IsFirstBuy(storeItem);
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

	// Token: 0x06017DF6 RID: 97782 RVA: 0x00697C60 File Offset: 0x00695E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStoreItem(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			FixedStore store;
			LuaObject.checkType<FixedStore>(l, 2, out store);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			FixedStoreItem storeItem = dataSectionFixedStore.GetStoreItem(store, goodsId);
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

	// Token: 0x06017DF7 RID: 97783 RVA: 0x00697CD0 File Offset: 0x00695ED0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Stores(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionFixedStore.Stores);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DF8 RID: 97784 RVA: 0x00697D24 File Offset: 0x00695F24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Stores(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFixedStore dataSectionFixedStore = (DataSectionFixedStore)LuaObject.checkSelf(l);
			Dictionary<int, FixedStore> stores;
			LuaObject.checkType<Dictionary<int, FixedStore>>(l, 2, out stores);
			dataSectionFixedStore.Stores = stores;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DF9 RID: 97785 RVA: 0x00697D7C File Offset: 0x00695F7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionFixedStore");
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.SetStores);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.InitStores);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.InitStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.AddStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.ResetStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.FindStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.BuyStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.IsFirstBuy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.GetStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cacheA);
		string name = "Stores";
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.get_Stores);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.set_Stores);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cacheC, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.<>f__mg$cacheD, typeof(DataSectionFixedStore), typeof(DataSection));
	}

	// Token: 0x0400E3D5 RID: 58325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E3D6 RID: 58326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E3D7 RID: 58327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E3D8 RID: 58328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E3D9 RID: 58329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E3DA RID: 58330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E3DB RID: 58331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E3DC RID: 58332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E3DD RID: 58333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E3DE RID: 58334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E3DF RID: 58335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E3E0 RID: 58336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E3E1 RID: 58337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E3E2 RID: 58338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
