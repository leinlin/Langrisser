using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200163D RID: 5693
[Preserve]
public class Lua_UnityEngine_BatteryStatus : LuaObject
{
	// Token: 0x06022C39 RID: 142393 RVA: 0x00C009A4 File Offset: 0x00BFEBA4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.BatteryStatus");
		LuaObject.addMember(l, 0, "Unknown");
		LuaObject.addMember(l, 1, "Charging");
		LuaObject.addMember(l, 2, "Discharging");
		LuaObject.addMember(l, 3, "NotCharging");
		LuaObject.addMember(l, 4, "Full");
		LuaDLL.lua_pop(l, 1);
	}
}
