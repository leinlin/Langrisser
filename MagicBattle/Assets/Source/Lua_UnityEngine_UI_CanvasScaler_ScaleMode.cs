using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001810 RID: 6160
[Preserve]
public class Lua_UnityEngine_UI_CanvasScaler_ScaleMode : LuaObject
{
	// Token: 0x06023FB0 RID: 147376 RVA: 0x00CA0D30 File Offset: 0x00C9EF30
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.CanvasScaler.ScaleMode");
		LuaObject.addMember(l, 0, "ConstantPixelSize");
		LuaObject.addMember(l, 1, "ScaleWithScreenSize");
		LuaObject.addMember(l, 2, "ConstantPhysicalSize");
		LuaDLL.lua_pop(l, 1);
	}
}
