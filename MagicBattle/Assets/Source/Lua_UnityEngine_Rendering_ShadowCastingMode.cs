using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017A0 RID: 6048
[Preserve]
public class Lua_UnityEngine_Rendering_ShadowCastingMode : LuaObject
{
	// Token: 0x06023B11 RID: 146193 RVA: 0x00C7D41C File Offset: 0x00C7B61C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.ShadowCastingMode");
		LuaObject.addMember(l, 0, "Off");
		LuaObject.addMember(l, 1, "On");
		LuaObject.addMember(l, 2, "TwoSided");
		LuaObject.addMember(l, 3, "ShadowsOnly");
		LuaDLL.lua_pop(l, 1);
	}
}
