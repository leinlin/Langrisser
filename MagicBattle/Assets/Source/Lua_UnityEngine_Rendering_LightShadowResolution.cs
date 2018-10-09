using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001790 RID: 6032
[Preserve]
public class Lua_UnityEngine_Rendering_LightShadowResolution : LuaObject
{
	// Token: 0x06023AE9 RID: 146153 RVA: 0x00C7C7D8 File Offset: 0x00C7A9D8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.LightShadowResolution");
		LuaObject.addMember(l, 0, "Low");
		LuaObject.addMember(l, 1, "Medium");
		LuaObject.addMember(l, 2, "High");
		LuaObject.addMember(l, 3, "VeryHigh");
		LuaObject.addMember(l, -1, "FromQualitySettings");
		LuaDLL.lua_pop(l, 1);
	}
}
