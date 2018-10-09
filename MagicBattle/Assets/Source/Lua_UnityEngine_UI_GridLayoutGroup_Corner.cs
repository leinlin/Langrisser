using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001829 RID: 6185
[Preserve]
public class Lua_UnityEngine_UI_GridLayoutGroup_Corner : LuaObject
{
	// Token: 0x0602409A RID: 147610 RVA: 0x00CA6C20 File Offset: 0x00CA4E20
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.GridLayoutGroup.Corner");
		LuaObject.addMember(l, 0, "UpperLeft");
		LuaObject.addMember(l, 1, "UpperRight");
		LuaObject.addMember(l, 2, "LowerLeft");
		LuaObject.addMember(l, 3, "LowerRight");
		LuaDLL.lua_pop(l, 1);
	}
}
