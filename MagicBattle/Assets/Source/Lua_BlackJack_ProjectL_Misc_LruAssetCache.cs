using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020012AD RID: 4781
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_LruAssetCache : LuaObject
{
	// Token: 0x06019135 RID: 102709 RVA: 0x00725E4C File Offset: 0x0072404C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int cacheType;
			LuaObject.checkType(l, 2, out cacheType);
			int maxCount;
			LuaObject.checkType(l, 3, out maxCount);
			LruAssetCache o = new LruAssetCache(cacheType, maxCount);
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

	// Token: 0x06019136 RID: 102710 RVA: 0x00725EAC File Offset: 0x007240AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCacheType(IntPtr l)
	{
		int result;
		try
		{
			LruAssetCache lruAssetCache = (LruAssetCache)LuaObject.checkSelf(l);
			int cacheType = lruAssetCache.GetCacheType();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cacheType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019137 RID: 102711 RVA: 0x00725F00 File Offset: 0x00724100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMaxCount(IntPtr l)
	{
		int result;
		try
		{
			LruAssetCache lruAssetCache = (LruAssetCache)LuaObject.checkSelf(l);
			int maxCount = lruAssetCache.GetMaxCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, maxCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019138 RID: 102712 RVA: 0x00725F54 File Offset: 0x00724154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Add(IntPtr l)
	{
		int result;
		try
		{
			LruAssetCache lruAssetCache = (LruAssetCache)LuaObject.checkSelf(l);
			UnityEngine.Object a;
			LuaObject.checkType<UnityEngine.Object>(l, 2, out a);
			lruAssetCache.Add(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019139 RID: 102713 RVA: 0x00725FAC File Offset: 0x007241AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			LruAssetCache lruAssetCache = (LruAssetCache)LuaObject.checkSelf(l);
			lruAssetCache.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601913A RID: 102714 RVA: 0x00725FF8 File Offset: 0x007241F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.LruAssetCache");
		if (Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LruAssetCache.GetCacheType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LruAssetCache.GetMaxCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LruAssetCache.Add);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LruAssetCache.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LruAssetCache.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_LruAssetCache.<>f__mg$cache4, typeof(LruAssetCache));
	}

	// Token: 0x0400F5BD RID: 62909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F5BE RID: 62910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F5BF RID: 62911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F5C0 RID: 62912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F5C1 RID: 62913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
