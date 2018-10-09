using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011C6 RID: 4550
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BagItemFactory : LuaObject
{
	// Token: 0x0601796D RID: 96621 RVA: 0x006775D4 File Offset: 0x006757D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BagItemFactory o = new BagItemFactory();
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

	// Token: 0x0601796E RID: 96622 RVA: 0x0067761C File Offset: 0x0067581C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagItemFactory bagItemFactory = (BagItemFactory)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			BagItemBase o = bagItemFactory.CreateBagItem(goodsTypeId, contentId, nums);
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

	// Token: 0x0601796F RID: 96623 RVA: 0x00677698 File Offset: 0x00675898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateInstanceBagItemByServer(IntPtr l)
	{
		int result;
		try
		{
			BagItemFactory bagItemFactory = (BagItemFactory)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			ulong instanceId;
			LuaObject.checkType(l, 5, out instanceId);
			BagItemBase o = bagItemFactory.CreateInstanceBagItemByServer(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x06017970 RID: 96624 RVA: 0x00677720 File Offset: 0x00675920
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateInstanceBagItemByClient(IntPtr l)
	{
		int result;
		try
		{
			BagItemFactory bagItemFactory = (BagItemFactory)LuaObject.checkSelf(l);
			ProGoods pbGoods;
			LuaObject.checkType<ProGoods>(l, 2, out pbGoods);
			BagItemBase o = bagItemFactory.CreateInstanceBagItemByClient(pbGoods);
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

	// Token: 0x06017971 RID: 96625 RVA: 0x00677784 File Offset: 0x00675984
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateBagItemInstanceId_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 2, out contentId);
			ulong o = BagItemFactory.CreateBagItemInstanceId(goodsTypeId, contentId);
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

	// Token: 0x06017972 RID: 96626 RVA: 0x006777E4 File Offset: 0x006759E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BagItemFactory bagItemFactory = (BagItemFactory)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemFactory.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017973 RID: 96627 RVA: 0x00677838 File Offset: 0x00675A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BagItemFactory bagItemFactory = (BagItemFactory)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			bagItemFactory.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017974 RID: 96628 RVA: 0x00677890 File Offset: 0x00675A90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BagItemFactory");
		if (Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemFactory.CreateBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemFactory.CreateInstanceBagItemByServer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemFactory.CreateInstanceBagItemByClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemFactory.CreateBagItemInstanceId_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache3);
		string name = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemFactory.get_ConfigDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemFactory.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemFactory.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BagItemFactory.<>f__mg$cache6, typeof(BagItemFactory));
	}

	// Token: 0x0400DFC3 RID: 57283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DFC4 RID: 57284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DFC5 RID: 57285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DFC6 RID: 57286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DFC7 RID: 57287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DFC8 RID: 57288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DFC9 RID: 57289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
