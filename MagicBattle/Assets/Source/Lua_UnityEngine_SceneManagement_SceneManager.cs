using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

// Token: 0x020017C6 RID: 6086
[Preserve]
public class Lua_UnityEngine_SceneManagement_SceneManager : LuaObject
{
	// Token: 0x06023CAB RID: 146603 RVA: 0x00C89C40 File Offset: 0x00C87E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SceneManager o = new SceneManager();
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

	// Token: 0x06023CAC RID: 146604 RVA: 0x00C89C88 File Offset: 0x00C87E88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetActiveScene_s(IntPtr l)
	{
		int result;
		try
		{
			Scene activeScene = SceneManager.GetActiveScene();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activeScene);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CAD RID: 146605 RVA: 0x00C89CD4 File Offset: 0x00C87ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActiveScene_s(IntPtr l)
	{
		int result;
		try
		{
			Scene activeScene;
			LuaObject.checkValueType<Scene>(l, 1, out activeScene);
			bool b = SceneManager.SetActiveScene(activeScene);
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

	// Token: 0x06023CAE RID: 146606 RVA: 0x00C89D28 File Offset: 0x00C87F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSceneByPath_s(IntPtr l)
	{
		int result;
		try
		{
			string scenePath;
			LuaObject.checkType(l, 1, out scenePath);
			Scene sceneByPath = SceneManager.GetSceneByPath(scenePath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sceneByPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CAF RID: 146607 RVA: 0x00C89D80 File Offset: 0x00C87F80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSceneByName_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			Scene sceneByName = SceneManager.GetSceneByName(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sceneByName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CB0 RID: 146608 RVA: 0x00C89DD8 File Offset: 0x00C87FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSceneByBuildIndex_s(IntPtr l)
	{
		int result;
		try
		{
			int buildIndex;
			LuaObject.checkType(l, 1, out buildIndex);
			Scene sceneByBuildIndex = SceneManager.GetSceneByBuildIndex(buildIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sceneByBuildIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CB1 RID: 146609 RVA: 0x00C89E30 File Offset: 0x00C88030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSceneAt_s(IntPtr l)
	{
		int result;
		try
		{
			int index;
			LuaObject.checkType(l, 1, out index);
			Scene sceneAt = SceneManager.GetSceneAt(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sceneAt);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CB2 RID: 146610 RVA: 0x00C89E88 File Offset: 0x00C88088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadScene_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string sceneName;
				LuaObject.checkType(l, 1, out sceneName);
				SceneManager.LoadScene(sceneName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int sceneBuildIndex;
				LuaObject.checkType(l, 1, out sceneBuildIndex);
				SceneManager.LoadScene(sceneBuildIndex);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(LoadSceneMode)))
			{
				int sceneBuildIndex2;
				LuaObject.checkType(l, 1, out sceneBuildIndex2);
				LoadSceneMode mode;
				LuaObject.checkEnum<LoadSceneMode>(l, 2, out mode);
				SceneManager.LoadScene(sceneBuildIndex2, mode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(LoadSceneMode)))
			{
				string sceneName2;
				LuaObject.checkType(l, 1, out sceneName2);
				LoadSceneMode mode2;
				LuaObject.checkEnum<LoadSceneMode>(l, 2, out mode2);
				SceneManager.LoadScene(sceneName2, mode2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadScene to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CB3 RID: 146611 RVA: 0x00C89FE4 File Offset: 0x00C881E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadSceneAsync_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string sceneName;
				LuaObject.checkType(l, 1, out sceneName);
				AsyncOperation o = SceneManager.LoadSceneAsync(sceneName);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int sceneBuildIndex;
				LuaObject.checkType(l, 1, out sceneBuildIndex);
				AsyncOperation o2 = SceneManager.LoadSceneAsync(sceneBuildIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(LoadSceneMode)))
			{
				int sceneBuildIndex2;
				LuaObject.checkType(l, 1, out sceneBuildIndex2);
				LoadSceneMode mode;
				LuaObject.checkEnum<LoadSceneMode>(l, 2, out mode);
				AsyncOperation o3 = SceneManager.LoadSceneAsync(sceneBuildIndex2, mode);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(LoadSceneMode)))
			{
				string sceneName2;
				LuaObject.checkType(l, 1, out sceneName2);
				LoadSceneMode mode2;
				LuaObject.checkEnum<LoadSceneMode>(l, 2, out mode2);
				AsyncOperation o4 = SceneManager.LoadSceneAsync(sceneName2, mode2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadSceneAsync to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CB4 RID: 146612 RVA: 0x00C8A168 File Offset: 0x00C88368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateScene_s(IntPtr l)
	{
		int result;
		try
		{
			string sceneName;
			LuaObject.checkType(l, 1, out sceneName);
			Scene scene = SceneManager.CreateScene(sceneName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scene);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CB5 RID: 146613 RVA: 0x00C8A1C0 File Offset: 0x00C883C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnloadSceneAsync_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int sceneBuildIndex;
				LuaObject.checkType(l, 1, out sceneBuildIndex);
				AsyncOperation o = SceneManager.UnloadSceneAsync(sceneBuildIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string sceneName;
				LuaObject.checkType(l, 1, out sceneName);
				AsyncOperation o2 = SceneManager.UnloadSceneAsync(sceneName);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Scene)))
			{
				Scene scene;
				LuaObject.checkValueType<Scene>(l, 1, out scene);
				AsyncOperation o3 = SceneManager.UnloadSceneAsync(scene);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function UnloadSceneAsync to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CB6 RID: 146614 RVA: 0x00C8A2CC File Offset: 0x00C884CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MergeScenes_s(IntPtr l)
	{
		int result;
		try
		{
			Scene sourceScene;
			LuaObject.checkValueType<Scene>(l, 1, out sourceScene);
			Scene destinationScene;
			LuaObject.checkValueType<Scene>(l, 2, out destinationScene);
			SceneManager.MergeScenes(sourceScene, destinationScene);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CB7 RID: 146615 RVA: 0x00C8A324 File Offset: 0x00C88524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MoveGameObjectToScene_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			Scene scene;
			LuaObject.checkValueType<Scene>(l, 2, out scene);
			SceneManager.MoveGameObjectToScene(go, scene);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CB8 RID: 146616 RVA: 0x00C8A37C File Offset: 0x00C8857C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sceneCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SceneManager.sceneCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CB9 RID: 146617 RVA: 0x00C8A3C4 File Offset: 0x00C885C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sceneCountInBuildSettings(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SceneManager.sceneCountInBuildSettings);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CBA RID: 146618 RVA: 0x00C8A40C File Offset: 0x00C8860C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SceneManagement.SceneManager");
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.GetActiveScene_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache0);
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.SetActiveScene_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache1);
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.GetSceneByPath_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache2);
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.GetSceneByName_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache3);
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.GetSceneByBuildIndex_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache4);
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.GetSceneAt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache5);
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.LoadScene_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache6);
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.LoadSceneAsync_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache7);
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.CreateScene_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache8);
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.UnloadSceneAsync_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cache9);
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.MergeScenes_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheA);
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.MoveGameObjectToScene_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheB);
		string name = "sceneCount";
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.get_sceneCount);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheC, null, false);
		string name2 = "sceneCountInBuildSettings";
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.get_sceneCountInBuildSettings);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheD, null, false);
		if (Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneManager.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_SceneManagement_SceneManager.<>f__mg$cacheE, typeof(SceneManager));
	}

	// Token: 0x0401997D RID: 104829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401997E RID: 104830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401997F RID: 104831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019980 RID: 104832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019981 RID: 104833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019982 RID: 104834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019983 RID: 104835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019984 RID: 104836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019985 RID: 104837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019986 RID: 104838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019987 RID: 104839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019988 RID: 104840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019989 RID: 104841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401998A RID: 104842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401998B RID: 104843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
