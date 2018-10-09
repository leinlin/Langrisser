using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001824 RID: 6180
[Preserve]
public class Lua_UnityEngine_UI_GraphicRaycaster_BlockingObjects : LuaObject
{
	// Token: 0x0602407C RID: 147580 RVA: 0x00CA61A0 File Offset: 0x00CA43A0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.GraphicRaycaster.BlockingObjects");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "TwoD");
		LuaObject.addMember(l, 2, "ThreeD");
		LuaObject.addMember(l, 3, "All");
		LuaDLL.lua_pop(l, 1);
	}
}
