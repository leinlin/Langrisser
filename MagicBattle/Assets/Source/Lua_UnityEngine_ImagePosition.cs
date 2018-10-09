using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016F1 RID: 5873
[Preserve]
public class Lua_UnityEngine_ImagePosition : LuaObject
{
	// Token: 0x0602339C RID: 144284 RVA: 0x00C39650 File Offset: 0x00C37850
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ImagePosition");
		LuaObject.addMember(l, 0, "ImageLeft");
		LuaObject.addMember(l, 1, "ImageAbove");
		LuaObject.addMember(l, 2, "ImageOnly");
		LuaObject.addMember(l, 3, "TextOnly");
		LuaDLL.lua_pop(l, 1);
	}
}
