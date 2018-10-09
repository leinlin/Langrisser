using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001649 RID: 5705
[Preserve]
public class Lua_UnityEngine_Cache : LuaObject
{
	// Token: 0x06022CCF RID: 142543 RVA: 0x00C04FEC File Offset: 0x00C031EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Cache cache = default(Cache);
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

	// Token: 0x06022CD0 RID: 142544 RVA: 0x00C0503C File Offset: 0x00C0323C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearCache(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Cache cache;
				LuaObject.checkValueType<Cache>(l, 1, out cache);
				bool b = cache.ClearCache();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 2)
			{
				Cache cache2;
				LuaObject.checkValueType<Cache>(l, 1, out cache2);
				int expiration;
				LuaObject.checkType(l, 2, out expiration);
				bool b2 = cache2.ClearCache(expiration);
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

	// Token: 0x06022CD1 RID: 142545 RVA: 0x00C050F4 File Offset: 0x00C032F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Cache lhs;
			LuaObject.checkValueType<Cache>(l, 1, out lhs);
			Cache rhs;
			LuaObject.checkValueType<Cache>(l, 2, out rhs);
			bool b = lhs == rhs;
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

	// Token: 0x06022CD2 RID: 142546 RVA: 0x00C05154 File Offset: 0x00C03354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Cache lhs;
			LuaObject.checkValueType<Cache>(l, 1, out lhs);
			Cache rhs;
			LuaObject.checkValueType<Cache>(l, 2, out rhs);
			bool b = lhs != rhs;
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

	// Token: 0x06022CD3 RID: 142547 RVA: 0x00C051B4 File Offset: 0x00C033B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_valid(IntPtr l)
	{
		int result;
		try
		{
			Cache cache;
			LuaObject.checkValueType<Cache>(l, 1, out cache);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cache.valid);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CD4 RID: 142548 RVA: 0x00C05208 File Offset: 0x00C03408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ready(IntPtr l)
	{
		int result;
		try
		{
			Cache cache;
			LuaObject.checkValueType<Cache>(l, 1, out cache);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cache.ready);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CD5 RID: 142549 RVA: 0x00C0525C File Offset: 0x00C0345C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_readOnly(IntPtr l)
	{
		int result;
		try
		{
			Cache cache;
			LuaObject.checkValueType<Cache>(l, 1, out cache);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cache.readOnly);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CD6 RID: 142550 RVA: 0x00C052B0 File Offset: 0x00C034B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_path(IntPtr l)
	{
		int result;
		try
		{
			Cache cache;
			LuaObject.checkValueType<Cache>(l, 1, out cache);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cache.path);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CD7 RID: 142551 RVA: 0x00C05304 File Offset: 0x00C03504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_index(IntPtr l)
	{
		int result;
		try
		{
			Cache cache;
			LuaObject.checkValueType<Cache>(l, 1, out cache);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cache.index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CD8 RID: 142552 RVA: 0x00C05358 File Offset: 0x00C03558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_spaceFree(IntPtr l)
	{
		int result;
		try
		{
			Cache cache;
			LuaObject.checkValueType<Cache>(l, 1, out cache);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cache.spaceFree);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CD9 RID: 142553 RVA: 0x00C053AC File Offset: 0x00C035AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maximumAvailableStorageSpace(IntPtr l)
	{
		int result;
		try
		{
			Cache cache;
			LuaObject.checkValueType<Cache>(l, 1, out cache);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cache.maximumAvailableStorageSpace);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CDA RID: 142554 RVA: 0x00C05400 File Offset: 0x00C03600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maximumAvailableStorageSpace(IntPtr l)
	{
		int result;
		try
		{
			Cache cache;
			LuaObject.checkValueType<Cache>(l, 1, out cache);
			long maximumAvailableStorageSpace;
			LuaObject.checkType(l, 2, out maximumAvailableStorageSpace);
			cache.maximumAvailableStorageSpace = maximumAvailableStorageSpace;
			LuaObject.setBack(l, cache);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CDB RID: 142555 RVA: 0x00C05464 File Offset: 0x00C03664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_spaceOccupied(IntPtr l)
	{
		int result;
		try
		{
			Cache cache;
			LuaObject.checkValueType<Cache>(l, 1, out cache);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cache.spaceOccupied);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CDC RID: 142556 RVA: 0x00C054B8 File Offset: 0x00C036B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_expirationDelay(IntPtr l)
	{
		int result;
		try
		{
			Cache cache;
			LuaObject.checkValueType<Cache>(l, 1, out cache);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cache.expirationDelay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CDD RID: 142557 RVA: 0x00C0550C File Offset: 0x00C0370C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_expirationDelay(IntPtr l)
	{
		int result;
		try
		{
			Cache cache;
			LuaObject.checkValueType<Cache>(l, 1, out cache);
			int expirationDelay;
			LuaObject.checkType(l, 2, out expirationDelay);
			cache.expirationDelay = expirationDelay;
			LuaObject.setBack(l, cache);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CDE RID: 142558 RVA: 0x00C05570 File Offset: 0x00C03770
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Cache");
		if (Lua_UnityEngine_Cache.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Cache.ClearCache);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Cache.<>f__mg$cache0);
		if (Lua_UnityEngine_Cache.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Cache.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Cache.<>f__mg$cache1);
		if (Lua_UnityEngine_Cache.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Cache.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Cache.<>f__mg$cache2);
		string name = "valid";
		if (Lua_UnityEngine_Cache.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Cache.get_valid);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Cache.<>f__mg$cache3, null, true);
		string name2 = "ready";
		if (Lua_UnityEngine_Cache.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Cache.get_ready);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Cache.<>f__mg$cache4, null, true);
		string name3 = "readOnly";
		if (Lua_UnityEngine_Cache.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Cache.get_readOnly);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Cache.<>f__mg$cache5, null, true);
		string name4 = "path";
		if (Lua_UnityEngine_Cache.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Cache.get_path);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Cache.<>f__mg$cache6, null, true);
		string name5 = "index";
		if (Lua_UnityEngine_Cache.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Cache.get_index);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Cache.<>f__mg$cache7, null, true);
		string name6 = "spaceFree";
		if (Lua_UnityEngine_Cache.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Cache.get_spaceFree);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Cache.<>f__mg$cache8, null, true);
		string name7 = "maximumAvailableStorageSpace";
		if (Lua_UnityEngine_Cache.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Cache.get_maximumAvailableStorageSpace);
		}
		LuaCSFunction get = Lua_UnityEngine_Cache.<>f__mg$cache9;
		if (Lua_UnityEngine_Cache.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Cache.set_maximumAvailableStorageSpace);
		}
		LuaObject.addMember(l, name7, get, Lua_UnityEngine_Cache.<>f__mg$cacheA, true);
		string name8 = "spaceOccupied";
		if (Lua_UnityEngine_Cache.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Cache.get_spaceOccupied);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Cache.<>f__mg$cacheB, null, true);
		string name9 = "expirationDelay";
		if (Lua_UnityEngine_Cache.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Cache.get_expirationDelay);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Cache.<>f__mg$cacheC;
		if (Lua_UnityEngine_Cache.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Cache.set_expirationDelay);
		}
		LuaObject.addMember(l, name9, get2, Lua_UnityEngine_Cache.<>f__mg$cacheD, true);
		if (Lua_UnityEngine_Cache.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Cache.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Cache.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Cache.<>f__mg$cacheE, typeof(Cache), typeof(ValueType));
	}

	// Token: 0x04018C9B RID: 101531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C9C RID: 101532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C9D RID: 101533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018C9E RID: 101534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018C9F RID: 101535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018CA0 RID: 101536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018CA1 RID: 101537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018CA2 RID: 101538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018CA3 RID: 101539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018CA4 RID: 101540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018CA5 RID: 101541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018CA6 RID: 101542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018CA7 RID: 101543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018CA8 RID: 101544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018CA9 RID: 101545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
