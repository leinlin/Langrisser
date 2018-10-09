using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001879 RID: 6265
[Preserve]
public class Lua_UnityEngine_VRTextureUsage : LuaObject
{
	// Token: 0x06024431 RID: 148529 RVA: 0x00CBF72C File Offset: 0x00CBD92C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.VRTextureUsage");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "OneEye");
		LuaObject.addMember(l, 2, "TwoEyes");
		LuaDLL.lua_pop(l, 1);
	}
}
