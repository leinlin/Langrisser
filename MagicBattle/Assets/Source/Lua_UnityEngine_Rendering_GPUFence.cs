using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x02001789 RID: 6025
[Preserve]
public class Lua_UnityEngine_Rendering_GPUFence : LuaObject
{
	// Token: 0x06023AC9 RID: 146121 RVA: 0x00C7BCD4 File Offset: 0x00C79ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GPUFence gpufence = default(GPUFence);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gpufence);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ACA RID: 146122 RVA: 0x00C7BD24 File Offset: 0x00C79F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_passed(IntPtr l)
	{
		int result;
		try
		{
			GPUFence gpufence;
			LuaObject.checkValueType<GPUFence>(l, 1, out gpufence);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gpufence.passed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ACB RID: 146123 RVA: 0x00C7BD78 File Offset: 0x00C79F78
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Rendering.GPUFence");
		string name = "passed";
		if (Lua_UnityEngine_Rendering_GPUFence.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Rendering_GPUFence.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Rendering_GPUFence.get_passed);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Rendering_GPUFence.<>f__mg$cache0, null, true);
		if (Lua_UnityEngine_Rendering_GPUFence.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Rendering_GPUFence.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Rendering_GPUFence.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Rendering_GPUFence.<>f__mg$cache1, typeof(GPUFence), typeof(ValueType));
	}

	// Token: 0x04019815 RID: 104469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019816 RID: 104470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
