using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016E1 RID: 5857
[Preserve]
public class Lua_UnityEngine_HorizontalWrapMode : LuaObject
{
	// Token: 0x06023328 RID: 144168 RVA: 0x00C363AC File Offset: 0x00C345AC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.HorizontalWrapMode");
		LuaObject.addMember(l, 0, "Wrap");
		LuaObject.addMember(l, 1, "Overflow");
		LuaDLL.lua_pop(l, 1);
	}
}
