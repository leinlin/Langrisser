using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001682 RID: 5762
[Preserve]
public class Lua_UnityEngine_CustomRenderTextureUpdateMode : LuaObject
{
	// Token: 0x06023031 RID: 143409 RVA: 0x00C1F7AC File Offset: 0x00C1D9AC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.CustomRenderTextureUpdateMode");
		LuaObject.addMember(l, 0, "OnLoad");
		LuaObject.addMember(l, 1, "Realtime");
		LuaObject.addMember(l, 2, "OnDemand");
		LuaDLL.lua_pop(l, 1);
	}
}
