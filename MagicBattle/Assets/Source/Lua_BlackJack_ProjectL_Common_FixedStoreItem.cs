using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200121F RID: 4639
[Preserve]
public class Lua_BlackJack_ProjectL_Common_FixedStoreItem : LuaObject
{
	// Token: 0x060180F7 RID: 98551 RVA: 0x006ADA28 File Offset: 0x006ABC28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreItem o = new FixedStoreItem();
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

	// Token: 0x060180F8 RID: 98552 RVA: 0x006ADA70 File Offset: 0x006ABC70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StoreItemToPBStoreItem_s(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreItem storeItem;
			LuaObject.checkType<FixedStoreItem>(l, 1, out storeItem);
			ProFixedStoreItem o = FixedStoreItem.StoreItemToPBStoreItem(storeItem);
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

	// Token: 0x060180F9 RID: 98553 RVA: 0x006ADAC4 File Offset: 0x006ABCC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreItemsToPBStoreItems_s(IntPtr l)
	{
		int result;
		try
		{
			List<FixedStoreItem> storeItems;
			LuaObject.checkType<List<FixedStoreItem>>(l, 1, out storeItems);
			List<ProFixedStoreItem> o = FixedStoreItem.StoreItemsToPBStoreItems(storeItems);
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

	// Token: 0x060180FA RID: 98554 RVA: 0x006ADB18 File Offset: 0x006ABD18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBStoreItemToStoreItem_s(IntPtr l)
	{
		int result;
		try
		{
			ProFixedStoreItem pbStoreItem;
			LuaObject.checkType<ProFixedStoreItem>(l, 1, out pbStoreItem);
			FixedStoreItem o = FixedStoreItem.PBStoreItemToStoreItem(pbStoreItem);
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

	// Token: 0x060180FB RID: 98555 RVA: 0x006ADB6C File Offset: 0x006ABD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBStoreItemsToStoreItems_s(IntPtr l)
	{
		int result;
		try
		{
			List<ProFixedStoreItem> pbStoreItems;
			LuaObject.checkType<List<ProFixedStoreItem>>(l, 1, out pbStoreItems);
			List<FixedStoreItem> o = FixedStoreItem.PBStoreItemsToStoreItems(pbStoreItems);
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

	// Token: 0x060180FC RID: 98556 RVA: 0x006ADBC0 File Offset: 0x006ABDC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreItem fixedStoreItem = (FixedStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreItem.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180FD RID: 98557 RVA: 0x006ADC14 File Offset: 0x006ABE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Id(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreItem fixedStoreItem = (FixedStoreItem)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			fixedStoreItem.Id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180FE RID: 98558 RVA: 0x006ADC6C File Offset: 0x006ABE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BoughtCount(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreItem fixedStoreItem = (FixedStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreItem.BoughtCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180FF RID: 98559 RVA: 0x006ADCC0 File Offset: 0x006ABEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BoughtCount(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreItem fixedStoreItem = (FixedStoreItem)LuaObject.checkSelf(l);
			int boughtCount;
			LuaObject.checkType(l, 2, out boughtCount);
			fixedStoreItem.BoughtCount = boughtCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018100 RID: 98560 RVA: 0x006ADD18 File Offset: 0x006ABF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsFirstBuy(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreItem fixedStoreItem = (FixedStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreItem.IsFirstBuy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018101 RID: 98561 RVA: 0x006ADD6C File Offset: 0x006ABF6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsFirstBuy(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreItem fixedStoreItem = (FixedStoreItem)LuaObject.checkSelf(l);
			bool isFirstBuy;
			LuaObject.checkType(l, 2, out isFirstBuy);
			fixedStoreItem.IsFirstBuy = isFirstBuy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018102 RID: 98562 RVA: 0x006ADDC4 File Offset: 0x006ABFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextFlushTime(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreItem fixedStoreItem = (FixedStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreItem.NextFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018103 RID: 98563 RVA: 0x006ADE18 File Offset: 0x006AC018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NextFlushTime(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreItem fixedStoreItem = (FixedStoreItem)LuaObject.checkSelf(l);
			long nextFlushTime;
			LuaObject.checkType(l, 2, out nextFlushTime);
			fixedStoreItem.NextFlushTime = nextFlushTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018104 RID: 98564 RVA: 0x006ADE70 File Offset: 0x006AC070
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.FixedStoreItem");
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.StoreItemToPBStoreItem_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.StoreItemsToPBStoreItems_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.PBStoreItemToStoreItem_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.PBStoreItemsToStoreItems_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache3);
		string name = "Id";
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.get_Id);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.set_Id);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache5, true);
		string name2 = "BoughtCount";
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.get_BoughtCount);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.set_BoughtCount);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache7, true);
		string name3 = "IsFirstBuy";
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.get_IsFirstBuy);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.set_IsFirstBuy);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cache9, true);
		string name4 = "NextFlushTime";
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.get_NextFlushTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.set_NextFlushTime);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_FixedStoreItem.<>f__mg$cacheC, typeof(FixedStoreItem));
	}

	// Token: 0x0400E69B RID: 59035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E69C RID: 59036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E69D RID: 59037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E69E RID: 59038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E69F RID: 59039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E6A0 RID: 59040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E6A1 RID: 59041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E6A2 RID: 59042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E6A3 RID: 59043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E6A4 RID: 59044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E6A5 RID: 59045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E6A6 RID: 59046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E6A7 RID: 59047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
