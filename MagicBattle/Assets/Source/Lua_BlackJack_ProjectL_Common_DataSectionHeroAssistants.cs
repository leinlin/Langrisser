using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001200 RID: 4608
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants : LuaObject
{
	// Token: 0x06017E85 RID: 97925 RVA: 0x0069C158 File Offset: 0x0069A358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroAssistants o = new DataSectionHeroAssistants();
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

	// Token: 0x06017E86 RID: 97926 RVA: 0x0069C1A0 File Offset: 0x0069A3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroAssistants dataSectionHeroAssistants = (DataSectionHeroAssistants)LuaObject.checkSelf(l);
			dataSectionHeroAssistants.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E87 RID: 97927 RVA: 0x0069C1EC File Offset: 0x0069A3EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroAssistants dataSectionHeroAssistants = (DataSectionHeroAssistants)LuaObject.checkSelf(l);
			object o = dataSectionHeroAssistants.SerializeToClient();
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

	// Token: 0x06017E88 RID: 97928 RVA: 0x0069C240 File Offset: 0x0069A440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateInstantiatedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroAssistants dataSectionHeroAssistants = (DataSectionHeroAssistants)LuaObject.checkSelf(l);
			DSHeroAssistantNtf ds;
			LuaObject.checkType<DSHeroAssistantNtf>(l, 2, out ds);
			dataSectionHeroAssistants.UpdateInstantiatedData(ds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E89 RID: 97929 RVA: 0x0069C298 File Offset: 0x0069A498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroAssistants(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroAssistants dataSectionHeroAssistants = (DataSectionHeroAssistants)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHeroAssistants.HeroAssistants);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E8A RID: 97930 RVA: 0x0069C2EC File Offset: 0x0069A4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroAssistants(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroAssistants dataSectionHeroAssistants = (DataSectionHeroAssistants)LuaObject.checkSelf(l);
			HeroAssistants heroAssistants;
			LuaObject.checkType<HeroAssistants>(l, 2, out heroAssistants);
			dataSectionHeroAssistants.HeroAssistants = heroAssistants;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E8B RID: 97931 RVA: 0x0069C344 File Offset: 0x0069A544
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionHeroAssistants");
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.UpdateInstantiatedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache2);
		string name = "HeroAssistants";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.get_HeroAssistants);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.set_HeroAssistants);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache4, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.<>f__mg$cache5, typeof(DataSectionHeroAssistants), typeof(DataSection));
	}

	// Token: 0x0400E467 RID: 58471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E468 RID: 58472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E469 RID: 58473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E46A RID: 58474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E46B RID: 58475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E46C RID: 58476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
