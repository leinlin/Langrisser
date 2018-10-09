using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001279 RID: 4729
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RoleGenerator : LuaObject
{
	// Token: 0x06018A60 RID: 100960 RVA: 0x006F456C File Offset: 0x006F276C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RoleGenerator o = new RoleGenerator();
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

	// Token: 0x06018A61 RID: 100961 RVA: 0x006F45B4 File Offset: 0x006F27B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBornChannelIdFromUserId_s(IntPtr l)
	{
		int result;
		try
		{
			string userId;
			LuaObject.checkType(l, 1, out userId);
			int bornChannelIdFromUserId = RoleGenerator.GetBornChannelIdFromUserId(userId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bornChannelIdFromUserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A62 RID: 100962 RVA: 0x006F4608 File Offset: 0x006F2808
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RoleGenerator");
		if (Lua_BlackJack_ProjectL_Common_RoleGenerator.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleGenerator.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleGenerator.GetBornChannelIdFromUserId_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RoleGenerator.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RoleGenerator.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RoleGenerator.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RoleGenerator.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RoleGenerator.<>f__mg$cache1, typeof(RoleGenerator));
	}

	// Token: 0x0400EF50 RID: 61264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EF51 RID: 61265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
