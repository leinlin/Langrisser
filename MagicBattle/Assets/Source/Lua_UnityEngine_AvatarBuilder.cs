using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001637 RID: 5687
[Preserve]
public class Lua_UnityEngine_AvatarBuilder : LuaObject
{
	// Token: 0x06022C1F RID: 142367 RVA: 0x00BFFF88 File Offset: 0x00BFE188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AvatarBuilder o = new AvatarBuilder();
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

	// Token: 0x06022C20 RID: 142368 RVA: 0x00BFFFD0 File Offset: 0x00BFE1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuildHumanAvatar_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 2, out humanDescription);
			Avatar o = AvatarBuilder.BuildHumanAvatar(go, humanDescription);
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

	// Token: 0x06022C21 RID: 142369 RVA: 0x00C00030 File Offset: 0x00BFE230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuildGenericAvatar_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			string rootMotionTransformName;
			LuaObject.checkType(l, 2, out rootMotionTransformName);
			Avatar o = AvatarBuilder.BuildGenericAvatar(go, rootMotionTransformName);
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

	// Token: 0x06022C22 RID: 142370 RVA: 0x00C00090 File Offset: 0x00BFE290
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AvatarBuilder");
		if (Lua_UnityEngine_AvatarBuilder.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AvatarBuilder.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AvatarBuilder.BuildHumanAvatar_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AvatarBuilder.<>f__mg$cache0);
		if (Lua_UnityEngine_AvatarBuilder.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AvatarBuilder.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AvatarBuilder.BuildGenericAvatar_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AvatarBuilder.<>f__mg$cache1);
		if (Lua_UnityEngine_AvatarBuilder.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AvatarBuilder.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AvatarBuilder.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AvatarBuilder.<>f__mg$cache2, typeof(AvatarBuilder));
	}

	// Token: 0x04018C0F RID: 101391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C10 RID: 101392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C11 RID: 101393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
