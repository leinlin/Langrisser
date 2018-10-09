using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001843 RID: 6211
[Preserve]
public class Lua_UnityEngine_UI_InputField_LineType : LuaObject
{
	// Token: 0x06024168 RID: 147816 RVA: 0x00CABC18 File Offset: 0x00CA9E18
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.InputField.LineType");
		LuaObject.addMember(l, 0, "SingleLine");
		LuaObject.addMember(l, 1, "MultiLineSubmit");
		LuaObject.addMember(l, 2, "MultiLineNewline");
		LuaDLL.lua_pop(l, 1);
	}
}
