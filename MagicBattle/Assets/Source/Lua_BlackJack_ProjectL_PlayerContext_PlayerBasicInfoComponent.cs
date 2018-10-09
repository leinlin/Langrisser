using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012D6 RID: 4822
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent : LuaObject
{
	// Token: 0x0601974E RID: 104270 RVA: 0x00755D9C File Offset: 0x00753F9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent o = new PlayerBasicInfoComponent();
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

	// Token: 0x0601974F RID: 104271 RVA: 0x00755DE4 File Offset: 0x00753FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019750 RID: 104272 RVA: 0x00755E30 File Offset: 0x00754030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019751 RID: 104273 RVA: 0x00755E7C File Offset: 0x0075407C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019752 RID: 104274 RVA: 0x00755EC8 File Offset: 0x007540C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCurrentTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			DateTime currentTime = playerBasicInfoComponent.GetCurrentTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019753 RID: 104275 RVA: 0x00755F24 File Offset: 0x00754124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(PlayerInfoInitAck)))
			{
				PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
				PlayerInfoInitAck msg;
				LuaObject.checkType<PlayerInfoInitAck>(l, 2, out msg);
				playerBasicInfoComponent.DeSerialize(msg);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(DSPlayerBasicNtf)))
			{
				PlayerBasicInfoComponent playerBasicInfoComponent2 = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
				DSPlayerBasicNtf msg2;
				LuaObject.checkType<DSPlayerBasicNtf>(l, 2, out msg2);
				playerBasicInfoComponent2.DeSerialize(msg2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DeSerialize to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019754 RID: 104276 RVA: 0x00755FFC File Offset: 0x007541FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EveryDaySign(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int signDays;
			LuaObject.checkType(l, 2, out signDays);
			long lastSignTime;
			LuaObject.checkType(l, 3, out lastSignTime);
			playerBasicInfoComponent.EveryDaySign(signDays, lastSignTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019755 RID: 104277 RVA: 0x00756060 File Offset: 0x00754260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckPlayerName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int i = playerBasicInfoComponent.CheckPlayerName(name);
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

	// Token: 0x06019756 RID: 104278 RVA: 0x007560C4 File Offset: 0x007542C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			ushort dsversion = playerBasicInfoComponent.GetDSVersion();
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

	// Token: 0x06019757 RID: 104279 RVA: 0x00756118 File Offset: 0x00754318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerBasicInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			DataSectionPlayerBasicInfo playerBasicInfo = playerBasicInfoComponent.GetPlayerBasicInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019758 RID: 104280 RVA: 0x0075616C File Offset: 0x0075436C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEnergyReachMaxTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			DateTime energyReachMaxTime = playerBasicInfoComponent.GetEnergyReachMaxTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyReachMaxTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019759 RID: 104281 RVA: 0x007561C8 File Offset: 0x007543C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DecreaseEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int energyCost;
			LuaObject.checkType(l, 2, out energyCost);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponent.DecreaseEnergy(energyCost, causeId, location);
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

	// Token: 0x0601975A RID: 104282 RVA: 0x00756244 File Offset: 0x00754444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IncreamentEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			long energyAddNums;
			LuaObject.checkType(l, 2, out energyAddNums);
			bool canAboveMaxEnergy;
			LuaObject.checkType(l, 3, out canAboveMaxEnergy);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 4, out causeId);
			string location;
			LuaObject.checkType(l, 5, out location);
			int i = playerBasicInfoComponent.IncreamentEnergy(energyAddNums, canAboveMaxEnergy, causeId, location);
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

	// Token: 0x0601975B RID: 104283 RVA: 0x007562CC File Offset: 0x007544CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			bool arenaGiven;
			LuaObject.checkType(l, 3, out arenaGiven);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 4, out causeId);
			string location;
			LuaObject.checkType(l, 5, out location);
			int i = playerBasicInfoComponent.AddArenaTickets(nums, arenaGiven, causeId, location);
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

	// Token: 0x0601975C RID: 104284 RVA: 0x00756354 File Offset: 0x00754554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLevelChange(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int upLevel;
			LuaObject.checkType(l, 2, out upLevel);
			int addExp;
			LuaObject.checkType(l, 3, out addExp);
			playerBasicInfoComponent.m_luaExportHelper.OnLevelChange(upLevel, addExp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601975D RID: 104285 RVA: 0x007563C0 File Offset: 0x007545C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			string s = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x0601975E RID: 104286 RVA: 0x0075641C File Offset: 0x0075461C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601975F RID: 104287 RVA: 0x00756470 File Offset: 0x00754670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019760 RID: 104288 RVA: 0x007564C4 File Offset: 0x007546C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019761 RID: 104289 RVA: 0x00756518 File Offset: 0x00754718
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019762 RID: 104290 RVA: 0x00756574 File Offset: 0x00754774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019763 RID: 104291 RVA: 0x007565C8 File Offset: 0x007547C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TryUpdateSignedDays(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_TryUpdateSignedDays();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019764 RID: 104292 RVA: 0x0075661C File Offset: 0x0075481C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsGameFunctionOpened(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsGameFunctionOpened(gameFunctionType);
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

	// Token: 0x06019765 RID: 104293 RVA: 0x00756684 File Offset: 0x00754884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetCreateTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			DateTime dateTime = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetCreateTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019766 RID: 104294 RVA: 0x007566E4 File Offset: 0x007548E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetCreateTimeUtc(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			DateTime dateTime = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetCreateTimeUtc();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019767 RID: 104295 RVA: 0x00756744 File Offset: 0x00754944
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetLastLogoutTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			DateTime dateTime = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetLastLogoutTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019768 RID: 104296 RVA: 0x007567A4 File Offset: 0x007549A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetLoginTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			DateTime dateTime = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetLoginTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019769 RID: 104297 RVA: 0x00756804 File Offset: 0x00754A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetPlayerName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			string s = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetPlayerName();
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

	// Token: 0x0601976A RID: 104298 RVA: 0x00756860 File Offset: 0x00754A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetUserId(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			string s = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetUserId();
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

	// Token: 0x0601976B RID: 104299 RVA: 0x007568BC File Offset: 0x00754ABC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsMe(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsMe(userId);
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

	// Token: 0x0601976C RID: 104300 RVA: 0x00756924 File Offset: 0x00754B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetCurrentLevelExp(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetCurrentLevelExp();
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

	// Token: 0x0601976D RID: 104301 RVA: 0x00756980 File Offset: 0x00754B80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetRechargedCsystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetRechargedCsystal();
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

	// Token: 0x0601976E RID: 104302 RVA: 0x007569DC File Offset: 0x00754BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetRechargeRMB(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			long i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetRechargeRMB();
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

	// Token: 0x0601976F RID: 104303 RVA: 0x00756A38 File Offset: 0x00754C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetHeadIcon();
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

	// Token: 0x06019770 RID: 104304 RVA: 0x00756A94 File Offset: 0x00754C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetDefaultHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetDefaultHeadIcon();
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

	// Token: 0x06019771 RID: 104305 RVA: 0x00756AF0 File Offset: 0x00754CF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetHeadPortrait(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetHeadPortrait();
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

	// Token: 0x06019772 RID: 104306 RVA: 0x00756B4C File Offset: 0x00754D4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetHeadFrame();
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

	// Token: 0x06019773 RID: 104307 RVA: 0x00756BA8 File Offset: 0x00754DA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsPlayerLevelMax(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsPlayerLevelMax();
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

	// Token: 0x06019774 RID: 104308 RVA: 0x00756C04 File Offset: 0x00754E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddPlayerExp(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int exp;
			LuaObject.checkType(l, 2, out exp);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddPlayerExp(exp);
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

	// Token: 0x06019775 RID: 104309 RVA: 0x00756C6C File Offset: 0x00754E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnLevelChange(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int upLevel;
			LuaObject.checkType(l, 2, out upLevel);
			int addExp;
			LuaObject.checkType(l, 3, out addExp);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_OnLevelChange(upLevel, addExp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019776 RID: 104310 RVA: 0x00756CD8 File Offset: 0x00754ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddGold(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddGold(nums, causeId, location);
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

	// Token: 0x06019777 RID: 104311 RVA: 0x00756D5C File Offset: 0x00754F5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsGoldEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int useGoldCount;
			LuaObject.checkType(l, 2, out useGoldCount);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsGoldEnough(useGoldCount);
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

	// Token: 0x06019778 RID: 104312 RVA: 0x00756DC4 File Offset: 0x00754FC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsGoldOverFlow(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int addNums;
			LuaObject.checkType(l, 2, out addNums);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsGoldOverFlow(addNums);
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

	// Token: 0x06019779 RID: 104313 RVA: 0x00756E2C File Offset: 0x0075502C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetGold(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetGold();
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

	// Token: 0x0601977A RID: 104314 RVA: 0x00756E88 File Offset: 0x00755088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddBrillianceMithralStone(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
				int nums;
				LuaObject.checkType(l, 2, out nums);
				int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddBrillianceMithralStone(nums);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 4)
			{
				PlayerBasicInfoComponent playerBasicInfoComponent2 = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
				int nums2;
				LuaObject.checkType(l, 2, out nums2);
				GameFunctionType causeId;
				LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
				string location;
				LuaObject.checkType(l, 4, out location);
				int i2 = playerBasicInfoComponent2.m_luaExportHelper.__callBase_AddBrillianceMithralStone(nums2, causeId, location);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_AddBrillianceMithralStone to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601977B RID: 104315 RVA: 0x00756F78 File Offset: 0x00755178
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddMithralStone(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
				int nums;
				LuaObject.checkType(l, 2, out nums);
				int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddMithralStone(nums);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 4)
			{
				PlayerBasicInfoComponent playerBasicInfoComponent2 = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
				int nums2;
				LuaObject.checkType(l, 2, out nums2);
				GameFunctionType causeId;
				LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
				string location;
				LuaObject.checkType(l, 4, out location);
				int i2 = playerBasicInfoComponent2.m_luaExportHelper.__callBase_AddMithralStone(nums2, causeId, location);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_AddMithralStone to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601977C RID: 104316 RVA: 0x00757068 File Offset: 0x00755268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsMithralStoneEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsMithralStoneEnough(nums);
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

	// Token: 0x0601977D RID: 104317 RVA: 0x007570D0 File Offset: 0x007552D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsBrillianceMithralStoneEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsBrillianceMithralStoneEnough(nums);
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

	// Token: 0x0601977E RID: 104318 RVA: 0x00757138 File Offset: 0x00755338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsCurrencyEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			GoodsType currencyType;
			LuaObject.checkEnum<GoodsType>(l, 2, out currencyType);
			int consumeNums;
			LuaObject.checkType(l, 3, out consumeNums);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsCurrencyEnough(currencyType, consumeNums);
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

	// Token: 0x0601977F RID: 104319 RVA: 0x007571AC File Offset: 0x007553AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddCurrency(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			GoodsType currencyType;
			LuaObject.checkEnum<GoodsType>(l, 2, out currencyType);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 4, out causeId);
			string location;
			LuaObject.checkType(l, 5, out location);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddCurrency(currencyType, nums, causeId, location);
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

	// Token: 0x06019780 RID: 104320 RVA: 0x0075723C File Offset: 0x0075543C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddRechargeRMB(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			DateTime rechargeTime;
			LuaObject.checkValueType<DateTime>(l, 3, out rechargeTime);
			bool needSync2Client;
			LuaObject.checkType(l, 4, out needSync2Client);
			long i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddRechargeRMB(nums, rechargeTime, needSync2Client);
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

	// Token: 0x06019781 RID: 104321 RVA: 0x007572C0 File Offset: 0x007554C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddCrystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddCrystal(nums, causeId, location);
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

	// Token: 0x06019782 RID: 104322 RVA: 0x00757344 File Offset: 0x00755544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsCrystalEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsCrystalEnough(consumeNums);
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

	// Token: 0x06019783 RID: 104323 RVA: 0x007573AC File Offset: 0x007555AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			long secondPast;
			LuaObject.checkType(l, 2, out secondPast);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_InitEnergy(secondPast);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019784 RID: 104324 RVA: 0x00757408 File Offset: 0x00755608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsReachEnergyMax(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			long currentEnergy;
			LuaObject.checkType(l, 2, out currentEnergy);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsReachEnergyMax(currentEnergy);
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

	// Token: 0x06019785 RID: 104325 RVA: 0x00757470 File Offset: 0x00755670
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_FlushEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_FlushEnergy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019786 RID: 104326 RVA: 0x007574C4 File Offset: 0x007556C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanFlushEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_CanFlushEnergy();
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

	// Token: 0x06019787 RID: 104327 RVA: 0x00757520 File Offset: 0x00755720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanFlushPlayerAction(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_CanFlushPlayerAction();
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

	// Token: 0x06019788 RID: 104328 RVA: 0x0075757C File Offset: 0x0075577C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ResetPlayerActionNextFlushTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_ResetPlayerActionNextFlushTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019789 RID: 104329 RVA: 0x007575D0 File Offset: 0x007557D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IncreamentEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			long energyAddNums;
			LuaObject.checkType(l, 2, out energyAddNums);
			bool canAboveMaxEnergy;
			LuaObject.checkType(l, 3, out canAboveMaxEnergy);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 4, out causeId);
			string location;
			LuaObject.checkType(l, 5, out location);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_IncreamentEnergy(energyAddNums, canAboveMaxEnergy, causeId, location);
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

	// Token: 0x0601978A RID: 104330 RVA: 0x00757660 File Offset: 0x00755860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DecreaseEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int energyCost;
			LuaObject.checkType(l, 2, out energyCost);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_DecreaseEnergy(energyCost, causeId, location);
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

	// Token: 0x0601978B RID: 104331 RVA: 0x007576E4 File Offset: 0x007558E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsEnergyEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int consumeEnergy;
			LuaObject.checkType(l, 2, out consumeEnergy);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsEnergyEnough(consumeEnergy);
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

	// Token: 0x0601978C RID: 104332 RVA: 0x0075774C File Offset: 0x0075594C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetEnergy();
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

	// Token: 0x0601978D RID: 104333 RVA: 0x007577A8 File Offset: 0x007559A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetCurrentTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			DateTime dateTime = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetCurrentTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601978E RID: 104334 RVA: 0x00757808 File Offset: 0x00755A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsSigned(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsSigned();
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

	// Token: 0x0601978F RID: 104335 RVA: 0x00757864 File Offset: 0x00755A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanSignToday(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_CanSignToday();
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

	// Token: 0x06019790 RID: 104336 RVA: 0x007578C0 File Offset: 0x00755AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanBuyEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_CanBuyEnergy();
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

	// Token: 0x06019791 RID: 104337 RVA: 0x0075791C File Offset: 0x00755B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BuyEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_BuyEnergy();
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

	// Token: 0x06019792 RID: 104338 RVA: 0x00757978 File Offset: 0x00755B78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanBuyArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_CanBuyArenaTickets();
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

	// Token: 0x06019793 RID: 104339 RVA: 0x007579D4 File Offset: 0x00755BD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BuyArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_BuyArenaTickets();
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

	// Token: 0x06019794 RID: 104340 RVA: 0x00757A30 File Offset: 0x00755C30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetNextFlushPlayerActionTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			DateTime dateTime = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetNextFlushPlayerActionTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019795 RID: 104341 RVA: 0x00757A90 File Offset: 0x00755C90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_FlushPlayerAction(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_FlushPlayerAction();
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

	// Token: 0x06019796 RID: 104342 RVA: 0x00757AEC File Offset: 0x00755CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPlayerActionFlushEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_OnPlayerActionFlushEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019797 RID: 104343 RVA: 0x00757B40 File Offset: 0x00755D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsArenaTicketsEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsArenaTicketsEnough(consumeNums);
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

	// Token: 0x06019798 RID: 104344 RVA: 0x00757BA8 File Offset: 0x00755DA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsArenaTicketsFull(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsArenaTicketsFull();
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

	// Token: 0x06019799 RID: 104345 RVA: 0x00757C04 File Offset: 0x00755E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			bool arenaGiven;
			LuaObject.checkType(l, 3, out arenaGiven);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 4, out causeId);
			string location;
			LuaObject.checkType(l, 5, out location);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddArenaTickets(nums, arenaGiven, causeId, location);
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

	// Token: 0x0601979A RID: 104346 RVA: 0x00757C94 File Offset: 0x00755E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAreanaTicketNums(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetAreanaTicketNums();
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

	// Token: 0x0601979B RID: 104347 RVA: 0x00757CF0 File Offset: 0x00755EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddRechargedCrystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddRechargedCrystal(nums);
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

	// Token: 0x0601979C RID: 104348 RVA: 0x00757D58 File Offset: 0x00755F58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddArenaHonour(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddArenaHonour(nums, causeId, location);
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

	// Token: 0x0601979D RID: 104349 RVA: 0x00757DDC File Offset: 0x00755FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetArenaHonour(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetArenaHonour();
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

	// Token: 0x0601979E RID: 104350 RVA: 0x00757E38 File Offset: 0x00756038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddRealTimePVPHonor(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddRealTimePVPHonor(nums, causeId, location);
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

	// Token: 0x0601979F RID: 104351 RVA: 0x00757EBC File Offset: 0x007560BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetRealTimePVPHonor(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetRealTimePVPHonor();
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

	// Token: 0x060197A0 RID: 104352 RVA: 0x00757F18 File Offset: 0x00756118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetFriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetFriendshipPoints();
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

	// Token: 0x060197A1 RID: 104353 RVA: 0x00757F74 File Offset: 0x00756174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetSkinTickets(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetSkinTickets();
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

	// Token: 0x060197A2 RID: 104354 RVA: 0x00757FD0 File Offset: 0x007561D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddFriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddFriendshipPoints(nums, causeId, location);
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

	// Token: 0x060197A3 RID: 104355 RVA: 0x00758054 File Offset: 0x00756254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddSkinTickets(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddSkinTickets(nums, causeId, location);
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

	// Token: 0x060197A4 RID: 104356 RVA: 0x007580D8 File Offset: 0x007562D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddMemoryEssence(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddMemoryEssence(nums, causeId, location);
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

	// Token: 0x060197A5 RID: 104357 RVA: 0x0075815C File Offset: 0x0075635C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddGuildMedal(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_AddGuildMedal(nums, causeId, location);
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

	// Token: 0x060197A6 RID: 104358 RVA: 0x007581E0 File Offset: 0x007563E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsGuildMedalEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsGuildMedalEnough(consumeNums);
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

	// Token: 0x060197A7 RID: 104359 RVA: 0x00758248 File Offset: 0x00756448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsFriendshipPointsEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsFriendshipPointsEnough(consumeNums);
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

	// Token: 0x060197A8 RID: 104360 RVA: 0x007582B0 File Offset: 0x007564B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsArenaHonourEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsArenaHonourEnough(consumeNums);
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

	// Token: 0x060197A9 RID: 104361 RVA: 0x00758318 File Offset: 0x00756518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsRealTimePVPHonorEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsRealTimePVPHonorEnough(consumeNums);
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

	// Token: 0x060197AA RID: 104362 RVA: 0x00758380 File Offset: 0x00756580
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsSkinTicketEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsSkinTicketEnough(consumeNums);
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

	// Token: 0x060197AB RID: 104363 RVA: 0x007583E8 File Offset: 0x007565E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsMemoryEssenceEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsMemoryEssenceEnough(consumeNums);
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

	// Token: 0x060197AC RID: 104364 RVA: 0x00758450 File Offset: 0x00756650
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanSetUserGuide(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			List<int> completeStepIds;
			LuaObject.checkType<List<int>>(l, 2, out completeStepIds);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_CanSetUserGuide(completeStepIds);
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

	// Token: 0x060197AD RID: 104365 RVA: 0x007584B8 File Offset: 0x007566B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetUserGuide(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			List<int> completeStepIds;
			LuaObject.checkType<List<int>>(l, 2, out completeStepIds);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_SetUserGuide(completeStepIds);
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

	// Token: 0x060197AE RID: 104366 RVA: 0x00758520 File Offset: 0x00756720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CleanUserGuide(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			List<int> completeStepIds;
			LuaObject.checkType<List<int>>(l, 2, out completeStepIds);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_CleanUserGuide(completeStepIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060197AF RID: 104367 RVA: 0x0075857C File Offset: 0x0075677C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CompleteAllUserGuides(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_CompleteAllUserGuides();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060197B0 RID: 104368 RVA: 0x007585D0 File Offset: 0x007567D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsUserGuideCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int stepId;
			LuaObject.checkType(l, 2, out stepId);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsUserGuideCompleted(stepId);
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

	// Token: 0x060197B1 RID: 104369 RVA: 0x00758638 File Offset: 0x00756838
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetLevel();
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

	// Token: 0x060197B2 RID: 104370 RVA: 0x00758694 File Offset: 0x00756894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetRechargedCrystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetRechargedCrystal();
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

	// Token: 0x060197B3 RID: 104371 RVA: 0x007586F0 File Offset: 0x007568F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetCrystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetCrystal();
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

	// Token: 0x060197B4 RID: 104372 RVA: 0x0075874C File Offset: 0x0075694C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CheckRankingListAddPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_CheckRankingListAddPlayerLevel();
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

	// Token: 0x060197B5 RID: 104373 RVA: 0x007587A8 File Offset: 0x007569A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CreateRankingPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int championHeroId;
			LuaObject.checkType(l, 2, out championHeroId);
			RankingPlayerInfo o = playerBasicInfoComponent.m_luaExportHelper.__callBase_CreateRankingPlayerInfo(championHeroId);
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

	// Token: 0x060197B6 RID: 104374 RVA: 0x00758810 File Offset: 0x00756A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnRankingListPlayerInfoChange(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_OnRankingListPlayerInfoChange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060197B7 RID: 104375 RVA: 0x00758864 File Offset: 0x00756A64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OpenGameRating(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_OpenGameRating();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060197B8 RID: 104376 RVA: 0x007588B8 File Offset: 0x00756AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpenGameRating(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsOpenGameRating();
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

	// Token: 0x060197B9 RID: 104377 RVA: 0x00758914 File Offset: 0x00756B14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetMemoryStoreOpenStatus(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			bool open;
			LuaObject.checkType(l, 2, out open);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_SetMemoryStoreOpenStatus(open);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060197BA RID: 104378 RVA: 0x00758970 File Offset: 0x00756B70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsMemoryStoreOpen(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponent.m_luaExportHelper.__callBase_IsMemoryStoreOpen();
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

	// Token: 0x060197BB RID: 104379 RVA: 0x007589CC File Offset: 0x00756BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetLevelUpAddEnergyFromConfig(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetLevelUpAddEnergyFromConfig();
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

	// Token: 0x060197BC RID: 104380 RVA: 0x00758A28 File Offset: 0x00756C28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetNextLevelExpFromConfig(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_GetNextLevelExpFromConfig();
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

	// Token: 0x060197BD RID: 104381 RVA: 0x00758A84 File Offset: 0x00756C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanSetHeadPortraitAndHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int headPortraitId;
			LuaObject.checkType(l, 2, out headPortraitId);
			int headFrameId;
			LuaObject.checkType(l, 3, out headFrameId);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_CanSetHeadPortraitAndHeadFrame(headPortraitId, headFrameId);
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

	// Token: 0x060197BE RID: 104382 RVA: 0x00758AF8 File Offset: 0x00756CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetHeadPortraitAndHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int headPortraitId;
			LuaObject.checkType(l, 2, out headPortraitId);
			int headFrameId;
			LuaObject.checkType(l, 3, out headFrameId);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_SetHeadPortraitAndHeadFrame(headPortraitId, headFrameId);
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

	// Token: 0x060197BF RID: 104383 RVA: 0x00758B6C File Offset: 0x00756D6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanSetHeadPortrait(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int headPortraitId;
			LuaObject.checkType(l, 2, out headPortraitId);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_CanSetHeadPortrait(headPortraitId);
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

	// Token: 0x060197C0 RID: 104384 RVA: 0x00758BD4 File Offset: 0x00756DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetHeadPortrait(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int headPortraitId;
			LuaObject.checkType(l, 2, out headPortraitId);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_SetHeadPortrait(headPortraitId);
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

	// Token: 0x060197C1 RID: 104385 RVA: 0x00758C3C File Offset: 0x00756E3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanSetHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_CanSetHeadFrame(headFrameId);
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

	// Token: 0x060197C2 RID: 104386 RVA: 0x00758CA4 File Offset: 0x00756EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_SetHeadFrame(headFrameId);
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

	// Token: 0x060197C3 RID: 104387 RVA: 0x00758D0C File Offset: 0x00756F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnHeadIconChange(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_OnHeadIconChange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060197C4 RID: 104388 RVA: 0x00758D60 File Offset: 0x00756F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanChangePlayerName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			string newName;
			LuaObject.checkType(l, 2, out newName);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_CanChangePlayerName(newName);
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

	// Token: 0x060197C5 RID: 104389 RVA: 0x00758DC8 File Offset: 0x00756FC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ChangePlayerName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			string newName;
			LuaObject.checkType(l, 2, out newName);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_ChangePlayerName(newName);
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

	// Token: 0x060197C6 RID: 104390 RVA: 0x00758E30 File Offset: 0x00757030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TryChangePlayerName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			string newName;
			LuaObject.checkType(l, 2, out newName);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_TryChangePlayerName(newName);
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

	// Token: 0x060197C7 RID: 104391 RVA: 0x00758E98 File Offset: 0x00757098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckPlayerName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int i = playerBasicInfoComponent.m_luaExportHelper.__callBase_CheckPlayerName(name);
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

	// Token: 0x060197C8 RID: 104392 RVA: 0x00758F00 File Offset: 0x00757100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DoShare(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			playerBasicInfoComponent.m_luaExportHelper.__callBase_DoShare();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060197C9 RID: 104393 RVA: 0x00758F54 File Offset: 0x00757154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponent.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060197CA RID: 104394 RVA: 0x00758FAC File Offset: 0x007571AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			playerBasicInfoComponent.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060197CB RID: 104395 RVA: 0x00759008 File Offset: 0x00757208
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_vipLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponent.m_vipLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060197CC RID: 104396 RVA: 0x0075905C File Offset: 0x0075725C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_vipLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponent playerBasicInfoComponent = (PlayerBasicInfoComponent)LuaObject.checkSelf(l);
			int vipLevel;
			LuaObject.checkType(l, 2, out vipLevel);
			playerBasicInfoComponent.m_vipLevel = vipLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060197CD RID: 104397 RVA: 0x007590B4 File Offset: 0x007572B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.PlayerBasicInfoComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.GetCurrentTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.EveryDaySign);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.CheckPlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.GetPlayerBasicInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.GetEnergyReachMaxTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.DecreaseEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.IncreamentEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.AddArenaTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.OnLevelChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_TryUpdateSignedDays);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsGameFunctionOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetCreateTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetCreateTimeUtc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetLastLogoutTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetLoginTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetPlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetUserId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetCurrentLevelExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetRechargedCsystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetRechargeRMB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetHeadIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetDefaultHeadIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetHeadPortrait);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsPlayerLevelMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddPlayerExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_OnLevelChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsGoldEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsGoldOverFlow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddBrillianceMithralStone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddMithralStone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsMithralStoneEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsBrillianceMithralStoneEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsCurrencyEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddCurrency);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddRechargeRMB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsCrystalEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_InitEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsReachEnergyMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_FlushEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CanFlushEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CanFlushPlayerAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_ResetPlayerActionNextFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IncreamentEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_DecreaseEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsEnergyEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetCurrentTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsSigned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CanSignToday);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CanBuyEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_BuyEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CanBuyArenaTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_BuyArenaTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetNextFlushPlayerActionTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_FlushPlayerAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_OnPlayerActionFlushEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsArenaTicketsEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsArenaTicketsFull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddArenaTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetAreanaTicketNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddRechargedCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddArenaHonour);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetArenaHonour);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddRealTimePVPHonor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetRealTimePVPHonor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetFriendshipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetSkinTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddFriendshipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddSkinTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddMemoryEssence);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_AddGuildMedal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsGuildMedalEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsFriendshipPointsEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsArenaHonourEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsRealTimePVPHonorEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsSkinTicketEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsMemoryEssenceEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CanSetUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_SetUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CleanUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CompleteAllUserGuides);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsUserGuideCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetRechargedCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CheckRankingListAddPlayerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CreateRankingPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_OnRankingListPlayerInfoChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_OpenGameRating);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsOpenGameRating);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_SetMemoryStoreOpenStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_IsMemoryStoreOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetLevelUpAddEnergyFromConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_GetNextLevelExpFromConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CanSetHeadPortraitAndHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_SetHeadPortraitAndHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CanSetHeadPortrait);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_SetHeadPortrait);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CanSetHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_SetHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_OnHeadIconChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CanChangePlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_ChangePlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_TryChangePlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_CheckPlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.__callBase_DoShare);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache79);
		string name = "m_playerContext";
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.get_m_playerContext);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.set_m_playerContext);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7B, true);
		string name2 = "m_vipLevel";
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.get_m_vipLevel);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.set_m_vipLevel);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7D, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.<>f__mg$cache7E, typeof(PlayerBasicInfoComponent), typeof(PlayerBasicInfoComponentCommon));
	}

	// Token: 0x0400FB84 RID: 64388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400FB85 RID: 64389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400FB86 RID: 64390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400FB87 RID: 64391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400FB88 RID: 64392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400FB89 RID: 64393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400FB8A RID: 64394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400FB8B RID: 64395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400FB8C RID: 64396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400FB8D RID: 64397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400FB8E RID: 64398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400FB8F RID: 64399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400FB90 RID: 64400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400FB91 RID: 64401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400FB92 RID: 64402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400FB93 RID: 64403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400FB94 RID: 64404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400FB95 RID: 64405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400FB96 RID: 64406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400FB97 RID: 64407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400FB98 RID: 64408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400FB99 RID: 64409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400FB9A RID: 64410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400FB9B RID: 64411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400FB9C RID: 64412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400FB9D RID: 64413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400FB9E RID: 64414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400FB9F RID: 64415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400FBA0 RID: 64416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400FBA1 RID: 64417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400FBA2 RID: 64418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400FBA3 RID: 64419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400FBA4 RID: 64420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400FBA5 RID: 64421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400FBA6 RID: 64422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400FBA7 RID: 64423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400FBA8 RID: 64424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400FBA9 RID: 64425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400FBAA RID: 64426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400FBAB RID: 64427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400FBAC RID: 64428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400FBAD RID: 64429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400FBAE RID: 64430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400FBAF RID: 64431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400FBB0 RID: 64432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400FBB1 RID: 64433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400FBB2 RID: 64434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400FBB3 RID: 64435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400FBB4 RID: 64436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400FBB5 RID: 64437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400FBB6 RID: 64438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400FBB7 RID: 64439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400FBB8 RID: 64440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400FBB9 RID: 64441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400FBBA RID: 64442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400FBBB RID: 64443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400FBBC RID: 64444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400FBBD RID: 64445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400FBBE RID: 64446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400FBBF RID: 64447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400FBC0 RID: 64448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400FBC1 RID: 64449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400FBC2 RID: 64450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400FBC3 RID: 64451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400FBC4 RID: 64452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400FBC5 RID: 64453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400FBC6 RID: 64454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400FBC7 RID: 64455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400FBC8 RID: 64456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400FBC9 RID: 64457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400FBCA RID: 64458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400FBCB RID: 64459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400FBCC RID: 64460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400FBCD RID: 64461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400FBCE RID: 64462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400FBCF RID: 64463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400FBD0 RID: 64464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400FBD1 RID: 64465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400FBD2 RID: 64466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400FBD3 RID: 64467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400FBD4 RID: 64468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400FBD5 RID: 64469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400FBD6 RID: 64470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400FBD7 RID: 64471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400FBD8 RID: 64472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400FBD9 RID: 64473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400FBDA RID: 64474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400FBDB RID: 64475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400FBDC RID: 64476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400FBDD RID: 64477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400FBDE RID: 64478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400FBDF RID: 64479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400FBE0 RID: 64480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400FBE1 RID: 64481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400FBE2 RID: 64482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400FBE3 RID: 64483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400FBE4 RID: 64484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400FBE5 RID: 64485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400FBE6 RID: 64486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400FBE7 RID: 64487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400FBE8 RID: 64488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400FBE9 RID: 64489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400FBEA RID: 64490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400FBEB RID: 64491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400FBEC RID: 64492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400FBED RID: 64493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400FBEE RID: 64494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400FBEF RID: 64495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400FBF0 RID: 64496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400FBF1 RID: 64497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400FBF2 RID: 64498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400FBF3 RID: 64499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400FBF4 RID: 64500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400FBF5 RID: 64501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0400FBF6 RID: 64502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0400FBF7 RID: 64503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0400FBF8 RID: 64504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0400FBF9 RID: 64505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0400FBFA RID: 64506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0400FBFB RID: 64507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0400FBFC RID: 64508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0400FBFD RID: 64509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0400FBFE RID: 64510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0400FBFF RID: 64511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0400FC00 RID: 64512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0400FC01 RID: 64513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0400FC02 RID: 64514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;
}
