using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016E3 RID: 5859
[Preserve]
public class Lua_UnityEngine_HumanBone : LuaObject
{
	// Token: 0x0602332C RID: 144172 RVA: 0x00C366D8 File Offset: 0x00C348D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HumanBone humanBone = default(HumanBone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanBone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602332D RID: 144173 RVA: 0x00C36728 File Offset: 0x00C34928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_limit(IntPtr l)
	{
		int result;
		try
		{
			HumanBone humanBone;
			LuaObject.checkValueType<HumanBone>(l, 1, out humanBone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanBone.limit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602332E RID: 144174 RVA: 0x00C36780 File Offset: 0x00C34980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_limit(IntPtr l)
	{
		int result;
		try
		{
			HumanBone humanBone;
			LuaObject.checkValueType<HumanBone>(l, 1, out humanBone);
			HumanLimit limit;
			LuaObject.checkValueType<HumanLimit>(l, 2, out limit);
			humanBone.limit = limit;
			LuaObject.setBack(l, humanBone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602332F RID: 144175 RVA: 0x00C367E4 File Offset: 0x00C349E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_boneName(IntPtr l)
	{
		int result;
		try
		{
			HumanBone humanBone;
			LuaObject.checkValueType<HumanBone>(l, 1, out humanBone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanBone.boneName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023330 RID: 144176 RVA: 0x00C36838 File Offset: 0x00C34A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_boneName(IntPtr l)
	{
		int result;
		try
		{
			HumanBone humanBone;
			LuaObject.checkValueType<HumanBone>(l, 1, out humanBone);
			string boneName;
			LuaObject.checkType(l, 2, out boneName);
			humanBone.boneName = boneName;
			LuaObject.setBack(l, humanBone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023331 RID: 144177 RVA: 0x00C3689C File Offset: 0x00C34A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_humanName(IntPtr l)
	{
		int result;
		try
		{
			HumanBone humanBone;
			LuaObject.checkValueType<HumanBone>(l, 1, out humanBone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanBone.humanName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023332 RID: 144178 RVA: 0x00C368F0 File Offset: 0x00C34AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_humanName(IntPtr l)
	{
		int result;
		try
		{
			HumanBone humanBone;
			LuaObject.checkValueType<HumanBone>(l, 1, out humanBone);
			string humanName;
			LuaObject.checkType(l, 2, out humanName);
			humanBone.humanName = humanName;
			LuaObject.setBack(l, humanBone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023333 RID: 144179 RVA: 0x00C36954 File Offset: 0x00C34B54
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.HumanBone");
		string name = "limit";
		if (Lua_UnityEngine_HumanBone.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_HumanBone.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_HumanBone.get_limit);
		}
		LuaCSFunction get = Lua_UnityEngine_HumanBone.<>f__mg$cache0;
		if (Lua_UnityEngine_HumanBone.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_HumanBone.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_HumanBone.set_limit);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_HumanBone.<>f__mg$cache1, true);
		string name2 = "boneName";
		if (Lua_UnityEngine_HumanBone.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_HumanBone.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_HumanBone.get_boneName);
		}
		LuaCSFunction get2 = Lua_UnityEngine_HumanBone.<>f__mg$cache2;
		if (Lua_UnityEngine_HumanBone.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_HumanBone.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_HumanBone.set_boneName);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_HumanBone.<>f__mg$cache3, true);
		string name3 = "humanName";
		if (Lua_UnityEngine_HumanBone.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_HumanBone.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_HumanBone.get_humanName);
		}
		LuaCSFunction get3 = Lua_UnityEngine_HumanBone.<>f__mg$cache4;
		if (Lua_UnityEngine_HumanBone.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_HumanBone.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_HumanBone.set_humanName);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_HumanBone.<>f__mg$cache5, true);
		if (Lua_UnityEngine_HumanBone.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_HumanBone.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_HumanBone.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_HumanBone.<>f__mg$cache6, typeof(HumanBone), typeof(ValueType));
	}

	// Token: 0x040191C4 RID: 102852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040191C5 RID: 102853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040191C6 RID: 102854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040191C7 RID: 102855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040191C8 RID: 102856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040191C9 RID: 102857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040191CA RID: 102858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
