using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011C8 RID: 4552
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleActorLogInfo : LuaObject
{
	// Token: 0x06017979 RID: 96633 RVA: 0x00677A50 File Offset: 0x00675C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleActorLogInfo o = new BattleActorLogInfo();
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

	// Token: 0x0601797A RID: 96634 RVA: 0x00677A98 File Offset: 0x00675C98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_heroId(IntPtr l)
	{
		int result;
		try
		{
			BattleActorLogInfo battleActorLogInfo = (BattleActorLogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorLogInfo.heroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601797B RID: 96635 RVA: 0x00677AEC File Offset: 0x00675CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_heroId(IntPtr l)
	{
		int result;
		try
		{
			BattleActorLogInfo battleActorLogInfo = (BattleActorLogInfo)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			battleActorLogInfo.heroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601797C RID: 96636 RVA: 0x00677B44 File Offset: 0x00675D44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_killEnemies(IntPtr l)
	{
		int result;
		try
		{
			BattleActorLogInfo battleActorLogInfo = (BattleActorLogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorLogInfo.killEnemies);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601797D RID: 96637 RVA: 0x00677B98 File Offset: 0x00675D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_killEnemies(IntPtr l)
	{
		int result;
		try
		{
			BattleActorLogInfo battleActorLogInfo = (BattleActorLogInfo)LuaObject.checkSelf(l);
			int killEnemies;
			LuaObject.checkType(l, 2, out killEnemies);
			battleActorLogInfo.killEnemies = killEnemies;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601797E RID: 96638 RVA: 0x00677BF0 File Offset: 0x00675DF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_useSkills(IntPtr l)
	{
		int result;
		try
		{
			BattleActorLogInfo battleActorLogInfo = (BattleActorLogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorLogInfo.useSkills);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601797F RID: 96639 RVA: 0x00677C44 File Offset: 0x00675E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useSkills(IntPtr l)
	{
		int result;
		try
		{
			BattleActorLogInfo battleActorLogInfo = (BattleActorLogInfo)LuaObject.checkSelf(l);
			int useSkills;
			LuaObject.checkType(l, 2, out useSkills);
			battleActorLogInfo.useSkills = useSkills;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017980 RID: 96640 RVA: 0x00677C9C File Offset: 0x00675E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deadTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleActorLogInfo battleActorLogInfo = (BattleActorLogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorLogInfo.deadTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017981 RID: 96641 RVA: 0x00677CF0 File Offset: 0x00675EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_deadTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleActorLogInfo battleActorLogInfo = (BattleActorLogInfo)LuaObject.checkSelf(l);
			int deadTurn;
			LuaObject.checkType(l, 2, out deadTurn);
			battleActorLogInfo.deadTurn = deadTurn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017982 RID: 96642 RVA: 0x00677D48 File Offset: 0x00675F48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_killerId(IntPtr l)
	{
		int result;
		try
		{
			BattleActorLogInfo battleActorLogInfo = (BattleActorLogInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorLogInfo.killerId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017983 RID: 96643 RVA: 0x00677D9C File Offset: 0x00675F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_killerId(IntPtr l)
	{
		int result;
		try
		{
			BattleActorLogInfo battleActorLogInfo = (BattleActorLogInfo)LuaObject.checkSelf(l);
			int killerId;
			LuaObject.checkType(l, 2, out killerId);
			battleActorLogInfo.killerId = killerId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017984 RID: 96644 RVA: 0x00677DF4 File Offset: 0x00675FF4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleActorLogInfo");
		string name = "heroId";
		if (Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.get_heroId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.set_heroId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache1, true);
		string name2 = "killEnemies";
		if (Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.get_killEnemies);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.set_killEnemies);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache3, true);
		string name3 = "useSkills";
		if (Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.get_useSkills);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.set_useSkills);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache5, true);
		string name4 = "deadTurn";
		if (Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.get_deadTurn);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.set_deadTurn);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache7, true);
		string name5 = "killerId";
		if (Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.get_killerId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.set_killerId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.<>f__mg$cacheA, typeof(BattleActorLogInfo));
	}

	// Token: 0x0400DFCB RID: 57291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DFCC RID: 57292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DFCD RID: 57293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DFCE RID: 57294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DFCF RID: 57295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DFD0 RID: 57296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DFD1 RID: 57297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DFD2 RID: 57298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DFD3 RID: 57299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DFD4 RID: 57300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DFD5 RID: 57301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
