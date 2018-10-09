using System;
using System.Runtime.CompilerServices;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015F9 RID: 5625
[Preserve]
public class Lua_BlackJack_UtilityTools_StringCheck : LuaObject
{
	// Token: 0x060227F5 RID: 141301 RVA: 0x00BD4380 File Offset: 0x00BD2580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			StringCheck o = new StringCheck();
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

	// Token: 0x060227F6 RID: 141302 RVA: 0x00BD43C8 File Offset: 0x00BD25C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsStringLegal_s(IntPtr l)
	{
		int result;
		try
		{
			string checkingString;
			LuaObject.checkType(l, 1, out checkingString);
			bool b = StringCheck.IsStringLegal(checkingString);
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

	// Token: 0x060227F7 RID: 141303 RVA: 0x00BD441C File Offset: 0x00BD261C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDigitChar_s(IntPtr l)
	{
		int result;
		try
		{
			char c;
			LuaObject.checkType(l, 1, out c);
			bool b = StringCheck.IsDigitChar(c);
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

	// Token: 0x060227F8 RID: 141304 RVA: 0x00BD4470 File Offset: 0x00BD2670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEnglishChar_s(IntPtr l)
	{
		int result;
		try
		{
			char c;
			LuaObject.checkType(l, 1, out c);
			bool b = StringCheck.IsEnglishChar(c);
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

	// Token: 0x060227F9 RID: 141305 RVA: 0x00BD44C4 File Offset: 0x00BD26C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsChineseChar_s(IntPtr l)
	{
		int result;
		try
		{
			char c;
			LuaObject.checkType(l, 1, out c);
			bool b = StringCheck.IsChineseChar(c);
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

	// Token: 0x060227FA RID: 141306 RVA: 0x00BD4518 File Offset: 0x00BD2718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsJapaneseChar_s(IntPtr l)
	{
		int result;
		try
		{
			char c;
			LuaObject.checkType(l, 1, out c);
			bool b = StringCheck.IsJapaneseChar(c);
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

	// Token: 0x060227FB RID: 141307 RVA: 0x00BD456C File Offset: 0x00BD276C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.UtilityTools.StringCheck");
		if (Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_UtilityTools_StringCheck.IsStringLegal_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache0);
		if (Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_UtilityTools_StringCheck.IsDigitChar_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache1);
		if (Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_UtilityTools_StringCheck.IsEnglishChar_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache2);
		if (Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_UtilityTools_StringCheck.IsChineseChar_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache3);
		if (Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_UtilityTools_StringCheck.IsJapaneseChar_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache4);
		if (Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_UtilityTools_StringCheck.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_UtilityTools_StringCheck.<>f__mg$cache5, typeof(StringCheck));
	}

	// Token: 0x040185E5 RID: 99813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185E6 RID: 99814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185E7 RID: 99815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040185E8 RID: 99816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040185E9 RID: 99817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040185EA RID: 99818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
