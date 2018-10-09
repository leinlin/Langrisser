using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001812 RID: 6162
[Preserve]
public class Lua_UnityEngine_UI_CanvasScaler_Unit : LuaObject
{
	// Token: 0x06023FB4 RID: 147380 RVA: 0x00CA0DB0 File Offset: 0x00C9EFB0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.CanvasScaler.Unit");
		LuaObject.addMember(l, 0, "Centimeters");
		LuaObject.addMember(l, 1, "Millimeters");
		LuaObject.addMember(l, 2, "Inches");
		LuaObject.addMember(l, 3, "Points");
		LuaObject.addMember(l, 4, "Picas");
		LuaDLL.lua_pop(l, 1);
	}
}
