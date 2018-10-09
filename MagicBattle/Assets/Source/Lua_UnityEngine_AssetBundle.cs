using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001630 RID: 5680
[Preserve]
public class Lua_UnityEngine_AssetBundle : LuaObject
{
	// Token: 0x06022BE8 RID: 142312 RVA: 0x00BFE29C File Offset: 0x00BFC49C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AssetBundle o = new AssetBundle();
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

	// Token: 0x06022BE9 RID: 142313 RVA: 0x00BFE2E4 File Offset: 0x00BFC4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Contains(IntPtr l)
	{
		int result;
		try
		{
			AssetBundle assetBundle = (AssetBundle)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool b = assetBundle.Contains(name);
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

	// Token: 0x06022BEA RID: 142314 RVA: 0x00BFE348 File Offset: 0x00BFC548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadAsset(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(string)))
			{
				AssetBundle assetBundle = (AssetBundle)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				UnityEngine.Object o = assetBundle.LoadAsset(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string)))
			{
				AssetBundle assetBundle2 = (AssetBundle)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				UnityEngine.Object o2 = assetBundle2.LoadAsset<UnityEngine.Object>(name2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 3)
			{
				AssetBundle assetBundle3 = (AssetBundle)LuaObject.checkSelf(l);
				string name3;
				LuaObject.checkType(l, 2, out name3);
				Type type;
				LuaObject.checkType(l, 3, out type);
				UnityEngine.Object o3 = assetBundle3.LoadAsset(name3, type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadAsset to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BEB RID: 142315 RVA: 0x00BFE48C File Offset: 0x00BFC68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadAssetAsync(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				AssetBundle assetBundle = (AssetBundle)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				AssetBundleRequest o = assetBundle.LoadAssetAsync(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				AssetBundle assetBundle2 = (AssetBundle)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				Type type;
				LuaObject.checkType(l, 3, out type);
				AssetBundleRequest o2 = assetBundle2.LoadAssetAsync(name2, type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadAssetAsync to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BEC RID: 142316 RVA: 0x00BFE564 File Offset: 0x00BFC764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadAssetWithSubAssets(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(string)))
			{
				AssetBundle assetBundle = (AssetBundle)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				UnityEngine.Object[] a = assetBundle.LoadAssetWithSubAssets(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string)))
			{
				AssetBundle assetBundle2 = (AssetBundle)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				UnityEngine.Object[] a2 = assetBundle2.LoadAssetWithSubAssets<UnityEngine.Object>(name2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 3)
			{
				AssetBundle assetBundle3 = (AssetBundle)LuaObject.checkSelf(l);
				string name3;
				LuaObject.checkType(l, 2, out name3);
				Type type;
				LuaObject.checkType(l, 3, out type);
				UnityEngine.Object[] a3 = assetBundle3.LoadAssetWithSubAssets(name3, type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadAssetWithSubAssets to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BED RID: 142317 RVA: 0x00BFE6A8 File Offset: 0x00BFC8A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LoadAssetWithSubAssetsAsync(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				AssetBundle assetBundle = (AssetBundle)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				AssetBundleRequest o = assetBundle.LoadAssetWithSubAssetsAsync(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				AssetBundle assetBundle2 = (AssetBundle)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				Type type;
				LuaObject.checkType(l, 3, out type);
				AssetBundleRequest o2 = assetBundle2.LoadAssetWithSubAssetsAsync(name2, type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadAssetWithSubAssetsAsync to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BEE RID: 142318 RVA: 0x00BFE780 File Offset: 0x00BFC980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadAllAssets(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, new Type[0]))
			{
				AssetBundle assetBundle = (AssetBundle)LuaObject.checkSelf(l);
				UnityEngine.Object[] a = assetBundle.LoadAllAssets<UnityEngine.Object>();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, new Type[0]))
			{
				AssetBundle assetBundle2 = (AssetBundle)LuaObject.checkSelf(l);
				UnityEngine.Object[] a2 = assetBundle2.LoadAllAssets();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 2)
			{
				AssetBundle assetBundle3 = (AssetBundle)LuaObject.checkSelf(l);
				Type type;
				LuaObject.checkType(l, 2, out type);
				UnityEngine.Object[] a3 = assetBundle3.LoadAllAssets(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadAllAssets to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BEF RID: 142319 RVA: 0x00BFE888 File Offset: 0x00BFCA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadAllAssetsAsync(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				AssetBundle assetBundle = (AssetBundle)LuaObject.checkSelf(l);
				AssetBundleRequest o = assetBundle.LoadAllAssetsAsync();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				AssetBundle assetBundle2 = (AssetBundle)LuaObject.checkSelf(l);
				Type type;
				LuaObject.checkType(l, 2, out type);
				AssetBundleRequest o2 = assetBundle2.LoadAllAssetsAsync(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadAllAssetsAsync to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BF0 RID: 142320 RVA: 0x00BFE944 File Offset: 0x00BFCB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Unload(IntPtr l)
	{
		int result;
		try
		{
			AssetBundle assetBundle = (AssetBundle)LuaObject.checkSelf(l);
			bool unloadAllLoadedObjects;
			LuaObject.checkType(l, 2, out unloadAllLoadedObjects);
			assetBundle.Unload(unloadAllLoadedObjects);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BF1 RID: 142321 RVA: 0x00BFE99C File Offset: 0x00BFCB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllAssetNames(IntPtr l)
	{
		int result;
		try
		{
			AssetBundle assetBundle = (AssetBundle)LuaObject.checkSelf(l);
			string[] allAssetNames = assetBundle.GetAllAssetNames();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allAssetNames);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BF2 RID: 142322 RVA: 0x00BFE9F0 File Offset: 0x00BFCBF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllScenePaths(IntPtr l)
	{
		int result;
		try
		{
			AssetBundle assetBundle = (AssetBundle)LuaObject.checkSelf(l);
			string[] allScenePaths = assetBundle.GetAllScenePaths();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allScenePaths);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BF3 RID: 142323 RVA: 0x00BFEA44 File Offset: 0x00BFCC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnloadAllAssetBundles_s(IntPtr l)
	{
		int result;
		try
		{
			bool unloadAllObjects;
			LuaObject.checkType(l, 1, out unloadAllObjects);
			AssetBundle.UnloadAllAssetBundles(unloadAllObjects);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BF4 RID: 142324 RVA: 0x00BFEA90 File Offset: 0x00BFCC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllLoadedAssetBundles_s(IntPtr l)
	{
		int result;
		try
		{
			IEnumerable<AssetBundle> allLoadedAssetBundles = AssetBundle.GetAllLoadedAssetBundles();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allLoadedAssetBundles);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BF5 RID: 142325 RVA: 0x00BFEAD8 File Offset: 0x00BFCCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadFromFileAsync_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string path;
				LuaObject.checkType(l, 1, out path);
				AssetBundleCreateRequest o = AssetBundle.LoadFromFileAsync(path);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				string path2;
				LuaObject.checkType(l, 1, out path2);
				uint crc;
				LuaObject.checkType(l, 2, out crc);
				AssetBundleCreateRequest o2 = AssetBundle.LoadFromFileAsync(path2, crc);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 3)
			{
				string path3;
				LuaObject.checkType(l, 1, out path3);
				uint crc2;
				LuaObject.checkType(l, 2, out crc2);
				ulong offset;
				LuaObject.checkType(l, 3, out offset);
				AssetBundleCreateRequest o3 = AssetBundle.LoadFromFileAsync(path3, crc2, offset);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadFromFileAsync to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BF6 RID: 142326 RVA: 0x00BFEBD8 File Offset: 0x00BFCDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadFromFile_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string path;
				LuaObject.checkType(l, 1, out path);
				AssetBundle o = AssetBundle.LoadFromFile(path);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				string path2;
				LuaObject.checkType(l, 1, out path2);
				uint crc;
				LuaObject.checkType(l, 2, out crc);
				AssetBundle o2 = AssetBundle.LoadFromFile(path2, crc);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 3)
			{
				string path3;
				LuaObject.checkType(l, 1, out path3);
				uint crc2;
				LuaObject.checkType(l, 2, out crc2);
				ulong offset;
				LuaObject.checkType(l, 3, out offset);
				AssetBundle o3 = AssetBundle.LoadFromFile(path3, crc2, offset);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadFromFile to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BF7 RID: 142327 RVA: 0x00BFECD8 File Offset: 0x00BFCED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadFromMemoryAsync_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				byte[] binary;
				LuaObject.checkArray<byte>(l, 1, out binary);
				AssetBundleCreateRequest o = AssetBundle.LoadFromMemoryAsync(binary);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				byte[] binary2;
				LuaObject.checkArray<byte>(l, 1, out binary2);
				uint crc;
				LuaObject.checkType(l, 2, out crc);
				AssetBundleCreateRequest o2 = AssetBundle.LoadFromMemoryAsync(binary2, crc);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadFromMemoryAsync to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BF8 RID: 142328 RVA: 0x00BFED90 File Offset: 0x00BFCF90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LoadFromMemory_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				byte[] binary;
				LuaObject.checkArray<byte>(l, 1, out binary);
				AssetBundle o = AssetBundle.LoadFromMemory(binary);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				byte[] binary2;
				LuaObject.checkArray<byte>(l, 1, out binary2);
				uint crc;
				LuaObject.checkType(l, 2, out crc);
				AssetBundle o2 = AssetBundle.LoadFromMemory(binary2, crc);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadFromMemory to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BF9 RID: 142329 RVA: 0x00BFEE48 File Offset: 0x00BFD048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadFromStreamAsync_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Stream stream;
				LuaObject.checkType<Stream>(l, 1, out stream);
				uint crc;
				LuaObject.checkType(l, 2, out crc);
				AssetBundleCreateRequest o = AssetBundle.LoadFromStreamAsync(stream, crc);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 1)
			{
				Stream stream2;
				LuaObject.checkType<Stream>(l, 1, out stream2);
				AssetBundleCreateRequest o2 = AssetBundle.LoadFromStreamAsync(stream2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 3)
			{
				Stream stream3;
				LuaObject.checkType<Stream>(l, 1, out stream3);
				uint crc2;
				LuaObject.checkType(l, 2, out crc2);
				uint managedReadBufferSize;
				LuaObject.checkType(l, 3, out managedReadBufferSize);
				AssetBundleCreateRequest o3 = AssetBundle.LoadFromStreamAsync(stream3, crc2, managedReadBufferSize);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadFromStreamAsync to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BFA RID: 142330 RVA: 0x00BFEF4C File Offset: 0x00BFD14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LoadFromStream_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Stream stream;
				LuaObject.checkType<Stream>(l, 1, out stream);
				uint crc;
				LuaObject.checkType(l, 2, out crc);
				AssetBundle o = AssetBundle.LoadFromStream(stream, crc);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 1)
			{
				Stream stream2;
				LuaObject.checkType<Stream>(l, 1, out stream2);
				AssetBundle o2 = AssetBundle.LoadFromStream(stream2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 3)
			{
				Stream stream3;
				LuaObject.checkType<Stream>(l, 1, out stream3);
				uint crc2;
				LuaObject.checkType(l, 2, out crc2);
				uint managedReadBufferSize;
				LuaObject.checkType(l, 3, out managedReadBufferSize);
				AssetBundle o3 = AssetBundle.LoadFromStream(stream3, crc2, managedReadBufferSize);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadFromStream to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BFB RID: 142331 RVA: 0x00BFF050 File Offset: 0x00BFD250
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_mainAsset(IntPtr l)
	{
		int result;
		try
		{
			AssetBundle assetBundle = (AssetBundle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assetBundle.mainAsset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BFC RID: 142332 RVA: 0x00BFF0A4 File Offset: 0x00BFD2A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isStreamedSceneAssetBundle(IntPtr l)
	{
		int result;
		try
		{
			AssetBundle assetBundle = (AssetBundle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assetBundle.isStreamedSceneAssetBundle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BFD RID: 142333 RVA: 0x00BFF0F8 File Offset: 0x00BFD2F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AssetBundle");
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.Contains);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache0);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.LoadAsset);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache1);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.LoadAssetAsync);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache2);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.LoadAssetWithSubAssets);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache3);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.LoadAssetWithSubAssetsAsync);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache4);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.LoadAllAssets);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache5);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.LoadAllAssetsAsync);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache6);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.Unload);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache7);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.GetAllAssetNames);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache8);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.GetAllScenePaths);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache9);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_AssetBundle.UnloadAllAssetBundles_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cacheA);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_AssetBundle.GetAllLoadedAssetBundles_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cacheB);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_AssetBundle.LoadFromFileAsync_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cacheC);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_AssetBundle.LoadFromFile_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cacheD);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_AssetBundle.LoadFromMemoryAsync_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cacheE);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_AssetBundle.LoadFromMemory_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cacheF);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.LoadFromStreamAsync_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache10);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.LoadFromStream_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache11);
		string name = "mainAsset";
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.get_mainAsset);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_AssetBundle.<>f__mg$cache12, null, true);
		string name2 = "isStreamedSceneAssetBundle";
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.get_isStreamedSceneAssetBundle);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_AssetBundle.<>f__mg$cache13, null, true);
		if (Lua_UnityEngine_AssetBundle.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_AssetBundle.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_AssetBundle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AssetBundle.<>f__mg$cache14, typeof(AssetBundle), typeof(UnityEngine.Object));
	}

	// Token: 0x04018BE6 RID: 101350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018BE7 RID: 101351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018BE8 RID: 101352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018BE9 RID: 101353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018BEA RID: 101354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018BEB RID: 101355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018BEC RID: 101356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018BED RID: 101357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018BEE RID: 101358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018BEF RID: 101359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018BF0 RID: 101360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018BF1 RID: 101361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018BF2 RID: 101362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018BF3 RID: 101363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018BF4 RID: 101364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018BF5 RID: 101365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018BF6 RID: 101366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018BF7 RID: 101367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018BF8 RID: 101368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018BF9 RID: 101369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018BFA RID: 101370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
