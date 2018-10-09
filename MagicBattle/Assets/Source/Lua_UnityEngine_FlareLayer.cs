using System;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016CA RID: 5834
[Preserve]
public class Lua_UnityEngine_FlareLayer : LuaObject
{
	// Token: 0x06023226 RID: 143910 RVA: 0x00C2BC78 File Offset: 0x00C29E78
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.FlareLayer");
		LuaObject.createTypeMetatable(l, null, typeof(FlareLayer), typeof(Behaviour));
	}
}
