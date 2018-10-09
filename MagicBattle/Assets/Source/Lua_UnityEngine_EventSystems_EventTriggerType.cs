using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016A6 RID: 5798
[Preserve]
public class Lua_UnityEngine_EventSystems_EventTriggerType : LuaObject
{
	// Token: 0x06023156 RID: 143702 RVA: 0x00C27324 File Offset: 0x00C25524
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.EventSystems.EventTriggerType");
		LuaObject.addMember(l, 0, "PointerEnter");
		LuaObject.addMember(l, 1, "PointerExit");
		LuaObject.addMember(l, 2, "PointerDown");
		LuaObject.addMember(l, 3, "PointerUp");
		LuaObject.addMember(l, 4, "PointerClick");
		LuaObject.addMember(l, 5, "Drag");
		LuaObject.addMember(l, 6, "Drop");
		LuaObject.addMember(l, 7, "Scroll");
		LuaObject.addMember(l, 8, "UpdateSelected");
		LuaObject.addMember(l, 9, "Select");
		LuaObject.addMember(l, 10, "Deselect");
		LuaObject.addMember(l, 11, "Move");
		LuaObject.addMember(l, 12, "InitializePotentialDrag");
		LuaObject.addMember(l, 13, "BeginDrag");
		LuaObject.addMember(l, 14, "EndDrag");
		LuaObject.addMember(l, 15, "Submit");
		LuaObject.addMember(l, 16, "Cancel");
		LuaDLL.lua_pop(l, 1);
	}
}
