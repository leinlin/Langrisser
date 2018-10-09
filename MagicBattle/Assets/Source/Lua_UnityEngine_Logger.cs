using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001720 RID: 5920
[Preserve]
public class Lua_UnityEngine_Logger : LuaObject
{
	// Token: 0x06023552 RID: 144722 RVA: 0x00C45C44 File Offset: 0x00C43E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ILogHandler logHandler;
			LuaObject.checkType<ILogHandler>(l, 2, out logHandler);
			UnityEngine.Logger o = new UnityEngine.Logger(logHandler);
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

	// Token: 0x06023553 RID: 144723 RVA: 0x00C45C98 File Offset: 0x00C43E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLogTypeAllowed(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Logger logger = (UnityEngine.Logger)LuaObject.checkSelf(l);
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

	// Token: 0x06023554 RID: 144724 RVA: 0x00C45CFC File Offset: 0x00C43EFC
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
				UnityEngine.Logger logger = (UnityEngine.Logger)LuaObject.checkSelf(l);
				object message;
				LuaObject.checkType<object>(l, 2, out message);
				logger.Log(message);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(object)))
			{
				UnityEngine.Logger logger2 = (UnityEngine.Logger)LuaObject.checkSelf(l);
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
				UnityEngine.Logger logger3 = (UnityEngine.Logger)LuaObject.checkSelf(l);
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
				UnityEngine.Logger logger4 = (UnityEngine.Logger)LuaObject.checkSelf(l);
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
				UnityEngine.Logger logger5 = (UnityEngine.Logger)LuaObject.checkSelf(l);
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
				UnityEngine.Logger logger6 = (UnityEngine.Logger)LuaObject.checkSelf(l);
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
				UnityEngine.Logger logger7 = (UnityEngine.Logger)LuaObject.checkSelf(l);
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

	// Token: 0x06023555 RID: 144725 RVA: 0x00C45FEC File Offset: 0x00C441EC
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
				UnityEngine.Logger logger = (UnityEngine.Logger)LuaObject.checkSelf(l);
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
				UnityEngine.Logger logger2 = (UnityEngine.Logger)LuaObject.checkSelf(l);
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

	// Token: 0x06023556 RID: 144726 RVA: 0x00C460CC File Offset: 0x00C442CC
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
				UnityEngine.Logger logger = (UnityEngine.Logger)LuaObject.checkSelf(l);
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
				UnityEngine.Logger logger2 = (UnityEngine.Logger)LuaObject.checkSelf(l);
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

	// Token: 0x06023557 RID: 144727 RVA: 0x00C461AC File Offset: 0x00C443AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogFormat(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				UnityEngine.Logger logger = (UnityEngine.Logger)LuaObject.checkSelf(l);
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
			else if (num == 5)
			{
				UnityEngine.Logger logger2 = (UnityEngine.Logger)LuaObject.checkSelf(l);
				LogType logType2;
				LuaObject.checkEnum<LogType>(l, 2, out logType2);
				UnityEngine.Object context;
				LuaObject.checkType<UnityEngine.Object>(l, 3, out context);
				string format2;
				LuaObject.checkType(l, 4, out format2);
				object[] args2;
				LuaObject.checkParams<object>(l, 5, out args2);
				logger2.LogFormat(logType2, context, format2, args2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LogFormat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023558 RID: 144728 RVA: 0x00C462A4 File Offset: 0x00C444A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogException(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				UnityEngine.Logger logger = (UnityEngine.Logger)LuaObject.checkSelf(l);
				Exception exception;
				LuaObject.checkType<Exception>(l, 2, out exception);
				logger.LogException(exception);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				UnityEngine.Logger logger2 = (UnityEngine.Logger)LuaObject.checkSelf(l);
				Exception exception2;
				LuaObject.checkType<Exception>(l, 2, out exception2);
				UnityEngine.Object context;
				LuaObject.checkType<UnityEngine.Object>(l, 3, out context);
				logger2.LogException(exception2, context);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LogException to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023559 RID: 144729 RVA: 0x00C46368 File Offset: 0x00C44568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_logHandler(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Logger logger = (UnityEngine.Logger)LuaObject.checkSelf(l);
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

	// Token: 0x0602355A RID: 144730 RVA: 0x00C463BC File Offset: 0x00C445BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_logHandler(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Logger logger = (UnityEngine.Logger)LuaObject.checkSelf(l);
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

	// Token: 0x0602355B RID: 144731 RVA: 0x00C46414 File Offset: 0x00C44614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_logEnabled(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Logger logger = (UnityEngine.Logger)LuaObject.checkSelf(l);
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

	// Token: 0x0602355C RID: 144732 RVA: 0x00C46468 File Offset: 0x00C44668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_logEnabled(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Logger logger = (UnityEngine.Logger)LuaObject.checkSelf(l);
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

	// Token: 0x0602355D RID: 144733 RVA: 0x00C464C0 File Offset: 0x00C446C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_filterLogType(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Logger logger = (UnityEngine.Logger)LuaObject.checkSelf(l);
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

	// Token: 0x0602355E RID: 144734 RVA: 0x00C46514 File Offset: 0x00C44714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_filterLogType(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Logger logger = (UnityEngine.Logger)LuaObject.checkSelf(l);
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

	// Token: 0x0602355F RID: 144735 RVA: 0x00C4656C File Offset: 0x00C4476C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Logger");
		if (Lua_UnityEngine_Logger.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Logger.IsLogTypeAllowed);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Logger.<>f__mg$cache0);
		if (Lua_UnityEngine_Logger.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Logger.Log);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Logger.<>f__mg$cache1);
		if (Lua_UnityEngine_Logger.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Logger.LogWarning);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Logger.<>f__mg$cache2);
		if (Lua_UnityEngine_Logger.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Logger.LogError);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Logger.<>f__mg$cache3);
		if (Lua_UnityEngine_Logger.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Logger.LogFormat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Logger.<>f__mg$cache4);
		if (Lua_UnityEngine_Logger.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Logger.LogException);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Logger.<>f__mg$cache5);
		string name = "logHandler";
		if (Lua_UnityEngine_Logger.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Logger.get_logHandler);
		}
		LuaCSFunction get = Lua_UnityEngine_Logger.<>f__mg$cache6;
		if (Lua_UnityEngine_Logger.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Logger.set_logHandler);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Logger.<>f__mg$cache7, true);
		string name2 = "logEnabled";
		if (Lua_UnityEngine_Logger.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Logger.get_logEnabled);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Logger.<>f__mg$cache8;
		if (Lua_UnityEngine_Logger.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Logger.set_logEnabled);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Logger.<>f__mg$cache9, true);
		string name3 = "filterLogType";
		if (Lua_UnityEngine_Logger.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Logger.get_filterLogType);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Logger.<>f__mg$cacheA;
		if (Lua_UnityEngine_Logger.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Logger.set_filterLogType);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Logger.<>f__mg$cacheB, true);
		if (Lua_UnityEngine_Logger.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Logger.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Logger.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Logger.<>f__mg$cacheC, typeof(UnityEngine.Logger));
	}

	// Token: 0x04019370 RID: 103280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019371 RID: 103281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019372 RID: 103282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019373 RID: 103283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019374 RID: 103284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019375 RID: 103285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019376 RID: 103286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019377 RID: 103287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019378 RID: 103288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019379 RID: 103289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401937A RID: 103290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401937B RID: 103291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401937C RID: 103292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
