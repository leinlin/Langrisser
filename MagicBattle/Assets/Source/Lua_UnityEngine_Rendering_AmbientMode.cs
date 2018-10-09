using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001779 RID: 6009
[Preserve]
public class Lua_UnityEngine_Rendering_AmbientMode : LuaObject
{
	// Token: 0x06023A6D RID: 146029 RVA: 0x00C76578 File Offset: 0x00C74778
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.AmbientMode");
		LuaObject.addMember(l, 0, "Skybox");
		LuaObject.addMember(l, 1, "Trilight");
		LuaObject.addMember(l, 3, "Flat");
		LuaObject.addMember(l, 4, "Custom");
		LuaDLL.lua_pop(l, 1);
	}
}
