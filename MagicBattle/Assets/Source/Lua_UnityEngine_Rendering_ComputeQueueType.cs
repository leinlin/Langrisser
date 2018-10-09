using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001785 RID: 6021
[Preserve]
public class Lua_UnityEngine_Rendering_ComputeQueueType : LuaObject
{
	// Token: 0x06023AC1 RID: 146113 RVA: 0x00C7BBB0 File Offset: 0x00C79DB0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.ComputeQueueType");
		LuaObject.addMember(l, 0, "Default");
		LuaObject.addMember(l, 1, "Background");
		LuaObject.addMember(l, 2, "Urgent");
		LuaDLL.lua_pop(l, 1);
	}
}
