using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012C1 RID: 4801
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent : LuaObject
{
	// Token: 0x06019411 RID: 103441 RVA: 0x0073BF0C File Offset: 0x0073A10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent o = new FixedStoreComponent();
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

	// Token: 0x06019412 RID: 103442 RVA: 0x0073BF54 File Offset: 0x0073A154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			fixedStoreComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019413 RID: 103443 RVA: 0x0073BFA0 File Offset: 0x0073A1A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			fixedStoreComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019414 RID: 103444 RVA: 0x0073BFEC File Offset: 0x0073A1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			fixedStoreComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019415 RID: 103445 RVA: 0x0073C038 File Offset: 0x0073A238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			DSFixedStoreNtf ntf;
			LuaObject.checkType<DSFixedStoreNtf>(l, 2, out ntf);
			fixedStoreComponent.DeSerialize(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019416 RID: 103446 RVA: 0x0073C090 File Offset: 0x0073A290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitStores(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			List<ProFixedStore> pbStores;
			LuaObject.checkType<List<ProFixedStore>>(l, 2, out pbStores);
			fixedStoreComponent.InitStores(pbStores);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019417 RID: 103447 RVA: 0x0073C0E8 File Offset: 0x0073A2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsStoreInfoEmpty(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			bool b = fixedStoreComponent.IsStoreInfoEmpty();
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

	// Token: 0x06019418 RID: 103448 RVA: 0x0073C13C File Offset: 0x0073A33C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindStoreById(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			FixedStore o = fixedStoreComponent.FindStoreById(storeId);
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

	// Token: 0x06019419 RID: 103449 RVA: 0x0073C1A0 File Offset: 0x0073A3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitStoreInfo(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			ProFixedStore pbStore;
			LuaObject.checkType<ProFixedStore>(l, 2, out pbStore);
			fixedStoreComponent.InitStoreInfo(pbStore);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601941A RID: 103450 RVA: 0x0073C1F8 File Offset: 0x0073A3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanBuyGoods(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int i = fixedStoreComponent.CanBuyGoods(storeId, goodsId);
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

	// Token: 0x0601941B RID: 103451 RVA: 0x0073C268 File Offset: 0x0073A468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyStoreItem(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			long nextFlushTime;
			LuaObject.checkType(l, 4, out nextFlushTime);
			bool isReseted;
			LuaObject.checkType(l, 5, out isReseted);
			fixedStoreComponent.BuyStoreItem(storeId, goodsId, nextFlushTime, isReseted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601941C RID: 103452 RVA: 0x0073C2E8 File Offset: 0x0073A4E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			ushort dsversion = fixedStoreComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601941D RID: 103453 RVA: 0x0073C33C File Offset: 0x0073A53C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			string s = fixedStoreComponent.m_luaExportHelper.__callBase_GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601941E RID: 103454 RVA: 0x0073C398 File Offset: 0x0073A598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			fixedStoreComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601941F RID: 103455 RVA: 0x0073C3EC File Offset: 0x0073A5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			fixedStoreComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019420 RID: 103456 RVA: 0x0073C440 File Offset: 0x0073A640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			fixedStoreComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019421 RID: 103457 RVA: 0x0073C494 File Offset: 0x0073A694
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			fixedStoreComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019422 RID: 103458 RVA: 0x0073C4F0 File Offset: 0x0073A6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			fixedStoreComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019423 RID: 103459 RVA: 0x0073C544 File Offset: 0x0073A744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsSoldOut(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo itemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out itemConfig);
			FixedStoreItem item;
			LuaObject.checkType<FixedStoreItem>(l, 3, out item);
			bool b = fixedStoreComponent.m_luaExportHelper.__callBase_IsSoldOut(itemConfig, item);
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

	// Token: 0x06019424 RID: 103460 RVA: 0x0073C5B8 File Offset: 0x0073A7B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsInSaleTime(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo itemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out itemConfig);
			bool b = fixedStoreComponent.m_luaExportHelper.__callBase_IsInSaleTime(itemConfig);
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

	// Token: 0x06019425 RID: 103461 RVA: 0x0073C620 File Offset: 0x0073A820
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanBuyGoods(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int selectedIndex;
			LuaObject.checkType(l, 4, out selectedIndex);
			int i = fixedStoreComponent.m_luaExportHelper.__callBase_CanBuyGoods(storeId, goodsId, selectedIndex);
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

	// Token: 0x06019426 RID: 103462 RVA: 0x0073C6A4 File Offset: 0x0073A8A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanBuyFixedStoreItem(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo itemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out itemConfig);
			FixedStoreItem item;
			LuaObject.checkType<FixedStoreItem>(l, 3, out item);
			int i = fixedStoreComponent.m_luaExportHelper.__callBase_CanBuyFixedStoreItem(itemConfig, item);
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

	// Token: 0x06019427 RID: 103463 RVA: 0x0073C718 File Offset: 0x0073A918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CaculateCurrencyCount(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo storeItemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out storeItemConfig);
			bool isFirstBuy;
			LuaObject.checkType(l, 3, out isFirstBuy);
			int i = fixedStoreComponent.m_luaExportHelper.__callBase_CaculateCurrencyCount(storeItemConfig, isFirstBuy);
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

	// Token: 0x06019428 RID: 103464 RVA: 0x0073C78C File Offset: 0x0073A98C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsOnDiscountPeriod(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo storeItemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out storeItemConfig);
			bool b = fixedStoreComponent.m_luaExportHelper.__callBase_IsOnDiscountPeriod(storeItemConfig);
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

	// Token: 0x06019429 RID: 103465 RVA: 0x0073C7F4 File Offset: 0x0073A9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetStore(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			FixedStore o = fixedStoreComponent.m_luaExportHelper.__callBase_GetStore(storeId);
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

	// Token: 0x0601942A RID: 103466 RVA: 0x0073C85C File Offset: 0x0073AA5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BuyStoreItem(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreComponent fixedStoreComponent = (FixedStoreComponent)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			FixedStoreItem storeItem;
			LuaObject.checkType<FixedStoreItem>(l, 3, out storeItem);
			int count;
			LuaObject.checkType(l, 4, out count);
			fixedStoreComponent.m_luaExportHelper.__callBase_BuyStoreItem(storeId, storeItem, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601942B RID: 103467 RVA: 0x0073C8D4 File Offset: 0x0073AAD4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.FixedStoreComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.InitStores);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.IsStoreInfoEmpty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.FindStoreById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.InitStoreInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.CanBuyGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.BuyStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_IsSoldOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_IsInSaleTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_CanBuyGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_CanBuyFixedStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_CaculateCurrencyCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_IsOnDiscountPeriod);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_GetStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.__callBase_BuyStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.<>f__mg$cache19, typeof(FixedStoreComponent), typeof(FixedStoreComponentCommon));
	}

	// Token: 0x0400F871 RID: 63601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F872 RID: 63602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F873 RID: 63603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F874 RID: 63604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F875 RID: 63605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F876 RID: 63606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F877 RID: 63607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F878 RID: 63608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F879 RID: 63609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F87A RID: 63610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F87B RID: 63611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F87C RID: 63612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F87D RID: 63613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F87E RID: 63614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F87F RID: 63615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F880 RID: 63616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F881 RID: 63617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F882 RID: 63618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F883 RID: 63619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F884 RID: 63620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F885 RID: 63621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F886 RID: 63622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F887 RID: 63623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F888 RID: 63624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F889 RID: 63625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F88A RID: 63626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
