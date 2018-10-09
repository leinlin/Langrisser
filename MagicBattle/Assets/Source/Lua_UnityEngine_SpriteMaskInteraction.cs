using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017E3 RID: 6115
[Preserve]
public class Lua_UnityEngine_SpriteMaskInteraction : LuaObject
{
	// Token: 0x06023DAA RID: 146858 RVA: 0x00C91520 File Offset: 0x00C8F720
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.SpriteMaskInteraction");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "VisibleInsideMask");
		LuaObject.addMember(l, 2, "VisibleOutsideMask");
		LuaDLL.lua_pop(l, 1);
	}
}
