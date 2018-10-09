using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016DD RID: 5853
[Preserve]
public class Lua_UnityEngine_Hash128 : LuaObject
{
	// Token: 0x06023300 RID: 144128 RVA: 0x00C352C0 File Offset: 0x00C334C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			uint u32_;
			LuaObject.checkType(l, 2, out u32_);
			uint u32_2;
			LuaObject.checkType(l, 3, out u32_2);
			uint u32_3;
			LuaObject.checkType(l, 4, out u32_3);
			uint u32_4;
			LuaObject.checkType(l, 5, out u32_4);
			Hash128 hash = new Hash128(u32_, u32_2, u32_3, u32_4);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hash);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023301 RID: 144129 RVA: 0x00C35340 File Offset: 0x00C33540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Parse_s(IntPtr l)
	{
		int result;
		try
		{
			string hashString;
			LuaObject.checkType(l, 1, out hashString);
			Hash128 hash = Hash128.Parse(hashString);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hash);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023302 RID: 144130 RVA: 0x00C35398 File Offset: 0x00C33598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Hash128 hash;
			LuaObject.checkValueType<Hash128>(l, 1, out hash);
			Hash128 hash2;
			LuaObject.checkValueType<Hash128>(l, 2, out hash2);
			bool b = hash == hash2;
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

	// Token: 0x06023303 RID: 144131 RVA: 0x00C353F8 File Offset: 0x00C335F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Hash128 hash;
			LuaObject.checkValueType<Hash128>(l, 1, out hash);
			Hash128 hash2;
			LuaObject.checkValueType<Hash128>(l, 2, out hash2);
			bool b = hash != hash2;
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

	// Token: 0x06023304 RID: 144132 RVA: 0x00C35458 File Offset: 0x00C33658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isValid(IntPtr l)
	{
		int result;
		try
		{
			Hash128 hash;
			LuaObject.checkValueType<Hash128>(l, 1, out hash);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hash.isValid);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023305 RID: 144133 RVA: 0x00C354AC File Offset: 0x00C336AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Hash128");
		if (Lua_UnityEngine_Hash128.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Hash128.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Hash128.Parse_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Hash128.<>f__mg$cache0);
		if (Lua_UnityEngine_Hash128.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Hash128.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Hash128.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Hash128.<>f__mg$cache1);
		if (Lua_UnityEngine_Hash128.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Hash128.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Hash128.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Hash128.<>f__mg$cache2);
		string name = "isValid";
		if (Lua_UnityEngine_Hash128.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Hash128.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Hash128.get_isValid);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Hash128.<>f__mg$cache3, null, true);
		if (Lua_UnityEngine_Hash128.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Hash128.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Hash128.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Hash128.<>f__mg$cache4, typeof(Hash128), typeof(ValueType));
	}

	// Token: 0x040191A4 RID: 102820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040191A5 RID: 102821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040191A6 RID: 102822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040191A7 RID: 102823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040191A8 RID: 102824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
