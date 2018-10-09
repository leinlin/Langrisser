using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200164B RID: 5707
[Preserve]
public class Lua_UnityEngine_Caching : LuaObject
{
	// Token: 0x06022CE7 RID: 142567 RVA: 0x00C05AA4 File Offset: 0x00C03CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Caching o = new Caching();
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

	// Token: 0x06022CE8 RID: 142568 RVA: 0x00C05AEC File Offset: 0x00C03CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearCache_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 0)
			{
				bool b = Caching.ClearCache();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 1)
			{
				int expiration;
				LuaObject.checkType(l, 1, out expiration);
				bool b2 = Caching.ClearCache(expiration);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ClearCache to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CE9 RID: 142569 RVA: 0x00C05B8C File Offset: 0x00C03D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearCachedVersion_s(IntPtr l)
	{
		int result;
		try
		{
			string assetBundleName;
			LuaObject.checkType(l, 1, out assetBundleName);
			Hash128 hash;
			LuaObject.checkValueType<Hash128>(l, 2, out hash);
			bool b = Caching.ClearCachedVersion(assetBundleName, hash);
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

	// Token: 0x06022CEA RID: 142570 RVA: 0x00C05BEC File Offset: 0x00C03DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearOtherCachedVersions_s(IntPtr l)
	{
		int result;
		try
		{
			string assetBundleName;
			LuaObject.checkType(l, 1, out assetBundleName);
			Hash128 hash;
			LuaObject.checkValueType<Hash128>(l, 2, out hash);
			bool b = Caching.ClearOtherCachedVersions(assetBundleName, hash);
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

	// Token: 0x06022CEB RID: 142571 RVA: 0x00C05C4C File Offset: 0x00C03E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllCachedVersions_s(IntPtr l)
	{
		int result;
		try
		{
			string assetBundleName;
			LuaObject.checkType(l, 1, out assetBundleName);
			bool b = Caching.ClearAllCachedVersions(assetBundleName);
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

	// Token: 0x06022CEC RID: 142572 RVA: 0x00C05CA0 File Offset: 0x00C03EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCachedVersions_s(IntPtr l)
	{
		int result;
		try
		{
			string assetBundleName;
			LuaObject.checkType(l, 1, out assetBundleName);
			List<Hash128> outCachedVersions;
			LuaObject.checkType<List<Hash128>>(l, 2, out outCachedVersions);
			Caching.GetCachedVersions(assetBundleName, outCachedVersions);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CED RID: 142573 RVA: 0x00C05CF8 File Offset: 0x00C03EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsVersionCached_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				CachedAssetBundle cachedBundle;
				LuaObject.checkValueType<CachedAssetBundle>(l, 1, out cachedBundle);
				bool b = Caching.IsVersionCached(cachedBundle);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 2)
			{
				string url;
				LuaObject.checkType(l, 1, out url);
				Hash128 hash;
				LuaObject.checkValueType<Hash128>(l, 2, out hash);
				bool b2 = Caching.IsVersionCached(url, hash);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsVersionCached to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CEE RID: 142574 RVA: 0x00C05DB0 File Offset: 0x00C03FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MarkAsUsed_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				CachedAssetBundle cachedBundle;
				LuaObject.checkValueType<CachedAssetBundle>(l, 1, out cachedBundle);
				bool b = Caching.MarkAsUsed(cachedBundle);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 2)
			{
				string url;
				LuaObject.checkType(l, 1, out url);
				Hash128 hash;
				LuaObject.checkValueType<Hash128>(l, 2, out hash);
				bool b2 = Caching.MarkAsUsed(url, hash);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function MarkAsUsed to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CEF RID: 142575 RVA: 0x00C05E68 File Offset: 0x00C04068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddCache_s(IntPtr l)
	{
		int result;
		try
		{
			string cachePath;
			LuaObject.checkType(l, 1, out cachePath);
			Cache cache = Caching.AddCache(cachePath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cache);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CF0 RID: 142576 RVA: 0x00C05EC0 File Offset: 0x00C040C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCacheAt_s(IntPtr l)
	{
		int result;
		try
		{
			int cacheIndex;
			LuaObject.checkType(l, 1, out cacheIndex);
			Cache cacheAt = Caching.GetCacheAt(cacheIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cacheAt);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CF1 RID: 142577 RVA: 0x00C05F18 File Offset: 0x00C04118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCacheByPath_s(IntPtr l)
	{
		int result;
		try
		{
			string cachePath;
			LuaObject.checkType(l, 1, out cachePath);
			Cache cacheByPath = Caching.GetCacheByPath(cachePath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cacheByPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CF2 RID: 142578 RVA: 0x00C05F70 File Offset: 0x00C04170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllCachePaths_s(IntPtr l)
	{
		int result;
		try
		{
			List<string> cachePaths;
			LuaObject.checkType<List<string>>(l, 1, out cachePaths);
			Caching.GetAllCachePaths(cachePaths);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CF3 RID: 142579 RVA: 0x00C05FBC File Offset: 0x00C041BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveCache_s(IntPtr l)
	{
		int result;
		try
		{
			Cache cache;
			LuaObject.checkValueType<Cache>(l, 1, out cache);
			bool b = Caching.RemoveCache(cache);
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

	// Token: 0x06022CF4 RID: 142580 RVA: 0x00C06010 File Offset: 0x00C04210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveCacheBefore_s(IntPtr l)
	{
		int result;
		try
		{
			Cache src;
			LuaObject.checkValueType<Cache>(l, 1, out src);
			Cache dst;
			LuaObject.checkValueType<Cache>(l, 2, out dst);
			Caching.MoveCacheBefore(src, dst);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CF5 RID: 142581 RVA: 0x00C06068 File Offset: 0x00C04268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveCacheAfter_s(IntPtr l)
	{
		int result;
		try
		{
			Cache src;
			LuaObject.checkValueType<Cache>(l, 1, out src);
			Cache dst;
			LuaObject.checkValueType<Cache>(l, 2, out dst);
			Caching.MoveCacheAfter(src, dst);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CF6 RID: 142582 RVA: 0x00C060C0 File Offset: 0x00C042C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_compressionEnabled(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Caching.compressionEnabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CF7 RID: 142583 RVA: 0x00C06108 File Offset: 0x00C04308
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_compressionEnabled(IntPtr l)
	{
		int result;
		try
		{
			bool compressionEnabled;
			LuaObject.checkType(l, 2, out compressionEnabled);
			Caching.compressionEnabled = compressionEnabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CF8 RID: 142584 RVA: 0x00C06154 File Offset: 0x00C04354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ready(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Caching.ready);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CF9 RID: 142585 RVA: 0x00C0619C File Offset: 0x00C0439C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cacheCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Caching.cacheCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CFA RID: 142586 RVA: 0x00C061E4 File Offset: 0x00C043E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_defaultCache(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Caching.defaultCache);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CFB RID: 142587 RVA: 0x00C06230 File Offset: 0x00C04430
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_currentCacheForWriting(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Caching.currentCacheForWriting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CFC RID: 142588 RVA: 0x00C0627C File Offset: 0x00C0447C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_currentCacheForWriting(IntPtr l)
	{
		int result;
		try
		{
			Cache currentCacheForWriting;
			LuaObject.checkValueType<Cache>(l, 2, out currentCacheForWriting);
			Caching.currentCacheForWriting = currentCacheForWriting;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CFD RID: 142589 RVA: 0x00C062C8 File Offset: 0x00C044C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Caching");
		if (Lua_UnityEngine_Caching.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Caching.ClearCache_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cache0);
		if (Lua_UnityEngine_Caching.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Caching.ClearCachedVersion_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cache1);
		if (Lua_UnityEngine_Caching.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Caching.ClearOtherCachedVersions_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cache2);
		if (Lua_UnityEngine_Caching.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Caching.ClearAllCachedVersions_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cache3);
		if (Lua_UnityEngine_Caching.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Caching.GetCachedVersions_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cache4);
		if (Lua_UnityEngine_Caching.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Caching.IsVersionCached_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cache5);
		if (Lua_UnityEngine_Caching.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Caching.MarkAsUsed_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cache6);
		if (Lua_UnityEngine_Caching.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Caching.AddCache_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cache7);
		if (Lua_UnityEngine_Caching.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Caching.GetCacheAt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cache8);
		if (Lua_UnityEngine_Caching.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Caching.GetCacheByPath_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cache9);
		if (Lua_UnityEngine_Caching.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Caching.GetAllCachePaths_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cacheA);
		if (Lua_UnityEngine_Caching.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Caching.RemoveCache_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cacheB);
		if (Lua_UnityEngine_Caching.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Caching.MoveCacheBefore_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cacheC);
		if (Lua_UnityEngine_Caching.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Caching.MoveCacheAfter_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Caching.<>f__mg$cacheD);
		string name = "compressionEnabled";
		if (Lua_UnityEngine_Caching.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Caching.get_compressionEnabled);
		}
		LuaCSFunction get = Lua_UnityEngine_Caching.<>f__mg$cacheE;
		if (Lua_UnityEngine_Caching.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Caching.set_compressionEnabled);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Caching.<>f__mg$cacheF, false);
		string name2 = "ready";
		if (Lua_UnityEngine_Caching.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Caching.get_ready);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Caching.<>f__mg$cache10, null, false);
		string name3 = "cacheCount";
		if (Lua_UnityEngine_Caching.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Caching.get_cacheCount);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Caching.<>f__mg$cache11, null, false);
		string name4 = "defaultCache";
		if (Lua_UnityEngine_Caching.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Caching.get_defaultCache);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Caching.<>f__mg$cache12, null, false);
		string name5 = "currentCacheForWriting";
		if (Lua_UnityEngine_Caching.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Caching.get_currentCacheForWriting);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Caching.<>f__mg$cache13;
		if (Lua_UnityEngine_Caching.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Caching.set_currentCacheForWriting);
		}
		LuaObject.addMember(l, name5, get2, Lua_UnityEngine_Caching.<>f__mg$cache14, false);
		if (Lua_UnityEngine_Caching.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Caching.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Caching.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Caching.<>f__mg$cache15, typeof(Caching));
	}

	// Token: 0x04018CAF RID: 101551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018CB0 RID: 101552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018CB1 RID: 101553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018CB2 RID: 101554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018CB3 RID: 101555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018CB4 RID: 101556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018CB5 RID: 101557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018CB6 RID: 101558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018CB7 RID: 101559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018CB8 RID: 101560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018CB9 RID: 101561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018CBA RID: 101562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018CBB RID: 101563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018CBC RID: 101564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018CBD RID: 101565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018CBE RID: 101566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018CBF RID: 101567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018CC0 RID: 101568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018CC1 RID: 101569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018CC2 RID: 101570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018CC3 RID: 101571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018CC4 RID: 101572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
