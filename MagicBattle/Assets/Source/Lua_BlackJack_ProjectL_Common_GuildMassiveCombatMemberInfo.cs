using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200122F RID: 4655
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo : LuaObject
{
	// Token: 0x06018240 RID: 98880 RVA: 0x006B6C54 File Offset: 0x006B4E54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo o = new GuildMassiveCombatMemberInfo();
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

	// Token: 0x06018241 RID: 98881 RVA: 0x006B6C9C File Offset: 0x006B4E9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPro(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo memberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			ProGuildMassiveCombatMemberInfo o = memberInfo.ToPro();
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

	// Token: 0x06018242 RID: 98882 RVA: 0x006B6CF0 File Offset: 0x006B4EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PointsRewardsClaimed(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatMemberInfo.PointsRewardsClaimed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018243 RID: 98883 RVA: 0x006B6D44 File Offset: 0x006B4F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PointsRewardsClaimed(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			List<int> pointsRewardsClaimed;
			LuaObject.checkType<List<int>>(l, 2, out pointsRewardsClaimed);
			guildMassiveCombatMemberInfo.PointsRewardsClaimed = pointsRewardsClaimed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018244 RID: 98884 RVA: 0x006B6D9C File Offset: 0x006B4F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Summary(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatMemberInfo.Summary);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018245 RID: 98885 RVA: 0x006B6DF0 File Offset: 0x006B4FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Summary(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			UserSummary summary;
			LuaObject.checkType<UserSummary>(l, 2, out summary);
			guildMassiveCombatMemberInfo.Summary = summary;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018246 RID: 98886 RVA: 0x006B6E48 File Offset: 0x006B5048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatMemberInfo.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018247 RID: 98887 RVA: 0x006B6E9C File Offset: 0x006B509C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			guildMassiveCombatMemberInfo.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018248 RID: 98888 RVA: 0x006B6EF4 File Offset: 0x006B50F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Points(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatMemberInfo.Points);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018249 RID: 98889 RVA: 0x006B6F48 File Offset: 0x006B5148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Points(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			int points;
			LuaObject.checkType(l, 2, out points);
			guildMassiveCombatMemberInfo.Points = points;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601824A RID: 98890 RVA: 0x006B6FA0 File Offset: 0x006B51A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PointsToday(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatMemberInfo.PointsToday);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601824B RID: 98891 RVA: 0x006B6FF4 File Offset: 0x006B51F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PointsToday(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			int pointsToday;
			LuaObject.checkType(l, 2, out pointsToday);
			guildMassiveCombatMemberInfo.PointsToday = pointsToday;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601824C RID: 98892 RVA: 0x006B704C File Offset: 0x006B524C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Title(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)guildMassiveCombatMemberInfo.Title);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601824D RID: 98893 RVA: 0x006B70A0 File Offset: 0x006B52A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Title(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatMemberInfo guildMassiveCombatMemberInfo = (GuildMassiveCombatMemberInfo)LuaObject.checkSelf(l);
			GuildTitle title;
			LuaObject.checkEnum<GuildTitle>(l, 2, out title);
			guildMassiveCombatMemberInfo.Title = title;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601824E RID: 98894 RVA: 0x006B70F8 File Offset: 0x006B52F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GuildMassiveCombatMemberInfo");
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.ToPro);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache0);
		string name = "PointsRewardsClaimed";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.get_PointsRewardsClaimed);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.set_PointsRewardsClaimed);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache2, true);
		string name2 = "Summary";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.get_Summary);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.set_Summary);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache4, true);
		string name3 = "UserId";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.get_UserId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.set_UserId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache6, true);
		string name4 = "Points";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.get_Points);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.set_Points);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache8, true);
		string name5 = "PointsToday";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.get_PointsToday);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.set_PointsToday);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cacheA, true);
		string name6 = "Title";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.get_Title);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.set_Title);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cacheC, true);
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.<>f__mg$cacheD, typeof(GuildMassiveCombatMemberInfo));
	}

	// Token: 0x0400E7C4 RID: 59332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E7C5 RID: 59333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E7C6 RID: 59334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E7C7 RID: 59335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E7C8 RID: 59336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E7C9 RID: 59337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E7CA RID: 59338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E7CB RID: 59339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E7CC RID: 59340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E7CD RID: 59341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E7CE RID: 59342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E7CF RID: 59343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E7D0 RID: 59344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E7D1 RID: 59345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
