using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020013EE RID: 5102
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChatUITask : LuaObject
{
	// Token: 0x0601CA26 RID: 117286 RVA: 0x008EA6A0 File Offset: 0x008E88A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			ChatUITask o = new ChatUITask(name);
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

	// Token: 0x0601CA27 RID: 117287 RVA: 0x008EA6F4 File Offset: 0x008E88F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSmallExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			SmallExpressionItemContrller ctrl;
			LuaObject.checkType<SmallExpressionItemContrller>(l, 2, out ctrl);
			chatUITask.OnSmallExpressionClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA28 RID: 117288 RVA: 0x008EA74C File Offset: 0x008E894C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRoomIdInputEnd(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			chatUITask.OnRoomIdInputEnd(content);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA29 RID: 117289 RVA: 0x008EA7A4 File Offset: 0x008E89A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartChatUITaskWithNormalMode_s(IntPtr l)
	{
		int result;
		try
		{
			UIIntent returnToIntent;
			LuaObject.checkType<UIIntent>(l, 1, out returnToIntent);
			ChatUITask o = ChatUITask.StartChatUITaskWithNormalMode(returnToIntent);
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

	// Token: 0x0601CA2A RID: 117290 RVA: 0x008EA7F8 File Offset: 0x008E89F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartChatUITaskToEnterAppointChannel_s(IntPtr l)
	{
		int result;
		try
		{
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 1, out channel);
			UIIntent returnToIntent;
			LuaObject.checkType<UIIntent>(l, 2, out returnToIntent);
			string id;
			LuaObject.checkType(l, 3, out id);
			ChatUITask o = ChatUITask.StartChatUITaskToEnterAppointChannel(channel, returnToIntent, id);
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

	// Token: 0x0601CA2B RID: 117291 RVA: 0x008EA868 File Offset: 0x008E8A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PauseUITask_s(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask.PauseUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA2C RID: 117292 RVA: 0x008EA8A8 File Offset: 0x008E8AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = chatUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601CA2D RID: 117293 RVA: 0x008EA910 File Offset: 0x008E8B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPause(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA2E RID: 117294 RVA: 0x008EA964 File Offset: 0x008E8B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA2F RID: 117295 RVA: 0x008EA9B8 File Offset: 0x008E8BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = chatUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601CA30 RID: 117296 RVA: 0x008EAA20 File Offset: 0x008E8C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetChatTargetInfoEndFroResume(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = chatUITask.m_luaExportHelper.OnGetChatTargetInfoEndFroResume(intent);
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

	// Token: 0x0601CA31 RID: 117297 RVA: 0x008EAA88 File Offset: 0x008E8C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA32 RID: 117298 RVA: 0x008EAADC File Offset: 0x008E8CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA33 RID: 117299 RVA: 0x008EAB30 File Offset: 0x008E8D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA34 RID: 117300 RVA: 0x008EAB84 File Offset: 0x008E8D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedUpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			bool b = chatUITask.m_luaExportHelper.IsNeedUpdateDataCache();
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

	// Token: 0x0601CA35 RID: 117301 RVA: 0x008EABE0 File Offset: 0x008E8DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.UpdateDataCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA36 RID: 117302 RVA: 0x008EAC34 File Offset: 0x008E8E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RequestMicrophonePermission(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			IEnumerator o = chatUITask.m_luaExportHelper.RequestMicrophonePermission();
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

	// Token: 0x0601CA37 RID: 117303 RVA: 0x008EAC90 File Offset: 0x008E8E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA38 RID: 117304 RVA: 0x008EACE4 File Offset: 0x008E8EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			bool b = chatUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601CA39 RID: 117305 RVA: 0x008EAD40 File Offset: 0x008E8F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExpressionBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.OnExpressionBgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA3A RID: 117306 RVA: 0x008EAD94 File Offset: 0x008E8F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExpressionFunctionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.OnExpressionFunctionButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA3B RID: 117307 RVA: 0x008EADE8 File Offset: 0x008E8FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemVoiceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient voiceInfo;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out voiceInfo);
			chatUITask.m_luaExportHelper.OnItemVoiceButtonClick(voiceInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA3C RID: 117308 RVA: 0x008EAE44 File Offset: 0x008E9044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayerIconClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatMessage chatInfo;
			LuaObject.checkType<ChatMessage>(l, 2, out chatInfo);
			GameObject playerIcon;
			LuaObject.checkType<GameObject>(l, 3, out playerIcon);
			chatUITask.m_luaExportHelper.OnPlayerIconClick(chatInfo, playerIcon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA3D RID: 117309 RVA: 0x008EAEB0 File Offset: 0x008E90B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPlayerSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			GameObject playerIcon;
			LuaObject.checkType<GameObject>(l, 2, out playerIcon);
			chatUITask.m_luaExportHelper.ShowPlayerSimpleInfo(playerIcon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA3E RID: 117310 RVA: 0x008EAF0C File Offset: 0x008E910C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfo_OnPrivateChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			BusinessCard playerInfo;
			LuaObject.checkType<BusinessCard>(l, 2, out playerInfo);
			chatUITask.m_luaExportHelper.PlayerSimpleInfo_OnPrivateChatButtonClick(playerInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA3F RID: 117311 RVA: 0x008EAF68 File Offset: 0x008E9168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSimpleInfo_OnBlockUser(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.PlayerSimpleInfo_OnBlockUser();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA40 RID: 117312 RVA: 0x008EAFBC File Offset: 0x008E91BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTalkButtonHold(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.OnTalkButtonHold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA41 RID: 117313 RVA: 0x008EB010 File Offset: 0x008E9210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTalkButtonClickUp(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.OnTalkButtonClickUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA42 RID: 117314 RVA: 0x008EB064 File Offset: 0x008E9264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExitTalkButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.OnExitTalkButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA43 RID: 117315 RVA: 0x008EB0B8 File Offset: 0x008E92B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnterTalkButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.OnEnterTalkButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA44 RID: 117316 RVA: 0x008EB10C File Offset: 0x008E930C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTableChange(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatChannel currentTableType;
			LuaObject.checkEnum<ChatChannel>(l, 2, out currentTableType);
			chatUITask.m_luaExportHelper.OnTableChange(currentTableType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA45 RID: 117317 RVA: 0x008EB168 File Offset: 0x008E9368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatTargetChanged(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			string id;
			LuaObject.checkType(l, 3, out id);
			string name;
			LuaObject.checkType(l, 4, out name);
			chatUITask.m_luaExportHelper.OnChatTargetChanged(channel, id, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA46 RID: 117318 RVA: 0x008EB1E0 File Offset: 0x008E93E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			chatUITask.m_luaExportHelper.OnSendButtonClick(content);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA47 RID: 117319 RVA: 0x008EB23C File Offset: 0x008E943C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.OnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA48 RID: 117320 RVA: 0x008EB290 File Offset: 0x008E9490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.ReturnPrevUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA49 RID: 117321 RVA: 0x008EB2E4 File Offset: 0x008E94E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnVoiceRecordTimeout(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			chatUITask.m_luaExportHelper.OnVoiceRecordTimeout(channel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA4A RID: 117322 RVA: 0x008EB340 File Offset: 0x008E9540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDataFromIntent(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			chatUITask.m_luaExportHelper.GetDataFromIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA4B RID: 117323 RVA: 0x008EB39C File Offset: 0x008E959C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryGetPrivateChatPlayerInfoList(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			List<string> playerIdList;
			LuaObject.checkType<List<string>>(l, 2, out playerIdList);
			Action action;
			LuaObject.checkDelegate<Action>(l, 3, out action);
			chatUITask.m_luaExportHelper.TryGetPrivateChatPlayerInfoList(playerIdList, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA4C RID: 117324 RVA: 0x008EB408 File Offset: 0x008E9608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryGetPrivateChatPlayerInfoListFilterBlacklist(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			chatUITask.m_luaExportHelper.TryGetPrivateChatPlayerInfoListFilterBlacklist(userID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA4D RID: 117325 RVA: 0x008EB464 File Offset: 0x008E9664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryGetChatGroupInfoList(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			chatUITask.m_luaExportHelper.TryGetChatGroupInfoList(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA4E RID: 117326 RVA: 0x008EB4C0 File Offset: 0x008E96C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatMessageNtf(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatMessage info;
			LuaObject.checkType<ChatMessage>(l, 2, out info);
			chatUITask.m_luaExportHelper.OnChatMessageNtf(info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA4F RID: 117327 RVA: 0x008EB51C File Offset: 0x008E971C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatMessageAck(IntPtr l)
	{
		int result2;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			chatUITask.m_luaExportHelper.OnChatMessageAck(result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x0601CA50 RID: 117328 RVA: 0x008EB578 File Offset: 0x008E9778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatGroupUpdateNtf(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ProChatGroupInfo chatGroupInfo;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out chatGroupInfo);
			chatUITask.m_luaExportHelper.OnChatGroupUpdateNtf(chatGroupInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA51 RID: 117329 RVA: 0x008EB5D4 File Offset: 0x008E97D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EventOnFriendGetSocialRelationNtf(IntPtr l)
	{
		int result2;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			int result;
			LuaObject.checkType(l, 2, out result);
			chatUITask.m_luaExportHelper.EventOnFriendGetSocialRelationNtf(result);
			LuaObject.pushValue(l, true);
			result2 = 1;
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x0601CA52 RID: 117330 RVA: 0x008EB630 File Offset: 0x008E9830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPipelineStateMaskNeedUpdate(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatUITask.PipeLineStateMaskType state;
			LuaObject.checkEnum<ChatUITask.PipeLineStateMaskType>(l, 2, out state);
			bool b = chatUITask.m_luaExportHelper.IsPipelineStateMaskNeedUpdate(state);
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

	// Token: 0x0601CA53 RID: 117331 RVA: 0x008EB698 File Offset: 0x008E9898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnablePipelineStateMask(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatUITask.PipeLineStateMaskType state;
			LuaObject.checkEnum<ChatUITask.PipeLineStateMaskType>(l, 2, out state);
			chatUITask.m_luaExportHelper.EnablePipelineStateMask(state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA54 RID: 117332 RVA: 0x008EB6F4 File Offset: 0x008E98F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentChatListByTableType(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			List<ChatComponent.ChatMessageClient> currentChatListByTableType = chatUITask.m_luaExportHelper.GetCurrentChatListByTableType();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentChatListByTableType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA55 RID: 117333 RVA: 0x008EB750 File Offset: 0x008E9950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickForVoiceRecordTime(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.TickForVoiceRecordTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA56 RID: 117334 RVA: 0x008EB7A4 File Offset: 0x008E99A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickForHistoryRecordShow(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.TickForHistoryRecordShow();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA57 RID: 117335 RVA: 0x008EB7F8 File Offset: 0x008E99F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickForVoiceAnim(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.TickForVoiceAnim();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA58 RID: 117336 RVA: 0x008EB84C File Offset: 0x008E9A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayVoiceAnim(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.PlayVoiceAnim();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA59 RID: 117337 RVA: 0x008EB8A0 File Offset: 0x008E9AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopAllVoiceAnim(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.StopAllVoiceAnim();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA5A RID: 117338 RVA: 0x008EB8F4 File Offset: 0x008E9AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatVoiceStartPlay(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient voiceMsg;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out voiceMsg);
			chatUITask.m_luaExportHelper.OnChatVoiceStartPlay(voiceMsg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA5B RID: 117339 RVA: 0x008EB950 File Offset: 0x008E9B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetChatMsgWithBlacklist(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			List<ChatComponent.ChatMessageClient> chatMsgWithBlacklist = chatUITask.m_luaExportHelper.GetChatMsgWithBlacklist(channel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatMsgWithBlacklist);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA5C RID: 117340 RVA: 0x008EB9B8 File Offset: 0x008E9BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DelayInstancePrefab(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			IEnumerator o = chatUITask.m_luaExportHelper.DelayInstancePrefab();
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

	// Token: 0x0601CA5D RID: 117341 RVA: 0x008EBA14 File Offset: 0x008E9C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshRedState(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.RefreshRedState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA5E RID: 117342 RVA: 0x008EBA68 File Offset: 0x008E9C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = chatUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601CA5F RID: 117343 RVA: 0x008EBAD0 File Offset: 0x008E9CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA60 RID: 117344 RVA: 0x008EBB24 File Offset: 0x008E9D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA61 RID: 117345 RVA: 0x008EBB78 File Offset: 0x008E9D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = chatUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601CA62 RID: 117346 RVA: 0x008EBBE0 File Offset: 0x008E9DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = chatUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601CA63 RID: 117347 RVA: 0x008EBC48 File Offset: 0x008E9E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			chatUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA64 RID: 117348 RVA: 0x008EBCB4 File Offset: 0x008E9EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			bool b = chatUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601CA65 RID: 117349 RVA: 0x008EBD10 File Offset: 0x008E9F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			List<string> o = chatUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601CA66 RID: 117350 RVA: 0x008EBD6C File Offset: 0x008E9F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA67 RID: 117351 RVA: 0x008EBDC0 File Offset: 0x008E9FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA68 RID: 117352 RVA: 0x008EBE14 File Offset: 0x008EA014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA69 RID: 117353 RVA: 0x008EBE68 File Offset: 0x008EA068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA6A RID: 117354 RVA: 0x008EBEBC File Offset: 0x008EA0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA6B RID: 117355 RVA: 0x008EBF10 File Offset: 0x008EA110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			chatUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA6C RID: 117356 RVA: 0x008EBF6C File Offset: 0x008EA16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			chatUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA6D RID: 117357 RVA: 0x008EBFC8 File Offset: 0x008EA1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			chatUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA6E RID: 117358 RVA: 0x008EC024 File Offset: 0x008EA224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			chatUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA6F RID: 117359 RVA: 0x008EC080 File Offset: 0x008EA280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			bool b = chatUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601CA70 RID: 117360 RVA: 0x008EC0DC File Offset: 0x008EA2DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			bool b = chatUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601CA71 RID: 117361 RVA: 0x008EC138 File Offset: 0x008EA338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			bool b = chatUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601CA72 RID: 117362 RVA: 0x008EC194 File Offset: 0x008EA394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			UITaskBase o = chatUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601CA73 RID: 117363 RVA: 0x008EC1F0 File Offset: 0x008EA3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA74 RID: 117364 RVA: 0x008EC244 File Offset: 0x008EA444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			chatUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA75 RID: 117365 RVA: 0x008EC298 File Offset: 0x008EA498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isTalkButtonDown(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_isTalkButtonDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA76 RID: 117366 RVA: 0x008EC2F0 File Offset: 0x008EA4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isTalkButtonDown(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			bool isTalkButtonDown;
			LuaObject.checkType(l, 2, out isTalkButtonDown);
			chatUITask.m_luaExportHelper.m_isTalkButtonDown = isTalkButtonDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA77 RID: 117367 RVA: 0x008EC34C File Offset: 0x008EA54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isExitTalkButtonRect(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_isExitTalkButtonRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA78 RID: 117368 RVA: 0x008EC3A4 File Offset: 0x008EA5A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isExitTalkButtonRect(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			bool isExitTalkButtonRect;
			LuaObject.checkType(l, 2, out isExitTalkButtonRect);
			chatUITask.m_luaExportHelper.m_isExitTalkButtonRect = isExitTalkButtonRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA79 RID: 117369 RVA: 0x008EC400 File Offset: 0x008EA600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerCtx(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_playerCtx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA7A RID: 117370 RVA: 0x008EC458 File Offset: 0x008EA658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerCtx(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerCtx;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerCtx);
			chatUITask.m_luaExportHelper.m_playerCtx = playerCtx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA7B RID: 117371 RVA: 0x008EC4B4 File Offset: 0x008EA6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentChatList(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_currentChatList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA7C RID: 117372 RVA: 0x008EC50C File Offset: 0x008EA70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentChatList(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			List<ChatComponent.ChatMessageClient> currentChatList;
			LuaObject.checkType<List<ChatComponent.ChatMessageClient>>(l, 2, out currentChatList);
			chatUITask.m_luaExportHelper.m_currentChatList = currentChatList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA7D RID: 117373 RVA: 0x008EC568 File Offset: 0x008EA768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentTableType(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)chatUITask.m_luaExportHelper.m_currentTableType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA7E RID: 117374 RVA: 0x008EC5C0 File Offset: 0x008EA7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentTableType(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatChannel currentTableType;
			LuaObject.checkEnum<ChatChannel>(l, 2, out currentTableType);
			chatUITask.m_luaExportHelper.m_currentTableType = currentTableType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA7F RID: 117375 RVA: 0x008EC61C File Offset: 0x008EA81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatTagetID(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_chatTagetID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA80 RID: 117376 RVA: 0x008EC674 File Offset: 0x008EA874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatTagetID(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			string chatTagetID;
			LuaObject.checkType(l, 2, out chatTagetID);
			chatUITask.m_luaExportHelper.m_chatTagetID = chatTagetID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA81 RID: 117377 RVA: 0x008EC6D0 File Offset: 0x008EA8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupChatID(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_groupChatID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA82 RID: 117378 RVA: 0x008EC728 File Offset: 0x008EA928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupChatID(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			string groupChatID;
			LuaObject.checkType(l, 2, out groupChatID);
			chatUITask.m_luaExportHelper.m_groupChatID = groupChatID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA83 RID: 117379 RVA: 0x008EC784 File Offset: 0x008EA984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA84 RID: 117380 RVA: 0x008EC7DC File Offset: 0x008EA9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			chatUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA85 RID: 117381 RVA: 0x008EC838 File Offset: 0x008EAA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerSimpleInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_playerSimpleInfoUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA86 RID: 117382 RVA: 0x008EC890 File Offset: 0x008EAA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerSimpleInfoUITask(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			PlayerSimpleInfoUITask playerSimpleInfoUITask;
			LuaObject.checkType<PlayerSimpleInfoUITask>(l, 2, out playerSimpleInfoUITask);
			chatUITask.m_luaExportHelper.m_playerSimpleInfoUITask = playerSimpleInfoUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA87 RID: 117383 RVA: 0x008EC8EC File Offset: 0x008EAAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPrivateShowHistoryRecord(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_isPrivateShowHistoryRecord);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA88 RID: 117384 RVA: 0x008EC944 File Offset: 0x008EAB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPrivateShowHistoryRecord(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			bool isPrivateShowHistoryRecord;
			LuaObject.checkType(l, 2, out isPrivateShowHistoryRecord);
			chatUITask.m_luaExportHelper.m_isPrivateShowHistoryRecord = isPrivateShowHistoryRecord;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA89 RID: 117385 RVA: 0x008EC9A0 File Offset: 0x008EABA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDragSrcowView(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_isDragSrcowView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA8A RID: 117386 RVA: 0x008EC9F8 File Offset: 0x008EABF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDragSrcowView(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			bool isDragSrcowView;
			LuaObject.checkType(l, 2, out isDragSrcowView);
			chatUITask.m_luaExportHelper.m_isDragSrcowView = isDragSrcowView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA8B RID: 117387 RVA: 0x008ECA54 File Offset: 0x008EAC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isGroupShowHistoryRecord(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_isGroupShowHistoryRecord);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA8C RID: 117388 RVA: 0x008ECAAC File Offset: 0x008EACAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isGroupShowHistoryRecord(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			bool isGroupShowHistoryRecord;
			LuaObject.checkType(l, 2, out isGroupShowHistoryRecord);
			chatUITask.m_luaExportHelper.m_isGroupShowHistoryRecord = isGroupShowHistoryRecord;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA8D RID: 117389 RVA: 0x008ECB08 File Offset: 0x008EAD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatUICtrl(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_chatUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA8E RID: 117390 RVA: 0x008ECB60 File Offset: 0x008EAD60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatUICtrl(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatUIController chatUICtrl;
			LuaObject.checkType<ChatUIController>(l, 2, out chatUICtrl);
			chatUITask.m_luaExportHelper.m_chatUICtrl = chatUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA8F RID: 117391 RVA: 0x008ECBBC File Offset: 0x008EADBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expressionCtrl(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_expressionCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA90 RID: 117392 RVA: 0x008ECC14 File Offset: 0x008EAE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expressionCtrl(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			ChatExpressionUIController expressionCtrl;
			LuaObject.checkType<ChatExpressionUIController>(l, 2, out expressionCtrl);
			chatUITask.m_luaExportHelper.m_expressionCtrl = expressionCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA91 RID: 117393 RVA: 0x008ECC70 File Offset: 0x008EAE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentChatUserID(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_currentChatUserID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA92 RID: 117394 RVA: 0x008ECCC8 File Offset: 0x008EAEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentChatUserID(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			string currentChatUserID;
			LuaObject.checkType(l, 2, out currentChatUserID);
			chatUITask.m_luaExportHelper.m_currentChatUserID = currentChatUserID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA93 RID: 117395 RVA: 0x008ECD24 File Offset: 0x008EAF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamsKey_AppointChannel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "AppointEnterChannel");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA94 RID: 117396 RVA: 0x008ECD6C File Offset: 0x008EAF6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamsKey_ChatUserId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "PrivateChatPlayerGameUserId");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA95 RID: 117397 RVA: 0x008ECDB4 File Offset: 0x008EAFB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamsKey_GroupChatId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "GroupChatId");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA96 RID: 117398 RVA: 0x008ECDFC File Offset: 0x008EAFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExpressionMark(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "#");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA97 RID: 117399 RVA: 0x008ECE44 File Offset: 0x008EB044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA98 RID: 117400 RVA: 0x008ECE9C File Offset: 0x008EB09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			chatUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA99 RID: 117401 RVA: 0x008ECEF8 File Offset: 0x008EB0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA9A RID: 117402 RVA: 0x008ECF50 File Offset: 0x008EB150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			chatUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA9B RID: 117403 RVA: 0x008ECFAC File Offset: 0x008EB1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA9C RID: 117404 RVA: 0x008ED004 File Offset: 0x008EB204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			ChatUITask chatUITask = (ChatUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA9D RID: 117405 RVA: 0x008ED05C File Offset: 0x008EB25C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChatUITask");
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnSmallExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnRoomIdInputEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.StartChatUITaskWithNormalMode_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.StartChatUITaskToEnterAppointChannel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.PauseUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnGetChatTargetInfoEndFroResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.IsNeedUpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.UpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.RequestMicrophonePermission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnExpressionBgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnExpressionFunctionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnItemVoiceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnPlayerIconClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.ShowPlayerSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.PlayerSimpleInfo_OnPrivateChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.PlayerSimpleInfo_OnBlockUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnTalkButtonHold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnTalkButtonClickUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnExitTalkButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnEnterTalkButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnTableChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnChatTargetChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnSendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnVoiceRecordTimeout);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.GetDataFromIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.TryGetPrivateChatPlayerInfoList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.TryGetPrivateChatPlayerInfoListFilterBlacklist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.TryGetChatGroupInfoList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnChatMessageNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnChatMessageAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnChatGroupUpdateNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.EventOnFriendGetSocialRelationNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.IsPipelineStateMaskNeedUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.EnablePipelineStateMask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.GetCurrentChatListByTableType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.TickForVoiceRecordTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.TickForHistoryRecordShow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.TickForVoiceAnim);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.PlayVoiceAnim);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.StopAllVoiceAnim);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.OnChatVoiceStartPlay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.GetChatMsgWithBlacklist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.DelayInstancePrefab);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.RefreshRedState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4D);
		string name = "m_isTalkButtonDown";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_isTalkButtonDown);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_isTalkButtonDown);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache4F, true);
		string name2 = "m_isExitTalkButtonRect";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_isExitTalkButtonRect);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_isExitTalkButtonRect);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache51, true);
		string name3 = "m_playerCtx";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_playerCtx);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_playerCtx);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache53, true);
		string name4 = "m_currentChatList";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_currentChatList);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_currentChatList);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache55, true);
		string name5 = "m_currentTableType";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_currentTableType);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_currentTableType);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache57, true);
		string name6 = "m_chatTagetID";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_chatTagetID);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_chatTagetID);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache59, true);
		string name7 = "m_groupChatID";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_groupChatID);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_groupChatID);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5B, true);
		string name8 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_configDataLoader);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5D, true);
		string name9 = "m_playerSimpleInfoUITask";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_playerSimpleInfoUITask);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_playerSimpleInfoUITask);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache5F, true);
		string name10 = "m_isPrivateShowHistoryRecord";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_isPrivateShowHistoryRecord);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_isPrivateShowHistoryRecord);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache61, true);
		string name11 = "m_isDragSrcowView";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_isDragSrcowView);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_isDragSrcowView);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache63, true);
		string name12 = "m_isGroupShowHistoryRecord";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_isGroupShowHistoryRecord);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_isGroupShowHistoryRecord);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache65, true);
		string name13 = "m_chatUICtrl";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_chatUICtrl);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_chatUICtrl);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache67, true);
		string name14 = "m_expressionCtrl";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_expressionCtrl);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_expressionCtrl);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache69, true);
		string name15 = "m_currentChatUserID";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_currentChatUserID);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_currentChatUserID);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6B, true);
		string name16 = "ParamsKey_AppointChannel";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_ParamsKey_AppointChannel);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6C, null, false);
		string name17 = "ParamsKey_ChatUserId";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_ParamsKey_ChatUserId);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6D, null, false);
		string name18 = "ParamsKey_GroupChatId";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_ParamsKey_GroupChatId);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6E, null, false);
		string name19 = "ExpressionMark";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_ExpressionMark);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache6F, null, false);
		string name20 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_layerDescArray);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name20, get16, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache71, true);
		string name21 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name21, get17, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache73, true);
		string name22 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache74, null, true);
		string name23 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache75, null, true);
		if (Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ChatUITask.<>f__mg$cache76, typeof(ChatUITask), typeof(UITask));
	}

	// Token: 0x04012C2C RID: 76844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012C2D RID: 76845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012C2E RID: 76846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012C2F RID: 76847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012C30 RID: 76848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012C31 RID: 76849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012C32 RID: 76850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012C33 RID: 76851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012C34 RID: 76852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012C35 RID: 76853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012C36 RID: 76854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012C37 RID: 76855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012C38 RID: 76856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012C39 RID: 76857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012C3A RID: 76858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012C3B RID: 76859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012C3C RID: 76860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012C3D RID: 76861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012C3E RID: 76862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012C3F RID: 76863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012C40 RID: 76864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012C41 RID: 76865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012C42 RID: 76866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012C43 RID: 76867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012C44 RID: 76868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012C45 RID: 76869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012C46 RID: 76870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012C47 RID: 76871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012C48 RID: 76872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012C49 RID: 76873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012C4A RID: 76874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012C4B RID: 76875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012C4C RID: 76876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012C4D RID: 76877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012C4E RID: 76878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012C4F RID: 76879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012C50 RID: 76880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012C51 RID: 76881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012C52 RID: 76882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012C53 RID: 76883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012C54 RID: 76884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012C55 RID: 76885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012C56 RID: 76886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012C57 RID: 76887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012C58 RID: 76888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012C59 RID: 76889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012C5A RID: 76890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012C5B RID: 76891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012C5C RID: 76892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012C5D RID: 76893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012C5E RID: 76894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012C5F RID: 76895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012C60 RID: 76896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012C61 RID: 76897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012C62 RID: 76898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012C63 RID: 76899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012C64 RID: 76900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012C65 RID: 76901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04012C66 RID: 76902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012C67 RID: 76903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04012C68 RID: 76904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04012C69 RID: 76905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04012C6A RID: 76906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04012C6B RID: 76907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04012C6C RID: 76908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04012C6D RID: 76909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04012C6E RID: 76910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04012C6F RID: 76911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04012C70 RID: 76912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04012C71 RID: 76913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04012C72 RID: 76914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04012C73 RID: 76915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04012C74 RID: 76916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04012C75 RID: 76917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04012C76 RID: 76918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04012C77 RID: 76919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04012C78 RID: 76920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04012C79 RID: 76921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04012C7A RID: 76922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04012C7B RID: 76923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04012C7C RID: 76924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04012C7D RID: 76925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04012C7E RID: 76926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04012C7F RID: 76927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04012C80 RID: 76928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04012C81 RID: 76929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04012C82 RID: 76930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04012C83 RID: 76931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04012C84 RID: 76932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04012C85 RID: 76933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04012C86 RID: 76934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04012C87 RID: 76935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04012C88 RID: 76936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04012C89 RID: 76937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04012C8A RID: 76938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04012C8B RID: 76939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04012C8C RID: 76940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04012C8D RID: 76941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04012C8E RID: 76942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04012C8F RID: 76943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04012C90 RID: 76944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04012C91 RID: 76945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04012C92 RID: 76946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04012C93 RID: 76947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04012C94 RID: 76948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04012C95 RID: 76949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04012C96 RID: 76950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04012C97 RID: 76951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04012C98 RID: 76952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04012C99 RID: 76953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04012C9A RID: 76954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04012C9B RID: 76955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04012C9C RID: 76956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04012C9D RID: 76957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04012C9E RID: 76958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04012C9F RID: 76959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04012CA0 RID: 76960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04012CA1 RID: 76961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04012CA2 RID: 76962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;
}
