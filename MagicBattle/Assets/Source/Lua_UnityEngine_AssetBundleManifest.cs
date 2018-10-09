using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001632 RID: 5682
[Preserve]
public class Lua_UnityEngine_AssetBundleManifest : LuaObject
{
	// Token: 0x06022C03 RID: 142339 RVA: 0x00BFF53C File Offset: 0x00BFD73C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AssetBundleManifest o = new AssetBundleManifest();
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

	// Token: 0x06022C04 RID: 142340 RVA: 0x00BFF584 File Offset: 0x00BFD784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllAssetBundles(IntPtr l)
	{
		int result;
		try
		{
			AssetBundleManifest assetBundleManifest = (AssetBundleManifest)LuaObject.checkSelf(l);
			string[] allAssetBundles = assetBundleManifest.GetAllAssetBundles();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allAssetBundles);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C05 RID: 142341 RVA: 0x00BFF5D8 File Offset: 0x00BFD7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllAssetBundlesWithVariant(IntPtr l)
	{
		int result;
		try
		{
			AssetBundleManifest assetBundleManifest = (AssetBundleManifest)LuaObject.checkSelf(l);
			string[] allAssetBundlesWithVariant = assetBundleManifest.GetAllAssetBundlesWithVariant();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allAssetBundlesWithVariant);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C06 RID: 142342 RVA: 0x00BFF62C File Offset: 0x00BFD82C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAssetBundleHash(IntPtr l)
	{
		int result;
		try
		{
			AssetBundleManifest assetBundleManifest = (AssetBundleManifest)LuaObject.checkSelf(l);
			string assetBundleName;
			LuaObject.checkType(l, 2, out assetBundleName);
			Hash128 assetBundleHash = assetBundleManifest.GetAssetBundleHash(assetBundleName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assetBundleHash);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C07 RID: 142343 RVA: 0x00BFF694 File Offset: 0x00BFD894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDirectDependencies(IntPtr l)
	{
		int result;
		try
		{
			AssetBundleManifest assetBundleManifest = (AssetBundleManifest)LuaObject.checkSelf(l);
			string assetBundleName;
			LuaObject.checkType(l, 2, out assetBundleName);
			string[] directDependencies = assetBundleManifest.GetDirectDependencies(assetBundleName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, directDependencies);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C08 RID: 142344 RVA: 0x00BFF6F8 File Offset: 0x00BFD8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllDependencies(IntPtr l)
	{
		int result;
		try
		{
			AssetBundleManifest assetBundleManifest = (AssetBundleManifest)LuaObject.checkSelf(l);
			string assetBundleName;
			LuaObject.checkType(l, 2, out assetBundleName);
			string[] allDependencies = assetBundleManifest.GetAllDependencies(assetBundleName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allDependencies);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C09 RID: 142345 RVA: 0x00BFF75C File Offset: 0x00BFD95C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AssetBundleManifest");
		if (Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AssetBundleManifest.GetAllAssetBundles);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache0);
		if (Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AssetBundleManifest.GetAllAssetBundlesWithVariant);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache1);
		if (Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AssetBundleManifest.GetAssetBundleHash);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache2);
		if (Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AssetBundleManifest.GetDirectDependencies);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache3);
		if (Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AssetBundleManifest.GetAllDependencies);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache4);
		if (Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AssetBundleManifest.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AssetBundleManifest.<>f__mg$cache5, typeof(AssetBundleManifest), typeof(UnityEngine.Object));
	}

	// Token: 0x04018BFD RID: 101373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018BFE RID: 101374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018BFF RID: 101375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018C00 RID: 101376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018C01 RID: 101377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018C02 RID: 101378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
