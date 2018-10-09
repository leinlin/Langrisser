using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200161E RID: 5662
[Preserve]
public class Lua_UnityEngine_AnimatorClipInfo : LuaObject
{
	// Token: 0x06022B49 RID: 142153 RVA: 0x00BF9F60 File Offset: 0x00BF8160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimatorClipInfo animatorClipInfo = default(AnimatorClipInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorClipInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B4A RID: 142154 RVA: 0x00BF9FB0 File Offset: 0x00BF81B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clip(IntPtr l)
	{
		int result;
		try
		{
			AnimatorClipInfo animatorClipInfo;
			LuaObject.checkValueType<AnimatorClipInfo>(l, 1, out animatorClipInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorClipInfo.clip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B4B RID: 142155 RVA: 0x00BFA004 File Offset: 0x00BF8204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_weight(IntPtr l)
	{
		int result;
		try
		{
			AnimatorClipInfo animatorClipInfo;
			LuaObject.checkValueType<AnimatorClipInfo>(l, 1, out animatorClipInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorClipInfo.weight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B4C RID: 142156 RVA: 0x00BFA058 File Offset: 0x00BF8258
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AnimatorClipInfo");
		string name = "clip";
		if (Lua_UnityEngine_AnimatorClipInfo.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AnimatorClipInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AnimatorClipInfo.get_clip);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_AnimatorClipInfo.<>f__mg$cache0, null, true);
		string name2 = "weight";
		if (Lua_UnityEngine_AnimatorClipInfo.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AnimatorClipInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AnimatorClipInfo.get_weight);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_AnimatorClipInfo.<>f__mg$cache1, null, true);
		if (Lua_UnityEngine_AnimatorClipInfo.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AnimatorClipInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AnimatorClipInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AnimatorClipInfo.<>f__mg$cache2, typeof(AnimatorClipInfo), typeof(ValueType));
	}

	// Token: 0x04018B6B RID: 101227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018B6C RID: 101228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018B6D RID: 101229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
