using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200182C RID: 6188
[Preserve]
public class Lua_UnityEngine_UI_ICanvasElement : LuaObject
{
	// Token: 0x060240AE RID: 147630 RVA: 0x00CA7368 File Offset: 0x00CA5568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Rebuild(IntPtr l)
	{
		int result;
		try
		{
			ICanvasElement canvasElement = (ICanvasElement)LuaObject.checkSelf(l);
			CanvasUpdate executing;
			LuaObject.checkEnum<CanvasUpdate>(l, 2, out executing);
			canvasElement.Rebuild(executing);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240AF RID: 147631 RVA: 0x00CA73C0 File Offset: 0x00CA55C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LayoutComplete(IntPtr l)
	{
		int result;
		try
		{
			ICanvasElement canvasElement = (ICanvasElement)LuaObject.checkSelf(l);
			canvasElement.LayoutComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240B0 RID: 147632 RVA: 0x00CA740C File Offset: 0x00CA560C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GraphicUpdateComplete(IntPtr l)
	{
		int result;
		try
		{
			ICanvasElement canvasElement = (ICanvasElement)LuaObject.checkSelf(l);
			canvasElement.GraphicUpdateComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240B1 RID: 147633 RVA: 0x00CA7458 File Offset: 0x00CA5658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDestroyed(IntPtr l)
	{
		int result;
		try
		{
			ICanvasElement canvasElement = (ICanvasElement)LuaObject.checkSelf(l);
			bool b = canvasElement.IsDestroyed();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240B2 RID: 147634 RVA: 0x00CA74AC File Offset: 0x00CA56AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transform(IntPtr l)
	{
		int result;
		try
		{
			ICanvasElement canvasElement = (ICanvasElement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasElement.transform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240B3 RID: 147635 RVA: 0x00CA7500 File Offset: 0x00CA5700
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.ICanvasElement");
		if (Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_ICanvasElement.Rebuild);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_ICanvasElement.LayoutComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_ICanvasElement.GraphicUpdateComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_ICanvasElement.IsDestroyed);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache3);
		string name = "transform";
		if (Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_ICanvasElement.get_transform);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_ICanvasElement.<>f__mg$cache4, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(ICanvasElement));
	}

	// Token: 0x04019CB4 RID: 105652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019CB5 RID: 105653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019CB6 RID: 105654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019CB7 RID: 105655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019CB8 RID: 105656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
