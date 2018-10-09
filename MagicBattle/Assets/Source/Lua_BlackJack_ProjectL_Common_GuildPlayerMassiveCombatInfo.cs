using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001233 RID: 4659
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo : LuaObject
{
	// Token: 0x06018283 RID: 98947 RVA: 0x006B88B0 File Offset: 0x006B6AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildPlayerMassiveCombatInfo o = new GuildPlayerMassiveCombatInfo();
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

	// Token: 0x06018284 RID: 98948 RVA: 0x006B88F8 File Offset: 0x006B6AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPro(IntPtr l)
	{
		int result;
		try
		{
			GuildPlayerMassiveCombatInfo info = (GuildPlayerMassiveCombatInfo)LuaObject.checkSelf(l);
			ProGuildPlayerMassiveCombatInfo o = info.ToPro();
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

	// Token: 0x06018285 RID: 98949 RVA: 0x006B894C File Offset: 0x006B6B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UsedHeroIds(IntPtr l)
	{
		int result;
		try
		{
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = (GuildPlayerMassiveCombatInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildPlayerMassiveCombatInfo.UsedHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018286 RID: 98950 RVA: 0x006B89A0 File Offset: 0x006B6BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UsedHeroIds(IntPtr l)
	{
		int result;
		try
		{
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = (GuildPlayerMassiveCombatInfo)LuaObject.checkSelf(l);
			List<int> usedHeroIds;
			LuaObject.checkType<List<int>>(l, 2, out usedHeroIds);
			guildPlayerMassiveCombatInfo.UsedHeroIds = usedHeroIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018287 RID: 98951 RVA: 0x006B89F8 File Offset: 0x006B6BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BindedGuildId(IntPtr l)
	{
		int result;
		try
		{
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = (GuildPlayerMassiveCombatInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildPlayerMassiveCombatInfo.BindedGuildId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018288 RID: 98952 RVA: 0x006B8A4C File Offset: 0x006B6C4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BindedGuildId(IntPtr l)
	{
		int result;
		try
		{
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = (GuildPlayerMassiveCombatInfo)LuaObject.checkSelf(l);
			string bindedGuildId;
			LuaObject.checkType(l, 2, out bindedGuildId);
			guildPlayerMassiveCombatInfo.BindedGuildId = bindedGuildId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018289 RID: 98953 RVA: 0x006B8AA4 File Offset: 0x006B6CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Points(IntPtr l)
	{
		int result;
		try
		{
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = (GuildPlayerMassiveCombatInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildPlayerMassiveCombatInfo.Points);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601828A RID: 98954 RVA: 0x006B8AF8 File Offset: 0x006B6CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Points(IntPtr l)
	{
		int result;
		try
		{
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = (GuildPlayerMassiveCombatInfo)LuaObject.checkSelf(l);
			int points;
			LuaObject.checkType(l, 2, out points);
			guildPlayerMassiveCombatInfo.Points = points;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601828B RID: 98955 RVA: 0x006B8B50 File Offset: 0x006B6D50
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GuildPlayerMassiveCombatInfo");
		if (Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.ToPro);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache0);
		string name = "UsedHeroIds";
		if (Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.get_UsedHeroIds);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.set_UsedHeroIds);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache2, true);
		string name2 = "BindedGuildId";
		if (Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.get_BindedGuildId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.set_BindedGuildId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache4, true);
		string name3 = "Points";
		if (Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.get_Points);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.set_Points);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.<>f__mg$cache7, typeof(GuildPlayerMassiveCombatInfo));
	}

	// Token: 0x0400E7FF RID: 59391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E800 RID: 59392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E801 RID: 59393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E802 RID: 59394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E803 RID: 59395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E804 RID: 59396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E805 RID: 59397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E806 RID: 59398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
