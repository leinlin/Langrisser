using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017AA RID: 6058
[Preserve]
public class Lua_UnityEngine_RenderMode : LuaObject
{
	// Token: 0x06023B38 RID: 146232 RVA: 0x00C7E1C4 File Offset: 0x00C7C3C4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RenderMode");
		LuaObject.addMember(l, 0, "ScreenSpaceOverlay");
		LuaObject.addMember(l, 1, "ScreenSpaceCamera");
		LuaObject.addMember(l, 2, "WorldSpace");
		LuaDLL.lua_pop(l, 1);
	}
}
