using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001781 RID: 6017
[Preserve]
public class Lua_UnityEngine_Rendering_CameraHDRMode : LuaObject
{
	// Token: 0x06023A7D RID: 146045 RVA: 0x00C76D5C File Offset: 0x00C74F5C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.CameraHDRMode");
		LuaObject.addMember(l, 1, "FP16");
		LuaObject.addMember(l, 2, "R11G11B10");
		LuaDLL.lua_pop(l, 1);
	}
}
