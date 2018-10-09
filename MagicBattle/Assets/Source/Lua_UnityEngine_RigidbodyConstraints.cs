using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017B8 RID: 6072
[Preserve]
public class Lua_UnityEngine_RigidbodyConstraints : LuaObject
{
	// Token: 0x06023C7F RID: 146559 RVA: 0x00C88EC8 File Offset: 0x00C870C8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RigidbodyConstraints");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 2, "FreezePositionX");
		LuaObject.addMember(l, 4, "FreezePositionY");
		LuaObject.addMember(l, 8, "FreezePositionZ");
		LuaObject.addMember(l, 14, "FreezePosition");
		LuaObject.addMember(l, 16, "FreezeRotationX");
		LuaObject.addMember(l, 32, "FreezeRotationY");
		LuaObject.addMember(l, 64, "FreezeRotationZ");
		LuaObject.addMember(l, 112, "FreezeRotation");
		LuaObject.addMember(l, 126, "FreezeAll");
		LuaDLL.lua_pop(l, 1);
	}
}
