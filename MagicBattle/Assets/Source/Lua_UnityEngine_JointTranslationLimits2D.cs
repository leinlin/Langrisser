using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001700 RID: 5888
[Preserve]
public class Lua_UnityEngine_JointTranslationLimits2D : LuaObject
{
	// Token: 0x06023442 RID: 144450 RVA: 0x00C3DB18 File Offset: 0x00C3BD18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			JointTranslationLimits2D jointTranslationLimits2D = default(JointTranslationLimits2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointTranslationLimits2D);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023443 RID: 144451 RVA: 0x00C3DB68 File Offset: 0x00C3BD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_min(IntPtr l)
	{
		int result;
		try
		{
			JointTranslationLimits2D jointTranslationLimits2D;
			LuaObject.checkValueType<JointTranslationLimits2D>(l, 1, out jointTranslationLimits2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointTranslationLimits2D.min);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023444 RID: 144452 RVA: 0x00C3DBBC File Offset: 0x00C3BDBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_min(IntPtr l)
	{
		int result;
		try
		{
			JointTranslationLimits2D jointTranslationLimits2D;
			LuaObject.checkValueType<JointTranslationLimits2D>(l, 1, out jointTranslationLimits2D);
			float min;
			LuaObject.checkType(l, 2, out min);
			jointTranslationLimits2D.min = min;
			LuaObject.setBack(l, jointTranslationLimits2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023445 RID: 144453 RVA: 0x00C3DC20 File Offset: 0x00C3BE20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_max(IntPtr l)
	{
		int result;
		try
		{
			JointTranslationLimits2D jointTranslationLimits2D;
			LuaObject.checkValueType<JointTranslationLimits2D>(l, 1, out jointTranslationLimits2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointTranslationLimits2D.max);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023446 RID: 144454 RVA: 0x00C3DC74 File Offset: 0x00C3BE74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_max(IntPtr l)
	{
		int result;
		try
		{
			JointTranslationLimits2D jointTranslationLimits2D;
			LuaObject.checkValueType<JointTranslationLimits2D>(l, 1, out jointTranslationLimits2D);
			float max;
			LuaObject.checkType(l, 2, out max);
			jointTranslationLimits2D.max = max;
			LuaObject.setBack(l, jointTranslationLimits2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023447 RID: 144455 RVA: 0x00C3DCD8 File Offset: 0x00C3BED8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.JointTranslationLimits2D");
		string name = "min";
		if (Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_JointTranslationLimits2D.get_min);
		}
		LuaCSFunction get = Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache0;
		if (Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_JointTranslationLimits2D.set_min);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache1, true);
		string name2 = "max";
		if (Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_JointTranslationLimits2D.get_max);
		}
		LuaCSFunction get2 = Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache2;
		if (Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_JointTranslationLimits2D.set_max);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache3, true);
		if (Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_JointTranslationLimits2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_JointTranslationLimits2D.<>f__mg$cache4, typeof(JointTranslationLimits2D), typeof(ValueType));
	}

	// Token: 0x040192A0 RID: 103072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040192A1 RID: 103073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040192A2 RID: 103074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040192A3 RID: 103075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040192A4 RID: 103076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
