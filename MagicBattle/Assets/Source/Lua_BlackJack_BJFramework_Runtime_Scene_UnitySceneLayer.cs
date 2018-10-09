using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Scene;
using SLua;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

// Token: 0x0200111E RID: 4382
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer : LuaObject
{
	// Token: 0x06015C60 RID: 89184 RVA: 0x0059D104 File Offset: 0x0059B304
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetScene(IntPtr l)
	{
		int result;
		try
		{
			UnitySceneLayer unitySceneLayer = (UnitySceneLayer)LuaObject.checkSelf(l);
			Scene scene;
			LuaObject.checkValueType<Scene>(l, 2, out scene);
			unitySceneLayer.SetScene(scene);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C61 RID: 89185 RVA: 0x0059D15C File Offset: 0x0059B35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Scene(IntPtr l)
	{
		int result;
		try
		{
			UnitySceneLayer unitySceneLayer = (UnitySceneLayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unitySceneLayer.Scene);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C62 RID: 89186 RVA: 0x0059D1B4 File Offset: 0x0059B3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Scene(IntPtr l)
	{
		int result;
		try
		{
			UnitySceneLayer unitySceneLayer = (UnitySceneLayer)LuaObject.checkSelf(l);
			Scene scene;
			LuaObject.checkValueType<Scene>(l, 2, out scene);
			unitySceneLayer.Scene = scene;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C63 RID: 89187 RVA: 0x0059D20C File Offset: 0x0059B40C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UnitySceneRootObjs(IntPtr l)
	{
		int result;
		try
		{
			UnitySceneLayer unitySceneLayer = (UnitySceneLayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unitySceneLayer.UnitySceneRootObjs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C64 RID: 89188 RVA: 0x0059D260 File Offset: 0x0059B460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UnitySceneRootObjs(IntPtr l)
	{
		int result;
		try
		{
			UnitySceneLayer unitySceneLayer = (UnitySceneLayer)LuaObject.checkSelf(l);
			List<GameObject> unitySceneRootObjs;
			LuaObject.checkType<List<GameObject>>(l, 2, out unitySceneRootObjs);
			unitySceneLayer.UnitySceneRootObjs = unitySceneRootObjs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C65 RID: 89189 RVA: 0x0059D2B8 File Offset: 0x0059B4B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerCamera(IntPtr l)
	{
		int result;
		try
		{
			UnitySceneLayer unitySceneLayer = (UnitySceneLayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unitySceneLayer.LayerCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C66 RID: 89190 RVA: 0x0059D30C File Offset: 0x0059B50C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Scene.UnitySceneLayer");
		if (Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.SetScene);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache0);
		string name = "Scene";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.get_Scene);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache1;
		if (Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.set_Scene);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache2, true);
		string name2 = "UnitySceneRootObjs";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.get_UnitySceneRootObjs);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache3;
		if (Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.set_UnitySceneRootObjs);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache4, true);
		string name3 = "LayerCamera";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.get_LayerCamera);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.<>f__mg$cache5, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(UnitySceneLayer), typeof(ThreeDSceneLayer));
	}

	// Token: 0x0400C406 RID: 50182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C407 RID: 50183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C408 RID: 50184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C409 RID: 50185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C40A RID: 50186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C40B RID: 50187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
