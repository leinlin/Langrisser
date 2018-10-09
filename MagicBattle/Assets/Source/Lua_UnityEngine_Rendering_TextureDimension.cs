using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017A8 RID: 6056
[Preserve]
public class Lua_UnityEngine_Rendering_TextureDimension : LuaObject
{
	// Token: 0x06023B34 RID: 146228 RVA: 0x00C7E0D8 File Offset: 0x00C7C2D8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.TextureDimension");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Any");
		LuaObject.addMember(l, 2, "Tex2D");
		LuaObject.addMember(l, 3, "Tex3D");
		LuaObject.addMember(l, 4, "Cube");
		LuaObject.addMember(l, 5, "Tex2DArray");
		LuaObject.addMember(l, 6, "CubeArray");
		LuaObject.addMember(l, -1, "Unknown");
		LuaDLL.lua_pop(l, 1);
	}
}
