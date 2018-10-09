using System;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016C7 RID: 5831
[Preserve]
public class Lua_UnityEngine_FixedJoint : LuaObject
{
	// Token: 0x0602321A RID: 143898 RVA: 0x00C2B908 File Offset: 0x00C29B08
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.FixedJoint");
		LuaObject.createTypeMetatable(l, null, typeof(FixedJoint), typeof(Joint));
	}
}
