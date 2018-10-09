using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011E3 RID: 4579
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon : LuaObject
{
	// Token: 0x06017BBE RID: 97214 RVA: 0x00687F20 File Offset: 0x00686120
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon o = new ClimbTowerComponentCommon();
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

	// Token: 0x06017BBF RID: 97215 RVA: 0x00687F68 File Offset: 0x00686168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			string name = climbTowerComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BC0 RID: 97216 RVA: 0x00687FBC File Offset: 0x006861BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			climbTowerComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BC1 RID: 97217 RVA: 0x00688008 File Offset: 0x00686208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			climbTowerComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BC2 RID: 97218 RVA: 0x00688054 File Offset: 0x00686254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			climbTowerComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BC3 RID: 97219 RVA: 0x006880A0 File Offset: 0x006862A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			climbTowerComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BC4 RID: 97220 RVA: 0x006880F8 File Offset: 0x006862F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			climbTowerComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BC5 RID: 97221 RVA: 0x00688144 File Offset: 0x00686344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedFlush(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			bool b = climbTowerComponentCommon.IsNeedFlush();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BC6 RID: 97222 RVA: 0x00688198 File Offset: 0x00686398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAutoRaidClimbTowerMax(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			int autoRaidClimbTowerMax = climbTowerComponentCommon.GetAutoRaidClimbTowerMax();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, autoRaidClimbTowerMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BC7 RID: 97223 RVA: 0x006881EC File Offset: 0x006863EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsReachTopTower(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			bool b = climbTowerComponentCommon.IsReachTopTower();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BC8 RID: 97224 RVA: 0x00688240 File Offset: 0x00686440
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetClimbTower(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			ClimbTower climbTower = climbTowerComponentCommon.GetClimbTower();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BC9 RID: 97225 RVA: 0x00688294 File Offset: 0x00686494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCompleteSuccessFloor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			int completeSuccessFloor;
			LuaObject.checkType(l, 2, out completeSuccessFloor);
			climbTowerComponentCommon.SetCompleteSuccessFloor(completeSuccessFloor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BCA RID: 97226 RVA: 0x006882EC File Offset: 0x006864EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGlobalClimbTowerInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			GlobalClimbTowerInfo globalClimbTowerInfo = climbTowerComponentCommon.GetGlobalClimbTowerInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalClimbTowerInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BCB RID: 97227 RVA: 0x00688340 File Offset: 0x00686540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AttackClimbTowerLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			int floorId;
			LuaObject.checkType(l, 2, out floorId);
			int i = climbTowerComponentCommon.AttackClimbTowerLevel(floorId);
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

	// Token: 0x06017BCC RID: 97228 RVA: 0x006883A4 File Offset: 0x006865A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackClimbTowerLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			int floorId;
			LuaObject.checkType(l, 2, out floorId);
			int i = climbTowerComponentCommon.CanAttackClimbTowerLevel(floorId);
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

	// Token: 0x06017BCD RID: 97229 RVA: 0x00688408 File Offset: 0x00686608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFloor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			int floorId;
			LuaObject.checkType(l, 2, out floorId);
			GlobalClimbTowerFloor floor = climbTowerComponentCommon.GetFloor(floorId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, floor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BCE RID: 97230 RVA: 0x0068846C File Offset: 0x0068666C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NewClimbTower(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			int seed;
			LuaObject.checkType(l, 2, out seed);
			GlobalClimbTowerInfo o = climbTowerComponentCommon.NewClimbTower(seed);
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

	// Token: 0x06017BCF RID: 97231 RVA: 0x006884D0 File Offset: 0x006866D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanRaidLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out floorInfo);
			int i = climbTowerComponentCommon.CanRaidLevel(floorInfo);
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

	// Token: 0x06017BD0 RID: 97232 RVA: 0x00688534 File Offset: 0x00686734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCommonSuccessClimbTowerLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out floorInfo);
			ConfigDataTowerLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTowerLevelInfo>(l, 3, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			int energyCost;
			LuaObject.checkType(l, 5, out energyCost);
			climbTowerComponentCommon.m_luaExportHelper.SetCommonSuccessClimbTowerLevel(floorInfo, levelInfo, battleTreasures, energyCost);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BD1 RID: 97233 RVA: 0x006885B8 File Offset: 0x006867B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetRaidSuccessClimbTowerLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo raidSuccessClimbTowerLevel;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out raidSuccessClimbTowerLevel);
			climbTowerComponentCommon.m_luaExportHelper.SetRaidSuccessClimbTowerLevel(raidSuccessClimbTowerLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BD2 RID: 97234 RVA: 0x00688614 File Offset: 0x00686814
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackLevelByEnergyAndSoOn(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out floorInfo);
			bool checkBagFull;
			LuaObject.checkType(l, 3, out checkBagFull);
			int i = climbTowerComponentCommon.m_luaExportHelper.CanAttackLevelByEnergyAndSoOn(floorInfo, checkBagFull);
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

	// Token: 0x06017BD3 RID: 97235 RVA: 0x00688688 File Offset: 0x00686888
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BD4 RID: 97236 RVA: 0x006886E0 File Offset: 0x006868E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			climbTowerComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BD5 RID: 97237 RVA: 0x0068873C File Offset: 0x0068693C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BD6 RID: 97238 RVA: 0x00688794 File Offset: 0x00686994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			climbTowerComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BD7 RID: 97239 RVA: 0x006887F0 File Offset: 0x006869F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BD8 RID: 97240 RVA: 0x00688848 File Offset: 0x00686A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			climbTowerComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BD9 RID: 97241 RVA: 0x006888A4 File Offset: 0x00686AA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BDA RID: 97242 RVA: 0x006888FC File Offset: 0x00686AFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			climbTowerComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BDB RID: 97243 RVA: 0x00688958 File Offset: 0x00686B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BDC RID: 97244 RVA: 0x006889B0 File Offset: 0x00686BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			climbTowerComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BDD RID: 97245 RVA: 0x00688A0C File Offset: 0x00686C0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_climbTowerDS(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerComponentCommon.m_luaExportHelper.m_climbTowerDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BDE RID: 97246 RVA: 0x00688A64 File Offset: 0x00686C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_climbTowerDS(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			DataSectionClimbTower climbTowerDS;
			LuaObject.checkType<DataSectionClimbTower>(l, 2, out climbTowerDS);
			climbTowerComponentCommon.m_luaExportHelper.m_climbTowerDS = climbTowerDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BDF RID: 97247 RVA: 0x00688AC0 File Offset: 0x00686CC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ClimbTowerFloorMax(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerComponentCommon.m_luaExportHelper.ClimbTowerFloorMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BE0 RID: 97248 RVA: 0x00688B18 File Offset: 0x00686D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ClimbTowerFloorMax(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			int climbTowerFloorMax;
			LuaObject.checkType(l, 2, out climbTowerFloorMax);
			climbTowerComponentCommon.m_luaExportHelper.ClimbTowerFloorMax = climbTowerFloorMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BE1 RID: 97249 RVA: 0x00688B74 File Offset: 0x00686D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AutoClimbFactor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerComponentCommon.m_luaExportHelper.AutoClimbFactor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BE2 RID: 97250 RVA: 0x00688BCC File Offset: 0x00686DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AutoClimbFactor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			int autoClimbFactor;
			LuaObject.checkType(l, 2, out autoClimbFactor);
			climbTowerComponentCommon.m_luaExportHelper.AutoClimbFactor = autoClimbFactor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BE3 RID: 97251 RVA: 0x00688C28 File Offset: 0x00686E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AutoClimbMax(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerComponentCommon.m_luaExportHelper.AutoClimbMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BE4 RID: 97252 RVA: 0x00688C80 File Offset: 0x00686E80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AutoClimbMax(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			int autoClimbMax;
			LuaObject.checkType(l, 2, out autoClimbMax);
			climbTowerComponentCommon.m_luaExportHelper.AutoClimbMax = autoClimbMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BE5 RID: 97253 RVA: 0x00688CDC File Offset: 0x00686EDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BE6 RID: 97254 RVA: 0x00688D30 File Offset: 0x00686F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponentCommon climbTowerComponentCommon = (ClimbTowerComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			climbTowerComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BE7 RID: 97255 RVA: 0x00688D88 File Offset: 0x00686F88
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ClimbTowerComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.IsNeedFlush);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.GetAutoRaidClimbTowerMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.IsReachTopTower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.GetClimbTower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.SetCompleteSuccessFloor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.GetGlobalClimbTowerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.AttackClimbTowerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.CanAttackClimbTowerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.GetFloor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.NewClimbTower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.CanRaidLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.SetCommonSuccessClimbTowerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.SetRaidSuccessClimbTowerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.CanAttackLevelByEnergyAndSoOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache13);
		string name = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache15, true);
		string name2 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache17, true);
		string name3 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.get_m_battle);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache19, true);
		string name4 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.get_m_bag);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1B, true);
		string name5 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.get_m_hero);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1D, true);
		string name6 = "m_climbTowerDS";
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.get_m_climbTowerDS);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.set_m_climbTowerDS);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache1F, true);
		string name7 = "ClimbTowerFloorMax";
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.get_ClimbTowerFloorMax);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.set_ClimbTowerFloorMax);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache21, true);
		string name8 = "AutoClimbFactor";
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.get_AutoClimbFactor);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.set_AutoClimbFactor);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache23, true);
		string name9 = "AutoClimbMax";
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.get_AutoClimbMax);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.set_AutoClimbMax);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache25, true);
		string name10 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.get_Owner);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache27, true);
		if (Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.<>f__mg$cache28, typeof(ClimbTowerComponentCommon));
	}

	// Token: 0x0400E1DA RID: 57818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E1DB RID: 57819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E1DC RID: 57820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E1DD RID: 57821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E1DE RID: 57822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E1DF RID: 57823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E1E0 RID: 57824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E1E1 RID: 57825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E1E2 RID: 57826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E1E3 RID: 57827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E1E4 RID: 57828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E1E5 RID: 57829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E1E6 RID: 57830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E1E7 RID: 57831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E1E8 RID: 57832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E1E9 RID: 57833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E1EA RID: 57834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E1EB RID: 57835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E1EC RID: 57836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E1ED RID: 57837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E1EE RID: 57838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E1EF RID: 57839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E1F0 RID: 57840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E1F1 RID: 57841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E1F2 RID: 57842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E1F3 RID: 57843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E1F4 RID: 57844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E1F5 RID: 57845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E1F6 RID: 57846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E1F7 RID: 57847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E1F8 RID: 57848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E1F9 RID: 57849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E1FA RID: 57850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E1FB RID: 57851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E1FC RID: 57852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E1FD RID: 57853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E1FE RID: 57854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E1FF RID: 57855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E200 RID: 57856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E201 RID: 57857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E202 RID: 57858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;
}
