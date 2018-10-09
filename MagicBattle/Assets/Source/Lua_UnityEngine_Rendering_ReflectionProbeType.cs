using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200179A RID: 6042
[Preserve]
public class Lua_UnityEngine_Rendering_ReflectionProbeType : LuaObject
{
	// Token: 0x06023B02 RID: 146178 RVA: 0x00C7CD6C File Offset: 0x00C7AF6C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.ReflectionProbeType");
		LuaObject.addMember(l, 0, "Cube");
		LuaObject.addMember(l, 1, "Card");
		LuaDLL.lua_pop(l, 1);
	}
}
