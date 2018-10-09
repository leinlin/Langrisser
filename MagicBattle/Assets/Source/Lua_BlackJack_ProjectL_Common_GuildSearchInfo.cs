using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001234 RID: 4660
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GuildSearchInfo : LuaObject
{
	// Token: 0x0601828D RID: 98957 RVA: 0x006B8C94 File Offset: 0x006B6E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo o = new GuildSearchInfo();
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

	// Token: 0x0601828E RID: 98958 RVA: 0x006B8CDC File Offset: 0x006B6EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPBGuildSearchInfo_s(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo info;
			LuaObject.checkType<GuildSearchInfo>(l, 1, out info);
			ProGuildSearchInfo o = GuildSearchInfo.ToPBGuildSearchInfo(info);
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

	// Token: 0x0601828F RID: 98959 RVA: 0x006B8D30 File Offset: 0x006B6F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToGuildSearchInfo_s(IntPtr l)
	{
		int result;
		try
		{
			ProGuildSearchInfo proInfo;
			LuaObject.checkType<ProGuildSearchInfo>(l, 1, out proInfo);
			GuildSearchInfo o = GuildSearchInfo.ToGuildSearchInfo(proInfo);
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

	// Token: 0x06018290 RID: 98960 RVA: 0x006B8D84 File Offset: 0x006B6F84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildSearchInfo.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018291 RID: 98961 RVA: 0x006B8DD8 File Offset: 0x006B6FD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Id(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			string id;
			LuaObject.checkType(l, 2, out id);
			guildSearchInfo.Id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018292 RID: 98962 RVA: 0x006B8E30 File Offset: 0x006B7030
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildSearchInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018293 RID: 98963 RVA: 0x006B8E84 File Offset: 0x006B7084
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			guildSearchInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018294 RID: 98964 RVA: 0x006B8EDC File Offset: 0x006B70DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MemberCount(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildSearchInfo.MemberCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018295 RID: 98965 RVA: 0x006B8F30 File Offset: 0x006B7130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MemberCount(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			int memberCount;
			LuaObject.checkType(l, 2, out memberCount);
			guildSearchInfo.MemberCount = memberCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018296 RID: 98966 RVA: 0x006B8F88 File Offset: 0x006B7188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JoinLevel(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildSearchInfo.JoinLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018297 RID: 98967 RVA: 0x006B8FDC File Offset: 0x006B71DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_JoinLevel(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			int joinLevel;
			LuaObject.checkType(l, 2, out joinLevel);
			guildSearchInfo.JoinLevel = joinLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018298 RID: 98968 RVA: 0x006B9034 File Offset: 0x006B7234
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LastWeekActivities(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildSearchInfo.LastWeekActivities);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018299 RID: 98969 RVA: 0x006B9088 File Offset: 0x006B7288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LastWeekActivities(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			int lastWeekActivities;
			LuaObject.checkType(l, 2, out lastWeekActivities);
			guildSearchInfo.LastWeekActivities = lastWeekActivities;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601829A RID: 98970 RVA: 0x006B90E0 File Offset: 0x006B72E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HiringDeclaration(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildSearchInfo.HiringDeclaration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601829B RID: 98971 RVA: 0x006B9134 File Offset: 0x006B7334
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HiringDeclaration(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			string hiringDeclaration;
			LuaObject.checkType(l, 2, out hiringDeclaration);
			guildSearchInfo.HiringDeclaration = hiringDeclaration;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601829C RID: 98972 RVA: 0x006B918C File Offset: 0x006B738C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PresidentMemberInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildSearchInfo.PresidentMemberInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601829D RID: 98973 RVA: 0x006B91E0 File Offset: 0x006B73E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PresidentMemberInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			GuildMember presidentMemberInfo;
			LuaObject.checkType<GuildMember>(l, 2, out presidentMemberInfo);
			guildSearchInfo.PresidentMemberInfo = presidentMemberInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601829E RID: 98974 RVA: 0x006B9238 File Offset: 0x006B7438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HaveSendJoinReq(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildSearchInfo.HaveSendJoinReq);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601829F RID: 98975 RVA: 0x006B928C File Offset: 0x006B748C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HaveSendJoinReq(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchInfo guildSearchInfo = (GuildSearchInfo)LuaObject.checkSelf(l);
			bool haveSendJoinReq;
			LuaObject.checkType(l, 2, out haveSendJoinReq);
			guildSearchInfo.HaveSendJoinReq = haveSendJoinReq;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182A0 RID: 98976 RVA: 0x006B92E4 File Offset: 0x006B74E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GuildSearchInfo");
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.ToPBGuildSearchInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.ToGuildSearchInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache1);
		string name = "Id";
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.get_Id);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.set_Id);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache3, true);
		string name2 = "Name";
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.get_Name);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.set_Name);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache5, true);
		string name3 = "MemberCount";
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.get_MemberCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.set_MemberCount);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache7, true);
		string name4 = "JoinLevel";
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.get_JoinLevel);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.set_JoinLevel);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache9, true);
		string name5 = "LastWeekActivities";
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.get_LastWeekActivities);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.set_LastWeekActivities);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheB, true);
		string name6 = "HiringDeclaration";
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.get_HiringDeclaration);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.set_HiringDeclaration);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheD, true);
		string name7 = "PresidentMemberInfo";
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.get_PresidentMemberInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.set_PresidentMemberInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cacheF, true);
		string name8 = "HaveSendJoinReq";
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.get_HaveSendJoinReq);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.set_HaveSendJoinReq);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache11, true);
		if (Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GuildSearchInfo.<>f__mg$cache12, typeof(GuildSearchInfo));
	}

	// Token: 0x0400E807 RID: 59399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E808 RID: 59400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E809 RID: 59401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E80A RID: 59402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E80B RID: 59403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E80C RID: 59404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E80D RID: 59405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E80E RID: 59406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E80F RID: 59407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E810 RID: 59408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E811 RID: 59409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E812 RID: 59410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E813 RID: 59411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E814 RID: 59412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E815 RID: 59413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E816 RID: 59414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E817 RID: 59415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E818 RID: 59416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E819 RID: 59417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
