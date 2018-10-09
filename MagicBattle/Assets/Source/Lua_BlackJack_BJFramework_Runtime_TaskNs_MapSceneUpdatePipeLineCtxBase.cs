using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001122 RID: 4386
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase : LuaObject
{
	// Token: 0x06015CBE RID: 89278 RVA: 0x0059FC7C File Offset: 0x0059DE7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase o = new MapSceneUpdatePipeLineCtxBase();
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

	// Token: 0x06015CBF RID: 89279 RVA: 0x0059FCC4 File Offset: 0x0059DEC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = (MapSceneUpdatePipeLineCtxBase)LuaObject.checkSelf(l);
			bool b = mapSceneUpdatePipeLineCtxBase.Start();
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

	// Token: 0x06015CC0 RID: 89280 RVA: 0x0059FD18 File Offset: 0x0059DF18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = (MapSceneUpdatePipeLineCtxBase)LuaObject.checkSelf(l);
			mapSceneUpdatePipeLineCtxBase.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CC1 RID: 89281 RVA: 0x0059FD64 File Offset: 0x0059DF64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsRunning(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = (MapSceneUpdatePipeLineCtxBase)LuaObject.checkSelf(l);
			bool b = mapSceneUpdatePipeLineCtxBase.IsRunning();
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

	// Token: 0x06015CC2 RID: 89282 RVA: 0x0059FDB8 File Offset: 0x0059DFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_runing(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = (MapSceneUpdatePipeLineCtxBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneUpdatePipeLineCtxBase.m_luaExportHelper.m_runing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CC3 RID: 89283 RVA: 0x0059FE10 File Offset: 0x0059E010
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_runing(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = (MapSceneUpdatePipeLineCtxBase)LuaObject.checkSelf(l);
			bool runing;
			LuaObject.checkType(l, 2, out runing);
			mapSceneUpdatePipeLineCtxBase.m_luaExportHelper.m_runing = runing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CC4 RID: 89284 RVA: 0x0059FE6C File Offset: 0x0059E06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockResCache(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = (MapSceneUpdatePipeLineCtxBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneUpdatePipeLineCtxBase.m_lockResCache);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CC5 RID: 89285 RVA: 0x0059FEC0 File Offset: 0x0059E0C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lockResCache(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = (MapSceneUpdatePipeLineCtxBase)LuaObject.checkSelf(l);
			bool lockResCache;
			LuaObject.checkType(l, 2, out lockResCache);
			mapSceneUpdatePipeLineCtxBase.m_lockResCache = lockResCache;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CC6 RID: 89286 RVA: 0x0059FF18 File Offset: 0x0059E118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loadingStaticResCorutineCount(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = (MapSceneUpdatePipeLineCtxBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneUpdatePipeLineCtxBase.m_loadingStaticResCorutineCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CC7 RID: 89287 RVA: 0x0059FF6C File Offset: 0x0059E16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loadingStaticResCorutineCount(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = (MapSceneUpdatePipeLineCtxBase)LuaObject.checkSelf(l);
			int loadingStaticResCorutineCount;
			LuaObject.checkType(l, 2, out loadingStaticResCorutineCount);
			mapSceneUpdatePipeLineCtxBase.m_loadingStaticResCorutineCount = loadingStaticResCorutineCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CC8 RID: 89288 RVA: 0x0059FFC4 File Offset: 0x0059E1C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_loadingDynamicResCorutineCount(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = (MapSceneUpdatePipeLineCtxBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneUpdatePipeLineCtxBase.m_loadingDynamicResCorutineCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CC9 RID: 89289 RVA: 0x005A0018 File Offset: 0x0059E218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loadingDynamicResCorutineCount(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = (MapSceneUpdatePipeLineCtxBase)LuaObject.checkSelf(l);
			int loadingDynamicResCorutineCount;
			LuaObject.checkType(l, 2, out loadingDynamicResCorutineCount);
			mapSceneUpdatePipeLineCtxBase.m_loadingDynamicResCorutineCount = loadingDynamicResCorutineCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CCA RID: 89290 RVA: 0x005A0070 File Offset: 0x0059E270
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_updateViewAction(IntPtr l)
	{
		int result;
		try
		{
			MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase = (MapSceneUpdatePipeLineCtxBase)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				mapSceneUpdatePipeLineCtxBase.m_updateViewAction = action;
			}
			else if (num == 1)
			{
				MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase2 = mapSceneUpdatePipeLineCtxBase;
				mapSceneUpdatePipeLineCtxBase2.m_updateViewAction = (Action)Delegate.Combine(mapSceneUpdatePipeLineCtxBase2.m_updateViewAction, action);
			}
			else if (num == 2)
			{
				MapSceneUpdatePipeLineCtxBase mapSceneUpdatePipeLineCtxBase3 = mapSceneUpdatePipeLineCtxBase;
				mapSceneUpdatePipeLineCtxBase3.m_updateViewAction = (Action)Delegate.Remove(mapSceneUpdatePipeLineCtxBase3.m_updateViewAction, action);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CCB RID: 89291 RVA: 0x005A0118 File Offset: 0x0059E318
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.TaskNs.MapSceneUpdatePipeLineCtxBase");
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.IsRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache2);
		string name = "m_runing";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.get_m_runing);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache3;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.set_m_runing);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache4, true);
		string name2 = "m_lockResCache";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.get_m_lockResCache);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache5;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.set_m_lockResCache);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache6, true);
		string name3 = "m_loadingStaticResCorutineCount";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.get_m_loadingStaticResCorutineCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache7;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.set_m_loadingStaticResCorutineCount);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache8, true);
		string name4 = "m_loadingDynamicResCorutineCount";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.get_m_loadingDynamicResCorutineCount);
		}
		LuaCSFunction get4 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cache9;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.set_m_loadingDynamicResCorutineCount);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cacheA, true);
		string name5 = "m_updateViewAction";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.set_m_updateViewAction);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cacheB, true);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.<>f__mg$cacheC, typeof(MapSceneUpdatePipeLineCtxBase));
	}

	// Token: 0x0400C45C RID: 50268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C45D RID: 50269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C45E RID: 50270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C45F RID: 50271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C460 RID: 50272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C461 RID: 50273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C462 RID: 50274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C463 RID: 50275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C464 RID: 50276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C465 RID: 50277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C466 RID: 50278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C467 RID: 50279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C468 RID: 50280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
