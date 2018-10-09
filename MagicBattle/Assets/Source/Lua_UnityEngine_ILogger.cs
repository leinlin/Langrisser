using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016EB RID: 5867
[Preserve]
public class Lua_UnityEngine_ILogger : LuaObject
{
	// Token: 0x0602337E RID: 144254 RVA: 0x00C388B8 File Offset: 0x00C36AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLogTypeAllowed(IntPtr l)
	{
		int result;
		try
		{
			ILogger logger = (ILogger)LuaObject.checkSelf(l);
			LogType logType;
			LuaObject.checkEnum<LogType>(l, 2, out logType);
			bool b = logger.IsLogTypeAllowed(logType);
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

	// Token: 0x0602337F RID: 144255 RVA: 0x00C3891C File Offset: 0x00C36B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Log(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				ILogger logger = (ILogger)LuaObject.checkSelf(l);
				object message;
				LuaObject.checkType<object>(l, 2, out message);
				logger.Log(message);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(object)))
			{
				ILogger logger2 = (ILogger)LuaObject.checkSelf(l);
				string tag;
				LuaObject.checkType(l, 2, out tag);
				object message2;
				LuaObject.checkType<object>(l, 3, out message2);
				logger2.Log(tag, message2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(LogType), typeof(object)))
			{
				ILogger logger3 = (ILogger)LuaObject.checkSelf(l);
				LogType logType;
				LuaObject.checkEnum<LogType>(l, 2, out logType);
				object message3;
				LuaObject.checkType<object>(l, 3, out message3);
				logger3.Log(logType, message3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(object), typeof(UnityEngine.Object)))
			{
				ILogger logger4 = (ILogger)LuaObject.checkSelf(l);
				string tag2;
				LuaObject.checkType(l, 2, out tag2);
				object message4;
				LuaObject.checkType<object>(l, 3, out message4);
				UnityEngine.Object context;
				LuaObject.checkType<UnityEngine.Object>(l, 4, out context);
				logger4.Log(tag2, message4, context);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(LogType), typeof(object), typeof(UnityEngine.Object)))
			{
				ILogger logger5 = (ILogger)LuaObject.checkSelf(l);
				LogType logType2;
				LuaObject.checkEnum<LogType>(l, 2, out logType2);
				object message5;
				LuaObject.checkType<object>(l, 3, out message5);
				UnityEngine.Object context2;
				LuaObject.checkType<UnityEngine.Object>(l, 4, out context2);
				logger5.Log(logType2, message5, context2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(LogType), typeof(string), typeof(object)))
			{
				ILogger logger6 = (ILogger)LuaObject.checkSelf(l);
				LogType logType3;
				LuaObject.checkEnum<LogType>(l, 2, out logType3);
				string tag3;
				LuaObject.checkType(l, 3, out tag3);
				object message6;
				LuaObject.checkType<object>(l, 4, out message6);
				logger6.Log(logType3, tag3, message6);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				ILogger logger7 = (ILogger)LuaObject.checkSelf(l);
				LogType logType4;
				LuaObject.checkEnum<LogType>(l, 2, out logType4);
				string tag4;
				LuaObject.checkType(l, 3, out tag4);
				object message7;
				LuaObject.checkType<object>(l, 4, out message7);
				UnityEngine.Object context3;
				LuaObject.checkType<UnityEngine.Object>(l, 5, out context3);
				logger7.Log(logType4, tag4, message7, context3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Log to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023380 RID: 144256 RVA: 0x00C38C0C File Offset: 0x00C36E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogWarning(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				ILogger logger = (ILogger)LuaObject.checkSelf(l);
				string tag;
				LuaObject.checkType(l, 2, out tag);
				object message;
				LuaObject.checkType<object>(l, 3, out message);
				logger.LogWarning(tag, message);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				ILogger logger2 = (ILogger)LuaObject.checkSelf(l);
				string tag2;
				LuaObject.checkType(l, 2, out tag2);
				object message2;
				LuaObject.checkType<object>(l, 3, out message2);
				UnityEngine.Object context;
				LuaObject.checkType<UnityEngine.Object>(l, 4, out context);
				logger2.LogWarning(tag2, message2, context);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LogWarning to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023381 RID: 144257 RVA: 0x00C38CEC File Offset: 0x00C36EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogError(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				ILogger logger = (ILogger)LuaObject.checkSelf(l);
				string tag;
				LuaObject.checkType(l, 2, out tag);
				object message;
				LuaObject.checkType<object>(l, 3, out message);
				logger.LogError(tag, message);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				ILogger logger2 = (ILogger)LuaObject.checkSelf(l);
				string tag2;
				LuaObject.checkType(l, 2, out tag2);
				object message2;
				LuaObject.checkType<object>(l, 3, out message2);
				UnityEngine.Object context;
				LuaObject.checkType<UnityEngine.Object>(l, 4, out context);
				logger2.LogError(tag2, message2, context);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LogError to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023382 RID: 144258 RVA: 0x00C38DCC File Offset: 0x00C36FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogFormat(IntPtr l)
	{
		int result;
		try
		{
			ILogger logger = (ILogger)LuaObject.checkSelf(l);
			LogType logType;
			LuaObject.checkEnum<LogType>(l, 2, out logType);
			string format;
			LuaObject.checkType(l, 3, out format);
			object[] args;
			LuaObject.checkParams<object>(l, 4, out args);
			logger.LogFormat(logType, format, args);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023383 RID: 144259 RVA: 0x00C38E40 File Offset: 0x00C37040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogException(IntPtr l)
	{
		int result;
		try
		{
			ILogger logger = (ILogger)LuaObject.checkSelf(l);
			Exception exception;
			LuaObject.checkType<Exception>(l, 2, out exception);
			logger.LogException(exception);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023384 RID: 144260 RVA: 0x00C38E98 File Offset: 0x00C37098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_logHandler(IntPtr l)
	{
		int result;
		try
		{
			ILogger logger = (ILogger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logger.logHandler);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023385 RID: 144261 RVA: 0x00C38EEC File Offset: 0x00C370EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_logHandler(IntPtr l)
	{
		int result;
		try
		{
			ILogger logger = (ILogger)LuaObject.checkSelf(l);
			ILogHandler logHandler;
			LuaObject.checkType<ILogHandler>(l, 2, out logHandler);
			logger.logHandler = logHandler;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023386 RID: 144262 RVA: 0x00C38F44 File Offset: 0x00C37144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_logEnabled(IntPtr l)
	{
		int result;
		try
		{
			ILogger logger = (ILogger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logger.logEnabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023387 RID: 144263 RVA: 0x00C38F98 File Offset: 0x00C37198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_logEnabled(IntPtr l)
	{
		int result;
		try
		{
			ILogger logger = (ILogger)LuaObject.checkSelf(l);
			bool logEnabled;
			LuaObject.checkType(l, 2, out logEnabled);
			logger.logEnabled = logEnabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023388 RID: 144264 RVA: 0x00C38FF0 File Offset: 0x00C371F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_filterLogType(IntPtr l)
	{
		int result;
		try
		{
			ILogger logger = (ILogger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)logger.filterLogType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023389 RID: 144265 RVA: 0x00C39044 File Offset: 0x00C37244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_filterLogType(IntPtr l)
	{
		int result;
		try
		{
			ILogger logger = (ILogger)LuaObject.checkSelf(l);
			LogType filterLogType;
			LuaObject.checkEnum<LogType>(l, 2, out filterLogType);
			logger.filterLogType = filterLogType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602338A RID: 144266 RVA: 0x00C3909C File Offset: 0x00C3729C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ILogger");
		if (Lua_UnityEngine_ILogger.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ILogger.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ILogger.IsLogTypeAllowed);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ILogger.<>f__mg$cache0);
		if (Lua_UnityEngine_ILogger.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ILogger.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ILogger.Log);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ILogger.<>f__mg$cache1);
		if (Lua_UnityEngine_ILogger.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ILogger.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ILogger.LogWarning);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ILogger.<>f__mg$cache2);
		if (Lua_UnityEngine_ILogger.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ILogger.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ILogger.LogError);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ILogger.<>f__mg$cache3);
		if (Lua_UnityEngine_ILogger.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_ILogger.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_ILogger.LogFormat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ILogger.<>f__mg$cache4);
		if (Lua_UnityEngine_ILogger.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_ILogger.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_ILogger.LogException);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ILogger.<>f__mg$cache5);
		string name = "logHandler";
		if (Lua_UnityEngine_ILogger.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_ILogger.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_ILogger.get_logHandler);
		}
		LuaCSFunction get = Lua_UnityEngine_ILogger.<>f__mg$cache6;
		if (Lua_UnityEngine_ILogger.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_ILogger.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_ILogger.set_logHandler);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_ILogger.<>f__mg$cache7, true);
		string name2 = "logEnabled";
		if (Lua_UnityEngine_ILogger.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_ILogger.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_ILogger.get_logEnabled);
		}
		LuaCSFunction get2 = Lua_UnityEngine_ILogger.<>f__mg$cache8;
		if (Lua_UnityEngine_ILogger.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_ILogger.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_ILogger.set_logEnabled);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_ILogger.<>f__mg$cache9, true);
		string name3 = "filterLogType";
		if (Lua_UnityEngine_ILogger.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_ILogger.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_ILogger.get_filterLogType);
		}
		LuaCSFunction get3 = Lua_UnityEngine_ILogger.<>f__mg$cacheA;
		if (Lua_UnityEngine_ILogger.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_ILogger.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_ILogger.set_filterLogType);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_ILogger.<>f__mg$cacheB, true);
		LuaObject.createTypeMetatable(l, null, typeof(ILogger));
	}

	// Token: 0x04019206 RID: 102918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019207 RID: 102919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019208 RID: 102920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019209 RID: 102921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401920A RID: 102922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401920B RID: 102923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401920C RID: 102924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401920D RID: 102925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401920E RID: 102926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401920F RID: 102927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019210 RID: 102928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019211 RID: 102929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
