using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001798 RID: 6040
[Preserve]
public class Lua_UnityEngine_Rendering_ReflectionProbeRefreshMode : LuaObject
{
	// Token: 0x06023AFE RID: 146174 RVA: 0x00C7CCEC File Offset: 0x00C7AEEC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.ReflectionProbeRefreshMode");
		LuaObject.addMember(l, 0, "OnAwake");
		LuaObject.addMember(l, 1, "EveryFrame");
		LuaObject.addMember(l, 2, "ViaScripting");
		LuaDLL.lua_pop(l, 1);
	}
}
