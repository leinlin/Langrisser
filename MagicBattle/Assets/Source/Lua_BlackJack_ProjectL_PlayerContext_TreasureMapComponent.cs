using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012E7 RID: 4839
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent : LuaObject
{
	// Token: 0x0601A0EB RID: 106731 RVA: 0x007A6C1C File Offset: 0x007A4E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent o = new TreasureMapComponent();
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

	// Token: 0x0601A0EC RID: 106732 RVA: 0x007A6C64 File Offset: 0x007A4E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			treasureMapComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0ED RID: 106733 RVA: 0x007A6CB0 File Offset: 0x007A4EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			treasureMapComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0EE RID: 106734 RVA: 0x007A6CFC File Offset: 0x007A4EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			treasureMapComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0EF RID: 106735 RVA: 0x007A6D48 File Offset: 0x007A4F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			DSTreasureMapNtf msg;
			LuaObject.checkType<DSTreasureMapNtf>(l, 2, out msg);
			treasureMapComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0F0 RID: 106736 RVA: 0x007A6DA0 File Offset: 0x007A4FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			ushort dsversion = treasureMapComponent.GetDSVersion();
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

	// Token: 0x0601A0F1 RID: 106737 RVA: 0x007A6DF4 File Offset: 0x007A4FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentTicketNums(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			int currentTicketNums = treasureMapComponent.GetCurrentTicketNums();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentTicketNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0F2 RID: 106738 RVA: 0x007A6E48 File Offset: 0x007A5048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FinishedTreasureLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool isWin;
			LuaObject.checkType(l, 3, out isWin);
			List<int> battleTreasureIds;
			LuaObject.checkType<List<int>>(l, 4, out battleTreasureIds);
			int i = treasureMapComponent.FinishedTreasureLevel(levelId, isWin, battleTreasureIds);
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

	// Token: 0x0601A0F3 RID: 106739 RVA: 0x007A6EC4 File Offset: 0x007A50C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSuccessTreasureMapLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			treasureMapComponent.m_luaExportHelper.SetSuccessTreasureMapLevel(levelInfo, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0F4 RID: 106740 RVA: 0x007A6F30 File Offset: 0x007A5130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			string s = treasureMapComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x0601A0F5 RID: 106741 RVA: 0x007A6F8C File Offset: 0x007A518C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			treasureMapComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0F6 RID: 106742 RVA: 0x007A6FE0 File Offset: 0x007A51E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			treasureMapComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0F7 RID: 106743 RVA: 0x007A7034 File Offset: 0x007A5234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			treasureMapComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0F8 RID: 106744 RVA: 0x007A7088 File Offset: 0x007A5288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			treasureMapComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0F9 RID: 106745 RVA: 0x007A70E4 File Offset: 0x007A52E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			treasureMapComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0FA RID: 106746 RVA: 0x007A7138 File Offset: 0x007A5338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = treasureMapComponent.m_luaExportHelper.__callBase_IsLevelFinished(levelId);
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

	// Token: 0x0601A0FB RID: 106747 RVA: 0x007A71A0 File Offset: 0x007A53A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AttackTreasureLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = treasureMapComponent.m_luaExportHelper.__callBase_AttackTreasureLevel(levelId);
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

	// Token: 0x0601A0FC RID: 106748 RVA: 0x007A7208 File Offset: 0x007A5408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackTreasureLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			int leveId;
			LuaObject.checkType(l, 2, out leveId);
			int i = treasureMapComponent.m_luaExportHelper.__callBase_CanAttackTreasureLevel(leveId);
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

	// Token: 0x0601A0FD RID: 106749 RVA: 0x007A7270 File Offset: 0x007A5470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetSuccessTreasureMapLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			ConfigDataTreasureLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTreasureLevelInfo>(l, 2, out levelInfo);
			List<int> battleTreasures;
			LuaObject.checkType<List<int>>(l, 3, out battleTreasures);
			treasureMapComponent.m_luaExportHelper.__callBase_SetSuccessTreasureMapLevel(levelInfo, battleTreasures);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0FE RID: 106750 RVA: 0x007A72DC File Offset: 0x007A54DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnFinishedLevel(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapComponent treasureMapComponent = (TreasureMapComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			treasureMapComponent.m_luaExportHelper.__callBase_OnFinishedLevel(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0FF RID: 106751 RVA: 0x007A7338 File Offset: 0x007A5538
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.TreasureMapComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.GetCurrentTicketNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.FinishedTreasureLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.SetSuccessTreasureMapLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.__callBase_IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.__callBase_AttackTreasureLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.__callBase_CanAttackTreasureLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.__callBase_SetSuccessTreasureMapLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.__callBase_OnFinishedLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.<>f__mg$cache13, typeof(TreasureMapComponent), typeof(TreasureMapComponentCommon));
	}

	// Token: 0x040104FF RID: 66815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010500 RID: 66816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010501 RID: 66817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010502 RID: 66818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010503 RID: 66819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010504 RID: 66820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010505 RID: 66821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010506 RID: 66822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010507 RID: 66823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010508 RID: 66824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010509 RID: 66825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401050A RID: 66826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401050B RID: 66827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401050C RID: 66828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401050D RID: 66829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401050E RID: 66830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401050F RID: 66831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010510 RID: 66832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010511 RID: 66833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010512 RID: 66834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
