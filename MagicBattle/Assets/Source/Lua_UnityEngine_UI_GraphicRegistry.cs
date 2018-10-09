using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001825 RID: 6181
[Preserve]
public class Lua_UnityEngine_UI_GraphicRegistry : LuaObject
{
	// Token: 0x0602407E RID: 147582 RVA: 0x00CA61F8 File Offset: 0x00CA43F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterGraphicForCanvas_s(IntPtr l)
	{
		int result;
		try
		{
			Canvas c;
			LuaObject.checkType<Canvas>(l, 1, out c);
			Graphic graphic;
			LuaObject.checkType<Graphic>(l, 2, out graphic);
			GraphicRegistry.RegisterGraphicForCanvas(c, graphic);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602407F RID: 147583 RVA: 0x00CA6250 File Offset: 0x00CA4450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterGraphicForCanvas_s(IntPtr l)
	{
		int result;
		try
		{
			Canvas c;
			LuaObject.checkType<Canvas>(l, 1, out c);
			Graphic graphic;
			LuaObject.checkType<Graphic>(l, 2, out graphic);
			GraphicRegistry.UnregisterGraphicForCanvas(c, graphic);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024080 RID: 147584 RVA: 0x00CA62A8 File Offset: 0x00CA44A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGraphicsForCanvas_s(IntPtr l)
	{
		int result;
		try
		{
			Canvas canvas;
			LuaObject.checkType<Canvas>(l, 1, out canvas);
			IList<Graphic> graphicsForCanvas = GraphicRegistry.GetGraphicsForCanvas(canvas);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphicsForCanvas);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024081 RID: 147585 RVA: 0x00CA62FC File Offset: 0x00CA44FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GraphicRegistry.instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024082 RID: 147586 RVA: 0x00CA6344 File Offset: 0x00CA4544
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.GraphicRegistry");
		if (Lua_UnityEngine_UI_GraphicRegistry.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_GraphicRegistry.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_GraphicRegistry.RegisterGraphicForCanvas_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_GraphicRegistry.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_GraphicRegistry.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_GraphicRegistry.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_GraphicRegistry.UnregisterGraphicForCanvas_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_GraphicRegistry.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_GraphicRegistry.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_GraphicRegistry.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_GraphicRegistry.GetGraphicsForCanvas_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_GraphicRegistry.<>f__mg$cache2);
		string name = "instance";
		if (Lua_UnityEngine_UI_GraphicRegistry.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_GraphicRegistry.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_GraphicRegistry.get_instance);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_GraphicRegistry.<>f__mg$cache3, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(GraphicRegistry));
	}

	// Token: 0x04019C92 RID: 105618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019C93 RID: 105619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019C94 RID: 105620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019C95 RID: 105621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
