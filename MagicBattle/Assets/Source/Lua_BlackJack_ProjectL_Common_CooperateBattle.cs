using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011E9 RID: 4585
[Preserve]
public class Lua_BlackJack_ProjectL_Common_CooperateBattle : LuaObject
{
	// Token: 0x06017C70 RID: 97392 RVA: 0x0068CE04 File Offset: 0x0068B004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle o = new CooperateBattle();
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

	// Token: 0x06017C71 RID: 97393 RVA: 0x0068CE4C File Offset: 0x0068B04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReloadConfigData(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			cooperateBattle.ReloadConfigData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C72 RID: 97394 RVA: 0x0068CE98 File Offset: 0x0068B098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WhichBattleCollections(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.WhichBattleCollections);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C73 RID: 97395 RVA: 0x0068CEEC File Offset: 0x0068B0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WhichBattleCollections(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			CooperateBattleCollections whichBattleCollections;
			LuaObject.checkType<CooperateBattleCollections>(l, 2, out whichBattleCollections);
			cooperateBattle.WhichBattleCollections = whichBattleCollections;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C74 RID: 97396 RVA: 0x0068CF44 File Offset: 0x0068B144
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Levels(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.Levels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C75 RID: 97397 RVA: 0x0068CF98 File Offset: 0x0068B198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Levels(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			List<CooperateBattleLevel> levels;
			LuaObject.checkType<List<CooperateBattleLevel>>(l, 2, out levels);
			cooperateBattle.Levels = levels;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C76 RID: 97398 RVA: 0x0068CFF0 File Offset: 0x0068B1F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C77 RID: 97399 RVA: 0x0068D044 File Offset: 0x0068B244
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			cooperateBattle.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C78 RID: 97400 RVA: 0x0068D09C File Offset: 0x0068B29C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C79 RID: 97401 RVA: 0x0068D0F0 File Offset: 0x0068B2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Description(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.Description);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C7A RID: 97402 RVA: 0x0068D144 File Offset: 0x0068B344
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OpenDateTime(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.OpenDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C7B RID: 97403 RVA: 0x0068D19C File Offset: 0x0068B39C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CloseDateTime(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.CloseDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C7C RID: 97404 RVA: 0x0068D1F4 File Offset: 0x0068B3F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ShowWeekDays(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.ShowWeekDays);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C7D RID: 97405 RVA: 0x0068D248 File Offset: 0x0068B448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.ChallengedNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C7E RID: 97406 RVA: 0x0068D29C File Offset: 0x0068B49C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			int challengedNums;
			LuaObject.checkType(l, 2, out challengedNums);
			cooperateBattle.ChallengedNums = challengedNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C7F RID: 97407 RVA: 0x0068D2F4 File Offset: 0x0068B4F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsAvailableForChallenge(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.IsAvailableForChallenge);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C80 RID: 97408 RVA: 0x0068D348 File Offset: 0x0068B548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsAvailableForDisplay(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.IsAvailableForDisplay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C81 RID: 97409 RVA: 0x0068D39C File Offset: 0x0068B59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C82 RID: 97410 RVA: 0x0068D3F0 File Offset: 0x0068B5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C83 RID: 97411 RVA: 0x0068D444 File Offset: 0x0068B644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattle cooperateBattle = (CooperateBattle)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			cooperateBattle.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C84 RID: 97412 RVA: 0x0068D49C File Offset: 0x0068B69C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.CooperateBattle");
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.ReloadConfigData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache0);
		string name = "WhichBattleCollections";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_WhichBattleCollections);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.set_WhichBattleCollections);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache2, true);
		string name2 = "Levels";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_Levels);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.set_Levels);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache4, true);
		string name3 = "ID";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.set_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache6, true);
		string name4 = "Name";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_Name);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache7, null, true);
		string name5 = "Description";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_Description);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache8, null, true);
		string name6 = "OpenDateTime";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_OpenDateTime);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache9, null, true);
		string name7 = "CloseDateTime";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_CloseDateTime);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheA, null, true);
		string name8 = "ShowWeekDays";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_ShowWeekDays);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheB, null, true);
		string name9 = "ChallengedNums";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_ChallengedNums);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.set_ChallengedNums);
		}
		LuaObject.addMember(l, name9, get4, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheD, true);
		string name10 = "IsAvailableForChallenge";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_IsAvailableForChallenge);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheE, null, true);
		string name11 = "IsAvailableForDisplay";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_IsAvailableForDisplay);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cacheF, null, true);
		string name12 = "Config";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_Config);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache10, null, true);
		string name13 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.get_ConfigDataLoader);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name13, get5, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache12, true);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_CooperateBattle.<>f__mg$cache13, typeof(CooperateBattle));
	}

	// Token: 0x0400E280 RID: 57984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E281 RID: 57985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E282 RID: 57986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E283 RID: 57987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E284 RID: 57988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E285 RID: 57989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E286 RID: 57990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E287 RID: 57991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E288 RID: 57992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E289 RID: 57993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E28A RID: 57994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E28B RID: 57995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E28C RID: 57996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E28D RID: 57997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E28E RID: 57998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E28F RID: 57999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E290 RID: 58000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E291 RID: 58001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E292 RID: 58002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E293 RID: 58003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
