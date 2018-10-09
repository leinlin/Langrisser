using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200178F RID: 6031
[Preserve]
public class Lua_UnityEngine_Rendering_LightProbeUsage : LuaObject
{
	// Token: 0x06023AE7 RID: 146151 RVA: 0x00C7C798 File Offset: 0x00C7A998
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.LightProbeUsage");
		LuaObject.addMember(l, 0, "Off");
		LuaObject.addMember(l, 1, "BlendProbes");
		LuaObject.addMember(l, 2, "UseProxyVolume");
		LuaDLL.lua_pop(l, 1);
	}
}
