using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001816 RID: 6166
[Preserve]
public class Lua_UnityEngine_UI_Clipping : LuaObject
{
	// Token: 0x06023FC8 RID: 147400 RVA: 0x00CA1428 File Offset: 0x00C9F628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindCullAndClipWorldRect_s(IntPtr l)
	{
		int result;
		try
		{
			List<RectMask2D> rectMaskParents;
			LuaObject.checkType<List<RectMask2D>>(l, 1, out rectMaskParents);
			bool b;
			Rect rect = Clipping.FindCullAndClipWorldRect(rectMaskParents, out b);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect);
			LuaObject.pushValue(l, b);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FC9 RID: 147401 RVA: 0x00CA148C File Offset: 0x00C9F68C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Clipping");
		if (Lua_UnityEngine_UI_Clipping.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Clipping.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Clipping.FindCullAndClipWorldRect_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Clipping.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(Clipping));
	}

	// Token: 0x04019BFA RID: 105466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
