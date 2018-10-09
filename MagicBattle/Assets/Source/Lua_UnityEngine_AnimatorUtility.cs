using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001627 RID: 5671
[Preserve]
public class Lua_UnityEngine_AnimatorUtility : LuaObject
{
	// Token: 0x06022B85 RID: 142213 RVA: 0x00BFB730 File Offset: 0x00BF9930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimatorUtility o = new AnimatorUtility();
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

	// Token: 0x06022B86 RID: 142214 RVA: 0x00BFB778 File Offset: 0x00BF9978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OptimizeTransformHierarchy_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			string[] exposedTransforms;
			LuaObject.checkArray<string>(l, 2, out exposedTransforms);
			AnimatorUtility.OptimizeTransformHierarchy(go, exposedTransforms);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B87 RID: 142215 RVA: 0x00BFB7D0 File Offset: 0x00BF99D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeoptimizeTransformHierarchy_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			AnimatorUtility.DeoptimizeTransformHierarchy(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B88 RID: 142216 RVA: 0x00BFB81C File Offset: 0x00BF9A1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AnimatorUtility");
		if (Lua_UnityEngine_AnimatorUtility.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AnimatorUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AnimatorUtility.OptimizeTransformHierarchy_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimatorUtility.<>f__mg$cache0);
		if (Lua_UnityEngine_AnimatorUtility.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AnimatorUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AnimatorUtility.DeoptimizeTransformHierarchy_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimatorUtility.<>f__mg$cache1);
		if (Lua_UnityEngine_AnimatorUtility.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AnimatorUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AnimatorUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AnimatorUtility.<>f__mg$cache2, typeof(AnimatorUtility));
	}

	// Token: 0x04018B95 RID: 101269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018B96 RID: 101270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018B97 RID: 101271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
