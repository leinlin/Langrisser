using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015EF RID: 5615
[Preserve]
public class Lua_BlackJack_ProjectLBasic_StringTable : LuaObject
{
	// Token: 0x060227B9 RID: 141241 RVA: 0x00BD2E6C File Offset: 0x00BD106C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			StringTable o = new StringTable();
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

	// Token: 0x060227BA RID: 141242 RVA: 0x00BD2EB4 File Offset: 0x00BD10B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Load_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = StringTable.Load();
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

	// Token: 0x060227BB RID: 141243 RVA: 0x00BD2EFC File Offset: 0x00BD10FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsKeyExist_s(IntPtr l)
	{
		int result;
		try
		{
			string key;
			LuaObject.checkType(l, 1, out key);
			bool b = StringTable.IsKeyExist(key);
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

	// Token: 0x060227BC RID: 141244 RVA: 0x00BD2F50 File Offset: 0x00BD1150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Get_s(IntPtr l)
	{
		int result;
		try
		{
			string key;
			LuaObject.checkType(l, 1, out key);
			string s = StringTable.Get(key);
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

	// Token: 0x060227BD RID: 141245 RVA: 0x00BD2FA4 File Offset: 0x00BD11A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectLBasic.StringTable");
		if (Lua_BlackJack_ProjectLBasic_StringTable.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectLBasic_StringTable.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_StringTable.Load_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_StringTable.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectLBasic_StringTable.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectLBasic_StringTable.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_StringTable.IsKeyExist_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_StringTable.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectLBasic_StringTable.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectLBasic_StringTable.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_StringTable.Get_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_StringTable.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectLBasic_StringTable.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectLBasic_StringTable.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_StringTable.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectLBasic_StringTable.<>f__mg$cache3, typeof(StringTable));
	}

	// Token: 0x040185BD RID: 99773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185BE RID: 99774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185BF RID: 99775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040185C0 RID: 99776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
