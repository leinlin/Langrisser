using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001782 RID: 6018
[Preserve]
public class Lua_UnityEngine_Rendering_ColorWriteMask : LuaObject
{
	// Token: 0x06023A7F RID: 146047 RVA: 0x00C76D90 File Offset: 0x00C74F90
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.ColorWriteMask");
		LuaObject.addMember(l, 1, "Alpha");
		LuaObject.addMember(l, 2, "Blue");
		LuaObject.addMember(l, 4, "Green");
		LuaObject.addMember(l, 8, "Red");
		LuaObject.addMember(l, 15, "All");
		LuaDLL.lua_pop(l, 1);
	}
}
