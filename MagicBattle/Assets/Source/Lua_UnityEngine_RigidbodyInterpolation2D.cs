using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017BB RID: 6075
[Preserve]
public class Lua_UnityEngine_RigidbodyInterpolation2D : LuaObject
{
	// Token: 0x06023C85 RID: 146565 RVA: 0x00C89020 File Offset: 0x00C87220
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RigidbodyInterpolation2D");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Interpolate");
		LuaObject.addMember(l, 2, "Extrapolate");
		LuaDLL.lua_pop(l, 1);
	}
}
