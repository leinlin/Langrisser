using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001764 RID: 5988
[Preserve]
public class Lua_UnityEngine_QueryTriggerInteraction : LuaObject
{
	// Token: 0x06023926 RID: 145702 RVA: 0x00C6CEF4 File Offset: 0x00C6B0F4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.QueryTriggerInteraction");
		LuaObject.addMember(l, 0, "UseGlobal");
		LuaObject.addMember(l, 1, "Ignore");
		LuaObject.addMember(l, 2, "Collide");
		LuaDLL.lua_pop(l, 1);
	}
}
