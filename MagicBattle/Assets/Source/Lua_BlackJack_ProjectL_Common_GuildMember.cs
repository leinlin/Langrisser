using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001231 RID: 4657
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GuildMember : LuaObject
{
	// Token: 0x06018261 RID: 98913 RVA: 0x006B7A50 File Offset: 0x006B5C50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildMember o = new GuildMember();
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

	// Token: 0x06018262 RID: 98914 RVA: 0x006B7A98 File Offset: 0x006B5C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WeeklyFlush(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			guildMember.WeeklyFlush();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018263 RID: 98915 RVA: 0x006B7AE4 File Offset: 0x006B5CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAdmin(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			bool b = guildMember.IsAdmin();
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

	// Token: 0x06018264 RID: 98916 RVA: 0x006B7B38 File Offset: 0x006B5D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPb_s(IntPtr l)
	{
		int result;
		try
		{
			GuildMember m;
			LuaObject.checkType<GuildMember>(l, 1, out m);
			ProGuildMember o = GuildMember.ToPb(m);
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

	// Token: 0x06018265 RID: 98917 RVA: 0x006B7B8C File Offset: 0x006B5D8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FromPb_s(IntPtr l)
	{
		int result;
		try
		{
			ProGuildMember pb;
			LuaObject.checkType<ProGuildMember>(l, 1, out pb);
			GuildMember o = GuildMember.FromPb(pb);
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

	// Token: 0x06018266 RID: 98918 RVA: 0x006B7BE0 File Offset: 0x006B5DE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMember.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018267 RID: 98919 RVA: 0x006B7C34 File Offset: 0x006B5E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			guildMember.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018268 RID: 98920 RVA: 0x006B7C8C File Offset: 0x006B5E8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMember.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018269 RID: 98921 RVA: 0x006B7CE0 File Offset: 0x006B5EE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			guildMember.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601826A RID: 98922 RVA: 0x006B7D38 File Offset: 0x006B5F38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMember.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601826B RID: 98923 RVA: 0x006B7D8C File Offset: 0x006B5F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			guildMember.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601826C RID: 98924 RVA: 0x006B7DE4 File Offset: 0x006B5FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Title(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)guildMember.Title);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601826D RID: 98925 RVA: 0x006B7E38 File Offset: 0x006B6038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Title(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			GuildTitle title;
			LuaObject.checkEnum<GuildTitle>(l, 2, out title);
			guildMember.Title = title;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601826E RID: 98926 RVA: 0x006B7E90 File Offset: 0x006B6090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TotalActivities(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMember.TotalActivities);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601826F RID: 98927 RVA: 0x006B7EE4 File Offset: 0x006B60E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TotalActivities(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			int totalActivities;
			LuaObject.checkType(l, 2, out totalActivities);
			guildMember.TotalActivities = totalActivities;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018270 RID: 98928 RVA: 0x006B7F3C File Offset: 0x006B613C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ThisWeekActivities(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMember.ThisWeekActivities);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018271 RID: 98929 RVA: 0x006B7F90 File Offset: 0x006B6190
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ThisWeekActivities(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			int thisWeekActivities;
			LuaObject.checkType(l, 2, out thisWeekActivities);
			guildMember.ThisWeekActivities = thisWeekActivities;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018272 RID: 98930 RVA: 0x006B7FE8 File Offset: 0x006B61E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Online(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMember.Online);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018273 RID: 98931 RVA: 0x006B803C File Offset: 0x006B623C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Online(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			bool online;
			LuaObject.checkType(l, 2, out online);
			guildMember.Online = online;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018274 RID: 98932 RVA: 0x006B8094 File Offset: 0x006B6294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LogoutTime(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMember.LogoutTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018275 RID: 98933 RVA: 0x006B80EC File Offset: 0x006B62EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LogoutTime(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			DateTime logoutTime;
			LuaObject.checkValueType<DateTime>(l, 2, out logoutTime);
			guildMember.LogoutTime = logoutTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018276 RID: 98934 RVA: 0x006B8144 File Offset: 0x006B6344
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TopHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMember.TopHeroBattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018277 RID: 98935 RVA: 0x006B8198 File Offset: 0x006B6398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TopHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			int topHeroBattlePower;
			LuaObject.checkType(l, 2, out topHeroBattlePower);
			guildMember.TopHeroBattlePower = topHeroBattlePower;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018278 RID: 98936 RVA: 0x006B81F0 File Offset: 0x006B63F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildMember.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018279 RID: 98937 RVA: 0x006B8244 File Offset: 0x006B6444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildMember guildMember = (GuildMember)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			guildMember.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601827A RID: 98938 RVA: 0x006B829C File Offset: 0x006B649C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GuildMember");
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.WeeklyFlush);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.IsAdmin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.ToPb_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.FromPb_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache3);
		string name = "UserId";
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.get_UserId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.set_UserId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache5, true);
		string name2 = "Name";
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.get_Name);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.set_Name);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache7, true);
		string name3 = "Level";
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.get_Level);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.set_Level);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache9, true);
		string name4 = "Title";
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.get_Title);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.set_Title);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheB, true);
		string name5 = "TotalActivities";
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.get_TotalActivities);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.set_TotalActivities);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheD, true);
		string name6 = "ThisWeekActivities";
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.get_ThisWeekActivities);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.set_ThisWeekActivities);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cacheF, true);
		string name7 = "Online";
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.get_Online);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.set_Online);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache11, true);
		string name8 = "LogoutTime";
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.get_LogoutTime);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.set_LogoutTime);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache13, true);
		string name9 = "TopHeroBattlePower";
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.get_TopHeroBattlePower);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.set_TopHeroBattlePower);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache15, true);
		string name10 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.get_HeadIcon);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.set_HeadIcon);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache17, true);
		if (Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildMember.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GuildMember.<>f__mg$cache18, typeof(GuildMember));
	}

	// Token: 0x0400E7E1 RID: 59361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E7E2 RID: 59362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E7E3 RID: 59363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E7E4 RID: 59364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E7E5 RID: 59365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E7E6 RID: 59366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E7E7 RID: 59367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E7E8 RID: 59368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E7E9 RID: 59369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E7EA RID: 59370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E7EB RID: 59371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E7EC RID: 59372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E7ED RID: 59373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E7EE RID: 59374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E7EF RID: 59375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E7F0 RID: 59376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E7F1 RID: 59377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E7F2 RID: 59378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E7F3 RID: 59379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E7F4 RID: 59380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E7F5 RID: 59381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E7F6 RID: 59382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E7F7 RID: 59383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E7F8 RID: 59384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E7F9 RID: 59385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
