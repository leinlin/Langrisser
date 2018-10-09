using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001796 RID: 6038
[Preserve]
public class Lua_UnityEngine_Rendering_ReflectionProbeClearFlags : LuaObject
{
	// Token: 0x06023AFA RID: 146170 RVA: 0x00C7CC78 File Offset: 0x00C7AE78
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.ReflectionProbeClearFlags");
		LuaObject.addMember(l, 1, "Skybox");
		LuaObject.addMember(l, 2, "SolidColor");
		LuaDLL.lua_pop(l, 1);
	}
}
