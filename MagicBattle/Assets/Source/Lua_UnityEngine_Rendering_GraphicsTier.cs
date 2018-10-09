using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200178C RID: 6028
[Preserve]
public class Lua_UnityEngine_Rendering_GraphicsTier : LuaObject
{
	// Token: 0x06023AE1 RID: 146145 RVA: 0x00C7C6B4 File Offset: 0x00C7A8B4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.GraphicsTier");
		LuaObject.addMember(l, 0, "Tier1");
		LuaObject.addMember(l, 1, "Tier2");
		LuaObject.addMember(l, 2, "Tier3");
		LuaDLL.lua_pop(l, 1);
	}
}
