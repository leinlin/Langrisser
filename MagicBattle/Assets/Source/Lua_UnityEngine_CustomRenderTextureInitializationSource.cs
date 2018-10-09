using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001681 RID: 5761
[Preserve]
public class Lua_UnityEngine_CustomRenderTextureInitializationSource : LuaObject
{
	// Token: 0x0602302F RID: 143407 RVA: 0x00C1F778 File Offset: 0x00C1D978
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.CustomRenderTextureInitializationSource");
		LuaObject.addMember(l, 0, "TextureAndColor");
		LuaObject.addMember(l, 1, "Material");
		LuaDLL.lua_pop(l, 1);
	}
}
