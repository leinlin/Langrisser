using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012DF RID: 4831
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus : LuaObject
{
	// Token: 0x06019FE4 RID: 106468 RVA: 0x0079EC98 File Offset: 0x0079CE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroStatus o = new RewardHeroStatus();
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

	// Token: 0x06019FE5 RID: 106469 RVA: 0x0079ECE0 File Offset: 0x0079CEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroStatus rewardHeroStatus = (RewardHeroStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroStatus.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FE6 RID: 106470 RVA: 0x0079ED34 File Offset: 0x0079CF34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Id(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroStatus rewardHeroStatus = (RewardHeroStatus)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			rewardHeroStatus.Id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FE7 RID: 106471 RVA: 0x0079ED8C File Offset: 0x0079CF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroStatus rewardHeroStatus = (RewardHeroStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroStatus.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FE8 RID: 106472 RVA: 0x0079EDE0 File Offset: 0x0079CFE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroStatus rewardHeroStatus = (RewardHeroStatus)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			rewardHeroStatus.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FE9 RID: 106473 RVA: 0x0079EE38 File Offset: 0x0079D038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Exp(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroStatus rewardHeroStatus = (RewardHeroStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroStatus.Exp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FEA RID: 106474 RVA: 0x0079EE8C File Offset: 0x0079D08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Exp(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroStatus rewardHeroStatus = (RewardHeroStatus)LuaObject.checkSelf(l);
			int exp;
			LuaObject.checkType(l, 2, out exp);
			rewardHeroStatus.Exp = exp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FEB RID: 106475 RVA: 0x0079EEE4 File Offset: 0x0079D0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextLevelExp(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroStatus rewardHeroStatus = (RewardHeroStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroStatus.NextLevelExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FEC RID: 106476 RVA: 0x0079EF38 File Offset: 0x0079D138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NextLevelExp(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroStatus rewardHeroStatus = (RewardHeroStatus)LuaObject.checkSelf(l);
			int nextLevelExp;
			LuaObject.checkType(l, 2, out nextLevelExp);
			rewardHeroStatus.NextLevelExp = nextLevelExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FED RID: 106477 RVA: 0x0079EF90 File Offset: 0x0079D190
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.RewardHeroStatus");
		string name = "Id";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.get_Id);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.set_Id);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache1, true);
		string name2 = "Level";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.get_Level);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.set_Level);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache3, true);
		string name3 = "Exp";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.get_Exp);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.set_Exp);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache5, true);
		string name4 = "NextLevelExp";
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.get_NextLevelExp);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.set_NextLevelExp);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.<>f__mg$cache8, typeof(RewardHeroStatus));
	}

	// Token: 0x04010408 RID: 66568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010409 RID: 66569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401040A RID: 66570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401040B RID: 66571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401040C RID: 66572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401040D RID: 66573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401040E RID: 66574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401040F RID: 66575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010410 RID: 66576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
