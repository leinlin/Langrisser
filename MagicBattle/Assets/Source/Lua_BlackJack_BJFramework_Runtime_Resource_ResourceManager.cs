using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Resource;
using SLua;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

// Token: 0x02001118 RID: 4376
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager : LuaObject
{
	// Token: 0x06015C04 RID: 89092 RVA: 0x0059A760 File Offset: 0x00598960
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LoadAsset(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string path;
			LuaObject.checkType(l, 2, out path);
			Action<string, UnityEngine.Object> onCompleted;
			LuaObject.checkDelegate<Action<string, UnityEngine.Object>>(l, 3, out onCompleted);
			bool noErrlog;
			LuaObject.checkType(l, 4, out noErrlog);
			bool loadAync;
			LuaObject.checkType(l, 5, out loadAync);
			IEnumerator o = resourceManager.LoadAsset<UnityEngine.Object>(path, onCompleted, noErrlog, loadAync);
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

	// Token: 0x06015C05 RID: 89093 RVA: 0x0059A7E8 File Offset: 0x005989E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLoadAssetsCorutine(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			HashSet<string> pathList;
			LuaObject.checkType<HashSet<string>>(l, 2, out pathList);
			IDictionary<string, UnityEngine.Object> assetDict;
			LuaObject.checkType<IDictionary<string, UnityEngine.Object>>(l, 3, out assetDict);
			Action onComplete;
			LuaObject.checkDelegate<Action>(l, 4, out onComplete);
			bool loadAsync;
			LuaObject.checkType(l, 5, out loadAsync);
			resourceManager.StartLoadAssetsCorutine(pathList, assetDict, onComplete, loadAsync);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C06 RID: 89094 RVA: 0x0059A868 File Offset: 0x00598A68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartLoadAssetCorutine(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string path;
			LuaObject.checkType(l, 2, out path);
			Action<string, UnityEngine.Object> onComplete;
			LuaObject.checkDelegate<Action<string, UnityEngine.Object>>(l, 3, out onComplete);
			resourceManager.StartLoadAssetCorutine(path, onComplete);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C07 RID: 89095 RVA: 0x0059A8CC File Offset: 0x00598ACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetDownloadUrlRoot(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string downloadUrlRoot;
			LuaObject.checkType(l, 2, out downloadUrlRoot);
			resourceManager.SetDownloadUrlRoot(downloadUrlRoot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C08 RID: 89096 RVA: 0x0059A924 File Offset: 0x00598B24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OutputMemUseage(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			resourceManager.OutputMemUseage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C09 RID: 89097 RVA: 0x0059A970 File Offset: 0x00598B70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UnloadUnusedAssets(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			bool b = resourceManager.UnloadUnusedAssets();
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

	// Token: 0x06015C0A RID: 89098 RVA: 0x0059A9C4 File Offset: 0x00598BC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UnloadUnusedResourceAll(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			Action onComplete;
			LuaObject.checkDelegate<Action>(l, 2, out onComplete);
			HashSet<string> keepReserve;
			LuaObject.checkType<HashSet<string>>(l, 3, out keepReserve);
			bool b = resourceManager.UnloadUnusedResourceAll(onComplete, keepReserve);
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

	// Token: 0x06015C0B RID: 89099 RVA: 0x0059AA34 File Offset: 0x00598C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLoadedAssetPathSet(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			HashSet<string> loadedAssetPathSet = resourceManager.GetLoadedAssetPathSet();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loadedAssetPathSet);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C0C RID: 89100 RVA: 0x0059AA88 File Offset: 0x00598C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDownloadBundleUrlPrefix(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string downloadBundleUrlPrefix;
			LuaObject.checkType(l, 2, out downloadBundleUrlPrefix);
			resourceManager.SetDownloadBundleUrlPrefix(downloadBundleUrlPrefix);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C0D RID: 89101 RVA: 0x0059AAE0 File Offset: 0x00598CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MakeAssetBundleDontUnload(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string assetPath;
			LuaObject.checkType(l, 2, out assetPath);
			bool b = resourceManager.MakeAssetBundleDontUnload(assetPath);
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

	// Token: 0x06015C0E RID: 89102 RVA: 0x0059AB44 File Offset: 0x00598D44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetResaveRuntimePath(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string srcDir;
			LuaObject.checkType(l, 2, out srcDir);
			string relativePath;
			LuaObject.checkType(l, 3, out relativePath);
			string resaveRuntimePath = resourceManager.GetResaveRuntimePath(srcDir, relativePath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resaveRuntimePath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C0F RID: 89103 RVA: 0x0059ABB4 File Offset: 0x00598DB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TryGetResaveFile(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string srcDir;
			LuaObject.checkType(l, 2, out srcDir);
			string relativePath;
			LuaObject.checkType(l, 3, out relativePath);
			string s = resourceManager.TryGetResaveFile(srcDir, relativePath);
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

	// Token: 0x06015C10 RID: 89104 RVA: 0x0059AC24 File Offset: 0x00598E24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DownloadResaveFile(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string srcDir;
			LuaObject.checkType(l, 2, out srcDir);
			HashSet<string> relativePaths;
			LuaObject.checkType<HashSet<string>>(l, 3, out relativePaths);
			Action<string, bool> onComplete;
			LuaObject.checkDelegate<Action<string, bool>>(l, 4, out onComplete);
			IEnumerator o = resourceManager.DownloadResaveFile(srcDir, relativePaths, onComplete);
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

	// Token: 0x06015C11 RID: 89105 RVA: 0x0059ACA0 File Offset: 0x00598EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartDownloadResaveFile(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string srcDir;
			LuaObject.checkType(l, 2, out srcDir);
			HashSet<string> relativePaths;
			LuaObject.checkType<HashSet<string>>(l, 3, out relativePaths);
			Action<string, bool> onComplete;
			LuaObject.checkDelegate<Action<string, bool>>(l, 4, out onComplete);
			resourceManager.StartDownloadResaveFile(srcDir, relativePaths, onComplete);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C12 RID: 89106 RVA: 0x0059AD14 File Offset: 0x00598F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveTouchedBundleSet(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			bool force;
			LuaObject.checkType(l, 2, out force);
			resourceManager.SaveTouchedBundleSet(force);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C13 RID: 89107 RVA: 0x0059AD6C File Offset: 0x00598F6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddBundle2TouchedBundleSet(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string bundleName;
			LuaObject.checkType(l, 2, out bundleName);
			bool checkBundleData;
			LuaObject.checkType(l, 3, out checkBundleData);
			bool b = resourceManager.AddBundle2TouchedBundleSet(bundleName, checkBundleData);
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

	// Token: 0x06015C14 RID: 89108 RVA: 0x0059ADDC File Offset: 0x00598FDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsAssetInTouchedBundleSet(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string assetPath;
			LuaObject.checkType(l, 2, out assetPath);
			bool b = resourceManager.IsAssetInTouchedBundleSet(assetPath);
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

	// Token: 0x06015C15 RID: 89109 RVA: 0x0059AE40 File Offset: 0x00599040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartAssetBundleManifestLoading(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 2, out onEnd);
			resourceManager.StartAssetBundleManifestLoading(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C16 RID: 89110 RVA: 0x0059AE98 File Offset: 0x00599098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartAssetBundlePreUpdateing(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 2, out onEnd);
			resourceManager.StartAssetBundlePreUpdateing(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C17 RID: 89111 RVA: 0x0059AEF0 File Offset: 0x005990F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAssetBundleUpdateingPercent(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			float assetBundleUpdateingPercent = resourceManager.GetAssetBundleUpdateingPercent();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assetBundleUpdateingPercent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C18 RID: 89112 RVA: 0x0059AF44 File Offset: 0x00599144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPreUpdateingDownloadedBytes(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			long preUpdateingDownloadedBytes = resourceManager.GetPreUpdateingDownloadedBytes();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preUpdateingDownloadedBytes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C19 RID: 89113 RVA: 0x0059AF98 File Offset: 0x00599198
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTotalPreUpdateingDownloadBytes(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			long totalPreUpdateingDownloadBytes = resourceManager.GetTotalPreUpdateingDownloadBytes();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, totalPreUpdateingDownloadBytes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C1A RID: 89114 RVA: 0x0059AFEC File Offset: 0x005991EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartDownloadUntouchedAssets(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			HashSet<string> assets;
			LuaObject.checkType<HashSet<string>>(l, 2, out assets);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 3, out onEnd);
			resourceManager.StartDownloadUntouchedAssets(assets, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C1B RID: 89115 RVA: 0x0059B050 File Offset: 0x00599250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTotalUntouchedAssetBundleDownloadBytes(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			long totalUntouchedAssetBundleDownloadBytes = resourceManager.GetTotalUntouchedAssetBundleDownloadBytes();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, totalUntouchedAssetBundleDownloadBytes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C1C RID: 89116 RVA: 0x0059B0A4 File Offset: 0x005992A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBundleDataLoading(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 2, out onEnd);
			resourceManager.StartBundleDataLoading(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C1D RID: 89117 RVA: 0x0059B0FC File Offset: 0x005992FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckBundleDataVersionFromUrl(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			Action<bool, int, uint, bool> onEnd;
			LuaObject.checkDelegate<Action<bool, int, uint, bool>>(l, 2, out onEnd);
			IEnumerator o = resourceManager.CheckBundleDataVersionFromUrl(onEnd);
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

	// Token: 0x06015C1E RID: 89118 RVA: 0x0059B160 File Offset: 0x00599360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBundleDataBasicVersion(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			int bundleDataBasicVersion = resourceManager.GetBundleDataBasicVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bundleDataBasicVersion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C1F RID: 89119 RVA: 0x0059B1B4 File Offset: 0x005993B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckBundleCache(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			resourceManager.CheckBundleCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C20 RID: 89120 RVA: 0x0059B200 File Offset: 0x00599400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReserveAsset(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string path;
			LuaObject.checkType(l, 2, out path);
			Action<string, UnityEngine.Object> onCompleted;
			LuaObject.checkDelegate<Action<string, UnityEngine.Object>>(l, 3, out onCompleted);
			bool noErrlog;
			LuaObject.checkType(l, 4, out noErrlog);
			int reserveTime;
			LuaObject.checkType(l, 5, out reserveTime);
			IEnumerator o = resourceManager.ReserveAsset(path, onCompleted, noErrlog, reserveTime);
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

	// Token: 0x06015C21 RID: 89121 RVA: 0x0059B288 File Offset: 0x00599488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartReserveAssetsCorutine(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			HashSet<string> pathList;
			LuaObject.checkType<HashSet<string>>(l, 2, out pathList);
			IDictionary<string, UnityEngine.Object> assetDict;
			LuaObject.checkType<IDictionary<string, UnityEngine.Object>>(l, 3, out assetDict);
			Action onComplete;
			LuaObject.checkDelegate<Action>(l, 4, out onComplete);
			bool loadAsync;
			LuaObject.checkType(l, 5, out loadAsync);
			int reserveTime;
			LuaObject.checkType(l, 6, out reserveTime);
			resourceManager.StartReserveAssetsCorutine(pathList, assetDict, onComplete, loadAsync, reserveTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C22 RID: 89122 RVA: 0x0059B314 File Offset: 0x00599514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartStreamingAssetsFilesProcessing(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			Action<bool> onEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 2, out onEnd);
			resourceManager.StartStreamingAssetsFilesProcessing(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C23 RID: 89123 RVA: 0x0059B36C File Offset: 0x0059956C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadUnityScene(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			string path;
			LuaObject.checkType(l, 2, out path);
			Action<string, Scene?> onCompleted;
			LuaObject.checkDelegate<Action<string, Scene?>>(l, 3, out onCompleted);
			bool noErrlog;
			LuaObject.checkType(l, 4, out noErrlog);
			bool loadAync;
			LuaObject.checkType(l, 5, out loadAync);
			IEnumerator o = resourceManager.LoadUnityScene(path, onCompleted, noErrlog, loadAync);
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

	// Token: 0x06015C24 RID: 89124 RVA: 0x0059B3F4 File Offset: 0x005995F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_loadFilePaths(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resourceManager.m_loadFilePaths);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C25 RID: 89125 RVA: 0x0059B448 File Offset: 0x00599648
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_loadFilePaths(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			HashSet<string> loadFilePaths;
			LuaObject.checkType<HashSet<string>>(l, 2, out loadFilePaths);
			resourceManager.m_loadFilePaths = loadFilePaths;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C26 RID: 89126 RVA: 0x0059B4A0 File Offset: 0x005996A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_loadingProgress(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resourceManager.m_loadingProgress);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C27 RID: 89127 RVA: 0x0059B4F4 File Offset: 0x005996F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_loadingProgress(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			float loadingProgress;
			LuaObject.checkType(l, 2, out loadingProgress);
			resourceManager.m_loadingProgress = loadingProgress;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C28 RID: 89128 RVA: 0x0059B54C File Offset: 0x0059974C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ResourceManager.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C29 RID: 89129 RVA: 0x0059B594 File Offset: 0x00599794
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_State(IntPtr l)
	{
		int result;
		try
		{
			ResourceManager resourceManager = (ResourceManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)resourceManager.State);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C2A RID: 89130 RVA: 0x0059B5E8 File Offset: 0x005997E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Resource.ResourceManager");
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.LoadAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.StartLoadAssetsCorutine);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.StartLoadAssetCorutine);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.SetDownloadUrlRoot);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.OutputMemUseage);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.UnloadUnusedAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.UnloadUnusedResourceAll);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.GetLoadedAssetPathSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.SetDownloadBundleUrlPrefix);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.MakeAssetBundleDontUnload);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.GetResaveRuntimePath);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.TryGetResaveFile);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.DownloadResaveFile);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.StartDownloadResaveFile);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.SaveTouchedBundleSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.AddBundle2TouchedBundleSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.IsAssetInTouchedBundleSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.StartAssetBundleManifestLoading);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache11);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.StartAssetBundlePreUpdateing);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache12);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.GetAssetBundleUpdateingPercent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache13);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.GetPreUpdateingDownloadedBytes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache14);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.GetTotalPreUpdateingDownloadBytes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache15);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.StartDownloadUntouchedAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache16);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.GetTotalUntouchedAssetBundleDownloadBytes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache17);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.StartBundleDataLoading);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache18);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.CheckBundleDataVersionFromUrl);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache19);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.GetBundleDataBasicVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1A);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.CheckBundleCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1B);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.ReserveAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1C);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.StartReserveAssetsCorutine);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1D);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.StartStreamingAssetsFilesProcessing);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1E);
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.LoadUnityScene);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache1F);
		string name = "m_loadFilePaths";
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.get_m_loadFilePaths);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache20;
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.set_m_loadFilePaths);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache21, true);
		string name2 = "m_loadingProgress";
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.get_m_loadingProgress);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache22;
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.set_m_loadingProgress);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache23, true);
		string name3 = "Instance";
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.get_Instance);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache24, null, false);
		string name4 = "State";
		if (Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.get_State);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.<>f__mg$cache25, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(ResourceManager));
	}

	// Token: 0x0400C3B6 RID: 50102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C3B7 RID: 50103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C3B8 RID: 50104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C3B9 RID: 50105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C3BA RID: 50106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C3BB RID: 50107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C3BC RID: 50108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C3BD RID: 50109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C3BE RID: 50110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C3BF RID: 50111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C3C0 RID: 50112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C3C1 RID: 50113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C3C2 RID: 50114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C3C3 RID: 50115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C3C4 RID: 50116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C3C5 RID: 50117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C3C6 RID: 50118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C3C7 RID: 50119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C3C8 RID: 50120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C3C9 RID: 50121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C3CA RID: 50122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C3CB RID: 50123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400C3CC RID: 50124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400C3CD RID: 50125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400C3CE RID: 50126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400C3CF RID: 50127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400C3D0 RID: 50128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400C3D1 RID: 50129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400C3D2 RID: 50130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400C3D3 RID: 50131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400C3D4 RID: 50132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400C3D5 RID: 50133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400C3D6 RID: 50134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400C3D7 RID: 50135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400C3D8 RID: 50136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400C3D9 RID: 50137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400C3DA RID: 50138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400C3DB RID: 50139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
