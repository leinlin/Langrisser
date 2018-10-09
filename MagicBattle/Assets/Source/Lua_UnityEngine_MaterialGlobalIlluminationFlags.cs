using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001724 RID: 5924
[Preserve]
public class Lua_UnityEngine_MaterialGlobalIlluminationFlags : LuaObject
{
	// Token: 0x060235A8 RID: 144808 RVA: 0x00C49F7C File Offset: 0x00C4817C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.MaterialGlobalIlluminationFlags");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "RealtimeEmissive");
		LuaObject.addMember(l, 2, "BakedEmissive");
		LuaObject.addMember(l, 3, "AnyEmissive");
		LuaObject.addMember(l, 4, "EmissiveIsBlack");
		LuaDLL.lua_pop(l, 1);
	}
}
