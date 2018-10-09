using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200182F RID: 6191
[Preserve]
public class Lua_UnityEngine_UI_ILayoutController : LuaObject
{
	// Token: 0x060240BF RID: 147647 RVA: 0x00CA7934 File Offset: 0x00CA5B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutHorizontal(IntPtr l)
	{
		int result;
		try
		{
			ILayoutController layoutController = (ILayoutController)LuaObject.checkSelf(l);
			layoutController.SetLayoutHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240C0 RID: 147648 RVA: 0x00CA7980 File Offset: 0x00CA5B80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLayoutVertical(IntPtr l)
	{
		int result;
		try
		{
			ILayoutController layoutController = (ILayoutController)LuaObject.checkSelf(l);
			layoutController.SetLayoutVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240C1 RID: 147649 RVA: 0x00CA79CC File Offset: 0x00CA5BCC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.ILayoutController");
		if (Lua_UnityEngine_UI_ILayoutController.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_ILayoutController.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_ILayoutController.SetLayoutHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ILayoutController.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_ILayoutController.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_ILayoutController.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_ILayoutController.SetLayoutVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ILayoutController.<>f__mg$cache1);
		LuaObject.createTypeMetatable(l, null, typeof(ILayoutController));
	}

	// Token: 0x04019CBF RID: 105663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019CC0 RID: 105664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
