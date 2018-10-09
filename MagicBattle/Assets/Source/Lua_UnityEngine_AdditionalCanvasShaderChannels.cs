using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200160C RID: 5644
[Preserve]
public class Lua_UnityEngine_AdditionalCanvasShaderChannels : LuaObject
{
	// Token: 0x060229E7 RID: 141799 RVA: 0x00BEC51C File Offset: 0x00BEA71C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AdditionalCanvasShaderChannels");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "TexCoord1");
		LuaObject.addMember(l, 2, "TexCoord2");
		LuaObject.addMember(l, 4, "TexCoord3");
		LuaObject.addMember(l, 8, "Normal");
		LuaObject.addMember(l, 16, "Tangent");
		LuaDLL.lua_pop(l, 1);
	}
}
