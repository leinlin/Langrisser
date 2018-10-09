using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200163B RID: 5691
[Preserve]
public class Lua_UnityEngine_AvatarMaskBodyPart : LuaObject
{
	// Token: 0x06022C35 RID: 142389 RVA: 0x00C00860 File Offset: 0x00BFEA60
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AvatarMaskBodyPart");
		LuaObject.addMember(l, 0, "Root");
		LuaObject.addMember(l, 1, "Body");
		LuaObject.addMember(l, 2, "Head");
		LuaObject.addMember(l, 3, "LeftLeg");
		LuaObject.addMember(l, 4, "RightLeg");
		LuaObject.addMember(l, 5, "LeftArm");
		LuaObject.addMember(l, 6, "RightArm");
		LuaObject.addMember(l, 7, "LeftFingers");
		LuaObject.addMember(l, 8, "RightFingers");
		LuaObject.addMember(l, 9, "LeftFootIK");
		LuaObject.addMember(l, 10, "RightFootIK");
		LuaObject.addMember(l, 11, "LeftHandIK");
		LuaObject.addMember(l, 12, "RightHandIK");
		LuaObject.addMember(l, 13, "LastBodyPart");
		LuaDLL.lua_pop(l, 1);
	}
}
