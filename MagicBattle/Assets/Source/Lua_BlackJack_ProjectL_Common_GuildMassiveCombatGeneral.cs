using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200122D RID: 4653
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral : LuaObject
{
	// Token: 0x06018224 RID: 98852 RVA: 0x006B60A0 File Offset: 0x006B42A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatGeneral o = new GuildMassiveCombatGeneral();
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

	// Token: 0x06018225 RID: 98853 RVA: 0x006B60E8 File Offset: 0x006B42E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPro(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatGeneral general = (GuildMassiveCombatGeneral)LuaObject.checkSelf(l);
			ProGuildMassiveCombatGeneralInfo o = general.ToPro();
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

	// Token: 0x06018226 RID: 98854 RVA: 0x006B613C File Offset: 0x006B433C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FinishedCombats(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatGeneral guildMassiveCombatGeneral = (GuildMassiveCombatGeneral)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatGeneral.FinishedCombats);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018227 RID: 98855 RVA: 0x006B6190 File Offset: 0x006B4390
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FinishedCombats(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatGeneral guildMassiveCombatGeneral = (GuildMassiveCombatGeneral)LuaObject.checkSelf(l);
			List<GuildMassiveCombatInfo> finishedCombats;
			LuaObject.checkType<List<GuildMassiveCombatInfo>>(l, 2, out finishedCombats);
			guildMassiveCombatGeneral.FinishedCombats = finishedCombats;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018228 RID: 98856 RVA: 0x006B61E8 File Offset: 0x006B43E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RecentCombat(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatGeneral guildMassiveCombatGeneral = (GuildMassiveCombatGeneral)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMassiveCombatGeneral.RecentCombat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018229 RID: 98857 RVA: 0x006B623C File Offset: 0x006B443C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RecentCombat(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatGeneral guildMassiveCombatGeneral = (GuildMassiveCombatGeneral)LuaObject.checkSelf(l);
			GuildMassiveCombatInfo recentCombat;
			LuaObject.checkType<GuildMassiveCombatInfo>(l, 2, out recentCombat);
			guildMassiveCombatGeneral.RecentCombat = recentCombat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601822A RID: 98858 RVA: 0x006B6294 File Offset: 0x006B4494
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GuildMassiveCombatGeneral");
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.ToPro);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache0);
		string name = "FinishedCombats";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.get_FinishedCombats);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.set_FinishedCombats);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache2, true);
		string name2 = "RecentCombat";
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.get_RecentCombat);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.set_RecentCombat);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache4, true);
		if (Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.<>f__mg$cache5, typeof(GuildMassiveCombatGeneral));
	}

	// Token: 0x0400E7AC RID: 59308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E7AD RID: 59309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E7AE RID: 59310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E7AF RID: 59311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E7B0 RID: 59312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E7B1 RID: 59313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
