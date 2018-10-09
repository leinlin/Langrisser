using System;
using System.Runtime.CompilerServices;
using System.Threading;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020015FC RID: 5628
[Preserve]
public class Lua_Debug : LuaObject
{
	// Token: 0x0602280A RID: 141322 RVA: 0x00BD4C5C File Offset: 0x00BD2E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Log_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string str;
				LuaObject.checkType(l, 1, out str);
				global::Debug.Log(str);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(object[])))
			{
				object[] paramList;
				LuaObject.checkParams<object>(l, 1, out paramList);
				global::Debug.Log(paramList);
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

	// Token: 0x0602280B RID: 141323 RVA: 0x00BD4D14 File Offset: 0x00BD2F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogWarning_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string str;
				LuaObject.checkType(l, 1, out str);
				global::Debug.LogWarning(str);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(object[])))
			{
				object[] paramList;
				LuaObject.checkParams<object>(l, 1, out paramList);
				global::Debug.LogWarning(paramList);
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

	// Token: 0x0602280C RID: 141324 RVA: 0x00BD4DCC File Offset: 0x00BD2FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogError_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string str;
				LuaObject.checkType(l, 1, out str);
				global::Debug.LogError(str);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(object[])))
			{
				object[] paramList;
				LuaObject.checkParams<object>(l, 1, out paramList);
				global::Debug.LogError(paramList);
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

	// Token: 0x0602280D RID: 141325 RVA: 0x00BD4E84 File Offset: 0x00BD3084
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Assert_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(bool), typeof(object[])))
			{
				bool value;
				LuaObject.checkType(l, 1, out value);
				object[] paramList;
				LuaObject.checkParams<object>(l, 2, out paramList);
				global::Debug.Assert(value, paramList);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(bool), typeof(string)))
			{
				bool value2;
				LuaObject.checkType(l, 1, out value2);
				string str;
				LuaObject.checkType(l, 2, out str);
				global::Debug.Assert(value2, str);
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

	// Token: 0x0602280E RID: 141326 RVA: 0x00BD4F68 File Offset: 0x00BD3168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WriteLine_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string str;
				LuaObject.checkType(l, 1, out str);
				global::Debug.WriteLine(str);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(object[])))
			{
				object[] paramList;
				LuaObject.checkParams<object>(l, 1, out paramList);
				global::Debug.WriteLine(paramList);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function WriteLine to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602280F RID: 141327 RVA: 0x00BD5020 File Offset: 0x00BD3220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SystemLogException_s(IntPtr l)
	{
		int result;
		try
		{
			object[] paramList;
			LuaObject.checkParams<object>(l, 1, out paramList);
			global::Debug.SystemLogException(paramList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022810 RID: 141328 RVA: 0x00BD506C File Offset: 0x00BD326C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Break_s(IntPtr l)
	{
		int result;
		try
		{
			global::Debug.Break();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022811 RID: 141329 RVA: 0x00BD50AC File Offset: 0x00BD32AC
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
				global::Debug.DrawLine(start, end);
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
				global::Debug.DrawLine(start2, end2, color);
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
				global::Debug.DrawLine(start3, end3, color2, duration);
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
				global::Debug.DrawLine(start4, end4, color3, duration2, depthTest);
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

	// Token: 0x06022812 RID: 141330 RVA: 0x00BD5214 File Offset: 0x00BD3414
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
				global::Debug.DrawRay(start, dir);
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
				global::Debug.DrawRay(start2, dir2, color);
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
				global::Debug.DrawRay(start3, dir3, color2, duration);
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
				global::Debug.DrawRay(start4, dir4, color3, duration2, depthTest);
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

	// Token: 0x06022813 RID: 141331 RVA: 0x00BD537C File Offset: 0x00BD357C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mainThread(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, global::Debug.m_mainThread);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022814 RID: 141332 RVA: 0x00BD53C4 File Offset: 0x00BD35C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_mainThread(IntPtr l)
	{
		int result;
		try
		{
			Thread mainThread;
			LuaObject.checkType<Thread>(l, 2, out mainThread);
			global::Debug.m_mainThread = mainThread;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022815 RID: 141333 RVA: 0x00BD5410 File Offset: 0x00BD3610
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "Debug");
		if (Lua_Debug.<>f__mg$cache0 == null)
		{
			Lua_Debug.<>f__mg$cache0 = new LuaCSFunction(Lua_Debug.Log_s);
		}
		LuaObject.addMember(l, Lua_Debug.<>f__mg$cache0);
		if (Lua_Debug.<>f__mg$cache1 == null)
		{
			Lua_Debug.<>f__mg$cache1 = new LuaCSFunction(Lua_Debug.LogWarning_s);
		}
		LuaObject.addMember(l, Lua_Debug.<>f__mg$cache1);
		if (Lua_Debug.<>f__mg$cache2 == null)
		{
			Lua_Debug.<>f__mg$cache2 = new LuaCSFunction(Lua_Debug.LogError_s);
		}
		LuaObject.addMember(l, Lua_Debug.<>f__mg$cache2);
		if (Lua_Debug.<>f__mg$cache3 == null)
		{
			Lua_Debug.<>f__mg$cache3 = new LuaCSFunction(Lua_Debug.Assert_s);
		}
		LuaObject.addMember(l, Lua_Debug.<>f__mg$cache3);
		if (Lua_Debug.<>f__mg$cache4 == null)
		{
			Lua_Debug.<>f__mg$cache4 = new LuaCSFunction(Lua_Debug.WriteLine_s);
		}
		LuaObject.addMember(l, Lua_Debug.<>f__mg$cache4);
		if (Lua_Debug.<>f__mg$cache5 == null)
		{
			Lua_Debug.<>f__mg$cache5 = new LuaCSFunction(Lua_Debug.SystemLogException_s);
		}
		LuaObject.addMember(l, Lua_Debug.<>f__mg$cache5);
		if (Lua_Debug.<>f__mg$cache6 == null)
		{
			Lua_Debug.<>f__mg$cache6 = new LuaCSFunction(Lua_Debug.Break_s);
		}
		LuaObject.addMember(l, Lua_Debug.<>f__mg$cache6);
		if (Lua_Debug.<>f__mg$cache7 == null)
		{
			Lua_Debug.<>f__mg$cache7 = new LuaCSFunction(Lua_Debug.DrawLine_s);
		}
		LuaObject.addMember(l, Lua_Debug.<>f__mg$cache7);
		if (Lua_Debug.<>f__mg$cache8 == null)
		{
			Lua_Debug.<>f__mg$cache8 = new LuaCSFunction(Lua_Debug.DrawRay_s);
		}
		LuaObject.addMember(l, Lua_Debug.<>f__mg$cache8);
		string name = "m_mainThread";
		if (Lua_Debug.<>f__mg$cache9 == null)
		{
			Lua_Debug.<>f__mg$cache9 = new LuaCSFunction(Lua_Debug.get_m_mainThread);
		}
		LuaCSFunction get = Lua_Debug.<>f__mg$cache9;
		if (Lua_Debug.<>f__mg$cacheA == null)
		{
			Lua_Debug.<>f__mg$cacheA = new LuaCSFunction(Lua_Debug.set_m_mainThread);
		}
		LuaObject.addMember(l, name, get, Lua_Debug.<>f__mg$cacheA, false);
		LuaObject.createTypeMetatable(l, null, typeof(global::Debug));
	}

	// Token: 0x040185F4 RID: 99828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185F5 RID: 99829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185F6 RID: 99830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040185F7 RID: 99831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040185F8 RID: 99832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040185F9 RID: 99833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040185FA RID: 99834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040185FB RID: 99835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040185FC RID: 99836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040185FD RID: 99837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040185FE RID: 99838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
