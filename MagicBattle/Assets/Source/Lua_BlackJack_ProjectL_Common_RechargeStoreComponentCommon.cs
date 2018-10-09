using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001273 RID: 4723
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon : LuaObject
{
	// Token: 0x060189B9 RID: 100793 RVA: 0x006EF640 File Offset: 0x006ED840
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon o = new RechargeStoreComponentCommon();
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

	// Token: 0x060189BA RID: 100794 RVA: 0x006EF688 File Offset: 0x006ED888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			string name = rechargeStoreComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189BB RID: 100795 RVA: 0x006EF6DC File Offset: 0x006ED8DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			rechargeStoreComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189BC RID: 100796 RVA: 0x006EF728 File Offset: 0x006ED928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			rechargeStoreComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189BD RID: 100797 RVA: 0x006EF774 File Offset: 0x006ED974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			rechargeStoreComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189BE RID: 100798 RVA: 0x006EF7C0 File Offset: 0x006ED9C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			rechargeStoreComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189BF RID: 100799 RVA: 0x006EF818 File Offset: 0x006EDA18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			rechargeStoreComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189C0 RID: 100800 RVA: 0x006EF864 File Offset: 0x006EDA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGoodsBought(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			bool b = rechargeStoreComponentCommon.IsGoodsBought(goodsId);
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

	// Token: 0x060189C1 RID: 100801 RVA: 0x006EF8C8 File Offset: 0x006EDAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CaculateGotCrystalNums(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			int i = rechargeStoreComponentCommon.CaculateGotCrystalNums(goodsId);
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

	// Token: 0x060189C2 RID: 100802 RVA: 0x006EF92C File Offset: 0x006EDB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyGoods(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			rechargeStoreComponentCommon.m_luaExportHelper.BuyGoods(goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189C3 RID: 100803 RVA: 0x006EF988 File Offset: 0x006EDB88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_BuyRechargeStoreGoodsEvent(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			rechargeStoreComponentCommon.m_luaExportHelper.__callDele_BuyRechargeStoreGoodsEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189C4 RID: 100804 RVA: 0x006EF9E4 File Offset: 0x006EDBE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_BuyRechargeStoreGoodsEvent(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			rechargeStoreComponentCommon.m_luaExportHelper.__clearDele_BuyRechargeStoreGoodsEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189C5 RID: 100805 RVA: 0x006EFA40 File Offset: 0x006EDC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_BuyStoreItemEvent(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			rechargeStoreComponentCommon.m_luaExportHelper.__callDele_BuyStoreItemEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189C6 RID: 100806 RVA: 0x006EFAAC File Offset: 0x006EDCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_BuyStoreItemEvent(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			rechargeStoreComponentCommon.m_luaExportHelper.__clearDele_BuyStoreItemEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189C7 RID: 100807 RVA: 0x006EFB18 File Offset: 0x006EDD18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rechargeStoreComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189C8 RID: 100808 RVA: 0x006EFB70 File Offset: 0x006EDD70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			rechargeStoreComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189C9 RID: 100809 RVA: 0x006EFBCC File Offset: 0x006EDDCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargeStoreDS(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rechargeStoreComponentCommon.m_luaExportHelper.m_rechargeStoreDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189CA RID: 100810 RVA: 0x006EFC24 File Offset: 0x006EDE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargeStoreDS(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			DataSectionRechargeStore rechargeStoreDS;
			LuaObject.checkType<DataSectionRechargeStore>(l, 2, out rechargeStoreDS);
			rechargeStoreComponentCommon.m_luaExportHelper.m_rechargeStoreDS = rechargeStoreDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189CB RID: 100811 RVA: 0x006EFC80 File Offset: 0x006EDE80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rechargeStoreComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189CC RID: 100812 RVA: 0x006EFCD8 File Offset: 0x006EDED8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			rechargeStoreComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189CD RID: 100813 RVA: 0x006EFD34 File Offset: 0x006EDF34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BuyRechargeStoreGoodsEvent(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					rechargeStoreComponentCommon.BuyRechargeStoreGoodsEvent += value;
				}
				else if (num == 2)
				{
					rechargeStoreComponentCommon.BuyRechargeStoreGoodsEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189CE RID: 100814 RVA: 0x006EFDB4 File Offset: 0x006EDFB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BuyStoreItemEvent(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					rechargeStoreComponentCommon.BuyStoreItemEvent += value;
				}
				else if (num == 2)
				{
					rechargeStoreComponentCommon.BuyStoreItemEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189CF RID: 100815 RVA: 0x006EFE34 File Offset: 0x006EE034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rechargeStoreComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189D0 RID: 100816 RVA: 0x006EFE88 File Offset: 0x006EE088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponentCommon rechargeStoreComponentCommon = (RechargeStoreComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			rechargeStoreComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189D1 RID: 100817 RVA: 0x006EFEE0 File Offset: 0x006EE0E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RechargeStoreComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.IsGoodsBought);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.CaculateGotCrystalNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.BuyGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.__callDele_BuyRechargeStoreGoodsEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.__clearDele_BuyRechargeStoreGoodsEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.__callDele_BuyStoreItemEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.__clearDele_BuyStoreItemEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheC);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheE, true);
		string name2 = "m_rechargeStoreDS";
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.get_m_rechargeStoreDS);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.set_m_rechargeStoreDS);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache10, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache12, true);
		string name4 = "BuyRechargeStoreGoodsEvent";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.set_BuyRechargeStoreGoodsEvent);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache13, true);
		string name5 = "BuyStoreItemEvent";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.set_BuyStoreItemEvent);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache14, true);
		string name6 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.get_Owner);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache16, true);
		if (Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.<>f__mg$cache17, typeof(RechargeStoreComponentCommon));
	}

	// Token: 0x0400EEB5 RID: 61109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EEB6 RID: 61110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EEB7 RID: 61111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EEB8 RID: 61112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EEB9 RID: 61113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EEBA RID: 61114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EEBB RID: 61115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EEBC RID: 61116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EEBD RID: 61117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EEBE RID: 61118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EEBF RID: 61119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EEC0 RID: 61120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EEC1 RID: 61121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EEC2 RID: 61122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EEC3 RID: 61123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EEC4 RID: 61124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EEC5 RID: 61125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EEC6 RID: 61126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EEC7 RID: 61127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EEC8 RID: 61128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EEC9 RID: 61129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EECA RID: 61130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EECB RID: 61131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EECC RID: 61132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
