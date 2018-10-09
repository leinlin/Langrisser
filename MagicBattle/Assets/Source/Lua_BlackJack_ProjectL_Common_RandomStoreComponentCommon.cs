using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001268 RID: 4712
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon : LuaObject
{
	// Token: 0x060188EE RID: 100590 RVA: 0x006E9CE4 File Offset: 0x006E7EE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon o = new RandomStoreComponentCommon();
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

	// Token: 0x060188EF RID: 100591 RVA: 0x006E9D2C File Offset: 0x006E7F2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			string name = randomStoreComponentCommon.GetName();
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

	// Token: 0x060188F0 RID: 100592 RVA: 0x006E9D80 File Offset: 0x006E7F80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			randomStoreComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188F1 RID: 100593 RVA: 0x006E9DCC File Offset: 0x006E7FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			randomStoreComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188F2 RID: 100594 RVA: 0x006E9E18 File Offset: 0x006E8018
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			randomStoreComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188F3 RID: 100595 RVA: 0x006E9E64 File Offset: 0x006E8064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			randomStoreComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188F4 RID: 100596 RVA: 0x006E9EBC File Offset: 0x006E80BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			randomStoreComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188F5 RID: 100597 RVA: 0x006E9F08 File Offset: 0x006E8108
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFlushManualFlushNums(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			randomStoreComponentCommon.OnFlushManualFlushNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188F6 RID: 100598 RVA: 0x006E9F54 File Offset: 0x006E8154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAutoFlushStore(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			bool b = randomStoreComponentCommon.CanAutoFlushStore(store);
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

	// Token: 0x060188F7 RID: 100599 RVA: 0x006E9FB8 File Offset: 0x006E81B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanBuyRandomStoreItem(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int index;
			LuaObject.checkType(l, 3, out index);
			int selectedIndex;
			LuaObject.checkType(l, 4, out selectedIndex);
			int i = randomStoreComponentCommon.CanBuyRandomStoreItem(storeId, index, selectedIndex);
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

	// Token: 0x060188F8 RID: 100600 RVA: 0x006EA034 File Offset: 0x006E8234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBoughtStoreItem(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			RandomStoreItem storeItem;
			LuaObject.checkType<RandomStoreItem>(l, 2, out storeItem);
			bool b = randomStoreComponentCommon.m_luaExportHelper.IsBoughtStoreItem(storeItem);
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

	// Token: 0x060188F9 RID: 100601 RVA: 0x006EA09C File Offset: 0x006E829C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanManualFlushStore(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			ConfigDataRandomStoreInfo storeInfo;
			LuaObject.checkType<ConfigDataRandomStoreInfo>(l, 3, out storeInfo);
			int i = randomStoreComponentCommon.m_luaExportHelper.CanManualFlushStore(store, storeInfo);
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

	// Token: 0x060188FA RID: 100602 RVA: 0x006EA110 File Offset: 0x006E8310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBuyStoreItem(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			randomStoreComponentCommon.m_luaExportHelper.OnBuyStoreItem(storeId, goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188FB RID: 100603 RVA: 0x006EA17C File Offset: 0x006E837C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_BuyStoreItemEvent(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			randomStoreComponentCommon.m_luaExportHelper.__callDele_BuyStoreItemEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188FC RID: 100604 RVA: 0x006EA1E8 File Offset: 0x006E83E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_BuyStoreItemEvent(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			randomStoreComponentCommon.m_luaExportHelper.__clearDele_BuyStoreItemEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188FD RID: 100605 RVA: 0x006EA254 File Offset: 0x006E8454
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStoreComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188FE RID: 100606 RVA: 0x006EA2AC File Offset: 0x006E84AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			randomStoreComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188FF RID: 100607 RVA: 0x006EA308 File Offset: 0x006E8508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStoreComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018900 RID: 100608 RVA: 0x006EA360 File Offset: 0x006E8560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			randomStoreComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018901 RID: 100609 RVA: 0x006EA3BC File Offset: 0x006E85BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStoreComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018902 RID: 100610 RVA: 0x006EA414 File Offset: 0x006E8614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			randomStoreComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018903 RID: 100611 RVA: 0x006EA470 File Offset: 0x006E8670
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_randomStoreDS(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStoreComponentCommon.m_luaExportHelper.m_randomStoreDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018904 RID: 100612 RVA: 0x006EA4C8 File Offset: 0x006E86C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_randomStoreDS(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			DataSectionRandomStore randomStoreDS;
			LuaObject.checkType<DataSectionRandomStore>(l, 2, out randomStoreDS);
			randomStoreComponentCommon.m_luaExportHelper.m_randomStoreDS = randomStoreDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018905 RID: 100613 RVA: 0x006EA524 File Offset: 0x006E8724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BuyStoreItemEvent(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					randomStoreComponentCommon.BuyStoreItemEvent += value;
				}
				else if (num == 2)
				{
					randomStoreComponentCommon.BuyStoreItemEvent -= value;
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

	// Token: 0x06018906 RID: 100614 RVA: 0x006EA5A4 File Offset: 0x006E87A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStoreComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018907 RID: 100615 RVA: 0x006EA5F8 File Offset: 0x006E87F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponentCommon randomStoreComponentCommon = (RandomStoreComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			randomStoreComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018908 RID: 100616 RVA: 0x006EA650 File Offset: 0x006E8850
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RandomStoreComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.OnFlushManualFlushNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.CanAutoFlushStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.CanBuyRandomStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.IsBoughtStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.CanManualFlushStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.OnBuyStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.__callDele_BuyStoreItemEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.__clearDele_BuyStoreItemEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheD);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cacheF, true);
		string name2 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache11, true);
		string name3 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.get_m_bag);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache13, true);
		string name4 = "m_randomStoreDS";
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.get_m_randomStoreDS);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.set_m_randomStoreDS);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache15, true);
		string name5 = "BuyStoreItemEvent";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.set_BuyStoreItemEvent);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache16, true);
		string name6 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.get_Owner);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache18, true);
		if (Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.<>f__mg$cache19, typeof(RandomStoreComponentCommon));
	}

	// Token: 0x0400EE00 RID: 60928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EE01 RID: 60929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EE02 RID: 60930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EE03 RID: 60931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EE04 RID: 60932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EE05 RID: 60933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EE06 RID: 60934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EE07 RID: 60935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EE08 RID: 60936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EE09 RID: 60937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EE0A RID: 60938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EE0B RID: 60939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EE0C RID: 60940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EE0D RID: 60941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EE0E RID: 60942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EE0F RID: 60943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EE10 RID: 60944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EE11 RID: 60945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EE12 RID: 60946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EE13 RID: 60947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EE14 RID: 60948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EE15 RID: 60949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EE16 RID: 60950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EE17 RID: 60951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EE18 RID: 60952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EE19 RID: 60953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
