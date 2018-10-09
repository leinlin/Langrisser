using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200160A RID: 5642
[Preserve]
public class Lua_JetBrains_Annotations_ImplicitUseTargetFlags : LuaObject
{
	// Token: 0x060229E0 RID: 141792 RVA: 0x00BEC320 File Offset: 0x00BEA520
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "JetBrains.Annotations.ImplicitUseTargetFlags");
		LuaObject.addMember(l, 1, "Itself");
		LuaObject.addMember(l, 1, "Default");
		LuaObject.addMember(l, 2, "Members");
		LuaObject.addMember(l, 3, "WithMembers");
		LuaDLL.lua_pop(l, 1);
	}
}
