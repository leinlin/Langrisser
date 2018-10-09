using System;
using System.Runtime.CompilerServices;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015F8 RID: 5624
[Preserve]
public class Lua_BlackJack_UtilityTools_SensitiveWords : LuaObject
{
	// Token: 0x060227EF RID: 141295 RVA: 0x00BD4154 File Offset: 0x00BD2354
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SensitiveWords o = new SensitiveWords();
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

	// Token: 0x060227F0 RID: 141296 RVA: 0x00BD419C File Offset: 0x00BD239C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitSensitiveWord(IntPtr l)
	{
		int result;
		try
		{
			SensitiveWords sensitiveWords = (SensitiveWords)LuaObject.checkSelf(l);
			string word;
			LuaObject.checkType(l, 2, out word);
			sensitiveWords.InitSensitiveWord(word);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227F1 RID: 141297 RVA: 0x00BD41F4 File Offset: 0x00BD23F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSensitiveWord(IntPtr l)
	{
		int result;
		try
		{
			SensitiveWords sensitiveWords = (SensitiveWords)LuaObject.checkSelf(l);
			string sentence;
			LuaObject.checkType(l, 2, out sentence);
			bool b = sensitiveWords.IsSensitiveWord(sentence);
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

	// Token: 0x060227F2 RID: 141298 RVA: 0x00BD4258 File Offset: 0x00BD2458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReplaceSensitiveWord(IntPtr l)
	{
		int result;
		try
		{
			SensitiveWords sensitiveWords = (SensitiveWords)LuaObject.checkSelf(l);
			string sentence;
			LuaObject.checkType(l, 2, out sentence);
			char replaceChar;
			LuaObject.checkType(l, 3, out replaceChar);
			string s = sensitiveWords.ReplaceSensitiveWord(sentence, replaceChar);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227F3 RID: 141299 RVA: 0x00BD42C8 File Offset: 0x00BD24C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.UtilityTools.SensitiveWords");
		if (Lua_BlackJack_UtilityTools_SensitiveWords.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_UtilityTools_SensitiveWords.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_UtilityTools_SensitiveWords.InitSensitiveWord);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_SensitiveWords.<>f__mg$cache0);
		if (Lua_BlackJack_UtilityTools_SensitiveWords.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_UtilityTools_SensitiveWords.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_UtilityTools_SensitiveWords.IsSensitiveWord);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_SensitiveWords.<>f__mg$cache1);
		if (Lua_BlackJack_UtilityTools_SensitiveWords.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_UtilityTools_SensitiveWords.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_UtilityTools_SensitiveWords.ReplaceSensitiveWord);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_SensitiveWords.<>f__mg$cache2);
		if (Lua_BlackJack_UtilityTools_SensitiveWords.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_UtilityTools_SensitiveWords.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_UtilityTools_SensitiveWords.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_UtilityTools_SensitiveWords.<>f__mg$cache3, typeof(SensitiveWords));
	}

	// Token: 0x040185E1 RID: 99809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185E2 RID: 99810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185E3 RID: 99811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040185E4 RID: 99812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
