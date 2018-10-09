using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200170B RID: 5899
[Preserve]
public class Lua_UnityEngine_LightmapsModeLegacy : LuaObject
{
	// Token: 0x060234BE RID: 144574 RVA: 0x00C42298 File Offset: 0x00C40498
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LightmapsModeLegacy");
		LuaObject.addMember(l, 0, "Single");
		LuaObject.addMember(l, 1, "Dual");
		LuaObject.addMember(l, 2, "Directional");
		LuaDLL.lua_pop(l, 1);
	}
}
