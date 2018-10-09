using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012BC RID: 4796
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent : LuaObject
{
	// Token: 0x06019375 RID: 103285 RVA: 0x007373E0 File Offset: 0x007355E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent o = new ClimbTowerComponent();
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

	// Token: 0x06019376 RID: 103286 RVA: 0x00737428 File Offset: 0x00735628
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			climbTowerComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019377 RID: 103287 RVA: 0x00737474 File Offset: 0x00735674
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			climbTowerComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019378 RID: 103288 RVA: 0x007374C0 File Offset: 0x007356C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			ushort dsversion = climbTowerComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019379 RID: 103289 RVA: 0x00737514 File Offset: 0x00735714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			DSClimbTowerNtf msg;
			LuaObject.checkType<DSClimbTowerNtf>(l, 2, out msg);
			climbTowerComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601937A RID: 103290 RVA: 0x0073756C File Offset: 0x0073576C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetClimbTower(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			ClimbTowerGetAck climbTower;
			LuaObject.checkType<ClimbTowerGetAck>(l, 2, out climbTower);
			climbTowerComponent.SetClimbTower(climbTower);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601937B RID: 103291 RVA: 0x007375C4 File Offset: 0x007357C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishedClimbTowerLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			int floorId;
			LuaObject.checkType(l, 2, out floorId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			bool isWin;
			LuaObject.checkType(l, 4, out isWin);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 5, out battleTreasures);
			int i = climbTowerComponent.FinishedClimbTowerLevel(floorId, levelId, isWin, battleTreasures);
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

	// Token: 0x0601937C RID: 103292 RVA: 0x0073764C File Offset: 0x0073584C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSuccessClimbTowerLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out floorInfo);
			ConfigDataTowerLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTowerLevelInfo>(l, 3, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			bool isTeamBattle;
			LuaObject.checkType(l, 5, out isTeamBattle);
			climbTowerComponent.SetSuccessClimbTowerLevel(floorInfo, levelInfo, battleTreasures, isTeamBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601937D RID: 103293 RVA: 0x007376CC File Offset: 0x007358CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaidClimbTowerLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			int reachFloorId;
			LuaObject.checkType(l, 2, out reachFloorId);
			int i = climbTowerComponent.RaidClimbTowerLevel(reachFloorId);
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

	// Token: 0x0601937E RID: 103294 RVA: 0x00737730 File Offset: 0x00735930
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetFinishedFloorId(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			int finishedFloorId = climbTowerComponent.GetFinishedFloorId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, finishedFloorId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601937F RID: 103295 RVA: 0x00737784 File Offset: 0x00735984
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHistoryMaxFloorId(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			int historyMaxFloorId = climbTowerComponent.GetHistoryMaxFloorId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, historyMaxFloorId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019380 RID: 103296 RVA: 0x007377D8 File Offset: 0x007359D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetClimbTowerFloorMax(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			int climbTowerFloorMax = climbTowerComponent.GetClimbTowerFloorMax();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerFloorMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019381 RID: 103297 RVA: 0x0073782C File Offset: 0x00735A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryRaid(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			int i2;
			int i3;
			int i = climbTowerComponent.TryRaid(out i2, out i3);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			LuaObject.pushValue(l, i3);
			result = 4;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019382 RID: 103298 RVA: 0x00737898 File Offset: 0x00735A98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNextFlushTime(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			DateTime nextFlushTime = climbTowerComponent.GetNextFlushTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nextFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019383 RID: 103299 RVA: 0x007378F4 File Offset: 0x00735AF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			string s = climbTowerComponent.m_luaExportHelper.__callBase_GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019384 RID: 103300 RVA: 0x00737950 File Offset: 0x00735B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			climbTowerComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019385 RID: 103301 RVA: 0x007379A4 File Offset: 0x00735BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			climbTowerComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019386 RID: 103302 RVA: 0x007379F8 File Offset: 0x00735BF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			climbTowerComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019387 RID: 103303 RVA: 0x00737A4C File Offset: 0x00735C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			climbTowerComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019388 RID: 103304 RVA: 0x00737AA8 File Offset: 0x00735CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			climbTowerComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019389 RID: 103305 RVA: 0x00737AFC File Offset: 0x00735CFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedFlush(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			bool b = climbTowerComponent.m_luaExportHelper.__callBase_IsNeedFlush();
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

	// Token: 0x0601938A RID: 103306 RVA: 0x00737B58 File Offset: 0x00735D58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAutoRaidClimbTowerMax(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			int i = climbTowerComponent.m_luaExportHelper.__callBase_GetAutoRaidClimbTowerMax();
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

	// Token: 0x0601938B RID: 103307 RVA: 0x00737BB4 File Offset: 0x00735DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsReachTopTower(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			bool b = climbTowerComponent.m_luaExportHelper.__callBase_IsReachTopTower();
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

	// Token: 0x0601938C RID: 103308 RVA: 0x00737C10 File Offset: 0x00735E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetClimbTower(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			ClimbTower o = climbTowerComponent.m_luaExportHelper.__callBase_GetClimbTower();
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

	// Token: 0x0601938D RID: 103309 RVA: 0x00737C6C File Offset: 0x00735E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetCompleteSuccessFloor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			int floorId;
			LuaObject.checkType(l, 2, out floorId);
			climbTowerComponent.m_luaExportHelper.__callBase_SetCompleteSuccessFloor(floorId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601938E RID: 103310 RVA: 0x00737CC8 File Offset: 0x00735EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetGlobalClimbTowerInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			GlobalClimbTowerInfo o = climbTowerComponent.m_luaExportHelper.__callBase_GetGlobalClimbTowerInfo();
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

	// Token: 0x0601938F RID: 103311 RVA: 0x00737D24 File Offset: 0x00735F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AttackClimbTowerLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			int floorId;
			LuaObject.checkType(l, 2, out floorId);
			int i = climbTowerComponent.m_luaExportHelper.__callBase_AttackClimbTowerLevel(floorId);
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

	// Token: 0x06019390 RID: 103312 RVA: 0x00737D8C File Offset: 0x00735F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackClimbTowerLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			int floorId;
			LuaObject.checkType(l, 2, out floorId);
			int i = climbTowerComponent.m_luaExportHelper.__callBase_CanAttackClimbTowerLevel(floorId);
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

	// Token: 0x06019391 RID: 103313 RVA: 0x00737DF4 File Offset: 0x00735FF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetFloor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			int floorId;
			LuaObject.checkType(l, 2, out floorId);
			GlobalClimbTowerFloor o = climbTowerComponent.m_luaExportHelper.__callBase_GetFloor(floorId);
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

	// Token: 0x06019392 RID: 103314 RVA: 0x00737E5C File Offset: 0x0073605C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_NewClimbTower(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			int seed;
			LuaObject.checkType(l, 2, out seed);
			GlobalClimbTowerInfo o = climbTowerComponent.m_luaExportHelper.__callBase_NewClimbTower(seed);
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

	// Token: 0x06019393 RID: 103315 RVA: 0x00737EC4 File Offset: 0x007360C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetCommonSuccessClimbTowerLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out floorInfo);
			ConfigDataTowerLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTowerLevelInfo>(l, 3, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasures);
			int energyCost;
			LuaObject.checkType(l, 5, out energyCost);
			climbTowerComponent.m_luaExportHelper.__callBase_SetCommonSuccessClimbTowerLevel(floorInfo, levelInfo, battleTreasures, energyCost);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019394 RID: 103316 RVA: 0x00737F48 File Offset: 0x00736148
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanRaidLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out floorInfo);
			int i = climbTowerComponent.m_luaExportHelper.__callBase_CanRaidLevel(floorInfo);
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

	// Token: 0x06019395 RID: 103317 RVA: 0x00737FB0 File Offset: 0x007361B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetRaidSuccessClimbTowerLevel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out floorInfo);
			climbTowerComponent.m_luaExportHelper.__callBase_SetRaidSuccessClimbTowerLevel(floorInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019396 RID: 103318 RVA: 0x0073800C File Offset: 0x0073620C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanAttackLevelByEnergyAndSoOn(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerComponent climbTowerComponent = (ClimbTowerComponent)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out floorInfo);
			bool checkBagFull;
			LuaObject.checkType(l, 3, out checkBagFull);
			int i = climbTowerComponent.m_luaExportHelper.__callBase_CanAttackLevelByEnergyAndSoOn(floorInfo, checkBagFull);
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

	// Token: 0x06019397 RID: 103319 RVA: 0x00738080 File Offset: 0x00736280
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.ClimbTowerComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.SetClimbTower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.FinishedClimbTowerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.SetSuccessClimbTowerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.RaidClimbTowerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.GetFinishedFloorId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.GetHistoryMaxFloorId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.GetClimbTowerFloorMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.TryRaid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.GetNextFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_IsNeedFlush);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_GetAutoRaidClimbTowerMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_IsReachTopTower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_GetClimbTower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_SetCompleteSuccessFloor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_GetGlobalClimbTowerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_AttackClimbTowerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_CanAttackClimbTowerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_GetFloor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_NewClimbTower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_SetCommonSuccessClimbTowerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_CanRaidLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_SetRaidSuccessClimbTowerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.__callBase_CanAttackLevelByEnergyAndSoOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.<>f__mg$cache21, typeof(ClimbTowerComponent), typeof(ClimbTowerComponentCommon));
	}

	// Token: 0x0400F7DF RID: 63455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F7E0 RID: 63456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F7E1 RID: 63457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F7E2 RID: 63458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F7E3 RID: 63459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F7E4 RID: 63460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F7E5 RID: 63461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F7E6 RID: 63462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F7E7 RID: 63463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F7E8 RID: 63464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F7E9 RID: 63465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F7EA RID: 63466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F7EB RID: 63467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F7EC RID: 63468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F7ED RID: 63469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F7EE RID: 63470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F7EF RID: 63471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F7F0 RID: 63472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F7F1 RID: 63473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F7F2 RID: 63474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F7F3 RID: 63475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F7F4 RID: 63476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F7F5 RID: 63477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F7F6 RID: 63478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F7F7 RID: 63479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F7F8 RID: 63480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F7F9 RID: 63481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F7FA RID: 63482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F7FB RID: 63483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F7FC RID: 63484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F7FD RID: 63485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F7FE RID: 63486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F7FF RID: 63487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F800 RID: 63488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;
}
