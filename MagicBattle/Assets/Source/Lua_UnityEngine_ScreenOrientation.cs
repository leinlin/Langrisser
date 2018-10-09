using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017C9 RID: 6089
[Preserve]
public class Lua_UnityEngine_ScreenOrientation : LuaObject
{
	// Token: 0x06023CD8 RID: 146648 RVA: 0x00C8B1B0 File Offset: 0x00C893B0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ScreenOrientation");
		LuaObject.addMember(l, 0, "Unknown");
		LuaObject.addMember(l, 1, "Portrait");
		LuaObject.addMember(l, 2, "PortraitUpsideDown");
		LuaObject.addMember(l, 3, "Landscape");
		LuaObject.addMember(l, 3, "LandscapeLeft");
		LuaObject.addMember(l, 4, "LandscapeRight");
		LuaObject.addMember(l, 5, "AutoRotation");
		LuaDLL.lua_pop(l, 1);
	}
}
