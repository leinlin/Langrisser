using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200166E RID: 5742
[Preserve]
public class Lua_UnityEngine_CompositeCollider2D_GenerationType : LuaObject
{
	// Token: 0x06022F14 RID: 143124 RVA: 0x00C167F0 File Offset: 0x00C149F0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.CompositeCollider2D.GenerationType");
		LuaObject.addMember(l, 0, "Synchronous");
		LuaObject.addMember(l, 1, "Manual");
		LuaDLL.lua_pop(l, 1);
	}
}
