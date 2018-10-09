using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001786 RID: 6022
[Preserve]
public class Lua_UnityEngine_Rendering_CopyTextureSupport : LuaObject
{
	// Token: 0x06023AC3 RID: 146115 RVA: 0x00C7BBF0 File Offset: 0x00C79DF0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.CopyTextureSupport");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Basic");
		LuaObject.addMember(l, 2, "Copy3D");
		LuaObject.addMember(l, 4, "DifferentTypes");
		LuaObject.addMember(l, 8, "TextureToRT");
		LuaObject.addMember(l, 16, "RTToTexture");
		LuaDLL.lua_pop(l, 1);
	}
}
