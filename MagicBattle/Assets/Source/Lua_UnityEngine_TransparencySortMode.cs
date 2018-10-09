using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001806 RID: 6150
[Preserve]
public class Lua_UnityEngine_TransparencySortMode : LuaObject
{
	// Token: 0x06023F6D RID: 147309 RVA: 0x00C9F3A4 File Offset: 0x00C9D5A4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.TransparencySortMode");
		LuaObject.addMember(l, 0, "Default");
		LuaObject.addMember(l, 1, "Perspective");
		LuaObject.addMember(l, 2, "Orthographic");
		LuaObject.addMember(l, 3, "CustomAxis");
		LuaDLL.lua_pop(l, 1);
	}
}
