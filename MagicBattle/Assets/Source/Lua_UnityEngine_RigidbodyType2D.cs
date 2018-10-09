using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017BD RID: 6077
[Preserve]
public class Lua_UnityEngine_RigidbodyType2D : LuaObject
{
	// Token: 0x06023C89 RID: 146569 RVA: 0x00C890A0 File Offset: 0x00C872A0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RigidbodyType2D");
		LuaObject.addMember(l, 0, "Dynamic");
		LuaObject.addMember(l, 1, "Kinematic");
		LuaObject.addMember(l, 2, "Static");
		LuaDLL.lua_pop(l, 1);
	}
}
