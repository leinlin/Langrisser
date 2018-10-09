using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001638 RID: 5688
[Preserve]
public class Lua_UnityEngine_AvatarIKGoal : LuaObject
{
	// Token: 0x06022C24 RID: 142372 RVA: 0x00C00124 File Offset: 0x00BFE324
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AvatarIKGoal");
		LuaObject.addMember(l, 0, "LeftFoot");
		LuaObject.addMember(l, 1, "RightFoot");
		LuaObject.addMember(l, 2, "LeftHand");
		LuaObject.addMember(l, 3, "RightHand");
		LuaDLL.lua_pop(l, 1);
	}
}
