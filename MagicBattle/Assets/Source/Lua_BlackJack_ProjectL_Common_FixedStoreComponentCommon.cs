using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200121E RID: 4638
[Preserve]
public class Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon : LuaObject
{
	// Token: 0x060180D3 RID: 98515 RVA: 0x006AC8AC File Offset: 0x006AAAAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon o = new FixedStoreComponentCommon();
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

	// Token: 0x060180D4 RID: 98516 RVA: 0x006AC8F4 File Offset: 0x006AAAF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			string name = fixedStoreComponentCommon.GetName();
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

	// Token: 0x060180D5 RID: 98517 RVA: 0x006AC948 File Offset: 0x006AAB48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			fixedStoreComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180D6 RID: 98518 RVA: 0x006AC994 File Offset: 0x006AAB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			fixedStoreComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180D7 RID: 98519 RVA: 0x006AC9E0 File Offset: 0x006AABE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			fixedStoreComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180D8 RID: 98520 RVA: 0x006ACA2C File Offset: 0x006AAC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			fixedStoreComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180D9 RID: 98521 RVA: 0x006ACA84 File Offset: 0x006AAC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			fixedStoreComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180DA RID: 98522 RVA: 0x006ACAD0 File Offset: 0x006AACD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsSoldOut(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo itemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out itemConfig);
			FixedStoreItem item;
			LuaObject.checkType<FixedStoreItem>(l, 3, out item);
			bool b = fixedStoreComponentCommon.IsSoldOut(itemConfig, item);
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

	// Token: 0x060180DB RID: 98523 RVA: 0x006ACB40 File Offset: 0x006AAD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInSaleTime(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo itemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out itemConfig);
			bool b = fixedStoreComponentCommon.IsInSaleTime(itemConfig);
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

	// Token: 0x060180DC RID: 98524 RVA: 0x006ACBA4 File Offset: 0x006AADA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanBuyGoods(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int selectedIndex;
			LuaObject.checkType(l, 4, out selectedIndex);
			int i = fixedStoreComponentCommon.CanBuyGoods(storeId, goodsId, selectedIndex);
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

	// Token: 0x060180DD RID: 98525 RVA: 0x006ACC20 File Offset: 0x006AAE20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CaculateCurrencyCount(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo storeItemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out storeItemConfig);
			bool isFirstBuy;
			LuaObject.checkType(l, 3, out isFirstBuy);
			int i = fixedStoreComponentCommon.CaculateCurrencyCount(storeItemConfig, isFirstBuy);
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

	// Token: 0x060180DE RID: 98526 RVA: 0x006ACC90 File Offset: 0x006AAE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOnDiscountPeriod(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo storeItemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out storeItemConfig);
			bool b = fixedStoreComponentCommon.IsOnDiscountPeriod(storeItemConfig);
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

	// Token: 0x060180DF RID: 98527 RVA: 0x006ACCF4 File Offset: 0x006AAEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStore(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			FixedStore store = fixedStoreComponentCommon.GetStore(storeId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, store);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180E0 RID: 98528 RVA: 0x006ACD58 File Offset: 0x006AAF58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFlushBoughtNums(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			fixedStoreComponentCommon.m_luaExportHelper.OnFlushBoughtNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180E1 RID: 98529 RVA: 0x006ACDAC File Offset: 0x006AAFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanBuyFixedStoreItem(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo itemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out itemConfig);
			FixedStoreItem item;
			LuaObject.checkType<FixedStoreItem>(l, 3, out item);
			int i = fixedStoreComponentCommon.m_luaExportHelper.CanBuyFixedStoreItem(itemConfig, item);
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

	// Token: 0x060180E2 RID: 98530 RVA: 0x006ACE20 File Offset: 0x006AB020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStoreOfferingById(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			FixedStore storeOfferingById = fixedStoreComponentCommon.m_luaExportHelper.GetStoreOfferingById(storeId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeOfferingById);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180E3 RID: 98531 RVA: 0x006ACE88 File Offset: 0x006AB088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyStoreItem(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			FixedStoreItem storeItem;
			LuaObject.checkType<FixedStoreItem>(l, 3, out storeItem);
			int count;
			LuaObject.checkType(l, 4, out count);
			fixedStoreComponentCommon.m_luaExportHelper.BuyStoreItem(storeId, storeItem, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180E4 RID: 98532 RVA: 0x006ACF00 File Offset: 0x006AB100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBuyStoreItem(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			FixedStoreItem storeItem;
			LuaObject.checkType<FixedStoreItem>(l, 2, out storeItem);
			int count;
			LuaObject.checkType(l, 3, out count);
			fixedStoreComponentCommon.m_luaExportHelper.OnBuyStoreItem(storeItem, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180E5 RID: 98533 RVA: 0x006ACF6C File Offset: 0x006AB16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddSkin(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			FixedStoreItem storeItem;
			LuaObject.checkType<FixedStoreItem>(l, 2, out storeItem);
			fixedStoreComponentCommon.m_luaExportHelper.OnAddSkin(storeItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180E6 RID: 98534 RVA: 0x006ACFC8 File Offset: 0x006AB1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_BuyStoreItemEvent(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			fixedStoreComponentCommon.m_luaExportHelper.__callDele_BuyStoreItemEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180E7 RID: 98535 RVA: 0x006AD034 File Offset: 0x006AB234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_BuyStoreItemEvent(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			fixedStoreComponentCommon.m_luaExportHelper.__clearDele_BuyStoreItemEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180E8 RID: 98536 RVA: 0x006AD0A0 File Offset: 0x006AB2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180E9 RID: 98537 RVA: 0x006AD0F8 File Offset: 0x006AB2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			fixedStoreComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180EA RID: 98538 RVA: 0x006AD154 File Offset: 0x006AB354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180EB RID: 98539 RVA: 0x006AD1AC File Offset: 0x006AB3AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			fixedStoreComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180EC RID: 98540 RVA: 0x006AD208 File Offset: 0x006AB408
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180ED RID: 98541 RVA: 0x006AD260 File Offset: 0x006AB460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			fixedStoreComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180EE RID: 98542 RVA: 0x006AD2BC File Offset: 0x006AB4BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_resource(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreComponentCommon.m_luaExportHelper.m_resource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180EF RID: 98543 RVA: 0x006AD314 File Offset: 0x006AB514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resource(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			ResourceComponentCommon resource;
			LuaObject.checkType<ResourceComponentCommon>(l, 2, out resource);
			fixedStoreComponentCommon.m_luaExportHelper.m_resource = resource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180F0 RID: 98544 RVA: 0x006AD370 File Offset: 0x006AB570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fixedStoreDS(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreComponentCommon.m_luaExportHelper.m_fixedStoreDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180F1 RID: 98545 RVA: 0x006AD3C8 File Offset: 0x006AB5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fixedStoreDS(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			DataSectionFixedStore fixedStoreDS;
			LuaObject.checkType<DataSectionFixedStore>(l, 2, out fixedStoreDS);
			fixedStoreComponentCommon.m_luaExportHelper.m_fixedStoreDS = fixedStoreDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180F2 RID: 98546 RVA: 0x006AD424 File Offset: 0x006AB624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BuyStoreItemEvent(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fixedStoreComponentCommon.BuyStoreItemEvent += value;
				}
				else if (num == 2)
				{
					fixedStoreComponentCommon.BuyStoreItemEvent -= value;
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

	// Token: 0x060180F3 RID: 98547 RVA: 0x006AD4A4 File Offset: 0x006AB6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180F4 RID: 98548 RVA: 0x006AD4F8 File Offset: 0x006AB6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponentCommon fixedStoreComponentCommon = (FixedStoreComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			fixedStoreComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060180F5 RID: 98549 RVA: 0x006AD550 File Offset: 0x006AB750
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.FixedStoreComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.IsSoldOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.IsInSaleTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.CanBuyGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.CaculateCurrencyCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.IsOnDiscountPeriod);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.GetStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.OnFlushBoughtNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.CanBuyFixedStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.GetStoreOfferingById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.BuyStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.OnBuyStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.OnAddSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.__callDele_BuyStoreItemEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.__clearDele_BuyStoreItemEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache13);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache15, true);
		string name2 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.get_m_bag);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache17, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache19, true);
		string name4 = "m_resource";
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.get_m_resource);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.set_m_resource);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1B, true);
		string name5 = "m_fixedStoreDS";
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.get_m_fixedStoreDS);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.set_m_fixedStoreDS);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1D, true);
		string name6 = "BuyStoreItemEvent";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.set_BuyStoreItemEvent);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1E, true);
		string name7 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.get_Owner);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache20, true);
		if (Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.<>f__mg$cache21, typeof(FixedStoreComponentCommon));
	}

	// Token: 0x0400E679 RID: 59001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E67A RID: 59002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E67B RID: 59003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E67C RID: 59004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E67D RID: 59005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E67E RID: 59006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E67F RID: 59007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E680 RID: 59008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E681 RID: 59009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E682 RID: 59010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E683 RID: 59011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E684 RID: 59012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E685 RID: 59013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E686 RID: 59014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E687 RID: 59015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E688 RID: 59016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E689 RID: 59017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E68A RID: 59018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E68B RID: 59019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E68C RID: 59020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E68D RID: 59021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E68E RID: 59022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E68F RID: 59023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E690 RID: 59024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E691 RID: 59025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E692 RID: 59026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E693 RID: 59027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E694 RID: 59028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E695 RID: 59029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E696 RID: 59030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E697 RID: 59031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E698 RID: 59032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E699 RID: 59033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E69A RID: 59034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;
}
