using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017FA RID: 6138
[Preserve]
public class Lua_UnityEngine_Texture2D_EXRFlags : LuaObject
{
	// Token: 0x06023EBA RID: 147130 RVA: 0x00C99480 File Offset: 0x00C97680
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Texture2D.EXRFlags");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "OutputAsFloat");
		LuaObject.addMember(l, 2, "CompressZIP");
		LuaObject.addMember(l, 4, "CompressRLE");
		LuaObject.addMember(l, 8, "CompressPIZ");
		LuaDLL.lua_pop(l, 1);
	}
}
