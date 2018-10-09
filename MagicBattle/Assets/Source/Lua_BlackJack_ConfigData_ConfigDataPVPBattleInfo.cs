using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001163 RID: 4451
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo : LuaObject
{
	// Token: 0x06016B6B RID: 93035 RVA: 0x0060DEE0 File Offset: 0x0060C0E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo o = new ConfigDataPVPBattleInfo();
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

	// Token: 0x06016B6C RID: 93036 RVA: 0x0060DF28 File Offset: 0x0060C128
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battlefieldInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.m_battlefieldInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B6D RID: 93037 RVA: 0x0060DF7C File Offset: 0x0060C17C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battlefieldInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			configDataPVPBattleInfo.m_battlefieldInfo = battlefieldInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B6E RID: 93038 RVA: 0x0060DFD4 File Offset: 0x0060C1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleWinConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.m_battleWinConditionInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B6F RID: 93039 RVA: 0x0060E028 File Offset: 0x0060C228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleWinConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo[] battleWinConditionInfos;
			LuaObject.checkArray<ConfigDataBattleWinConditionInfo>(l, 2, out battleWinConditionInfos);
			configDataPVPBattleInfo.m_battleWinConditionInfos = battleWinConditionInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B70 RID: 93040 RVA: 0x0060E080 File Offset: 0x0060C280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleLoseConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.m_battleLoseConditionInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B71 RID: 93041 RVA: 0x0060E0D4 File Offset: 0x0060C2D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleLoseConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleLoseConditionInfo[] battleLoseConditionInfos;
			LuaObject.checkArray<ConfigDataBattleLoseConditionInfo>(l, 2, out battleLoseConditionInfos);
			configDataPVPBattleInfo.m_battleLoseConditionInfos = battleLoseConditionInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B72 RID: 93042 RVA: 0x0060E12C File Offset: 0x0060C32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleEventTriggerInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.m_battleEventTriggerInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B73 RID: 93043 RVA: 0x0060E180 File Offset: 0x0060C380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleEventTriggerInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleEventTriggerInfo[] battleEventTriggerInfos;
			LuaObject.checkArray<ConfigDataBattleEventTriggerInfo>(l, 2, out battleEventTriggerInfos);
			configDataPVPBattleInfo.m_battleEventTriggerInfos = battleEventTriggerInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B74 RID: 93044 RVA: 0x0060E1D8 File Offset: 0x0060C3D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B75 RID: 93045 RVA: 0x0060E22C File Offset: 0x0060C42C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataPVPBattleInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B76 RID: 93046 RVA: 0x0060E284 File Offset: 0x0060C484
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B77 RID: 93047 RVA: 0x0060E2D8 File Offset: 0x0060C4D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataPVPBattleInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B78 RID: 93048 RVA: 0x0060E330 File Offset: 0x0060C530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B79 RID: 93049 RVA: 0x0060E384 File Offset: 0x0060C584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataPVPBattleInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B7A RID: 93050 RVA: 0x0060E3DC File Offset: 0x0060C5DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B7B RID: 93051 RVA: 0x0060E430 File Offset: 0x0060C630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataPVPBattleInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B7C RID: 93052 RVA: 0x0060E488 File Offset: 0x0060C688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B7D RID: 93053 RVA: 0x0060E4DC File Offset: 0x0060C6DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataPVPBattleInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B7E RID: 93054 RVA: 0x0060E534 File Offset: 0x0060C734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WinDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.WinDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B7F RID: 93055 RVA: 0x0060E588 File Offset: 0x0060C788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WinDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			string winDesc;
			LuaObject.checkType(l, 2, out winDesc);
			configDataPVPBattleInfo.WinDesc = winDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B80 RID: 93056 RVA: 0x0060E5E0 File Offset: 0x0060C7E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WinDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.WinDescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B81 RID: 93057 RVA: 0x0060E634 File Offset: 0x0060C834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WinDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			string winDescStrKey;
			LuaObject.checkType(l, 2, out winDescStrKey);
			configDataPVPBattleInfo.WinDescStrKey = winDescStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B82 RID: 93058 RVA: 0x0060E68C File Offset: 0x0060C88C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LoseDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.LoseDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B83 RID: 93059 RVA: 0x0060E6E0 File Offset: 0x0060C8E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LoseDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			string loseDesc;
			LuaObject.checkType(l, 2, out loseDesc);
			configDataPVPBattleInfo.LoseDesc = loseDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B84 RID: 93060 RVA: 0x0060E738 File Offset: 0x0060C938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoseDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.LoseDescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B85 RID: 93061 RVA: 0x0060E78C File Offset: 0x0060C98C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LoseDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			string loseDescStrKey;
			LuaObject.checkType(l, 2, out loseDescStrKey);
			configDataPVPBattleInfo.LoseDescStrKey = loseDescStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B86 RID: 93062 RVA: 0x0060E7E4 File Offset: 0x0060C9E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battlefield_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.Battlefield_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B87 RID: 93063 RVA: 0x0060E838 File Offset: 0x0060CA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battlefield_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			int battlefield_ID;
			LuaObject.checkType(l, 2, out battlefield_ID);
			configDataPVPBattleInfo.Battlefield_ID = battlefield_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B88 RID: 93064 RVA: 0x0060E890 File Offset: 0x0060CA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.CameraX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B89 RID: 93065 RVA: 0x0060E8E4 File Offset: 0x0060CAE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			int cameraX;
			LuaObject.checkType(l, 2, out cameraX);
			configDataPVPBattleInfo.CameraX = cameraX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B8A RID: 93066 RVA: 0x0060E93C File Offset: 0x0060CB3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.CameraY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B8B RID: 93067 RVA: 0x0060E990 File Offset: 0x0060CB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			int cameraY;
			LuaObject.checkType(l, 2, out cameraY);
			configDataPVPBattleInfo.CameraY = cameraY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B8C RID: 93068 RVA: 0x0060E9E8 File Offset: 0x0060CBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendCameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.DefendCameraX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B8D RID: 93069 RVA: 0x0060EA3C File Offset: 0x0060CC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefendCameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			int defendCameraX;
			LuaObject.checkType(l, 2, out defendCameraX);
			configDataPVPBattleInfo.DefendCameraX = defendCameraX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B8E RID: 93070 RVA: 0x0060EA94 File Offset: 0x0060CC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendCameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.DefendCameraY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B8F RID: 93071 RVA: 0x0060EAE8 File Offset: 0x0060CCE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefendCameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			int defendCameraY;
			LuaObject.checkType(l, 2, out defendCameraY);
			configDataPVPBattleInfo.DefendCameraY = defendCameraY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B90 RID: 93072 RVA: 0x0060EB40 File Offset: 0x0060CD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PrepareMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.PrepareMusic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B91 RID: 93073 RVA: 0x0060EB94 File Offset: 0x0060CD94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PrepareMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			string prepareMusic;
			LuaObject.checkType(l, 2, out prepareMusic);
			configDataPVPBattleInfo.PrepareMusic = prepareMusic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B92 RID: 93074 RVA: 0x0060EBEC File Offset: 0x0060CDEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.BattleMusic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B93 RID: 93075 RVA: 0x0060EC40 File Offset: 0x0060CE40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			string battleMusic;
			LuaObject.checkType(l, 2, out battleMusic);
			configDataPVPBattleInfo.BattleMusic = battleMusic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B94 RID: 93076 RVA: 0x0060EC98 File Offset: 0x0060CE98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefendBattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.DefendBattleMusic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B95 RID: 93077 RVA: 0x0060ECEC File Offset: 0x0060CEEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefendBattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			string defendBattleMusic;
			LuaObject.checkType(l, 2, out defendBattleMusic);
			configDataPVPBattleInfo.DefendBattleMusic = defendBattleMusic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B96 RID: 93078 RVA: 0x0060ED44 File Offset: 0x0060CF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TurnMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.TurnMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B97 RID: 93079 RVA: 0x0060ED98 File Offset: 0x0060CF98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TurnMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			int turnMax;
			LuaObject.checkType(l, 2, out turnMax);
			configDataPVPBattleInfo.TurnMax = turnMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B98 RID: 93080 RVA: 0x0060EDF0 File Offset: 0x0060CFF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WinConditions_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.WinConditions_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B99 RID: 93081 RVA: 0x0060EE44 File Offset: 0x0060D044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoseConditions_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.LoseConditions_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B9A RID: 93082 RVA: 0x0060EE98 File Offset: 0x0060D098
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EventTriggers_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.EventTriggers_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B9B RID: 93083 RVA: 0x0060EEEC File Offset: 0x0060D0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AttackNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.AttackNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B9C RID: 93084 RVA: 0x0060EF40 File Offset: 0x0060D140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AttackNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			int attackNumber;
			LuaObject.checkType(l, 2, out attackNumber);
			configDataPVPBattleInfo.AttackNumber = attackNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B9D RID: 93085 RVA: 0x0060EF98 File Offset: 0x0060D198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AttackPositions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.AttackPositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B9E RID: 93086 RVA: 0x0060EFEC File Offset: 0x0060D1EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackDirs(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.AttackDirs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B9F RID: 93087 RVA: 0x0060F040 File Offset: 0x0060D240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.DefendNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BA0 RID: 93088 RVA: 0x0060F094 File Offset: 0x0060D294
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefendNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			int defendNumber;
			LuaObject.checkType(l, 2, out defendNumber);
			configDataPVPBattleInfo.DefendNumber = defendNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BA1 RID: 93089 RVA: 0x0060F0EC File Offset: 0x0060D2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendPositions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.DefendPositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BA2 RID: 93090 RVA: 0x0060F140 File Offset: 0x0060D340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefendDirs(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = (ConfigDataPVPBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataPVPBattleInfo.DefendDirs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016BA3 RID: 93091 RVA: 0x0060F194 File Offset: 0x0060D394
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataPVPBattleInfo");
		string name = "m_battlefieldInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_m_battlefieldInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_m_battlefieldInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1, true);
		string name2 = "m_battleWinConditionInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_m_battleWinConditionInfos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_m_battleWinConditionInfos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache3, true);
		string name3 = "m_battleLoseConditionInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_m_battleLoseConditionInfos);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_m_battleLoseConditionInfos);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache5, true);
		string name4 = "m_battleEventTriggerInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_m_battleEventTriggerInfos);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_m_battleEventTriggerInfos);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache7, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache9, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheB, true);
		string name7 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_NameStrKey);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheD, true);
		string name8 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_Desc);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_Desc);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cacheF, true);
		string name9 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_DescStrKey);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache11, true);
		string name10 = "WinDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_WinDesc);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_WinDesc);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache13, true);
		string name11 = "WinDescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_WinDescStrKey);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_WinDescStrKey);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache15, true);
		string name12 = "LoseDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_LoseDesc);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_LoseDesc);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache17, true);
		string name13 = "LoseDescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_LoseDescStrKey);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_LoseDescStrKey);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache19, true);
		string name14 = "Battlefield_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_Battlefield_ID);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_Battlefield_ID);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1B, true);
		string name15 = "CameraX";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_CameraX);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_CameraX);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1D, true);
		string name16 = "CameraY";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_CameraY);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_CameraY);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache1F, true);
		string name17 = "DefendCameraX";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_DefendCameraX);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_DefendCameraX);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache21, true);
		string name18 = "DefendCameraY";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_DefendCameraY);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_DefendCameraY);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache23, true);
		string name19 = "PrepareMusic";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_PrepareMusic);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_PrepareMusic);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache25, true);
		string name20 = "BattleMusic";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_BattleMusic);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_BattleMusic);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache27, true);
		string name21 = "DefendBattleMusic";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_DefendBattleMusic);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_DefendBattleMusic);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache29, true);
		string name22 = "TurnMax";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_TurnMax);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_TurnMax);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2B, true);
		string name23 = "WinConditions_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_WinConditions_ID);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2C, null, true);
		string name24 = "LoseConditions_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_LoseConditions_ID);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2D, null, true);
		string name25 = "EventTriggers_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_EventTriggers_ID);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2E, null, true);
		string name26 = "AttackNumber";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_AttackNumber);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache2F;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_AttackNumber);
		}
		LuaObject.addMember(l, name26, get23, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache30, true);
		string name27 = "AttackPositions";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_AttackPositions);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache31, null, true);
		string name28 = "AttackDirs";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_AttackDirs);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache32, null, true);
		string name29 = "DefendNumber";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_DefendNumber);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache33;
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.set_DefendNumber);
		}
		LuaObject.addMember(l, name29, get24, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache34, true);
		string name30 = "DefendPositions";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_DefendPositions);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache35, null, true);
		string name31 = "DefendDirs";
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.get_DefendDirs);
		}
		LuaObject.addMember(l, name31, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache36, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.<>f__mg$cache37, typeof(ConfigDataPVPBattleInfo));
	}

	// Token: 0x0400D287 RID: 53895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D288 RID: 53896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D289 RID: 53897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D28A RID: 53898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D28B RID: 53899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D28C RID: 53900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D28D RID: 53901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D28E RID: 53902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D28F RID: 53903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D290 RID: 53904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D291 RID: 53905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D292 RID: 53906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D293 RID: 53907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D294 RID: 53908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D295 RID: 53909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D296 RID: 53910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D297 RID: 53911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D298 RID: 53912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D299 RID: 53913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D29A RID: 53914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D29B RID: 53915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D29C RID: 53916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D29D RID: 53917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D29E RID: 53918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D29F RID: 53919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D2A0 RID: 53920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D2A1 RID: 53921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D2A2 RID: 53922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D2A3 RID: 53923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D2A4 RID: 53924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D2A5 RID: 53925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D2A6 RID: 53926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D2A7 RID: 53927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D2A8 RID: 53928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D2A9 RID: 53929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D2AA RID: 53930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D2AB RID: 53931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D2AC RID: 53932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D2AD RID: 53933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D2AE RID: 53934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D2AF RID: 53935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D2B0 RID: 53936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D2B1 RID: 53937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D2B2 RID: 53938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D2B3 RID: 53939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D2B4 RID: 53940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D2B5 RID: 53941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D2B6 RID: 53942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D2B7 RID: 53943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D2B8 RID: 53944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D2B9 RID: 53945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D2BA RID: 53946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D2BB RID: 53947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D2BC RID: 53948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D2BD RID: 53949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400D2BE RID: 53950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
