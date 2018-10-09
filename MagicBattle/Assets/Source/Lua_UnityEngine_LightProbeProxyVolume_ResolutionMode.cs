using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001711 RID: 5905
[Preserve]
public class Lua_UnityEngine_LightProbeProxyVolume_ResolutionMode : LuaObject
{
	// Token: 0x060234E3 RID: 144611 RVA: 0x00C42FD0 File Offset: 0x00C411D0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LightProbeProxyVolume.ResolutionMode");
		LuaObject.addMember(l, 0, "Automatic");
		LuaObject.addMember(l, 1, "Custom");
		LuaDLL.lua_pop(l, 1);
	}
}
