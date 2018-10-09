using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200110E RID: 4366
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager : LuaObject
{
	// Token: 0x06015B81 RID: 88961 RVA: 0x00596B48 File Offset: 0x00594D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHotFixLuaModuleByTypeFullName(IntPtr l)
	{
		int result;
		try
		{
			LuaManager luaManager = (LuaManager)LuaObject.checkSelf(l);
			Type type;
			LuaObject.checkType(l, 2, out type);
			LuaTable hotFixLuaModuleByTypeFullName = luaManager.GetHotFixLuaModuleByTypeFullName(type);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hotFixLuaModuleByTypeFullName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B82 RID: 88962 RVA: 0x00596BAC File Offset: 0x00594DAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RegHotFix(IntPtr l)
	{
		int result;
		try
		{
			LuaManager luaManager = (LuaManager)LuaObject.checkSelf(l);
			string typeFullName;
			LuaObject.checkType(l, 2, out typeFullName);
			LuaTable module;
			LuaObject.checkType(l, 3, out module);
			luaManager.RegHotFix(typeFullName, module);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B83 RID: 88963 RVA: 0x00596C10 File Offset: 0x00594E10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RequireModule(IntPtr l)
	{
		int result;
		try
		{
			LuaManager luaManager = (LuaManager)LuaObject.checkSelf(l);
			string moduleName;
			LuaObject.checkType(l, 2, out moduleName);
			LuaTable t = luaManager.RequireModule(moduleName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, t);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B84 RID: 88964 RVA: 0x00596C74 File Offset: 0x00594E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLuaModuleExist(IntPtr l)
	{
		int result;
		try
		{
			LuaManager luaManager = (LuaManager)LuaObject.checkSelf(l);
			string moduleName;
			LuaObject.checkType(l, 2, out moduleName);
			bool b = luaManager.IsLuaModuleExist(moduleName);
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

	// Token: 0x06015B85 RID: 88965 RVA: 0x00596CD8 File Offset: 0x00594ED8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LuaObjHelperMemberName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "m_luaObjHelper");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B86 RID: 88966 RVA: 0x00596D20 File Offset: 0x00594F20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LuaManager.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B87 RID: 88967 RVA: 0x00596D68 File Offset: 0x00594F68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Lua.LuaManager");
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.GetHotFixLuaModuleByTypeFullName);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.RegHotFix);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.RequireModule);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.IsLuaModuleExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache3);
		string name = "LuaObjHelperMemberName";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.get_LuaObjHelperMemberName);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache4, null, false);
		string name2 = "Instance";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.get_Instance);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.<>f__mg$cache5, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(LuaManager));
	}

	// Token: 0x0400C347 RID: 49991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C348 RID: 49992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C349 RID: 49993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C34A RID: 49994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C34B RID: 49995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C34C RID: 49996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
