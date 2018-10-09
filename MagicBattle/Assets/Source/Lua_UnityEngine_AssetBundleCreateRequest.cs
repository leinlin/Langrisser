using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001631 RID: 5681
[Preserve]
public class Lua_UnityEngine_AssetBundleCreateRequest : LuaObject
{
	// Token: 0x06022BFF RID: 142335 RVA: 0x00BFF41C File Offset: 0x00BFD61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AssetBundleCreateRequest o = new AssetBundleCreateRequest();
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

	// Token: 0x06022C00 RID: 142336 RVA: 0x00BFF464 File Offset: 0x00BFD664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_assetBundle(IntPtr l)
	{
		int result;
		try
		{
			AssetBundleCreateRequest assetBundleCreateRequest = (AssetBundleCreateRequest)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assetBundleCreateRequest.assetBundle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C01 RID: 142337 RVA: 0x00BFF4B8 File Offset: 0x00BFD6B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AssetBundleCreateRequest");
		string name = "assetBundle";
		if (Lua_UnityEngine_AssetBundleCreateRequest.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AssetBundleCreateRequest.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AssetBundleCreateRequest.get_assetBundle);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_AssetBundleCreateRequest.<>f__mg$cache0, null, true);
		if (Lua_UnityEngine_AssetBundleCreateRequest.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AssetBundleCreateRequest.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AssetBundleCreateRequest.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AssetBundleCreateRequest.<>f__mg$cache1, typeof(AssetBundleCreateRequest), typeof(AsyncOperation));
	}

	// Token: 0x04018BFB RID: 101371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018BFC RID: 101372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
