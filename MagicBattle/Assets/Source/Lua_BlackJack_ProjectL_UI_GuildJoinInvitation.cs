using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200147E RID: 5246
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildJoinInvitation : LuaObject
{
	// Token: 0x0601E4DE RID: 124126 RVA: 0x009BF038 File Offset: 0x009BD238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitation o = new GuildJoinInvitation();
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

	// Token: 0x0601E4DF RID: 124127 RVA: 0x009BF080 File Offset: 0x009BD280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromPb_s(IntPtr l)
	{
		int result;
		try
		{
			ProGuildJoinInvitation pb;
			LuaObject.checkType<ProGuildJoinInvitation>(l, 1, out pb);
			GuildJoinInvitation o = GuildJoinInvitation.FromPb(pb);
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

	// Token: 0x0601E4E0 RID: 124128 RVA: 0x009BF0D4 File Offset: 0x009BD2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildId(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitation guildJoinInvitation = (GuildJoinInvitation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildJoinInvitation.GuildId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4E1 RID: 124129 RVA: 0x009BF128 File Offset: 0x009BD328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GuildId(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitation guildJoinInvitation = (GuildJoinInvitation)LuaObject.checkSelf(l);
			string guildId;
			LuaObject.checkType(l, 2, out guildId);
			guildJoinInvitation.GuildId = guildId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4E2 RID: 124130 RVA: 0x009BF180 File Offset: 0x009BD380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildName(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitation guildJoinInvitation = (GuildJoinInvitation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildJoinInvitation.GuildName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4E3 RID: 124131 RVA: 0x009BF1D4 File Offset: 0x009BD3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GuildName(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitation guildJoinInvitation = (GuildJoinInvitation)LuaObject.checkSelf(l);
			string guildName;
			LuaObject.checkType(l, 2, out guildName);
			guildJoinInvitation.GuildName = guildName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4E4 RID: 124132 RVA: 0x009BF22C File Offset: 0x009BD42C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitation guildJoinInvitation = (GuildJoinInvitation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildJoinInvitation.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4E5 RID: 124133 RVA: 0x009BF280 File Offset: 0x009BD480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitation guildJoinInvitation = (GuildJoinInvitation)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			guildJoinInvitation.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4E6 RID: 124134 RVA: 0x009BF2D8 File Offset: 0x009BD4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitation guildJoinInvitation = (GuildJoinInvitation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildJoinInvitation.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4E7 RID: 124135 RVA: 0x009BF32C File Offset: 0x009BD52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitation guildJoinInvitation = (GuildJoinInvitation)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			guildJoinInvitation.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4E8 RID: 124136 RVA: 0x009BF384 File Offset: 0x009BD584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitation guildJoinInvitation = (GuildJoinInvitation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildJoinInvitation.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4E9 RID: 124137 RVA: 0x009BF3D8 File Offset: 0x009BD5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitation guildJoinInvitation = (GuildJoinInvitation)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			guildJoinInvitation.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4EA RID: 124138 RVA: 0x009BF430 File Offset: 0x009BD630
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildJoinInvitation");
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.FromPb_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache0);
		string name = "GuildId";
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.get_GuildId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.set_GuildId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache2, true);
		string name2 = "GuildName";
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.get_GuildName);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.set_GuildName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache4, true);
		string name3 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.get_HeadIcon);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.set_HeadIcon);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache6, true);
		string name4 = "Level";
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.get_Level);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.set_Level);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache8, true);
		string name5 = "Name";
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cacheA, true);
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.<>f__mg$cacheB, typeof(GuildJoinInvitation));
	}

	// Token: 0x040145C4 RID: 83396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040145C5 RID: 83397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040145C6 RID: 83398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040145C7 RID: 83399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040145C8 RID: 83400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040145C9 RID: 83401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040145CA RID: 83402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040145CB RID: 83403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040145CC RID: 83404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040145CD RID: 83405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040145CE RID: 83406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040145CF RID: 83407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
