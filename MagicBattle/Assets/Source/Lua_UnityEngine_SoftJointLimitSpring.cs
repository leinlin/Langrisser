using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017D9 RID: 6105
[Preserve]
public class Lua_UnityEngine_SoftJointLimitSpring : LuaObject
{
	// Token: 0x06023D54 RID: 146772 RVA: 0x00C8EF30 File Offset: 0x00C8D130
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SoftJointLimitSpring softJointLimitSpring = default(SoftJointLimitSpring);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, softJointLimitSpring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D55 RID: 146773 RVA: 0x00C8EF80 File Offset: 0x00C8D180
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_spring(IntPtr l)
	{
		int result;
		try
		{
			SoftJointLimitSpring softJointLimitSpring;
			LuaObject.checkValueType<SoftJointLimitSpring>(l, 1, out softJointLimitSpring);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, softJointLimitSpring.spring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D56 RID: 146774 RVA: 0x00C8EFD4 File Offset: 0x00C8D1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_spring(IntPtr l)
	{
		int result;
		try
		{
			SoftJointLimitSpring softJointLimitSpring;
			LuaObject.checkValueType<SoftJointLimitSpring>(l, 1, out softJointLimitSpring);
			float spring;
			LuaObject.checkType(l, 2, out spring);
			softJointLimitSpring.spring = spring;
			LuaObject.setBack(l, softJointLimitSpring);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D57 RID: 146775 RVA: 0x00C8F038 File Offset: 0x00C8D238
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_damper(IntPtr l)
	{
		int result;
		try
		{
			SoftJointLimitSpring softJointLimitSpring;
			LuaObject.checkValueType<SoftJointLimitSpring>(l, 1, out softJointLimitSpring);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, softJointLimitSpring.damper);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D58 RID: 146776 RVA: 0x00C8F08C File Offset: 0x00C8D28C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_damper(IntPtr l)
	{
		int result;
		try
		{
			SoftJointLimitSpring softJointLimitSpring;
			LuaObject.checkValueType<SoftJointLimitSpring>(l, 1, out softJointLimitSpring);
			float damper;
			LuaObject.checkType(l, 2, out damper);
			softJointLimitSpring.damper = damper;
			LuaObject.setBack(l, softJointLimitSpring);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D59 RID: 146777 RVA: 0x00C8F0F0 File Offset: 0x00C8D2F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SoftJointLimitSpring");
		string name = "spring";
		if (Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SoftJointLimitSpring.get_spring);
		}
		LuaCSFunction get = Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache0;
		if (Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SoftJointLimitSpring.set_spring);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache1, true);
		string name2 = "damper";
		if (Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SoftJointLimitSpring.get_damper);
		}
		LuaCSFunction get2 = Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache2;
		if (Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SoftJointLimitSpring.set_damper);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache3, true);
		if (Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SoftJointLimitSpring.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_SoftJointLimitSpring.<>f__mg$cache4, typeof(SoftJointLimitSpring), typeof(ValueType));
	}

	// Token: 0x04019A00 RID: 104960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A01 RID: 104961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019A02 RID: 104962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019A03 RID: 104963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019A04 RID: 104964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
