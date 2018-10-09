using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001190 RID: 4496
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleActorEquipment : LuaObject
{
	// Token: 0x060171EC RID: 94700 RVA: 0x0063E2A8 File Offset: 0x0063C4A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleActorEquipment o = new BattleActorEquipment();
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

	// Token: 0x060171ED RID: 94701 RVA: 0x0063E2F0 File Offset: 0x0063C4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActiveSkillId(IntPtr l)
	{
		int result;
		try
		{
			BattleActorEquipment battleActorEquipment = (BattleActorEquipment)LuaObject.checkSelf(l);
			int activeSkillId = battleActorEquipment.GetActiveSkillId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activeSkillId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171EE RID: 94702 RVA: 0x0063E344 File Offset: 0x0063C544
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EquipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorEquipment battleActorEquipment = (BattleActorEquipment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorEquipment.EquipmentInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171EF RID: 94703 RVA: 0x0063E398 File Offset: 0x0063C598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EquipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorEquipment battleActorEquipment = (BattleActorEquipment)LuaObject.checkSelf(l);
			ConfigDataEquipmentInfo equipmentInfo;
			LuaObject.checkType<ConfigDataEquipmentInfo>(l, 2, out equipmentInfo);
			battleActorEquipment.EquipmentInfo = equipmentInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171F0 RID: 94704 RVA: 0x0063E3F0 File Offset: 0x0063C5F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			BattleActorEquipment battleActorEquipment = (BattleActorEquipment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorEquipment.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171F1 RID: 94705 RVA: 0x0063E444 File Offset: 0x0063C644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			BattleActorEquipment battleActorEquipment = (BattleActorEquipment)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			battleActorEquipment.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171F2 RID: 94706 RVA: 0x0063E49C File Offset: 0x0063C69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnchantProperties(IntPtr l)
	{
		int result;
		try
		{
			BattleActorEquipment battleActorEquipment = (BattleActorEquipment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorEquipment.EnchantProperties);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171F3 RID: 94707 RVA: 0x0063E4F0 File Offset: 0x0063C6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnchantProperties(IntPtr l)
	{
		int result;
		try
		{
			BattleActorEquipment battleActorEquipment = (BattleActorEquipment)LuaObject.checkSelf(l);
			CommonBattleProperty[] enchantProperties;
			LuaObject.checkArray<CommonBattleProperty>(l, 2, out enchantProperties);
			battleActorEquipment.EnchantProperties = enchantProperties;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171F4 RID: 94708 RVA: 0x0063E548 File Offset: 0x0063C748
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleActorEquipment");
		if (Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.GetActiveSkillId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache0);
		string name = "EquipmentInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.get_EquipmentInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.set_EquipmentInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache2, true);
		string name2 = "Level";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.get_Level);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.set_Level);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache4, true);
		string name3 = "EnchantProperties";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.get_EnchantProperties);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.set_EnchantProperties);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.<>f__mg$cache7, typeof(BattleActorEquipment));
	}

	// Token: 0x0400D8AE RID: 55470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D8AF RID: 55471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D8B0 RID: 55472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D8B1 RID: 55473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D8B2 RID: 55474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D8B3 RID: 55475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D8B4 RID: 55476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D8B5 RID: 55477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
