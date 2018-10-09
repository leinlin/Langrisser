using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200172D RID: 5933
[Preserve]
public class Lua_UnityEngine_MeshTopology : LuaObject
{
	// Token: 0x0602369F RID: 145055 RVA: 0x00C533F4 File Offset: 0x00C515F4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.MeshTopology");
		LuaObject.addMember(l, 0, "Triangles");
		LuaObject.addMember(l, 2, "Quads");
		LuaObject.addMember(l, 3, "Lines");
		LuaObject.addMember(l, 4, "LineStrip");
		LuaObject.addMember(l, 5, "Points");
		LuaDLL.lua_pop(l, 1);
	}
}
