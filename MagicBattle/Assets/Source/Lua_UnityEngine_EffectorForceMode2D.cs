using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001694 RID: 5780
[Preserve]
public class Lua_UnityEngine_EffectorForceMode2D : LuaObject
{
	// Token: 0x060230A8 RID: 143528 RVA: 0x00C22BD4 File Offset: 0x00C20DD4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.EffectorForceMode2D");
		LuaObject.addMember(l, 0, "Constant");
		LuaObject.addMember(l, 1, "InverseLinear");
		LuaObject.addMember(l, 2, "InverseSquared");
		LuaDLL.lua_pop(l, 1);
	}
}
