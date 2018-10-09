using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200172A RID: 5930
[Preserve]
public class Lua_UnityEngine_MeshColliderCookingOptions : LuaObject
{
	// Token: 0x06023693 RID: 145043 RVA: 0x00C53040 File Offset: 0x00C51240
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.MeshColliderCookingOptions");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "InflateConvexMesh");
		LuaObject.addMember(l, 2, "CookForFasterSimulation");
		LuaObject.addMember(l, 4, "EnableMeshCleaning");
		LuaObject.addMember(l, 8, "WeldColocatedVertices");
		LuaDLL.lua_pop(l, 1);
	}
}
