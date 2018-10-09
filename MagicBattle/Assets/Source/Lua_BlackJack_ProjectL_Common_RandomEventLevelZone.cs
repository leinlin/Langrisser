using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001265 RID: 4709
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RandomEventLevelZone : LuaObject
{
	// Token: 0x060188D0 RID: 100560 RVA: 0x006E90AC File Offset: 0x006E72AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomEventLevelZone o = new RandomEventLevelZone();
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

	// Token: 0x060188D1 RID: 100561 RVA: 0x006E90F4 File Offset: 0x006E72F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Groups(IntPtr l)
	{
		int result;
		try
		{
			RandomEventLevelZone randomEventLevelZone = (RandomEventLevelZone)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomEventLevelZone.Groups);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188D2 RID: 100562 RVA: 0x006E9148 File Offset: 0x006E7348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Groups(IntPtr l)
	{
		int result;
		try
		{
			RandomEventLevelZone randomEventLevelZone = (RandomEventLevelZone)LuaObject.checkSelf(l);
			Dictionary<int, RandomEventGroup> groups;
			LuaObject.checkType<Dictionary<int, RandomEventGroup>>(l, 2, out groups);
			randomEventLevelZone.Groups = groups;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188D3 RID: 100563 RVA: 0x006E91A0 File Offset: 0x006E73A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelZoneId(IntPtr l)
	{
		int result;
		try
		{
			RandomEventLevelZone randomEventLevelZone = (RandomEventLevelZone)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomEventLevelZone.LevelZoneId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188D4 RID: 100564 RVA: 0x006E91F4 File Offset: 0x006E73F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LevelZoneId(IntPtr l)
	{
		int result;
		try
		{
			RandomEventLevelZone randomEventLevelZone = (RandomEventLevelZone)LuaObject.checkSelf(l);
			int levelZoneId;
			LuaObject.checkType(l, 2, out levelZoneId);
			randomEventLevelZone.LevelZoneId = levelZoneId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188D5 RID: 100565 RVA: 0x006E924C File Offset: 0x006E744C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RandomEventLevelZone");
		string name = "Groups";
		if (Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.get_Groups);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.set_Groups);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache1, true);
		string name2 = "LevelZoneId";
		if (Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.get_LevelZoneId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.set_LevelZoneId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.<>f__mg$cache4, typeof(RandomEventLevelZone));
	}

	// Token: 0x0400EDE8 RID: 60904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EDE9 RID: 60905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EDEA RID: 60906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EDEB RID: 60907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EDEC RID: 60908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
