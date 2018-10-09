using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200121C RID: 4636
[Preserve]
public class Lua_BlackJack_ProjectL_Common_EquipmentBagItem : LuaObject
{
	// Token: 0x060180B4 RID: 98484 RVA: 0x006ABB70 File Offset: 0x006A9D70
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
			EquipmentBagItem o = new EquipmentBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x060180B5 RID: 98485 RVA: 0x006ABBEC File Offset: 0x006A9DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEnchant(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			bool b = equipmentBagItem.IsEnchant();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180B6 RID: 98486 RVA: 0x006ABC40 File Offset: 0x006A9E40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsEquipmentEnhanced(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			bool b = equipmentBagItem.IsEquipmentEnhanced();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180B7 RID: 98487 RVA: 0x006ABC94 File Offset: 0x006A9E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEquipmentLevelUped(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			int bornStarLevel;
			LuaObject.checkType(l, 2, out bornStarLevel);
			bool b = equipmentBagItem.IsEquipmentLevelUped(bornStarLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180B8 RID: 98488 RVA: 0x006ABCF8 File Offset: 0x006A9EF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToBattleHeroEquipment(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			BattleHeroEquipment o = equipmentBagItem.ToBattleHeroEquipment();
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

	// Token: 0x060180B9 RID: 98489 RVA: 0x006ABD4C File Offset: 0x006A9F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPBGoods(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			ProGoods o = equipmentBagItem.ToPBGoods();
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

	// Token: 0x060180BA RID: 98490 RVA: 0x006ABDA0 File Offset: 0x006A9FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnchantProperties(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBagItem.EnchantProperties);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180BB RID: 98491 RVA: 0x006ABDF4 File Offset: 0x006A9FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnchantProperties(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			List<CommonBattleProperty> enchantProperties;
			LuaObject.checkType<List<CommonBattleProperty>>(l, 2, out enchantProperties);
			equipmentBagItem.EnchantProperties = enchantProperties;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180BC RID: 98492 RVA: 0x006ABE4C File Offset: 0x006AA04C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBagItem.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180BD RID: 98493 RVA: 0x006ABEA0 File Offset: 0x006AA0A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			equipmentBagItem.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180BE RID: 98494 RVA: 0x006ABEF8 File Offset: 0x006AA0F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Exp(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBagItem.Exp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180BF RID: 98495 RVA: 0x006ABF4C File Offset: 0x006AA14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Exp(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			int exp;
			LuaObject.checkType(l, 2, out exp);
			equipmentBagItem.Exp = exp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180C0 RID: 98496 RVA: 0x006ABFA4 File Offset: 0x006AA1A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StarLevel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBagItem.StarLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180C1 RID: 98497 RVA: 0x006ABFF8 File Offset: 0x006AA1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StarLevel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			int starLevel;
			LuaObject.checkType(l, 2, out starLevel);
			equipmentBagItem.StarLevel = starLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180C2 RID: 98498 RVA: 0x006AC050 File Offset: 0x006AA250
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Locked(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBagItem.Locked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180C3 RID: 98499 RVA: 0x006AC0A4 File Offset: 0x006AA2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Locked(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			bool locked;
			LuaObject.checkType(l, 2, out locked);
			equipmentBagItem.Locked = locked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180C4 RID: 98500 RVA: 0x006AC0FC File Offset: 0x006AA2FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ResonanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentBagItem.ResonanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180C5 RID: 98501 RVA: 0x006AC150 File Offset: 0x006AA350
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ResonanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentBagItem equipmentBagItem = (EquipmentBagItem)LuaObject.checkSelf(l);
			int resonanceId;
			LuaObject.checkType(l, 2, out resonanceId);
			equipmentBagItem.ResonanceId = resonanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180C6 RID: 98502 RVA: 0x006AC1A8 File Offset: 0x006AA3A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.EquipmentBagItem");
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.IsEnchant);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.IsEquipmentEnhanced);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.IsEquipmentLevelUped);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.ToBattleHeroEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.ToPBGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache4);
		string name = "EnchantProperties";
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.get_EnchantProperties);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.set_EnchantProperties);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache6, true);
		string name2 = "Level";
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.get_Level);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.set_Level);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache8, true);
		string name3 = "Exp";
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.get_Exp);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.set_Exp);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheA, true);
		string name4 = "StarLevel";
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.get_StarLevel);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.set_StarLevel);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheC, true);
		string name5 = "Locked";
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.get_Locked);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.set_Locked);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheE, true);
		string name6 = "ResonanceId";
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.get_ResonanceId);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.set_ResonanceId);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache10, true);
		if (Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_EquipmentBagItem.<>f__mg$cache11, typeof(EquipmentBagItem), typeof(BagItemBase));
	}

	// Token: 0x0400E65E RID: 58974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E65F RID: 58975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E660 RID: 58976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E661 RID: 58977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E662 RID: 58978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E663 RID: 58979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E664 RID: 58980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E665 RID: 58981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E666 RID: 58982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E667 RID: 58983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E668 RID: 58984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E669 RID: 58985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E66A RID: 58986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E66B RID: 58987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E66C RID: 58988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E66D RID: 58989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E66E RID: 58990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E66F RID: 58991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
