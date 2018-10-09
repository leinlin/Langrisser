using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017BE RID: 6078
[Preserve]
public class Lua_UnityEngine_RotationDriveMode : LuaObject
{
	// Token: 0x06023C8B RID: 146571 RVA: 0x00C890E0 File Offset: 0x00C872E0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RotationDriveMode");
		LuaObject.addMember(l, 0, "XYAndZ");
		LuaObject.addMember(l, 1, "Slerp");
		LuaDLL.lua_pop(l, 1);
	}
}
