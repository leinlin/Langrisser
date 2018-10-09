using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001170 RID: 4464
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo : LuaObject
{
	// Token: 0x06016E56 RID: 93782 RVA: 0x00623608 File Offset: 0x00621808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo o = new ConfigDataTowerLevelInfo();
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

	// Token: 0x06016E57 RID: 93783 RVA: 0x00623650 File Offset: 0x00621850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTowerLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E58 RID: 93784 RVA: 0x006236A4 File Offset: 0x006218A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataTowerLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E59 RID: 93785 RVA: 0x006236FC File Offset: 0x006218FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTowerLevelInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E5A RID: 93786 RVA: 0x00623750 File Offset: 0x00621950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataTowerLevelInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E5B RID: 93787 RVA: 0x006237A8 File Offset: 0x006219A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelRes(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTowerLevelInfo.LevelRes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E5C RID: 93788 RVA: 0x006237FC File Offset: 0x006219FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LevelRes(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			string levelRes;
			LuaObject.checkType(l, 2, out levelRes);
			configDataTowerLevelInfo.LevelRes = levelRes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E5D RID: 93789 RVA: 0x00623854 File Offset: 0x00621A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ThumbImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTowerLevelInfo.ThumbImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E5E RID: 93790 RVA: 0x006238A8 File Offset: 0x00621AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ThumbImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			string thumbImage;
			LuaObject.checkType(l, 2, out thumbImage);
			configDataTowerLevelInfo.ThumbImage = thumbImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E5F RID: 93791 RVA: 0x00623900 File Offset: 0x00621B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTowerLevelInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E60 RID: 93792 RVA: 0x00623954 File Offset: 0x00621B54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataTowerLevelInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E61 RID: 93793 RVA: 0x006239AC File Offset: 0x00621BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleRuleList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTowerLevelInfo.BattleRuleList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E62 RID: 93794 RVA: 0x00623A00 File Offset: 0x00621C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTowerLevelInfo.BattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E63 RID: 93795 RVA: 0x00623A54 File Offset: 0x00621C54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = (ConfigDataTowerLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataTowerLevelInfo.BattleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E64 RID: 93796 RVA: 0x00623AAC File Offset: 0x00621CAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataTowerLevelInfo");
		string name = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.get_ID);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache1, true);
		string name2 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.get_Name);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.set_Name);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache3, true);
		string name3 = "LevelRes";
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.get_LevelRes);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.set_LevelRes);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache5, true);
		string name4 = "ThumbImage";
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.get_ThumbImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.set_ThumbImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache7, true);
		string name5 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.get_Battle_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cache9, true);
		string name6 = "BattleRuleList";
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.get_BattleRuleList);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cacheA, null, true);
		string name7 = "BattleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.get_BattleInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cacheB;
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.set_BattleInfo);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cacheC, true);
		if (Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.<>f__mg$cacheD, typeof(ConfigDataTowerLevelInfo));
	}

	// Token: 0x0400D558 RID: 54616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D559 RID: 54617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D55A RID: 54618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D55B RID: 54619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D55C RID: 54620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D55D RID: 54621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D55E RID: 54622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D55F RID: 54623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D560 RID: 54624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D561 RID: 54625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D562 RID: 54626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D563 RID: 54627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D564 RID: 54628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D565 RID: 54629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
