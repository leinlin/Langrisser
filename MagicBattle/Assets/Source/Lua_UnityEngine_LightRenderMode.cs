using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001713 RID: 5907
[Preserve]
public class Lua_UnityEngine_LightRenderMode : LuaObject
{
	// Token: 0x060234EE RID: 144622 RVA: 0x00C4339C File Offset: 0x00C4159C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LightRenderMode");
		LuaObject.addMember(l, 0, "Auto");
		LuaObject.addMember(l, 1, "ForcePixel");
		LuaObject.addMember(l, 2, "ForceVertex");
		LuaDLL.lua_pop(l, 1);
	}
}
