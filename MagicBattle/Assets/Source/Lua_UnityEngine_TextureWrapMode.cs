using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017FE RID: 6142
[Preserve]
public class Lua_UnityEngine_TextureWrapMode : LuaObject
{
	// Token: 0x06023ED2 RID: 147154 RVA: 0x00C9A614 File Offset: 0x00C98814
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.TextureWrapMode");
		LuaObject.addMember(l, 0, "Repeat");
		LuaObject.addMember(l, 1, "Clamp");
		LuaObject.addMember(l, 2, "Mirror");
		LuaObject.addMember(l, 3, "MirrorOnce");
		LuaDLL.lua_pop(l, 1);
	}
}
