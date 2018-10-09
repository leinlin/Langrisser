using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001624 RID: 5668
[Preserve]
public class Lua_UnityEngine_AnimatorStateInfo : LuaObject
{
	// Token: 0x06022B6A RID: 142186 RVA: 0x00BFAC30 File Offset: 0x00BF8E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimatorStateInfo animatorStateInfo = default(AnimatorStateInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorStateInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B6B RID: 142187 RVA: 0x00BFAC80 File Offset: 0x00BF8E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsName(IntPtr l)
	{
		int result;
		try
		{
			AnimatorStateInfo animatorStateInfo;
			LuaObject.checkValueType<AnimatorStateInfo>(l, 1, out animatorStateInfo);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool b = animatorStateInfo.IsName(name);
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

	// Token: 0x06022B6C RID: 142188 RVA: 0x00BFACE0 File Offset: 0x00BF8EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTag(IntPtr l)
	{
		int result;
		try
		{
			AnimatorStateInfo animatorStateInfo;
			LuaObject.checkValueType<AnimatorStateInfo>(l, 1, out animatorStateInfo);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			bool b = animatorStateInfo.IsTag(tag);
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

	// Token: 0x06022B6D RID: 142189 RVA: 0x00BFAD40 File Offset: 0x00BF8F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fullPathHash(IntPtr l)
	{
		int result;
		try
		{
			AnimatorStateInfo animatorStateInfo;
			LuaObject.checkValueType<AnimatorStateInfo>(l, 1, out animatorStateInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorStateInfo.fullPathHash);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B6E RID: 142190 RVA: 0x00BFAD94 File Offset: 0x00BF8F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shortNameHash(IntPtr l)
	{
		int result;
		try
		{
			AnimatorStateInfo animatorStateInfo;
			LuaObject.checkValueType<AnimatorStateInfo>(l, 1, out animatorStateInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorStateInfo.shortNameHash);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B6F RID: 142191 RVA: 0x00BFADE8 File Offset: 0x00BF8FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normalizedTime(IntPtr l)
	{
		int result;
		try
		{
			AnimatorStateInfo animatorStateInfo;
			LuaObject.checkValueType<AnimatorStateInfo>(l, 1, out animatorStateInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorStateInfo.normalizedTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B70 RID: 142192 RVA: 0x00BFAE3C File Offset: 0x00BF903C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_length(IntPtr l)
	{
		int result;
		try
		{
			AnimatorStateInfo animatorStateInfo;
			LuaObject.checkValueType<AnimatorStateInfo>(l, 1, out animatorStateInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorStateInfo.length);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B71 RID: 142193 RVA: 0x00BFAE90 File Offset: 0x00BF9090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_speed(IntPtr l)
	{
		int result;
		try
		{
			AnimatorStateInfo animatorStateInfo;
			LuaObject.checkValueType<AnimatorStateInfo>(l, 1, out animatorStateInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorStateInfo.speed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B72 RID: 142194 RVA: 0x00BFAEE4 File Offset: 0x00BF90E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_speedMultiplier(IntPtr l)
	{
		int result;
		try
		{
			AnimatorStateInfo animatorStateInfo;
			LuaObject.checkValueType<AnimatorStateInfo>(l, 1, out animatorStateInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorStateInfo.speedMultiplier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B73 RID: 142195 RVA: 0x00BFAF38 File Offset: 0x00BF9138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tagHash(IntPtr l)
	{
		int result;
		try
		{
			AnimatorStateInfo animatorStateInfo;
			LuaObject.checkValueType<AnimatorStateInfo>(l, 1, out animatorStateInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorStateInfo.tagHash);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B74 RID: 142196 RVA: 0x00BFAF8C File Offset: 0x00BF918C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_loop(IntPtr l)
	{
		int result;
		try
		{
			AnimatorStateInfo animatorStateInfo;
			LuaObject.checkValueType<AnimatorStateInfo>(l, 1, out animatorStateInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorStateInfo.loop);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B75 RID: 142197 RVA: 0x00BFAFE0 File Offset: 0x00BF91E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AnimatorStateInfo");
		if (Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AnimatorStateInfo.IsName);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache0);
		if (Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AnimatorStateInfo.IsTag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache1);
		string name = "fullPathHash";
		if (Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AnimatorStateInfo.get_fullPathHash);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache2, null, true);
		string name2 = "shortNameHash";
		if (Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AnimatorStateInfo.get_shortNameHash);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache3, null, true);
		string name3 = "normalizedTime";
		if (Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AnimatorStateInfo.get_normalizedTime);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache4, null, true);
		string name4 = "length";
		if (Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AnimatorStateInfo.get_length);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache5, null, true);
		string name5 = "speed";
		if (Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_AnimatorStateInfo.get_speed);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache6, null, true);
		string name6 = "speedMultiplier";
		if (Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_AnimatorStateInfo.get_speedMultiplier);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache7, null, true);
		string name7 = "tagHash";
		if (Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_AnimatorStateInfo.get_tagHash);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache8, null, true);
		string name8 = "loop";
		if (Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_AnimatorStateInfo.get_loop);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cache9, null, true);
		if (Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_AnimatorStateInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AnimatorStateInfo.<>f__mg$cacheA, typeof(AnimatorStateInfo), typeof(ValueType));
	}

	// Token: 0x04018B80 RID: 101248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018B81 RID: 101249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018B82 RID: 101250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018B83 RID: 101251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018B84 RID: 101252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018B85 RID: 101253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018B86 RID: 101254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018B87 RID: 101255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018B88 RID: 101256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018B89 RID: 101257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018B8A RID: 101258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
