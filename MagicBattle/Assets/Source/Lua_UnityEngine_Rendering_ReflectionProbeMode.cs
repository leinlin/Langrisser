using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001797 RID: 6039
[Preserve]
public class Lua_UnityEngine_Rendering_ReflectionProbeMode : LuaObject
{
	// Token: 0x06023AFC RID: 146172 RVA: 0x00C7CCAC File Offset: 0x00C7AEAC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.ReflectionProbeMode");
		LuaObject.addMember(l, 0, "Baked");
		LuaObject.addMember(l, 1, "Realtime");
		LuaObject.addMember(l, 2, "Custom");
		LuaDLL.lua_pop(l, 1);
	}
}
