using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001842 RID: 6210
[Preserve]
public class Lua_UnityEngine_UI_InputField_InputType : LuaObject
{
	// Token: 0x06024166 RID: 147814 RVA: 0x00CABBD8 File Offset: 0x00CA9DD8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.InputField.InputType");
		LuaObject.addMember(l, 0, "Standard");
		LuaObject.addMember(l, 1, "AutoCorrect");
		LuaObject.addMember(l, 2, "Password");
		LuaDLL.lua_pop(l, 1);
	}
}
