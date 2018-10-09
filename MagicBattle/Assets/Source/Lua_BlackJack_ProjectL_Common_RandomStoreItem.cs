using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001269 RID: 4713
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RandomStoreItem : LuaObject
{
	// Token: 0x0601890A RID: 100618 RVA: 0x006EAA10 File Offset: 0x006E8C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItem o = new RandomStoreItem();
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

	// Token: 0x0601890B RID: 100619 RVA: 0x006EAA58 File Offset: 0x006E8C58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StoreItemToPBStoreItem_s(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItem storeItem;
			LuaObject.checkType<RandomStoreItem>(l, 1, out storeItem);
			ProRandomStoreItem o = RandomStoreItem.StoreItemToPBStoreItem(storeItem);
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

	// Token: 0x0601890C RID: 100620 RVA: 0x006EAAAC File Offset: 0x006E8CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBStoreItemToStoreItem_s(IntPtr l)
	{
		int result;
		try
		{
			ProRandomStoreItem pbStoreItem;
			LuaObject.checkType<ProRandomStoreItem>(l, 1, out pbStoreItem);
			RandomStoreItem o = RandomStoreItem.PBStoreItemToStoreItem(pbStoreItem);
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

	// Token: 0x0601890D RID: 100621 RVA: 0x006EAB00 File Offset: 0x006E8D00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItem randomStoreItem = (RandomStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStoreItem.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601890E RID: 100622 RVA: 0x006EAB54 File Offset: 0x006E8D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Id(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItem randomStoreItem = (RandomStoreItem)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			randomStoreItem.Id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601890F RID: 100623 RVA: 0x006EABAC File Offset: 0x006E8DAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Bought(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItem randomStoreItem = (RandomStoreItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStoreItem.Bought);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018910 RID: 100624 RVA: 0x006EAC00 File Offset: 0x006E8E00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Bought(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItem randomStoreItem = (RandomStoreItem)LuaObject.checkSelf(l);
			bool bought;
			LuaObject.checkType(l, 2, out bought);
			randomStoreItem.Bought = bought;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018911 RID: 100625 RVA: 0x006EAC58 File Offset: 0x006E8E58
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RandomStoreItem");
		if (Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreItem.StoreItemToPBStoreItem_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreItem.PBStoreItemToStoreItem_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache1);
		string name = "Id";
		if (Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreItem.get_Id);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreItem.set_Id);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache3, true);
		string name2 = "Bought";
		if (Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreItem.get_Bought);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreItem.set_Bought);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RandomStoreItem.<>f__mg$cache6, typeof(RandomStoreItem));
	}

	// Token: 0x0400EE1A RID: 60954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EE1B RID: 60955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EE1C RID: 60956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EE1D RID: 60957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EE1E RID: 60958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EE1F RID: 60959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EE20 RID: 60960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
