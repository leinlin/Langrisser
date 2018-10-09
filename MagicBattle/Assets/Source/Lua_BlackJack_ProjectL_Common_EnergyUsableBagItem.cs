using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200121B RID: 4635
[Preserve]
public class Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem : LuaObject
{
	// Token: 0x060180AE RID: 98478 RVA: 0x006AB918 File Offset: 0x006A9B18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
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
			EnergyUsableBagItem o = new EnergyUsableBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x060180AF RID: 98479 RVA: 0x006AB994 File Offset: 0x006A9B94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HaveEffect(IntPtr l)
	{
		int result;
		try
		{
			EnergyUsableBagItem energyUsableBagItem = (EnergyUsableBagItem)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			object[] param;
			LuaObject.checkParams<object>(l, 3, out param);
			int i = energyUsableBagItem.HaveEffect(owner, param);
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

	// Token: 0x060180B0 RID: 98480 RVA: 0x006ABA04 File Offset: 0x006A9C04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergyCount(IntPtr l)
	{
		int result;
		try
		{
			EnergyUsableBagItem energyUsableBagItem = (EnergyUsableBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyUsableBagItem.EnergyCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180B1 RID: 98481 RVA: 0x006ABA58 File Offset: 0x006A9C58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergyCount(IntPtr l)
	{
		int result;
		try
		{
			EnergyUsableBagItem energyUsableBagItem = (EnergyUsableBagItem)LuaObject.checkSelf(l);
			int energyCount;
			LuaObject.checkType(l, 2, out energyCount);
			energyUsableBagItem.EnergyCount = energyCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180B2 RID: 98482 RVA: 0x006ABAB0 File Offset: 0x006A9CB0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.EnergyUsableBagItem");
		if (Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.HaveEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.<>f__mg$cache0);
		string name = "EnergyCount";
		if (Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.get_EnergyCount);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.set_EnergyCount);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.<>f__mg$cache2, true);
		if (Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.<>f__mg$cache3, typeof(EnergyUsableBagItem), typeof(UseableBagItem));
	}

	// Token: 0x0400E65A RID: 58970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E65B RID: 58971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E65C RID: 58972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E65D RID: 58973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
