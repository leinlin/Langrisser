using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001228 RID: 4648
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GoldUsableBagItem : LuaObject
{
	// Token: 0x060181AC RID: 98732 RVA: 0x006B2A98 File Offset: 0x006B0C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			ulong instanceId;
			LuaObject.checkType(l, 5, out instanceId);
			GoldUsableBagItem o = new GoldUsableBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x060181AD RID: 98733 RVA: 0x006B2B14 File Offset: 0x006B0D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HaveEffect(IntPtr l)
	{
		int result;
		try
		{
			GoldUsableBagItem goldUsableBagItem = (GoldUsableBagItem)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			object[] param;
			LuaObject.checkParams<object>(l, 3, out param);
			int i = goldUsableBagItem.HaveEffect(owner, param);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181AE RID: 98734 RVA: 0x006B2B84 File Offset: 0x006B0D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoldCount(IntPtr l)
	{
		int result;
		try
		{
			GoldUsableBagItem goldUsableBagItem = (GoldUsableBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goldUsableBagItem.GoldCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181AF RID: 98735 RVA: 0x006B2BD8 File Offset: 0x006B0DD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GoldCount(IntPtr l)
	{
		int result;
		try
		{
			GoldUsableBagItem goldUsableBagItem = (GoldUsableBagItem)LuaObject.checkSelf(l);
			int goldCount;
			LuaObject.checkType(l, 2, out goldCount);
			goldUsableBagItem.GoldCount = goldCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181B0 RID: 98736 RVA: 0x006B2C30 File Offset: 0x006B0E30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GoldUsableBagItem");
		if (Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.HaveEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.<>f__mg$cache0);
		string name = "GoldCount";
		if (Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.get_GoldCount);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.set_GoldCount);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.<>f__mg$cache2, true);
		if (Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.<>f__mg$cache3, typeof(GoldUsableBagItem), typeof(UseableBagItem));
	}

	// Token: 0x0400E73E RID: 59198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E73F RID: 59199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E740 RID: 59200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E741 RID: 59201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
