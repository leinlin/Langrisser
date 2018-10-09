using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.Utils;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015FB RID: 5627
[Preserve]
public class Lua_BlackJack_Utils_TinyCorutineHelper : LuaObject
{
	// Token: 0x06022802 RID: 141314 RVA: 0x00BD48FC File Offset: 0x00BD2AFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TinyCorutineHelper o = new TinyCorutineHelper();
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

	// Token: 0x06022803 RID: 141315 RVA: 0x00BD4944 File Offset: 0x00BD2B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCorutine(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Func<IEnumerator>)))
			{
				TinyCorutineHelper tinyCorutineHelper = (TinyCorutineHelper)LuaObject.checkSelf(l);
				Func<IEnumerator> corutine;
				LuaObject.checkDelegate<Func<IEnumerator>>(l, 2, out corutine);
				tinyCorutineHelper.StartCorutine(corutine);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(IEnumerator)))
			{
				TinyCorutineHelper tinyCorutineHelper2 = (TinyCorutineHelper)LuaObject.checkSelf(l);
				IEnumerator corutine2;
				LuaObject.checkType<IEnumerator>(l, 2, out corutine2);
				tinyCorutineHelper2.StartCorutine(corutine2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function StartCorutine to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022804 RID: 141316 RVA: 0x00BD4A1C File Offset: 0x00BD2C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLuaCoroutine(IntPtr l)
	{
		int result;
		try
		{
			TinyCorutineHelper tinyCorutineHelper = (TinyCorutineHelper)LuaObject.checkSelf(l);
			LuaFunction func;
			LuaObject.checkType(l, 2, out func);
			tinyCorutineHelper.StartLuaCoroutine(func);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022805 RID: 141317 RVA: 0x00BD4A74 File Offset: 0x00BD2C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CancelAll(IntPtr l)
	{
		int result;
		try
		{
			TinyCorutineHelper tinyCorutineHelper = (TinyCorutineHelper)LuaObject.checkSelf(l);
			tinyCorutineHelper.CancelAll();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022806 RID: 141318 RVA: 0x00BD4AC0 File Offset: 0x00BD2CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			TinyCorutineHelper tinyCorutineHelper = (TinyCorutineHelper)LuaObject.checkSelf(l);
			tinyCorutineHelper.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022807 RID: 141319 RVA: 0x00BD4B0C File Offset: 0x00BD2D0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MoveNext_s(IntPtr l)
	{
		int result;
		try
		{
			IEnumerator iter;
			LuaObject.checkType<IEnumerator>(l, 1, out iter);
			bool b = TinyCorutineHelper.MoveNext(iter);
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

	// Token: 0x06022808 RID: 141320 RVA: 0x00BD4B60 File Offset: 0x00BD2D60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.Utils.TinyCorutineHelper");
		if (Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_Utils_TinyCorutineHelper.StartCorutine);
		}
		LuaObject.addMember(l, Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache0);
		if (Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_Utils_TinyCorutineHelper.StartLuaCoroutine);
		}
		LuaObject.addMember(l, Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache1);
		if (Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_Utils_TinyCorutineHelper.CancelAll);
		}
		LuaObject.addMember(l, Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache2);
		if (Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_Utils_TinyCorutineHelper.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache3);
		if (Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_Utils_TinyCorutineHelper.MoveNext_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache4);
		if (Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_Utils_TinyCorutineHelper.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_Utils_TinyCorutineHelper.<>f__mg$cache5, typeof(TinyCorutineHelper));
	}

	// Token: 0x040185EE RID: 99822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185EF RID: 99823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185F0 RID: 99824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040185F1 RID: 99825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040185F2 RID: 99826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040185F3 RID: 99827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
