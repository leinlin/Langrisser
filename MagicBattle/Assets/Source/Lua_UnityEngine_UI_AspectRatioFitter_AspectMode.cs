using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200180B RID: 6155
[Preserve]
public class Lua_UnityEngine_UI_AspectRatioFitter_AspectMode : LuaObject
{
	// Token: 0x06023F8C RID: 147340 RVA: 0x00C9FF20 File Offset: 0x00C9E120
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.AspectRatioFitter.AspectMode");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "WidthControlsHeight");
		LuaObject.addMember(l, 2, "HeightControlsWidth");
		LuaObject.addMember(l, 3, "FitInParent");
		LuaObject.addMember(l, 4, "EnvelopeParent");
		LuaDLL.lua_pop(l, 1);
	}
}
