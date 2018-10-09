using System;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001833 RID: 6195
[Preserve]
public class Lua_UnityEngine_UI_ILayoutSelfController : LuaObject
{
	// Token: 0x060240D3 RID: 147667 RVA: 0x00CA7FA0 File Offset: 0x00CA61A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.ILayoutSelfController");
		LuaObject.createTypeMetatable(l, null, typeof(ILayoutSelfController));
	}
}
