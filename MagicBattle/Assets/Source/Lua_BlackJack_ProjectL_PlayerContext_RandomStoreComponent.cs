using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012DB RID: 4827
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent : LuaObject
{
	// Token: 0x06019F6B RID: 106347 RVA: 0x0079B350 File Offset: 0x00799550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent o = new RandomStoreComponent();
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

	// Token: 0x06019F6C RID: 106348 RVA: 0x0079B398 File Offset: 0x00799598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			randomStoreComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F6D RID: 106349 RVA: 0x0079B3E4 File Offset: 0x007995E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			randomStoreComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F6E RID: 106350 RVA: 0x0079B430 File Offset: 0x00799630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			randomStoreComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F6F RID: 106351 RVA: 0x0079B47C File Offset: 0x0079967C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			DSRandomStoreNtf ntf;
			LuaObject.checkType<DSRandomStoreNtf>(l, 2, out ntf);
			randomStoreComponent.DeSerialize(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F70 RID: 106352 RVA: 0x0079B4D4 File Offset: 0x007996D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitStores(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			List<ProRandomStore> pbStores;
			LuaObject.checkType<List<ProRandomStore>>(l, 2, out pbStores);
			randomStoreComponent.InitStores(pbStores);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F71 RID: 106353 RVA: 0x0079B52C File Offset: 0x0079972C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			ushort dsversion = randomStoreComponent.GetDSVersion();
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

	// Token: 0x06019F72 RID: 106354 RVA: 0x0079B580 File Offset: 0x00799780
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsStoreInfoEmpty(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			bool b = randomStoreComponent.IsStoreInfoEmpty();
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

	// Token: 0x06019F73 RID: 106355 RVA: 0x0079B5D4 File Offset: 0x007997D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStore(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			randomStoreComponent.SetStore(store);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F74 RID: 106356 RVA: 0x0079B62C File Offset: 0x0079982C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetManualFlushNums(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int manualFlushNums = randomStoreComponent.GetManualFlushNums(storeId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, manualFlushNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F75 RID: 106357 RVA: 0x0079B690 File Offset: 0x00799890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanManualFlushRandomStore(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			int i = randomStoreComponent.CanManualFlushRandomStore(store);
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

	// Token: 0x06019F76 RID: 106358 RVA: 0x0079B6F4 File Offset: 0x007998F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ManualFlushRandomStore(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			int i = randomStoreComponent.ManualFlushRandomStore(store);
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

	// Token: 0x06019F77 RID: 106359 RVA: 0x0079B758 File Offset: 0x00799958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStore(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			RandomStore store = randomStoreComponent.GetStore(storeId);
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

	// Token: 0x06019F78 RID: 106360 RVA: 0x0079B7BC File Offset: 0x007999BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStoreNextFlushTime(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			DateTime storeNextFlushTime = randomStoreComponent.GetStoreNextFlushTime(storeId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeNextFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F79 RID: 106361 RVA: 0x0079B824 File Offset: 0x00799A24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BuyStoreItem(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int index;
			LuaObject.checkType(l, 3, out index);
			int i = randomStoreComponent.BuyStoreItem(storeId, index);
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

	// Token: 0x06019F7A RID: 106362 RVA: 0x0079B894 File Offset: 0x00799A94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			string s = randomStoreComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x06019F7B RID: 106363 RVA: 0x0079B8F0 File Offset: 0x00799AF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			randomStoreComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F7C RID: 106364 RVA: 0x0079B944 File Offset: 0x00799B44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			randomStoreComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F7D RID: 106365 RVA: 0x0079B998 File Offset: 0x00799B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			randomStoreComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F7E RID: 106366 RVA: 0x0079B9EC File Offset: 0x00799BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			randomStoreComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F7F RID: 106367 RVA: 0x0079BA48 File Offset: 0x00799C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			randomStoreComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F80 RID: 106368 RVA: 0x0079BA9C File Offset: 0x00799C9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnFlushManualFlushNums(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			randomStoreComponent.m_luaExportHelper.__callBase_OnFlushManualFlushNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F81 RID: 106369 RVA: 0x0079BAF0 File Offset: 0x00799CF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanAutoFlushStore(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			bool b = randomStoreComponent.m_luaExportHelper.__callBase_CanAutoFlushStore(store);
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

	// Token: 0x06019F82 RID: 106370 RVA: 0x0079BB58 File Offset: 0x00799D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsBoughtStoreItem(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			RandomStoreItem storeItem;
			LuaObject.checkType<RandomStoreItem>(l, 2, out storeItem);
			bool b = randomStoreComponent.m_luaExportHelper.__callBase_IsBoughtStoreItem(storeItem);
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

	// Token: 0x06019F83 RID: 106371 RVA: 0x0079BBC0 File Offset: 0x00799DC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanManualFlushStore(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			RandomStore store;
			LuaObject.checkType<RandomStore>(l, 2, out store);
			ConfigDataRandomStoreInfo storeInfo;
			LuaObject.checkType<ConfigDataRandomStoreInfo>(l, 3, out storeInfo);
			int i = randomStoreComponent.m_luaExportHelper.__callBase_CanManualFlushStore(store, storeInfo);
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

	// Token: 0x06019F84 RID: 106372 RVA: 0x0079BC34 File Offset: 0x00799E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanBuyRandomStoreItem(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int index;
			LuaObject.checkType(l, 3, out index);
			int selectedIndex;
			LuaObject.checkType(l, 4, out selectedIndex);
			int i = randomStoreComponent.m_luaExportHelper.__callBase_CanBuyRandomStoreItem(storeId, index, selectedIndex);
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

	// Token: 0x06019F85 RID: 106373 RVA: 0x0079BCB8 File Offset: 0x00799EB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBuyStoreItem(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreComponent randomStoreComponent = (RandomStoreComponent)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			randomStoreComponent.m_luaExportHelper.__callBase_OnBuyStoreItem(storeId, goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F86 RID: 106374 RVA: 0x0079BD24 File Offset: 0x00799F24
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.RandomStoreComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.InitStores);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.IsStoreInfoEmpty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.SetStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.GetManualFlushNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.CanManualFlushRandomStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.ManualFlushRandomStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.GetStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.GetStoreNextFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.BuyStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.__callBase_OnFlushManualFlushNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.__callBase_CanAutoFlushStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.__callBase_IsBoughtStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.__callBase_CanManualFlushStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.__callBase_CanBuyRandomStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.__callBase_OnBuyStoreItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.<>f__mg$cache1A, typeof(RandomStoreComponent), typeof(RandomStoreComponentCommon));
	}

	// Token: 0x04010397 RID: 66455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010398 RID: 66456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010399 RID: 66457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401039A RID: 66458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401039B RID: 66459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401039C RID: 66460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401039D RID: 66461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401039E RID: 66462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401039F RID: 66463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040103A0 RID: 66464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040103A1 RID: 66465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040103A2 RID: 66466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040103A3 RID: 66467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040103A4 RID: 66468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040103A5 RID: 66469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040103A6 RID: 66470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040103A7 RID: 66471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040103A8 RID: 66472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040103A9 RID: 66473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040103AA RID: 66474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040103AB RID: 66475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040103AC RID: 66476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040103AD RID: 66477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040103AE RID: 66478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040103AF RID: 66479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040103B0 RID: 66480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040103B1 RID: 66481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
