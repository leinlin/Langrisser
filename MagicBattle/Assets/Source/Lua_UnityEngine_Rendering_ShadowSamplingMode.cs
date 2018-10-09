using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017A2 RID: 6050
[Preserve]
public class Lua_UnityEngine_Rendering_ShadowSamplingMode : LuaObject
{
	// Token: 0x06023B15 RID: 146197 RVA: 0x00C7D560 File Offset: 0x00C7B760
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.ShadowSamplingMode");
		LuaObject.addMember(l, 0, "CompareDepths");
		LuaObject.addMember(l, 1, "RawDepth");
		LuaObject.addMember(l, 2, "None");
		LuaDLL.lua_pop(l, 1);
	}
}
