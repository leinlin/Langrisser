using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001293 RID: 4755
[Preserve]
public class Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject : LuaObject
{
	// Token: 0x06018C8D RID: 101517 RVA: 0x007045EC File Offset: 0x007027EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UnThreadSafeLRUCacheObject o = new UnThreadSafeLRUCacheObject();
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

	// Token: 0x06018C8E RID: 101518 RVA: 0x00704634 File Offset: 0x00702834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLastUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			UnThreadSafeLRUCacheObject unThreadSafeLRUCacheObject = (UnThreadSafeLRUCacheObject)LuaObject.checkSelf(l);
			unThreadSafeLRUCacheObject.SetLastUpdateTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C8F RID: 101519 RVA: 0x00704680 File Offset: 0x00702880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLastUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			UnThreadSafeLRUCacheObject unThreadSafeLRUCacheObject = (UnThreadSafeLRUCacheObject)LuaObject.checkSelf(l);
			long lastUpdateTime = unThreadSafeLRUCacheObject.GetLastUpdateTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C90 RID: 101520 RVA: 0x007046D4 File Offset: 0x007028D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLastReadTime(IntPtr l)
	{
		int result;
		try
		{
			UnThreadSafeLRUCacheObject unThreadSafeLRUCacheObject = (UnThreadSafeLRUCacheObject)LuaObject.checkSelf(l);
			unThreadSafeLRUCacheObject.SetLastReadTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C91 RID: 101521 RVA: 0x00704720 File Offset: 0x00702920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLastReadTime(IntPtr l)
	{
		int result;
		try
		{
			UnThreadSafeLRUCacheObject unThreadSafeLRUCacheObject = (UnThreadSafeLRUCacheObject)LuaObject.checkSelf(l);
			long lastReadTime = unThreadSafeLRUCacheObject.GetLastReadTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastReadTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C92 RID: 101522 RVA: 0x00704774 File Offset: 0x00702974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNewestTime(IntPtr l)
	{
		int result;
		try
		{
			UnThreadSafeLRUCacheObject unThreadSafeLRUCacheObject = (UnThreadSafeLRUCacheObject)LuaObject.checkSelf(l);
			long newestTime = unThreadSafeLRUCacheObject.GetNewestTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, newestTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C93 RID: 101523 RVA: 0x007047C8 File Offset: 0x007029C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.UnThreadSafeLRUCacheObject");
		if (Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.SetLastUpdateTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.GetLastUpdateTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.SetLastReadTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.GetLastReadTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.GetNewestTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.<>f__mg$cache5, typeof(UnThreadSafeLRUCacheObject), typeof(CacheObject));
	}

	// Token: 0x0400F149 RID: 61769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F14A RID: 61770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F14B RID: 61771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F14C RID: 61772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F14D RID: 61773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F14E RID: 61774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
