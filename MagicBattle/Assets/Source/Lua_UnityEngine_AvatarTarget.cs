using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200163C RID: 5692
[Preserve]
public class Lua_UnityEngine_AvatarTarget : LuaObject
{
	// Token: 0x06022C37 RID: 142391 RVA: 0x00C00934 File Offset: 0x00BFEB34
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AvatarTarget");
		LuaObject.addMember(l, 0, "Root");
		LuaObject.addMember(l, 1, "Body");
		LuaObject.addMember(l, 2, "LeftFoot");
		LuaObject.addMember(l, 3, "RightFoot");
		LuaObject.addMember(l, 4, "LeftHand");
		LuaObject.addMember(l, 5, "RightHand");
		LuaDLL.lua_pop(l, 1);
	}
}
