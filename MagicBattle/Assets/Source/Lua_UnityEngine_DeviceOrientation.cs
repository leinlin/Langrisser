using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001689 RID: 5769
[Preserve]
public class Lua_UnityEngine_DeviceOrientation : LuaObject
{
	// Token: 0x06023065 RID: 143461 RVA: 0x00C21228 File Offset: 0x00C1F428
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.DeviceOrientation");
		LuaObject.addMember(l, 0, "Unknown");
		LuaObject.addMember(l, 1, "Portrait");
		LuaObject.addMember(l, 2, "PortraitUpsideDown");
		LuaObject.addMember(l, 3, "LandscapeLeft");
		LuaObject.addMember(l, 4, "LandscapeRight");
		LuaObject.addMember(l, 5, "FaceUp");
		LuaObject.addMember(l, 6, "FaceDown");
		LuaDLL.lua_pop(l, 1);
	}
}
