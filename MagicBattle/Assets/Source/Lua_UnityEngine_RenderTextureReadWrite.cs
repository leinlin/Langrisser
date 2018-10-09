using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017B2 RID: 6066
[Preserve]
public class Lua_UnityEngine_RenderTextureReadWrite : LuaObject
{
	// Token: 0x06023BDE RID: 146398 RVA: 0x00C83550 File Offset: 0x00C81750
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RenderTextureReadWrite");
		LuaObject.addMember(l, 0, "Default");
		LuaObject.addMember(l, 1, "Linear");
		LuaObject.addMember(l, 2, "sRGB");
		LuaDLL.lua_pop(l, 1);
	}
}
