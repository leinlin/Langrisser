using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200120F RID: 4623
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionResource : LuaObject
{
	// Token: 0x06017FF8 RID: 98296 RVA: 0x006A6828 File Offset: 0x006A4A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource o = new DataSectionResource();
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

	// Token: 0x06017FF9 RID: 98297 RVA: 0x006A6870 File Offset: 0x006A4A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			dataSectionResource.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FFA RID: 98298 RVA: 0x006A68BC File Offset: 0x006A4ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			object o = dataSectionResource.SerializeToClient();
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

	// Token: 0x06017FFB RID: 98299 RVA: 0x006A6910 File Offset: 0x006A4B10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllMonthCards(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			List<MonthCard> allMonthCards = dataSectionResource.GetAllMonthCards();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allMonthCards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FFC RID: 98300 RVA: 0x006A6964 File Offset: 0x006A4B64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindMonthCardById(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			int cardId;
			LuaObject.checkType(l, 2, out cardId);
			MonthCard o = dataSectionResource.FindMonthCardById(cardId);
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

	// Token: 0x06017FFD RID: 98301 RVA: 0x006A69C8 File Offset: 0x006A4BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMonthCard(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			int monthCardId;
			LuaObject.checkType(l, 2, out monthCardId);
			DateTime expiredTime;
			LuaObject.checkValueType<DateTime>(l, 3, out expiredTime);
			string goodsId;
			LuaObject.checkType(l, 4, out goodsId);
			dataSectionResource.AddMonthCard(monthCardId, expiredTime, goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FFE RID: 98302 RVA: 0x006A6A3C File Offset: 0x006A4C3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveMonthCard(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
				int monthCardId;
				LuaObject.checkType(l, 2, out monthCardId);
				bool b = dataSectionResource.RemoveMonthCard(monthCardId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(MonthCard)))
			{
				DataSectionResource dataSectionResource2 = (DataSectionResource)LuaObject.checkSelf(l);
				MonthCard monthCard;
				LuaObject.checkType<MonthCard>(l, 2, out monthCard);
				dataSectionResource2.RemoveMonthCard(monthCard);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function RemoveMonthCard to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FFF RID: 98303 RVA: 0x006A6B20 File Offset: 0x006A4D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasHeadFrameId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			bool b = dataSectionResource.HasHeadFrameId(headFrameId);
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

	// Token: 0x06018000 RID: 98304 RVA: 0x006A6B84 File Offset: 0x006A4D84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			bool b = dataSectionResource.AddHeadFrame(headFrameId);
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

	// Token: 0x06018001 RID: 98305 RVA: 0x006A6BE8 File Offset: 0x006A4DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasOwn(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			GoodsType goodtypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodtypeId);
			int id;
			LuaObject.checkType(l, 3, out id);
			bool b = dataSectionResource.HasOwn(goodtypeId, id);
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

	// Token: 0x06018002 RID: 98306 RVA: 0x006A6C58 File Offset: 0x006A4E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroSkin(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			int heroSkinId;
			LuaObject.checkType(l, 2, out heroSkinId);
			dataSectionResource.AddHeroSkin(heroSkinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018003 RID: 98307 RVA: 0x006A6CB0 File Offset: 0x006A4EB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			int soldierSkinId;
			LuaObject.checkType(l, 2, out soldierSkinId);
			dataSectionResource.AddSoldierSkin(soldierSkinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018004 RID: 98308 RVA: 0x006A6D08 File Offset: 0x006A4F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddEquipmentId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			int equipmentId;
			LuaObject.checkType(l, 2, out equipmentId);
			dataSectionResource.AddEquipmentId(equipmentId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018005 RID: 98309 RVA: 0x006A6D60 File Offset: 0x006A4F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitResource(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			PlayerOutOfBagItem resource;
			LuaObject.checkType<PlayerOutOfBagItem>(l, 2, out resource);
			dataSectionResource.InitResource(resource);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018006 RID: 98310 RVA: 0x006A6DB8 File Offset: 0x006A4FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resource(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionResource.m_resource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018007 RID: 98311 RVA: 0x006A6E0C File Offset: 0x006A500C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_resource(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			PlayerOutOfBagItem resource;
			LuaObject.checkType<PlayerOutOfBagItem>(l, 2, out resource);
			dataSectionResource.m_resource = resource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018008 RID: 98312 RVA: 0x006A6E64 File Offset: 0x006A5064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Resource(IntPtr l)
	{
		int result;
		try
		{
			DataSectionResource dataSectionResource = (DataSectionResource)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionResource.Resource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018009 RID: 98313 RVA: 0x006A6EB8 File Offset: 0x006A50B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionResource");
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.GetAllMonthCards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.FindMonthCardById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.AddMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.RemoveMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.HasHeadFrameId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.AddHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.HasOwn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.AddHeroSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.AddSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.AddEquipmentId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.InitResource);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheC);
		string name = "m_resource";
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.get_m_resource);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.set_m_resource);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheE, true);
		string name2 = "Resource";
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.get_Resource);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cacheF, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionResource.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionResource.<>f__mg$cache10, typeof(DataSectionResource), typeof(DataSection));
	}

	// Token: 0x0400E5BC RID: 58812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E5BD RID: 58813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E5BE RID: 58814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E5BF RID: 58815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E5C0 RID: 58816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E5C1 RID: 58817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E5C2 RID: 58818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E5C3 RID: 58819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E5C4 RID: 58820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E5C5 RID: 58821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E5C6 RID: 58822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E5C7 RID: 58823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E5C8 RID: 58824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E5C9 RID: 58825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E5CA RID: 58826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E5CB RID: 58827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E5CC RID: 58828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
