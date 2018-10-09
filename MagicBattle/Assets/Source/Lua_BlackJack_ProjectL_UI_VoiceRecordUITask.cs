using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020015DE RID: 5598
[Preserve]
public class Lua_BlackJack_ProjectL_UI_VoiceRecordUITask : LuaObject
{
	// Token: 0x060222E6 RID: 140006 RVA: 0x00BAC4E8 File Offset: 0x00BAA6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			VoiceRecordUITask o = new VoiceRecordUITask(name);
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

	// Token: 0x060222E7 RID: 140007 RVA: 0x00BAC53C File Offset: 0x00BAA73C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartVoiceRecordUITask_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject btnObj;
			LuaObject.checkType<GameObject>(l, 1, out btnObj);
			ChatChannel channelType;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channelType);
			VoiceRecordUITask o = VoiceRecordUITask.StartVoiceRecordUITask(btnObj, channelType);
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

	// Token: 0x060222E8 RID: 140008 RVA: 0x00BAC59C File Offset: 0x00BAA79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = voiceRecordUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x060222E9 RID: 140009 RVA: 0x00BAC604 File Offset: 0x00BAA804
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = voiceRecordUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x060222EA RID: 140010 RVA: 0x00BAC66C File Offset: 0x00BAA86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222EB RID: 140011 RVA: 0x00BAC6C0 File Offset: 0x00BAA8C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222EC RID: 140012 RVA: 0x00BAC714 File Offset: 0x00BAA914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDataFromIntent(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			voiceRecordUITask.m_luaExportHelper.GetDataFromIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222ED RID: 140013 RVA: 0x00BAC770 File Offset: 0x00BAA970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222EE RID: 140014 RVA: 0x00BAC7C4 File Offset: 0x00BAA9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222EF RID: 140015 RVA: 0x00BAC818 File Offset: 0x00BAAA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RequestMicrophonePermission(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			IEnumerator o = voiceRecordUITask.m_luaExportHelper.RequestMicrophonePermission();
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

	// Token: 0x060222F0 RID: 140016 RVA: 0x00BAC874 File Offset: 0x00BAAA74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222F1 RID: 140017 RVA: 0x00BAC8C8 File Offset: 0x00BAAAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTalkButtonHold(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.OnTalkButtonHold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222F2 RID: 140018 RVA: 0x00BAC91C File Offset: 0x00BAAB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTalkButtonClickUp(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.OnTalkButtonClickUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222F3 RID: 140019 RVA: 0x00BAC970 File Offset: 0x00BAAB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExitTalkButton(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.OnExitTalkButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222F4 RID: 140020 RVA: 0x00BAC9C4 File Offset: 0x00BAABC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnterTalkButton(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.OnEnterTalkButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222F5 RID: 140021 RVA: 0x00BACA18 File Offset: 0x00BAAC18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnVoiceRecordTimeout(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			voiceRecordUITask.m_luaExportHelper.OnVoiceRecordTimeout(channel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222F6 RID: 140022 RVA: 0x00BACA74 File Offset: 0x00BAAC74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickForVoiceRecordTime(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.TickForVoiceRecordTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222F7 RID: 140023 RVA: 0x00BACAC8 File Offset: 0x00BAACC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = voiceRecordUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x060222F8 RID: 140024 RVA: 0x00BACB30 File Offset: 0x00BAAD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222F9 RID: 140025 RVA: 0x00BACB84 File Offset: 0x00BAAD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222FA RID: 140026 RVA: 0x00BACBD8 File Offset: 0x00BAADD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = voiceRecordUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x060222FB RID: 140027 RVA: 0x00BACC40 File Offset: 0x00BAAE40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = voiceRecordUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x060222FC RID: 140028 RVA: 0x00BACCA8 File Offset: 0x00BAAEA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			voiceRecordUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060222FD RID: 140029 RVA: 0x00BACD14 File Offset: 0x00BAAF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			bool b = voiceRecordUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x060222FE RID: 140030 RVA: 0x00BACD70 File Offset: 0x00BAAF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			List<string> o = voiceRecordUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x060222FF RID: 140031 RVA: 0x00BACDCC File Offset: 0x00BAAFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022300 RID: 140032 RVA: 0x00BACE20 File Offset: 0x00BAB020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022301 RID: 140033 RVA: 0x00BACE74 File Offset: 0x00BAB074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022302 RID: 140034 RVA: 0x00BACEC8 File Offset: 0x00BAB0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022303 RID: 140035 RVA: 0x00BACF1C File Offset: 0x00BAB11C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022304 RID: 140036 RVA: 0x00BACF70 File Offset: 0x00BAB170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			voiceRecordUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022305 RID: 140037 RVA: 0x00BACFCC File Offset: 0x00BAB1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			voiceRecordUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022306 RID: 140038 RVA: 0x00BAD028 File Offset: 0x00BAB228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			voiceRecordUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022307 RID: 140039 RVA: 0x00BAD084 File Offset: 0x00BAB284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			voiceRecordUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022308 RID: 140040 RVA: 0x00BAD0E0 File Offset: 0x00BAB2E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			bool b = voiceRecordUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06022309 RID: 140041 RVA: 0x00BAD13C File Offset: 0x00BAB33C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			bool b = voiceRecordUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0602230A RID: 140042 RVA: 0x00BAD198 File Offset: 0x00BAB398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			bool b = voiceRecordUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0602230B RID: 140043 RVA: 0x00BAD1F4 File Offset: 0x00BAB3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			UITaskBase o = voiceRecordUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0602230C RID: 140044 RVA: 0x00BAD250 File Offset: 0x00BAB450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602230D RID: 140045 RVA: 0x00BAD2A4 File Offset: 0x00BAB4A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			voiceRecordUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602230E RID: 140046 RVA: 0x00BAD2F8 File Offset: 0x00BAB4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_TalkBtnObj(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUITask.m_luaExportHelper.m_TalkBtnObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602230F RID: 140047 RVA: 0x00BAD350 File Offset: 0x00BAB550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_TalkBtnObj(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			GameObject talkBtnObj;
			LuaObject.checkType<GameObject>(l, 2, out talkBtnObj);
			voiceRecordUITask.m_luaExportHelper.m_TalkBtnObj = talkBtnObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022310 RID: 140048 RVA: 0x00BAD3AC File Offset: 0x00BAB5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isTalkButtonDown(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUITask.m_luaExportHelper.m_isTalkButtonDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022311 RID: 140049 RVA: 0x00BAD404 File Offset: 0x00BAB604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isTalkButtonDown(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			bool isTalkButtonDown;
			LuaObject.checkType(l, 2, out isTalkButtonDown);
			voiceRecordUITask.m_luaExportHelper.m_isTalkButtonDown = isTalkButtonDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022312 RID: 140050 RVA: 0x00BAD460 File Offset: 0x00BAB660
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isExitTalkButtonRect(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUITask.m_luaExportHelper.m_isExitTalkButtonRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022313 RID: 140051 RVA: 0x00BAD4B8 File Offset: 0x00BAB6B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isExitTalkButtonRect(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			bool isExitTalkButtonRect;
			LuaObject.checkType(l, 2, out isExitTalkButtonRect);
			voiceRecordUITask.m_luaExportHelper.m_isExitTalkButtonRect = isExitTalkButtonRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022314 RID: 140052 RVA: 0x00BAD514 File Offset: 0x00BAB714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerCtx(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUITask.m_luaExportHelper.m_playerCtx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022315 RID: 140053 RVA: 0x00BAD56C File Offset: 0x00BAB76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerCtx(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerCtx;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerCtx);
			voiceRecordUITask.m_luaExportHelper.m_playerCtx = playerCtx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022316 RID: 140054 RVA: 0x00BAD5C8 File Offset: 0x00BAB7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentTableType(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)voiceRecordUITask.m_luaExportHelper.m_currentTableType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022317 RID: 140055 RVA: 0x00BAD620 File Offset: 0x00BAB820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentTableType(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			ChatChannel currentTableType;
			LuaObject.checkEnum<ChatChannel>(l, 2, out currentTableType);
			voiceRecordUITask.m_luaExportHelper.m_currentTableType = currentTableType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022318 RID: 140056 RVA: 0x00BAD67C File Offset: 0x00BAB87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_VoiceUICtrl(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUITask.m_luaExportHelper.m_VoiceUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022319 RID: 140057 RVA: 0x00BAD6D4 File Offset: 0x00BAB8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_VoiceUICtrl(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			VoiceRecordUIController voiceUICtrl;
			LuaObject.checkType<VoiceRecordUIController>(l, 2, out voiceUICtrl);
			voiceRecordUITask.m_luaExportHelper.m_VoiceUICtrl = voiceUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602231A RID: 140058 RVA: 0x00BAD730 File Offset: 0x00BAB930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602231B RID: 140059 RVA: 0x00BAD788 File Offset: 0x00BAB988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			voiceRecordUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602231C RID: 140060 RVA: 0x00BAD7E4 File Offset: 0x00BAB9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602231D RID: 140061 RVA: 0x00BAD83C File Offset: 0x00BABA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			voiceRecordUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602231E RID: 140062 RVA: 0x00BAD898 File Offset: 0x00BABA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602231F RID: 140063 RVA: 0x00BAD8F0 File Offset: 0x00BABAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			VoiceRecordUITask voiceRecordUITask = (VoiceRecordUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voiceRecordUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022320 RID: 140064 RVA: 0x00BAD948 File Offset: 0x00BABB48
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.VoiceRecordUITask");
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.StartVoiceRecordUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.GetDataFromIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.RequestMicrophonePermission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.OnTalkButtonHold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.OnTalkButtonClickUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.OnExitTalkButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.OnEnterTalkButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.OnVoiceRecordTimeout);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.TickForVoiceRecordTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache26);
		string name = "m_TalkBtnObj";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.get_m_TalkBtnObj);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.set_m_TalkBtnObj);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache28, true);
		string name2 = "m_isTalkButtonDown";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.get_m_isTalkButtonDown);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.set_m_isTalkButtonDown);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2A, true);
		string name3 = "m_isExitTalkButtonRect";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.get_m_isExitTalkButtonRect);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.set_m_isExitTalkButtonRect);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2C, true);
		string name4 = "m_playerCtx";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.get_m_playerCtx);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.set_m_playerCtx);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2E, true);
		string name5 = "m_currentTableType";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.get_m_currentTableType);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.set_m_currentTableType);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache30, true);
		string name6 = "m_VoiceUICtrl";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.get_m_VoiceUICtrl);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.set_m_VoiceUICtrl);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache32, true);
		string name7 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.get_m_layerDescArray);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache34, true);
		string name8 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache36, true);
		string name9 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache37, null, true);
		string name10 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache38, null, true);
		if (Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.<>f__mg$cache39, typeof(VoiceRecordUITask), typeof(UITask));
	}

	// Token: 0x0401810C RID: 98572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401810D RID: 98573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401810E RID: 98574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401810F RID: 98575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018110 RID: 98576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018111 RID: 98577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018112 RID: 98578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018113 RID: 98579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018114 RID: 98580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018115 RID: 98581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018116 RID: 98582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018117 RID: 98583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018118 RID: 98584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018119 RID: 98585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401811A RID: 98586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401811B RID: 98587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401811C RID: 98588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401811D RID: 98589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401811E RID: 98590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401811F RID: 98591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018120 RID: 98592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018121 RID: 98593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018122 RID: 98594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018123 RID: 98595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018124 RID: 98596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018125 RID: 98597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018126 RID: 98598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018127 RID: 98599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018128 RID: 98600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018129 RID: 98601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401812A RID: 98602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401812B RID: 98603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401812C RID: 98604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401812D RID: 98605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401812E RID: 98606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401812F RID: 98607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04018130 RID: 98608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04018131 RID: 98609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04018132 RID: 98610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04018133 RID: 98611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04018134 RID: 98612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04018135 RID: 98613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04018136 RID: 98614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04018137 RID: 98615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04018138 RID: 98616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04018139 RID: 98617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401813A RID: 98618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401813B RID: 98619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401813C RID: 98620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401813D RID: 98621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401813E RID: 98622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401813F RID: 98623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04018140 RID: 98624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04018141 RID: 98625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04018142 RID: 98626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04018143 RID: 98627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04018144 RID: 98628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04018145 RID: 98629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;
}
