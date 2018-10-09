using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017D4 RID: 6100
[Preserve]
public class Lua_UnityEngine_SkinQuality : LuaObject
{
	// Token: 0x06023D2D RID: 146733 RVA: 0x00C8E020 File Offset: 0x00C8C220
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.SkinQuality");
		LuaObject.addMember(l, 0, "Auto");
		LuaObject.addMember(l, 1, "Bone1");
		LuaObject.addMember(l, 2, "Bone2");
		LuaObject.addMember(l, 4, "Bone4");
		LuaDLL.lua_pop(l, 1);
	}
}
