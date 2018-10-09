using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001686 RID: 5766
[Preserve]
public class Lua_UnityEngine_Debug : LuaObject
{
	// Token: 0x06023048 RID: 143432 RVA: 0x00C1FFD4 File Offset: 0x00C1E1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Debug o = new UnityEngine.Debug();
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

	// Token: 0x06023049 RID: 143433 RVA: 0x00C2001C File Offset: 0x00C1E21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawLine_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector3 start;
				LuaObject.checkType(l, 1, out start);
				Vector3 end;
				LuaObject.checkType(l, 2, out end);
				UnityEngine.Debug.DrawLine(start, end);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Vector3 start2;
				LuaObject.checkType(l, 1, out start2);
				Vector3 end2;
				LuaObject.checkType(l, 2, out end2);
				Color color;
				LuaObject.checkType(l, 3, out color);
				UnityEngine.Debug.DrawLine(start2, end2, color);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Vector3 start3;
				LuaObject.checkType(l, 1, out start3);
				Vector3 end3;
				LuaObject.checkType(l, 2, out end3);
				Color color2;
				LuaObject.checkType(l, 3, out color2);
				float duration;
				LuaObject.checkType(l, 4, out duration);
				UnityEngine.Debug.DrawLine(start3, end3, color2, duration);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Vector3 start4;
				LuaObject.checkType(l, 1, out start4);
				Vector3 end4;
				LuaObject.checkType(l, 2, out end4);
				Color color3;
				LuaObject.checkType(l, 3, out color3);
				float duration2;
				LuaObject.checkType(l, 4, out duration2);
				bool depthTest;
				LuaObject.checkType(l, 5, out depthTest);
				UnityEngine.Debug.DrawLine(start4, end4, color3, duration2, depthTest);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawLine to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602304A RID: 143434 RVA: 0x00C20184 File Offset: 0x00C1E384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawRay_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector3 start;
				LuaObject.checkType(l, 1, out start);
				Vector3 dir;
				LuaObject.checkType(l, 2, out dir);
				UnityEngine.Debug.DrawRay(start, dir);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Vector3 start2;
				LuaObject.checkType(l, 1, out start2);
				Vector3 dir2;
				LuaObject.checkType(l, 2, out dir2);
				Color color;
				LuaObject.checkType(l, 3, out color);
				UnityEngine.Debug.DrawRay(start2, dir2, color);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Vector3 start3;
				LuaObject.checkType(l, 1, out start3);
				Vector3 dir3;
				LuaObject.checkType(l, 2, out dir3);
				Color color2;
				LuaObject.checkType(l, 3, out color2);
				float duration;
				LuaObject.checkType(l, 4, out duration);
				UnityEngine.Debug.DrawRay(start3, dir3, color2, duration);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Vector3 start4;
				LuaObject.checkType(l, 1, out start4);
				Vector3 dir4;
				LuaObject.checkType(l, 2, out dir4);
				Color color3;
				LuaObject.checkType(l, 3, out color3);
				float duration2;
				LuaObject.checkType(l, 4, out duration2);
				bool depthTest;
				LuaObject.checkType(l, 5, out depthTest);
				UnityEngine.Debug.DrawRay(start4, dir4, color3, duration2, depthTest);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DrawRay to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602304B RID: 143435 RVA: 0x00C202EC File Offset: 0x00C1E4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Break_s(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Debug.Break();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602304C RID: 143436 RVA: 0x00C2032C File Offset: 0x00C1E52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DebugBreak_s(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Debug.DebugBreak();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602304D RID: 143437 RVA: 0x00C2036C File Offset: 0x00C1E56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Log_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				object message;
				LuaObject.checkType<object>(l, 1, out message);
				UnityEngine.Debug.Log(message);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				object message2;
				LuaObject.checkType<object>(l, 1, out message2);
				UnityEngine.Object context;
				LuaObject.checkType<UnityEngine.Object>(l, 2, out context);
				UnityEngine.Debug.Log(message2, context);
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

	// Token: 0x0602304E RID: 143438 RVA: 0x00C20410 File Offset: 0x00C1E610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogFormat_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string format;
				LuaObject.checkType(l, 1, out format);
				object[] args;
				LuaObject.checkParams<object>(l, 2, out args);
				UnityEngine.Debug.LogFormat(format, args);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				UnityEngine.Object context;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out context);
				string format2;
				LuaObject.checkType(l, 2, out format2);
				object[] args2;
				LuaObject.checkParams<object>(l, 3, out args2);
				UnityEngine.Debug.LogFormat(context, format2, args2);
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

	// Token: 0x0602304F RID: 143439 RVA: 0x00C204CC File Offset: 0x00C1E6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogError_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				object message;
				LuaObject.checkType<object>(l, 1, out message);
				UnityEngine.Debug.LogError(message);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				object message2;
				LuaObject.checkType<object>(l, 1, out message2);
				UnityEngine.Object context;
				LuaObject.checkType<UnityEngine.Object>(l, 2, out context);
				UnityEngine.Debug.LogError(message2, context);
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

	// Token: 0x06023050 RID: 143440 RVA: 0x00C20570 File Offset: 0x00C1E770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogErrorFormat_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string format;
				LuaObject.checkType(l, 1, out format);
				object[] args;
				LuaObject.checkParams<object>(l, 2, out args);
				UnityEngine.Debug.LogErrorFormat(format, args);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				UnityEngine.Object context;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out context);
				string format2;
				LuaObject.checkType(l, 2, out format2);
				object[] args2;
				LuaObject.checkParams<object>(l, 3, out args2);
				UnityEngine.Debug.LogErrorFormat(context, format2, args2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LogErrorFormat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023051 RID: 143441 RVA: 0x00C2062C File Offset: 0x00C1E82C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearDeveloperConsole_s(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Debug.ClearDeveloperConsole();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023052 RID: 143442 RVA: 0x00C2066C File Offset: 0x00C1E86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogException_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Exception exception;
				LuaObject.checkType<Exception>(l, 1, out exception);
				UnityEngine.Debug.LogException(exception);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				Exception exception2;
				LuaObject.checkType<Exception>(l, 1, out exception2);
				UnityEngine.Object context;
				LuaObject.checkType<UnityEngine.Object>(l, 2, out context);
				UnityEngine.Debug.LogException(exception2, context);
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

	// Token: 0x06023053 RID: 143443 RVA: 0x00C20710 File Offset: 0x00C1E910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogWarning_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				object message;
				LuaObject.checkType<object>(l, 1, out message);
				UnityEngine.Debug.LogWarning(message);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				object message2;
				LuaObject.checkType<object>(l, 1, out message2);
				UnityEngine.Object context;
				LuaObject.checkType<UnityEngine.Object>(l, 2, out context);
				UnityEngine.Debug.LogWarning(message2, context);
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

	// Token: 0x06023054 RID: 143444 RVA: 0x00C207B4 File Offset: 0x00C1E9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogWarningFormat_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string format;
				LuaObject.checkType(l, 1, out format);
				object[] args;
				LuaObject.checkParams<object>(l, 2, out args);
				UnityEngine.Debug.LogWarningFormat(format, args);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				UnityEngine.Object context;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out context);
				string format2;
				LuaObject.checkType(l, 2, out format2);
				object[] args2;
				LuaObject.checkParams<object>(l, 3, out args2);
				UnityEngine.Debug.LogWarningFormat(context, format2, args2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LogWarningFormat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023055 RID: 143445 RVA: 0x00C20870 File Offset: 0x00C1EA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Assert_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				bool flag;
				LuaObject.checkType(l, 1, out flag);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(bool), typeof(string)))
			{
				bool flag2;
				LuaObject.checkType(l, 1, out flag2);
				string text;
				LuaObject.checkType(l, 2, out text);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(bool), typeof(object)))
			{
				bool flag3;
				LuaObject.checkType(l, 1, out flag3);
				object obj;
				LuaObject.checkType<object>(l, 2, out obj);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(bool), typeof(UnityEngine.Object)))
			{
				bool flag4;
				LuaObject.checkType(l, 1, out flag4);
				UnityEngine.Object @object;
				LuaObject.checkType<UnityEngine.Object>(l, 2, out @object);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(bool), typeof(string), typeof(UnityEngine.Object)))
			{
				bool flag5;
				LuaObject.checkType(l, 1, out flag5);
				string text2;
				LuaObject.checkType(l, 2, out text2);
				UnityEngine.Object object2;
				LuaObject.checkType<UnityEngine.Object>(l, 3, out object2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(bool), typeof(object), typeof(UnityEngine.Object)))
			{
				bool flag6;
				LuaObject.checkType(l, 1, out flag6);
				object obj2;
				LuaObject.checkType<object>(l, 2, out obj2);
				UnityEngine.Object object3;
				LuaObject.checkType<UnityEngine.Object>(l, 3, out object3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Assert to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023056 RID: 143446 RVA: 0x00C20A60 File Offset: 0x00C1EC60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AssertFormat_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				bool flag;
				LuaObject.checkType(l, 1, out flag);
				string text;
				LuaObject.checkType(l, 2, out text);
				object[] array;
				LuaObject.checkParams<object>(l, 3, out array);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				bool flag2;
				LuaObject.checkType(l, 1, out flag2);
				UnityEngine.Object @object;
				LuaObject.checkType<UnityEngine.Object>(l, 2, out @object);
				string text2;
				LuaObject.checkType(l, 3, out text2);
				object[] array2;
				LuaObject.checkParams<object>(l, 4, out array2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AssertFormat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023057 RID: 143447 RVA: 0x00C20B24 File Offset: 0x00C1ED24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogAssertion_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				object obj;
				LuaObject.checkType<object>(l, 1, out obj);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				object obj2;
				LuaObject.checkType<object>(l, 1, out obj2);
				UnityEngine.Object @object;
				LuaObject.checkType<UnityEngine.Object>(l, 2, out @object);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LogAssertion to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023058 RID: 143448 RVA: 0x00C20BBC File Offset: 0x00C1EDBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogAssertionFormat_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string text;
				LuaObject.checkType(l, 1, out text);
				object[] array;
				LuaObject.checkParams<object>(l, 2, out array);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				UnityEngine.Object @object;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out @object);
				string text2;
				LuaObject.checkType(l, 2, out text2);
				object[] array2;
				LuaObject.checkParams<object>(l, 3, out array2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LogAssertionFormat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023059 RID: 143449 RVA: 0x00C20C68 File Offset: 0x00C1EE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_unityLogger(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UnityEngine.Debug.unityLogger);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602305A RID: 143450 RVA: 0x00C20CB0 File Offset: 0x00C1EEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_developerConsoleVisible(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UnityEngine.Debug.developerConsoleVisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602305B RID: 143451 RVA: 0x00C20CF8 File Offset: 0x00C1EEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_developerConsoleVisible(IntPtr l)
	{
		int result;
		try
		{
			bool developerConsoleVisible;
			LuaObject.checkType(l, 2, out developerConsoleVisible);
			UnityEngine.Debug.developerConsoleVisible = developerConsoleVisible;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602305C RID: 143452 RVA: 0x00C20D44 File Offset: 0x00C1EF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isDebugBuild(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UnityEngine.Debug.isDebugBuild);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602305D RID: 143453 RVA: 0x00C20D8C File Offset: 0x00C1EF8C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Debug");
		if (Lua_UnityEngine_Debug.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Debug.DrawLine_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cache0);
		if (Lua_UnityEngine_Debug.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Debug.DrawRay_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cache1);
		if (Lua_UnityEngine_Debug.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Debug.Break_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cache2);
		if (Lua_UnityEngine_Debug.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Debug.DebugBreak_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cache3);
		if (Lua_UnityEngine_Debug.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Debug.Log_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cache4);
		if (Lua_UnityEngine_Debug.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Debug.LogFormat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cache5);
		if (Lua_UnityEngine_Debug.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Debug.LogError_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cache6);
		if (Lua_UnityEngine_Debug.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Debug.LogErrorFormat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cache7);
		if (Lua_UnityEngine_Debug.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Debug.ClearDeveloperConsole_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cache8);
		if (Lua_UnityEngine_Debug.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Debug.LogException_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cache9);
		if (Lua_UnityEngine_Debug.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Debug.LogWarning_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cacheA);
		if (Lua_UnityEngine_Debug.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Debug.LogWarningFormat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cacheB);
		if (Lua_UnityEngine_Debug.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Debug.Assert_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cacheC);
		if (Lua_UnityEngine_Debug.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Debug.AssertFormat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cacheD);
		if (Lua_UnityEngine_Debug.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Debug.LogAssertion_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cacheE);
		if (Lua_UnityEngine_Debug.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Debug.LogAssertionFormat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Debug.<>f__mg$cacheF);
		string name = "unityLogger";
		if (Lua_UnityEngine_Debug.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Debug.get_unityLogger);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Debug.<>f__mg$cache10, null, false);
		string name2 = "developerConsoleVisible";
		if (Lua_UnityEngine_Debug.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Debug.get_developerConsoleVisible);
		}
		LuaCSFunction get = Lua_UnityEngine_Debug.<>f__mg$cache11;
		if (Lua_UnityEngine_Debug.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Debug.set_developerConsoleVisible);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_Debug.<>f__mg$cache12, false);
		string name3 = "isDebugBuild";
		if (Lua_UnityEngine_Debug.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Debug.get_isDebugBuild);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Debug.<>f__mg$cache13, null, false);
		if (Lua_UnityEngine_Debug.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Debug.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Debug.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Debug.<>f__mg$cache14, typeof(UnityEngine.Debug));
	}

	// Token: 0x04018F9A RID: 102298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018F9B RID: 102299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F9C RID: 102300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F9D RID: 102301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018F9E RID: 102302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018F9F RID: 102303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018FA0 RID: 102304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018FA1 RID: 102305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018FA2 RID: 102306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018FA3 RID: 102307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018FA4 RID: 102308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018FA5 RID: 102309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018FA6 RID: 102310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018FA7 RID: 102311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018FA8 RID: 102312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018FA9 RID: 102313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018FAA RID: 102314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018FAB RID: 102315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018FAC RID: 102316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018FAD RID: 102317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018FAE RID: 102318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
