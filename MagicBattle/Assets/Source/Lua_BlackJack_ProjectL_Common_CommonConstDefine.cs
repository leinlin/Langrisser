using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011E6 RID: 4582
[Preserve]
public class Lua_BlackJack_ProjectL_Common_CommonConstDefine : LuaObject
{
	// Token: 0x06017C0C RID: 97292 RVA: 0x0068A294 File Offset: 0x00688494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CommonConstDefine o = new CommonConstDefine();
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

	// Token: 0x06017C0D RID: 97293 RVA: 0x0068A2DC File Offset: 0x006884DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MaxEquipmentNums(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C0E RID: 97294 RVA: 0x0068A320 File Offset: 0x00688520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GuildMassiveCombatLeastSetupHeroNums(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C0F RID: 97295 RVA: 0x0068A364 File Offset: 0x00688564
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.CommonConstDefine");
		string name = "MaxEquipmentNums";
		if (Lua_BlackJack_ProjectL_Common_CommonConstDefine.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonConstDefine.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonConstDefine.get_MaxEquipmentNums);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_CommonConstDefine.<>f__mg$cache0, null, false);
		string name2 = "GuildMassiveCombatLeastSetupHeroNums";
		if (Lua_BlackJack_ProjectL_Common_CommonConstDefine.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonConstDefine.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonConstDefine.get_GuildMassiveCombatLeastSetupHeroNums);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Common_CommonConstDefine.<>f__mg$cache1, null, false);
		if (Lua_BlackJack_ProjectL_Common_CommonConstDefine.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommonConstDefine.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommonConstDefine.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_CommonConstDefine.<>f__mg$cache2, typeof(CommonConstDefine));
	}

	// Token: 0x0400E222 RID: 57890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E223 RID: 57891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E224 RID: 57892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
