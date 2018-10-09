using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012F5 RID: 4853
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit : LuaObject
{
	// Token: 0x0601A1C9 RID: 106953 RVA: 0x007AD324 File Offset: 0x007AB524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit o = new ClientActorActBuffHit();
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

	// Token: 0x0601A1CA RID: 106954 RVA: 0x007AD36C File Offset: 0x007AB56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffState(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit clientActorActBuffHit = (ClientActorActBuffHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActBuffHit.m_buffState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1CB RID: 106955 RVA: 0x007AD3C0 File Offset: 0x007AB5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffState(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit clientActorActBuffHit = (ClientActorActBuffHit)LuaObject.checkSelf(l);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 2, out buffState);
			clientActorActBuffHit.m_buffState = buffState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1CC RID: 106956 RVA: 0x007AD418 File Offset: 0x007AB618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit clientActorActBuffHit = (ClientActorActBuffHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActBuffHit.m_heroHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1CD RID: 106957 RVA: 0x007AD46C File Offset: 0x007AB66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit clientActorActBuffHit = (ClientActorActBuffHit)LuaObject.checkSelf(l);
			int heroHp;
			LuaObject.checkType(l, 2, out heroHp);
			clientActorActBuffHit.m_heroHp = heroHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1CE RID: 106958 RVA: 0x007AD4C4 File Offset: 0x007AB6C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit clientActorActBuffHit = (ClientActorActBuffHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActBuffHit.m_soldierHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1CF RID: 106959 RVA: 0x007AD518 File Offset: 0x007AB718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit clientActorActBuffHit = (ClientActorActBuffHit)LuaObject.checkSelf(l);
			int soldierHp;
			LuaObject.checkType(l, 2, out soldierHp);
			clientActorActBuffHit.m_soldierHp = soldierHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1D0 RID: 106960 RVA: 0x007AD570 File Offset: 0x007AB770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHpModify(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit clientActorActBuffHit = (ClientActorActBuffHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActBuffHit.m_heroHpModify);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1D1 RID: 106961 RVA: 0x007AD5C4 File Offset: 0x007AB7C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHpModify(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit clientActorActBuffHit = (ClientActorActBuffHit)LuaObject.checkSelf(l);
			int heroHpModify;
			LuaObject.checkType(l, 2, out heroHpModify);
			clientActorActBuffHit.m_heroHpModify = heroHpModify;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1D2 RID: 106962 RVA: 0x007AD61C File Offset: 0x007AB81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHpModify(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit clientActorActBuffHit = (ClientActorActBuffHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActBuffHit.m_soldierHpModify);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1D3 RID: 106963 RVA: 0x007AD670 File Offset: 0x007AB870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHpModify(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit clientActorActBuffHit = (ClientActorActBuffHit)LuaObject.checkSelf(l);
			int soldierHpModify;
			LuaObject.checkType(l, 2, out soldierHpModify);
			clientActorActBuffHit.m_soldierHpModify = soldierHpModify;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1D4 RID: 106964 RVA: 0x007AD6C8 File Offset: 0x007AB8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberType(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit clientActorActBuffHit = (ClientActorActBuffHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)clientActorActBuffHit.m_damageNumberType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1D5 RID: 106965 RVA: 0x007AD71C File Offset: 0x007AB91C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberType(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBuffHit clientActorActBuffHit = (ClientActorActBuffHit)LuaObject.checkSelf(l);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 2, out damageNumberType);
			clientActorActBuffHit.m_damageNumberType = damageNumberType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1D6 RID: 106966 RVA: 0x007AD774 File Offset: 0x007AB974
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActBuffHit");
		string name = "m_buffState";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.get_m_buffState);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.set_m_buffState);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache1, true);
		string name2 = "m_heroHp";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.get_m_heroHp);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.set_m_heroHp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache3, true);
		string name3 = "m_soldierHp";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.get_m_soldierHp);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.set_m_soldierHp);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache5, true);
		string name4 = "m_heroHpModify";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.get_m_heroHpModify);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.set_m_heroHpModify);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache7, true);
		string name5 = "m_soldierHpModify";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.get_m_soldierHpModify);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.set_m_soldierHpModify);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cache9, true);
		string name6 = "m_damageNumberType";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.get_m_damageNumberType);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.set_m_damageNumberType);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.<>f__mg$cacheC, typeof(ClientActorActBuffHit), typeof(ClientActorAct));
	}

	// Token: 0x040105C1 RID: 67009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105C2 RID: 67010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105C3 RID: 67011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040105C4 RID: 67012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040105C5 RID: 67013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040105C6 RID: 67014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040105C7 RID: 67015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040105C8 RID: 67016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040105C9 RID: 67017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040105CA RID: 67018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040105CB RID: 67019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040105CC RID: 67020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040105CD RID: 67021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
