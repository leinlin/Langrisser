using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200167D RID: 5757
[Preserve]
public class Lua_UnityEngine_CubemapFace : LuaObject
{
	// Token: 0x06022FF2 RID: 143346 RVA: 0x00C1D9E4 File Offset: 0x00C1BBE4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.CubemapFace");
		LuaObject.addMember(l, 0, "PositiveX");
		LuaObject.addMember(l, 1, "NegativeX");
		LuaObject.addMember(l, 2, "PositiveY");
		LuaObject.addMember(l, 3, "NegativeY");
		LuaObject.addMember(l, 4, "PositiveZ");
		LuaObject.addMember(l, 5, "NegativeZ");
		LuaObject.addMember(l, -1, "Unknown");
		LuaDLL.lua_pop(l, 1);
	}
}
