using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001799 RID: 6041
[Preserve]
public class Lua_UnityEngine_Rendering_ReflectionProbeTimeSlicingMode : LuaObject
{
	// Token: 0x06023B00 RID: 146176 RVA: 0x00C7CD2C File Offset: 0x00C7AF2C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.ReflectionProbeTimeSlicingMode");
		LuaObject.addMember(l, 0, "AllFacesAtOnce");
		LuaObject.addMember(l, 1, "IndividualFaces");
		LuaObject.addMember(l, 2, "NoTimeSlicing");
		LuaDLL.lua_pop(l, 1);
	}
}
