using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200170E RID: 5902
[Preserve]
public class Lua_UnityEngine_LightProbeProxyVolume_BoundingBoxMode : LuaObject
{
	// Token: 0x060234DD RID: 144605 RVA: 0x00C42F1C File Offset: 0x00C4111C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LightProbeProxyVolume.BoundingBoxMode");
		LuaObject.addMember(l, 0, "AutomaticLocal");
		LuaObject.addMember(l, 1, "AutomaticWorld");
		LuaObject.addMember(l, 2, "Custom");
		LuaDLL.lua_pop(l, 1);
	}
}
