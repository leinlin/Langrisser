using System;
using System.Runtime.CompilerServices;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015F1 RID: 5617
[Preserve]
public class Lua_BlackJack_UtilityTools_CountMinSketch : LuaObject
{
	// Token: 0x060227CA RID: 141258 RVA: 0x00BD353C File Offset: 0x00BD173C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			double epsilon;
			LuaObject.checkType(l, 2, out epsilon);
			double delta;
			LuaObject.checkType(l, 3, out delta);
			CountMinSketch o = new CountMinSketch(epsilon, delta);
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

	// Token: 0x060227CB RID: 141259 RVA: 0x00BD359C File Offset: 0x00BD179C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Add(IntPtr l)
	{
		int result;
		try
		{
			CountMinSketch countMinSketch = (CountMinSketch)LuaObject.checkSelf(l);
			ulong data;
			LuaObject.checkType(l, 2, out data);
			CountMinSketch o = countMinSketch.Add(data);
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

	// Token: 0x060227CC RID: 141260 RVA: 0x00BD3600 File Offset: 0x00BD1800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Count(IntPtr l)
	{
		int result;
		try
		{
			CountMinSketch countMinSketch = (CountMinSketch)LuaObject.checkSelf(l);
			ulong data;
			LuaObject.checkType(l, 2, out data);
			ulong o = countMinSketch.Count(data);
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

	// Token: 0x060227CD RID: 141261 RVA: 0x00BD3664 File Offset: 0x00BD1864
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Reset(IntPtr l)
	{
		int result;
		try
		{
			CountMinSketch countMinSketch = (CountMinSketch)LuaObject.checkSelf(l);
			CountMinSketch o = countMinSketch.Reset();
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

	// Token: 0x060227CE RID: 141262 RVA: 0x00BD36B8 File Offset: 0x00BD18B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Hash(IntPtr l)
	{
		int result;
		try
		{
			CountMinSketch countMinSketch = (CountMinSketch)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			ulong value;
			LuaObject.checkType(l, 3, out value);
			ulong o = countMinSketch.Hash(index, value);
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

	// Token: 0x060227CF RID: 141263 RVA: 0x00BD3728 File Offset: 0x00BD1928
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.UtilityTools.CountMinSketch");
		if (Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_UtilityTools_CountMinSketch.Add);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache0);
		if (Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_UtilityTools_CountMinSketch.Count);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache1);
		if (Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_UtilityTools_CountMinSketch.Reset);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache2);
		if (Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_UtilityTools_CountMinSketch.Hash);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache3);
		if (Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_UtilityTools_CountMinSketch.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_UtilityTools_CountMinSketch.<>f__mg$cache4, typeof(CountMinSketch));
	}

	// Token: 0x040185CA RID: 99786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185CB RID: 99787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185CC RID: 99788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040185CD RID: 99789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040185CE RID: 99790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
