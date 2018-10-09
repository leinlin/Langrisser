using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200111B RID: 4379
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager : LuaObject
{
	// Token: 0x06015C43 RID: 89155 RVA: 0x0059C4DC File Offset: 0x0059A6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateLayer(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			Type layerType;
			LuaObject.checkType(l, 2, out layerType);
			string name;
			LuaObject.checkType(l, 3, out name);
			string resPath;
			LuaObject.checkType(l, 4, out resPath);
			Action<SceneLayerBase> onComplete;
			LuaObject.checkDelegate<Action<SceneLayerBase>>(l, 5, out onComplete);
			bool enableReserve;
			LuaObject.checkType(l, 6, out enableReserve);
			sceneManager.CreateLayer(layerType, name, resPath, onComplete, enableReserve);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C44 RID: 89156 RVA: 0x0059C568 File Offset: 0x0059A768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FreeLayer(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			SceneLayerBase layer;
			LuaObject.checkType<SceneLayerBase>(l, 2, out layer);
			sceneManager.FreeLayer(layer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C45 RID: 89157 RVA: 0x0059C5C0 File Offset: 0x0059A7C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PushLayer(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			SceneLayerBase layer;
			LuaObject.checkType<SceneLayerBase>(l, 2, out layer);
			bool b = sceneManager.PushLayer(layer);
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

	// Token: 0x06015C46 RID: 89158 RVA: 0x0059C624 File Offset: 0x0059A824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PopLayer(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			SceneLayerBase layer;
			LuaObject.checkType<SceneLayerBase>(l, 2, out layer);
			sceneManager.PopLayer(layer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C47 RID: 89159 RVA: 0x0059C67C File Offset: 0x0059A87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BringLayerToTop(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			UISceneLayer layer;
			LuaObject.checkType<UISceneLayer>(l, 2, out layer);
			sceneManager.BringLayerToTop(layer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C48 RID: 89160 RVA: 0x0059C6D4 File Offset: 0x0059A8D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Enable3DLayerBlur(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			sceneManager.Enable3DLayerBlur(isEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C49 RID: 89161 RVA: 0x0059C72C File Offset: 0x0059A92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ApplyCurrRenderSetting(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			sceneManager.ApplyCurrRenderSetting();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C4A RID: 89162 RVA: 0x0059C778 File Offset: 0x0059A978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrRenderSetting(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			LayerRenderSettingDesc currRenderSetting = sceneManager.GetCurrRenderSetting();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currRenderSetting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C4B RID: 89163 RVA: 0x0059C7CC File Offset: 0x0059A9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRootCanvas(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			GameObject rootCanvas = sceneManager.GetRootCanvas(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rootCanvas);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C4C RID: 89164 RVA: 0x0059C830 File Offset: 0x0059AA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindLayerByName(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			SceneLayerBase o = sceneManager.FindLayerByName(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C4D RID: 89165 RVA: 0x0059C894 File Offset: 0x0059AA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindUILayerUnderLayer(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			Func<SceneLayerBase, bool> filter;
			LuaObject.checkDelegate<Func<SceneLayerBase, bool>>(l, 3, out filter);
			SceneLayerBase o = sceneManager.FindUILayerUnderLayer(name, filter);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C4E RID: 89166 RVA: 0x0059C904 File Offset: 0x0059AB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerCameraFromSceneByPath(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			string rectTransPath;
			LuaObject.checkType(l, 2, out rectTransPath);
			Camera layerCameraFromSceneByPath = sceneManager.GetLayerCameraFromSceneByPath(rectTransPath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerCameraFromSceneByPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C4F RID: 89167 RVA: 0x0059C968 File Offset: 0x0059AB68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRectTransformFromSceneByPath(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			string rectTransPath;
			LuaObject.checkType(l, 2, out rectTransPath);
			RectTransform rectTransformFromSceneByPath = sceneManager.GetRectTransformFromSceneByPath(rectTransPath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectTransformFromSceneByPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C50 RID: 89168 RVA: 0x0059C9CC File Offset: 0x0059ABCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetObjectPath_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 1, out obj);
			string objectPath = SceneManager.GetObjectPath(obj);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, objectPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C51 RID: 89169 RVA: 0x0059CA20 File Offset: 0x0059AC20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiSceneGroup1Camera(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sceneManager.m_uiSceneGroup1Camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C52 RID: 89170 RVA: 0x0059CA74 File Offset: 0x0059AC74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiSceneGroup1Camera(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			Camera uiSceneGroup1Camera;
			LuaObject.checkType<Camera>(l, 2, out uiSceneGroup1Camera);
			sceneManager.m_uiSceneGroup1Camera = uiSceneGroup1Camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C53 RID: 89171 RVA: 0x0059CACC File Offset: 0x0059ACCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiSceneGroup2Camera(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sceneManager.m_uiSceneGroup2Camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C54 RID: 89172 RVA: 0x0059CB20 File Offset: 0x0059AD20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiSceneGroup2Camera(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			Camera uiSceneGroup2Camera;
			LuaObject.checkType<Camera>(l, 2, out uiSceneGroup2Camera);
			sceneManager.m_uiSceneGroup2Camera = uiSceneGroup2Camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C55 RID: 89173 RVA: 0x0059CB78 File Offset: 0x0059AD78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RootCanvasGo(IntPtr l)
	{
		int result;
		try
		{
			SceneManager sceneManager = (SceneManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sceneManager.RootCanvasGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C56 RID: 89174 RVA: 0x0059CBCC File Offset: 0x0059ADCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SceneManager.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C57 RID: 89175 RVA: 0x0059CC14 File Offset: 0x0059AE14
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Scene.SceneManager");
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.CreateLayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.FreeLayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.PushLayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.PopLayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.BringLayerToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.Enable3DLayerBlur);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.ApplyCurrRenderSetting);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.GetCurrRenderSetting);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.GetRootCanvas);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.FindLayerByName);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.FindUILayerUnderLayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.GetLayerCameraFromSceneByPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.GetRectTransformFromSceneByPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.GetObjectPath_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheD);
		string name = "m_uiSceneGroup1Camera";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.get_m_uiSceneGroup1Camera);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheE;
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.set_m_uiSceneGroup1Camera);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cacheF, true);
		string name2 = "m_uiSceneGroup2Camera";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.get_m_uiSceneGroup2Camera);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache10;
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.set_m_uiSceneGroup2Camera);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache11, true);
		string name3 = "RootCanvasGo";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.get_RootCanvasGo);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache12, null, true);
		string name4 = "Instance";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.get_Instance);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.<>f__mg$cache13, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(SceneManager));
	}

	// Token: 0x0400C3EF RID: 50159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C3F0 RID: 50160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C3F1 RID: 50161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C3F2 RID: 50162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C3F3 RID: 50163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C3F4 RID: 50164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C3F5 RID: 50165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C3F6 RID: 50166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C3F7 RID: 50167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C3F8 RID: 50168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C3F9 RID: 50169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C3FA RID: 50170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C3FB RID: 50171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C3FC RID: 50172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C3FD RID: 50173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C3FE RID: 50174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C3FF RID: 50175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C400 RID: 50176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C401 RID: 50177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C402 RID: 50178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
