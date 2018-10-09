using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020012A3 RID: 4771
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_GameObjectUtility : LuaObject
{
	// Token: 0x06019055 RID: 102485 RVA: 0x0071EE68 File Offset: 0x0071D068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GameObjectUtility o = new GameObjectUtility();
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

	// Token: 0x06019056 RID: 102486 RVA: 0x0071EEB0 File Offset: 0x0071D0B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindChildObject_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				GameObject parentObj;
				LuaObject.checkType<GameObject>(l, 1, out parentObj);
				string[] path;
				LuaObject.checkArray<string>(l, 2, out path);
				GameObject o = GameObjectUtility.FindChildObject(parentObj, path);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				GameObject parentObj2;
				LuaObject.checkType<GameObject>(l, 1, out parentObj2);
				string[] path2;
				LuaObject.checkArray<string>(l, 2, out path2);
				Action<GameObject> action;
				LuaObject.checkDelegate<Action<GameObject>>(l, 3, out action);
				GameObjectUtility.FindChildObject(parentObj2, path2, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function FindChildObject to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019057 RID: 102487 RVA: 0x0071EF7C File Offset: 0x0071D17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindChildGameObject_R_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			string name;
			LuaObject.checkType(l, 2, out name);
			GameObject o = GameObjectUtility.FindChildGameObject_R(go, name);
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

	// Token: 0x06019058 RID: 102488 RVA: 0x0071EFDC File Offset: 0x0071D1DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDefaultName_s(IntPtr l)
	{
		int result;
		try
		{
			string assetName;
			LuaObject.checkType(l, 1, out assetName);
			string defaultName = GameObjectUtility.GetDefaultName(assetName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, defaultName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019059 RID: 102489 RVA: 0x0071F030 File Offset: 0x0071D230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddControllerToGameObject_s(IntPtr l)
	{
		int result;
		try
		{
			Type type;
			LuaObject.checkType(l, 1, out type);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			PrefabControllerBase o = GameObjectUtility.AddControllerToGameObject(type, go);
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

	// Token: 0x0601905A RID: 102490 RVA: 0x0071F090 File Offset: 0x0071D290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindGameObjectByName_s(IntPtr l)
	{
		int result;
		try
		{
			Transform parent;
			LuaObject.checkType<Transform>(l, 1, out parent);
			string name;
			LuaObject.checkType(l, 2, out name);
			GameObject o = GameObjectUtility.FindGameObjectByName(parent, name);
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

	// Token: 0x0601905B RID: 102491 RVA: 0x0071F0F0 File Offset: 0x0071D2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindComponentByName_s(IntPtr l)
	{
		int result;
		try
		{
			Transform parent;
			LuaObject.checkType<Transform>(l, 1, out parent);
			string name;
			LuaObject.checkType(l, 2, out name);
			MonoBehaviour o = GameObjectUtility.FindComponentByName<MonoBehaviour>(parent, name);
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

	// Token: 0x0601905C RID: 102492 RVA: 0x0071F150 File Offset: 0x0071D350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloneGameObject_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject cloneObj;
			LuaObject.checkType<GameObject>(l, 1, out cloneObj);
			Transform parent;
			LuaObject.checkType<Transform>(l, 2, out parent);
			GameObject o = GameObjectUtility.CloneGameObject(cloneObj, parent);
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

	// Token: 0x0601905D RID: 102493 RVA: 0x0071F1B0 File Offset: 0x0071D3B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DestroyChildren_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 1, out obj);
			GameObjectUtility.DestroyChildren(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601905E RID: 102494 RVA: 0x0071F1FC File Offset: 0x0071D3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyChildrenImmediate_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 1, out obj);
			GameObjectUtility.DestroyChildrenImmediate(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601905F RID: 102495 RVA: 0x0071F248 File Offset: 0x0071D448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DestroyComponentList_s(IntPtr l)
	{
		int result;
		try
		{
			List<MonoBehaviour> list;
			LuaObject.checkType<List<MonoBehaviour>>(l, 1, out list);
			GameObjectUtility.DestroyComponentList<MonoBehaviour>(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019060 RID: 102496 RVA: 0x0071F294 File Offset: 0x0071D494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InactiveComponentList_s(IntPtr l)
	{
		int result;
		try
		{
			List<MonoBehaviour> list;
			LuaObject.checkType<List<MonoBehaviour>>(l, 1, out list);
			GameObjectUtility.InactiveComponentList<MonoBehaviour>(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019061 RID: 102497 RVA: 0x0071F2E0 File Offset: 0x0071D4E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasChinese_s(IntPtr l)
	{
		int result;
		try
		{
			string str;
			LuaObject.checkType(l, 1, out str);
			bool b = GameObjectUtility.HasChinese(str);
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

	// Token: 0x06019062 RID: 102498 RVA: 0x0071F334 File Offset: 0x0071D534
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SceneRoot(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GameObjectUtility.SceneRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019063 RID: 102499 RVA: 0x0071F37C File Offset: 0x0071D57C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.GameObjectUtility");
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.FindChildObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.FindChildGameObject_R_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.GetDefaultName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.AddControllerToGameObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.FindGameObjectByName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.FindComponentByName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.CloneGameObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.DestroyChildren_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.DestroyChildrenImmediate_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.DestroyComponentList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.InactiveComponentList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.HasChinese_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cacheB);
		string name = "SceneRoot";
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.get_SceneRoot);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cacheC, null, false);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_GameObjectUtility.<>f__mg$cacheD, typeof(GameObjectUtility));
	}

	// Token: 0x0400F4F1 RID: 62705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F4F2 RID: 62706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F4F3 RID: 62707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F4F4 RID: 62708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F4F5 RID: 62709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F4F6 RID: 62710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F4F7 RID: 62711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F4F8 RID: 62712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F4F9 RID: 62713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F4FA RID: 62714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F4FB RID: 62715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F4FC RID: 62716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F4FD RID: 62717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F4FE RID: 62718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
