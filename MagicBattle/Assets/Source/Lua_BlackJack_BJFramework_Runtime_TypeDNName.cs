using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001125 RID: 4389
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_TypeDNName : LuaObject
{
	// Token: 0x06015D30 RID: 89392 RVA: 0x005A3290 File Offset: 0x005A1490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string typeDNName;
			LuaObject.checkType(l, 2, out typeDNName);
			TypeDNName o = new TypeDNName(typeDNName);
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

	// Token: 0x06015D31 RID: 89393 RVA: 0x005A32E4 File Offset: 0x005A14E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_assemblyName(IntPtr l)
	{
		int result;
		try
		{
			TypeDNName typeDNName = (TypeDNName)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, typeDNName.m_assemblyName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D32 RID: 89394 RVA: 0x005A3338 File Offset: 0x005A1538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_assemblyName(IntPtr l)
	{
		int result;
		try
		{
			TypeDNName typeDNName = (TypeDNName)LuaObject.checkSelf(l);
			string assemblyName;
			LuaObject.checkType(l, 2, out assemblyName);
			typeDNName.m_assemblyName = assemblyName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D33 RID: 89395 RVA: 0x005A3390 File Offset: 0x005A1590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_typeFullName(IntPtr l)
	{
		int result;
		try
		{
			TypeDNName typeDNName = (TypeDNName)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, typeDNName.m_typeFullName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D34 RID: 89396 RVA: 0x005A33E4 File Offset: 0x005A15E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_typeFullName(IntPtr l)
	{
		int result;
		try
		{
			TypeDNName typeDNName = (TypeDNName)LuaObject.checkSelf(l);
			string typeFullName;
			LuaObject.checkType(l, 2, out typeFullName);
			typeDNName.m_typeFullName = typeFullName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D35 RID: 89397 RVA: 0x005A343C File Offset: 0x005A163C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.TypeDNName");
		string name = "m_assemblyName";
		if (Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TypeDNName.get_m_assemblyName);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache0;
		if (Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TypeDNName.set_m_assemblyName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache1, true);
		string name2 = "m_typeFullName";
		if (Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TypeDNName.get_m_typeFullName);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache2;
		if (Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TypeDNName.set_m_typeFullName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache3, true);
		if (Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TypeDNName.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_TypeDNName.<>f__mg$cache4, typeof(TypeDNName));
	}

	// Token: 0x0400C4C8 RID: 50376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C4C9 RID: 50377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C4CA RID: 50378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C4CB RID: 50379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C4CC RID: 50380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
