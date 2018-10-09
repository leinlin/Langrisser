using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011EE RID: 4590
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon : LuaObject
{
	// Token: 0x06017CDF RID: 97503 RVA: 0x0069020C File Offset: 0x0068E40C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon o = new DanmakuComponentCommon();
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

	// Token: 0x06017CE0 RID: 97504 RVA: 0x00690254 File Offset: 0x0068E454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			string name = danmakuComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CE1 RID: 97505 RVA: 0x006902A8 File Offset: 0x0068E4A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			danmakuComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CE2 RID: 97506 RVA: 0x006902F4 File Offset: 0x0068E4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			danmakuComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CE3 RID: 97507 RVA: 0x00690340 File Offset: 0x0068E540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			danmakuComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CE4 RID: 97508 RVA: 0x0069038C File Offset: 0x0068E58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			danmakuComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CE5 RID: 97509 RVA: 0x006903E4 File Offset: 0x0068E5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			danmakuComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CE6 RID: 97510 RVA: 0x00690430 File Offset: 0x0068E630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGetLevelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			int gameFunctionTypeId;
			LuaObject.checkType(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int i = danmakuComponentCommon.CanGetLevelDanmaku(gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CE7 RID: 97511 RVA: 0x006904A0 File Offset: 0x0068E6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanPostLevelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			int gameFunctionTypeId;
			LuaObject.checkType(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			List<PostDanmakuEntry> entries;
			LuaObject.checkType<List<PostDanmakuEntry>>(l, 4, out entries);
			int i = danmakuComponentCommon.CanPostLevelDanmaku(gameFunctionTypeId, locationId, entries);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CE8 RID: 97512 RVA: 0x0069051C File Offset: 0x0068E71C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CombineLevelDanmakuKey(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			int gameFunctionTypeId;
			LuaObject.checkType(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			string s = danmakuComponentCommon.CombineLevelDanmakuKey(gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CE9 RID: 97513 RVA: 0x0069058C File Offset: 0x0068E78C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TruncateDanmakuOrNot(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			PostDanmakuEntry entry;
			LuaObject.checkType<PostDanmakuEntry>(l, 2, out entry);
			danmakuComponentCommon.m_luaExportHelper.TruncateDanmakuOrNot(entry);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CEA RID: 97514 RVA: 0x006905E8 File Offset: 0x0068E7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, danmakuComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CEB RID: 97515 RVA: 0x00690640 File Offset: 0x0068E840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			danmakuComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CEC RID: 97516 RVA: 0x0069069C File Offset: 0x0068E89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, danmakuComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CED RID: 97517 RVA: 0x006906F0 File Offset: 0x0068E8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponentCommon danmakuComponentCommon = (DanmakuComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			danmakuComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CEE RID: 97518 RVA: 0x00690748 File Offset: 0x0068E948
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DanmakuComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.CanGetLevelDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.CanPostLevelDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.CombineLevelDanmakuKey);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.TruncateDanmakuOrNot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cache9);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheB, true);
		string name2 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.get_Owner);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheD, true);
		if (Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.<>f__mg$cacheE, typeof(DanmakuComponentCommon));
	}

	// Token: 0x0400E2E5 RID: 58085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E2E6 RID: 58086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E2E7 RID: 58087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E2E8 RID: 58088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E2E9 RID: 58089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E2EA RID: 58090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E2EB RID: 58091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E2EC RID: 58092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E2ED RID: 58093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E2EE RID: 58094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E2EF RID: 58095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E2F0 RID: 58096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E2F1 RID: 58097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E2F2 RID: 58098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E2F3 RID: 58099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
