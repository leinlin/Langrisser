using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017A6 RID: 6054
[Preserve]
public class Lua_UnityEngine_Rendering_StencilOp : LuaObject
{
	// Token: 0x06023B30 RID: 146224 RVA: 0x00C7E01C File Offset: 0x00C7C21C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.StencilOp");
		LuaObject.addMember(l, 0, "Keep");
		LuaObject.addMember(l, 1, "Zero");
		LuaObject.addMember(l, 2, "Replace");
		LuaObject.addMember(l, 3, "IncrementSaturate");
		LuaObject.addMember(l, 4, "DecrementSaturate");
		LuaObject.addMember(l, 5, "Invert");
		LuaObject.addMember(l, 6, "IncrementWrap");
		LuaObject.addMember(l, 7, "DecrementWrap");
		LuaDLL.lua_pop(l, 1);
	}
}
