using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017F3 RID: 6131
[Preserve]
public class Lua_UnityEngine_TexGenMode : LuaObject
{
	// Token: 0x06023E3A RID: 147002 RVA: 0x00C952A4 File Offset: 0x00C934A4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.TexGenMode");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "SphereMap");
		LuaObject.addMember(l, 2, "Object");
		LuaObject.addMember(l, 3, "EyeLinear");
		LuaObject.addMember(l, 4, "CubeReflect");
		LuaObject.addMember(l, 5, "CubeNormal");
		LuaDLL.lua_pop(l, 1);
	}
}
