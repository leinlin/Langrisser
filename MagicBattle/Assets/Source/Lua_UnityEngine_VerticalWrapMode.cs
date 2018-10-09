using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001878 RID: 6264
[Preserve]
public class Lua_UnityEngine_VerticalWrapMode : LuaObject
{
	// Token: 0x0602442F RID: 148527 RVA: 0x00CBF6F8 File Offset: 0x00CBD8F8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.VerticalWrapMode");
		LuaObject.addMember(l, 0, "Truncate");
		LuaObject.addMember(l, 1, "Overflow");
		LuaDLL.lua_pop(l, 1);
	}
}
