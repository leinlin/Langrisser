using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017BA RID: 6074
[Preserve]
public class Lua_UnityEngine_RigidbodyInterpolation : LuaObject
{
	// Token: 0x06023C83 RID: 146563 RVA: 0x00C88FE0 File Offset: 0x00C871E0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RigidbodyInterpolation");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Interpolate");
		LuaObject.addMember(l, 2, "Extrapolate");
		LuaDLL.lua_pop(l, 1);
	}
}
