using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

// Token: 0x020017C5 RID: 6085
[Preserve]
public class Lua_UnityEngine_SceneManagement_Scene : LuaObject
{
	// Token: 0x06023C9E RID: 146590 RVA: 0x00C89648 File Offset: 0x00C87848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Scene scene = default(Scene);
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

	// Token: 0x06023C9F RID: 146591 RVA: 0x00C89698 File Offset: 0x00C87898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsValid(IntPtr l)
	{
		int result;
		try
		{
			Scene scene;
			LuaObject.checkValueType<Scene>(l, 1, out scene);
			bool b = scene.IsValid();
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

	// Token: 0x06023CA0 RID: 146592 RVA: 0x00C896EC File Offset: 0x00C878EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRootGameObjects(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Scene scene;
				LuaObject.checkValueType<Scene>(l, 1, out scene);
				GameObject[] rootGameObjects = scene.GetRootGameObjects();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rootGameObjects);
				result = 2;
			}
			else if (num == 2)
			{
				Scene scene2;
				LuaObject.checkValueType<Scene>(l, 1, out scene2);
				List<GameObject> rootGameObjects2;
				LuaObject.checkType<List<GameObject>>(l, 2, out rootGameObjects2);
				scene2.GetRootGameObjects(rootGameObjects2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, scene2);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetRootGameObjects to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CA1 RID: 146593 RVA: 0x00C897A8 File Offset: 0x00C879A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Scene lhs;
			LuaObject.checkValueType<Scene>(l, 1, out lhs);
			Scene rhs;
			LuaObject.checkValueType<Scene>(l, 2, out rhs);
			bool b = lhs == rhs;
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

	// Token: 0x06023CA2 RID: 146594 RVA: 0x00C89808 File Offset: 0x00C87A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Scene lhs;
			LuaObject.checkValueType<Scene>(l, 1, out lhs);
			Scene rhs;
			LuaObject.checkValueType<Scene>(l, 2, out rhs);
			bool b = lhs != rhs;
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

	// Token: 0x06023CA3 RID: 146595 RVA: 0x00C89868 File Offset: 0x00C87A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_path(IntPtr l)
	{
		int result;
		try
		{
			Scene scene;
			LuaObject.checkValueType<Scene>(l, 1, out scene);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scene.path);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CA4 RID: 146596 RVA: 0x00C898BC File Offset: 0x00C87ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_name(IntPtr l)
	{
		int result;
		try
		{
			Scene scene;
			LuaObject.checkValueType<Scene>(l, 1, out scene);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scene.name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CA5 RID: 146597 RVA: 0x00C89910 File Offset: 0x00C87B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isLoaded(IntPtr l)
	{
		int result;
		try
		{
			Scene scene;
			LuaObject.checkValueType<Scene>(l, 1, out scene);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scene.isLoaded);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CA6 RID: 146598 RVA: 0x00C89964 File Offset: 0x00C87B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_buildIndex(IntPtr l)
	{
		int result;
		try
		{
			Scene scene;
			LuaObject.checkValueType<Scene>(l, 1, out scene);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scene.buildIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CA7 RID: 146599 RVA: 0x00C899B8 File Offset: 0x00C87BB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isDirty(IntPtr l)
	{
		int result;
		try
		{
			Scene scene;
			LuaObject.checkValueType<Scene>(l, 1, out scene);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scene.isDirty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CA8 RID: 146600 RVA: 0x00C89A0C File Offset: 0x00C87C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rootCount(IntPtr l)
	{
		int result;
		try
		{
			Scene scene;
			LuaObject.checkValueType<Scene>(l, 1, out scene);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scene.rootCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CA9 RID: 146601 RVA: 0x00C89A60 File Offset: 0x00C87C60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SceneManagement.Scene");
		if (Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_Scene.IsValid);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache0);
		if (Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_Scene.GetRootGameObjects);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache1);
		if (Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_Scene.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache2);
		if (Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_Scene.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache3);
		string name = "path";
		if (Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_Scene.get_path);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache4, null, true);
		string name2 = "name";
		if (Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_Scene.get_name);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache5, null, true);
		string name3 = "isLoaded";
		if (Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_Scene.get_isLoaded);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache6, null, true);
		string name4 = "buildIndex";
		if (Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_Scene.get_buildIndex);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache7, null, true);
		string name5 = "isDirty";
		if (Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_Scene.get_isDirty);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache8, null, true);
		string name6 = "rootCount";
		if (Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_SceneManagement_Scene.get_rootCount);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cache9, null, true);
		if (Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_SceneManagement_Scene.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_SceneManagement_Scene.<>f__mg$cacheA, typeof(Scene), typeof(ValueType));
	}

	// Token: 0x04019972 RID: 104818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019973 RID: 104819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019974 RID: 104820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019975 RID: 104821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019976 RID: 104822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019977 RID: 104823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019978 RID: 104824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019979 RID: 104825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401997A RID: 104826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401997B RID: 104827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401997C RID: 104828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
