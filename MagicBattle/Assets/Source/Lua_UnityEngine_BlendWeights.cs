using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001641 RID: 5697
[Preserve]
public class Lua_UnityEngine_BlendWeights : LuaObject
{
	// Token: 0x06022C58 RID: 142424 RVA: 0x00C0183C File Offset: 0x00BFFA3C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.BlendWeights");
		LuaObject.addMember(l, 1, "OneBone");
		LuaObject.addMember(l, 2, "TwoBones");
		LuaObject.addMember(l, 4, "FourBones");
		LuaDLL.lua_pop(l, 1);
	}
}
