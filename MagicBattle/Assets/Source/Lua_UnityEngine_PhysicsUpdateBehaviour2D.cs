using System;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200173C RID: 5948
[Preserve]
public class Lua_UnityEngine_PhysicsUpdateBehaviour2D : LuaObject
{
	// Token: 0x06023794 RID: 145300 RVA: 0x00C624C8 File Offset: 0x00C606C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.PhysicsUpdateBehaviour2D");
		LuaObject.createTypeMetatable(l, null, typeof(PhysicsUpdateBehaviour2D), typeof(Behaviour));
	}
}
