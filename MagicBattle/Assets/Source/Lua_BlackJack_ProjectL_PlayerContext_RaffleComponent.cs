using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012DA RID: 4826
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent : LuaObject
{
	// Token: 0x06019F4D RID: 106317 RVA: 0x0079A4C0 File Offset: 0x007986C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent o = new RaffleComponent();
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

	// Token: 0x06019F4E RID: 106318 RVA: 0x0079A508 File Offset: 0x00798708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			raffleComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F4F RID: 106319 RVA: 0x0079A554 File Offset: 0x00798754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			DSRaffleNtf msg;
			LuaObject.checkType<DSRaffleNtf>(l, 2, out msg);
			raffleComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F50 RID: 106320 RVA: 0x0079A5AC File Offset: 0x007987AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOpenRafflePools(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			List<RafflePool> openRafflePools = raffleComponent.GetOpenRafflePools();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, openRafflePools);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F51 RID: 106321 RVA: 0x0079A600 File Offset: 0x00798800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Drawed(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			int raffleId;
			LuaObject.checkType(l, 3, out raffleId);
			raffleComponent.Drawed(poolId, raffleId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F52 RID: 106322 RVA: 0x0079A664 File Offset: 0x00798864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			ushort dsversion = raffleComponent.GetDSVersion();
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

	// Token: 0x06019F53 RID: 106323 RVA: 0x0079A6B8 File Offset: 0x007988B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			string s = raffleComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x06019F54 RID: 106324 RVA: 0x0079A714 File Offset: 0x00798914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			raffleComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F55 RID: 106325 RVA: 0x0079A768 File Offset: 0x00798968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			raffleComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F56 RID: 106326 RVA: 0x0079A7BC File Offset: 0x007989BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			raffleComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F57 RID: 106327 RVA: 0x0079A810 File Offset: 0x00798A10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			raffleComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F58 RID: 106328 RVA: 0x0079A86C File Offset: 0x00798A6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			raffleComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F59 RID: 106329 RVA: 0x0079A8C0 File Offset: 0x00798AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RemoveRafflePool(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			raffleComponent.m_luaExportHelper.__callBase_RemoveRafflePool(poolId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F5A RID: 106330 RVA: 0x0079A91C File Offset: 0x00798B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitRafflePoolConfigs(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			List<RafflePool> rafflePools;
			LuaObject.checkType<List<RafflePool>>(l, 2, out rafflePools);
			raffleComponent.m_luaExportHelper.__callBase_InitRafflePoolConfigs(rafflePools);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F5B RID: 106331 RVA: 0x0079A978 File Offset: 0x00798B78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsRafflePoolOnActivityTime(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			int rafflePoolId;
			LuaObject.checkType(l, 2, out rafflePoolId);
			int i = raffleComponent.m_luaExportHelper.__callBase_IsRafflePoolOnActivityTime(rafflePoolId);
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

	// Token: 0x06019F5C RID: 106332 RVA: 0x0079A9E0 File Offset: 0x00798BE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_FindOperationalActivityByRafflePoolId(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			int activityCardPoolId;
			LuaObject.checkType(l, 2, out activityCardPoolId);
			OperationalActivityBase o = raffleComponent.m_luaExportHelper.__callBase_FindOperationalActivityByRafflePoolId(activityCardPoolId);
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

	// Token: 0x06019F5D RID: 106333 RVA: 0x0079AA48 File Offset: 0x00798C48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllOpenActivityRafflePool(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			List<int> o = raffleComponent.m_luaExportHelper.__callBase_GetAllOpenActivityRafflePool();
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

	// Token: 0x06019F5E RID: 106334 RVA: 0x0079AAA4 File Offset: 0x00798CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetRafflePool(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			RafflePool o = raffleComponent.m_luaExportHelper.__callBase_GetRafflePool(poolId);
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

	// Token: 0x06019F5F RID: 106335 RVA: 0x0079AB0C File Offset: 0x00798D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsRaffleItemsAllDrawed(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			bool b = raffleComponent.m_luaExportHelper.__callBase_IsRaffleItemsAllDrawed(pool);
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

	// Token: 0x06019F60 RID: 106336 RVA: 0x0079AB74 File Offset: 0x00798D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsDrawItemsEnough(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int drawItemId;
			LuaObject.checkType(l, 3, out drawItemId);
			int count;
			LuaObject.checkType(l, 4, out count);
			bool b = raffleComponent.m_luaExportHelper.__callBase_IsDrawItemsEnough(goodsType, drawItemId, count);
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

	// Token: 0x06019F61 RID: 106337 RVA: 0x0079ABF8 File Offset: 0x00798DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetDrawItemCost(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			int i = raffleComponent.m_luaExportHelper.__callBase_GetDrawItemCost(pool);
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

	// Token: 0x06019F62 RID: 106338 RVA: 0x0079AC60 File Offset: 0x00798E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanFreeDraw(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			bool b = raffleComponent.m_luaExportHelper.__callBase_CanFreeDraw(pool);
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

	// Token: 0x06019F63 RID: 106339 RVA: 0x0079ACC8 File Offset: 0x00798EC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanDraw(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			int i = raffleComponent.m_luaExportHelper.__callBase_CanDraw(poolId);
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

	// Token: 0x06019F64 RID: 106340 RVA: 0x0079AD30 File Offset: 0x00798F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DrawCostItem(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			RafflePool rafflePool;
			LuaObject.checkType<RafflePool>(l, 2, out rafflePool);
			int raffleId;
			LuaObject.checkType(l, 3, out raffleId);
			raffleComponent.m_luaExportHelper.__callBase_DrawCostItem(rafflePool, raffleId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F65 RID: 106341 RVA: 0x0079AD9C File Offset: 0x00798F9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetRaffleItem(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			int raffleId;
			LuaObject.checkType(l, 3, out raffleId);
			RaffleItem o = raffleComponent.m_luaExportHelper.__callBase_GetRaffleItem(pool, raffleId);
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

	// Token: 0x06019F66 RID: 106342 RVA: 0x0079AE10 File Offset: 0x00799010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetFreeDrawedCount(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			int i = raffleComponent.m_luaExportHelper.__callBase_GetFreeDrawedCount(pool);
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

	// Token: 0x06019F67 RID: 106343 RVA: 0x0079AE78 File Offset: 0x00799078
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetDrawedCount(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			int i = raffleComponent.m_luaExportHelper.__callBase_GetDrawedCount(pool);
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

	// Token: 0x06019F68 RID: 106344 RVA: 0x0079AEE0 File Offset: 0x007990E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllDrawedCount(IntPtr l)
	{
		int result;
		try
		{
			RaffleComponent raffleComponent = (RaffleComponent)LuaObject.checkSelf(l);
			RafflePool pool;
			LuaObject.checkType<RafflePool>(l, 2, out pool);
			int i = raffleComponent.m_luaExportHelper.__callBase_GetAllDrawedCount(pool);
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

	// Token: 0x06019F69 RID: 106345 RVA: 0x0079AF48 File Offset: 0x00799148
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.RaffleComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.GetOpenRafflePools);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.Drawed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_RemoveRafflePool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_InitRafflePoolConfigs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_IsRafflePoolOnActivityTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_FindOperationalActivityByRafflePoolId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_GetAllOpenActivityRafflePool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_GetRafflePool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_IsRaffleItemsAllDrawed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_IsDrawItemsEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_GetDrawItemCost);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_CanFreeDraw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_CanDraw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_DrawCostItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_GetRaffleItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_GetFreeDrawedCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_GetDrawedCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.__callBase_GetAllDrawedCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.<>f__mg$cache1B, typeof(RaffleComponent), typeof(RaffleComponentCommon));
	}

	// Token: 0x0401037B RID: 66427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401037C RID: 66428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401037D RID: 66429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401037E RID: 66430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401037F RID: 66431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010380 RID: 66432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010381 RID: 66433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010382 RID: 66434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010383 RID: 66435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010384 RID: 66436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010385 RID: 66437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010386 RID: 66438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010387 RID: 66439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010388 RID: 66440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010389 RID: 66441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401038A RID: 66442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401038B RID: 66443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401038C RID: 66444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401038D RID: 66445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401038E RID: 66446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401038F RID: 66447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010390 RID: 66448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010391 RID: 66449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010392 RID: 66450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010393 RID: 66451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010394 RID: 66452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010395 RID: 66453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010396 RID: 66454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
