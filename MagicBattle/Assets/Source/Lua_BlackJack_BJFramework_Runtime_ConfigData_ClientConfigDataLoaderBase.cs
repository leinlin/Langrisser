using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.ConfigData;
using BlackJack.BJFramework.Runtime.Resource;
using ProtoBuf;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001108 RID: 4360
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase : LuaObject
{
	// Token: 0x06015B01 RID: 88833 RVA: 0x00592D64 File Offset: 0x00590F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadLazyLoadConfigDataAsset(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			string configDataName;
			LuaObject.checkType(l, 2, out configDataName);
			string configAssetName;
			LuaObject.checkType(l, 3, out configAssetName);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 4, out onEnd);
			clientConfigDataLoaderBase.LoadLazyLoadConfigDataAsset(configDataName, configAssetName, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B02 RID: 88834 RVA: 0x00592DD8 File Offset: 0x00590FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLazyLoadConfigAssetNameByKey(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			string configDataName;
			LuaObject.checkType(l, 2, out configDataName);
			int key;
			LuaObject.checkType(l, 3, out key);
			string lazyLoadConfigAssetNameByKey = clientConfigDataLoaderBase.GetLazyLoadConfigAssetNameByKey(configDataName, key);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lazyLoadConfigAssetNameByKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B03 RID: 88835 RVA: 0x00592E48 File Offset: 0x00591048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetConfigDataPath(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			string configDataPath = clientConfigDataLoaderBase.GetConfigDataPath();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B04 RID: 88836 RVA: 0x00592E9C File Offset: 0x0059109C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLazyLoadConfigAssetInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			string configDataName;
			LuaObject.checkType(l, 2, out configDataName);
			string configAssetName;
			LuaObject.checkType(l, 3, out configAssetName);
			ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo lazyLoadConfigAssetInfo = clientConfigDataLoaderBase.GetLazyLoadConfigAssetInfo(configDataName, configAssetName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lazyLoadConfigAssetInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B05 RID: 88837 RVA: 0x00592F0C File Offset: 0x0059110C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeserializeExtensionTableOnLoadFromAssetEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			BytesScriptableObjectMD5 dataObj;
			LuaObject.checkType<BytesScriptableObjectMD5>(l, 2, out dataObj);
			string assetPath;
			LuaObject.checkType(l, 3, out assetPath);
			string typeName;
			LuaObject.checkType(l, 4, out typeName);
			List<DummyType> o = clientConfigDataLoaderBase.DeserializeExtensionTableOnLoadFromAssetEnd(dataObj, assetPath, typeName);
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

	// Token: 0x06015B06 RID: 88838 RVA: 0x00592F88 File Offset: 0x00591188
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnInitLoadFromAssetEndWorker(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			int totalWorkerCount;
			LuaObject.checkType(l, 2, out totalWorkerCount);
			int workerId;
			LuaObject.checkType(l, 3, out workerId);
			int loadCountForSingleYield;
			LuaObject.checkType(l, 4, out loadCountForSingleYield);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 5, out onEnd);
			List<string> skipTypeList;
			LuaObject.checkType<List<string>>(l, 6, out skipTypeList);
			List<string> filterTypeList;
			LuaObject.checkType<List<string>>(l, 7, out filterTypeList);
			IEnumerator o = clientConfigDataLoaderBase.m_luaExportHelper.OnInitLoadFromAssetEndWorker(totalWorkerCount, workerId, loadCountForSingleYield, onEnd, skipTypeList, filterTypeList);
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

	// Token: 0x06015B07 RID: 88839 RVA: 0x00593030 File Offset: 0x00591230
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnInitLoadFromAssetEndWorkerForLuaDummyType(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			bool b = clientConfigDataLoaderBase.m_luaExportHelper.OnInitLoadFromAssetEndWorkerForLuaDummyType();
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

	// Token: 0x06015B08 RID: 88840 RVA: 0x0059308C File Offset: 0x0059128C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddConfigDataItemForLuaDummyType(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			string typeName;
			LuaObject.checkType(l, 2, out typeName);
			DummyType dataItem;
			LuaObject.checkType<DummyType>(l, 3, out dataItem);
			clientConfigDataLoaderBase.m_luaExportHelper.AddConfigDataItemForLuaDummyType(typeName, dataItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B09 RID: 88841 RVA: 0x005930F8 File Offset: 0x005912F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllInitLoadConfigDataTypeNameForLuaDummy(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			List<string> allInitLoadConfigDataTypeNameForLuaDummy = clientConfigDataLoaderBase.m_luaExportHelper.GetAllInitLoadConfigDataTypeNameForLuaDummy();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allInitLoadConfigDataTypeNameForLuaDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B0A RID: 88842 RVA: 0x00593154 File Offset: 0x00591354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllInitLoadConfigDataAssetPath(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			HashSet<string> allInitLoadConfigDataAssetPath = clientConfigDataLoaderBase.m_luaExportHelper.GetAllInitLoadConfigDataAssetPath();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allInitLoadConfigDataAssetPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B0B RID: 88843 RVA: 0x005931B0 File Offset: 0x005913B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLazyLoadFromAssetEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			string configDataName;
			LuaObject.checkType(l, 2, out configDataName);
			string configAssetName;
			LuaObject.checkType(l, 3, out configAssetName);
			UnityEngine.Object lasset;
			LuaObject.checkType<UnityEngine.Object>(l, 4, out lasset);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 5, out onEnd);
			clientConfigDataLoaderBase.m_luaExportHelper.OnLazyLoadFromAssetEnd(configDataName, configAssetName, lasset, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B0C RID: 88844 RVA: 0x00593234 File Offset: 0x00591434
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllLazyLoadConfigDataAssetPath(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			Dictionary<string, List<ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo>> allLazyLoadConfigDataAssetPath = clientConfigDataLoaderBase.m_luaExportHelper.GetAllLazyLoadConfigDataAssetPath();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allLazyLoadConfigDataAssetPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B0D RID: 88845 RVA: 0x00593290 File Offset: 0x00591490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReportNullAssetInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			clientConfigDataLoaderBase.m_luaExportHelper.ReportNullAssetInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B0E RID: 88846 RVA: 0x005932E4 File Offset: 0x005914E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FireEventOnConfigDataTableLoadEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			clientConfigDataLoaderBase.m_luaExportHelper.FireEventOnConfigDataTableLoadEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B0F RID: 88847 RVA: 0x00593338 File Offset: 0x00591538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnConfigDataTableLoadEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			clientConfigDataLoaderBase.m_luaExportHelper.__callDele_EventOnConfigDataTableLoadEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B10 RID: 88848 RVA: 0x0059338C File Offset: 0x0059158C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnConfigDataTableLoadEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			clientConfigDataLoaderBase.m_luaExportHelper.__clearDele_EventOnConfigDataTableLoadEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B11 RID: 88849 RVA: 0x005933E0 File Offset: 0x005915E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnConfigDataTableLoadEnd(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					clientConfigDataLoaderBase.EventOnConfigDataTableLoadEnd += value;
				}
				else if (num == 2)
				{
					clientConfigDataLoaderBase.EventOnConfigDataTableLoadEnd -= value;
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

	// Token: 0x06015B12 RID: 88850 RVA: 0x00593460 File Offset: 0x00591660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameClientSetting(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientConfigDataLoaderBase.m_luaExportHelper.m_gameClientSetting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B13 RID: 88851 RVA: 0x005934B8 File Offset: 0x005916B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_gameClientSetting(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			GameClientSetting gameClientSetting;
			LuaObject.checkType<GameClientSetting>(l, 2, out gameClientSetting);
			clientConfigDataLoaderBase.m_luaExportHelper.m_gameClientSetting = gameClientSetting;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B14 RID: 88852 RVA: 0x00593514 File Offset: 0x00591714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lazyLoadConfigDataAssetPathDict(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientConfigDataLoaderBase.m_luaExportHelper.m_lazyLoadConfigDataAssetPathDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B15 RID: 88853 RVA: 0x0059356C File Offset: 0x0059176C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lazyLoadConfigDataAssetPathDict(IntPtr l)
	{
		int result;
		try
		{
			ClientConfigDataLoaderBase clientConfigDataLoaderBase = (ClientConfigDataLoaderBase)LuaObject.checkSelf(l);
			Dictionary<string, List<ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo>> lazyLoadConfigDataAssetPathDict;
			LuaObject.checkType<Dictionary<string, List<ClientConfigDataLoaderBase.LazyLoadConfigAssetInfo>>>(l, 2, out lazyLoadConfigDataAssetPathDict);
			clientConfigDataLoaderBase.m_luaExportHelper.m_lazyLoadConfigDataAssetPathDict = lazyLoadConfigDataAssetPathDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B16 RID: 88854 RVA: 0x005935C8 File Offset: 0x005917C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.ConfigData.ClientConfigDataLoaderBase");
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.LoadLazyLoadConfigDataAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.GetLazyLoadConfigAssetNameByKey);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.GetConfigDataPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.GetLazyLoadConfigAssetInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.DeserializeExtensionTableOnLoadFromAssetEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.OnInitLoadFromAssetEndWorker);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.OnInitLoadFromAssetEndWorkerForLuaDummyType);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.AddConfigDataItemForLuaDummyType);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.GetAllInitLoadConfigDataTypeNameForLuaDummy);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.GetAllInitLoadConfigDataAssetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.OnLazyLoadFromAssetEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.GetAllLazyLoadConfigDataAssetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.ReportNullAssetInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.FireEventOnConfigDataTableLoadEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.__callDele_EventOnConfigDataTableLoadEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.__clearDele_EventOnConfigDataTableLoadEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cacheF);
		string name = "EventOnConfigDataTableLoadEnd";
		LuaCSFunction get = null;
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.set_EventOnConfigDataTableLoadEnd);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache10, true);
		string name2 = "m_gameClientSetting";
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.get_m_gameClientSetting);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache11;
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.set_m_gameClientSetting);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache12, true);
		string name3 = "m_lazyLoadConfigDataAssetPathDict";
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.get_m_lazyLoadConfigDataAssetPathDict);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache13;
		if (Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.set_m_lazyLoadConfigDataAssetPathDict);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.<>f__mg$cache14, true);
		LuaObject.createTypeMetatable(l, null, typeof(ClientConfigDataLoaderBase));
	}

	// Token: 0x0400C2D3 RID: 49875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C2D4 RID: 49876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C2D5 RID: 49877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C2D6 RID: 49878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C2D7 RID: 49879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C2D8 RID: 49880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C2D9 RID: 49881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C2DA RID: 49882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C2DB RID: 49883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C2DC RID: 49884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C2DD RID: 49885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C2DE RID: 49886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C2DF RID: 49887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C2E0 RID: 49888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C2E1 RID: 49889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C2E2 RID: 49890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C2E3 RID: 49891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C2E4 RID: 49892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C2E5 RID: 49893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C2E6 RID: 49894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C2E7 RID: 49895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
