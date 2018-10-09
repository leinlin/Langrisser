using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001650 RID: 5712
[Preserve]
public class Lua_UnityEngine_CameraType : LuaObject
{
	// Token: 0x06022D8D RID: 142733 RVA: 0x00C0AA88 File Offset: 0x00C08C88
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.CameraType");
		LuaObject.addMember(l, 1, "Game");
		LuaObject.addMember(l, 2, "SceneView");
		LuaObject.addMember(l, 4, "Preview");
		LuaObject.addMember(l, 8, "VR");
		LuaObject.addMember(l, 16, "Reflection");
		LuaDLL.lua_pop(l, 1);
	}
}
