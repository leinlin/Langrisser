using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x02001795 RID: 6037
[Preserve]
public class Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo : LuaObject
{
	// Token: 0x06023AF3 RID: 146163 RVA: 0x00C7C9D4 File Offset: 0x00C7ABD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbeBlendInfo reflectionProbeBlendInfo = default(ReflectionProbeBlendInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbeBlendInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AF4 RID: 146164 RVA: 0x00C7CA24 File Offset: 0x00C7AC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_probe(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbeBlendInfo reflectionProbeBlendInfo;
			LuaObject.checkValueType<ReflectionProbeBlendInfo>(l, 1, out reflectionProbeBlendInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbeBlendInfo.probe);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AF5 RID: 146165 RVA: 0x00C7CA78 File Offset: 0x00C7AC78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_probe(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbeBlendInfo reflectionProbeBlendInfo;
			LuaObject.checkValueType<ReflectionProbeBlendInfo>(l, 1, out reflectionProbeBlendInfo);
			ReflectionProbe probe;
			LuaObject.checkType<ReflectionProbe>(l, 2, out probe);
			reflectionProbeBlendInfo.probe = probe;
			LuaObject.setBack(l, reflectionProbeBlendInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AF6 RID: 146166 RVA: 0x00C7CADC File Offset: 0x00C7ACDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_weight(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbeBlendInfo reflectionProbeBlendInfo;
			LuaObject.checkValueType<ReflectionProbeBlendInfo>(l, 1, out reflectionProbeBlendInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reflectionProbeBlendInfo.weight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AF7 RID: 146167 RVA: 0x00C7CB30 File Offset: 0x00C7AD30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_weight(IntPtr l)
	{
		int result;
		try
		{
			ReflectionProbeBlendInfo reflectionProbeBlendInfo;
			LuaObject.checkValueType<ReflectionProbeBlendInfo>(l, 1, out reflectionProbeBlendInfo);
			float weight;
			LuaObject.checkType(l, 2, out weight);
			reflectionProbeBlendInfo.weight = weight;
			LuaObject.setBack(l, reflectionProbeBlendInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AF8 RID: 146168 RVA: 0x00C7CB94 File Offset: 0x00C7AD94
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Rendering.ReflectionProbeBlendInfo");
		string name = "probe";
		if (Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.get_probe);
		}
		LuaCSFunction get = Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache0;
		if (Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.set_probe);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache1, true);
		string name2 = "weight";
		if (Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.get_weight);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache2;
		if (Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.set_weight);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache3, true);
		if (Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Rendering_ReflectionProbeBlendInfo.<>f__mg$cache4, typeof(ReflectionProbeBlendInfo), typeof(ValueType));
	}

	// Token: 0x04019827 RID: 104487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019828 RID: 104488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019829 RID: 104489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401982A RID: 104490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401982B RID: 104491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
