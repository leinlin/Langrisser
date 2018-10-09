using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017D8 RID: 6104
[Preserve]
public class Lua_UnityEngine_SoftJointLimit : LuaObject
{
	// Token: 0x06023D4B RID: 146763 RVA: 0x00C8EB8C File Offset: 0x00C8CD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SoftJointLimit softJointLimit = default(SoftJointLimit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, softJointLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D4C RID: 146764 RVA: 0x00C8EBDC File Offset: 0x00C8CDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_limit(IntPtr l)
	{
		int result;
		try
		{
			SoftJointLimit softJointLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 1, out softJointLimit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, softJointLimit.limit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D4D RID: 146765 RVA: 0x00C8EC30 File Offset: 0x00C8CE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_limit(IntPtr l)
	{
		int result;
		try
		{
			SoftJointLimit softJointLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 1, out softJointLimit);
			float limit;
			LuaObject.checkType(l, 2, out limit);
			softJointLimit.limit = limit;
			LuaObject.setBack(l, softJointLimit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D4E RID: 146766 RVA: 0x00C8EC94 File Offset: 0x00C8CE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bounciness(IntPtr l)
	{
		int result;
		try
		{
			SoftJointLimit softJointLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 1, out softJointLimit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, softJointLimit.bounciness);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D4F RID: 146767 RVA: 0x00C8ECE8 File Offset: 0x00C8CEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bounciness(IntPtr l)
	{
		int result;
		try
		{
			SoftJointLimit softJointLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 1, out softJointLimit);
			float bounciness;
			LuaObject.checkType(l, 2, out bounciness);
			softJointLimit.bounciness = bounciness;
			LuaObject.setBack(l, softJointLimit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D50 RID: 146768 RVA: 0x00C8ED4C File Offset: 0x00C8CF4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_contactDistance(IntPtr l)
	{
		int result;
		try
		{
			SoftJointLimit softJointLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 1, out softJointLimit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, softJointLimit.contactDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D51 RID: 146769 RVA: 0x00C8EDA0 File Offset: 0x00C8CFA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_contactDistance(IntPtr l)
	{
		int result;
		try
		{
			SoftJointLimit softJointLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 1, out softJointLimit);
			float contactDistance;
			LuaObject.checkType(l, 2, out contactDistance);
			softJointLimit.contactDistance = contactDistance;
			LuaObject.setBack(l, softJointLimit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D52 RID: 146770 RVA: 0x00C8EE04 File Offset: 0x00C8D004
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SoftJointLimit");
		string name = "limit";
		if (Lua_UnityEngine_SoftJointLimit.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SoftJointLimit.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SoftJointLimit.get_limit);
		}
		LuaCSFunction get = Lua_UnityEngine_SoftJointLimit.<>f__mg$cache0;
		if (Lua_UnityEngine_SoftJointLimit.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SoftJointLimit.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SoftJointLimit.set_limit);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_SoftJointLimit.<>f__mg$cache1, true);
		string name2 = "bounciness";
		if (Lua_UnityEngine_SoftJointLimit.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SoftJointLimit.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SoftJointLimit.get_bounciness);
		}
		LuaCSFunction get2 = Lua_UnityEngine_SoftJointLimit.<>f__mg$cache2;
		if (Lua_UnityEngine_SoftJointLimit.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SoftJointLimit.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SoftJointLimit.set_bounciness);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_SoftJointLimit.<>f__mg$cache3, true);
		string name3 = "contactDistance";
		if (Lua_UnityEngine_SoftJointLimit.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SoftJointLimit.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SoftJointLimit.get_contactDistance);
		}
		LuaCSFunction get3 = Lua_UnityEngine_SoftJointLimit.<>f__mg$cache4;
		if (Lua_UnityEngine_SoftJointLimit.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SoftJointLimit.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SoftJointLimit.set_contactDistance);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_SoftJointLimit.<>f__mg$cache5, true);
		if (Lua_UnityEngine_SoftJointLimit.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SoftJointLimit.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SoftJointLimit.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_SoftJointLimit.<>f__mg$cache6, typeof(SoftJointLimit), typeof(ValueType));
	}

	// Token: 0x040199F9 RID: 104953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040199FA RID: 104954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040199FB RID: 104955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040199FC RID: 104956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040199FD RID: 104957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040199FE RID: 104958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040199FF RID: 104959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
