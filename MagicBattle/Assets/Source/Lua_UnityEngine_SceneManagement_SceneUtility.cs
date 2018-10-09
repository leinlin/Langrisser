using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

// Token: 0x020017C7 RID: 6087
[Preserve]
public class Lua_UnityEngine_SceneManagement_SceneUtility : LuaObject
{
	// Token: 0x06023CBC RID: 146620 RVA: 0x00C8A654 File Offset: 0x00C88854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetScenePathByBuildIndex_s(IntPtr l)
	{
		int result;
		try
		{
			int buildIndex;
			LuaObject.checkType(l, 1, out buildIndex);
			string scenePathByBuildIndex = SceneUtility.GetScenePathByBuildIndex(buildIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scenePathByBuildIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CBD RID: 146621 RVA: 0x00C8A6A8 File Offset: 0x00C888A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBuildIndexByScenePath_s(IntPtr l)
	{
		int result;
		try
		{
			string scenePath;
			LuaObject.checkType(l, 1, out scenePath);
			int buildIndexByScenePath = SceneUtility.GetBuildIndexByScenePath(scenePath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buildIndexByScenePath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CBE RID: 146622 RVA: 0x00C8A6FC File Offset: 0x00C888FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SceneManagement.SceneUtility");
		if (Lua_UnityEngine_SceneManagement_SceneUtility.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SceneManagement_SceneUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneUtility.GetScenePathByBuildIndex_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneUtility.<>f__mg$cache0);
		if (Lua_UnityEngine_SceneManagement_SceneUtility.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SceneManagement_SceneUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_SceneUtility.GetBuildIndexByScenePath_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_SceneUtility.<>f__mg$cache1);
		LuaObject.createTypeMetatable(l, null, typeof(SceneUtility));
	}

	// Token: 0x0401998C RID: 104844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401998D RID: 104845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
