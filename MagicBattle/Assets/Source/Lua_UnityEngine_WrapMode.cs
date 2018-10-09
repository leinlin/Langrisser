using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001882 RID: 6274
[Preserve]
public class Lua_UnityEngine_WrapMode : LuaObject
{
	// Token: 0x06024462 RID: 148578 RVA: 0x00CC0814 File Offset: 0x00CBEA14
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.WrapMode");
		LuaObject.addMember(l, 0, "Default");
		LuaObject.addMember(l, 1, "Clamp");
		LuaObject.addMember(l, 1, "Once");
		LuaObject.addMember(l, 2, "Loop");
		LuaObject.addMember(l, 4, "PingPong");
		LuaObject.addMember(l, 8, "ClampForever");
		LuaDLL.lua_pop(l, 1);
	}
}
