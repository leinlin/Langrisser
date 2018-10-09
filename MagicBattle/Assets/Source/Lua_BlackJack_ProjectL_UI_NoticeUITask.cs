using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001519 RID: 5401
[Preserve]
public class Lua_BlackJack_ProjectL_UI_NoticeUITask : LuaObject
{
	// Token: 0x06020081 RID: 131201 RVA: 0x00A9A8EC File Offset: 0x00A98AEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			NoticeUITask o = new NoticeUITask(name);
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

	// Token: 0x06020082 RID: 131202 RVA: 0x00A9A940 File Offset: 0x00A98B40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			noticeUITask.EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020083 RID: 131203 RVA: 0x00A9A9A4 File Offset: 0x00A98BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = noticeUITask.OnNewIntent(intent);
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

	// Token: 0x06020084 RID: 131204 RVA: 0x00A9AA08 File Offset: 0x00A98C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdatePositionState(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.UpdatePositionState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020085 RID: 131205 RVA: 0x00A9AA54 File Offset: 0x00A98C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			string contentStr;
			LuaObject.checkType(l, 1, out contentStr);
			string uiStateName;
			LuaObject.checkType(l, 2, out uiStateName);
			ChatChannel chatChannel;
			LuaObject.checkEnum<ChatChannel>(l, 3, out chatChannel);
			bool isVoiceMsg;
			LuaObject.checkType(l, 4, out isVoiceMsg);
			NoticeUITask.StartUITask(contentStr, uiStateName, chatChannel, isVoiceMsg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020086 RID: 131206 RVA: 0x00A9AAC4 File Offset: 0x00A98CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = noticeUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x06020087 RID: 131207 RVA: 0x00A9AB2C File Offset: 0x00A98D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020088 RID: 131208 RVA: 0x00A9AB80 File Offset: 0x00A98D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020089 RID: 131209 RVA: 0x00A9ABD4 File Offset: 0x00A98DD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602008A RID: 131210 RVA: 0x00A9AC28 File Offset: 0x00A98E28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = noticeUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0602008B RID: 131211 RVA: 0x00A9AC90 File Offset: 0x00A98E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			noticeUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602008C RID: 131212 RVA: 0x00A9ACEC File Offset: 0x00A98EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NoticeUIController_OnNoticeClick(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			NoticeText currentNoticeText;
			LuaObject.checkType<NoticeText>(l, 2, out currentNoticeText);
			noticeUITask.m_luaExportHelper.NoticeUIController_OnNoticeClick(currentNoticeText);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602008D RID: 131213 RVA: 0x00A9AD48 File Offset: 0x00A98F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602008E RID: 131214 RVA: 0x00A9AD9C File Offset: 0x00A98F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = noticeUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0602008F RID: 131215 RVA: 0x00A9AE04 File Offset: 0x00A99004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020090 RID: 131216 RVA: 0x00A9AE58 File Offset: 0x00A99058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020091 RID: 131217 RVA: 0x00A9AEAC File Offset: 0x00A990AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = noticeUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06020092 RID: 131218 RVA: 0x00A9AF14 File Offset: 0x00A99114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = noticeUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06020093 RID: 131219 RVA: 0x00A9AF7C File Offset: 0x00A9917C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			noticeUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020094 RID: 131220 RVA: 0x00A9AFE8 File Offset: 0x00A991E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			bool b = noticeUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06020095 RID: 131221 RVA: 0x00A9B044 File Offset: 0x00A99244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			List<string> o = noticeUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06020096 RID: 131222 RVA: 0x00A9B0A0 File Offset: 0x00A992A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020097 RID: 131223 RVA: 0x00A9B0F4 File Offset: 0x00A992F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020098 RID: 131224 RVA: 0x00A9B148 File Offset: 0x00A99348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020099 RID: 131225 RVA: 0x00A9B19C File Offset: 0x00A9939C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602009A RID: 131226 RVA: 0x00A9B1F0 File Offset: 0x00A993F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602009B RID: 131227 RVA: 0x00A9B244 File Offset: 0x00A99444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			noticeUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602009C RID: 131228 RVA: 0x00A9B2A0 File Offset: 0x00A994A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			noticeUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602009D RID: 131229 RVA: 0x00A9B2FC File Offset: 0x00A994FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			noticeUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602009E RID: 131230 RVA: 0x00A9B358 File Offset: 0x00A99558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			noticeUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602009F RID: 131231 RVA: 0x00A9B3B4 File Offset: 0x00A995B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			bool b = noticeUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x060200A0 RID: 131232 RVA: 0x00A9B410 File Offset: 0x00A99610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			bool b = noticeUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x060200A1 RID: 131233 RVA: 0x00A9B46C File Offset: 0x00A9966C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			bool b = noticeUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x060200A2 RID: 131234 RVA: 0x00A9B4C8 File Offset: 0x00A996C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			UITaskBase o = noticeUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x060200A3 RID: 131235 RVA: 0x00A9B524 File Offset: 0x00A99724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200A4 RID: 131236 RVA: 0x00A9B578 File Offset: 0x00A99778
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			noticeUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200A5 RID: 131237 RVA: 0x00A9B5CC File Offset: 0x00A997CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentNoticeInfo(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUITask.m_luaExportHelper.m_currentNoticeInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200A6 RID: 131238 RVA: 0x00A9B624 File Offset: 0x00A99824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_currentNoticeInfo(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			string currentNoticeInfo;
			LuaObject.checkType(l, 2, out currentNoticeInfo);
			noticeUITask.m_luaExportHelper.m_currentNoticeInfo = currentNoticeInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200A7 RID: 131239 RVA: 0x00A9B680 File Offset: 0x00A99880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentNoticeStateName(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUITask.m_luaExportHelper.m_currentNoticeStateName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200A8 RID: 131240 RVA: 0x00A9B6D8 File Offset: 0x00A998D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentNoticeStateName(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			string currentNoticeStateName;
			LuaObject.checkType(l, 2, out currentNoticeStateName);
			noticeUITask.m_luaExportHelper.m_currentNoticeStateName = currentNoticeStateName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200A9 RID: 131241 RVA: 0x00A9B734 File Offset: 0x00A99934
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_chatChannel(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)noticeUITask.m_luaExportHelper.m_chatChannel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200AA RID: 131242 RVA: 0x00A9B78C File Offset: 0x00A9998C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_chatChannel(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			ChatChannel chatChannel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out chatChannel);
			noticeUITask.m_luaExportHelper.m_chatChannel = chatChannel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200AB RID: 131243 RVA: 0x00A9B7E8 File Offset: 0x00A999E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentNoticeIsVoice(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUITask.m_luaExportHelper.m_currentNoticeIsVoice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200AC RID: 131244 RVA: 0x00A9B840 File Offset: 0x00A99A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentNoticeIsVoice(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			bool currentNoticeIsVoice;
			LuaObject.checkType(l, 2, out currentNoticeIsVoice);
			noticeUITask.m_luaExportHelper.m_currentNoticeIsVoice = currentNoticeIsVoice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200AD RID: 131245 RVA: 0x00A9B89C File Offset: 0x00A99A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeUICtrl(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUITask.m_luaExportHelper.m_noticeUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200AE RID: 131246 RVA: 0x00A9B8F4 File Offset: 0x00A99AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeUICtrl(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			NoticeUIController noticeUICtrl;
			LuaObject.checkType<NoticeUIController>(l, 2, out noticeUICtrl);
			noticeUITask.m_luaExportHelper.m_noticeUICtrl = noticeUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200AF RID: 131247 RVA: 0x00A9B950 File Offset: 0x00A99B50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ParamKey_NoticeInfo(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, NoticeUITask.ParamKey_NoticeInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200B0 RID: 131248 RVA: 0x00A9B998 File Offset: 0x00A99B98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ParamKey_NoticeStateName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, NoticeUITask.ParamKey_NoticeStateName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200B1 RID: 131249 RVA: 0x00A9B9E0 File Offset: 0x00A99BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_NoticeChatChannel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, NoticeUITask.ParamKey_NoticeChatChannel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200B2 RID: 131250 RVA: 0x00A9BA28 File Offset: 0x00A99C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_NoticeIsVoice(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, NoticeUITask.ParamKey_NoticeIsVoice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200B3 RID: 131251 RVA: 0x00A9BA70 File Offset: 0x00A99C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isEnableClick(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, NoticeUITask.m_isEnableClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200B4 RID: 131252 RVA: 0x00A9BAB8 File Offset: 0x00A99CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isEnableClick(IntPtr l)
	{
		int result;
		try
		{
			bool isEnableClick;
			LuaObject.checkType(l, 2, out isEnableClick);
			NoticeUITask.m_isEnableClick = isEnableClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200B5 RID: 131253 RVA: 0x00A9BB04 File Offset: 0x00A99D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200B6 RID: 131254 RVA: 0x00A9BB5C File Offset: 0x00A99D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			noticeUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200B7 RID: 131255 RVA: 0x00A9BBB8 File Offset: 0x00A99DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200B8 RID: 131256 RVA: 0x00A9BC10 File Offset: 0x00A99E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			noticeUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200B9 RID: 131257 RVA: 0x00A9BC6C File Offset: 0x00A99E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200BA RID: 131258 RVA: 0x00A9BCC4 File Offset: 0x00A99EC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			NoticeUITask noticeUITask = (NoticeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060200BB RID: 131259 RVA: 0x00A9BD1C File Offset: 0x00A99F1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.NoticeUITask");
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.UpdatePositionState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.NoticeUIController_OnNoticeClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache22);
		string name = "m_currentNoticeInfo";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_m_currentNoticeInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.set_m_currentNoticeInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache24, true);
		string name2 = "m_currentNoticeStateName";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_m_currentNoticeStateName);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.set_m_currentNoticeStateName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache26, true);
		string name3 = "m_chatChannel";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_m_chatChannel);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.set_m_chatChannel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache28, true);
		string name4 = "m_currentNoticeIsVoice";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_m_currentNoticeIsVoice);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.set_m_currentNoticeIsVoice);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2A, true);
		string name5 = "m_noticeUICtrl";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_m_noticeUICtrl);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.set_m_noticeUICtrl);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2C, true);
		string name6 = "ParamKey_NoticeInfo";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_ParamKey_NoticeInfo);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2D, null, false);
		string name7 = "ParamKey_NoticeStateName";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_ParamKey_NoticeStateName);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2E, null, false);
		string name8 = "ParamKey_NoticeChatChannel";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_ParamKey_NoticeChatChannel);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache2F, null, false);
		string name9 = "ParamKey_NoticeIsVoice";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_ParamKey_NoticeIsVoice);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache30, null, false);
		string name10 = "m_isEnableClick";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_m_isEnableClick);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.set_m_isEnableClick);
		}
		LuaObject.addMember(l, name10, get6, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache32, false);
		string name11 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_m_layerDescArray);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name11, get7, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache34, true);
		string name12 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name12, get8, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache36, true);
		string name13 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache37, null, true);
		string name14 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache38, null, true);
		if (Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_NoticeUITask.<>f__mg$cache39, typeof(NoticeUITask), typeof(UITask));
	}

	// Token: 0x04016031 RID: 90161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016032 RID: 90162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016033 RID: 90163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016034 RID: 90164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016035 RID: 90165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016036 RID: 90166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016037 RID: 90167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016038 RID: 90168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016039 RID: 90169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401603A RID: 90170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401603B RID: 90171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401603C RID: 90172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401603D RID: 90173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401603E RID: 90174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401603F RID: 90175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016040 RID: 90176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016041 RID: 90177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016042 RID: 90178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016043 RID: 90179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016044 RID: 90180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016045 RID: 90181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016046 RID: 90182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016047 RID: 90183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016048 RID: 90184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016049 RID: 90185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401604A RID: 90186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401604B RID: 90187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401604C RID: 90188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401604D RID: 90189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401604E RID: 90190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401604F RID: 90191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016050 RID: 90192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016051 RID: 90193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016052 RID: 90194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016053 RID: 90195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016054 RID: 90196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016055 RID: 90197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016056 RID: 90198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016057 RID: 90199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016058 RID: 90200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016059 RID: 90201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401605A RID: 90202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401605B RID: 90203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401605C RID: 90204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401605D RID: 90205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401605E RID: 90206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401605F RID: 90207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016060 RID: 90208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016061 RID: 90209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016062 RID: 90210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016063 RID: 90211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016064 RID: 90212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016065 RID: 90213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016066 RID: 90214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016067 RID: 90215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016068 RID: 90216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016069 RID: 90217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401606A RID: 90218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;
}
