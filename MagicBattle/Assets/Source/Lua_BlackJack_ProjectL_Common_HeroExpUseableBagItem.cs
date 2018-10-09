using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001240 RID: 4672
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem : LuaObject
{
	// Token: 0x06018489 RID: 99465 RVA: 0x006C8A88 File Offset: 0x006C6C88
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
			HeroExpUseableBagItem o = new HeroExpUseableBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x0601848A RID: 99466 RVA: 0x006C8B04 File Offset: 0x006C6D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HaveEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroExpUseableBagItem heroExpUseableBagItem = (HeroExpUseableBagItem)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			object[] param;
			LuaObject.checkParams<object>(l, 3, out param);
			int i = heroExpUseableBagItem.HaveEffect(owner, param);
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

	// Token: 0x0601848B RID: 99467 RVA: 0x006C8B74 File Offset: 0x006C6D74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			HeroExpUseableBagItem heroExpUseableBagItem = (HeroExpUseableBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroExpUseableBagItem.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601848C RID: 99468 RVA: 0x006C8BC8 File Offset: 0x006C6DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			HeroExpUseableBagItem heroExpUseableBagItem = (HeroExpUseableBagItem)LuaObject.checkSelf(l);
			int heroExp;
			LuaObject.checkType(l, 2, out heroExp);
			heroExpUseableBagItem.HeroExp = heroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601848D RID: 99469 RVA: 0x006C8C20 File Offset: 0x006C6E20
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroExpUseableBagItem");
		if (Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.HaveEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.<>f__mg$cache0);
		string name = "HeroExp";
		if (Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.get_HeroExp);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.set_HeroExp);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.<>f__mg$cache2, true);
		if (Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.<>f__mg$cache3, typeof(HeroExpUseableBagItem), typeof(UseableBagItem));
	}

	// Token: 0x0400E9EB RID: 59883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E9EC RID: 59884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E9ED RID: 59885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E9EE RID: 59886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
