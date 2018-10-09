using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200121D RID: 4637
[Preserve]
public class Lua_BlackJack_ProjectL_Common_FixedStore : LuaObject
{
	// Token: 0x060180C8 RID: 98504 RVA: 0x006AC454 File Offset: 0x006AA654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FixedStore o = new FixedStore();
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

	// Token: 0x060180C9 RID: 98505 RVA: 0x006AC49C File Offset: 0x006AA69C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBFixedStoreToFixedStore_s(IntPtr l)
	{
		int result;
		try
		{
			ProFixedStore pbStore;
			LuaObject.checkType<ProFixedStore>(l, 1, out pbStore);
			FixedStore o = FixedStore.PBFixedStoreToFixedStore(pbStore);
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

	// Token: 0x060180CA RID: 98506 RVA: 0x006AC4F0 File Offset: 0x006AA6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBFixedStoresToFixedStores_s(IntPtr l)
	{
		int result;
		try
		{
			List<ProFixedStore> pbStores;
			LuaObject.checkType<List<ProFixedStore>>(l, 1, out pbStores);
			List<FixedStore> o = FixedStore.PBFixedStoresToFixedStores(pbStores);
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

	// Token: 0x060180CB RID: 98507 RVA: 0x006AC544 File Offset: 0x006AA744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FixedStoreToPBFixedStore_s(IntPtr l)
	{
		int result;
		try
		{
			FixedStore store;
			LuaObject.checkType<FixedStore>(l, 1, out store);
			ProFixedStore o = FixedStore.FixedStoreToPBFixedStore(store);
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

	// Token: 0x060180CC RID: 98508 RVA: 0x006AC598 File Offset: 0x006AA798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FixedStoresToPBFixedStores_s(IntPtr l)
	{
		int result;
		try
		{
			List<FixedStore> stores;
			LuaObject.checkType<List<FixedStore>>(l, 1, out stores);
			List<ProFixedStore> o = FixedStore.FixedStoresToPBFixedStores(stores);
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

	// Token: 0x060180CD RID: 98509 RVA: 0x006AC5EC File Offset: 0x006AA7EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Items(IntPtr l)
	{
		int result;
		try
		{
			FixedStore fixedStore = (FixedStore)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStore.Items);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180CE RID: 98510 RVA: 0x006AC640 File Offset: 0x006AA840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Items(IntPtr l)
	{
		int result;
		try
		{
			FixedStore fixedStore = (FixedStore)LuaObject.checkSelf(l);
			List<FixedStoreItem> items;
			LuaObject.checkType<List<FixedStoreItem>>(l, 2, out items);
			fixedStore.Items = items;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180CF RID: 98511 RVA: 0x006AC698 File Offset: 0x006AA898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			FixedStore fixedStore = (FixedStore)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStore.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180D0 RID: 98512 RVA: 0x006AC6EC File Offset: 0x006AA8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Id(IntPtr l)
	{
		int result;
		try
		{
			FixedStore fixedStore = (FixedStore)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			fixedStore.Id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180D1 RID: 98513 RVA: 0x006AC744 File Offset: 0x006AA944
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.FixedStore");
		if (Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStore.PBFixedStoreToFixedStore_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStore.PBFixedStoresToFixedStores_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStore.FixedStoreToPBFixedStore_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStore.FixedStoresToPBFixedStores_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache3);
		string name = "Items";
		if (Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStore.get_Items);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStore.set_Items);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache5, true);
		string name2 = "Id";
		if (Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStore.get_Id);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStore.set_Id);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStore.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_FixedStore.<>f__mg$cache8, typeof(FixedStore));
	}

	// Token: 0x0400E670 RID: 58992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E671 RID: 58993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E672 RID: 58994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E673 RID: 58995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E674 RID: 58996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E675 RID: 58997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E676 RID: 58998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E677 RID: 58999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E678 RID: 59000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
