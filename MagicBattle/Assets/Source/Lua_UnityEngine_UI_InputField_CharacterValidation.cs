using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001840 RID: 6208
[Preserve]
public class Lua_UnityEngine_UI_InputField_CharacterValidation : LuaObject
{
	// Token: 0x06024162 RID: 147810 RVA: 0x00CABAC8 File Offset: 0x00CA9CC8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.InputField.CharacterValidation");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Integer");
		LuaObject.addMember(l, 2, "Decimal");
		LuaObject.addMember(l, 3, "Alphanumeric");
		LuaObject.addMember(l, 4, "Name");
		LuaObject.addMember(l, 5, "EmailAddress");
		LuaDLL.lua_pop(l, 1);
	}
}
