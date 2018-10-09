using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001435 RID: 5173
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple : LuaObject
{
	// Token: 0x0601DA9D RID: 121501 RVA: 0x0096D958 File Offset: 0x0096BB58
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
			ExpressionParseController.PosStringTuple o = new ExpressionParseController.PosStringTuple(p, key);
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

	// Token: 0x0601DA9E RID: 121502 RVA: 0x0096D9B8 File Offset: 0x0096BBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pos(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController.PosStringTuple posStringTuple = (ExpressionParseController.PosStringTuple)LuaObject.checkSelf(l);
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

	// Token: 0x0601DA9F RID: 121503 RVA: 0x0096DA0C File Offset: 0x0096BC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pos(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController.PosStringTuple posStringTuple = (ExpressionParseController.PosStringTuple)LuaObject.checkSelf(l);
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

	// Token: 0x0601DAA0 RID: 121504 RVA: 0x0096DA64 File Offset: 0x0096BC64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_expressionKey(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController.PosStringTuple posStringTuple = (ExpressionParseController.PosStringTuple)LuaObject.checkSelf(l);
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

	// Token: 0x0601DAA1 RID: 121505 RVA: 0x0096DAB8 File Offset: 0x0096BCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_expressionKey(IntPtr l)
	{
		int result;
		try
		{
			ExpressionParseController.PosStringTuple posStringTuple = (ExpressionParseController.PosStringTuple)LuaObject.checkSelf(l);
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

	// Token: 0x0601DAA2 RID: 121506 RVA: 0x0096DB10 File Offset: 0x0096BD10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ExpressionParseController.PosStringTuple");
		string name = "pos";
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.get_pos);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.set_pos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache1, true);
		string name2 = "expressionKey";
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.get_expressionKey);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.set_expressionKey);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.<>f__mg$cache4, typeof(ExpressionParseController.PosStringTuple));
	}

	// Token: 0x04013C15 RID: 80917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013C16 RID: 80918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013C17 RID: 80919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013C18 RID: 80920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013C19 RID: 80921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
