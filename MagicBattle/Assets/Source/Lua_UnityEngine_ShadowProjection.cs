using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017CF RID: 6095
[Preserve]
public class Lua_UnityEngine_ShadowProjection : LuaObject
{
	// Token: 0x06023D09 RID: 146697 RVA: 0x00C8D24C File Offset: 0x00C8B44C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ShadowProjection");
		LuaObject.addMember(l, 0, "CloseFit");
		LuaObject.addMember(l, 1, "StableFit");
		LuaDLL.lua_pop(l, 1);
	}
}
