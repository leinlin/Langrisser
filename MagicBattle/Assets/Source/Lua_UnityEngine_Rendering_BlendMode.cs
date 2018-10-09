using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200177A RID: 6010
[Preserve]
public class Lua_UnityEngine_Rendering_BlendMode : LuaObject
{
	// Token: 0x06023A6F RID: 146031 RVA: 0x00C765D0 File Offset: 0x00C747D0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.BlendMode");
		LuaObject.addMember(l, 0, "Zero");
		LuaObject.addMember(l, 1, "One");
		LuaObject.addMember(l, 2, "DstColor");
		LuaObject.addMember(l, 3, "SrcColor");
		LuaObject.addMember(l, 4, "OneMinusDstColor");
		LuaObject.addMember(l, 5, "SrcAlpha");
		LuaObject.addMember(l, 6, "OneMinusSrcColor");
		LuaObject.addMember(l, 7, "DstAlpha");
		LuaObject.addMember(l, 8, "OneMinusDstAlpha");
		LuaObject.addMember(l, 9, "SrcAlphaSaturate");
		LuaObject.addMember(l, 10, "OneMinusSrcAlpha");
		LuaDLL.lua_pop(l, 1);
	}
}
