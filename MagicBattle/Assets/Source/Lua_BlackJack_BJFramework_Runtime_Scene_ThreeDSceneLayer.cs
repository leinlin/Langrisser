using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200111C RID: 4380
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Scene_ThreeDSceneLayer : LuaObject
{
	// Token: 0x06015C59 RID: 89177 RVA: 0x0059CF10 File Offset: 0x0059B110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerCamera(IntPtr l)
	{
		int result;
		try
		{
			ThreeDSceneLayer threeDSceneLayer = (ThreeDSceneLayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, threeDSceneLayer.LayerCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C5A RID: 89178 RVA: 0x0059CF64 File Offset: 0x0059B164
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Scene.ThreeDSceneLayer");
		string name = "LayerCamera";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_ThreeDSceneLayer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_ThreeDSceneLayer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_ThreeDSceneLayer.get_LayerCamera);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_BJFramework_Runtime_Scene_ThreeDSceneLayer.<>f__mg$cache0, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(ThreeDSceneLayer), typeof(SceneLayerBase));
	}

	// Token: 0x0400C403 RID: 50179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
