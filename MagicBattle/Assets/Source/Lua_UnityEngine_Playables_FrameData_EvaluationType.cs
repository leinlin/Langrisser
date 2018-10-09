using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001743 RID: 5955
[Preserve]
public class Lua_UnityEngine_Playables_FrameData_EvaluationType : LuaObject
{
	// Token: 0x060237D1 RID: 145361 RVA: 0x00C63F7C File Offset: 0x00C6217C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Playables.FrameData.EvaluationType");
		LuaObject.addMember(l, 0, "Evaluate");
		LuaObject.addMember(l, 1, "Playback");
		LuaDLL.lua_pop(l, 1);
	}
}
