using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017D6 RID: 6102
[Preserve]
public class Lua_UnityEngine_SleepTimeout : LuaObject
{
	// Token: 0x06023D33 RID: 146739 RVA: 0x00C8E1A8 File Offset: 0x00C8C3A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SleepTimeout o = new SleepTimeout();
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

	// Token: 0x06023D34 RID: 146740 RVA: 0x00C8E1F0 File Offset: 0x00C8C3F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NeverSleep(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D35 RID: 146741 RVA: 0x00C8E234 File Offset: 0x00C8C434
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SystemSetting(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D36 RID: 146742 RVA: 0x00C8E278 File Offset: 0x00C8C478
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SleepTimeout");
		string name = "NeverSleep";
		if (Lua_UnityEngine_SleepTimeout.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SleepTimeout.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SleepTimeout.get_NeverSleep);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_SleepTimeout.<>f__mg$cache0, null, false);
		string name2 = "SystemSetting";
		if (Lua_UnityEngine_SleepTimeout.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SleepTimeout.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SleepTimeout.get_SystemSetting);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_SleepTimeout.<>f__mg$cache1, null, false);
		if (Lua_UnityEngine_SleepTimeout.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SleepTimeout.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SleepTimeout.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_SleepTimeout.<>f__mg$cache2, typeof(SleepTimeout));
	}

	// Token: 0x040199E5 RID: 104933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040199E6 RID: 104934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040199E7 RID: 104935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
