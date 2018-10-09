using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001827 RID: 6183
[Preserve]
public class Lua_UnityEngine_UI_GridLayoutGroup_Axis : LuaObject
{
	// Token: 0x06024096 RID: 147606 RVA: 0x00CA6BAC File Offset: 0x00CA4DAC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.GridLayoutGroup.Axis");
		LuaObject.addMember(l, 0, "Horizontal");
		LuaObject.addMember(l, 1, "Vertical");
		LuaDLL.lua_pop(l, 1);
	}
}
