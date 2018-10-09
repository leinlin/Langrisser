using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011F3 RID: 4595
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement : LuaObject
{
	// Token: 0x06017D3B RID: 97595 RVA: 0x00692A4C File Offset: 0x00690C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement o = new DataSectionAnnouncement();
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

	// Token: 0x06017D3C RID: 97596 RVA: 0x00692A94 File Offset: 0x00690C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement dataSectionAnnouncement = (DataSectionAnnouncement)LuaObject.checkSelf(l);
			dataSectionAnnouncement.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D3D RID: 97597 RVA: 0x00692AE0 File Offset: 0x00690CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement dataSectionAnnouncement = (DataSectionAnnouncement)LuaObject.checkSelf(l);
			object o = dataSectionAnnouncement.SerializeToClient();
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

	// Token: 0x06017D3E RID: 97598 RVA: 0x00692B34 File Offset: 0x00690D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAnnouncements(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement dataSectionAnnouncement = (DataSectionAnnouncement)LuaObject.checkSelf(l);
			List<Announcement> announcements;
			LuaObject.checkType<List<Announcement>>(l, 2, out announcements);
			dataSectionAnnouncement.InitAnnouncements(announcements);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D3F RID: 97599 RVA: 0x00692B8C File Offset: 0x00690D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAnnouncements(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement dataSectionAnnouncement = (DataSectionAnnouncement)LuaObject.checkSelf(l);
			List<Announcement> announcements;
			LuaObject.checkType<List<Announcement>>(l, 2, out announcements);
			dataSectionAnnouncement.SetAnnouncements(announcements);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D40 RID: 97600 RVA: 0x00692BE4 File Offset: 0x00690DE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetClientAnnouncementCurrentVersion(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement dataSectionAnnouncement = (DataSectionAnnouncement)LuaObject.checkSelf(l);
			uint clientAnnouncementCurrentVersion;
			LuaObject.checkType(l, 2, out clientAnnouncementCurrentVersion);
			dataSectionAnnouncement.SetClientAnnouncementCurrentVersion(clientAnnouncementCurrentVersion);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D41 RID: 97601 RVA: 0x00692C3C File Offset: 0x00690E3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetServerAnnouncementCurrentVersion(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement dataSectionAnnouncement = (DataSectionAnnouncement)LuaObject.checkSelf(l);
			int serverAnnouncementCurrentVersion;
			LuaObject.checkType(l, 2, out serverAnnouncementCurrentVersion);
			dataSectionAnnouncement.SetServerAnnouncementCurrentVersion(serverAnnouncementCurrentVersion);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D42 RID: 97602 RVA: 0x00692C94 File Offset: 0x00690E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement dataSectionAnnouncement = (DataSectionAnnouncement)LuaObject.checkSelf(l);
			Announcement announcement;
			LuaObject.checkType<Announcement>(l, 2, out announcement);
			dataSectionAnnouncement.RemoveAnnouncement(announcement);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D43 RID: 97603 RVA: 0x00692CEC File Offset: 0x00690EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindAnnouncementsByCondition(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement dataSectionAnnouncement = (DataSectionAnnouncement)LuaObject.checkSelf(l);
			Predicate<Announcement> isConditionMatched;
			LuaObject.checkDelegate<Predicate<Announcement>>(l, 2, out isConditionMatched);
			List<Announcement> o = dataSectionAnnouncement.FindAnnouncementsByCondition(isConditionMatched);
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

	// Token: 0x06017D44 RID: 97604 RVA: 0x00692D50 File Offset: 0x00690F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindAnnouncementsByInstanceId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement dataSectionAnnouncement = (DataSectionAnnouncement)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			Announcement o = dataSectionAnnouncement.FindAnnouncementsByInstanceId(instanceId);
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

	// Token: 0x06017D45 RID: 97605 RVA: 0x00692DB4 File Offset: 0x00690FB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement dataSectionAnnouncement = (DataSectionAnnouncement)LuaObject.checkSelf(l);
			Announcement announcement;
			LuaObject.checkType<Announcement>(l, 2, out announcement);
			dataSectionAnnouncement.AddAnnouncement(announcement);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D46 RID: 97606 RVA: 0x00692E0C File Offset: 0x0069100C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ClientCurrentVersion(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement dataSectionAnnouncement = (DataSectionAnnouncement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionAnnouncement.ClientCurrentVersion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D47 RID: 97607 RVA: 0x00692E60 File Offset: 0x00691060
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ClientCurrentVersion(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnnouncement dataSectionAnnouncement = (DataSectionAnnouncement)LuaObject.checkSelf(l);
			uint clientCurrentVersion;
			LuaObject.checkType(l, 2, out clientCurrentVersion);
			dataSectionAnnouncement.ClientCurrentVersion = clientCurrentVersion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D48 RID: 97608 RVA: 0x00692EB8 File Offset: 0x006910B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionAnnouncement");
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.InitAnnouncements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.SetAnnouncements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.SetClientAnnouncementCurrentVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.SetServerAnnouncementCurrentVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.RemoveAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.FindAnnouncementsByCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.FindAnnouncementsByInstanceId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.AddAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cache9);
		string name = "ClientCurrentVersion";
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.get_ClientCurrentVersion);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.set_ClientCurrentVersion);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.<>f__mg$cacheC, typeof(DataSectionAnnouncement), typeof(DataSection));
	}

	// Token: 0x0400E337 RID: 58167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E338 RID: 58168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E339 RID: 58169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E33A RID: 58170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E33B RID: 58171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E33C RID: 58172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E33D RID: 58173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E33E RID: 58174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E33F RID: 58175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E340 RID: 58176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E341 RID: 58177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E342 RID: 58178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E343 RID: 58179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
