using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001695 RID: 5781
[Preserve]
public class Lua_UnityEngine_EffectorSelection2D : LuaObject
{
	// Token: 0x060230AA RID: 143530 RVA: 0x00C22C14 File Offset: 0x00C20E14
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.EffectorSelection2D");
		LuaObject.addMember(l, 0, "Rigidbody");
		LuaObject.addMember(l, 1, "Collider");
		LuaDLL.lua_pop(l, 1);
	}
}
