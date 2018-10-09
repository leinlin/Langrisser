using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017CE RID: 6094
[Preserve]
public class Lua_UnityEngine_ShadowmaskMode : LuaObject
{
	// Token: 0x06023D07 RID: 146695 RVA: 0x00C8D218 File Offset: 0x00C8B418
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ShadowmaskMode");
		LuaObject.addMember(l, 0, "Shadowmask");
		LuaObject.addMember(l, 1, "DistanceShadowmask");
		LuaDLL.lua_pop(l, 1);
	}
}
