using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200179C RID: 6044
[Preserve]
public class Lua_UnityEngine_Rendering_RenderBufferLoadAction : LuaObject
{
	// Token: 0x06023B06 RID: 146182 RVA: 0x00C7CDF8 File Offset: 0x00C7AFF8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.RenderBufferLoadAction");
		LuaObject.addMember(l, 0, "Load");
		LuaObject.addMember(l, 1, "Clear");
		LuaObject.addMember(l, 2, "DontCare");
		LuaDLL.lua_pop(l, 1);
	}
}
