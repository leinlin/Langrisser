using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001531 RID: 5425
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerSettingUITask : LuaObject
{
	// Token: 0x060204CD RID: 132301 RVA: 0x00ABD1E0 File Offset: 0x00ABB3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			PlayerSettingUITask o = new PlayerSettingUITask(name);
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

	// Token: 0x060204CE RID: 132302 RVA: 0x00ABD234 File Offset: 0x00ABB434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204CF RID: 132303 RVA: 0x00ABD288 File Offset: 0x00ABB488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204D0 RID: 132304 RVA: 0x00ABD2DC File Offset: 0x00ABB4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204D1 RID: 132305 RVA: 0x00ABD330 File Offset: 0x00ABB530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerSettingUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x060204D2 RID: 132306 RVA: 0x00ABD398 File Offset: 0x00ABB598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204D3 RID: 132307 RVA: 0x00ABD3EC File Offset: 0x00ABB5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204D4 RID: 132308 RVA: 0x00ABD440 File Offset: 0x00ABB640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnMusicVolumeChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			float volume;
			LuaObject.checkType(l, 2, out volume);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnMusicVolumeChanged(volume);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204D5 RID: 132309 RVA: 0x00ABD49C File Offset: 0x00ABB69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnSFXVolumeChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			float volume;
			LuaObject.checkType(l, 2, out volume);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnSFXVolumeChanged(volume);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204D6 RID: 132310 RVA: 0x00ABD4F8 File Offset: 0x00ABB6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnVoiceVolumeChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			float volume;
			LuaObject.checkType(l, 2, out volume);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnVoiceVolumeChanged(volume);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204D7 RID: 132311 RVA: 0x00ABD554 File Offset: 0x00ABB754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnBGMIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnBGMIsOn(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204D8 RID: 132312 RVA: 0x00ABD5B0 File Offset: 0x00ABB7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnSoundIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnSoundIsOn(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204D9 RID: 132313 RVA: 0x00ABD60C File Offset: 0x00ABB80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnVoiceIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnVoiceIsOn(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204DA RID: 132314 RVA: 0x00ABD668 File Offset: 0x00ABB868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnEndActionIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnEndActionIsOn(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204DB RID: 132315 RVA: 0x00ABD6C4 File Offset: 0x00ABB8C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnNotifyRecoveryEnergyIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnNotifyRecoveryEnergyIsOn(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204DC RID: 132316 RVA: 0x00ABD720 File Offset: 0x00ABB920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnNotifyRandomEventIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnNotifyRandomEventIsOn(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204DD RID: 132317 RVA: 0x00ABD77C File Offset: 0x00ABB97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnNotifyArenaTicketIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnNotifyArenaTicketIsOn(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204DE RID: 132318 RVA: 0x00ABD7D8 File Offset: 0x00ABB9D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnNotifyStoreRefreshIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnNotifyStoreRefreshIsOn(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204DF RID: 132319 RVA: 0x00ABD834 File Offset: 0x00ABBA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnSetBattleAnimationMode(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			SkipCombatMode mode;
			LuaObject.checkEnum<SkipCombatMode>(l, 2, out mode);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnSetBattleAnimationMode(mode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204E0 RID: 132320 RVA: 0x00ABD890 File Offset: 0x00ABBA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnPowerSaveModeIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUITask.m_luaExportHelper.PlayerSettingUIController_OnPowerSaveModeIsOn(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204E1 RID: 132321 RVA: 0x00ABD8EC File Offset: 0x00ABBAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerSettingUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x060204E2 RID: 132322 RVA: 0x00ABD954 File Offset: 0x00ABBB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204E3 RID: 132323 RVA: 0x00ABD9A8 File Offset: 0x00ABBBA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204E4 RID: 132324 RVA: 0x00ABD9FC File Offset: 0x00ABBBFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerSettingUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x060204E5 RID: 132325 RVA: 0x00ABDA64 File Offset: 0x00ABBC64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerSettingUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x060204E6 RID: 132326 RVA: 0x00ABDACC File Offset: 0x00ABBCCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			playerSettingUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204E7 RID: 132327 RVA: 0x00ABDB38 File Offset: 0x00ABBD38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool b = playerSettingUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x060204E8 RID: 132328 RVA: 0x00ABDB94 File Offset: 0x00ABBD94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			List<string> o = playerSettingUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x060204E9 RID: 132329 RVA: 0x00ABDBF0 File Offset: 0x00ABBDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204EA RID: 132330 RVA: 0x00ABDC44 File Offset: 0x00ABBE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204EB RID: 132331 RVA: 0x00ABDC98 File Offset: 0x00ABBE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204EC RID: 132332 RVA: 0x00ABDCEC File Offset: 0x00ABBEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204ED RID: 132333 RVA: 0x00ABDD40 File Offset: 0x00ABBF40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204EE RID: 132334 RVA: 0x00ABDD94 File Offset: 0x00ABBF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			playerSettingUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204EF RID: 132335 RVA: 0x00ABDDF0 File Offset: 0x00ABBFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			playerSettingUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204F0 RID: 132336 RVA: 0x00ABDE4C File Offset: 0x00ABC04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			playerSettingUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204F1 RID: 132337 RVA: 0x00ABDEA8 File Offset: 0x00ABC0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			playerSettingUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204F2 RID: 132338 RVA: 0x00ABDF04 File Offset: 0x00ABC104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool b = playerSettingUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x060204F3 RID: 132339 RVA: 0x00ABDF60 File Offset: 0x00ABC160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool b = playerSettingUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x060204F4 RID: 132340 RVA: 0x00ABDFBC File Offset: 0x00ABC1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			bool b = playerSettingUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x060204F5 RID: 132341 RVA: 0x00ABE018 File Offset: 0x00ABC218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			UITaskBase o = playerSettingUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x060204F6 RID: 132342 RVA: 0x00ABE074 File Offset: 0x00ABC274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204F7 RID: 132343 RVA: 0x00ABE0C8 File Offset: 0x00ABC2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			playerSettingUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204F8 RID: 132344 RVA: 0x00ABE11C File Offset: 0x00ABC31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204F9 RID: 132345 RVA: 0x00ABE174 File Offset: 0x00ABC374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			playerSettingUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204FA RID: 132346 RVA: 0x00ABE1D0 File Offset: 0x00ABC3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204FB RID: 132347 RVA: 0x00ABE228 File Offset: 0x00ABC428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			playerSettingUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204FC RID: 132348 RVA: 0x00ABE284 File Offset: 0x00ABC484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerSettingUIController(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUITask.m_luaExportHelper.m_playerSettingUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204FD RID: 132349 RVA: 0x00ABE2DC File Offset: 0x00ABC4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerSettingUIController(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			PlayerSettingUIController playerSettingUIController;
			LuaObject.checkType<PlayerSettingUIController>(l, 2, out playerSettingUIController);
			playerSettingUITask.m_luaExportHelper.m_playerSettingUIController = playerSettingUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204FE RID: 132350 RVA: 0x00ABE338 File Offset: 0x00ABC538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204FF RID: 132351 RVA: 0x00ABE390 File Offset: 0x00ABC590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUITask playerSettingUITask = (PlayerSettingUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020500 RID: 132352 RVA: 0x00ABE3E8 File Offset: 0x00ABC5E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerSettingUITask");
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnMusicVolumeChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnSFXVolumeChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnVoiceVolumeChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnBGMIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnSoundIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnVoiceIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnEndActionIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnNotifyRecoveryEnergyIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnNotifyRandomEventIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnNotifyArenaTicketIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnNotifyStoreRefreshIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnSetBattleAnimationMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.PlayerSettingUIController_OnPowerSaveModeIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache29);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2B, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2D, true);
		string name3 = "m_playerSettingUIController";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.get_m_playerSettingUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.set_m_playerSettingUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache2F, true);
		string name4 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache30, null, true);
		string name5 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache31, null, true);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.<>f__mg$cache32, typeof(PlayerSettingUITask), typeof(UITask));
	}

	// Token: 0x0401644D RID: 91213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401644E RID: 91214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401644F RID: 91215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016450 RID: 91216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016451 RID: 91217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016452 RID: 91218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016453 RID: 91219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016454 RID: 91220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016455 RID: 91221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016456 RID: 91222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016457 RID: 91223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016458 RID: 91224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016459 RID: 91225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401645A RID: 91226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401645B RID: 91227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401645C RID: 91228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401645D RID: 91229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401645E RID: 91230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401645F RID: 91231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016460 RID: 91232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016461 RID: 91233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016462 RID: 91234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016463 RID: 91235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016464 RID: 91236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016465 RID: 91237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016466 RID: 91238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016467 RID: 91239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016468 RID: 91240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016469 RID: 91241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401646A RID: 91242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401646B RID: 91243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401646C RID: 91244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401646D RID: 91245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401646E RID: 91246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401646F RID: 91247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016470 RID: 91248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016471 RID: 91249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016472 RID: 91250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016473 RID: 91251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016474 RID: 91252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016475 RID: 91253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016476 RID: 91254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016477 RID: 91255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016478 RID: 91256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016479 RID: 91257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401647A RID: 91258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401647B RID: 91259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401647C RID: 91260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401647D RID: 91261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401647E RID: 91262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401647F RID: 91263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;
}
