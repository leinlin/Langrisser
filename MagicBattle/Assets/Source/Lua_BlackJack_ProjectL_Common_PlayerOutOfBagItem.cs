using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200125D RID: 4701
[Preserve]
public class Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem : LuaObject
{
	// Token: 0x06018852 RID: 100434 RVA: 0x006E5A8C File Offset: 0x006E3C8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayerOutOfBagItem o = new PlayerOutOfBagItem();
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

	// Token: 0x06018853 RID: 100435 RVA: 0x006E5AD4 File Offset: 0x006E3CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPB_s(IntPtr l)
	{
		int result;
		try
		{
			PlayerOutOfBagItem resource;
			LuaObject.checkType<PlayerOutOfBagItem>(l, 1, out resource);
			ProResource o = PlayerOutOfBagItem.ToPB(resource);
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

	// Token: 0x06018854 RID: 100436 RVA: 0x006E5B28 File Offset: 0x006E3D28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FromPB_s(IntPtr l)
	{
		int result;
		try
		{
			ProResource pbResource;
			LuaObject.checkType<ProResource>(l, 1, out pbResource);
			PlayerOutOfBagItem o = PlayerOutOfBagItem.FromPB(pbResource);
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

	// Token: 0x06018855 RID: 100437 RVA: 0x006E5B7C File Offset: 0x006E3D7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeadFrames(IntPtr l)
	{
		int result;
		try
		{
			PlayerOutOfBagItem playerOutOfBagItem = (PlayerOutOfBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerOutOfBagItem.HeadFrames);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018856 RID: 100438 RVA: 0x006E5BD0 File Offset: 0x006E3DD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeadFrames(IntPtr l)
	{
		int result;
		try
		{
			PlayerOutOfBagItem playerOutOfBagItem = (PlayerOutOfBagItem)LuaObject.checkSelf(l);
			List<int> headFrames;
			LuaObject.checkType<List<int>>(l, 2, out headFrames);
			playerOutOfBagItem.HeadFrames = headFrames;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018857 RID: 100439 RVA: 0x006E5C28 File Offset: 0x006E3E28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroSkinIds(IntPtr l)
	{
		int result;
		try
		{
			PlayerOutOfBagItem playerOutOfBagItem = (PlayerOutOfBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerOutOfBagItem.HeroSkinIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018858 RID: 100440 RVA: 0x006E5C7C File Offset: 0x006E3E7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroSkinIds(IntPtr l)
	{
		int result;
		try
		{
			PlayerOutOfBagItem playerOutOfBagItem = (PlayerOutOfBagItem)LuaObject.checkSelf(l);
			List<int> heroSkinIds;
			LuaObject.checkType<List<int>>(l, 2, out heroSkinIds);
			playerOutOfBagItem.HeroSkinIds = heroSkinIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018859 RID: 100441 RVA: 0x006E5CD4 File Offset: 0x006E3ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierSkinIds(IntPtr l)
	{
		int result;
		try
		{
			PlayerOutOfBagItem playerOutOfBagItem = (PlayerOutOfBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerOutOfBagItem.SoldierSkinIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601885A RID: 100442 RVA: 0x006E5D28 File Offset: 0x006E3F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoldierSkinIds(IntPtr l)
	{
		int result;
		try
		{
			PlayerOutOfBagItem playerOutOfBagItem = (PlayerOutOfBagItem)LuaObject.checkSelf(l);
			List<int> soldierSkinIds;
			LuaObject.checkType<List<int>>(l, 2, out soldierSkinIds);
			playerOutOfBagItem.SoldierSkinIds = soldierSkinIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601885B RID: 100443 RVA: 0x006E5D80 File Offset: 0x006E3F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EquipmentIds(IntPtr l)
	{
		int result;
		try
		{
			PlayerOutOfBagItem playerOutOfBagItem = (PlayerOutOfBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerOutOfBagItem.EquipmentIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601885C RID: 100444 RVA: 0x006E5DD4 File Offset: 0x006E3FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EquipmentIds(IntPtr l)
	{
		int result;
		try
		{
			PlayerOutOfBagItem playerOutOfBagItem = (PlayerOutOfBagItem)LuaObject.checkSelf(l);
			List<int> equipmentIds;
			LuaObject.checkType<List<int>>(l, 2, out equipmentIds);
			playerOutOfBagItem.EquipmentIds = equipmentIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601885D RID: 100445 RVA: 0x006E5E2C File Offset: 0x006E402C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MonthCards(IntPtr l)
	{
		int result;
		try
		{
			PlayerOutOfBagItem playerOutOfBagItem = (PlayerOutOfBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerOutOfBagItem.MonthCards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601885E RID: 100446 RVA: 0x006E5E80 File Offset: 0x006E4080
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MonthCards(IntPtr l)
	{
		int result;
		try
		{
			PlayerOutOfBagItem playerOutOfBagItem = (PlayerOutOfBagItem)LuaObject.checkSelf(l);
			List<MonthCard> monthCards;
			LuaObject.checkType<List<MonthCard>>(l, 2, out monthCards);
			playerOutOfBagItem.MonthCards = monthCards;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601885F RID: 100447 RVA: 0x006E5ED8 File Offset: 0x006E40D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.PlayerOutOfBagItem");
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.ToPB_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.FromPB_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache1);
		string name = "HeadFrames";
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.get_HeadFrames);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.set_HeadFrames);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache3, true);
		string name2 = "HeroSkinIds";
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.get_HeroSkinIds);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.set_HeroSkinIds);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache5, true);
		string name3 = "SoldierSkinIds";
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.get_SoldierSkinIds);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.set_SoldierSkinIds);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache7, true);
		string name4 = "EquipmentIds";
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.get_EquipmentIds);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.set_EquipmentIds);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cache9, true);
		string name5 = "MonthCards";
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.get_MonthCards);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.set_MonthCards);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.<>f__mg$cacheC, typeof(PlayerOutOfBagItem));
	}

	// Token: 0x0400ED7A RID: 60794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400ED7B RID: 60795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400ED7C RID: 60796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400ED7D RID: 60797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400ED7E RID: 60798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400ED7F RID: 60799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400ED80 RID: 60800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400ED81 RID: 60801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400ED82 RID: 60802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400ED83 RID: 60803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400ED84 RID: 60804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400ED85 RID: 60805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400ED86 RID: 60806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
