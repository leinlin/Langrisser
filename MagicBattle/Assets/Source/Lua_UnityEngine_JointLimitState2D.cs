using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016FA RID: 5882
[Preserve]
public class Lua_UnityEngine_JointLimitState2D : LuaObject
{
	// Token: 0x0602341C RID: 144412 RVA: 0x00C3CCF0 File Offset: 0x00C3AEF0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.JointLimitState2D");
		LuaObject.addMember(l, 0, "Inactive");
		LuaObject.addMember(l, 1, "LowerLimit");
		LuaObject.addMember(l, 2, "UpperLimit");
		LuaObject.addMember(l, 3, "EqualLimits");
		LuaDLL.lua_pop(l, 1);
	}
}
