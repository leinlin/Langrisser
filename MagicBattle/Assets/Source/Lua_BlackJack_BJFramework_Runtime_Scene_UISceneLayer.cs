using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200111D RID: 4381
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Scene_UISceneLayer : LuaObject
{
	// Token: 0x06015C5C RID: 89180 RVA: 0x0059CFCC File Offset: 0x0059B1CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LayerCamera(IntPtr l)
	{
		int result;
		try
		{
			UISceneLayer uisceneLayer = (UISceneLayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uisceneLayer.LayerCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C5D RID: 89181 RVA: 0x0059D020 File Offset: 0x0059B220
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LayerCanvas(IntPtr l)
	{
		int result;
		try
		{
			UISceneLayer uisceneLayer = (UISceneLayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uisceneLayer.LayerCanvas);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C5E RID: 89182 RVA: 0x0059D074 File Offset: 0x0059B274
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Scene.UISceneLayer");
		string name = "LayerCamera";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_UISceneLayer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_UISceneLayer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_UISceneLayer.get_LayerCamera);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_BJFramework_Runtime_Scene_UISceneLayer.<>f__mg$cache0, null, true);
		string name2 = "LayerCanvas";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_UISceneLayer.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_UISceneLayer.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_UISceneLayer.get_LayerCanvas);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_BJFramework_Runtime_Scene_UISceneLayer.<>f__mg$cache1, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(UISceneLayer), typeof(SceneLayerBase));
	}

	// Token: 0x0400C404 RID: 50180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C405 RID: 50181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
