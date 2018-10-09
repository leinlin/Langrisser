using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200170C RID: 5900
[Preserve]
public class Lua_UnityEngine_LightProbeGroup : LuaObject
{
	// Token: 0x060234C0 RID: 144576 RVA: 0x00C422D8 File Offset: 0x00C404D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_probePositions(IntPtr l)
	{
		int result;
		try
		{
			LightProbeGroup lightProbeGroup = (LightProbeGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightProbeGroup.probePositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234C1 RID: 144577 RVA: 0x00C4232C File Offset: 0x00C4052C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_probePositions(IntPtr l)
	{
		int result;
		try
		{
			LightProbeGroup lightProbeGroup = (LightProbeGroup)LuaObject.checkSelf(l);
			Vector3[] probePositions;
			LuaObject.checkArray<Vector3>(l, 2, out probePositions);
			lightProbeGroup.probePositions = probePositions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234C2 RID: 144578 RVA: 0x00C42384 File Offset: 0x00C40584
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LightProbeGroup");
		string name = "probePositions";
		if (Lua_UnityEngine_LightProbeGroup.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LightProbeGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LightProbeGroup.get_probePositions);
		}
		LuaCSFunction get = Lua_UnityEngine_LightProbeGroup.<>f__mg$cache0;
		if (Lua_UnityEngine_LightProbeGroup.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LightProbeGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LightProbeGroup.set_probePositions);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_LightProbeGroup.<>f__mg$cache1, true);
		LuaObject.createTypeMetatable(l, null, typeof(LightProbeGroup), typeof(Behaviour));
	}

	// Token: 0x04019306 RID: 103174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019307 RID: 103175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
