using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001828 RID: 6184
[Preserve]
public class Lua_UnityEngine_UI_GridLayoutGroup_Constraint : LuaObject
{
	// Token: 0x06024098 RID: 147608 RVA: 0x00CA6BE0 File Offset: 0x00CA4DE0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.GridLayoutGroup.Constraint");
		LuaObject.addMember(l, 0, "Flexible");
		LuaObject.addMember(l, 1, "FixedColumnCount");
		LuaObject.addMember(l, 2, "FixedRowCount");
		LuaDLL.lua_pop(l, 1);
	}
}
