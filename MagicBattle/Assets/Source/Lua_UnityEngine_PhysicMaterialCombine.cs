using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001738 RID: 5944
[Preserve]
public class Lua_UnityEngine_PhysicMaterialCombine : LuaObject
{
	// Token: 0x060236DF RID: 145119 RVA: 0x00C553F4 File Offset: 0x00C535F4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.PhysicMaterialCombine");
		LuaObject.addMember(l, 0, "Average");
		LuaObject.addMember(l, 1, "Multiply");
		LuaObject.addMember(l, 2, "Minimum");
		LuaObject.addMember(l, 3, "Maximum");
		LuaDLL.lua_pop(l, 1);
	}
}
