using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011ED RID: 4589
[Preserve]
public class Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem : LuaObject
{
	// Token: 0x06017CD9 RID: 97497 RVA: 0x0068FFB4 File Offset: 0x0068E1B4
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
			CrystalUsableBagItem o = new CrystalUsableBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x06017CDA RID: 97498 RVA: 0x00690030 File Offset: 0x0068E230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HaveEffect(IntPtr l)
	{
		int result;
		try
		{
			CrystalUsableBagItem crystalUsableBagItem = (CrystalUsableBagItem)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			object[] param;
			LuaObject.checkParams<object>(l, 3, out param);
			int i = crystalUsableBagItem.HaveEffect(owner, param);
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

	// Token: 0x06017CDB RID: 97499 RVA: 0x006900A0 File Offset: 0x0068E2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CrystalCount(IntPtr l)
	{
		int result;
		try
		{
			CrystalUsableBagItem crystalUsableBagItem = (CrystalUsableBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, crystalUsableBagItem.CrystalCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CDC RID: 97500 RVA: 0x006900F4 File Offset: 0x0068E2F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CrystalCount(IntPtr l)
	{
		int result;
		try
		{
			CrystalUsableBagItem crystalUsableBagItem = (CrystalUsableBagItem)LuaObject.checkSelf(l);
			int crystalCount;
			LuaObject.checkType(l, 2, out crystalCount);
			crystalUsableBagItem.CrystalCount = crystalCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CDD RID: 97501 RVA: 0x0069014C File Offset: 0x0068E34C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.CrystalUsableBagItem");
		if (Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.HaveEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.<>f__mg$cache0);
		string name = "CrystalCount";
		if (Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.get_CrystalCount);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.set_CrystalCount);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.<>f__mg$cache2, true);
		if (Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.<>f__mg$cache3, typeof(CrystalUsableBagItem), typeof(UseableBagItem));
	}

	// Token: 0x0400E2E1 RID: 58081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E2E2 RID: 58082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E2E3 RID: 58083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E2E4 RID: 58084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
