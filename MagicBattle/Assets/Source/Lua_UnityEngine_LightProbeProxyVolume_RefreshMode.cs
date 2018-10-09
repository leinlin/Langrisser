using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001710 RID: 5904
[Preserve]
public class Lua_UnityEngine_LightProbeProxyVolume_RefreshMode : LuaObject
{
	// Token: 0x060234E1 RID: 144609 RVA: 0x00C42F90 File Offset: 0x00C41190
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LightProbeProxyVolume.RefreshMode");
		LuaObject.addMember(l, 0, "Automatic");
		LuaObject.addMember(l, 1, "EveryFrame");
		LuaObject.addMember(l, 2, "ViaScripting");
		LuaDLL.lua_pop(l, 1);
	}
}
