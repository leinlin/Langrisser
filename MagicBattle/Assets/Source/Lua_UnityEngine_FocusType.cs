using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016CB RID: 5835
[Preserve]
public class Lua_UnityEngine_FocusType : LuaObject
{
	// Token: 0x06023228 RID: 143912 RVA: 0x00C2BCA8 File Offset: 0x00C29EA8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.FocusType");
		LuaObject.addMember(l, 0, "Native");
		LuaObject.addMember(l, 1, "Keyboard");
		LuaObject.addMember(l, 2, "Passive");
		LuaDLL.lua_pop(l, 1);
	}
}
