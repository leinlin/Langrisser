using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200127A RID: 4730
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RoleInfo : LuaObject
{
	// Token: 0x06018A64 RID: 100964 RVA: 0x006F4678 File Offset: 0x006F2878
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo o = new RoleInfo();
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

	// Token: 0x06018A65 RID: 100965 RVA: 0x006F46C0 File Offset: 0x006F28C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo roleInfo = (RoleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, roleInfo.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A66 RID: 100966 RVA: 0x006F4714 File Offset: 0x006F2914
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo roleInfo = (RoleInfo)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			roleInfo.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A67 RID: 100967 RVA: 0x006F476C File Offset: 0x006F296C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ServerId(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo roleInfo = (RoleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, roleInfo.ServerId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A68 RID: 100968 RVA: 0x006F47C0 File Offset: 0x006F29C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ServerId(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo roleInfo = (RoleInfo)LuaObject.checkSelf(l);
			int serverId;
			LuaObject.checkType(l, 2, out serverId);
			roleInfo.ServerId = serverId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A69 RID: 100969 RVA: 0x006F4818 File Offset: 0x006F2A18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo roleInfo = (RoleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, roleInfo.PlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A6A RID: 100970 RVA: 0x006F486C File Offset: 0x006F2A6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo roleInfo = (RoleInfo)LuaObject.checkSelf(l);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			roleInfo.PlayerLevel = playerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A6B RID: 100971 RVA: 0x006F48C4 File Offset: 0x006F2AC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo roleInfo = (RoleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, roleInfo.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A6C RID: 100972 RVA: 0x006F4918 File Offset: 0x006F2B18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo roleInfo = (RoleInfo)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			roleInfo.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A6D RID: 100973 RVA: 0x006F4970 File Offset: 0x006F2B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo roleInfo = (RoleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, roleInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A6E RID: 100974 RVA: 0x006F49C4 File Offset: 0x006F2BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo roleInfo = (RoleInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			roleInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A6F RID: 100975 RVA: 0x006F4A1C File Offset: 0x006F2C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastLoginHours(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo roleInfo = (RoleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, roleInfo.LastLoginHours);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A70 RID: 100976 RVA: 0x006F4A70 File Offset: 0x006F2C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LastLoginHours(IntPtr l)
	{
		int result;
		try
		{
			RoleInfo roleInfo = (RoleInfo)LuaObject.checkSelf(l);
			int lastLoginHours;
			LuaObject.checkType(l, 2, out lastLoginHours);
			roleInfo.LastLoginHours = lastLoginHours;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A71 RID: 100977 RVA: 0x006F4AC8 File Offset: 0x006F2CC8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RoleInfo");
		string name = "UserId";
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.get_UserId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.set_UserId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache1, true);
		string name2 = "ServerId";
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.get_ServerId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.set_ServerId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache3, true);
		string name3 = "PlayerLevel";
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.get_PlayerLevel);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.set_PlayerLevel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache5, true);
		string name4 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.get_HeadIcon);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.set_HeadIcon);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache7, true);
		string name5 = "Name";
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cache9, true);
		string name6 = "LastLoginHours";
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.get_LastLoginHours);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.set_LastLoginHours);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RoleInfo.<>f__mg$cacheC, typeof(RoleInfo));
	}

	// Token: 0x0400EF52 RID: 61266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EF53 RID: 61267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EF54 RID: 61268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EF55 RID: 61269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EF56 RID: 61270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EF57 RID: 61271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EF58 RID: 61272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EF59 RID: 61273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EF5A RID: 61274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EF5B RID: 61275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EF5C RID: 61276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EF5D RID: 61277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EF5E RID: 61278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
