using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200113C RID: 4412
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataBattleInfo : LuaObject
{
	// Token: 0x06016529 RID: 91433 RVA: 0x005E0608 File Offset: 0x005DE808
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo o = new ConfigDataBattleInfo();
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

	// Token: 0x0601652A RID: 91434 RVA: 0x005E0650 File Offset: 0x005DE850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			bool b = configDataBattleInfo.Initialize();
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

	// Token: 0x0601652B RID: 91435 RVA: 0x005E06A4 File Offset: 0x005DE8A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlefieldInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.m_battlefieldInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601652C RID: 91436 RVA: 0x005E06F8 File Offset: 0x005DE8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlefieldInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			configDataBattleInfo.m_battlefieldInfo = battlefieldInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601652D RID: 91437 RVA: 0x005E0750 File Offset: 0x005DE950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleWinConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.m_battleWinConditionInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601652E RID: 91438 RVA: 0x005E07A4 File Offset: 0x005DE9A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleWinConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo[] battleWinConditionInfos;
			LuaObject.checkArray<ConfigDataBattleWinConditionInfo>(l, 2, out battleWinConditionInfos);
			configDataBattleInfo.m_battleWinConditionInfos = battleWinConditionInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601652F RID: 91439 RVA: 0x005E07FC File Offset: 0x005DE9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleLoseConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.m_battleLoseConditionInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016530 RID: 91440 RVA: 0x005E0850 File Offset: 0x005DEA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleLoseConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleLoseConditionInfo[] battleLoseConditionInfos;
			LuaObject.checkArray<ConfigDataBattleLoseConditionInfo>(l, 2, out battleLoseConditionInfos);
			configDataBattleInfo.m_battleLoseConditionInfos = battleLoseConditionInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016531 RID: 91441 RVA: 0x005E08A8 File Offset: 0x005DEAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleEventTriggerInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.m_battleEventTriggerInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016532 RID: 91442 RVA: 0x005E08FC File Offset: 0x005DEAFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleEventTriggerInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleEventTriggerInfo[] battleEventTriggerInfos;
			LuaObject.checkArray<ConfigDataBattleEventTriggerInfo>(l, 2, out battleEventTriggerInfos);
			configDataBattleInfo.m_battleEventTriggerInfos = battleEventTriggerInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016533 RID: 91443 RVA: 0x005E0954 File Offset: 0x005DEB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleTreasureInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.m_battleTreasureInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016534 RID: 91444 RVA: 0x005E09A8 File Offset: 0x005DEBA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleTreasureInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo[] battleTreasureInfos;
			LuaObject.checkArray<ConfigDataBattleTreasureInfo>(l, 2, out battleTreasureInfos);
			configDataBattleInfo.m_battleTreasureInfos = battleTreasureInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016535 RID: 91445 RVA: 0x005E0A00 File Offset: 0x005DEC00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_beforePerformBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.m_beforePerformBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016536 RID: 91446 RVA: 0x005E0A54 File Offset: 0x005DEC54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_beforePerformBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo beforePerformBattleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out beforePerformBattleInfo);
			configDataBattleInfo.m_beforePerformBattleInfo = beforePerformBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016537 RID: 91447 RVA: 0x005E0AAC File Offset: 0x005DECAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_afterPerformBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.m_afterPerformBattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016538 RID: 91448 RVA: 0x005E0B00 File Offset: 0x005DED00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_afterPerformBattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo afterPerformBattleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out afterPerformBattleInfo);
			configDataBattleInfo.m_afterPerformBattleInfo = afterPerformBattleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016539 RID: 91449 RVA: 0x005E0B58 File Offset: 0x005DED58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePerformInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.m_battlePerformInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601653A RID: 91450 RVA: 0x005E0BAC File Offset: 0x005DEDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePerformInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo battlePerformInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out battlePerformInfo);
			configDataBattleInfo.m_battlePerformInfo = battlePerformInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601653B RID: 91451 RVA: 0x005E0C04 File Offset: 0x005DEE04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enemyGroupBehaviors(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.m_enemyGroupBehaviors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601653C RID: 91452 RVA: 0x005E0C58 File Offset: 0x005DEE58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enemyGroupBehaviors(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			Dictionary<int, int> enemyGroupBehaviors;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out enemyGroupBehaviors);
			configDataBattleInfo.m_enemyGroupBehaviors = enemyGroupBehaviors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601653D RID: 91453 RVA: 0x005E0CB0 File Offset: 0x005DEEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_npcGroupBehaviors(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.m_npcGroupBehaviors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601653E RID: 91454 RVA: 0x005E0D04 File Offset: 0x005DEF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_npcGroupBehaviors(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			Dictionary<int, int> npcGroupBehaviors;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out npcGroupBehaviors);
			configDataBattleInfo.m_npcGroupBehaviors = npcGroupBehaviors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601653F RID: 91455 RVA: 0x005E0D5C File Offset: 0x005DEF5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016540 RID: 91456 RVA: 0x005E0DB0 File Offset: 0x005DEFB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataBattleInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016541 RID: 91457 RVA: 0x005E0E08 File Offset: 0x005DF008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016542 RID: 91458 RVA: 0x005E0E5C File Offset: 0x005DF05C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataBattleInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016543 RID: 91459 RVA: 0x005E0EB4 File Offset: 0x005DF0B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016544 RID: 91460 RVA: 0x005E0F08 File Offset: 0x005DF108
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataBattleInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016545 RID: 91461 RVA: 0x005E0F60 File Offset: 0x005DF160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016546 RID: 91462 RVA: 0x005E0FB4 File Offset: 0x005DF1B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataBattleInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016547 RID: 91463 RVA: 0x005E100C File Offset: 0x005DF20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016548 RID: 91464 RVA: 0x005E1060 File Offset: 0x005DF260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataBattleInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016549 RID: 91465 RVA: 0x005E10B8 File Offset: 0x005DF2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WinDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.WinDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601654A RID: 91466 RVA: 0x005E110C File Offset: 0x005DF30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WinDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			string winDesc;
			LuaObject.checkType(l, 2, out winDesc);
			configDataBattleInfo.WinDesc = winDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601654B RID: 91467 RVA: 0x005E1164 File Offset: 0x005DF364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WinDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.WinDescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601654C RID: 91468 RVA: 0x005E11B8 File Offset: 0x005DF3B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WinDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			string winDescStrKey;
			LuaObject.checkType(l, 2, out winDescStrKey);
			configDataBattleInfo.WinDescStrKey = winDescStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601654D RID: 91469 RVA: 0x005E1210 File Offset: 0x005DF410
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LoseDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.LoseDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601654E RID: 91470 RVA: 0x005E1264 File Offset: 0x005DF464
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LoseDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			string loseDesc;
			LuaObject.checkType(l, 2, out loseDesc);
			configDataBattleInfo.LoseDesc = loseDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601654F RID: 91471 RVA: 0x005E12BC File Offset: 0x005DF4BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LoseDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.LoseDescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016550 RID: 91472 RVA: 0x005E1310 File Offset: 0x005DF510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LoseDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			string loseDescStrKey;
			LuaObject.checkType(l, 2, out loseDescStrKey);
			configDataBattleInfo.LoseDescStrKey = loseDescStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016551 RID: 91473 RVA: 0x005E1368 File Offset: 0x005DF568
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battlefield_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.Battlefield_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016552 RID: 91474 RVA: 0x005E13BC File Offset: 0x005DF5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battlefield_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			int battlefield_ID;
			LuaObject.checkType(l, 2, out battlefield_ID);
			configDataBattleInfo.Battlefield_ID = battlefield_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016553 RID: 91475 RVA: 0x005E1414 File Offset: 0x005DF614
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.CameraX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016554 RID: 91476 RVA: 0x005E1468 File Offset: 0x005DF668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			int cameraX;
			LuaObject.checkType(l, 2, out cameraX);
			configDataBattleInfo.CameraX = cameraX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016555 RID: 91477 RVA: 0x005E14C0 File Offset: 0x005DF6C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.CameraY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016556 RID: 91478 RVA: 0x005E1514 File Offset: 0x005DF714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			int cameraY;
			LuaObject.checkType(l, 2, out cameraY);
			configDataBattleInfo.CameraY = cameraY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016557 RID: 91479 RVA: 0x005E156C File Offset: 0x005DF76C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PrepareMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.PrepareMusic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016558 RID: 91480 RVA: 0x005E15C0 File Offset: 0x005DF7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PrepareMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			string prepareMusic;
			LuaObject.checkType(l, 2, out prepareMusic);
			configDataBattleInfo.PrepareMusic = prepareMusic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016559 RID: 91481 RVA: 0x005E1618 File Offset: 0x005DF818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.BattleMusic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601655A RID: 91482 RVA: 0x005E166C File Offset: 0x005DF86C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			string battleMusic;
			LuaObject.checkType(l, 2, out battleMusic);
			configDataBattleInfo.BattleMusic = battleMusic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601655B RID: 91483 RVA: 0x005E16C4 File Offset: 0x005DF8C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnemyBattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.EnemyBattleMusic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601655C RID: 91484 RVA: 0x005E1718 File Offset: 0x005DF918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnemyBattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			string enemyBattleMusic;
			LuaObject.checkType(l, 2, out enemyBattleMusic);
			configDataBattleInfo.EnemyBattleMusic = enemyBattleMusic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601655D RID: 91485 RVA: 0x005E1770 File Offset: 0x005DF970
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TurnMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.TurnMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601655E RID: 91486 RVA: 0x005E17C4 File Offset: 0x005DF9C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TurnMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			int turnMax;
			LuaObject.checkType(l, 2, out turnMax);
			configDataBattleInfo.TurnMax = turnMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601655F RID: 91487 RVA: 0x005E181C File Offset: 0x005DFA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AllyNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.AllyNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016560 RID: 91488 RVA: 0x005E1870 File Offset: 0x005DFA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AllyNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			int allyNumber;
			LuaObject.checkType(l, 2, out allyNumber);
			configDataBattleInfo.AllyNumber = allyNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016561 RID: 91489 RVA: 0x005E18C8 File Offset: 0x005DFAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AllyPositions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.AllyPositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016562 RID: 91490 RVA: 0x005E191C File Offset: 0x005DFB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AllyDirs(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.AllyDirs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016563 RID: 91491 RVA: 0x005E1970 File Offset: 0x005DFB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnemyActors(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.EnemyActors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016564 RID: 91492 RVA: 0x005E19C4 File Offset: 0x005DFBC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnemyDirs(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.EnemyDirs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016565 RID: 91493 RVA: 0x005E1A18 File Offset: 0x005DFC18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnemyActorsBehavior(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.EnemyActorsBehavior);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016566 RID: 91494 RVA: 0x005E1A6C File Offset: 0x005DFC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnemyGroups(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.EnemyGroups);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016567 RID: 91495 RVA: 0x005E1AC0 File Offset: 0x005DFCC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnemyGroupBehavior(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.EnemyGroupBehavior);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016568 RID: 91496 RVA: 0x005E1B14 File Offset: 0x005DFD14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NpcActors(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.NpcActors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016569 RID: 91497 RVA: 0x005E1B68 File Offset: 0x005DFD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NpcDirs(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.NpcDirs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601656A RID: 91498 RVA: 0x005E1BBC File Offset: 0x005DFDBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NpcActorsBehavior(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.NpcActorsBehavior);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601656B RID: 91499 RVA: 0x005E1C10 File Offset: 0x005DFE10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NpcGroups(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.NpcGroups);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601656C RID: 91500 RVA: 0x005E1C64 File Offset: 0x005DFE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NpcGroupBehavior(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.NpcGroupBehavior);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601656D RID: 91501 RVA: 0x005E1CB8 File Offset: 0x005DFEB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WinConditions_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.WinConditions_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601656E RID: 91502 RVA: 0x005E1D0C File Offset: 0x005DFF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoseConditions_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.LoseConditions_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601656F RID: 91503 RVA: 0x005E1D60 File Offset: 0x005DFF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EventTriggers_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.EventTriggers_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016570 RID: 91504 RVA: 0x005E1DB4 File Offset: 0x005DFFB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleTreasures_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.BattleTreasures_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016571 RID: 91505 RVA: 0x005E1E08 File Offset: 0x005E0008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BeforePerformBattle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.BeforePerformBattle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016572 RID: 91506 RVA: 0x005E1E5C File Offset: 0x005E005C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BeforePerformBattle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			int beforePerformBattle_ID;
			LuaObject.checkType(l, 2, out beforePerformBattle_ID);
			configDataBattleInfo.BeforePerformBattle_ID = beforePerformBattle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016573 RID: 91507 RVA: 0x005E1EB4 File Offset: 0x005E00B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AfterPerformBattle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.AfterPerformBattle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016574 RID: 91508 RVA: 0x005E1F08 File Offset: 0x005E0108
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AfterPerformBattle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			int afterPerformBattle_ID;
			LuaObject.checkType(l, 2, out afterPerformBattle_ID);
			configDataBattleInfo.AfterPerformBattle_ID = afterPerformBattle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016575 RID: 91509 RVA: 0x005E1F60 File Offset: 0x005E0160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePerform_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.BattlePerform_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016576 RID: 91510 RVA: 0x005E1FB4 File Offset: 0x005E01B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattlePerform_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			int battlePerform_ID;
			LuaObject.checkType(l, 2, out battlePerform_ID);
			configDataBattleInfo.BattlePerform_ID = battlePerform_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016577 RID: 91511 RVA: 0x005E200C File Offset: 0x005E020C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleRandomEnemies_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.BattleRandomEnemies_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016578 RID: 91512 RVA: 0x005E2060 File Offset: 0x005E0260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleEnemyRandomRule(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBattleInfo.BattleEnemyRandomRule);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016579 RID: 91513 RVA: 0x005E20B4 File Offset: 0x005E02B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleEnemyRandomRule(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			BattleArmyRandomRuleType battleEnemyRandomRule;
			LuaObject.checkEnum<BattleArmyRandomRuleType>(l, 2, out battleEnemyRandomRule);
			configDataBattleInfo.BattleEnemyRandomRule = battleEnemyRandomRule;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601657A RID: 91514 RVA: 0x005E210C File Offset: 0x005E030C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnemyRandomTalent_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.EnemyRandomTalent_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601657B RID: 91515 RVA: 0x005E2160 File Offset: 0x005E0360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnemyRandomTalent_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			int enemyRandomTalent_ID;
			LuaObject.checkType(l, 2, out enemyRandomTalent_ID);
			configDataBattleInfo.EnemyRandomTalent_ID = enemyRandomTalent_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601657C RID: 91516 RVA: 0x005E21B8 File Offset: 0x005E03B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnemyRandomTalentProbilities(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.EnemyRandomTalentProbilities);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601657D RID: 91517 RVA: 0x005E220C File Offset: 0x005E040C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ImperativeBattleHeroes_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleInfo configDataBattleInfo = (ConfigDataBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleInfo.ImperativeBattleHeroes_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601657E RID: 91518 RVA: 0x005E2260 File Offset: 0x005E0460
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataBattleInfo");
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache0);
		string name = "m_battlefieldInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_m_battlefieldInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_m_battlefieldInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2, true);
		string name2 = "m_battleWinConditionInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_m_battleWinConditionInfos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_m_battleWinConditionInfos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4, true);
		string name3 = "m_battleLoseConditionInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_m_battleLoseConditionInfos);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache5;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_m_battleLoseConditionInfos);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache6, true);
		string name4 = "m_battleEventTriggerInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_m_battleEventTriggerInfos);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache7;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_m_battleEventTriggerInfos);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache8, true);
		string name5 = "m_battleTreasureInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_m_battleTreasureInfos);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache9;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_m_battleTreasureInfos);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheA, true);
		string name6 = "m_beforePerformBattleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_m_beforePerformBattleInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheB;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_m_beforePerformBattleInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheC, true);
		string name7 = "m_afterPerformBattleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_m_afterPerformBattleInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheD;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_m_afterPerformBattleInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheE, true);
		string name8 = "m_battlePerformInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_m_battlePerformInfo);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cacheF;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_m_battlePerformInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache10, true);
		string name9 = "m_enemyGroupBehaviors";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_m_enemyGroupBehaviors);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache11;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_m_enemyGroupBehaviors);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache12, true);
		string name10 = "m_npcGroupBehaviors";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_m_npcGroupBehaviors);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_m_npcGroupBehaviors);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache14, true);
		string name11 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_ID);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_ID);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache16, true);
		string name12 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_Name);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_Name);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache18, true);
		string name13 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_NameStrKey);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache19;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1A, true);
		string name14 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_Desc);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1B;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_Desc);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1C, true);
		string name15 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_DescStrKey);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1D;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1E, true);
		string name16 = "WinDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_WinDesc);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache1F;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_WinDesc);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache20, true);
		string name17 = "WinDescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_WinDescStrKey);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache21;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_WinDescStrKey);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache22, true);
		string name18 = "LoseDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_LoseDesc);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache23;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_LoseDesc);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache24, true);
		string name19 = "LoseDescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_LoseDescStrKey);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache25;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_LoseDescStrKey);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache26, true);
		string name20 = "Battlefield_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_Battlefield_ID);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache27;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_Battlefield_ID);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache28, true);
		string name21 = "CameraX";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_CameraX);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache29;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_CameraX);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2A, true);
		string name22 = "CameraY";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_CameraY);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_CameraY);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2C, true);
		string name23 = "PrepareMusic";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_PrepareMusic);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2D;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_PrepareMusic);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2E, true);
		string name24 = "BattleMusic";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_BattleMusic);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache2F;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_BattleMusic);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache30, true);
		string name25 = "EnemyBattleMusic";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_EnemyBattleMusic);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache31;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_EnemyBattleMusic);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache32, true);
		string name26 = "TurnMax";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_TurnMax);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache33;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_TurnMax);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache34, true);
		string name27 = "AllyNumber";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_AllyNumber);
		}
		LuaCSFunction get27 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache35;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_AllyNumber);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache36, true);
		string name28 = "AllyPositions";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_AllyPositions);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache37, null, true);
		string name29 = "AllyDirs";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_AllyDirs);
		}
		LuaObject.addMember(l, name29, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache38, null, true);
		string name30 = "EnemyActors";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_EnemyActors);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache39, null, true);
		string name31 = "EnemyDirs";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_EnemyDirs);
		}
		LuaObject.addMember(l, name31, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3A, null, true);
		string name32 = "EnemyActorsBehavior";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_EnemyActorsBehavior);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3B, null, true);
		string name33 = "EnemyGroups";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_EnemyGroups);
		}
		LuaObject.addMember(l, name33, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3C, null, true);
		string name34 = "EnemyGroupBehavior";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_EnemyGroupBehavior);
		}
		LuaObject.addMember(l, name34, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3D, null, true);
		string name35 = "NpcActors";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_NpcActors);
		}
		LuaObject.addMember(l, name35, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3E, null, true);
		string name36 = "NpcDirs";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_NpcDirs);
		}
		LuaObject.addMember(l, name36, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache3F, null, true);
		string name37 = "NpcActorsBehavior";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_NpcActorsBehavior);
		}
		LuaObject.addMember(l, name37, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache40, null, true);
		string name38 = "NpcGroups";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_NpcGroups);
		}
		LuaObject.addMember(l, name38, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache41, null, true);
		string name39 = "NpcGroupBehavior";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_NpcGroupBehavior);
		}
		LuaObject.addMember(l, name39, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache42, null, true);
		string name40 = "WinConditions_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_WinConditions_ID);
		}
		LuaObject.addMember(l, name40, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache43, null, true);
		string name41 = "LoseConditions_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_LoseConditions_ID);
		}
		LuaObject.addMember(l, name41, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache44, null, true);
		string name42 = "EventTriggers_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_EventTriggers_ID);
		}
		LuaObject.addMember(l, name42, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache45, null, true);
		string name43 = "BattleTreasures_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_BattleTreasures_ID);
		}
		LuaObject.addMember(l, name43, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache46, null, true);
		string name44 = "BeforePerformBattle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_BeforePerformBattle_ID);
		}
		LuaCSFunction get28 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache47;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_BeforePerformBattle_ID);
		}
		LuaObject.addMember(l, name44, get28, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache48, true);
		string name45 = "AfterPerformBattle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_AfterPerformBattle_ID);
		}
		LuaCSFunction get29 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache49;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_AfterPerformBattle_ID);
		}
		LuaObject.addMember(l, name45, get29, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4A, true);
		string name46 = "BattlePerform_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_BattlePerform_ID);
		}
		LuaCSFunction get30 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4B;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_BattlePerform_ID);
		}
		LuaObject.addMember(l, name46, get30, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4C, true);
		string name47 = "BattleRandomEnemies_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_BattleRandomEnemies_ID);
		}
		LuaObject.addMember(l, name47, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4D, null, true);
		string name48 = "BattleEnemyRandomRule";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_BattleEnemyRandomRule);
		}
		LuaCSFunction get31 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4E;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_BattleEnemyRandomRule);
		}
		LuaObject.addMember(l, name48, get31, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache4F, true);
		string name49 = "EnemyRandomTalent_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_EnemyRandomTalent_ID);
		}
		LuaCSFunction get32 = Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache50;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.set_EnemyRandomTalent_ID);
		}
		LuaObject.addMember(l, name49, get32, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache51, true);
		string name50 = "EnemyRandomTalentProbilities";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_EnemyRandomTalentProbilities);
		}
		LuaObject.addMember(l, name50, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache52, null, true);
		string name51 = "ImperativeBattleHeroes_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.get_ImperativeBattleHeroes_ID);
		}
		LuaObject.addMember(l, name51, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache53, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataBattleInfo.<>f__mg$cache54, typeof(ConfigDataBattleInfo));
	}

	// Token: 0x0400CC93 RID: 52371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CC94 RID: 52372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CC95 RID: 52373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CC96 RID: 52374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CC97 RID: 52375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CC98 RID: 52376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CC99 RID: 52377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CC9A RID: 52378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CC9B RID: 52379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CC9C RID: 52380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CC9D RID: 52381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CC9E RID: 52382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CC9F RID: 52383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CCA0 RID: 52384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CCA1 RID: 52385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CCA2 RID: 52386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CCA3 RID: 52387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CCA4 RID: 52388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CCA5 RID: 52389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CCA6 RID: 52390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CCA7 RID: 52391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CCA8 RID: 52392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CCA9 RID: 52393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CCAA RID: 52394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CCAB RID: 52395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CCAC RID: 52396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CCAD RID: 52397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CCAE RID: 52398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CCAF RID: 52399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CCB0 RID: 52400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CCB1 RID: 52401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CCB2 RID: 52402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CCB3 RID: 52403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CCB4 RID: 52404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CCB5 RID: 52405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CCB6 RID: 52406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CCB7 RID: 52407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CCB8 RID: 52408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CCB9 RID: 52409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CCBA RID: 52410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CCBB RID: 52411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400CCBC RID: 52412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400CCBD RID: 52413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400CCBE RID: 52414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400CCBF RID: 52415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400CCC0 RID: 52416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400CCC1 RID: 52417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400CCC2 RID: 52418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400CCC3 RID: 52419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400CCC4 RID: 52420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400CCC5 RID: 52421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400CCC6 RID: 52422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400CCC7 RID: 52423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400CCC8 RID: 52424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400CCC9 RID: 52425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400CCCA RID: 52426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400CCCB RID: 52427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400CCCC RID: 52428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400CCCD RID: 52429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400CCCE RID: 52430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400CCCF RID: 52431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400CCD0 RID: 52432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400CCD1 RID: 52433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400CCD2 RID: 52434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400CCD3 RID: 52435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400CCD4 RID: 52436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400CCD5 RID: 52437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400CCD6 RID: 52438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400CCD7 RID: 52439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400CCD8 RID: 52440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400CCD9 RID: 52441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400CCDA RID: 52442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400CCDB RID: 52443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400CCDC RID: 52444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400CCDD RID: 52445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400CCDE RID: 52446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400CCDF RID: 52447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400CCE0 RID: 52448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400CCE1 RID: 52449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400CCE2 RID: 52450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400CCE3 RID: 52451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400CCE4 RID: 52452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400CCE5 RID: 52453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400CCE6 RID: 52454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400CCE7 RID: 52455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;
}
