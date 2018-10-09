using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001841 RID: 6209
[Preserve]
public class Lua_UnityEngine_UI_InputField_ContentType : LuaObject
{
	// Token: 0x06024164 RID: 147812 RVA: 0x00CABB38 File Offset: 0x00CA9D38
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.InputField.ContentType");
		LuaObject.addMember(l, 0, "Standard");
		LuaObject.addMember(l, 1, "Autocorrected");
		LuaObject.addMember(l, 2, "IntegerNumber");
		LuaObject.addMember(l, 3, "DecimalNumber");
		LuaObject.addMember(l, 4, "Alphanumeric");
		LuaObject.addMember(l, 5, "Name");
		LuaObject.addMember(l, 6, "EmailAddress");
		LuaObject.addMember(l, 7, "Password");
		LuaObject.addMember(l, 8, "Pin");
		LuaObject.addMember(l, 9, "Custom");
		LuaDLL.lua_pop(l, 1);
	}
}
