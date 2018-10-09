using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016BE RID: 5822
[Preserve]
public class Lua_UnityEngine_EventSystems_PointerEventData_FramePressState : LuaObject
{
	// Token: 0x060231CE RID: 143822 RVA: 0x00C29B68 File Offset: 0x00C27D68
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.EventSystems.PointerEventData.FramePressState");
		LuaObject.addMember(l, 0, "Pressed");
		LuaObject.addMember(l, 1, "Released");
		LuaObject.addMember(l, 2, "PressedAndReleased");
		LuaObject.addMember(l, 3, "NotChanged");
		LuaDLL.lua_pop(l, 1);
	}
}
