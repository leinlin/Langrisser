using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Scripting;

// Token: 0x02001699 RID: 5785
[Preserve]
public class Lua_UnityEngine_Events_UnityEventBase : LuaObject
{
	// Token: 0x060230E5 RID: 143589 RVA: 0x00C245AC File Offset: 0x00C227AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPersistentEventCount(IntPtr l)
	{
		int result;
		try
		{
			UnityEventBase unityEventBase = (UnityEventBase)LuaObject.checkSelf(l);
			int persistentEventCount = unityEventBase.GetPersistentEventCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, persistentEventCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230E6 RID: 143590 RVA: 0x00C24600 File Offset: 0x00C22800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPersistentTarget(IntPtr l)
	{
		int result;
		try
		{
			UnityEventBase unityEventBase = (UnityEventBase)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			UnityEngine.Object persistentTarget = unityEventBase.GetPersistentTarget(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, persistentTarget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230E7 RID: 143591 RVA: 0x00C24664 File Offset: 0x00C22864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPersistentMethodName(IntPtr l)
	{
		int result;
		try
		{
			UnityEventBase unityEventBase = (UnityEventBase)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			string persistentMethodName = unityEventBase.GetPersistentMethodName(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, persistentMethodName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230E8 RID: 143592 RVA: 0x00C246C8 File Offset: 0x00C228C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPersistentListenerState(IntPtr l)
	{
		int result;
		try
		{
			UnityEventBase unityEventBase = (UnityEventBase)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			UnityEventCallState state;
			LuaObject.checkEnum<UnityEventCallState>(l, 3, out state);
			unityEventBase.SetPersistentListenerState(index, state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230E9 RID: 143593 RVA: 0x00C2472C File Offset: 0x00C2292C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAllListeners(IntPtr l)
	{
		int result;
		try
		{
			UnityEventBase unityEventBase = (UnityEventBase)LuaObject.checkSelf(l);
			unityEventBase.RemoveAllListeners();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230EA RID: 143594 RVA: 0x00C24778 File Offset: 0x00C22978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetValidMethodInfo_s(IntPtr l)
	{
		int result;
		try
		{
			object obj;
			LuaObject.checkType<object>(l, 1, out obj);
			string functionName;
			LuaObject.checkType(l, 2, out functionName);
			Type[] argumentTypes;
			LuaObject.checkArray<Type>(l, 3, out argumentTypes);
			MethodInfo validMethodInfo = UnityEventBase.GetValidMethodInfo(obj, functionName, argumentTypes);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, validMethodInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230EB RID: 143595 RVA: 0x00C247E8 File Offset: 0x00C229E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Events.UnityEventBase");
		if (Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Events_UnityEventBase.GetPersistentEventCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache0);
		if (Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Events_UnityEventBase.GetPersistentTarget);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache1);
		if (Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Events_UnityEventBase.GetPersistentMethodName);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache2);
		if (Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Events_UnityEventBase.SetPersistentListenerState);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache3);
		if (Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Events_UnityEventBase.RemoveAllListeners);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache4);
		if (Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Events_UnityEventBase.GetValidMethodInfo_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Events_UnityEventBase.<>f__mg$cache5);
		LuaObject.createTypeMetatable(l, null, typeof(UnityEventBase));
	}

	// Token: 0x04019011 RID: 102417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019012 RID: 102418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019013 RID: 102419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019014 RID: 102420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019015 RID: 102421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019016 RID: 102422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
