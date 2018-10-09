using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001634 RID: 5684
[Preserve]
public class Lua_UnityEngine_AsyncOperation : LuaObject
{
	// Token: 0x06022C10 RID: 142352 RVA: 0x00BFFA00 File Offset: 0x00BFDC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AsyncOperation o = new AsyncOperation();
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

	// Token: 0x06022C11 RID: 142353 RVA: 0x00BFFA48 File Offset: 0x00BFDC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isDone(IntPtr l)
	{
		int result;
		try
		{
			AsyncOperation asyncOperation = (AsyncOperation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, asyncOperation.isDone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C12 RID: 142354 RVA: 0x00BFFA9C File Offset: 0x00BFDC9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_progress(IntPtr l)
	{
		int result;
		try
		{
			AsyncOperation asyncOperation = (AsyncOperation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, asyncOperation.progress);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C13 RID: 142355 RVA: 0x00BFFAF0 File Offset: 0x00BFDCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_priority(IntPtr l)
	{
		int result;
		try
		{
			AsyncOperation asyncOperation = (AsyncOperation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, asyncOperation.priority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C14 RID: 142356 RVA: 0x00BFFB44 File Offset: 0x00BFDD44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_priority(IntPtr l)
	{
		int result;
		try
		{
			AsyncOperation asyncOperation = (AsyncOperation)LuaObject.checkSelf(l);
			int priority;
			LuaObject.checkType(l, 2, out priority);
			asyncOperation.priority = priority;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C15 RID: 142357 RVA: 0x00BFFB9C File Offset: 0x00BFDD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_allowSceneActivation(IntPtr l)
	{
		int result;
		try
		{
			AsyncOperation asyncOperation = (AsyncOperation)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, asyncOperation.allowSceneActivation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C16 RID: 142358 RVA: 0x00BFFBF0 File Offset: 0x00BFDDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_allowSceneActivation(IntPtr l)
	{
		int result;
		try
		{
			AsyncOperation asyncOperation = (AsyncOperation)LuaObject.checkSelf(l);
			bool allowSceneActivation;
			LuaObject.checkType(l, 2, out allowSceneActivation);
			asyncOperation.allowSceneActivation = allowSceneActivation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C17 RID: 142359 RVA: 0x00BFFC48 File Offset: 0x00BFDE48
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AsyncOperation");
		string name = "isDone";
		if (Lua_UnityEngine_AsyncOperation.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AsyncOperation.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AsyncOperation.get_isDone);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_AsyncOperation.<>f__mg$cache0, null, true);
		string name2 = "progress";
		if (Lua_UnityEngine_AsyncOperation.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AsyncOperation.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AsyncOperation.get_progress);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_AsyncOperation.<>f__mg$cache1, null, true);
		string name3 = "priority";
		if (Lua_UnityEngine_AsyncOperation.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AsyncOperation.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AsyncOperation.get_priority);
		}
		LuaCSFunction get = Lua_UnityEngine_AsyncOperation.<>f__mg$cache2;
		if (Lua_UnityEngine_AsyncOperation.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AsyncOperation.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AsyncOperation.set_priority);
		}
		LuaObject.addMember(l, name3, get, Lua_UnityEngine_AsyncOperation.<>f__mg$cache3, true);
		string name4 = "allowSceneActivation";
		if (Lua_UnityEngine_AsyncOperation.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AsyncOperation.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AsyncOperation.get_allowSceneActivation);
		}
		LuaCSFunction get2 = Lua_UnityEngine_AsyncOperation.<>f__mg$cache4;
		if (Lua_UnityEngine_AsyncOperation.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AsyncOperation.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AsyncOperation.set_allowSceneActivation);
		}
		LuaObject.addMember(l, name4, get2, Lua_UnityEngine_AsyncOperation.<>f__mg$cache5, true);
		if (Lua_UnityEngine_AsyncOperation.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_AsyncOperation.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_AsyncOperation.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AsyncOperation.<>f__mg$cache6, typeof(AsyncOperation), typeof(YieldInstruction));
	}

	// Token: 0x04018C06 RID: 101382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C07 RID: 101383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C08 RID: 101384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018C09 RID: 101385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018C0A RID: 101386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018C0B RID: 101387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018C0C RID: 101388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
