using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200164A RID: 5706
[Preserve]
public class Lua_UnityEngine_CachedAssetBundle : LuaObject
{
	// Token: 0x06022CE0 RID: 142560 RVA: 0x00C057E4 File Offset: 0x00C039E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			Hash128 hash;
			LuaObject.checkValueType<Hash128>(l, 3, out hash);
			CachedAssetBundle cachedAssetBundle = new CachedAssetBundle(name, hash);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cachedAssetBundle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CE1 RID: 142561 RVA: 0x00C0584C File Offset: 0x00C03A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_name(IntPtr l)
	{
		int result;
		try
		{
			CachedAssetBundle cachedAssetBundle;
			LuaObject.checkValueType<CachedAssetBundle>(l, 1, out cachedAssetBundle);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cachedAssetBundle.name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CE2 RID: 142562 RVA: 0x00C058A0 File Offset: 0x00C03AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_name(IntPtr l)
	{
		int result;
		try
		{
			CachedAssetBundle cachedAssetBundle;
			LuaObject.checkValueType<CachedAssetBundle>(l, 1, out cachedAssetBundle);
			string name;
			LuaObject.checkType(l, 2, out name);
			cachedAssetBundle.name = name;
			LuaObject.setBack(l, cachedAssetBundle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CE3 RID: 142563 RVA: 0x00C05904 File Offset: 0x00C03B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hash(IntPtr l)
	{
		int result;
		try
		{
			CachedAssetBundle cachedAssetBundle;
			LuaObject.checkValueType<CachedAssetBundle>(l, 1, out cachedAssetBundle);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cachedAssetBundle.hash);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CE4 RID: 142564 RVA: 0x00C0595C File Offset: 0x00C03B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_hash(IntPtr l)
	{
		int result;
		try
		{
			CachedAssetBundle cachedAssetBundle;
			LuaObject.checkValueType<CachedAssetBundle>(l, 1, out cachedAssetBundle);
			Hash128 hash;
			LuaObject.checkValueType<Hash128>(l, 2, out hash);
			cachedAssetBundle.hash = hash;
			LuaObject.setBack(l, cachedAssetBundle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CE5 RID: 142565 RVA: 0x00C059C0 File Offset: 0x00C03BC0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CachedAssetBundle");
		string name = "name";
		if (Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CachedAssetBundle.get_name);
		}
		LuaCSFunction get = Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache0;
		if (Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CachedAssetBundle.set_name);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache1, true);
		string name2 = "hash";
		if (Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CachedAssetBundle.get_hash);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache2;
		if (Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CachedAssetBundle.set_hash);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache3, true);
		if (Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CachedAssetBundle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_CachedAssetBundle.<>f__mg$cache4, typeof(CachedAssetBundle), typeof(ValueType));
	}

	// Token: 0x04018CAA RID: 101546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018CAB RID: 101547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018CAC RID: 101548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018CAD RID: 101549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018CAE RID: 101550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
