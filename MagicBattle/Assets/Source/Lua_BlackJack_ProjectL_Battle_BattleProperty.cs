using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200119B RID: 4507
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleProperty : LuaObject
{
	// Token: 0x06017419 RID: 95257 RVA: 0x0064F394 File Offset: 0x0064D594
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty o = new BattleProperty();
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

	// Token: 0x0601741A RID: 95258 RVA: 0x0064F3DC File Offset: 0x0064D5DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			battleProperty.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601741B RID: 95259 RVA: 0x0064F428 File Offset: 0x0064D628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeHeroProperties(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 3, out heroInfo);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 4, out jobConnectionInfo);
			int jobLevel;
			LuaObject.checkType(l, 5, out jobLevel);
			int heroLevel;
			LuaObject.checkType(l, 6, out heroLevel);
			int heroStar;
			LuaObject.checkType(l, 7, out heroStar);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 8, out pm);
			battleProperty.ComputeHeroProperties(configDataLoader, heroInfo, jobConnectionInfo, jobLevel, heroLevel, heroStar, pm);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601741C RID: 95260 RVA: 0x0064F4CC File Offset: 0x0064D6CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ApplyExchangeProperty(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 2, out pm);
			battleProperty.ApplyExchangeProperty(pm);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601741D RID: 95261 RVA: 0x0064F524 File Offset: 0x0064D724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeSoldierProperties(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 3, out soldierInfo);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 4, out heroInfo);
			int heroLevel;
			LuaObject.checkType(l, 5, out heroLevel);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 6, out pm);
			battleProperty.ComputeSoldierProperties(configDataLoader, soldierInfo, heroInfo, heroLevel, pm);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601741E RID: 95262 RVA: 0x0064F5B0 File Offset: 0x0064D7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClampNegativeValue_s(IntPtr l)
	{
		int result;
		try
		{
			int value;
			LuaObject.checkType(l, 1, out value);
			int i = BattleProperty.LuaExportHelper.ClampNegativeValue(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601741F RID: 95263 RVA: 0x0064F604 File Offset: 0x0064D804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.HealthPointMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017420 RID: 95264 RVA: 0x0064F658 File Offset: 0x0064D858
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int healthPointMax;
			LuaObject.checkType(l, 2, out healthPointMax);
			battleProperty.HealthPointMax = healthPointMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017421 RID: 95265 RVA: 0x0064F6B0 File Offset: 0x0064D8B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Attack(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Attack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017422 RID: 95266 RVA: 0x0064F704 File Offset: 0x0064D904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Attack(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int attack;
			LuaObject.checkType(l, 2, out attack);
			battleProperty.Attack = attack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017423 RID: 95267 RVA: 0x0064F75C File Offset: 0x0064D95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Defense(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Defense);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017424 RID: 95268 RVA: 0x0064F7B0 File Offset: 0x0064D9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Defense(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int defense;
			LuaObject.checkType(l, 2, out defense);
			battleProperty.Defense = defense;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017425 RID: 95269 RVA: 0x0064F808 File Offset: 0x0064DA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Magic(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Magic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017426 RID: 95270 RVA: 0x0064F85C File Offset: 0x0064DA5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Magic(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int magic;
			LuaObject.checkType(l, 2, out magic);
			battleProperty.Magic = magic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017427 RID: 95271 RVA: 0x0064F8B4 File Offset: 0x0064DAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MagicDefense(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.MagicDefense);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017428 RID: 95272 RVA: 0x0064F908 File Offset: 0x0064DB08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MagicDefense(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int magicDefense;
			LuaObject.checkType(l, 2, out magicDefense);
			battleProperty.MagicDefense = magicDefense;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017429 RID: 95273 RVA: 0x0064F960 File Offset: 0x0064DB60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Dexterity(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Dexterity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601742A RID: 95274 RVA: 0x0064F9B4 File Offset: 0x0064DBB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Dexterity(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int dexterity;
			LuaObject.checkType(l, 2, out dexterity);
			battleProperty.Dexterity = dexterity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601742B RID: 95275 RVA: 0x0064FA0C File Offset: 0x0064DC0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Buff_PhysicalDamageMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_PhysicalDamageMul);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601742C RID: 95276 RVA: 0x0064FA60 File Offset: 0x0064DC60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Buff_PhysicalDamageMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_PhysicalDamageMul;
			LuaObject.checkType(l, 2, out buff_PhysicalDamageMul);
			battleProperty.Buff_PhysicalDamageMul = buff_PhysicalDamageMul;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601742D RID: 95277 RVA: 0x0064FAB8 File Offset: 0x0064DCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Buff_PhysicalDamageReceiveMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_PhysicalDamageReceiveMul);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601742E RID: 95278 RVA: 0x0064FB0C File Offset: 0x0064DD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Buff_PhysicalDamageReceiveMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_PhysicalDamageReceiveMul;
			LuaObject.checkType(l, 2, out buff_PhysicalDamageReceiveMul);
			battleProperty.Buff_PhysicalDamageReceiveMul = buff_PhysicalDamageReceiveMul;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601742F RID: 95279 RVA: 0x0064FB64 File Offset: 0x0064DD64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Buff_SuperPhysicalDamageReceiveMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_SuperPhysicalDamageReceiveMul);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017430 RID: 95280 RVA: 0x0064FBB8 File Offset: 0x0064DDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Buff_SuperPhysicalDamageReceiveMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_SuperPhysicalDamageReceiveMul;
			LuaObject.checkType(l, 2, out buff_SuperPhysicalDamageReceiveMul);
			battleProperty.Buff_SuperPhysicalDamageReceiveMul = buff_SuperPhysicalDamageReceiveMul;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017431 RID: 95281 RVA: 0x0064FC10 File Offset: 0x0064DE10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Buff_HealMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_HealMul);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017432 RID: 95282 RVA: 0x0064FC64 File Offset: 0x0064DE64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Buff_HealMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_HealMul;
			LuaObject.checkType(l, 2, out buff_HealMul);
			battleProperty.Buff_HealMul = buff_HealMul;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017433 RID: 95283 RVA: 0x0064FCBC File Offset: 0x0064DEBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Buff_HealReceiveMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_HealReceiveMul);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017434 RID: 95284 RVA: 0x0064FD10 File Offset: 0x0064DF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Buff_HealReceiveMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_HealReceiveMul;
			LuaObject.checkType(l, 2, out buff_HealReceiveMul);
			battleProperty.Buff_HealReceiveMul = buff_HealReceiveMul;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017435 RID: 95285 RVA: 0x0064FD68 File Offset: 0x0064DF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Buff_MagicalDamageMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_MagicalDamageMul);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017436 RID: 95286 RVA: 0x0064FDBC File Offset: 0x0064DFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Buff_MagicalDamageMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_MagicalDamageMul;
			LuaObject.checkType(l, 2, out buff_MagicalDamageMul);
			battleProperty.Buff_MagicalDamageMul = buff_MagicalDamageMul;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017437 RID: 95287 RVA: 0x0064FE14 File Offset: 0x0064E014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Buff_MagicalDamageReceiveMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_MagicalDamageReceiveMul);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017438 RID: 95288 RVA: 0x0064FE68 File Offset: 0x0064E068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Buff_MagicalDamageReceiveMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_MagicalDamageReceiveMul;
			LuaObject.checkType(l, 2, out buff_MagicalDamageReceiveMul);
			battleProperty.Buff_MagicalDamageReceiveMul = buff_MagicalDamageReceiveMul;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017439 RID: 95289 RVA: 0x0064FEC0 File Offset: 0x0064E0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Buff_SuperMagicalDamageReceiveMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_SuperMagicalDamageReceiveMul);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601743A RID: 95290 RVA: 0x0064FF14 File Offset: 0x0064E114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Buff_SuperMagicalDamageReceiveMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_SuperMagicalDamageReceiveMul;
			LuaObject.checkType(l, 2, out buff_SuperMagicalDamageReceiveMul);
			battleProperty.Buff_SuperMagicalDamageReceiveMul = buff_SuperMagicalDamageReceiveMul;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601743B RID: 95291 RVA: 0x0064FF6C File Offset: 0x0064E16C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Buff_IgnoreDFMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_IgnoreDFMul);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601743C RID: 95292 RVA: 0x0064FFC0 File Offset: 0x0064E1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Buff_IgnoreDFMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_IgnoreDFMul;
			LuaObject.checkType(l, 2, out buff_IgnoreDFMul);
			battleProperty.Buff_IgnoreDFMul = buff_IgnoreDFMul;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601743D RID: 95293 RVA: 0x00650018 File Offset: 0x0064E218
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Buff_SkillDamageMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_SkillDamageMul);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601743E RID: 95294 RVA: 0x0065006C File Offset: 0x0064E26C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Buff_SkillDamageMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_SkillDamageMul;
			LuaObject.checkType(l, 2, out buff_SkillDamageMul);
			battleProperty.Buff_SkillDamageMul = buff_SkillDamageMul;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601743F RID: 95295 RVA: 0x006500C4 File Offset: 0x0064E2C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Buff_BFSkillDamageMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_BFSkillDamageMul);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017440 RID: 95296 RVA: 0x00650118 File Offset: 0x0064E318
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Buff_BFSkillDamageMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_BFSkillDamageMul;
			LuaObject.checkType(l, 2, out buff_BFSkillDamageMul);
			battleProperty.Buff_BFSkillDamageMul = buff_BFSkillDamageMul;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017441 RID: 95297 RVA: 0x00650170 File Offset: 0x0064E370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Buff_RangeDamageReceiveMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_RangeDamageReceiveMul);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017442 RID: 95298 RVA: 0x006501C4 File Offset: 0x0064E3C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Buff_RangeDamageReceiveMul(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_RangeDamageReceiveMul;
			LuaObject.checkType(l, 2, out buff_RangeDamageReceiveMul);
			battleProperty.Buff_RangeDamageReceiveMul = buff_RangeDamageReceiveMul;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017443 RID: 95299 RVA: 0x0065021C File Offset: 0x0064E41C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Buff_ReceiveCriticalRateAdd(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Buff_ReceiveCriticalRateAdd);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017444 RID: 95300 RVA: 0x00650270 File Offset: 0x0064E470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Buff_ReceiveCriticalRateAdd(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int buff_ReceiveCriticalRateAdd;
			LuaObject.checkType(l, 2, out buff_ReceiveCriticalRateAdd);
			battleProperty.Buff_ReceiveCriticalRateAdd = buff_ReceiveCriticalRateAdd;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017445 RID: 95301 RVA: 0x006502C8 File Offset: 0x0064E4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Cmd_HealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Cmd_HealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017446 RID: 95302 RVA: 0x0065031C File Offset: 0x0064E51C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Cmd_HealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int cmd_HealthPoint;
			LuaObject.checkType(l, 2, out cmd_HealthPoint);
			battleProperty.Cmd_HealthPoint = cmd_HealthPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017447 RID: 95303 RVA: 0x00650374 File Offset: 0x0064E574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Cmd_Attack(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Cmd_Attack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017448 RID: 95304 RVA: 0x006503C8 File Offset: 0x0064E5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Cmd_Attack(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int cmd_Attack;
			LuaObject.checkType(l, 2, out cmd_Attack);
			battleProperty.Cmd_Attack = cmd_Attack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017449 RID: 95305 RVA: 0x00650420 File Offset: 0x0064E620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Cmd_Defense(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Cmd_Defense);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601744A RID: 95306 RVA: 0x00650474 File Offset: 0x0064E674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Cmd_Defense(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int cmd_Defense;
			LuaObject.checkType(l, 2, out cmd_Defense);
			battleProperty.Cmd_Defense = cmd_Defense;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601744B RID: 95307 RVA: 0x006504CC File Offset: 0x0064E6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Cmd_MagicDefense(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.Cmd_MagicDefense);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601744C RID: 95308 RVA: 0x00650520 File Offset: 0x0064E720
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Cmd_MagicDefense(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int cmd_MagicDefense;
			LuaObject.checkType(l, 2, out cmd_MagicDefense);
			battleProperty.Cmd_MagicDefense = cmd_MagicDefense;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601744D RID: 95309 RVA: 0x00650578 File Offset: 0x0064E778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CriticalDamage(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.CriticalDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601744E RID: 95310 RVA: 0x006505CC File Offset: 0x0064E7CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CriticalDamage(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int criticalDamage;
			LuaObject.checkType(l, 2, out criticalDamage);
			battleProperty.CriticalDamage = criticalDamage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601744F RID: 95311 RVA: 0x00650624 File Offset: 0x0064E824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CriticalRate(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.CriticalRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017450 RID: 95312 RVA: 0x00650678 File Offset: 0x0064E878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CriticalRate(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int criticalRate;
			LuaObject.checkType(l, 2, out criticalRate);
			battleProperty.CriticalRate = criticalRate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017451 RID: 95313 RVA: 0x006506D0 File Offset: 0x0064E8D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackDistance(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.AttackDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017452 RID: 95314 RVA: 0x00650724 File Offset: 0x0064E924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AttackDistance(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int attackDistance;
			LuaObject.checkType(l, 2, out attackDistance);
			battleProperty.AttackDistance = attackDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017453 RID: 95315 RVA: 0x0065077C File Offset: 0x0064E97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MagicSkillDistanceAdd(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.MagicSkillDistanceAdd);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017454 RID: 95316 RVA: 0x006507D0 File Offset: 0x0064E9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MagicSkillDistanceAdd(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int magicSkillDistanceAdd;
			LuaObject.checkType(l, 2, out magicSkillDistanceAdd);
			battleProperty.MagicSkillDistanceAdd = magicSkillDistanceAdd;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017455 RID: 95317 RVA: 0x00650828 File Offset: 0x0064EA28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PhysicalSkillDistanceAdd(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.PhysicalSkillDistanceAdd);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017456 RID: 95318 RVA: 0x0065087C File Offset: 0x0064EA7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PhysicalSkillDistanceAdd(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int physicalSkillDistanceAdd;
			LuaObject.checkType(l, 2, out physicalSkillDistanceAdd);
			battleProperty.PhysicalSkillDistanceAdd = physicalSkillDistanceAdd;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017457 RID: 95319 RVA: 0x006508D4 File Offset: 0x0064EAD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MovePoint(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleProperty.MovePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017458 RID: 95320 RVA: 0x00650928 File Offset: 0x0064EB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MovePoint(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty battleProperty = (BattleProperty)LuaObject.checkSelf(l);
			int movePoint;
			LuaObject.checkType(l, 2, out movePoint);
			battleProperty.MovePoint = movePoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017459 RID: 95321 RVA: 0x00650980 File Offset: 0x0064EB80
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleProperty");
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.ComputeHeroProperties);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.ApplyExchangeProperty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.ComputeSoldierProperties);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.ClampNegativeValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache4);
		string name = "HealthPointMax";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_HealthPointMax);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_HealthPointMax);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache6, true);
		string name2 = "Attack";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Attack);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Attack);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache8, true);
		string name3 = "Defense";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Defense);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Defense);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheA, true);
		string name4 = "Magic";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Magic);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Magic);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheC, true);
		string name5 = "MagicDefense";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_MagicDefense);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_MagicDefense);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheE, true);
		string name6 = "Dexterity";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Dexterity);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Dexterity);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache10, true);
		string name7 = "Buff_PhysicalDamageMul";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_PhysicalDamageMul);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_PhysicalDamageMul);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache12, true);
		string name8 = "Buff_PhysicalDamageReceiveMul";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_PhysicalDamageReceiveMul);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_PhysicalDamageReceiveMul);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache14, true);
		string name9 = "Buff_SuperPhysicalDamageReceiveMul";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_SuperPhysicalDamageReceiveMul);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_SuperPhysicalDamageReceiveMul);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache16, true);
		string name10 = "Buff_HealMul";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_HealMul);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_HealMul);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache18, true);
		string name11 = "Buff_HealReceiveMul";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_HealReceiveMul);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_HealReceiveMul);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1A, true);
		string name12 = "Buff_MagicalDamageMul";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_MagicalDamageMul);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_MagicalDamageMul);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1C, true);
		string name13 = "Buff_MagicalDamageReceiveMul";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_MagicalDamageReceiveMul);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_MagicalDamageReceiveMul);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1E, true);
		string name14 = "Buff_SuperMagicalDamageReceiveMul";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_SuperMagicalDamageReceiveMul);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_SuperMagicalDamageReceiveMul);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache20, true);
		string name15 = "Buff_IgnoreDFMul";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_IgnoreDFMul);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_IgnoreDFMul);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache22, true);
		string name16 = "Buff_SkillDamageMul";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_SkillDamageMul);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_SkillDamageMul);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache24, true);
		string name17 = "Buff_BFSkillDamageMul";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_BFSkillDamageMul);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_BFSkillDamageMul);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache26, true);
		string name18 = "Buff_RangeDamageReceiveMul";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_RangeDamageReceiveMul);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_RangeDamageReceiveMul);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache28, true);
		string name19 = "Buff_ReceiveCriticalRateAdd";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Buff_ReceiveCriticalRateAdd);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Buff_ReceiveCriticalRateAdd);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2A, true);
		string name20 = "Cmd_HealthPoint";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Cmd_HealthPoint);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Cmd_HealthPoint);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2C, true);
		string name21 = "Cmd_Attack";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Cmd_Attack);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Cmd_Attack);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2E, true);
		string name22 = "Cmd_Defense";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Cmd_Defense);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Cmd_Defense);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache30, true);
		string name23 = "Cmd_MagicDefense";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_Cmd_MagicDefense);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_Cmd_MagicDefense);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache32, true);
		string name24 = "CriticalDamage";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_CriticalDamage);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_CriticalDamage);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache34, true);
		string name25 = "CriticalRate";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_CriticalRate);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_CriticalRate);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache36, true);
		string name26 = "AttackDistance";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_AttackDistance);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_AttackDistance);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache38, true);
		string name27 = "MagicSkillDistanceAdd";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_MagicSkillDistanceAdd);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_MagicSkillDistanceAdd);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3A, true);
		string name28 = "PhysicalSkillDistanceAdd";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_PhysicalSkillDistanceAdd);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_PhysicalSkillDistanceAdd);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3C, true);
		string name29 = "MovePoint";
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.get_MovePoint);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.set_MovePoint);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3E, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleProperty.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleProperty.<>f__mg$cache3F, typeof(BattleProperty));
	}

	// Token: 0x0400DAC5 RID: 56005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DAC6 RID: 56006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DAC7 RID: 56007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DAC8 RID: 56008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DAC9 RID: 56009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DACA RID: 56010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DACB RID: 56011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DACC RID: 56012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DACD RID: 56013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DACE RID: 56014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DACF RID: 56015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DAD0 RID: 56016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DAD1 RID: 56017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DAD2 RID: 56018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DAD3 RID: 56019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DAD4 RID: 56020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DAD5 RID: 56021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DAD6 RID: 56022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DAD7 RID: 56023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DAD8 RID: 56024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DAD9 RID: 56025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DADA RID: 56026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DADB RID: 56027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DADC RID: 56028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DADD RID: 56029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DADE RID: 56030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DADF RID: 56031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DAE0 RID: 56032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DAE1 RID: 56033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DAE2 RID: 56034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DAE3 RID: 56035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DAE4 RID: 56036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DAE5 RID: 56037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DAE6 RID: 56038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DAE7 RID: 56039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400DAE8 RID: 56040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400DAE9 RID: 56041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400DAEA RID: 56042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400DAEB RID: 56043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400DAEC RID: 56044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400DAED RID: 56045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400DAEE RID: 56046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400DAEF RID: 56047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400DAF0 RID: 56048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400DAF1 RID: 56049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400DAF2 RID: 56050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400DAF3 RID: 56051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400DAF4 RID: 56052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400DAF5 RID: 56053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400DAF6 RID: 56054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400DAF7 RID: 56055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400DAF8 RID: 56056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400DAF9 RID: 56057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400DAFA RID: 56058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400DAFB RID: 56059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400DAFC RID: 56060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400DAFD RID: 56061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400DAFE RID: 56062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400DAFF RID: 56063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400DB00 RID: 56064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400DB01 RID: 56065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400DB02 RID: 56066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400DB03 RID: 56067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400DB04 RID: 56068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;
}
