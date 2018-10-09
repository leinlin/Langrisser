using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001684 RID: 5764
[Preserve]
public class Lua_UnityEngine_CustomRenderTextureUpdateZoneSpace : LuaObject
{
	// Token: 0x06023040 RID: 143424 RVA: 0x00C1FD8C File Offset: 0x00C1DF8C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.CustomRenderTextureUpdateZoneSpace");
		LuaObject.addMember(l, 0, "Normalized");
		LuaObject.addMember(l, 1, "Pixel");
		LuaDLL.lua_pop(l, 1);
	}
}
