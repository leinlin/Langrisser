using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001872 RID: 6258
[Preserve]
public class Lua_UnityEngine_UserAuthorization : LuaObject
{
	// Token: 0x06024355 RID: 148309 RVA: 0x00CB87B4 File Offset: 0x00CB69B4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UserAuthorization");
		LuaObject.addMember(l, 1, "WebCam");
		LuaObject.addMember(l, 2, "Microphone");
		LuaDLL.lua_pop(l, 1);
	}
}
