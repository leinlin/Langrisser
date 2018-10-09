using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016FD RID: 5885
[Preserve]
public class Lua_UnityEngine_JointProjectionMode : LuaObject
{
	// Token: 0x0602342E RID: 144430 RVA: 0x00C3D390 File Offset: 0x00C3B590
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.JointProjectionMode");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "PositionAndRotation");
		LuaObject.addMember(l, 2, "PositionOnly");
		LuaDLL.lua_pop(l, 1);
	}
}
