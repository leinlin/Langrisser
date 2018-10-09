using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001241 RID: 4673
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem : LuaObject
{
	// Token: 0x0601848F RID: 99471 RVA: 0x006C8CE0 File Offset: 0x006C6EE0
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
			HeroFragmentBagItem o = new HeroFragmentBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x06018490 RID: 99472 RVA: 0x006C8D5C File Offset: 0x006C6F5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllExchangeMemoryEssence(IntPtr l)
	{
		int result;
		try
		{
			HeroFragmentBagItem heroFragmentBagItem = (HeroFragmentBagItem)LuaObject.checkSelf(l);
			int allExchangeMemoryEssence = heroFragmentBagItem.GetAllExchangeMemoryEssence();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allExchangeMemoryEssence);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018491 RID: 99473 RVA: 0x006C8DB0 File Offset: 0x006C6FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExchangeMemoryEssence(IntPtr l)
	{
		int result;
		try
		{
			HeroFragmentBagItem heroFragmentBagItem = (HeroFragmentBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroFragmentBagItem.ExchangeMemoryEssence);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018492 RID: 99474 RVA: 0x006C8E04 File Offset: 0x006C7004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ExchangeMemoryEssence(IntPtr l)
	{
		int result;
		try
		{
			HeroFragmentBagItem heroFragmentBagItem = (HeroFragmentBagItem)LuaObject.checkSelf(l);
			int exchangeMemoryEssence;
			LuaObject.checkType(l, 2, out exchangeMemoryEssence);
			heroFragmentBagItem.ExchangeMemoryEssence = exchangeMemoryEssence;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018493 RID: 99475 RVA: 0x006C8E5C File Offset: 0x006C705C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroFragmentBagItem");
		if (Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.GetAllExchangeMemoryEssence);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.<>f__mg$cache0);
		string name = "ExchangeMemoryEssence";
		if (Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.get_ExchangeMemoryEssence);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.set_ExchangeMemoryEssence);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.<>f__mg$cache2, true);
		if (Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.<>f__mg$cache3, typeof(HeroFragmentBagItem), typeof(BagItemBase));
	}

	// Token: 0x0400E9EF RID: 59887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E9F0 RID: 59888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E9F1 RID: 59889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E9F2 RID: 59890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
