using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001639 RID: 5689
[Preserve]
public class Lua_UnityEngine_AvatarIKHint : LuaObject
{
	// Token: 0x06022C26 RID: 142374 RVA: 0x00C0017C File Offset: 0x00BFE37C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AvatarIKHint");
		LuaObject.addMember(l, 0, "LeftKnee");
		LuaObject.addMember(l, 1, "RightKnee");
		LuaObject.addMember(l, 2, "LeftElbow");
		LuaObject.addMember(l, 3, "RightElbow");
		LuaDLL.lua_pop(l, 1);
	}
}
