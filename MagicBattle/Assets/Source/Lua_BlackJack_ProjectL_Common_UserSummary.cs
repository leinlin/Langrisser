using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001296 RID: 4758
[Preserve]
public class Lua_BlackJack_ProjectL_Common_UserSummary : LuaObject
{
	// Token: 0x06018CA3 RID: 101539 RVA: 0x00704E04 File Offset: 0x00703004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UserSummary o = new UserSummary();
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

	// Token: 0x06018CA4 RID: 101540 RVA: 0x00704E4C File Offset: 0x0070304C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPro(IntPtr l)
	{
		int result;
		try
		{
			UserSummary summary = (UserSummary)LuaObject.checkSelf(l);
			ProUserSummary o = summary.ToPro();
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

	// Token: 0x06018CA5 RID: 101541 RVA: 0x00704EA0 File Offset: 0x007030A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSummary.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CA6 RID: 101542 RVA: 0x00704EF4 File Offset: 0x007030F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			userSummary.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CA7 RID: 101543 RVA: 0x00704F4C File Offset: 0x0070314C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSummary.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CA8 RID: 101544 RVA: 0x00704FA0 File Offset: 0x007031A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			userSummary.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CA9 RID: 101545 RVA: 0x00704FF8 File Offset: 0x007031F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSummary.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CAA RID: 101546 RVA: 0x0070504C File Offset: 0x0070324C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			userSummary.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CAB RID: 101547 RVA: 0x007050A4 File Offset: 0x007032A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSummary.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CAC RID: 101548 RVA: 0x007050F8 File Offset: 0x007032F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			userSummary.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CAD RID: 101549 RVA: 0x00705150 File Offset: 0x00703350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Online(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSummary.Online);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CAE RID: 101550 RVA: 0x007051A4 File Offset: 0x007033A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Online(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			bool online;
			LuaObject.checkType(l, 2, out online);
			userSummary.Online = online;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CAF RID: 101551 RVA: 0x007051FC File Offset: 0x007033FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LogoutTime(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSummary.LogoutTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CB0 RID: 101552 RVA: 0x00705254 File Offset: 0x00703454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LogoutTime(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			DateTime logoutTime;
			LuaObject.checkValueType<DateTime>(l, 2, out logoutTime);
			userSummary.LogoutTime = logoutTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CB1 RID: 101553 RVA: 0x007052AC File Offset: 0x007034AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TopHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSummary.TopHeroBattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CB2 RID: 101554 RVA: 0x00705300 File Offset: 0x00703500
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TopHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			UserSummary userSummary = (UserSummary)LuaObject.checkSelf(l);
			int topHeroBattlePower;
			LuaObject.checkType(l, 2, out topHeroBattlePower);
			userSummary.TopHeroBattlePower = topHeroBattlePower;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018CB3 RID: 101555 RVA: 0x00705358 File Offset: 0x00703558
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.UserSummary");
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.ToPro);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache0);
		string name = "UserId";
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.get_UserId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.set_UserId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache2, true);
		string name2 = "Name";
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.get_Name);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.set_Name);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache4, true);
		string name3 = "Level";
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.get_Level);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.set_Level);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache6, true);
		string name4 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.get_HeadIcon);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.set_HeadIcon);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache8, true);
		string name5 = "Online";
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.get_Online);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.set_Online);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheA, true);
		string name6 = "LogoutTime";
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.get_LogoutTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.set_LogoutTime);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheC, true);
		string name7 = "TopHeroBattlePower";
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.get_TopHeroBattlePower);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.set_TopHeroBattlePower);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheE, true);
		if (Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UserSummary.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_UserSummary.<>f__mg$cacheF, typeof(UserSummary));
	}

	// Token: 0x0400F159 RID: 61785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F15A RID: 61786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F15B RID: 61787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F15C RID: 61788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F15D RID: 61789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F15E RID: 61790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F15F RID: 61791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F160 RID: 61792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F161 RID: 61793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F162 RID: 61794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F163 RID: 61795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F164 RID: 61796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F165 RID: 61797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F166 RID: 61798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F167 RID: 61799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F168 RID: 61800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
