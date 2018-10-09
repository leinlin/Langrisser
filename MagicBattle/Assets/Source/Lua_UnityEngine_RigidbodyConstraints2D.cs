using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017B9 RID: 6073
[Preserve]
public class Lua_UnityEngine_RigidbodyConstraints2D : LuaObject
{
	// Token: 0x06023C81 RID: 146561 RVA: 0x00C88F70 File Offset: 0x00C87170
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RigidbodyConstraints2D");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "FreezePositionX");
		LuaObject.addMember(l, 2, "FreezePositionY");
		LuaObject.addMember(l, 3, "FreezePosition");
		LuaObject.addMember(l, 4, "FreezeRotation");
		LuaObject.addMember(l, 7, "FreezeAll");
		LuaDLL.lua_pop(l, 1);
	}
}
