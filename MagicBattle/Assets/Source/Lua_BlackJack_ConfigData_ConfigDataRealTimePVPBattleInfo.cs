using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001164 RID: 4452
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo : LuaObject
{
	// Token: 0x06016BA5 RID: 93093 RVA: 0x0060F998 File Offset: 0x0060DB98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo o = new ConfigDataRealTimePVPBattleInfo();
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

	// Token: 0x06016BA6 RID: 93094 RVA: 0x0060F9E0 File Offset: 0x0060DBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlefieldInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.m_battlefieldInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BA7 RID: 93095 RVA: 0x0060FA34 File Offset: 0x0060DC34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battlefieldInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			configDataRealTimePVPBattleInfo.m_battlefieldInfo = battlefieldInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BA8 RID: 93096 RVA: 0x0060FA8C File Offset: 0x0060DC8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleWinConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.m_battleWinConditionInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BA9 RID: 93097 RVA: 0x0060FAE0 File Offset: 0x0060DCE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleWinConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo[] battleWinConditionInfos;
			LuaObject.checkArray<ConfigDataBattleWinConditionInfo>(l, 2, out battleWinConditionInfos);
			configDataRealTimePVPBattleInfo.m_battleWinConditionInfos = battleWinConditionInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BAA RID: 93098 RVA: 0x0060FB38 File Offset: 0x0060DD38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleLoseConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.m_battleLoseConditionInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BAB RID: 93099 RVA: 0x0060FB8C File Offset: 0x0060DD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleLoseConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleLoseConditionInfo[] battleLoseConditionInfos;
			LuaObject.checkArray<ConfigDataBattleLoseConditionInfo>(l, 2, out battleLoseConditionInfos);
			configDataRealTimePVPBattleInfo.m_battleLoseConditionInfos = battleLoseConditionInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BAC RID: 93100 RVA: 0x0060FBE4 File Offset: 0x0060DDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleEventTriggerInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.m_battleEventTriggerInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BAD RID: 93101 RVA: 0x0060FC38 File Offset: 0x0060DE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleEventTriggerInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleEventTriggerInfo[] battleEventTriggerInfos;
			LuaObject.checkArray<ConfigDataBattleEventTriggerInfo>(l, 2, out battleEventTriggerInfos);
			configDataRealTimePVPBattleInfo.m_battleEventTriggerInfos = battleEventTriggerInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BAE RID: 93102 RVA: 0x0060FC90 File Offset: 0x0060DE90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BAF RID: 93103 RVA: 0x0060FCE4 File Offset: 0x0060DEE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataRealTimePVPBattleInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BB0 RID: 93104 RVA: 0x0060FD3C File Offset: 0x0060DF3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BB1 RID: 93105 RVA: 0x0060FD90 File Offset: 0x0060DF90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataRealTimePVPBattleInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BB2 RID: 93106 RVA: 0x0060FDE8 File Offset: 0x0060DFE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BB3 RID: 93107 RVA: 0x0060FE3C File Offset: 0x0060E03C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataRealTimePVPBattleInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BB4 RID: 93108 RVA: 0x0060FE94 File Offset: 0x0060E094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BB5 RID: 93109 RVA: 0x0060FEE8 File Offset: 0x0060E0E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataRealTimePVPBattleInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BB6 RID: 93110 RVA: 0x0060FF40 File Offset: 0x0060E140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BB7 RID: 93111 RVA: 0x0060FF94 File Offset: 0x0060E194
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataRealTimePVPBattleInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BB8 RID: 93112 RVA: 0x0060FFEC File Offset: 0x0060E1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WinDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.WinDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BB9 RID: 93113 RVA: 0x00610040 File Offset: 0x0060E240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WinDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			string winDesc;
			LuaObject.checkType(l, 2, out winDesc);
			configDataRealTimePVPBattleInfo.WinDesc = winDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BBA RID: 93114 RVA: 0x00610098 File Offset: 0x0060E298
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WinDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.WinDescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BBB RID: 93115 RVA: 0x006100EC File Offset: 0x0060E2EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WinDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			string winDescStrKey;
			LuaObject.checkType(l, 2, out winDescStrKey);
			configDataRealTimePVPBattleInfo.WinDescStrKey = winDescStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BBC RID: 93116 RVA: 0x00610144 File Offset: 0x0060E344
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LoseDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.LoseDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BBD RID: 93117 RVA: 0x00610198 File Offset: 0x0060E398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LoseDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			string loseDesc;
			LuaObject.checkType(l, 2, out loseDesc);
			configDataRealTimePVPBattleInfo.LoseDesc = loseDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BBE RID: 93118 RVA: 0x006101F0 File Offset: 0x0060E3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoseDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.LoseDescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BBF RID: 93119 RVA: 0x00610244 File Offset: 0x0060E444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LoseDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			string loseDescStrKey;
			LuaObject.checkType(l, 2, out loseDescStrKey);
			configDataRealTimePVPBattleInfo.LoseDescStrKey = loseDescStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BC0 RID: 93120 RVA: 0x0061029C File Offset: 0x0060E49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Battlefield_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.Battlefield_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BC1 RID: 93121 RVA: 0x006102F0 File Offset: 0x0060E4F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Battlefield_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			int battlefield_ID;
			LuaObject.checkType(l, 2, out battlefield_ID);
			configDataRealTimePVPBattleInfo.Battlefield_ID = battlefield_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BC2 RID: 93122 RVA: 0x00610348 File Offset: 0x0060E548
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.CameraX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BC3 RID: 93123 RVA: 0x0061039C File Offset: 0x0060E59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			int cameraX;
			LuaObject.checkType(l, 2, out cameraX);
			configDataRealTimePVPBattleInfo.CameraX = cameraX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BC4 RID: 93124 RVA: 0x006103F4 File Offset: 0x0060E5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.CameraY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BC5 RID: 93125 RVA: 0x00610448 File Offset: 0x0060E648
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			int cameraY;
			LuaObject.checkType(l, 2, out cameraY);
			configDataRealTimePVPBattleInfo.CameraY = cameraY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BC6 RID: 93126 RVA: 0x006104A0 File Offset: 0x0060E6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendCameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.DefendCameraX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BC7 RID: 93127 RVA: 0x006104F4 File Offset: 0x0060E6F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefendCameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			int defendCameraX;
			LuaObject.checkType(l, 2, out defendCameraX);
			configDataRealTimePVPBattleInfo.DefendCameraX = defendCameraX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BC8 RID: 93128 RVA: 0x0061054C File Offset: 0x0060E74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendCameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.DefendCameraY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BC9 RID: 93129 RVA: 0x006105A0 File Offset: 0x0060E7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefendCameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			int defendCameraY;
			LuaObject.checkType(l, 2, out defendCameraY);
			configDataRealTimePVPBattleInfo.DefendCameraY = defendCameraY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BCA RID: 93130 RVA: 0x006105F8 File Offset: 0x0060E7F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PrepareMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.PrepareMusic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BCB RID: 93131 RVA: 0x0061064C File Offset: 0x0060E84C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PrepareMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			string prepareMusic;
			LuaObject.checkType(l, 2, out prepareMusic);
			configDataRealTimePVPBattleInfo.PrepareMusic = prepareMusic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BCC RID: 93132 RVA: 0x006106A4 File Offset: 0x0060E8A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.BattleMusic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BCD RID: 93133 RVA: 0x006106F8 File Offset: 0x0060E8F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			string battleMusic;
			LuaObject.checkType(l, 2, out battleMusic);
			configDataRealTimePVPBattleInfo.BattleMusic = battleMusic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BCE RID: 93134 RVA: 0x00610750 File Offset: 0x0060E950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendBattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.DefendBattleMusic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BCF RID: 93135 RVA: 0x006107A4 File Offset: 0x0060E9A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefendBattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			string defendBattleMusic;
			LuaObject.checkType(l, 2, out defendBattleMusic);
			configDataRealTimePVPBattleInfo.DefendBattleMusic = defendBattleMusic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BD0 RID: 93136 RVA: 0x006107FC File Offset: 0x0060E9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TurnMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.TurnMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BD1 RID: 93137 RVA: 0x00610850 File Offset: 0x0060EA50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TurnMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			int turnMax;
			LuaObject.checkType(l, 2, out turnMax);
			configDataRealTimePVPBattleInfo.TurnMax = turnMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BD2 RID: 93138 RVA: 0x006108A8 File Offset: 0x0060EAA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WinConditions_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.WinConditions_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BD3 RID: 93139 RVA: 0x006108FC File Offset: 0x0060EAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoseConditions_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.LoseConditions_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BD4 RID: 93140 RVA: 0x00610950 File Offset: 0x0060EB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EventTriggers_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.EventTriggers_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BD5 RID: 93141 RVA: 0x006109A4 File Offset: 0x0060EBA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.AttackNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BD6 RID: 93142 RVA: 0x006109F8 File Offset: 0x0060EBF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AttackNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			int attackNumber;
			LuaObject.checkType(l, 2, out attackNumber);
			configDataRealTimePVPBattleInfo.AttackNumber = attackNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BD7 RID: 93143 RVA: 0x00610A50 File Offset: 0x0060EC50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackPositions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.AttackPositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BD8 RID: 93144 RVA: 0x00610AA4 File Offset: 0x0060ECA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackDirs(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.AttackDirs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BD9 RID: 93145 RVA: 0x00610AF8 File Offset: 0x0060ECF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.DefendNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BDA RID: 93146 RVA: 0x00610B4C File Offset: 0x0060ED4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefendNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			int defendNumber;
			LuaObject.checkType(l, 2, out defendNumber);
			configDataRealTimePVPBattleInfo.DefendNumber = defendNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BDB RID: 93147 RVA: 0x00610BA4 File Offset: 0x0060EDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendPositions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.DefendPositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BDC RID: 93148 RVA: 0x00610BF8 File Offset: 0x0060EDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendDirs(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = (ConfigDataRealTimePVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRealTimePVPBattleInfo.DefendDirs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BDD RID: 93149 RVA: 0x00610C4C File Offset: 0x0060EE4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataRealTimePVPBattleInfo");
		string name = "m_battlefieldInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_m_battlefieldInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_m_battlefieldInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1, true);
		string name2 = "m_battleWinConditionInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_m_battleWinConditionInfos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_m_battleWinConditionInfos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache3, true);
		string name3 = "m_battleLoseConditionInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_m_battleLoseConditionInfos);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_m_battleLoseConditionInfos);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache5, true);
		string name4 = "m_battleEventTriggerInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_m_battleEventTriggerInfos);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_m_battleEventTriggerInfos);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache7, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache9, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheB, true);
		string name7 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_NameStrKey);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheD, true);
		string name8 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_Desc);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_Desc);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cacheF, true);
		string name9 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_DescStrKey);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache11, true);
		string name10 = "WinDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_WinDesc);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_WinDesc);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache13, true);
		string name11 = "WinDescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_WinDescStrKey);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_WinDescStrKey);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache15, true);
		string name12 = "LoseDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_LoseDesc);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_LoseDesc);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache17, true);
		string name13 = "LoseDescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_LoseDescStrKey);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_LoseDescStrKey);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache19, true);
		string name14 = "Battlefield_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_Battlefield_ID);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_Battlefield_ID);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1B, true);
		string name15 = "CameraX";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_CameraX);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_CameraX);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1D, true);
		string name16 = "CameraY";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_CameraY);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_CameraY);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache1F, true);
		string name17 = "DefendCameraX";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_DefendCameraX);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_DefendCameraX);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache21, true);
		string name18 = "DefendCameraY";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_DefendCameraY);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_DefendCameraY);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache23, true);
		string name19 = "PrepareMusic";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_PrepareMusic);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_PrepareMusic);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache25, true);
		string name20 = "BattleMusic";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_BattleMusic);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_BattleMusic);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache27, true);
		string name21 = "DefendBattleMusic";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_DefendBattleMusic);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_DefendBattleMusic);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache29, true);
		string name22 = "TurnMax";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_TurnMax);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_TurnMax);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2B, true);
		string name23 = "WinConditions_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_WinConditions_ID);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2C, null, true);
		string name24 = "LoseConditions_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_LoseConditions_ID);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2D, null, true);
		string name25 = "EventTriggers_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_EventTriggers_ID);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2E, null, true);
		string name26 = "AttackNumber";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_AttackNumber);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache2F;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_AttackNumber);
		}
		LuaObject.addMember(l, name26, get23, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache30, true);
		string name27 = "AttackPositions";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_AttackPositions);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache31, null, true);
		string name28 = "AttackDirs";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_AttackDirs);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache32, null, true);
		string name29 = "DefendNumber";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_DefendNumber);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache33;
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.set_DefendNumber);
		}
		LuaObject.addMember(l, name29, get24, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache34, true);
		string name30 = "DefendPositions";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_DefendPositions);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache35, null, true);
		string name31 = "DefendDirs";
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.get_DefendDirs);
		}
		LuaObject.addMember(l, name31, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache36, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.<>f__mg$cache37, typeof(ConfigDataRealTimePVPBattleInfo));
	}

	// Token: 0x0400D2BF RID: 53951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D2C0 RID: 53952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D2C1 RID: 53953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D2C2 RID: 53954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D2C3 RID: 53955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D2C4 RID: 53956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D2C5 RID: 53957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D2C6 RID: 53958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D2C7 RID: 53959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D2C8 RID: 53960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D2C9 RID: 53961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D2CA RID: 53962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D2CB RID: 53963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D2CC RID: 53964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D2CD RID: 53965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D2CE RID: 53966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D2CF RID: 53967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D2D0 RID: 53968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D2D1 RID: 53969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D2D2 RID: 53970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D2D3 RID: 53971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D2D4 RID: 53972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D2D5 RID: 53973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D2D6 RID: 53974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D2D7 RID: 53975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D2D8 RID: 53976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D2D9 RID: 53977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D2DA RID: 53978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D2DB RID: 53979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D2DC RID: 53980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D2DD RID: 53981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D2DE RID: 53982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D2DF RID: 53983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D2E0 RID: 53984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D2E1 RID: 53985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D2E2 RID: 53986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D2E3 RID: 53987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D2E4 RID: 53988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D2E5 RID: 53989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D2E6 RID: 53990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D2E7 RID: 53991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D2E8 RID: 53992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D2E9 RID: 53993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D2EA RID: 53994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D2EB RID: 53995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D2EC RID: 53996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D2ED RID: 53997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D2EE RID: 53998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D2EF RID: 53999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D2F0 RID: 54000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D2F1 RID: 54001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D2F2 RID: 54002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D2F3 RID: 54003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D2F4 RID: 54004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D2F5 RID: 54005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400D2F6 RID: 54006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
