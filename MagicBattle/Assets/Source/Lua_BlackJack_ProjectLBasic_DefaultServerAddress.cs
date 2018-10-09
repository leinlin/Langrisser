using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015EC RID: 5612
[Preserve]
public class Lua_BlackJack_ProjectLBasic_DefaultServerAddress : LuaObject
{
	// Token: 0x060227A6 RID: 141222 RVA: 0x00BD2784 File Offset: 0x00BD0984
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DefaultServerAddress o = new DefaultServerAddress();
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

	// Token: 0x060227A7 RID: 141223 RVA: 0x00BD27CC File Offset: 0x00BD09CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Load_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = DefaultServerAddress.Load();
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

	// Token: 0x060227A8 RID: 141224 RVA: 0x00BD2814 File Offset: 0x00BD0A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ServerListURL(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DefaultServerAddress.ServerListURL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227A9 RID: 141225 RVA: 0x00BD285C File Offset: 0x00BD0A5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AnnouncementsURL(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DefaultServerAddress.AnnouncementsURL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227AA RID: 141226 RVA: 0x00BD28A4 File Offset: 0x00BD0AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_URLToSaveUpdateClientServerURL(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DefaultServerAddress.URLToSaveUpdateClientServerURL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227AB RID: 141227 RVA: 0x00BD28EC File Offset: 0x00BD0AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GMUserConfigURL(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DefaultServerAddress.GMUserConfigURL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227AC RID: 141228 RVA: 0x00BD2934 File Offset: 0x00BD0B34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ReportBugURL(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DefaultServerAddress.ReportBugURL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227AD RID: 141229 RVA: 0x00BD297C File Offset: 0x00BD0B7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectLBasic.DefaultServerAddress");
		if (Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_DefaultServerAddress.Load_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache0);
		string name = "ServerListURL";
		if (Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_DefaultServerAddress.get_ServerListURL);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache1, null, false);
		string name2 = "AnnouncementsURL";
		if (Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_DefaultServerAddress.get_AnnouncementsURL);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache2, null, false);
		string name3 = "URLToSaveUpdateClientServerURL";
		if (Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_DefaultServerAddress.get_URLToSaveUpdateClientServerURL);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache3, null, false);
		string name4 = "GMUserConfigURL";
		if (Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_DefaultServerAddress.get_GMUserConfigURL);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache4, null, false);
		string name5 = "ReportBugURL";
		if (Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_DefaultServerAddress.get_ReportBugURL);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache5, null, false);
		if (Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_DefaultServerAddress.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectLBasic_DefaultServerAddress.<>f__mg$cache6, typeof(DefaultServerAddress));
	}

	// Token: 0x040185B0 RID: 99760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185B1 RID: 99761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185B2 RID: 99762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040185B3 RID: 99763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040185B4 RID: 99764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040185B5 RID: 99765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040185B6 RID: 99766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
