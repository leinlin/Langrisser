using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001601 RID: 5633
[Preserve]
public class Lua_SLua_BJLuaObjHelper : LuaObject
{
	// Token: 0x060228E1 RID: 141537 RVA: 0x00BDB734 File Offset: 0x00BD9934
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BJLuaObjHelper o = new BJLuaObjHelper();
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

	// Token: 0x060228E2 RID: 141538 RVA: 0x00BDB77C File Offset: 0x00BD997C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitInCS(IntPtr l)
	{
		int result;
		try
		{
			BJLuaObjHelper bjluaObjHelper = (BJLuaObjHelper)LuaObject.checkSelf(l);
			object owner;
			LuaObject.checkType<object>(l, 2, out owner);
			LuaTable module;
			LuaObject.checkType(l, 3, out module);
			bjluaObjHelper.InitInCS(owner, module);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228E3 RID: 141539 RVA: 0x00BDB7E0 File Offset: 0x00BD99E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLuaObj(IntPtr l)
	{
		int result;
		try
		{
			BJLuaObjHelper bjluaObjHelper = (BJLuaObjHelper)LuaObject.checkSelf(l);
			LuaTable luaObj;
			LuaObject.checkType(l, 2, out luaObj);
			bjluaObjHelper.SetLuaObj(luaObj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228E4 RID: 141540 RVA: 0x00BDB838 File Offset: 0x00BD9A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLuaObj(IntPtr l)
	{
		int result;
		try
		{
			BJLuaObjHelper bjluaObjHelper = (BJLuaObjHelper)LuaObject.checkSelf(l);
			LuaTable luaObj = bjluaObjHelper.GetLuaObj();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, luaObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228E5 RID: 141541 RVA: 0x00BDB88C File Offset: 0x00BD9A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsSkipLuaHotfix(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BJLuaObjHelper.IsSkipLuaHotfix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228E6 RID: 141542 RVA: 0x00BDB8D4 File Offset: 0x00BD9AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsSkipLuaHotfix(IntPtr l)
	{
		int result;
		try
		{
			bool isSkipLuaHotfix;
			LuaObject.checkType(l, 2, out isSkipLuaHotfix);
			BJLuaObjHelper.IsSkipLuaHotfix = isSkipLuaHotfix;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228E7 RID: 141543 RVA: 0x00BDB920 File Offset: 0x00BD9B20
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "SLua.BJLuaObjHelper");
		if (Lua_SLua_BJLuaObjHelper.<>f__mg$cache0 == null)
		{
			Lua_SLua_BJLuaObjHelper.<>f__mg$cache0 = new LuaCSFunction(Lua_SLua_BJLuaObjHelper.InitInCS);
		}
		LuaObject.addMember(l, Lua_SLua_BJLuaObjHelper.<>f__mg$cache0);
		if (Lua_SLua_BJLuaObjHelper.<>f__mg$cache1 == null)
		{
			Lua_SLua_BJLuaObjHelper.<>f__mg$cache1 = new LuaCSFunction(Lua_SLua_BJLuaObjHelper.SetLuaObj);
		}
		LuaObject.addMember(l, Lua_SLua_BJLuaObjHelper.<>f__mg$cache1);
		if (Lua_SLua_BJLuaObjHelper.<>f__mg$cache2 == null)
		{
			Lua_SLua_BJLuaObjHelper.<>f__mg$cache2 = new LuaCSFunction(Lua_SLua_BJLuaObjHelper.GetLuaObj);
		}
		LuaObject.addMember(l, Lua_SLua_BJLuaObjHelper.<>f__mg$cache2);
		string name = "IsSkipLuaHotfix";
		if (Lua_SLua_BJLuaObjHelper.<>f__mg$cache3 == null)
		{
			Lua_SLua_BJLuaObjHelper.<>f__mg$cache3 = new LuaCSFunction(Lua_SLua_BJLuaObjHelper.get_IsSkipLuaHotfix);
		}
		LuaCSFunction get = Lua_SLua_BJLuaObjHelper.<>f__mg$cache3;
		if (Lua_SLua_BJLuaObjHelper.<>f__mg$cache4 == null)
		{
			Lua_SLua_BJLuaObjHelper.<>f__mg$cache4 = new LuaCSFunction(Lua_SLua_BJLuaObjHelper.set_IsSkipLuaHotfix);
		}
		LuaObject.addMember(l, name, get, Lua_SLua_BJLuaObjHelper.<>f__mg$cache4, false);
		if (Lua_SLua_BJLuaObjHelper.<>f__mg$cache5 == null)
		{
			Lua_SLua_BJLuaObjHelper.<>f__mg$cache5 = new LuaCSFunction(Lua_SLua_BJLuaObjHelper.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_SLua_BJLuaObjHelper.<>f__mg$cache5, typeof(BJLuaObjHelper));
	}

	// Token: 0x040186C1 RID: 100033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040186C2 RID: 100034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040186C3 RID: 100035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040186C4 RID: 100036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040186C5 RID: 100037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040186C6 RID: 100038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
