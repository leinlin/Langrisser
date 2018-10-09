using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001117 RID: 4375
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase : LuaObject
{
	// Token: 0x06015BF9 RID: 89081 RVA: 0x0059A18C File Offset: 0x0059838C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryGetAsset(IntPtr l)
	{
		int result;
		try
		{
			PrefabResourceContainerBase prefabResourceContainerBase = (PrefabResourceContainerBase)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			UnityEngine.Object o;
			bool b = prefabResourceContainerBase.TryGetAsset(assetName, out o);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, o);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BFA RID: 89082 RVA: 0x0059A1FC File Offset: 0x005983FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAsset(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				PrefabResourceContainerBase prefabResourceContainerBase = (PrefabResourceContainerBase)LuaObject.checkSelf(l);
				string assetName;
				LuaObject.checkType(l, 2, out assetName);
				UnityEngine.Object asset = prefabResourceContainerBase.GetAsset(assetName);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, asset);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				PrefabResourceContainerBase prefabResourceContainerBase2 = (PrefabResourceContainerBase)LuaObject.checkSelf(l);
				string assetName2;
				LuaObject.checkType(l, 2, out assetName2);
				UnityEngine.Object asset2 = prefabResourceContainerBase2.GetAsset<UnityEngine.Object>(assetName2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, asset2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetAsset to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BFB RID: 89083 RVA: 0x0059A2E8 File Offset: 0x005984E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAssetAsync(IntPtr l)
	{
		int result;
		try
		{
			PrefabResourceContainerBase prefabResourceContainerBase = (PrefabResourceContainerBase)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			Action<UnityEngine.Object> onEnd;
			LuaObject.checkDelegate<Action<UnityEngine.Object>>(l, 3, out onEnd);
			bool isLoadAssetAsync;
			LuaObject.checkType(l, 4, out isLoadAssetAsync);
			IEnumerable assetAsync = prefabResourceContainerBase.GetAssetAsync(assetName, onEnd, isLoadAssetAsync);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assetAsync);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BFC RID: 89084 RVA: 0x0059A364 File Offset: 0x00598564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLazyLoadBackground(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				PrefabResourceContainerBase prefabResourceContainerBase = (PrefabResourceContainerBase)LuaObject.checkSelf(l);
				bool isLoadAssetAsync;
				LuaObject.checkType(l, 2, out isLoadAssetAsync);
				IEnumerable o = prefabResourceContainerBase.StartLazyLoadBackground(isLoadAssetAsync);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				PrefabResourceContainerBase prefabResourceContainerBase2 = (PrefabResourceContainerBase)LuaObject.checkSelf(l);
				List<string> assetNames;
				LuaObject.checkType<List<string>>(l, 2, out assetNames);
				bool isLoadAssetAsync2;
				LuaObject.checkType(l, 3, out isLoadAssetAsync2);
				IEnumerable o2 = prefabResourceContainerBase2.StartLazyLoadBackground(assetNames, isLoadAssetAsync2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function StartLazyLoadBackground to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BFD RID: 89085 RVA: 0x0059A43C File Offset: 0x0059863C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RecacheAllAssetsFromResourceManager(IntPtr l)
	{
		int result;
		try
		{
			PrefabResourceContainerBase prefabResourceContainerBase = (PrefabResourceContainerBase)LuaObject.checkSelf(l);
			IEnumerator o = prefabResourceContainerBase.RecacheAllAssetsFromResourceManager();
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

	// Token: 0x06015BFE RID: 89086 RVA: 0x0059A490 File Offset: 0x00598690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AssetList(IntPtr l)
	{
		int result;
		try
		{
			PrefabResourceContainerBase prefabResourceContainerBase = (PrefabResourceContainerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, prefabResourceContainerBase.AssetList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BFF RID: 89087 RVA: 0x0059A4E4 File Offset: 0x005986E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AssetList(IntPtr l)
	{
		int result;
		try
		{
			PrefabResourceContainerBase prefabResourceContainerBase = (PrefabResourceContainerBase)LuaObject.checkSelf(l);
			List<PrefabResourceContainerBase.AssetCacheItem> assetList;
			LuaObject.checkType<List<PrefabResourceContainerBase.AssetCacheItem>>(l, 2, out assetList);
			prefabResourceContainerBase.AssetList = assetList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C00 RID: 89088 RVA: 0x0059A53C File Offset: 0x0059873C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_assetCacheList(IntPtr l)
	{
		int result;
		try
		{
			PrefabResourceContainerBase prefabResourceContainerBase = (PrefabResourceContainerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, prefabResourceContainerBase.m_assetCacheList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C01 RID: 89089 RVA: 0x0059A590 File Offset: 0x00598790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_assetCacheList(IntPtr l)
	{
		int result;
		try
		{
			PrefabResourceContainerBase prefabResourceContainerBase = (PrefabResourceContainerBase)LuaObject.checkSelf(l);
			List<PrefabResourceContainerBase.AssetCacheItem> assetCacheList;
			LuaObject.checkType<List<PrefabResourceContainerBase.AssetCacheItem>>(l, 2, out assetCacheList);
			prefabResourceContainerBase.m_assetCacheList = assetCacheList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C02 RID: 89090 RVA: 0x0059A5E8 File Offset: 0x005987E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Prefab.PrefabResourceContainerBase");
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.TryGetAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.GetAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.GetAssetAsync);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.StartLazyLoadBackground);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.RecacheAllAssetsFromResourceManager);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache4);
		string name = "AssetList";
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.get_AssetList);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache5;
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.set_AssetList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache6, true);
		string name2 = "m_assetCacheList";
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.get_m_assetCacheList);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache7;
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.set_m_assetCacheList);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.<>f__mg$cache8, true);
		LuaObject.createTypeMetatable(l, null, typeof(PrefabResourceContainerBase), typeof(MonoBehaviour));
	}

	// Token: 0x0400C3AD RID: 50093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C3AE RID: 50094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C3AF RID: 50095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C3B0 RID: 50096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C3B1 RID: 50097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C3B2 RID: 50098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C3B3 RID: 50099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C3B4 RID: 50100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C3B5 RID: 50101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
