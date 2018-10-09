using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016EC RID: 5868
[Preserve]
public class Lua_UnityEngine_ILogHandler : LuaObject
{
	// Token: 0x0602338C RID: 144268 RVA: 0x00C39274 File Offset: 0x00C37474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogFormat(IntPtr l)
	{
		int result;
		try
		{
			ILogHandler logHandler = (ILogHandler)LuaObject.checkSelf(l);
			LogType logType;
			LuaObject.checkEnum<LogType>(l, 2, out logType);
			UnityEngine.Object context;
			LuaObject.checkType<UnityEngine.Object>(l, 3, out context);
			string format;
			LuaObject.checkType(l, 4, out format);
			object[] args;
			LuaObject.checkParams<object>(l, 5, out args);
			logHandler.LogFormat(logType, context, format, args);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602338D RID: 144269 RVA: 0x00C392F4 File Offset: 0x00C374F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogException(IntPtr l)
	{
		int result;
		try
		{
			ILogHandler logHandler = (ILogHandler)LuaObject.checkSelf(l);
			Exception exception;
			LuaObject.checkType<Exception>(l, 2, out exception);
			UnityEngine.Object context;
			LuaObject.checkType<UnityEngine.Object>(l, 3, out context);
			logHandler.LogException(exception, context);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602338E RID: 144270 RVA: 0x00C39358 File Offset: 0x00C37558
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ILogHandler");
		if (Lua_UnityEngine_ILogHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ILogHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ILogHandler.LogFormat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ILogHandler.<>f__mg$cache0);
		if (Lua_UnityEngine_ILogHandler.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ILogHandler.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ILogHandler.LogException);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ILogHandler.<>f__mg$cache1);
		LuaObject.createTypeMetatable(l, null, typeof(ILogHandler));
	}

	// Token: 0x04019212 RID: 102930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019213 RID: 102931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
