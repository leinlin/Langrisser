using System;
using SLua;
using UnityEngine.Diagnostics;
using UnityEngine.Scripting;

// Token: 0x0200168B RID: 5771
[Preserve]
public class Lua_UnityEngine_Diagnostics_PlayerConnection : LuaObject
{
	// Token: 0x06023069 RID: 143465 RVA: 0x00C212FC File Offset: 0x00C1F4FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Diagnostics.PlayerConnection");
		LuaObject.createTypeMetatable(l, null, typeof(PlayerConnection));
	}
}
