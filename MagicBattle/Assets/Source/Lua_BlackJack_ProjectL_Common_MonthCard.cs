using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001253 RID: 4691
[Preserve]
public class Lua_BlackJack_ProjectL_Common_MonthCard : LuaObject
{
	// Token: 0x060186E0 RID: 100064 RVA: 0x006DA844 File Offset: 0x006D8A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MonthCard o = new MonthCard();
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

	// Token: 0x060186E1 RID: 100065 RVA: 0x006DA88C File Offset: 0x006D8A8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPB_s(IntPtr l)
	{
		int result;
		try
		{
			MonthCard monthCard;
			LuaObject.checkType<MonthCard>(l, 1, out monthCard);
			ProMonthCard o = MonthCard.ToPB(monthCard);
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

	// Token: 0x060186E2 RID: 100066 RVA: 0x006DA8E0 File Offset: 0x006D8AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromPB_s(IntPtr l)
	{
		int result;
		try
		{
			ProMonthCard pbMonthCard;
			LuaObject.checkType<ProMonthCard>(l, 1, out pbMonthCard);
			MonthCard o = MonthCard.FromPB(pbMonthCard);
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

	// Token: 0x060186E3 RID: 100067 RVA: 0x006DA934 File Offset: 0x006D8B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CardId(IntPtr l)
	{
		int result;
		try
		{
			MonthCard monthCard = (MonthCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCard.CardId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186E4 RID: 100068 RVA: 0x006DA988 File Offset: 0x006D8B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CardId(IntPtr l)
	{
		int result;
		try
		{
			MonthCard monthCard = (MonthCard)LuaObject.checkSelf(l);
			int cardId;
			LuaObject.checkType(l, 2, out cardId);
			monthCard.CardId = cardId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186E5 RID: 100069 RVA: 0x006DA9E0 File Offset: 0x006D8BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			MonthCard monthCard = (MonthCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCard.ExpiredTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186E6 RID: 100070 RVA: 0x006DAA38 File Offset: 0x006D8C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			MonthCard monthCard = (MonthCard)LuaObject.checkSelf(l);
			DateTime expiredTime;
			LuaObject.checkValueType<DateTime>(l, 2, out expiredTime);
			monthCard.ExpiredTime = expiredTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186E7 RID: 100071 RVA: 0x006DAA90 File Offset: 0x006D8C90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GoodsId(IntPtr l)
	{
		int result;
		try
		{
			MonthCard monthCard = (MonthCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monthCard.GoodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186E8 RID: 100072 RVA: 0x006DAAE4 File Offset: 0x006D8CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GoodsId(IntPtr l)
	{
		int result;
		try
		{
			MonthCard monthCard = (MonthCard)LuaObject.checkSelf(l);
			string goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			monthCard.GoodsId = goodsId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060186E9 RID: 100073 RVA: 0x006DAB3C File Offset: 0x006D8D3C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.MonthCard");
		if (Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MonthCard.ToPB_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MonthCard.FromPB_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache1);
		string name = "CardId";
		if (Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MonthCard.get_CardId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MonthCard.set_CardId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache3, true);
		string name2 = "ExpiredTime";
		if (Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MonthCard.get_ExpiredTime);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MonthCard.set_ExpiredTime);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache5, true);
		string name3 = "GoodsId";
		if (Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MonthCard.get_GoodsId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MonthCard.set_GoodsId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MonthCard.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_MonthCard.<>f__mg$cache8, typeof(MonthCard));
	}

	// Token: 0x0400EC1C RID: 60444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EC1D RID: 60445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EC1E RID: 60446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EC1F RID: 60447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EC20 RID: 60448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EC21 RID: 60449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EC22 RID: 60450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EC23 RID: 60451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EC24 RID: 60452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
