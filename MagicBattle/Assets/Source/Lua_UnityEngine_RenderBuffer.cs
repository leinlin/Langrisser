using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001776 RID: 6006
[Preserve]
public class Lua_UnityEngine_RenderBuffer : LuaObject
{
	// Token: 0x06023A34 RID: 145972 RVA: 0x00C74C9C File Offset: 0x00C72E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RenderBuffer renderBuffer = default(RenderBuffer);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderBuffer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A35 RID: 145973 RVA: 0x00C74CEC File Offset: 0x00C72EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNativeRenderBufferPtr(IntPtr l)
	{
		int result;
		try
		{
			RenderBuffer renderBuffer;
			LuaObject.checkValueType<RenderBuffer>(l, 1, out renderBuffer);
			IntPtr nativeRenderBufferPtr = renderBuffer.GetNativeRenderBufferPtr();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nativeRenderBufferPtr);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A36 RID: 145974 RVA: 0x00C74D44 File Offset: 0x00C72F44
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RenderBuffer");
		if (Lua_UnityEngine_RenderBuffer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RenderBuffer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RenderBuffer.GetNativeRenderBufferPtr);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RenderBuffer.<>f__mg$cache0);
		if (Lua_UnityEngine_RenderBuffer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RenderBuffer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RenderBuffer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_RenderBuffer.<>f__mg$cache1, typeof(RenderBuffer), typeof(ValueType));
	}

	// Token: 0x040197A6 RID: 104358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040197A7 RID: 104359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
