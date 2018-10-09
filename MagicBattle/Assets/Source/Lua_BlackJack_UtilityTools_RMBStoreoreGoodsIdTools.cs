using System;
using System.Runtime.CompilerServices;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015F7 RID: 5623
[Preserve]
public class Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools : LuaObject
{
	// Token: 0x060227E9 RID: 141289 RVA: 0x00BD3F4C File Offset: 0x00BD214C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RMBStoreoreGoodsIdTools o = new RMBStoreoreGoodsIdTools();
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

	// Token: 0x060227EA RID: 141290 RVA: 0x00BD3F94 File Offset: 0x00BD2194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRealGoodsId_s(IntPtr l)
	{
		int result;
		try
		{
			string goodsId;
			LuaObject.checkType(l, 1, out goodsId);
			int realGoodsId = RMBStoreoreGoodsIdTools.GetRealGoodsId(goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realGoodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227EB RID: 141291 RVA: 0x00BD3FE8 File Offset: 0x00BD21E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetStoreTypeId_s(IntPtr l)
	{
		int result;
		try
		{
			string goodsId;
			LuaObject.checkType(l, 1, out goodsId);
			int storeTypeId = RMBStoreoreGoodsIdTools.GetStoreTypeId(goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeTypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227EC RID: 141292 RVA: 0x00BD403C File Offset: 0x00BD223C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsId_s(IntPtr l)
	{
		int result;
		try
		{
			int storeTypeId;
			LuaObject.checkType(l, 1, out storeTypeId);
			int realGoodsId;
			LuaObject.checkType(l, 2, out realGoodsId);
			string goodsId = RMBStoreoreGoodsIdTools.GetGoodsId(storeTypeId, realGoodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227ED RID: 141293 RVA: 0x00BD409C File Offset: 0x00BD229C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.UtilityTools.RMBStoreoreGoodsIdTools");
		if (Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.GetRealGoodsId_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.<>f__mg$cache0);
		if (Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.GetStoreTypeId_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.<>f__mg$cache1);
		if (Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.GetGoodsId_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.<>f__mg$cache2);
		if (Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.<>f__mg$cache3, typeof(RMBStoreoreGoodsIdTools));
	}

	// Token: 0x040185DD RID: 99805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185DE RID: 99806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185DF RID: 99807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040185E0 RID: 99808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
