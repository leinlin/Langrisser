using System;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001831 RID: 6193
[Preserve]
public class Lua_UnityEngine_UI_ILayoutGroup : LuaObject
{
	// Token: 0x060240CE RID: 147662 RVA: 0x00CA7EC8 File Offset: 0x00CA60C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.ILayoutGroup");
		LuaObject.createTypeMetatable(l, null, typeof(ILayoutGroup));
	}
}
