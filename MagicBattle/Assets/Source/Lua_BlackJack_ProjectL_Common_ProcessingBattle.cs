using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200125F RID: 4703
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ProcessingBattle : LuaObject
{
	// Token: 0x0601886A RID: 100458 RVA: 0x006E6434 File Offset: 0x006E4634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ProcessingBattle o = new ProcessingBattle();
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

	// Token: 0x0601886B RID: 100459 RVA: 0x006E647C File Offset: 0x006E467C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleProcessingToPbBattleProcessing_s(IntPtr l)
	{
		int result;
		try
		{
			ProcessingBattle battleInfo;
			LuaObject.checkType<ProcessingBattle>(l, 1, out battleInfo);
			ProBattleProcessing o = ProcessingBattle.BattleProcessingToPbBattleProcessing(battleInfo);
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

	// Token: 0x0601886C RID: 100460 RVA: 0x006E64D0 File Offset: 0x006E46D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PbBattleProcessingToBattleProcessing_s(IntPtr l)
	{
		int result;
		try
		{
			ProBattleProcessing pbBattleInfo;
			LuaObject.checkType<ProBattleProcessing>(l, 1, out pbBattleInfo);
			ProcessingBattle o = ProcessingBattle.PbBattleProcessingToBattleProcessing(pbBattleInfo);
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

	// Token: 0x0601886D RID: 100461 RVA: 0x006E6524 File Offset: 0x006E4724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Params(IntPtr l)
	{
		int result;
		try
		{
			ProcessingBattle processingBattle = (ProcessingBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, processingBattle.Params);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601886E RID: 100462 RVA: 0x006E6578 File Offset: 0x006E4778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Params(IntPtr l)
	{
		int result;
		try
		{
			ProcessingBattle processingBattle = (ProcessingBattle)LuaObject.checkSelf(l);
			List<int> @params;
			LuaObject.checkType<List<int>>(l, 2, out @params);
			processingBattle.Params = @params;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601886F RID: 100463 RVA: 0x006E65D0 File Offset: 0x006E47D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			ProcessingBattle processingBattle = (ProcessingBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)processingBattle.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018870 RID: 100464 RVA: 0x006E6624 File Offset: 0x006E4824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			ProcessingBattle processingBattle = (ProcessingBattle)LuaObject.checkSelf(l);
			BattleType type;
			LuaObject.checkEnum<BattleType>(l, 2, out type);
			processingBattle.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018871 RID: 100465 RVA: 0x006E667C File Offset: 0x006E487C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TypeId(IntPtr l)
	{
		int result;
		try
		{
			ProcessingBattle processingBattle = (ProcessingBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, processingBattle.TypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018872 RID: 100466 RVA: 0x006E66D0 File Offset: 0x006E48D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TypeId(IntPtr l)
	{
		int result;
		try
		{
			ProcessingBattle processingBattle = (ProcessingBattle)LuaObject.checkSelf(l);
			int typeId;
			LuaObject.checkType(l, 2, out typeId);
			processingBattle.TypeId = typeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018873 RID: 100467 RVA: 0x006E6728 File Offset: 0x006E4928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RandomSeed(IntPtr l)
	{
		int result;
		try
		{
			ProcessingBattle processingBattle = (ProcessingBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, processingBattle.RandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018874 RID: 100468 RVA: 0x006E677C File Offset: 0x006E497C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RandomSeed(IntPtr l)
	{
		int result;
		try
		{
			ProcessingBattle processingBattle = (ProcessingBattle)LuaObject.checkSelf(l);
			int randomSeed;
			LuaObject.checkType(l, 2, out randomSeed);
			processingBattle.RandomSeed = randomSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018875 RID: 100469 RVA: 0x006E67D4 File Offset: 0x006E49D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			ProcessingBattle processingBattle = (ProcessingBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, processingBattle.ArmyRandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018876 RID: 100470 RVA: 0x006E6828 File Offset: 0x006E4A28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ArmyRandomSeed(IntPtr l)
	{
		int result;
		try
		{
			ProcessingBattle processingBattle = (ProcessingBattle)LuaObject.checkSelf(l);
			int armyRandomSeed;
			LuaObject.checkType(l, 2, out armyRandomSeed);
			processingBattle.ArmyRandomSeed = armyRandomSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018877 RID: 100471 RVA: 0x006E6880 File Offset: 0x006E4A80
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ProcessingBattle");
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.BattleProcessingToPbBattleProcessing_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.PbBattleProcessingToBattleProcessing_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache1);
		string name = "Params";
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.get_Params);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.set_Params);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache3, true);
		string name2 = "Type";
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.get_Type);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.set_Type);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache5, true);
		string name3 = "TypeId";
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.get_TypeId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.set_TypeId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache7, true);
		string name4 = "RandomSeed";
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.get_RandomSeed);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.set_RandomSeed);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cache9, true);
		string name5 = "ArmyRandomSeed";
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.get_ArmyRandomSeed);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.set_ArmyRandomSeed);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ProcessingBattle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ProcessingBattle.<>f__mg$cacheC, typeof(ProcessingBattle));
	}

	// Token: 0x0400ED8E RID: 60814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400ED8F RID: 60815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400ED90 RID: 60816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400ED91 RID: 60817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400ED92 RID: 60818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400ED93 RID: 60819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400ED94 RID: 60820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400ED95 RID: 60821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400ED96 RID: 60822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400ED97 RID: 60823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400ED98 RID: 60824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400ED99 RID: 60825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400ED9A RID: 60826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
