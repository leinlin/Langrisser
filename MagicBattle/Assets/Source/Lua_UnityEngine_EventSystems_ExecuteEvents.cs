using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016A7 RID: 5799
[Preserve]
public class Lua_UnityEngine_EventSystems_ExecuteEvents : LuaObject
{
	// Token: 0x06023158 RID: 143704 RVA: 0x00C27420 File Offset: 0x00C25620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Execute_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject target;
			LuaObject.checkType<GameObject>(l, 1, out target);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			ExecuteEvents.EventFunction<IEventSystemHandler> functor;
			LuaObject.checkDelegate<ExecuteEvents.EventFunction<IEventSystemHandler>>(l, 3, out functor);
			bool b = ExecuteEvents.Execute<IEventSystemHandler>(target, eventData, functor);
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

	// Token: 0x06023159 RID: 143705 RVA: 0x00C27490 File Offset: 0x00C25690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteHierarchy_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject root;
			LuaObject.checkType<GameObject>(l, 1, out root);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			ExecuteEvents.EventFunction<IEventSystemHandler> callbackFunction;
			LuaObject.checkDelegate<ExecuteEvents.EventFunction<IEventSystemHandler>>(l, 3, out callbackFunction);
			GameObject o = ExecuteEvents.ExecuteHierarchy<IEventSystemHandler>(root, eventData, callbackFunction);
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

	// Token: 0x0602315A RID: 143706 RVA: 0x00C27500 File Offset: 0x00C25700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanHandleEvent_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			bool b = ExecuteEvents.CanHandleEvent<IEventSystemHandler>(go);
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

	// Token: 0x0602315B RID: 143707 RVA: 0x00C27554 File Offset: 0x00C25754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEventHandler_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject root;
			LuaObject.checkType<GameObject>(l, 1, out root);
			GameObject eventHandler = ExecuteEvents.GetEventHandler<IEventSystemHandler>(root);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventHandler);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602315C RID: 143708 RVA: 0x00C275A8 File Offset: 0x00C257A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.ExecuteEvents");
		if (Lua_UnityEngine_EventSystems_ExecuteEvents.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_ExecuteEvents.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_ExecuteEvents.Execute_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_ExecuteEvents.<>f__mg$cache0);
		if (Lua_UnityEngine_EventSystems_ExecuteEvents.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_ExecuteEvents.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_ExecuteEvents.ExecuteHierarchy_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_ExecuteEvents.<>f__mg$cache1);
		if (Lua_UnityEngine_EventSystems_ExecuteEvents.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_ExecuteEvents.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_ExecuteEvents.CanHandleEvent_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_ExecuteEvents.<>f__mg$cache2);
		if (Lua_UnityEngine_EventSystems_ExecuteEvents.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_ExecuteEvents.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_ExecuteEvents.GetEventHandler_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_ExecuteEvents.<>f__mg$cache3);
		LuaObject.createTypeMetatable(l, null, typeof(ExecuteEvents));
	}

	// Token: 0x04019068 RID: 102504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019069 RID: 102505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401906A RID: 102506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401906B RID: 102507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
