using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200179D RID: 6045
[Preserve]
public class Lua_UnityEngine_Rendering_RenderBufferStoreAction : LuaObject
{
	// Token: 0x06023B08 RID: 146184 RVA: 0x00C7CE38 File Offset: 0x00C7B038
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.RenderBufferStoreAction");
		LuaObject.addMember(l, 0, "Store");
		LuaObject.addMember(l, 1, "Resolve");
		LuaObject.addMember(l, 2, "StoreAndResolve");
		LuaObject.addMember(l, 3, "DontCare");
		LuaDLL.lua_pop(l, 1);
	}
}
