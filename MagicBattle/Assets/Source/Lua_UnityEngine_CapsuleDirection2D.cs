using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001656 RID: 5718
[Preserve]
public class Lua_UnityEngine_CapsuleDirection2D : LuaObject
{
	// Token: 0x06022DEF RID: 142831 RVA: 0x00C0D92C File Offset: 0x00C0BB2C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.CapsuleDirection2D");
		LuaObject.addMember(l, 0, "Vertical");
		LuaObject.addMember(l, 1, "Horizontal");
		LuaDLL.lua_pop(l, 1);
	}
}
