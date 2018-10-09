using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001609 RID: 5641
[Preserve]
public class Lua_JetBrains_Annotations_ImplicitUseKindFlags : LuaObject
{
	// Token: 0x060229DE RID: 141790 RVA: 0x00BEC2BC File Offset: 0x00BEA4BC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "JetBrains.Annotations.ImplicitUseKindFlags");
		LuaObject.addMember(l, 1, "Access");
		LuaObject.addMember(l, 2, "Assign");
		LuaObject.addMember(l, 4, "InstantiatedWithFixedConstructorSignature");
		LuaObject.addMember(l, 7, "Default");
		LuaObject.addMember(l, 8, "InstantiatedNoFixedConstructorSignature");
		LuaDLL.lua_pop(l, 1);
	}
}
