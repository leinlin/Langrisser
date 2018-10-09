using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011FA RID: 4602
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle : LuaObject
{
	// Token: 0x06017DD4 RID: 97748 RVA: 0x00696EF4 File Offset: 0x006950F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionCooperateBattle o = new DataSectionCooperateBattle();
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

	// Token: 0x06017DD5 RID: 97749 RVA: 0x00696F3C File Offset: 0x0069513C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionCooperateBattle dataSectionCooperateBattle = (DataSectionCooperateBattle)LuaObject.checkSelf(l);
			dataSectionCooperateBattle.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DD6 RID: 97750 RVA: 0x00696F88 File Offset: 0x00695188
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionCooperateBattle dataSectionCooperateBattle = (DataSectionCooperateBattle)LuaObject.checkSelf(l);
			object o = dataSectionCooperateBattle.SerializeToClient();
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

	// Token: 0x06017DD7 RID: 97751 RVA: 0x00696FDC File Offset: 0x006951DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateInstantiatedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionCooperateBattle dataSectionCooperateBattle = (DataSectionCooperateBattle)LuaObject.checkSelf(l);
			DSCooperateBattleNtf ds;
			LuaObject.checkType<DSCooperateBattleNtf>(l, 2, out ds);
			dataSectionCooperateBattle.UpdateInstantiatedData(ds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DD8 RID: 97752 RVA: 0x00697034 File Offset: 0x00695234
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			DataSectionCooperateBattle dataSectionCooperateBattle = (DataSectionCooperateBattle)LuaObject.checkSelf(l);
			int battleID;
			LuaObject.checkType(l, 2, out battleID);
			CooperateBattle cooperateBattle = dataSectionCooperateBattle.GetCooperateBattle(battleID);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DD9 RID: 97753 RVA: 0x00697098 File Offset: 0x00695298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionCooperateBattle dataSectionCooperateBattle = (DataSectionCooperateBattle)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			CooperateBattleLevel cooperateBattleLevel = dataSectionCooperateBattle.GetCooperateBattleLevel(battleId, levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DDA RID: 97754 RVA: 0x00697108 File Offset: 0x00695308
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetFirstCooperateBattleLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionCooperateBattle dataSectionCooperateBattle = (DataSectionCooperateBattle)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool mustBeAvailable;
			LuaObject.checkType(l, 3, out mustBeAvailable);
			CooperateBattleLevel firstCooperateBattleLevel = dataSectionCooperateBattle.GetFirstCooperateBattleLevel(levelId, mustBeAvailable);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, firstCooperateBattleLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DDB RID: 97755 RVA: 0x00697178 File Offset: 0x00695378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionCooperateBattle dataSectionCooperateBattle = (DataSectionCooperateBattle)LuaObject.checkSelf(l);
			int challengedNums;
			LuaObject.checkType(l, 2, out challengedNums);
			dataSectionCooperateBattle.SetChallengedNums(challengedNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DDC RID: 97756 RVA: 0x006971D0 File Offset: 0x006953D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IncreaseChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionCooperateBattle dataSectionCooperateBattle = (DataSectionCooperateBattle)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			dataSectionCooperateBattle.IncreaseChallengedNums(battleId, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DDD RID: 97757 RVA: 0x00697234 File Offset: 0x00695434
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleCollections(IntPtr l)
	{
		int result;
		try
		{
			DataSectionCooperateBattle dataSectionCooperateBattle = (DataSectionCooperateBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionCooperateBattle.BattleCollections);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DDE RID: 97758 RVA: 0x00697288 File Offset: 0x00695488
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleCollections(IntPtr l)
	{
		int result;
		try
		{
			DataSectionCooperateBattle dataSectionCooperateBattle = (DataSectionCooperateBattle)LuaObject.checkSelf(l);
			CooperateBattleCollections battleCollections;
			LuaObject.checkType<CooperateBattleCollections>(l, 2, out battleCollections);
			dataSectionCooperateBattle.BattleCollections = battleCollections;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DDF RID: 97759 RVA: 0x006972E0 File Offset: 0x006954E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionCooperateBattle");
		if (Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.UpdateInstantiatedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.GetCooperateBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.GetCooperateBattleLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.GetFirstCooperateBattleLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.SetChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.IncreaseChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache7);
		string name = "BattleCollections";
		if (Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.get_BattleCollections);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.set_BattleCollections);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.<>f__mg$cacheA, typeof(DataSectionCooperateBattle), typeof(DataSection));
	}

	// Token: 0x0400E3C2 RID: 58306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E3C3 RID: 58307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E3C4 RID: 58308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E3C5 RID: 58309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E3C6 RID: 58310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E3C7 RID: 58311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E3C8 RID: 58312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E3C9 RID: 58313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E3CA RID: 58314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E3CB RID: 58315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E3CC RID: 58316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
