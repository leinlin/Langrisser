using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017EE RID: 6126
[Preserve]
public class Lua_UnityEngine_StereoTargetEyeMask : LuaObject
{
	// Token: 0x06023DE2 RID: 146914 RVA: 0x00C92BE0 File Offset: 0x00C90DE0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.StereoTargetEyeMask");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Left");
		LuaObject.addMember(l, 2, "Right");
		LuaObject.addMember(l, 3, "Both");
		LuaDLL.lua_pop(l, 1);
	}
}
