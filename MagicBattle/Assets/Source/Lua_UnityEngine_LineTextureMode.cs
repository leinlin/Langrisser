using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001718 RID: 5912
[Preserve]
public class Lua_UnityEngine_LineTextureMode : LuaObject
{
	// Token: 0x0602351B RID: 144667 RVA: 0x00C4459C File Offset: 0x00C4279C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LineTextureMode");
		LuaObject.addMember(l, 0, "Stretch");
		LuaObject.addMember(l, 1, "Tile");
		LuaObject.addMember(l, 2, "DistributePerSegment");
		LuaObject.addMember(l, 3, "RepeatPerSegment");
		LuaDLL.lua_pop(l, 1);
	}
}
