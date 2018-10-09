using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017F4 RID: 6132
[Preserve]
public class Lua_UnityEngine_TextAnchor : LuaObject
{
	// Token: 0x06023E3C RID: 147004 RVA: 0x00C95314 File Offset: 0x00C93514
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.TextAnchor");
		LuaObject.addMember(l, 0, "UpperLeft");
		LuaObject.addMember(l, 1, "UpperCenter");
		LuaObject.addMember(l, 2, "UpperRight");
		LuaObject.addMember(l, 3, "MiddleLeft");
		LuaObject.addMember(l, 4, "MiddleCenter");
		LuaObject.addMember(l, 5, "MiddleRight");
		LuaObject.addMember(l, 6, "LowerLeft");
		LuaObject.addMember(l, 7, "LowerCenter");
		LuaObject.addMember(l, 8, "LowerRight");
		LuaDLL.lua_pop(l, 1);
	}
}
