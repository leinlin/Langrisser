using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017CC RID: 6092
[Preserve]
public class Lua_UnityEngine_SendMessageOptions : LuaObject
{
	// Token: 0x06023CE1 RID: 146657 RVA: 0x00C8B46C File Offset: 0x00C8966C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.SendMessageOptions");
		LuaObject.addMember(l, 0, "RequireReceiver");
		LuaObject.addMember(l, 1, "DontRequireReceiver");
		LuaDLL.lua_pop(l, 1);
	}
}
