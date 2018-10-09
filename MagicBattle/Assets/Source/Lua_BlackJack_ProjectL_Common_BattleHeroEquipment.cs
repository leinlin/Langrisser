using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011CC RID: 4556
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleHeroEquipment : LuaObject
{
	// Token: 0x06017A3F RID: 96831 RVA: 0x0067D888 File Offset: 0x0067BA88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment o = new BattleHeroEquipment();
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

	// Token: 0x06017A40 RID: 96832 RVA: 0x0067D8D0 File Offset: 0x0067BAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleHeroEquipmentToPBBattleHeroEquipment_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment equipment;
			LuaObject.checkType<BattleHeroEquipment>(l, 1, out equipment);
			ProBattleHeroEquipment o = BattleHeroEquipment.BattleHeroEquipmentToPBBattleHeroEquipment(equipment);
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

	// Token: 0x06017A41 RID: 96833 RVA: 0x0067D924 File Offset: 0x0067BB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBBattleHeroEquipmentToBattleHeroEquipment_s(IntPtr l)
	{
		int result;
		try
		{
			ProBattleHeroEquipment pbEquipment;
			LuaObject.checkType<ProBattleHeroEquipment>(l, 1, out pbEquipment);
			BattleHeroEquipment o = BattleHeroEquipment.PBBattleHeroEquipmentToBattleHeroEquipment(pbEquipment);
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

	// Token: 0x06017A42 RID: 96834 RVA: 0x0067D978 File Offset: 0x0067BB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateEquipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			battleHeroEquipment.m_luaExportHelper.UpdateEquipmentInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A43 RID: 96835 RVA: 0x0067D9CC File Offset: 0x0067BBCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_id(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroEquipment.m_luaExportHelper.m_id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A44 RID: 96836 RVA: 0x0067DA24 File Offset: 0x0067BC24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_id(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			battleHeroEquipment.m_luaExportHelper.m_id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A45 RID: 96837 RVA: 0x0067DA80 File Offset: 0x0067BC80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnchantProperties(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroEquipment.EnchantProperties);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A46 RID: 96838 RVA: 0x0067DAD4 File Offset: 0x0067BCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnchantProperties(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			List<CommonBattleProperty> enchantProperties;
			LuaObject.checkType<List<CommonBattleProperty>>(l, 2, out enchantProperties);
			battleHeroEquipment.EnchantProperties = enchantProperties;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A47 RID: 96839 RVA: 0x0067DB2C File Offset: 0x0067BD2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroEquipment.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A48 RID: 96840 RVA: 0x0067DB80 File Offset: 0x0067BD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Id(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			battleHeroEquipment.Id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A49 RID: 96841 RVA: 0x0067DBD8 File Offset: 0x0067BDD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Exp(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroEquipment.Exp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A4A RID: 96842 RVA: 0x0067DC2C File Offset: 0x0067BE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Exp(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			int exp;
			LuaObject.checkType(l, 2, out exp);
			battleHeroEquipment.Exp = exp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A4B RID: 96843 RVA: 0x0067DC84 File Offset: 0x0067BE84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroEquipment.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A4C RID: 96844 RVA: 0x0067DCD8 File Offset: 0x0067BED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			battleHeroEquipment.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A4D RID: 96845 RVA: 0x0067DD30 File Offset: 0x0067BF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StarLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroEquipment.StarLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A4E RID: 96846 RVA: 0x0067DD84 File Offset: 0x0067BF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StarLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			int starLevel;
			LuaObject.checkType(l, 2, out starLevel);
			battleHeroEquipment.StarLevel = starLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A4F RID: 96847 RVA: 0x0067DDDC File Offset: 0x0067BFDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ResonanceId(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroEquipment.ResonanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A50 RID: 96848 RVA: 0x0067DE30 File Offset: 0x0067C030
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ResonanceId(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			int resonanceId;
			LuaObject.checkType(l, 2, out resonanceId);
			battleHeroEquipment.ResonanceId = resonanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A51 RID: 96849 RVA: 0x0067DE88 File Offset: 0x0067C088
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EquipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroEquipment.EquipmentInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A52 RID: 96850 RVA: 0x0067DEDC File Offset: 0x0067C0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EquipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroEquipment battleHeroEquipment = (BattleHeroEquipment)LuaObject.checkSelf(l);
			ConfigDataEquipmentInfo equipmentInfo;
			LuaObject.checkType<ConfigDataEquipmentInfo>(l, 2, out equipmentInfo);
			battleHeroEquipment.m_luaExportHelper.EquipmentInfo = equipmentInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A53 RID: 96851 RVA: 0x0067DF38 File Offset: 0x0067C138
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleHeroEquipment");
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.BattleHeroEquipmentToPBBattleHeroEquipment_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.PBBattleHeroEquipmentToBattleHeroEquipment_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.UpdateEquipmentInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache2);
		string name = "m_id";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.get_m_id);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.set_m_id);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache4, true);
		string name2 = "EnchantProperties";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.get_EnchantProperties);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.set_EnchantProperties);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache6, true);
		string name3 = "Id";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.get_Id);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.set_Id);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache8, true);
		string name4 = "Exp";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.get_Exp);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.set_Exp);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheA, true);
		string name5 = "Level";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.get_Level);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.set_Level);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheC, true);
		string name6 = "StarLevel";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.get_StarLevel);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.set_StarLevel);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheE, true);
		string name7 = "ResonanceId";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.get_ResonanceId);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.set_ResonanceId);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache10, true);
		string name8 = "EquipmentInfo";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.get_EquipmentInfo);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.set_EquipmentInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache12, true);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.<>f__mg$cache13, typeof(BattleHeroEquipment));
	}

	// Token: 0x0400E089 RID: 57481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E08A RID: 57482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E08B RID: 57483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E08C RID: 57484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E08D RID: 57485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E08E RID: 57486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E08F RID: 57487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E090 RID: 57488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E091 RID: 57489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E092 RID: 57490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E093 RID: 57491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E094 RID: 57492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E095 RID: 57493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E096 RID: 57494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E097 RID: 57495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E098 RID: 57496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E099 RID: 57497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E09A RID: 57498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E09B RID: 57499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E09C RID: 57500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
