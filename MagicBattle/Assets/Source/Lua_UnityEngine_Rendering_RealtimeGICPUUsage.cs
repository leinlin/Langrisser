using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001793 RID: 6035
[Preserve]
public class Lua_UnityEngine_Rendering_RealtimeGICPUUsage : LuaObject
{
	// Token: 0x06023AEF RID: 146159 RVA: 0x00C7C938 File Offset: 0x00C7AB38
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.RealtimeGICPUUsage");
		LuaObject.addMember(l, 25, "Low");
		LuaObject.addMember(l, 50, "Medium");
		LuaObject.addMember(l, 75, "High");
		LuaObject.addMember(l, 100, "Unlimited");
		LuaDLL.lua_pop(l, 1);
	}
}
