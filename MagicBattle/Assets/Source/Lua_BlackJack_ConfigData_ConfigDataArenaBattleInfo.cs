using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001136 RID: 4406
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo : LuaObject
{
	// Token: 0x06016475 RID: 91253 RVA: 0x005DB58C File Offset: 0x005D978C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo o = new ConfigDataArenaBattleInfo();
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

	// Token: 0x06016476 RID: 91254 RVA: 0x005DB5D4 File Offset: 0x005D97D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlefieldInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.m_battlefieldInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016477 RID: 91255 RVA: 0x005DB628 File Offset: 0x005D9828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlefieldInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattlefieldInfo battlefieldInfo;
			LuaObject.checkType<ConfigDataBattlefieldInfo>(l, 2, out battlefieldInfo);
			configDataArenaBattleInfo.m_battlefieldInfo = battlefieldInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016478 RID: 91256 RVA: 0x005DB680 File Offset: 0x005D9880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleEventTriggerInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.m_battleEventTriggerInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016479 RID: 91257 RVA: 0x005DB6D4 File Offset: 0x005D98D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleEventTriggerInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleEventTriggerInfo[] battleEventTriggerInfos;
			LuaObject.checkArray<ConfigDataBattleEventTriggerInfo>(l, 2, out battleEventTriggerInfos);
			configDataArenaBattleInfo.m_battleEventTriggerInfos = battleEventTriggerInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601647A RID: 91258 RVA: 0x005DB72C File Offset: 0x005D992C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601647B RID: 91259 RVA: 0x005DB780 File Offset: 0x005D9980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataArenaBattleInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601647C RID: 91260 RVA: 0x005DB7D8 File Offset: 0x005D99D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601647D RID: 91261 RVA: 0x005DB82C File Offset: 0x005D9A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataArenaBattleInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601647E RID: 91262 RVA: 0x005DB884 File Offset: 0x005D9A84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601647F RID: 91263 RVA: 0x005DB8D8 File Offset: 0x005D9AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataArenaBattleInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016480 RID: 91264 RVA: 0x005DB930 File Offset: 0x005D9B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016481 RID: 91265 RVA: 0x005DB984 File Offset: 0x005D9B84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataArenaBattleInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016482 RID: 91266 RVA: 0x005DB9DC File Offset: 0x005D9BDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016483 RID: 91267 RVA: 0x005DBA30 File Offset: 0x005D9C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataArenaBattleInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016484 RID: 91268 RVA: 0x005DBA88 File Offset: 0x005D9C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Battlefield_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.Battlefield_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016485 RID: 91269 RVA: 0x005DBADC File Offset: 0x005D9CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battlefield_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			int battlefield_ID;
			LuaObject.checkType(l, 2, out battlefield_ID);
			configDataArenaBattleInfo.Battlefield_ID = battlefield_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016486 RID: 91270 RVA: 0x005DBB34 File Offset: 0x005D9D34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.CameraX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016487 RID: 91271 RVA: 0x005DBB88 File Offset: 0x005D9D88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			int cameraX;
			LuaObject.checkType(l, 2, out cameraX);
			configDataArenaBattleInfo.CameraX = cameraX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016488 RID: 91272 RVA: 0x005DBBE0 File Offset: 0x005D9DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.CameraY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016489 RID: 91273 RVA: 0x005DBC34 File Offset: 0x005D9E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			int cameraY;
			LuaObject.checkType(l, 2, out cameraY);
			configDataArenaBattleInfo.CameraY = cameraY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601648A RID: 91274 RVA: 0x005DBC8C File Offset: 0x005D9E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendCameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.DefendCameraX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601648B RID: 91275 RVA: 0x005DBCE0 File Offset: 0x005D9EE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefendCameraX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			int defendCameraX;
			LuaObject.checkType(l, 2, out defendCameraX);
			configDataArenaBattleInfo.DefendCameraX = defendCameraX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601648C RID: 91276 RVA: 0x005DBD38 File Offset: 0x005D9F38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefendCameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.DefendCameraY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601648D RID: 91277 RVA: 0x005DBD8C File Offset: 0x005D9F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefendCameraY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			int defendCameraY;
			LuaObject.checkType(l, 2, out defendCameraY);
			configDataArenaBattleInfo.DefendCameraY = defendCameraY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601648E RID: 91278 RVA: 0x005DBDE4 File Offset: 0x005D9FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PrepareMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.PrepareMusic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601648F RID: 91279 RVA: 0x005DBE38 File Offset: 0x005DA038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PrepareMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			string prepareMusic;
			LuaObject.checkType(l, 2, out prepareMusic);
			configDataArenaBattleInfo.PrepareMusic = prepareMusic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016490 RID: 91280 RVA: 0x005DBE90 File Offset: 0x005DA090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.BattleMusic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016491 RID: 91281 RVA: 0x005DBEE4 File Offset: 0x005DA0E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			string battleMusic;
			LuaObject.checkType(l, 2, out battleMusic);
			configDataArenaBattleInfo.BattleMusic = battleMusic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016492 RID: 91282 RVA: 0x005DBF3C File Offset: 0x005DA13C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefendBattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.DefendBattleMusic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016493 RID: 91283 RVA: 0x005DBF90 File Offset: 0x005DA190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefendBattleMusic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			string defendBattleMusic;
			LuaObject.checkType(l, 2, out defendBattleMusic);
			configDataArenaBattleInfo.DefendBattleMusic = defendBattleMusic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016494 RID: 91284 RVA: 0x005DBFE8 File Offset: 0x005DA1E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.AttackNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016495 RID: 91285 RVA: 0x005DC03C File Offset: 0x005DA23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AttackNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			int attackNumber;
			LuaObject.checkType(l, 2, out attackNumber);
			configDataArenaBattleInfo.AttackNumber = attackNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016496 RID: 91286 RVA: 0x005DC094 File Offset: 0x005DA294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AttackPositions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.AttackPositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016497 RID: 91287 RVA: 0x005DC0E8 File Offset: 0x005DA2E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackDirs(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.AttackDirs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016498 RID: 91288 RVA: 0x005DC13C File Offset: 0x005DA33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.DefendNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016499 RID: 91289 RVA: 0x005DC190 File Offset: 0x005DA390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefendNumber(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			int defendNumber;
			LuaObject.checkType(l, 2, out defendNumber);
			configDataArenaBattleInfo.DefendNumber = defendNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601649A RID: 91290 RVA: 0x005DC1E8 File Offset: 0x005DA3E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefendPositions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.DefendPositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601649B RID: 91291 RVA: 0x005DC23C File Offset: 0x005DA43C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefendDirs(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.DefendDirs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601649C RID: 91292 RVA: 0x005DC290 File Offset: 0x005DA490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EventTriggers_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.EventTriggers_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601649D RID: 91293 RVA: 0x005DC2E4 File Offset: 0x005DA4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Image(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaBattleInfo.Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601649E RID: 91294 RVA: 0x005DC338 File Offset: 0x005DA538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Image(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = (ConfigDataArenaBattleInfo)LuaObject.checkSelf(l);
			string image;
			LuaObject.checkType(l, 2, out image);
			configDataArenaBattleInfo.Image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601649F RID: 91295 RVA: 0x005DC390 File Offset: 0x005DA590
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataArenaBattleInfo");
		string name = "m_battlefieldInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_m_battlefieldInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_m_battlefieldInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1, true);
		string name2 = "m_battleEventTriggerInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_m_battleEventTriggerInfos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_m_battleEventTriggerInfos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache3, true);
		string name3 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache5, true);
		string name4 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_Name);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_Name);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache7, true);
		string name5 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_NameStrKey);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache9, true);
		string name6 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_Desc);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_Desc);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheB, true);
		string name7 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_DescStrKey);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheD, true);
		string name8 = "Battlefield_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_Battlefield_ID);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_Battlefield_ID);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cacheF, true);
		string name9 = "CameraX";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_CameraX);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_CameraX);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache11, true);
		string name10 = "CameraY";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_CameraY);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_CameraY);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache13, true);
		string name11 = "DefendCameraX";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_DefendCameraX);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_DefendCameraX);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache15, true);
		string name12 = "DefendCameraY";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_DefendCameraY);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_DefendCameraY);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache17, true);
		string name13 = "PrepareMusic";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_PrepareMusic);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_PrepareMusic);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache19, true);
		string name14 = "BattleMusic";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_BattleMusic);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_BattleMusic);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1B, true);
		string name15 = "DefendBattleMusic";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_DefendBattleMusic);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_DefendBattleMusic);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1D, true);
		string name16 = "AttackNumber";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_AttackNumber);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_AttackNumber);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache1F, true);
		string name17 = "AttackPositions";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_AttackPositions);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache20, null, true);
		string name18 = "AttackDirs";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_AttackDirs);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache21, null, true);
		string name19 = "DefendNumber";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_DefendNumber);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_DefendNumber);
		}
		LuaObject.addMember(l, name19, get17, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache23, true);
		string name20 = "DefendPositions";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_DefendPositions);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache24, null, true);
		string name21 = "DefendDirs";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_DefendDirs);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache25, null, true);
		string name22 = "EventTriggers_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_EventTriggers_ID);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache26, null, true);
		string name23 = "Image";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.get_Image);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache27;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.set_Image);
		}
		LuaObject.addMember(l, name23, get18, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache28, true);
		if (Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.<>f__mg$cache29, typeof(ConfigDataArenaBattleInfo));
	}

	// Token: 0x0400CBEB RID: 52203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CBEC RID: 52204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CBED RID: 52205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CBEE RID: 52206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CBEF RID: 52207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CBF0 RID: 52208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CBF1 RID: 52209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CBF2 RID: 52210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CBF3 RID: 52211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CBF4 RID: 52212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CBF5 RID: 52213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CBF6 RID: 52214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CBF7 RID: 52215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CBF8 RID: 52216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CBF9 RID: 52217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CBFA RID: 52218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CBFB RID: 52219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CBFC RID: 52220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CBFD RID: 52221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CBFE RID: 52222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CBFF RID: 52223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CC00 RID: 52224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CC01 RID: 52225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CC02 RID: 52226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CC03 RID: 52227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CC04 RID: 52228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CC05 RID: 52229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CC06 RID: 52230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CC07 RID: 52231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CC08 RID: 52232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CC09 RID: 52233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CC0A RID: 52234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CC0B RID: 52235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CC0C RID: 52236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CC0D RID: 52237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CC0E RID: 52238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CC0F RID: 52239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CC10 RID: 52240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CC11 RID: 52241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CC12 RID: 52242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CC13 RID: 52243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400CC14 RID: 52244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
