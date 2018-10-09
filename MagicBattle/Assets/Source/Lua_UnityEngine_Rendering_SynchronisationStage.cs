using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017A7 RID: 6055
[Preserve]
public class Lua_UnityEngine_Rendering_SynchronisationStage : LuaObject
{
	// Token: 0x06023B32 RID: 146226 RVA: 0x00C7E0A4 File Offset: 0x00C7C2A4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.SynchronisationStage");
		LuaObject.addMember(l, 0, "VertexProcessing");
		LuaObject.addMember(l, 1, "PixelProcessing");
		LuaDLL.lua_pop(l, 1);
	}
}
