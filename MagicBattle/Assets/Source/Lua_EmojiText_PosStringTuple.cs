using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015FD RID: 5629
[Preserve]
public class Lua_EmojiText_PosStringTuple : LuaObject
{
	// Token: 0x06022817 RID: 141335 RVA: 0x00BD55C4 File Offset: 0x00BD37C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int p;
			LuaObject.checkType(l, 2, out p);
			int key;
			LuaObject.checkType(l, 3, out key);
			EmojiText.PosStringTuple o = new EmojiText.PosStringTuple(p, key);
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

	// Token: 0x06022818 RID: 141336 RVA: 0x00BD5624 File Offset: 0x00BD3824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pos(IntPtr l)
	{
		int result;
		try
		{
			EmojiText.PosStringTuple posStringTuple = (EmojiText.PosStringTuple)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, posStringTuple.pos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022819 RID: 141337 RVA: 0x00BD5678 File Offset: 0x00BD3878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pos(IntPtr l)
	{
		int result;
		try
		{
			EmojiText.PosStringTuple posStringTuple = (EmojiText.PosStringTuple)LuaObject.checkSelf(l);
			int pos;
			LuaObject.checkType(l, 2, out pos);
			posStringTuple.pos = pos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602281A RID: 141338 RVA: 0x00BD56D0 File Offset: 0x00BD38D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_expressionKey(IntPtr l)
	{
		int result;
		try
		{
			EmojiText.PosStringTuple posStringTuple = (EmojiText.PosStringTuple)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, posStringTuple.expressionKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602281B RID: 141339 RVA: 0x00BD5724 File Offset: 0x00BD3924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_expressionKey(IntPtr l)
	{
		int result;
		try
		{
			EmojiText.PosStringTuple posStringTuple = (EmojiText.PosStringTuple)LuaObject.checkSelf(l);
			int expressionKey;
			LuaObject.checkType(l, 2, out expressionKey);
			posStringTuple.expressionKey = expressionKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602281C RID: 141340 RVA: 0x00BD577C File Offset: 0x00BD397C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "EmojiText.PosStringTuple");
		string name = "pos";
		if (Lua_EmojiText_PosStringTuple.<>f__mg$cache0 == null)
		{
			Lua_EmojiText_PosStringTuple.<>f__mg$cache0 = new LuaCSFunction(Lua_EmojiText_PosStringTuple.get_pos);
		}
		LuaCSFunction get = Lua_EmojiText_PosStringTuple.<>f__mg$cache0;
		if (Lua_EmojiText_PosStringTuple.<>f__mg$cache1 == null)
		{
			Lua_EmojiText_PosStringTuple.<>f__mg$cache1 = new LuaCSFunction(Lua_EmojiText_PosStringTuple.set_pos);
		}
		LuaObject.addMember(l, name, get, Lua_EmojiText_PosStringTuple.<>f__mg$cache1, true);
		string name2 = "expressionKey";
		if (Lua_EmojiText_PosStringTuple.<>f__mg$cache2 == null)
		{
			Lua_EmojiText_PosStringTuple.<>f__mg$cache2 = new LuaCSFunction(Lua_EmojiText_PosStringTuple.get_expressionKey);
		}
		LuaCSFunction get2 = Lua_EmojiText_PosStringTuple.<>f__mg$cache2;
		if (Lua_EmojiText_PosStringTuple.<>f__mg$cache3 == null)
		{
			Lua_EmojiText_PosStringTuple.<>f__mg$cache3 = new LuaCSFunction(Lua_EmojiText_PosStringTuple.set_expressionKey);
		}
		LuaObject.addMember(l, name2, get2, Lua_EmojiText_PosStringTuple.<>f__mg$cache3, true);
		if (Lua_EmojiText_PosStringTuple.<>f__mg$cache4 == null)
		{
			Lua_EmojiText_PosStringTuple.<>f__mg$cache4 = new LuaCSFunction(Lua_EmojiText_PosStringTuple.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_EmojiText_PosStringTuple.<>f__mg$cache4, typeof(EmojiText.PosStringTuple));
	}

	// Token: 0x040185FF RID: 99839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018600 RID: 99840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018601 RID: 99841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018602 RID: 99842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018603 RID: 99843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
