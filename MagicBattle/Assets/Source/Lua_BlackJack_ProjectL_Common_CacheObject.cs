using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011D9 RID: 4569
[Preserve]
public class Lua_BlackJack_ProjectL_Common_CacheObject : LuaObject
{
	// Token: 0x06017B3F RID: 97087 RVA: 0x00684B04 File Offset: 0x00682D04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CacheObject o = new CacheObject();
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

	// Token: 0x06017B40 RID: 97088 RVA: 0x00684B4C File Offset: 0x00682D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Dirty(IntPtr l)
	{
		int result;
		try
		{
			CacheObject cacheObject = (CacheObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cacheObject.Dirty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B41 RID: 97089 RVA: 0x00684BA0 File Offset: 0x00682DA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Dirty(IntPtr l)
	{
		int result;
		try
		{
			CacheObject cacheObject = (CacheObject)LuaObject.checkSelf(l);
			bool dirty;
			LuaObject.checkType(l, 2, out dirty);
			cacheObject.Dirty = dirty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B42 RID: 97090 RVA: 0x00684BF8 File Offset: 0x00682DF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.CacheObject");
		string name = "Dirty";
		if (Lua_BlackJack_ProjectL_Common_CacheObject.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_CacheObject.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CacheObject.get_Dirty);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_CacheObject.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_CacheObject.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_CacheObject.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CacheObject.set_Dirty);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_CacheObject.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Common_CacheObject.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_CacheObject.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CacheObject.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_CacheObject.<>f__mg$cache2, typeof(CacheObject));
	}

	// Token: 0x0400E16F RID: 57711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E170 RID: 57712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E171 RID: 57713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
