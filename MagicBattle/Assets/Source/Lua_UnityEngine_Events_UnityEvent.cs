using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Events;
using UnityEngine.Scripting;

// Token: 0x02001698 RID: 5784
[Preserve]
public class Lua_UnityEngine_Events_UnityEvent : LuaObject
{
	// Token: 0x060230DF RID: 143583 RVA: 0x00C243A8 File Offset: 0x00C225A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UnityEvent o = new UnityEvent();
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

	// Token: 0x060230E0 RID: 143584 RVA: 0x00C243F0 File Offset: 0x00C225F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddListener(IntPtr l)
	{
		int result;
		try
		{
			UnityEvent unityEvent = (UnityEvent)LuaObject.checkSelf(l);
			UnityAction call;
			LuaObject.checkDelegate<UnityAction>(l, 2, out call);
			unityEvent.AddListener(call);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230E1 RID: 143585 RVA: 0x00C24448 File Offset: 0x00C22648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveListener(IntPtr l)
	{
		int result;
		try
		{
			UnityEvent unityEvent = (UnityEvent)LuaObject.checkSelf(l);
			UnityAction call;
			LuaObject.checkDelegate<UnityAction>(l, 2, out call);
			unityEvent.RemoveListener(call);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230E2 RID: 143586 RVA: 0x00C244A0 File Offset: 0x00C226A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Invoke(IntPtr l)
	{
		int result;
		try
		{
			UnityEvent unityEvent = (UnityEvent)LuaObject.checkSelf(l);
			unityEvent.Invoke();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230E3 RID: 143587 RVA: 0x00C244EC File Offset: 0x00C226EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Events.UnityEvent");
		if (Lua_UnityEngine_Events_UnityEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Events_UnityEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Events_UnityEvent.AddListener);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Events_UnityEvent.<>f__mg$cache0);
		if (Lua_UnityEngine_Events_UnityEvent.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Events_UnityEvent.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Events_UnityEvent.RemoveListener);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Events_UnityEvent.<>f__mg$cache1);
		if (Lua_UnityEngine_Events_UnityEvent.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Events_UnityEvent.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Events_UnityEvent.Invoke);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Events_UnityEvent.<>f__mg$cache2);
		if (Lua_UnityEngine_Events_UnityEvent.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Events_UnityEvent.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Events_UnityEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Events_UnityEvent.<>f__mg$cache3, typeof(UnityEvent), typeof(UnityEventBase));
	}

	// Token: 0x0401900D RID: 102413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401900E RID: 102414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401900F RID: 102415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019010 RID: 102416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
