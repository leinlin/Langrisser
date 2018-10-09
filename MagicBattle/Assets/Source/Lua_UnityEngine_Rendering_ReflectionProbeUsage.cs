using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200179B RID: 6043
[Preserve]
public class Lua_UnityEngine_Rendering_ReflectionProbeUsage : LuaObject
{
	// Token: 0x06023B04 RID: 146180 RVA: 0x00C7CDA0 File Offset: 0x00C7AFA0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.ReflectionProbeUsage");
		LuaObject.addMember(l, 0, "Off");
		LuaObject.addMember(l, 1, "BlendProbes");
		LuaObject.addMember(l, 2, "BlendProbesAndSkybox");
		LuaObject.addMember(l, 3, "Simple");
		LuaDLL.lua_pop(l, 1);
	}
}
