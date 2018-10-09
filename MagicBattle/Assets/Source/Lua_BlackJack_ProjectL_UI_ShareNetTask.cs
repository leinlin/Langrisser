using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001576 RID: 5494
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ShareNetTask : LuaObject
{
	// Token: 0x0602105A RID: 135258 RVA: 0x00B190A8 File Offset: 0x00B172A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int archiveId;
			LuaObject.checkType(l, 3, out archiveId);
			ShareNetTask o = new ShareNetTask(heroId, archiveId);
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

	// Token: 0x0602105B RID: 135259 RVA: 0x00B19108 File Offset: 0x00B17308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterNetworkEvent(IntPtr l)
	{
		int result;
		try
		{
			ShareNetTask shareNetTask = (ShareNetTask)LuaObject.checkSelf(l);
			shareNetTask.m_luaExportHelper.RegisterNetworkEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602105C RID: 135260 RVA: 0x00B1915C File Offset: 0x00B1735C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterNetworkEvent(IntPtr l)
	{
		int result;
		try
		{
			ShareNetTask shareNetTask = (ShareNetTask)LuaObject.checkSelf(l);
			shareNetTask.m_luaExportHelper.UnregisterNetworkEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602105D RID: 135261 RVA: 0x00B191B0 File Offset: 0x00B173B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartNetWorking(IntPtr l)
	{
		int result;
		try
		{
			ShareNetTask shareNetTask = (ShareNetTask)LuaObject.checkSelf(l);
			bool b = shareNetTask.m_luaExportHelper.StartNetWorking();
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

	// Token: 0x0602105E RID: 135262 RVA: 0x00B1920C File Offset: 0x00B1740C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShareAck(IntPtr l)
	{
		int result;
		try
		{
			ShareNetTask shareNetTask = (ShareNetTask)LuaObject.checkSelf(l);
			shareNetTask.m_luaExportHelper.OnShareAck();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602105F RID: 135263 RVA: 0x00B19260 File Offset: 0x00B17460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ShareNetTask shareNetTask = (ShareNetTask)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = shareNetTask.m_luaExportHelper.__callBase_OnStart(param);
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

	// Token: 0x06021060 RID: 135264 RVA: 0x00B192C8 File Offset: 0x00B174C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ShareNetTask shareNetTask = (ShareNetTask)LuaObject.checkSelf(l);
			shareNetTask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021061 RID: 135265 RVA: 0x00B1931C File Offset: 0x00B1751C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnTimeOut(IntPtr l)
	{
		int result;
		try
		{
			ShareNetTask shareNetTask = (ShareNetTask)LuaObject.checkSelf(l);
			shareNetTask.m_luaExportHelper.__callBase_OnTimeOut();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021062 RID: 135266 RVA: 0x00B19370 File Offset: 0x00B17570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnReLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			ShareNetTask shareNetTask = (ShareNetTask)LuaObject.checkSelf(l);
			shareNetTask.m_luaExportHelper.__callBase_OnReLoginSuccess();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021063 RID: 135267 RVA: 0x00B193C4 File Offset: 0x00B175C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			ShareNetTask shareNetTask = (ShareNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shareNetTask.m_heroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021064 RID: 135268 RVA: 0x00B19418 File Offset: 0x00B17618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			ShareNetTask shareNetTask = (ShareNetTask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			shareNetTask.m_heroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021065 RID: 135269 RVA: 0x00B19470 File Offset: 0x00B17670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_archiveId(IntPtr l)
	{
		int result;
		try
		{
			ShareNetTask shareNetTask = (ShareNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shareNetTask.m_archiveId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021066 RID: 135270 RVA: 0x00B194C4 File Offset: 0x00B176C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_archiveId(IntPtr l)
	{
		int result;
		try
		{
			ShareNetTask shareNetTask = (ShareNetTask)LuaObject.checkSelf(l);
			int archiveId;
			LuaObject.checkType(l, 2, out archiveId);
			shareNetTask.m_archiveId = archiveId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021067 RID: 135271 RVA: 0x00B1951C File Offset: 0x00B1771C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ShareNetTask");
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.RegisterNetworkEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.UnregisterNetworkEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.StartNetWorking);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.OnShareAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.__callBase_OnTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.__callBase_OnReLoginSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache7);
		string name = "m_heroId";
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.get_m_heroId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.set_m_heroId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cache9, true);
		string name2 = "m_archiveId";
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.get_m_archiveId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.set_m_archiveId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ShareNetTask.<>f__mg$cacheC, typeof(ShareNetTask), typeof(UINetTask));
	}

	// Token: 0x04016F50 RID: 94032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016F51 RID: 94033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016F52 RID: 94034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016F53 RID: 94035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016F54 RID: 94036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016F55 RID: 94037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016F56 RID: 94038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016F57 RID: 94039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016F58 RID: 94040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016F59 RID: 94041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016F5A RID: 94042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016F5B RID: 94043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016F5C RID: 94044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
