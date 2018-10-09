using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017A9 RID: 6057
[Preserve]
public class Lua_UnityEngine_RenderingPath : LuaObject
{
	// Token: 0x06023B36 RID: 146230 RVA: 0x00C7E160 File Offset: 0x00C7C360
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RenderingPath");
		LuaObject.addMember(l, 0, "VertexLit");
		LuaObject.addMember(l, 1, "Forward");
		LuaObject.addMember(l, 2, "DeferredLighting");
		LuaObject.addMember(l, 3, "DeferredShading");
		LuaObject.addMember(l, -1, "UsePlayerSettings");
		LuaDLL.lua_pop(l, 1);
	}
}
