using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001772 RID: 6002
[Preserve]
public class Lua_UnityEngine_RectTransform_Edge : LuaObject
{
	// Token: 0x060239E5 RID: 145893 RVA: 0x00C727D8 File Offset: 0x00C709D8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RectTransform.Edge");
		LuaObject.addMember(l, 0, "Left");
		LuaObject.addMember(l, 1, "Right");
		LuaObject.addMember(l, 2, "Top");
		LuaObject.addMember(l, 3, "Bottom");
		LuaDLL.lua_pop(l, 1);
	}
}
