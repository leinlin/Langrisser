using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001258 RID: 4696
[Preserve]
public class Lua_BlackJack_ProjectL_Common_OrderReward : LuaObject
{
	// Token: 0x0601877D RID: 100221 RVA: 0x006DF100 File Offset: 0x006DD300
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				OrderReward o = new OrderReward();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				string orderId;
				LuaObject.checkType(l, 2, out orderId);
				OrderReward o = new OrderReward(orderId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601877E RID: 100222 RVA: 0x006DF198 File Offset: 0x006DD398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPB_s(IntPtr l)
	{
		int result;
		try
		{
			OrderReward orderReward;
			LuaObject.checkType<OrderReward>(l, 1, out orderReward);
			ProOrderReward o = OrderReward.ToPB(orderReward);
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

	// Token: 0x0601877F RID: 100223 RVA: 0x006DF1EC File Offset: 0x006DD3EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromPB_s(IntPtr l)
	{
		int result;
		try
		{
			ProOrderReward pbOrderReward;
			LuaObject.checkType<ProOrderReward>(l, 1, out pbOrderReward);
			OrderReward o = OrderReward.FromPB(pbOrderReward);
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

	// Token: 0x06018780 RID: 100224 RVA: 0x006DF240 File Offset: 0x006DD440
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			OrderReward orderReward = (OrderReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, orderReward.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018781 RID: 100225 RVA: 0x006DF294 File Offset: 0x006DD494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Rewards(IntPtr l)
	{
		int result;
		try
		{
			OrderReward orderReward = (OrderReward)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			orderReward.Rewards = rewards;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018782 RID: 100226 RVA: 0x006DF2EC File Offset: 0x006DD4EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OrderId(IntPtr l)
	{
		int result;
		try
		{
			OrderReward orderReward = (OrderReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, orderReward.OrderId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018783 RID: 100227 RVA: 0x006DF340 File Offset: 0x006DD540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OrderId(IntPtr l)
	{
		int result;
		try
		{
			OrderReward orderReward = (OrderReward)LuaObject.checkSelf(l);
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			orderReward.OrderId = orderId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018784 RID: 100228 RVA: 0x006DF398 File Offset: 0x006DD598
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.OrderReward");
		if (Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OrderReward.ToPB_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OrderReward.FromPB_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache1);
		string name = "Rewards";
		if (Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OrderReward.get_Rewards);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OrderReward.set_Rewards);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache3, true);
		string name2 = "OrderId";
		if (Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OrderReward.get_OrderId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OrderReward.set_OrderId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OrderReward.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_OrderReward.<>f__mg$cache6, typeof(OrderReward));
	}

	// Token: 0x0400ECAF RID: 60591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400ECB0 RID: 60592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400ECB1 RID: 60593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400ECB2 RID: 60594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400ECB3 RID: 60595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400ECB4 RID: 60596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400ECB5 RID: 60597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
