using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011B7 RID: 4535
[Preserve]
public class Lua_BlackJack_ProjectL_Common_Announcement : LuaObject
{
	// Token: 0x060177D5 RID: 96213 RVA: 0x0066B528 File Offset: 0x00669728
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Announcement o = new Announcement();
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

	// Token: 0x060177D6 RID: 96214 RVA: 0x0066B570 File Offset: 0x00669770
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBAnnouncementToAnnouncement_s(IntPtr l)
	{
		int result;
		try
		{
			ProAnnouncement pbAnnouncement;
			LuaObject.checkType<ProAnnouncement>(l, 1, out pbAnnouncement);
			Announcement o = Announcement.PBAnnouncementToAnnouncement(pbAnnouncement);
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

	// Token: 0x060177D7 RID: 96215 RVA: 0x0066B5C4 File Offset: 0x006697C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AnnouncementToPBAnnouncement_s(IntPtr l)
	{
		int result;
		try
		{
			Announcement announcement;
			LuaObject.checkType<Announcement>(l, 1, out announcement);
			ProAnnouncement o = Announcement.AnnouncementToPBAnnouncement(announcement);
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

	// Token: 0x060177D8 RID: 96216 RVA: 0x0066B618 File Offset: 0x00669818
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			Announcement announcement = (Announcement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, announcement.InstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177D9 RID: 96217 RVA: 0x0066B66C File Offset: 0x0066986C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			Announcement announcement = (Announcement)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			announcement.InstanceId = instanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177DA RID: 96218 RVA: 0x0066B6C4 File Offset: 0x006698C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ShowStartTime(IntPtr l)
	{
		int result;
		try
		{
			Announcement announcement = (Announcement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, announcement.ShowStartTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177DB RID: 96219 RVA: 0x0066B71C File Offset: 0x0066991C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ShowStartTime(IntPtr l)
	{
		int result;
		try
		{
			Announcement announcement = (Announcement)LuaObject.checkSelf(l);
			DateTime showStartTime;
			LuaObject.checkValueType<DateTime>(l, 2, out showStartTime);
			announcement.ShowStartTime = showStartTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177DC RID: 96220 RVA: 0x0066B774 File Offset: 0x00669974
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ShowEndTime(IntPtr l)
	{
		int result;
		try
		{
			Announcement announcement = (Announcement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, announcement.ShowEndTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177DD RID: 96221 RVA: 0x0066B7CC File Offset: 0x006699CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ShowEndTime(IntPtr l)
	{
		int result;
		try
		{
			Announcement announcement = (Announcement)LuaObject.checkSelf(l);
			DateTime showEndTime;
			LuaObject.checkValueType<DateTime>(l, 2, out showEndTime);
			announcement.ShowEndTime = showEndTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177DE RID: 96222 RVA: 0x0066B824 File Offset: 0x00669A24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Title(IntPtr l)
	{
		int result;
		try
		{
			Announcement announcement = (Announcement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, announcement.Title);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177DF RID: 96223 RVA: 0x0066B878 File Offset: 0x00669A78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Title(IntPtr l)
	{
		int result;
		try
		{
			Announcement announcement = (Announcement)LuaObject.checkSelf(l);
			string title;
			LuaObject.checkType(l, 2, out title);
			announcement.Title = title;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177E0 RID: 96224 RVA: 0x0066B8D0 File Offset: 0x00669AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Content(IntPtr l)
	{
		int result;
		try
		{
			Announcement announcement = (Announcement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, announcement.Content);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177E1 RID: 96225 RVA: 0x0066B924 File Offset: 0x00669B24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Content(IntPtr l)
	{
		int result;
		try
		{
			Announcement announcement = (Announcement)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			announcement.Content = content;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177E2 RID: 96226 RVA: 0x0066B97C File Offset: 0x00669B7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.Announcement");
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.PBAnnouncementToAnnouncement_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.AnnouncementToPBAnnouncement_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache1);
		string name = "InstanceId";
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.get_InstanceId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.set_InstanceId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache3, true);
		string name2 = "ShowStartTime";
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.get_ShowStartTime);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.set_ShowStartTime);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache5, true);
		string name3 = "ShowEndTime";
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.get_ShowEndTime);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.set_ShowEndTime);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache7, true);
		string name4 = "Title";
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.get_Title);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.set_Title);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cache9, true);
		string name5 = "Content";
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.get_Content);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.set_Content);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Announcement.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_Announcement.<>f__mg$cacheC, typeof(Announcement));
	}

	// Token: 0x0400DE49 RID: 56905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DE4A RID: 56906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DE4B RID: 56907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DE4C RID: 56908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DE4D RID: 56909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DE4E RID: 56910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DE4F RID: 56911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DE50 RID: 56912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DE51 RID: 56913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DE52 RID: 56914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DE53 RID: 56915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DE54 RID: 56916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DE55 RID: 56917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
