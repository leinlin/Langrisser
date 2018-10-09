using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200167A RID: 5754
[Preserve]
public class Lua_UnityEngine_CrashReport : LuaObject
{
	// Token: 0x06022FD4 RID: 143316 RVA: 0x00C1C7B8 File Offset: 0x00C1A9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Remove(IntPtr l)
	{
		int result;
		try
		{
			CrashReport crashReport = (CrashReport)LuaObject.checkSelf(l);
			crashReport.Remove();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FD5 RID: 143317 RVA: 0x00C1C804 File Offset: 0x00C1AA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAll_s(IntPtr l)
	{
		int result;
		try
		{
			CrashReport.RemoveAll();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FD6 RID: 143318 RVA: 0x00C1C844 File Offset: 0x00C1AA44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_time(IntPtr l)
	{
		int result;
		try
		{
			CrashReport crashReport = (CrashReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, crashReport.time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FD7 RID: 143319 RVA: 0x00C1C89C File Offset: 0x00C1AA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_text(IntPtr l)
	{
		int result;
		try
		{
			CrashReport crashReport = (CrashReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, crashReport.text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FD8 RID: 143320 RVA: 0x00C1C8F0 File Offset: 0x00C1AAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_reports(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CrashReport.reports);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FD9 RID: 143321 RVA: 0x00C1C938 File Offset: 0x00C1AB38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lastReport(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CrashReport.lastReport);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FDA RID: 143322 RVA: 0x00C1C980 File Offset: 0x00C1AB80
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CrashReport");
		if (Lua_UnityEngine_CrashReport.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CrashReport.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CrashReport.Remove);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CrashReport.<>f__mg$cache0);
		if (Lua_UnityEngine_CrashReport.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CrashReport.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CrashReport.RemoveAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CrashReport.<>f__mg$cache1);
		string name = "time";
		if (Lua_UnityEngine_CrashReport.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CrashReport.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CrashReport.get_time);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_CrashReport.<>f__mg$cache2, null, true);
		string name2 = "text";
		if (Lua_UnityEngine_CrashReport.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CrashReport.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CrashReport.get_text);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_CrashReport.<>f__mg$cache3, null, true);
		string name3 = "reports";
		if (Lua_UnityEngine_CrashReport.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CrashReport.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CrashReport.get_reports);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_CrashReport.<>f__mg$cache4, null, false);
		string name4 = "lastReport";
		if (Lua_UnityEngine_CrashReport.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CrashReport.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CrashReport.get_lastReport);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_CrashReport.<>f__mg$cache5, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(CrashReport));
	}

	// Token: 0x04018F3E RID: 102206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018F3F RID: 102207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F40 RID: 102208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F41 RID: 102209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018F42 RID: 102210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018F43 RID: 102211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
