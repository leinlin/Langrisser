using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001633 RID: 5683
[Preserve]
public class Lua_UnityEngine_AssetBundleRequest : LuaObject
{
	// Token: 0x06022C0B RID: 142347 RVA: 0x00BFF864 File Offset: 0x00BFDA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AssetBundleRequest o = new AssetBundleRequest();
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

	// Token: 0x06022C0C RID: 142348 RVA: 0x00BFF8AC File Offset: 0x00BFDAAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_asset(IntPtr l)
	{
		int result;
		try
		{
			AssetBundleRequest assetBundleRequest = (AssetBundleRequest)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assetBundleRequest.asset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C0D RID: 142349 RVA: 0x00BFF900 File Offset: 0x00BFDB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_allAssets(IntPtr l)
	{
		int result;
		try
		{
			AssetBundleRequest assetBundleRequest = (AssetBundleRequest)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assetBundleRequest.allAssets);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C0E RID: 142350 RVA: 0x00BFF954 File Offset: 0x00BFDB54
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AssetBundleRequest");
		string name = "asset";
		if (Lua_UnityEngine_AssetBundleRequest.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AssetBundleRequest.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AssetBundleRequest.get_asset);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_AssetBundleRequest.<>f__mg$cache0, null, true);
		string name2 = "allAssets";
		if (Lua_UnityEngine_AssetBundleRequest.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AssetBundleRequest.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AssetBundleRequest.get_allAssets);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_AssetBundleRequest.<>f__mg$cache1, null, true);
		if (Lua_UnityEngine_AssetBundleRequest.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AssetBundleRequest.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AssetBundleRequest.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AssetBundleRequest.<>f__mg$cache2, typeof(AssetBundleRequest), typeof(AsyncOperation));
	}

	// Token: 0x04018C03 RID: 101379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C04 RID: 101380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C05 RID: 101381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
