using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001622 RID: 5666
[Preserve]
public class Lua_UnityEngine_AnimatorOverrideController : LuaObject
{
	// Token: 0x06022B5E RID: 142174 RVA: 0x00BFA690 File Offset: 0x00BF8890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				AnimatorOverrideController o = new AnimatorOverrideController();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				RuntimeAnimatorController controller;
				LuaObject.checkType<RuntimeAnimatorController>(l, 2, out controller);
				AnimatorOverrideController o = new AnimatorOverrideController(controller);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B5F RID: 142175 RVA: 0x00BFA728 File Offset: 0x00BF8928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOverrides(IntPtr l)
	{
		int result;
		try
		{
			AnimatorOverrideController animatorOverrideController = (AnimatorOverrideController)LuaObject.checkSelf(l);
			List<KeyValuePair<AnimationClip, AnimationClip>> overrides;
			LuaObject.checkType<List<KeyValuePair<AnimationClip, AnimationClip>>>(l, 2, out overrides);
			animatorOverrideController.GetOverrides(overrides);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B60 RID: 142176 RVA: 0x00BFA780 File Offset: 0x00BF8980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ApplyOverrides(IntPtr l)
	{
		int result;
		try
		{
			AnimatorOverrideController animatorOverrideController = (AnimatorOverrideController)LuaObject.checkSelf(l);
			IList<KeyValuePair<AnimationClip, AnimationClip>> overrides;
			LuaObject.checkType<IList<KeyValuePair<AnimationClip, AnimationClip>>>(l, 2, out overrides);
			animatorOverrideController.ApplyOverrides(overrides);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B61 RID: 142177 RVA: 0x00BFA7D8 File Offset: 0x00BF89D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_runtimeAnimatorController(IntPtr l)
	{
		int result;
		try
		{
			AnimatorOverrideController animatorOverrideController = (AnimatorOverrideController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorOverrideController.runtimeAnimatorController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B62 RID: 142178 RVA: 0x00BFA82C File Offset: 0x00BF8A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_runtimeAnimatorController(IntPtr l)
	{
		int result;
		try
		{
			AnimatorOverrideController animatorOverrideController = (AnimatorOverrideController)LuaObject.checkSelf(l);
			RuntimeAnimatorController runtimeAnimatorController;
			LuaObject.checkType<RuntimeAnimatorController>(l, 2, out runtimeAnimatorController);
			animatorOverrideController.runtimeAnimatorController = runtimeAnimatorController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B63 RID: 142179 RVA: 0x00BFA884 File Offset: 0x00BF8A84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_overridesCount(IntPtr l)
	{
		int result;
		try
		{
			AnimatorOverrideController animatorOverrideController = (AnimatorOverrideController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorOverrideController.overridesCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B64 RID: 142180 RVA: 0x00BFA8D8 File Offset: 0x00BF8AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			AnimatorOverrideController animatorOverrideController = (AnimatorOverrideController)LuaObject.checkSelf(l);
			LuaTypes lt = LuaDLL.lua_type(l, 2);
			if (LuaObject.matchType(l, 2, lt, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 2, out name);
				AnimationClip o = animatorOverrideController[name];
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, 2, lt, typeof(AnimationClip)))
			{
				AnimationClip clip;
				LuaObject.checkType<AnimationClip>(l, 2, out clip);
				AnimationClip o2 = animatorOverrideController[clip];
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function getItem to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B65 RID: 142181 RVA: 0x00BFA9B8 File Offset: 0x00BF8BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setItem(IntPtr l)
	{
		int result;
		try
		{
			AnimatorOverrideController animatorOverrideController = (AnimatorOverrideController)LuaObject.checkSelf(l);
			LuaTypes lt = LuaDLL.lua_type(l, 2);
			if (LuaObject.matchType(l, 2, lt, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 2, out name);
				AnimationClip value;
				LuaObject.checkType<AnimationClip>(l, 3, out value);
				animatorOverrideController[name] = value;
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, 2, lt, typeof(AnimationClip)))
			{
				AnimationClip clip;
				LuaObject.checkType<AnimationClip>(l, 2, out clip);
				AnimationClip value2;
				LuaObject.checkType<AnimationClip>(l, 3, out value2);
				animatorOverrideController[clip] = value2;
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function setItem to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B66 RID: 142182 RVA: 0x00BFAA9C File Offset: 0x00BF8C9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AnimatorOverrideController");
		if (Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AnimatorOverrideController.GetOverrides);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache0);
		if (Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AnimatorOverrideController.ApplyOverrides);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache1);
		if (Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AnimatorOverrideController.getItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache2);
		if (Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AnimatorOverrideController.setItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache3);
		string name = "runtimeAnimatorController";
		if (Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AnimatorOverrideController.get_runtimeAnimatorController);
		}
		LuaCSFunction get = Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache4;
		if (Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AnimatorOverrideController.set_runtimeAnimatorController);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache5, true);
		string name2 = "overridesCount";
		if (Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_AnimatorOverrideController.get_overridesCount);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache6, null, true);
		if (Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_AnimatorOverrideController.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AnimatorOverrideController.<>f__mg$cache7, typeof(AnimatorOverrideController), typeof(RuntimeAnimatorController));
	}

	// Token: 0x04018B78 RID: 101240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018B79 RID: 101241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018B7A RID: 101242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018B7B RID: 101243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018B7C RID: 101244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018B7D RID: 101245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018B7E RID: 101246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018B7F RID: 101247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
