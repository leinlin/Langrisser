using System;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016AE RID: 5806
[Preserve]
public class Lua_UnityEngine_EventSystems_IEventSystemHandler : LuaObject
{
	// Token: 0x06023170 RID: 143728 RVA: 0x00C27A70 File Offset: 0x00C25C70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IEventSystemHandler");
		LuaObject.createTypeMetatable(l, null, typeof(IEventSystemHandler));
	}
}
