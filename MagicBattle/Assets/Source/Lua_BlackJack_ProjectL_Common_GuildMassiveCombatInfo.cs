using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200122E RID: 4654
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo : LuaObject
{
	// Token: 0x0601822C RID: 98860 RVA: 0x006B6390 File Offset: 0x006B4590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo o = new GuildMassiveCombatInfo();
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

	// Token: 0x0601822D RID: 98861 RVA: 0x006B63D8 File Offset: 0x006B45D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRewardSent(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			DateTime now;
			LuaObject.checkValueType<DateTime>(l, 2, out now);
			bool b = guildMassiveCombatInfo.IsRewardSent(now);
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

	// Token: 0x0601822E RID: 98862 RVA: 0x006B643C File Offset: 0x006B463C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStronghold(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			GuildMassiveCombatStronghold stronghold = guildMassiveCombatInfo.GetStronghold(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stronghold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601822F RID: 98863 RVA: 0x006B64A0 File Offset: 0x006B46A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPro(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo combatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			ProGuildMassiveCombatInfo o = combatInfo.ToPro();
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

	// Token: 0x06018230 RID: 98864 RVA: 0x006B64F4 File Offset: 0x006B46F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Strongholds(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatInfo.Strongholds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018231 RID: 98865 RVA: 0x006B6548 File Offset: 0x006B4748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Strongholds(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			List<GuildMassiveCombatStronghold> strongholds;
			LuaObject.checkType<List<GuildMassiveCombatStronghold>>(l, 2, out strongholds);
			guildMassiveCombatInfo.Strongholds = strongholds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018232 RID: 98866 RVA: 0x006B65A0 File Offset: 0x006B47A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Members(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatInfo.Members);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018233 RID: 98867 RVA: 0x006B65F4 File Offset: 0x006B47F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Members(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			List<GuildMassiveCombatMemberInfo> members;
			LuaObject.checkType<List<GuildMassiveCombatMemberInfo>>(l, 2, out members);
			guildMassiveCombatInfo.Members = members;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018234 RID: 98868 RVA: 0x006B664C File Offset: 0x006B484C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CreateTime(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatInfo.CreateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018235 RID: 98869 RVA: 0x006B66A4 File Offset: 0x006B48A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CreateTime(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			DateTime createTime;
			LuaObject.checkValueType<DateTime>(l, 2, out createTime);
			guildMassiveCombatInfo.CreateTime = createTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018236 RID: 98870 RVA: 0x006B66FC File Offset: 0x006B48FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FinishTime(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatInfo.FinishTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018237 RID: 98871 RVA: 0x006B6754 File Offset: 0x006B4954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FinishTime(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			DateTime finishTime;
			LuaObject.checkValueType<DateTime>(l, 2, out finishTime);
			guildMassiveCombatInfo.FinishTime = finishTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018238 RID: 98872 RVA: 0x006B67AC File Offset: 0x006B49AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RewardSendTime(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatInfo.RewardSendTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018239 RID: 98873 RVA: 0x006B6804 File Offset: 0x006B4A04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RewardSendTime(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			DateTime rewardSendTime;
			LuaObject.checkValueType<DateTime>(l, 2, out rewardSendTime);
			guildMassiveCombatInfo.RewardSendTime = rewardSendTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601823A RID: 98874 RVA: 0x006B685C File Offset: 0x006B4A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatInfo.InstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601823B RID: 98875 RVA: 0x006B68B0 File Offset: 0x006B4AB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			guildMassiveCombatInfo.InstanceId = instanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601823C RID: 98876 RVA: 0x006B6908 File Offset: 0x006B4B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Difficulty(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatInfo.Difficulty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601823D RID: 98877 RVA: 0x006B695C File Offset: 0x006B4B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Difficulty(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatInfo guildMassiveCombatInfo = (GuildMassiveCombatInfo)LuaObject.checkSelf(l);
			int difficulty;
			LuaObject.checkType(l, 2, out difficulty);
			guildMassiveCombatInfo.Difficulty = difficulty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601823E RID: 98878 RVA: 0x006B69B4 File Offset: 0x006B4BB4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GuildMassiveCombatInfo");
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.IsRewardSent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.GetStronghold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.ToPro);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache2);
		string name = "Strongholds";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.get_Strongholds);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.set_Strongholds);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache4, true);
		string name2 = "Members";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.get_Members);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.set_Members);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache6, true);
		string name3 = "CreateTime";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.get_CreateTime);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.set_CreateTime);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache8, true);
		string name4 = "FinishTime";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.get_FinishTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.set_FinishTime);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheA, true);
		string name5 = "RewardSendTime";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.get_RewardSendTime);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.set_RewardSendTime);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheC, true);
		string name6 = "InstanceId";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.get_InstanceId);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.set_InstanceId);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheE, true);
		string name7 = "Difficulty";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.get_Difficulty);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.set_Difficulty);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache10, true);
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.<>f__mg$cache11, typeof(GuildMassiveCombatInfo));
	}

	// Token: 0x0400E7B2 RID: 59314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E7B3 RID: 59315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E7B4 RID: 59316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E7B5 RID: 59317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E7B6 RID: 59318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E7B7 RID: 59319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E7B8 RID: 59320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E7B9 RID: 59321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E7BA RID: 59322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E7BB RID: 59323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E7BC RID: 59324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E7BD RID: 59325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E7BE RID: 59326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E7BF RID: 59327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E7C0 RID: 59328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E7C1 RID: 59329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E7C2 RID: 59330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E7C3 RID: 59331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
