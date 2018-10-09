using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011B4 RID: 4532
[Preserve]
public class Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem : LuaObject
{
	// Token: 0x06017792 RID: 96146 RVA: 0x00669668 File Offset: 0x00667868
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
			AddHeroFavorabilityUseableBagItem o = new AddHeroFavorabilityUseableBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x06017793 RID: 96147 RVA: 0x006696E4 File Offset: 0x006678E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HaveEffect(IntPtr l)
	{
		int result;
		try
		{
			AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = (AddHeroFavorabilityUseableBagItem)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			object[] param;
			LuaObject.checkParams<object>(l, 3, out param);
			int i = addHeroFavorabilityUseableBagItem.HaveEffect(owner, param);
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

	// Token: 0x06017794 RID: 96148 RVA: 0x00669754 File Offset: 0x00667954
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CalculateAddFavorabilityExp(IntPtr l)
	{
		int result;
		try
		{
			AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = (AddHeroFavorabilityUseableBagItem)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = addHeroFavorabilityUseableBagItem.CalculateAddFavorabilityExp(heroId);
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

	// Token: 0x06017795 RID: 96149 RVA: 0x006697B8 File Offset: 0x006679B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SpecificHeroAddFavorabilityExpBasicValue(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 10000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017796 RID: 96150 RVA: 0x00669800 File Offset: 0x00667A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SpecificHeroes(IntPtr l)
	{
		int result;
		try
		{
			AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = (AddHeroFavorabilityUseableBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, addHeroFavorabilityUseableBagItem.SpecificHeroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017797 RID: 96151 RVA: 0x00669854 File Offset: 0x00667A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SpecificHeroes(IntPtr l)
	{
		int result;
		try
		{
			AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = (AddHeroFavorabilityUseableBagItem)LuaObject.checkSelf(l);
			List<int> specificHeroes;
			LuaObject.checkType<List<int>>(l, 2, out specificHeroes);
			addHeroFavorabilityUseableBagItem.SpecificHeroes = specificHeroes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017798 RID: 96152 RVA: 0x006698AC File Offset: 0x00667AAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NormalAddExp(IntPtr l)
	{
		int result;
		try
		{
			AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = (AddHeroFavorabilityUseableBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, addHeroFavorabilityUseableBagItem.NormalAddExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017799 RID: 96153 RVA: 0x00669900 File Offset: 0x00667B00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NormalAddExp(IntPtr l)
	{
		int result;
		try
		{
			AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = (AddHeroFavorabilityUseableBagItem)LuaObject.checkSelf(l);
			int normalAddExp;
			LuaObject.checkType(l, 2, out normalAddExp);
			addHeroFavorabilityUseableBagItem.NormalAddExp = normalAddExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601779A RID: 96154 RVA: 0x00669958 File Offset: 0x00667B58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SpecificHeroAddFavorabilityExpMultipleValue(IntPtr l)
	{
		int result;
		try
		{
			AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = (AddHeroFavorabilityUseableBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, addHeroFavorabilityUseableBagItem.SpecificHeroAddFavorabilityExpMultipleValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601779B RID: 96155 RVA: 0x006699AC File Offset: 0x00667BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SpecificHeroAddFavorabilityExpMultipleValue(IntPtr l)
	{
		int result;
		try
		{
			AddHeroFavorabilityUseableBagItem addHeroFavorabilityUseableBagItem = (AddHeroFavorabilityUseableBagItem)LuaObject.checkSelf(l);
			int specificHeroAddFavorabilityExpMultipleValue;
			LuaObject.checkType(l, 2, out specificHeroAddFavorabilityExpMultipleValue);
			addHeroFavorabilityUseableBagItem.SpecificHeroAddFavorabilityExpMultipleValue = specificHeroAddFavorabilityExpMultipleValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601779C RID: 96156 RVA: 0x00669A04 File Offset: 0x00667C04
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.AddHeroFavorabilityUseableBagItem");
		if (Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.HaveEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.CalculateAddFavorabilityExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache1);
		string name = "SpecificHeroAddFavorabilityExpBasicValue";
		if (Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.get_SpecificHeroAddFavorabilityExpBasicValue);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache2, null, false);
		string name2 = "SpecificHeroes";
		if (Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.get_SpecificHeroes);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.set_SpecificHeroes);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache4, true);
		string name3 = "NormalAddExp";
		if (Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.get_NormalAddExp);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.set_NormalAddExp);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache6, true);
		string name4 = "SpecificHeroAddFavorabilityExpMultipleValue";
		if (Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.get_SpecificHeroAddFavorabilityExpMultipleValue);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.set_SpecificHeroAddFavorabilityExpMultipleValue);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache8, true);
		if (Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.<>f__mg$cache9, typeof(AddHeroFavorabilityUseableBagItem), typeof(UseableBagItem));
	}

	// Token: 0x0400DE0C RID: 56844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DE0D RID: 56845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DE0E RID: 56846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DE0F RID: 56847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DE10 RID: 56848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DE11 RID: 56849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DE12 RID: 56850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DE13 RID: 56851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DE14 RID: 56852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DE15 RID: 56853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
