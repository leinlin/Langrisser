using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200166F RID: 5743
[Preserve]
public class Lua_UnityEngine_CompositeCollider2D_GeometryType : LuaObject
{
	// Token: 0x06022F16 RID: 143126 RVA: 0x00C16824 File Offset: 0x00C14A24
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.CompositeCollider2D.GeometryType");
		LuaObject.addMember(l, 0, "Outlines");
		LuaObject.addMember(l, 1, "Polygons");
		LuaDLL.lua_pop(l, 1);
	}
}
