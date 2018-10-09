using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200175B RID: 5979
[Preserve]
public class Lua_UnityEngine_PrimitiveType : LuaObject
{
	// Token: 0x0602387E RID: 145534 RVA: 0x00C683D4 File Offset: 0x00C665D4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.PrimitiveType");
		LuaObject.addMember(l, 0, "Sphere");
		LuaObject.addMember(l, 1, "Capsule");
		LuaObject.addMember(l, 2, "Cylinder");
		LuaObject.addMember(l, 3, "Cube");
		LuaObject.addMember(l, 4, "Plane");
		LuaObject.addMember(l, 5, "Quad");
		LuaDLL.lua_pop(l, 1);
	}
}
