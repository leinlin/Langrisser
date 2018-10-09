using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200160B RID: 5643
[Preserve]
public class Lua_UnityEngine_AccelerationEvent : LuaObject
{
	// Token: 0x060229E2 RID: 141794 RVA: 0x00BEC378 File Offset: 0x00BEA578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AccelerationEvent accelerationEvent = default(AccelerationEvent);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, accelerationEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229E3 RID: 141795 RVA: 0x00BEC3C8 File Offset: 0x00BEA5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_acceleration(IntPtr l)
	{
		int result;
		try
		{
			AccelerationEvent accelerationEvent;
			LuaObject.checkValueType<AccelerationEvent>(l, 1, out accelerationEvent);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, accelerationEvent.acceleration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229E4 RID: 141796 RVA: 0x00BEC41C File Offset: 0x00BEA61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deltaTime(IntPtr l)
	{
		int result;
		try
		{
			AccelerationEvent accelerationEvent;
			LuaObject.checkValueType<AccelerationEvent>(l, 1, out accelerationEvent);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, accelerationEvent.deltaTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060229E5 RID: 141797 RVA: 0x00BEC470 File Offset: 0x00BEA670
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AccelerationEvent");
		string name = "acceleration";
		if (Lua_UnityEngine_AccelerationEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AccelerationEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AccelerationEvent.get_acceleration);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_AccelerationEvent.<>f__mg$cache0, null, true);
		string name2 = "deltaTime";
		if (Lua_UnityEngine_AccelerationEvent.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AccelerationEvent.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AccelerationEvent.get_deltaTime);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_AccelerationEvent.<>f__mg$cache1, null, true);
		if (Lua_UnityEngine_AccelerationEvent.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AccelerationEvent.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AccelerationEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AccelerationEvent.<>f__mg$cache2, typeof(AccelerationEvent), typeof(ValueType));
	}

	// Token: 0x04018A2A RID: 100906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018A2B RID: 100907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018A2C RID: 100908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
