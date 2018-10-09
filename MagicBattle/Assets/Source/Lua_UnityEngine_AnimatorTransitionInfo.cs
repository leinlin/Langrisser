using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001625 RID: 5669
[Preserve]
public class Lua_UnityEngine_AnimatorTransitionInfo : LuaObject
{
	// Token: 0x06022B77 RID: 142199 RVA: 0x00BFB1D0 File Offset: 0x00BF93D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimatorTransitionInfo animatorTransitionInfo = default(AnimatorTransitionInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorTransitionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B78 RID: 142200 RVA: 0x00BFB220 File Offset: 0x00BF9420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsName(IntPtr l)
	{
		int result;
		try
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			LuaObject.checkValueType<AnimatorTransitionInfo>(l, 1, out animatorTransitionInfo);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool b = animatorTransitionInfo.IsName(name);
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

	// Token: 0x06022B79 RID: 142201 RVA: 0x00BFB280 File Offset: 0x00BF9480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsUserName(IntPtr l)
	{
		int result;
		try
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			LuaObject.checkValueType<AnimatorTransitionInfo>(l, 1, out animatorTransitionInfo);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool b = animatorTransitionInfo.IsUserName(name);
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

	// Token: 0x06022B7A RID: 142202 RVA: 0x00BFB2E0 File Offset: 0x00BF94E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fullPathHash(IntPtr l)
	{
		int result;
		try
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			LuaObject.checkValueType<AnimatorTransitionInfo>(l, 1, out animatorTransitionInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorTransitionInfo.fullPathHash);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B7B RID: 142203 RVA: 0x00BFB334 File Offset: 0x00BF9534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_nameHash(IntPtr l)
	{
		int result;
		try
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			LuaObject.checkValueType<AnimatorTransitionInfo>(l, 1, out animatorTransitionInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorTransitionInfo.nameHash);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B7C RID: 142204 RVA: 0x00BFB388 File Offset: 0x00BF9588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_userNameHash(IntPtr l)
	{
		int result;
		try
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			LuaObject.checkValueType<AnimatorTransitionInfo>(l, 1, out animatorTransitionInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorTransitionInfo.userNameHash);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B7D RID: 142205 RVA: 0x00BFB3DC File Offset: 0x00BF95DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_durationUnit(IntPtr l)
	{
		int result;
		try
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			LuaObject.checkValueType<AnimatorTransitionInfo>(l, 1, out animatorTransitionInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animatorTransitionInfo.durationUnit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B7E RID: 142206 RVA: 0x00BFB430 File Offset: 0x00BF9630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_duration(IntPtr l)
	{
		int result;
		try
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			LuaObject.checkValueType<AnimatorTransitionInfo>(l, 1, out animatorTransitionInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorTransitionInfo.duration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B7F RID: 142207 RVA: 0x00BFB484 File Offset: 0x00BF9684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normalizedTime(IntPtr l)
	{
		int result;
		try
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			LuaObject.checkValueType<AnimatorTransitionInfo>(l, 1, out animatorTransitionInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorTransitionInfo.normalizedTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B80 RID: 142208 RVA: 0x00BFB4D8 File Offset: 0x00BF96D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_anyState(IntPtr l)
	{
		int result;
		try
		{
			AnimatorTransitionInfo animatorTransitionInfo;
			LuaObject.checkValueType<AnimatorTransitionInfo>(l, 1, out animatorTransitionInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorTransitionInfo.anyState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B81 RID: 142209 RVA: 0x00BFB52C File Offset: 0x00BF972C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AnimatorTransitionInfo");
		if (Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AnimatorTransitionInfo.IsName);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache0);
		if (Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AnimatorTransitionInfo.IsUserName);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache1);
		string name = "fullPathHash";
		if (Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AnimatorTransitionInfo.get_fullPathHash);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache2, null, true);
		string name2 = "nameHash";
		if (Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AnimatorTransitionInfo.get_nameHash);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache3, null, true);
		string name3 = "userNameHash";
		if (Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AnimatorTransitionInfo.get_userNameHash);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache4, null, true);
		string name4 = "durationUnit";
		if (Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AnimatorTransitionInfo.get_durationUnit);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache5, null, true);
		string name5 = "duration";
		if (Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_AnimatorTransitionInfo.get_duration);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache6, null, true);
		string name6 = "normalizedTime";
		if (Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_AnimatorTransitionInfo.get_normalizedTime);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache7, null, true);
		string name7 = "anyState";
		if (Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_AnimatorTransitionInfo.get_anyState);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache8, null, true);
		if (Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_AnimatorTransitionInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AnimatorTransitionInfo.<>f__mg$cache9, typeof(AnimatorTransitionInfo), typeof(ValueType));
	}

	// Token: 0x04018B8B RID: 101259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018B8C RID: 101260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018B8D RID: 101261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018B8E RID: 101262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018B8F RID: 101263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018B90 RID: 101264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018B91 RID: 101265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018B92 RID: 101266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018B93 RID: 101267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018B94 RID: 101268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
