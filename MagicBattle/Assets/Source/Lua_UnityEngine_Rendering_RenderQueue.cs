using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200179E RID: 6046
[Preserve]
public class Lua_UnityEngine_Rendering_RenderQueue : LuaObject
{
	// Token: 0x06023B0A RID: 146186 RVA: 0x00C7CE90 File Offset: 0x00C7B090
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.RenderQueue");
		LuaObject.addMember(l, 1000, "Background");
		LuaObject.addMember(l, 2000, "Geometry");
		LuaObject.addMember(l, 2450, "AlphaTest");
		LuaObject.addMember(l, 2500, "GeometryLast");
		LuaObject.addMember(l, 3000, "Transparent");
		LuaObject.addMember(l, 4000, "Overlay");
		LuaDLL.lua_pop(l, 1);
	}
}
