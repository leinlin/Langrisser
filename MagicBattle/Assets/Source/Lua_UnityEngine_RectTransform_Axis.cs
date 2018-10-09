using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001771 RID: 6001
[Preserve]
public class Lua_UnityEngine_RectTransform_Axis : LuaObject
{
	// Token: 0x060239E3 RID: 145891 RVA: 0x00C727A4 File Offset: 0x00C709A4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RectTransform.Axis");
		LuaObject.addMember(l, 0, "Horizontal");
		LuaObject.addMember(l, 1, "Vertical");
		LuaDLL.lua_pop(l, 1);
	}
}
