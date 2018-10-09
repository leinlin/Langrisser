using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011D6 RID: 4566
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet : LuaObject
{
	// Token: 0x06017B14 RID: 97044 RVA: 0x0068393C File Offset: 0x00681B3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroSet o = new BusinessCardHeroSet();
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

	// Token: 0x06017B15 RID: 97045 RVA: 0x00683984 File Offset: 0x00681B84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToProtocol_s(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroSet heroSet;
			LuaObject.checkType<BusinessCardHeroSet>(l, 1, out heroSet);
			ProBusinessCardHeroSet o = BusinessCardHeroSet.ToProtocol(heroSet);
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

	// Token: 0x06017B16 RID: 97046 RVA: 0x006839D8 File Offset: 0x00681BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToProtocols_s(IntPtr l)
	{
		int result;
		try
		{
			List<BusinessCardHeroSet> heroSets;
			LuaObject.checkType<List<BusinessCardHeroSet>>(l, 1, out heroSets);
			List<ProBusinessCardHeroSet> o = BusinessCardHeroSet.ToProtocols(heroSets);
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

	// Token: 0x06017B17 RID: 97047 RVA: 0x00683A2C File Offset: 0x00681C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromProtocol_s(IntPtr l)
	{
		int result;
		try
		{
			ProBusinessCardHeroSet pbHeroSet;
			LuaObject.checkType<ProBusinessCardHeroSet>(l, 1, out pbHeroSet);
			BusinessCardHeroSet o = BusinessCardHeroSet.FromProtocol(pbHeroSet);
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

	// Token: 0x06017B18 RID: 97048 RVA: 0x00683A80 File Offset: 0x00681C80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FromProtocols_s(IntPtr l)
	{
		int result;
		try
		{
			List<ProBusinessCardHeroSet> pbHeroSets;
			LuaObject.checkType<List<ProBusinessCardHeroSet>>(l, 1, out pbHeroSets);
			List<BusinessCardHeroSet> o = BusinessCardHeroSet.FromProtocols(pbHeroSets);
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

	// Token: 0x06017B19 RID: 97049 RVA: 0x00683AD4 File Offset: 0x00681CD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroId(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroSet businessCardHeroSet = (BusinessCardHeroSet)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroSet.HeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B1A RID: 97050 RVA: 0x00683B28 File Offset: 0x00681D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroId(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroSet businessCardHeroSet = (BusinessCardHeroSet)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			businessCardHeroSet.HeroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B1B RID: 97051 RVA: 0x00683B80 File Offset: 0x00681D80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Direction(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroSet businessCardHeroSet = (BusinessCardHeroSet)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)businessCardHeroSet.Direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B1C RID: 97052 RVA: 0x00683BD4 File Offset: 0x00681DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Direction(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroSet businessCardHeroSet = (BusinessCardHeroSet)LuaObject.checkSelf(l);
			HeroDirectionType direction;
			LuaObject.checkEnum<HeroDirectionType>(l, 2, out direction);
			businessCardHeroSet.Direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B1D RID: 97053 RVA: 0x00683C2C File Offset: 0x00681E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Action(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroSet businessCardHeroSet = (BusinessCardHeroSet)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)businessCardHeroSet.Action);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B1E RID: 97054 RVA: 0x00683C80 File Offset: 0x00681E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Action(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroSet businessCardHeroSet = (BusinessCardHeroSet)LuaObject.checkSelf(l);
			HeroActionType action;
			LuaObject.checkEnum<HeroActionType>(l, 2, out action);
			businessCardHeroSet.Action = action;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B1F RID: 97055 RVA: 0x00683CD8 File Offset: 0x00681ED8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PositionIndex(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroSet businessCardHeroSet = (BusinessCardHeroSet)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroSet.PositionIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B20 RID: 97056 RVA: 0x00683D2C File Offset: 0x00681F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PositionIndex(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroSet businessCardHeroSet = (BusinessCardHeroSet)LuaObject.checkSelf(l);
			int positionIndex;
			LuaObject.checkType(l, 2, out positionIndex);
			businessCardHeroSet.PositionIndex = positionIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B21 RID: 97057 RVA: 0x00683D84 File Offset: 0x00681F84
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BusinessCardHeroSet");
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.ToProtocol_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.ToProtocols_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.FromProtocol_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.FromProtocols_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache3);
		string name = "HeroId";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.get_HeroId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.set_HeroId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache5, true);
		string name2 = "Direction";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.get_Direction);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.set_Direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache7, true);
		string name3 = "Action";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.get_Action);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.set_Action);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cache9, true);
		string name4 = "PositionIndex";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.get_PositionIndex);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.set_PositionIndex);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.<>f__mg$cacheC, typeof(BusinessCardHeroSet));
	}

	// Token: 0x0400E14A RID: 57674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E14B RID: 57675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E14C RID: 57676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E14D RID: 57677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E14E RID: 57678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E14F RID: 57679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E150 RID: 57680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E151 RID: 57681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E152 RID: 57682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E153 RID: 57683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E154 RID: 57684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E155 RID: 57685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E156 RID: 57686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
