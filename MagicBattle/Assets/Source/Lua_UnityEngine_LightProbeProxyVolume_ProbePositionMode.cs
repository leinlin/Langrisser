using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200170F RID: 5903
[Preserve]
public class Lua_UnityEngine_LightProbeProxyVolume_ProbePositionMode : LuaObject
{
	// Token: 0x060234DF RID: 144607 RVA: 0x00C42F5C File Offset: 0x00C4115C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LightProbeProxyVolume.ProbePositionMode");
		LuaObject.addMember(l, 0, "CellCorner");
		LuaObject.addMember(l, 1, "CellCenter");
		LuaDLL.lua_pop(l, 1);
	}
}
