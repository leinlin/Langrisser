using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001688 RID: 5768
[Preserve]
public class Lua_UnityEngine_DepthTextureMode : LuaObject
{
	// Token: 0x06023063 RID: 143459 RVA: 0x00C211D0 File Offset: 0x00C1F3D0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.DepthTextureMode");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Depth");
		LuaObject.addMember(l, 2, "DepthNormals");
		LuaObject.addMember(l, 4, "MotionVectors");
		LuaDLL.lua_pop(l, 1);
	}
}
