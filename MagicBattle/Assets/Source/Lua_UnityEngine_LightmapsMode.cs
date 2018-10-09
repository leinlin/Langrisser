using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200170A RID: 5898
[Preserve]
public class Lua_UnityEngine_LightmapsMode : LuaObject
{
	// Token: 0x060234BC RID: 144572 RVA: 0x00C42228 File Offset: 0x00C40428
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LightmapsMode");
		LuaObject.addMember(l, 0, "Single");
		LuaObject.addMember(l, 0, "NonDirectional");
		LuaObject.addMember(l, 1, "Dual");
		LuaObject.addMember(l, 1, "CombinedDirectional");
		LuaObject.addMember(l, 2, "Directional");
		LuaObject.addMember(l, 2, "SeparateDirectional");
		LuaDLL.lua_pop(l, 1);
	}
}
