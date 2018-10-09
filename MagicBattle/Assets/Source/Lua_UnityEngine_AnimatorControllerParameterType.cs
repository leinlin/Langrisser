using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001620 RID: 5664
[Preserve]
public class Lua_UnityEngine_AnimatorControllerParameterType : LuaObject
{
	// Token: 0x06022B5A RID: 142170 RVA: 0x00BFA5E0 File Offset: 0x00BF87E0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AnimatorControllerParameterType");
		LuaObject.addMember(l, 1, "Float");
		LuaObject.addMember(l, 3, "Int");
		LuaObject.addMember(l, 4, "Bool");
		LuaObject.addMember(l, 9, "Trigger");
		LuaDLL.lua_pop(l, 1);
	}
}
