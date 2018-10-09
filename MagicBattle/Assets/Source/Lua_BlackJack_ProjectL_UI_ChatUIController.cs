using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013ED RID: 5101
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChatUIController : LuaObject
{
	// Token: 0x0601C952 RID: 117074 RVA: 0x008E3CE8 File Offset: 0x008E1EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshDropDownList(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			chatUIController.RefreshDropDownList(channel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C953 RID: 117075 RVA: 0x008E3D40 File Offset: 0x008E1F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowOrHidePanel(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			chatUIController.ShowOrHidePanel(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C954 RID: 117076 RVA: 0x008E3D98 File Offset: 0x008E1F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowNewChatTip(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.ShowNewChatTip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C955 RID: 117077 RVA: 0x008E3DE4 File Offset: 0x008E1FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InputFieldTextAppend(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string appendStr;
			LuaObject.checkType(l, 2, out appendStr);
			chatUIController.InputFieldTextAppend(appendStr);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C956 RID: 117078 RVA: 0x008E3E3C File Offset: 0x008E203C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateChatList(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			List<ChatComponent.ChatMessageClient> currentChatList;
			LuaObject.checkType<List<ChatComponent.ChatMessageClient>>(l, 2, out currentChatList);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 3, out channel);
			bool isRefill;
			LuaObject.checkType(l, 4, out isRefill);
			bool isScroll;
			LuaObject.checkType(l, 5, out isScroll);
			bool hasNew;
			LuaObject.checkType(l, 6, out hasNew);
			chatUIController.UpdateChatList(currentChatList, channel, isRefill, isScroll, hasNew);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C957 RID: 117079 RVA: 0x008E3EC8 File Offset: 0x008E20C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateChatCacheInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			List<ChatComponent.ChatMessageClient> chatInfoList;
			LuaObject.checkType<List<ChatComponent.ChatMessageClient>>(l, 2, out chatInfoList);
			chatUIController.UpdateChatCacheInfo(chatInfoList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C958 RID: 117080 RVA: 0x008E3F20 File Offset: 0x008E2120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetChannelToggleSelectState(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			bool channelToggleSelectState = chatUIController.GetChannelToggleSelectState(channel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, channelToggleSelectState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C959 RID: 117081 RVA: 0x008E3F84 File Offset: 0x008E2184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChannelToggleSelected(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatChannel channelToggleSelected;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channelToggleSelected);
			chatUIController.SetChannelToggleSelected(channelToggleSelected);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C95A RID: 117082 RVA: 0x008E3FDC File Offset: 0x008E21DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsScrollViewInEnd(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			bool b = chatUIController.IsScrollViewInEnd();
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

	// Token: 0x0601C95B RID: 117083 RVA: 0x008E4030 File Offset: 0x008E2230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateChooseChatPlayerOrGroupListInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			List<string> idList;
			LuaObject.checkType<List<string>>(l, 3, out idList);
			List<string> nameList;
			LuaObject.checkType<List<string>>(l, 4, out nameList);
			chatUIController.UpdateChooseChatPlayerOrGroupListInfo(channel, idList, nameList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C95C RID: 117084 RVA: 0x008E40A4 File Offset: 0x008E22A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowOrHideChooseChatTargetPannel(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			chatUIController.ShowOrHideChooseChatTargetPannel(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C95D RID: 117085 RVA: 0x008E40FC File Offset: 0x008E22FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTalkButtonSize(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Vector2 talkButtonSize;
			LuaObject.checkType(l, 2, out talkButtonSize);
			chatUIController.SetTalkButtonSize(talkButtonSize);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C95E RID: 117086 RVA: 0x008E4154 File Offset: 0x008E2354
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowVoiceRecordTip(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.ShowVoiceRecordTip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C95F RID: 117087 RVA: 0x008E41A0 File Offset: 0x008E23A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HideVoiceRecordTip(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.HideVoiceRecordTip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C960 RID: 117088 RVA: 0x008E41EC File Offset: 0x008E23EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowVoiceCancelTip(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.ShowVoiceCancelTip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C961 RID: 117089 RVA: 0x008E4238 File Offset: 0x008E2438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowVoiceShortTip(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.ShowVoiceShortTip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C962 RID: 117090 RVA: 0x008E4284 File Offset: 0x008E2484
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateVoiceRecordTime(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			chatUIController.UpdateVoiceRecordTime(time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C963 RID: 117091 RVA: 0x008E42DC File Offset: 0x008E24DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RegItemButtonClickEvent(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action<ChatComponent.ChatMessageClient> voiceClickAction;
			LuaObject.checkDelegate<Action<ChatComponent.ChatMessageClient>>(l, 2, out voiceClickAction);
			Action<ChatMessage, GameObject> playerIconClickAction;
			LuaObject.checkDelegate<Action<ChatMessage, GameObject>>(l, 3, out playerIconClickAction);
			chatUIController.RegItemButtonClickEvent(voiceClickAction, playerIconClickAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C964 RID: 117092 RVA: 0x008E4340 File Offset: 0x008E2540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetRoomIdTip(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			int roomIdTip;
			LuaObject.checkType(l, 2, out roomIdTip);
			chatUIController.SetRoomIdTip(roomIdTip);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C965 RID: 117093 RVA: 0x008E4398 File Offset: 0x008E2598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EnableRoomIdShow(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			chatUIController.EnableRoomIdShow(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C966 RID: 117094 RVA: 0x008E43F0 File Offset: 0x008E25F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CloseAllTableRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.CloseAllTableRedMark();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C967 RID: 117095 RVA: 0x008E443C File Offset: 0x008E263C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTableRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatChannel tableRedMark;
			LuaObject.checkEnum<ChatChannel>(l, 2, out tableRedMark);
			chatUIController.SetTableRedMark(tableRedMark);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C968 RID: 117096 RVA: 0x008E4494 File Offset: 0x008E2694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearChatContent(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.ClearChatContent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C969 RID: 117097 RVA: 0x008E44E0 File Offset: 0x008E26E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindChannelButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			Button o = chatUIController.FindChannelButton(channel);
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

	// Token: 0x0601C96A RID: 117098 RVA: 0x008E4544 File Offset: 0x008E2744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C96B RID: 117099 RVA: 0x008E4598 File Offset: 0x008E2798
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C96C RID: 117100 RVA: 0x008E45EC File Offset: 0x008E27EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRoomIdInputEnd(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			chatUIController.m_luaExportHelper.OnRoomIdInputEnd(content);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C96D RID: 117101 RVA: 0x008E4648 File Offset: 0x008E2848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExpressionFunctionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.OnExpressionFunctionButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C96E RID: 117102 RVA: 0x008E469C File Offset: 0x008E289C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTalkButtonClickDown(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			chatUIController.m_luaExportHelper.OnTalkButtonClickDown(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C96F RID: 117103 RVA: 0x008E46F8 File Offset: 0x008E28F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTalkButtonTestHoding(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			IEnumerator o = chatUIController.m_luaExportHelper.OnTalkButtonTestHoding();
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

	// Token: 0x0601C970 RID: 117104 RVA: 0x008E4754 File Offset: 0x008E2954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTalkButtonClickUp(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			chatUIController.m_luaExportHelper.OnTalkButtonClickUp(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C971 RID: 117105 RVA: 0x008E47B0 File Offset: 0x008E29B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExitTalkButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			chatUIController.m_luaExportHelper.OnExitTalkButton(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C972 RID: 117106 RVA: 0x008E480C File Offset: 0x008E2A0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEnterTalkButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			chatUIController.m_luaExportHelper.OnEnterTalkButton(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C973 RID: 117107 RVA: 0x008E4868 File Offset: 0x008E2A68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnSendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.OnSendButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C974 RID: 117108 RVA: 0x008E48BC File Offset: 0x008E2ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.OnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C975 RID: 117109 RVA: 0x008E4910 File Offset: 0x008E2B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTableSelected(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button currentButton;
			LuaObject.checkType<Button>(l, 2, out currentButton);
			chatUIController.m_luaExportHelper.OnTableSelected(currentButton);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C976 RID: 117110 RVA: 0x008E496C File Offset: 0x008E2B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatTargetChanged(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			chatUIController.m_luaExportHelper.OnChatTargetChanged(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C977 RID: 117111 RVA: 0x008E49C8 File Offset: 0x008E2BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChooseTargetRootClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.OnChooseTargetRootClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C978 RID: 117112 RVA: 0x008E4A1C File Offset: 0x008E2C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeRoomButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.OnChangeRoomButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C979 RID: 117113 RVA: 0x008E4A70 File Offset: 0x008E2C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InputPanel_OnEndEdit(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string str;
			LuaObject.checkType(l, 2, out str);
			chatUIController.m_luaExportHelper.InputPanel_OnEndEdit(str);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C97A RID: 117114 RVA: 0x008E4ACC File Offset: 0x008E2CCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnChatItemFill(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			UIControllerBase uCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out uCtrl);
			chatUIController.m_luaExportHelper.OnChatItemFill(uCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C97B RID: 117115 RVA: 0x008E4B28 File Offset: 0x008E2D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetShowChatItemPoolName4Info(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatMessage chatInfo;
			LuaObject.checkType<ChatMessage>(l, 2, out chatInfo);
			string showChatItemPoolName4Info = chatUIController.m_luaExportHelper.GetShowChatItemPoolName4Info(chatInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, showChatItemPoolName4Info);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C97C RID: 117116 RVA: 0x008E4B90 File Offset: 0x008E2D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetScrollViewToBottom(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.SetScrollViewToBottom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C97D RID: 117117 RVA: 0x008E4BE4 File Offset: 0x008E2DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			chatUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C97E RID: 117118 RVA: 0x008E4C50 File Offset: 0x008E2E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C97F RID: 117119 RVA: 0x008E4CA4 File Offset: 0x008E2EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C980 RID: 117120 RVA: 0x008E4CF8 File Offset: 0x008E2EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Type fieldType;
			LuaObject.checkType(l, 2, out fieldType);
			string path;
			LuaObject.checkType(l, 3, out path);
			AutoBindAttribute.InitState initState;
			LuaObject.checkEnum<AutoBindAttribute.InitState>(l, 4, out initState);
			string fieldName;
			LuaObject.checkType(l, 5, out fieldName);
			string ctrlName;
			LuaObject.checkType(l, 6, out ctrlName);
			bool optional;
			LuaObject.checkType(l, 7, out optional);
			UnityEngine.Object o = chatUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C981 RID: 117121 RVA: 0x008E4DA0 File Offset: 0x008E2FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C982 RID: 117122 RVA: 0x008E4DF4 File Offset: 0x008E2FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			chatUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C983 RID: 117123 RVA: 0x008E4E60 File Offset: 0x008E3060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				chatUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ChatUIController chatUIController2 = (ChatUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				chatUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C984 RID: 117124 RVA: 0x008E4F70 File Offset: 0x008E3170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chatUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C985 RID: 117125 RVA: 0x008E4FDC File Offset: 0x008E31DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chatUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C986 RID: 117126 RVA: 0x008E5048 File Offset: 0x008E3248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chatUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C987 RID: 117127 RVA: 0x008E50B4 File Offset: 0x008E32B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			chatUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C988 RID: 117128 RVA: 0x008E5120 File Offset: 0x008E3320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				chatUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ChatUIController chatUIController2 = (ChatUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				chatUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C989 RID: 117129 RVA: 0x008E5230 File Offset: 0x008E3430
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string s = chatUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C98A RID: 117130 RVA: 0x008E528C File Offset: 0x008E348C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTableChange(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatChannel obj;
			LuaObject.checkEnum<ChatChannel>(l, 2, out obj);
			chatUIController.m_luaExportHelper.__callDele_EventOnTableChange(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C98B RID: 117131 RVA: 0x008E52E8 File Offset: 0x008E34E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTableChange(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatChannel obj;
			LuaObject.checkEnum<ChatChannel>(l, 2, out obj);
			chatUIController.m_luaExportHelper.__clearDele_EventOnTableChange(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C98C RID: 117132 RVA: 0x008E5344 File Offset: 0x008E3544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			chatUIController.m_luaExportHelper.__callDele_EventOnSendButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C98D RID: 117133 RVA: 0x008E53A0 File Offset: 0x008E35A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			chatUIController.m_luaExportHelper.__clearDele_EventOnSendButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C98E RID: 117134 RVA: 0x008E53FC File Offset: 0x008E35FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__callDele_EventOnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C98F RID: 117135 RVA: 0x008E5450 File Offset: 0x008E3650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__clearDele_EventOnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C990 RID: 117136 RVA: 0x008E54A4 File Offset: 0x008E36A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnExpressionFunctionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__callDele_EventOnExpressionFunctionButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C991 RID: 117137 RVA: 0x008E54F8 File Offset: 0x008E36F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnExpressionFunctionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__clearDele_EventOnExpressionFunctionButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C992 RID: 117138 RVA: 0x008E554C File Offset: 0x008E374C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRoomIdInputEnd(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			chatUIController.m_luaExportHelper.__callDele_EventOnRoomIdInputEnd(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C993 RID: 117139 RVA: 0x008E55A8 File Offset: 0x008E37A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRoomIdInputEnd(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			chatUIController.m_luaExportHelper.__clearDele_EventOnRoomIdInputEnd(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C994 RID: 117140 RVA: 0x008E5604 File Offset: 0x008E3804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTalkButtonHold(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__callDele_EventOnTalkButtonHold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C995 RID: 117141 RVA: 0x008E5658 File Offset: 0x008E3858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTalkButtonHold(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__clearDele_EventOnTalkButtonHold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C996 RID: 117142 RVA: 0x008E56AC File Offset: 0x008E38AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnTalkButtonClickUp(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__callDele_EventOnTalkButtonClickUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C997 RID: 117143 RVA: 0x008E5700 File Offset: 0x008E3900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnTalkButtonClickUp(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__clearDele_EventOnTalkButtonClickUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C998 RID: 117144 RVA: 0x008E5754 File Offset: 0x008E3954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnExitTalkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__callDele_EventOnExitTalkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C999 RID: 117145 RVA: 0x008E57A8 File Offset: 0x008E39A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnExitTalkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__clearDele_EventOnExitTalkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C99A RID: 117146 RVA: 0x008E57FC File Offset: 0x008E39FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEnterTalkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__callDele_EventOnEnterTalkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C99B RID: 117147 RVA: 0x008E5850 File Offset: 0x008E3A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEnterTalkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			chatUIController.m_luaExportHelper.__clearDele_EventOnEnterTalkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C99C RID: 117148 RVA: 0x008E58A4 File Offset: 0x008E3AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChatTargetChanged(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatChannel arg;
			LuaObject.checkEnum<ChatChannel>(l, 2, out arg);
			string arg2;
			LuaObject.checkType(l, 3, out arg2);
			string arg3;
			LuaObject.checkType(l, 4, out arg3);
			chatUIController.m_luaExportHelper.__callDele_EventOnChatTargetChanged(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C99D RID: 117149 RVA: 0x008E591C File Offset: 0x008E3B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChatTargetChanged(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatChannel arg;
			LuaObject.checkEnum<ChatChannel>(l, 2, out arg);
			string arg2;
			LuaObject.checkType(l, 3, out arg2);
			string arg3;
			LuaObject.checkType(l, 4, out arg3);
			chatUIController.m_luaExportHelper.__clearDele_EventOnChatTargetChanged(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C99E RID: 117150 RVA: 0x008E5994 File Offset: 0x008E3B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_itemVoiceButtonClickEvent(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient obj;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out obj);
			chatUIController.m_luaExportHelper.__callDele_m_itemVoiceButtonClickEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C99F RID: 117151 RVA: 0x008E59F0 File Offset: 0x008E3BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_itemVoiceButtonClickEvent(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient obj;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out obj);
			chatUIController.m_luaExportHelper.__clearDele_m_itemVoiceButtonClickEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9A0 RID: 117152 RVA: 0x008E5A4C File Offset: 0x008E3C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_itemPlayerIconClickEvent(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatMessage arg;
			LuaObject.checkType<ChatMessage>(l, 2, out arg);
			GameObject arg2;
			LuaObject.checkType<GameObject>(l, 3, out arg2);
			chatUIController.m_luaExportHelper.__callDele_m_itemPlayerIconClickEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9A1 RID: 117153 RVA: 0x008E5AB8 File Offset: 0x008E3CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_itemPlayerIconClickEvent(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatMessage arg;
			LuaObject.checkType<ChatMessage>(l, 2, out arg);
			GameObject arg2;
			LuaObject.checkType<GameObject>(l, 3, out arg2);
			chatUIController.m_luaExportHelper.__clearDele_m_itemPlayerIconClickEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9A2 RID: 117154 RVA: 0x008E5B24 File Offset: 0x008E3D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_InputFocused(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_luaExportHelper.m_InputFocused);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9A3 RID: 117155 RVA: 0x008E5B7C File Offset: 0x008E3D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_InputFocused(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			bool inputFocused;
			LuaObject.checkType(l, 2, out inputFocused);
			chatUIController.m_luaExportHelper.m_InputFocused = inputFocused;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9A4 RID: 117156 RVA: 0x008E5BD8 File Offset: 0x008E3DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemVoiceButtonClickEvent(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action<ChatComponent.ChatMessageClient> action;
			int num = LuaObject.checkDelegate<Action<ChatComponent.ChatMessageClient>>(l, 2, out action);
			if (num == 0)
			{
				chatUIController.m_luaExportHelper.m_itemVoiceButtonClickEvent = action;
			}
			else if (num == 1)
			{
				ChatUIController.LuaExportHelper luaExportHelper = chatUIController.m_luaExportHelper;
				luaExportHelper.m_itemVoiceButtonClickEvent = (Action<ChatComponent.ChatMessageClient>)Delegate.Combine(luaExportHelper.m_itemVoiceButtonClickEvent, action);
			}
			else if (num == 2)
			{
				ChatUIController.LuaExportHelper luaExportHelper2 = chatUIController.m_luaExportHelper;
				luaExportHelper2.m_itemVoiceButtonClickEvent = (Action<ChatComponent.ChatMessageClient>)Delegate.Remove(luaExportHelper2.m_itemVoiceButtonClickEvent, action);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9A5 RID: 117157 RVA: 0x008E5C8C File Offset: 0x008E3E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemPlayerIconClickEvent(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action<ChatMessage, GameObject> action;
			int num = LuaObject.checkDelegate<Action<ChatMessage, GameObject>>(l, 2, out action);
			if (num == 0)
			{
				chatUIController.m_luaExportHelper.m_itemPlayerIconClickEvent = action;
			}
			else if (num == 1)
			{
				ChatUIController.LuaExportHelper luaExportHelper = chatUIController.m_luaExportHelper;
				luaExportHelper.m_itemPlayerIconClickEvent = (Action<ChatMessage, GameObject>)Delegate.Combine(luaExportHelper.m_itemPlayerIconClickEvent, action);
			}
			else if (num == 2)
			{
				ChatUIController.LuaExportHelper luaExportHelper2 = chatUIController.m_luaExportHelper;
				luaExportHelper2.m_itemPlayerIconClickEvent = (Action<ChatMessage, GameObject>)Delegate.Remove(luaExportHelper2.m_itemPlayerIconClickEvent, action);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9A6 RID: 117158 RVA: 0x008E5D40 File Offset: 0x008E3F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentTableType(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)chatUIController.m_luaExportHelper.m_currentTableType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9A7 RID: 117159 RVA: 0x008E5D98 File Offset: 0x008E3F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentTableType(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatChannel currentTableType;
			LuaObject.checkEnum<ChatChannel>(l, 2, out currentTableType);
			chatUIController.m_luaExportHelper.m_currentTableType = currentTableType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9A8 RID: 117160 RVA: 0x008E5DF4 File Offset: 0x008E3FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentChatList(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_luaExportHelper.m_currentChatList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9A9 RID: 117161 RVA: 0x008E5E4C File Offset: 0x008E404C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentChatList(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			List<ChatComponent.ChatMessageClient> currentChatList;
			LuaObject.checkType<List<ChatComponent.ChatMessageClient>>(l, 2, out currentChatList);
			chatUIController.m_luaExportHelper.m_currentChatList = currentChatList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9AA RID: 117162 RVA: 0x008E5EA8 File Offset: 0x008E40A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redMarkObjs(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_luaExportHelper.m_redMarkObjs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9AB RID: 117163 RVA: 0x008E5F00 File Offset: 0x008E4100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redMarkObjs(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			List<GameObject> redMarkObjs;
			LuaObject.checkType<List<GameObject>>(l, 2, out redMarkObjs);
			chatUIController.m_luaExportHelper.m_redMarkObjs = redMarkObjs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9AC RID: 117164 RVA: 0x008E5F5C File Offset: 0x008E415C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9AD RID: 117165 RVA: 0x008E5FB4 File Offset: 0x008E41B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			chatUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9AE RID: 117166 RVA: 0x008E6010 File Offset: 0x008E4210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTableChange(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action<ChatChannel> value;
			int num = LuaObject.checkDelegate<Action<ChatChannel>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chatUIController.EventOnTableChange += value;
				}
				else if (num == 2)
				{
					chatUIController.EventOnTableChange -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9AF RID: 117167 RVA: 0x008E6090 File Offset: 0x008E4290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chatUIController.EventOnSendButtonClick += value;
				}
				else if (num == 2)
				{
					chatUIController.EventOnSendButtonClick -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9B0 RID: 117168 RVA: 0x008E6110 File Offset: 0x008E4310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chatUIController.EventOnCloseButtonClick += value;
				}
				else if (num == 2)
				{
					chatUIController.EventOnCloseButtonClick -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9B1 RID: 117169 RVA: 0x008E6190 File Offset: 0x008E4390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnExpressionFunctionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chatUIController.EventOnExpressionFunctionButtonClick += value;
				}
				else if (num == 2)
				{
					chatUIController.EventOnExpressionFunctionButtonClick -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9B2 RID: 117170 RVA: 0x008E6210 File Offset: 0x008E4410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRoomIdInputEnd(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chatUIController.EventOnRoomIdInputEnd += value;
				}
				else if (num == 2)
				{
					chatUIController.EventOnRoomIdInputEnd -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9B3 RID: 117171 RVA: 0x008E6290 File Offset: 0x008E4490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTalkButtonHold(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chatUIController.EventOnTalkButtonHold += value;
				}
				else if (num == 2)
				{
					chatUIController.EventOnTalkButtonHold -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9B4 RID: 117172 RVA: 0x008E6310 File Offset: 0x008E4510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_coroutineTalkButtonTestHolding(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_luaExportHelper.m_coroutineTalkButtonTestHolding);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9B5 RID: 117173 RVA: 0x008E6368 File Offset: 0x008E4568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_coroutineTalkButtonTestHolding(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Coroutine coroutineTalkButtonTestHolding;
			LuaObject.checkType<Coroutine>(l, 2, out coroutineTalkButtonTestHolding);
			chatUIController.m_luaExportHelper.m_coroutineTalkButtonTestHolding = coroutineTalkButtonTestHolding;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9B6 RID: 117174 RVA: 0x008E63C4 File Offset: 0x008E45C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnTalkButtonClickUp(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chatUIController.EventOnTalkButtonClickUp += value;
				}
				else if (num == 2)
				{
					chatUIController.EventOnTalkButtonClickUp -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9B7 RID: 117175 RVA: 0x008E6444 File Offset: 0x008E4644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnExitTalkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chatUIController.EventOnExitTalkButtonClick += value;
				}
				else if (num == 2)
				{
					chatUIController.EventOnExitTalkButtonClick -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9B8 RID: 117176 RVA: 0x008E64C4 File Offset: 0x008E46C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEnterTalkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chatUIController.EventOnEnterTalkButtonClick += value;
				}
				else if (num == 2)
				{
					chatUIController.EventOnEnterTalkButtonClick -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9B9 RID: 117177 RVA: 0x008E6544 File Offset: 0x008E4744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChatTargetChanged(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Action<ChatChannel, string, string> value;
			int num = LuaObject.checkDelegate<Action<ChatChannel, string, string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					chatUIController.EventOnChatTargetChanged += value;
				}
				else if (num == 2)
				{
					chatUIController.EventOnChatTargetChanged -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9BA RID: 117178 RVA: 0x008E65C4 File Offset: 0x008E47C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9BB RID: 117179 RVA: 0x008E661C File Offset: 0x008E481C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			chatUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9BC RID: 117180 RVA: 0x008E6678 File Offset: 0x008E4878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastUpdateChatInfoListMaxIndex(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_luaExportHelper.m_lastUpdateChatInfoListMaxIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9BD RID: 117181 RVA: 0x008E66D0 File Offset: 0x008E48D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastUpdateChatInfoListMaxIndex(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			int lastUpdateChatInfoListMaxIndex;
			LuaObject.checkType(l, 2, out lastUpdateChatInfoListMaxIndex);
			chatUIController.m_luaExportHelper.m_lastUpdateChatInfoListMaxIndex = lastUpdateChatInfoListMaxIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9BE RID: 117182 RVA: 0x008E672C File Offset: 0x008E492C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_idList(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_luaExportHelper.m_idList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9BF RID: 117183 RVA: 0x008E6784 File Offset: 0x008E4984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_idList(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			List<string> idList;
			LuaObject.checkType<List<string>>(l, 2, out idList);
			chatUIController.m_luaExportHelper.m_idList = idList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9C0 RID: 117184 RVA: 0x008E67E0 File Offset: 0x008E49E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameList(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_luaExportHelper.m_nameList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9C1 RID: 117185 RVA: 0x008E6838 File Offset: 0x008E4A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameList(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			List<string> nameList;
			LuaObject.checkType<List<string>>(l, 2, out nameList);
			chatUIController.m_luaExportHelper.m_nameList = nameList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9C2 RID: 117186 RVA: 0x008E6894 File Offset: 0x008E4A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currPlayVoiceMsg(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_luaExportHelper.m_currPlayVoiceMsg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9C3 RID: 117187 RVA: 0x008E68EC File Offset: 0x008E4AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currPlayVoiceMsg(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient currPlayVoiceMsg;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out currPlayVoiceMsg);
			chatUIController.m_luaExportHelper.m_currPlayVoiceMsg = currPlayVoiceMsg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9C4 RID: 117188 RVA: 0x008E6948 File Offset: 0x008E4B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentChannel(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)chatUIController.m_luaExportHelper.m_currentChannel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9C5 RID: 117189 RVA: 0x008E69A0 File Offset: 0x008E4BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentChannel(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatChannel currentChannel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out currentChannel);
			chatUIController.m_luaExportHelper.m_currentChannel = currentChannel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9C6 RID: 117190 RVA: 0x008E69FC File Offset: 0x008E4BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastSelectButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_luaExportHelper.m_lastSelectButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9C7 RID: 117191 RVA: 0x008E6A54 File Offset: 0x008E4C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastSelectButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button lastSelectButton;
			LuaObject.checkType<Button>(l, 2, out lastSelectButton);
			chatUIController.m_luaExportHelper.m_lastSelectButton = lastSelectButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9C8 RID: 117192 RVA: 0x008E6AB0 File Offset: 0x008E4CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9C9 RID: 117193 RVA: 0x008E6B08 File Offset: 0x008E4D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			chatUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9CA RID: 117194 RVA: 0x008E6B64 File Offset: 0x008E4D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RoomInput(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.RoomInput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9CB RID: 117195 RVA: 0x008E6BB8 File Offset: 0x008E4DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoomInput(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			InputField roomInput;
			LuaObject.checkType<InputField>(l, 2, out roomInput);
			chatUIController.RoomInput = roomInput;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9CC RID: 117196 RVA: 0x008E6C10 File Offset: 0x008E4E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RoomIDShowText(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.RoomIDShowText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9CD RID: 117197 RVA: 0x008E6C64 File Offset: 0x008E4E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoomIDShowText(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Text roomIDShowText;
			LuaObject.checkType<Text>(l, 2, out roomIDShowText);
			chatUIController.RoomIDShowText = roomIDShowText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9CE RID: 117198 RVA: 0x008E6CBC File Offset: 0x008E4EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RoomRequireIDText(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.RoomRequireIDText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9CF RID: 117199 RVA: 0x008E6D10 File Offset: 0x008E4F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoomRequireIDText(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Text roomRequireIDText;
			LuaObject.checkType<Text>(l, 2, out roomRequireIDText);
			chatUIController.RoomRequireIDText = roomRequireIDText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9D0 RID: 117200 RVA: 0x008E6D68 File Offset: 0x008E4F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RoomIdShowRoot(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.RoomIdShowRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9D1 RID: 117201 RVA: 0x008E6DBC File Offset: 0x008E4FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoomIdShowRoot(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject roomIdShowRoot;
			LuaObject.checkType<GameObject>(l, 2, out roomIdShowRoot);
			chatUIController.RoomIdShowRoot = roomIdShowRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9D2 RID: 117202 RVA: 0x008E6E14 File Offset: 0x008E5014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChangeRoomButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.ChangeRoomButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9D3 RID: 117203 RVA: 0x008E6E68 File Offset: 0x008E5068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChangeRoomButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button changeRoomButton;
			LuaObject.checkType<Button>(l, 2, out changeRoomButton);
			chatUIController.ChangeRoomButton = changeRoomButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9D4 RID: 117204 RVA: 0x008E6EC0 File Offset: 0x008E50C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_voiceTimeText(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.voiceTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9D5 RID: 117205 RVA: 0x008E6F14 File Offset: 0x008E5114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_voiceTimeText(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Text voiceTimeText;
			LuaObject.checkType<Text>(l, 2, out voiceTimeText);
			chatUIController.voiceTimeText = voiceTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9D6 RID: 117206 RVA: 0x008E6F6C File Offset: 0x008E516C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_voiceRecordStateUICtrl(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.voiceRecordStateUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9D7 RID: 117207 RVA: 0x008E6FC0 File Offset: 0x008E51C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_voiceRecordStateUICtrl(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			CommonUIStateController voiceRecordStateUICtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out voiceRecordStateUICtrl);
			chatUIController.voiceRecordStateUICtrl = voiceRecordStateUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9D8 RID: 117208 RVA: 0x008E7018 File Offset: 0x008E5218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_recordTimeProgressBar(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.recordTimeProgressBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9D9 RID: 117209 RVA: 0x008E706C File Offset: 0x008E526C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_recordTimeProgressBar(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Image recordTimeProgressBar;
			LuaObject.checkType<Image>(l, 2, out recordTimeProgressBar);
			chatUIController.recordTimeProgressBar = recordTimeProgressBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9DA RID: 117210 RVA: 0x008E70C4 File Offset: 0x008E52C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_objPool(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.m_objPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9DB RID: 117211 RVA: 0x008E7118 File Offset: 0x008E5318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_objPool(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			EasyObjectPool objPool;
			LuaObject.checkType<EasyObjectPool>(l, 2, out objPool);
			chatUIController.m_objPool = objPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9DC RID: 117212 RVA: 0x008E7170 File Offset: 0x008E5370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UnusedRoot(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.UnusedRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9DD RID: 117213 RVA: 0x008E71C4 File Offset: 0x008E53C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UnusedRoot(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject unusedRoot;
			LuaObject.checkType<GameObject>(l, 2, out unusedRoot);
			chatUIController.UnusedRoot = unusedRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9DE RID: 117214 RVA: 0x008E721C File Offset: 0x008E541C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ListScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.ListScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9DF RID: 117215 RVA: 0x008E7270 File Offset: 0x008E5470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ListScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject listScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out listScrollViewContent);
			chatUIController.ListScrollViewContent = listScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9E0 RID: 117216 RVA: 0x008E72C8 File Offset: 0x008E54C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ScrollView(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.ScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9E1 RID: 117217 RVA: 0x008E731C File Offset: 0x008E551C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ScrollView(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatLoopVerticalScrollRect scrollView;
			LuaObject.checkType<ChatLoopVerticalScrollRect>(l, 2, out scrollView);
			chatUIController.ScrollView = scrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9E2 RID: 117218 RVA: 0x008E7374 File Offset: 0x008E5574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ViewPort(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.ViewPort);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9E3 RID: 117219 RVA: 0x008E73C8 File Offset: 0x008E55C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ViewPort(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			RectTransform viewPort;
			LuaObject.checkType<RectTransform>(l, 2, out viewPort);
			chatUIController.ViewPort = viewPort;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9E4 RID: 117220 RVA: 0x008E7420 File Offset: 0x008E5620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WorldButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.WorldButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9E5 RID: 117221 RVA: 0x008E7474 File Offset: 0x008E5674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WorldButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button worldButton;
			LuaObject.checkType<Button>(l, 2, out worldButton);
			chatUIController.WorldButton = worldButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9E6 RID: 117222 RVA: 0x008E74CC File Offset: 0x008E56CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SystemButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.SystemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9E7 RID: 117223 RVA: 0x008E7520 File Offset: 0x008E5720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SystemButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button systemButton;
			LuaObject.checkType<Button>(l, 2, out systemButton);
			chatUIController.SystemButton = systemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9E8 RID: 117224 RVA: 0x008E7578 File Offset: 0x008E5778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.TeamButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9E9 RID: 117225 RVA: 0x008E75CC File Offset: 0x008E57CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button teamButton;
			LuaObject.checkType<Button>(l, 2, out teamButton);
			chatUIController.TeamButton = teamButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9EA RID: 117226 RVA: 0x008E7624 File Offset: 0x008E5824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GroupButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.GroupButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9EB RID: 117227 RVA: 0x008E7678 File Offset: 0x008E5878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GroupButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button groupButton;
			LuaObject.checkType<Button>(l, 2, out groupButton);
			chatUIController.GroupButton = groupButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9EC RID: 117228 RVA: 0x008E76D0 File Offset: 0x008E58D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PrivateButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.PrivateButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9ED RID: 117229 RVA: 0x008E7724 File Offset: 0x008E5924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PrivateButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button privateButton;
			LuaObject.checkType<Button>(l, 2, out privateButton);
			chatUIController.PrivateButton = privateButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9EE RID: 117230 RVA: 0x008E777C File Offset: 0x008E597C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.GuildButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9EF RID: 117231 RVA: 0x008E77D0 File Offset: 0x008E59D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GuildButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button guildButton;
			LuaObject.checkType<Button>(l, 2, out guildButton);
			chatUIController.GuildButton = guildButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9F0 RID: 117232 RVA: 0x008E7828 File Offset: 0x008E5A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WorldToggleRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.WorldToggleRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9F1 RID: 117233 RVA: 0x008E787C File Offset: 0x008E5A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WorldToggleRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject worldToggleRedMark;
			LuaObject.checkType<GameObject>(l, 2, out worldToggleRedMark);
			chatUIController.WorldToggleRedMark = worldToggleRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9F2 RID: 117234 RVA: 0x008E78D4 File Offset: 0x008E5AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SystemToggleRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.SystemToggleRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9F3 RID: 117235 RVA: 0x008E7928 File Offset: 0x008E5B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SystemToggleRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject systemToggleRedMark;
			LuaObject.checkType<GameObject>(l, 2, out systemToggleRedMark);
			chatUIController.SystemToggleRedMark = systemToggleRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9F4 RID: 117236 RVA: 0x008E7980 File Offset: 0x008E5B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamToggleRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.TeamToggleRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9F5 RID: 117237 RVA: 0x008E79D4 File Offset: 0x008E5BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamToggleRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject teamToggleRedMark;
			LuaObject.checkType<GameObject>(l, 2, out teamToggleRedMark);
			chatUIController.TeamToggleRedMark = teamToggleRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9F6 RID: 117238 RVA: 0x008E7A2C File Offset: 0x008E5C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GroupToggleRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.GroupToggleRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9F7 RID: 117239 RVA: 0x008E7A80 File Offset: 0x008E5C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GroupToggleRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject groupToggleRedMark;
			LuaObject.checkType<GameObject>(l, 2, out groupToggleRedMark);
			chatUIController.GroupToggleRedMark = groupToggleRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9F8 RID: 117240 RVA: 0x008E7AD8 File Offset: 0x008E5CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PrivateToggleRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.PrivateToggleRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9F9 RID: 117241 RVA: 0x008E7B2C File Offset: 0x008E5D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PrivateToggleRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject privateToggleRedMark;
			LuaObject.checkType<GameObject>(l, 2, out privateToggleRedMark);
			chatUIController.PrivateToggleRedMark = privateToggleRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9FA RID: 117242 RVA: 0x008E7B84 File Offset: 0x008E5D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildToggleRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.GuildToggleRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9FB RID: 117243 RVA: 0x008E7BD8 File Offset: 0x008E5DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GuildToggleRedMark(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject guildToggleRedMark;
			LuaObject.checkType<GameObject>(l, 2, out guildToggleRedMark);
			chatUIController.GuildToggleRedMark = guildToggleRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9FC RID: 117244 RVA: 0x008E7C30 File Offset: 0x008E5E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CloseButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.CloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9FD RID: 117245 RVA: 0x008E7C84 File Offset: 0x008E5E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CloseButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button closeButton;
			LuaObject.checkType<Button>(l, 2, out closeButton);
			chatUIController.CloseButton = closeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9FE RID: 117246 RVA: 0x008E7CDC File Offset: 0x008E5EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BGButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.BGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C9FF RID: 117247 RVA: 0x008E7D30 File Offset: 0x008E5F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BGButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button bgbutton;
			LuaObject.checkType<Button>(l, 2, out bgbutton);
			chatUIController.BGButton = bgbutton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA00 RID: 117248 RVA: 0x008E7D88 File Offset: 0x008E5F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EmptyPanel(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.EmptyPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA01 RID: 117249 RVA: 0x008E7DDC File Offset: 0x008E5FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EmptyPanel(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject emptyPanel;
			LuaObject.checkType<GameObject>(l, 2, out emptyPanel);
			chatUIController.EmptyPanel = emptyPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA02 RID: 117250 RVA: 0x008E7E34 File Offset: 0x008E6034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NewChatTip(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.NewChatTip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA03 RID: 117251 RVA: 0x008E7E88 File Offset: 0x008E6088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NewChatTip(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button newChatTip;
			LuaObject.checkType<Button>(l, 2, out newChatTip);
			chatUIController.NewChatTip = newChatTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA04 RID: 117252 RVA: 0x008E7EE0 File Offset: 0x008E60E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TalkButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.TalkButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA05 RID: 117253 RVA: 0x008E7F34 File Offset: 0x008E6134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TalkButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button talkButton;
			LuaObject.checkType<Button>(l, 2, out talkButton);
			chatUIController.TalkButton = talkButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA06 RID: 117254 RVA: 0x008E7F8C File Offset: 0x008E618C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExpressionFunctionButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.ExpressionFunctionButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA07 RID: 117255 RVA: 0x008E7FE0 File Offset: 0x008E61E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExpressionFunctionButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Button expressionFunctionButton;
			LuaObject.checkType<Button>(l, 2, out expressionFunctionButton);
			chatUIController.ExpressionFunctionButton = expressionFunctionButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA08 RID: 117256 RVA: 0x008E8038 File Offset: 0x008E6238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InputPanel(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.InputPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA09 RID: 117257 RVA: 0x008E808C File Offset: 0x008E628C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_InputPanel(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			InputField inputPanel;
			LuaObject.checkType<InputField>(l, 2, out inputPanel);
			chatUIController.InputPanel = inputPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA0A RID: 117258 RVA: 0x008E80E4 File Offset: 0x008E62E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Placeholder(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.Placeholder);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA0B RID: 117259 RVA: 0x008E8138 File Offset: 0x008E6338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Placeholder(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Text placeholder;
			LuaObject.checkType<Text>(l, 2, out placeholder);
			chatUIController.Placeholder = placeholder;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA0C RID: 117260 RVA: 0x008E8190 File Offset: 0x008E6390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ContentText(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.ContentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA0D RID: 117261 RVA: 0x008E81E4 File Offset: 0x008E63E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ContentText(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Text contentText;
			LuaObject.checkType<Text>(l, 2, out contentText);
			chatUIController.ContentText = contentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA0E RID: 117262 RVA: 0x008E823C File Offset: 0x008E643C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SendButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.SendButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA0F RID: 117263 RVA: 0x008E8290 File Offset: 0x008E6490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SendButton(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ButtonEx sendButton;
			LuaObject.checkType<ButtonEx>(l, 2, out sendButton);
			chatUIController.SendButton = sendButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA10 RID: 117264 RVA: 0x008E82E8 File Offset: 0x008E64E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CantInputObj(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.CantInputObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA11 RID: 117265 RVA: 0x008E833C File Offset: 0x008E653C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CantInputObj(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject cantInputObj;
			LuaObject.checkType<GameObject>(l, 2, out cantInputObj);
			chatUIController.CantInputObj = cantInputObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA12 RID: 117266 RVA: 0x008E8394 File Offset: 0x008E6594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChooseListRoot(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.ChooseListRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA13 RID: 117267 RVA: 0x008E83E8 File Offset: 0x008E65E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChooseListRoot(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			GameObject chooseListRoot;
			LuaObject.checkType<GameObject>(l, 2, out chooseListRoot);
			chatUIController.ChooseListRoot = chooseListRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA14 RID: 117268 RVA: 0x008E8440 File Offset: 0x008E6640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatTargetChooseDropdown(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.ChatTargetChooseDropdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA15 RID: 117269 RVA: 0x008E8494 File Offset: 0x008E6694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChatTargetChooseDropdown(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Dropdown chatTargetChooseDropdown;
			LuaObject.checkType<Dropdown>(l, 2, out chatTargetChooseDropdown);
			chatUIController.ChatTargetChooseDropdown = chatTargetChooseDropdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA16 RID: 117270 RVA: 0x008E84EC File Offset: 0x008E66EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerNameLabel(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.PlayerNameLabel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA17 RID: 117271 RVA: 0x008E8540 File Offset: 0x008E6740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerNameLabel(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			Text playerNameLabel;
			LuaObject.checkType<Text>(l, 2, out playerNameLabel);
			chatUIController.PlayerNameLabel = playerNameLabel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA18 RID: 117272 RVA: 0x008E8598 File Offset: 0x008E6798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_emojiInfoTxtName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatUIController.LuaExportHelper.emojiInfoTxtName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA19 RID: 117273 RVA: 0x008E85E0 File Offset: 0x008E67E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_emojiShowAssetName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatUIController.LuaExportHelper.emojiShowAssetName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA1A RID: 117274 RVA: 0x008E8628 File Offset: 0x008E6828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatManagerItem(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatUIController.LuaExportHelper.ChatManagerItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA1B RID: 117275 RVA: 0x008E8670 File Offset: 0x008E6870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LeftWorldChatItem(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatUIController.LuaExportHelper.LeftWorldChatItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA1C RID: 117276 RVA: 0x008E86B8 File Offset: 0x008E68B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RightWorldChatItem(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatUIController.LuaExportHelper.RightWorldChatItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA1D RID: 117277 RVA: 0x008E8700 File Offset: 0x008E6900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LeftSystemChatItem(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatUIController.LuaExportHelper.LeftSystemChatItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA1E RID: 117278 RVA: 0x008E8748 File Offset: 0x008E6948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatManagerItemPoolName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatUIController.LuaExportHelper.ChatManagerItemPoolName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA1F RID: 117279 RVA: 0x008E8790 File Offset: 0x008E6990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LeftWorldChatItemPoolName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatUIController.LuaExportHelper.LeftWorldChatItemPoolName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA20 RID: 117280 RVA: 0x008E87D8 File Offset: 0x008E69D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RightWorldChatItemPoolName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatUIController.LuaExportHelper.RightWorldChatItemPoolName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA21 RID: 117281 RVA: 0x008E8820 File Offset: 0x008E6A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LeftSystemChatItemPoolName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ChatUIController.LuaExportHelper.LeftSystemChatItemPoolName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA22 RID: 117282 RVA: 0x008E8868 File Offset: 0x008E6A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CurrPlayVoiceMsg(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatUIController.CurrPlayVoiceMsg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA23 RID: 117283 RVA: 0x008E88BC File Offset: 0x008E6ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CurrPlayVoiceMsg(IntPtr l)
	{
		int result;
		try
		{
			ChatUIController chatUIController = (ChatUIController)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient currPlayVoiceMsg;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out currPlayVoiceMsg);
			chatUIController.CurrPlayVoiceMsg = currPlayVoiceMsg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CA24 RID: 117284 RVA: 0x008E8914 File Offset: 0x008E6B14
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChatUIController");
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.RefreshDropDownList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.ShowOrHidePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.ShowNewChatTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.InputFieldTextAppend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.UpdateChatList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.UpdateChatCacheInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.GetChannelToggleSelectState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.SetChannelToggleSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.IsScrollViewInEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.UpdateChooseChatPlayerOrGroupListInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.ShowOrHideChooseChatTargetPannel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.SetTalkButtonSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.ShowVoiceRecordTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.HideVoiceRecordTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.ShowVoiceCancelTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.ShowVoiceShortTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.UpdateVoiceRecordTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.RegItemButtonClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.SetRoomIdTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.EnableRoomIdShow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.CloseAllTableRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.SetTableRedMark);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.ClearChatContent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.FindChannelButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnRoomIdInputEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnExpressionFunctionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnTalkButtonClickDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnTalkButtonTestHoding);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnTalkButtonClickUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnExitTalkButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnEnterTalkButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnSendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnTableSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnChatTargetChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnChooseTargetRootClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnChangeRoomButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.InputPanel_OnEndEdit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.OnChatItemFill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.GetShowChatItemPoolName4Info);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.SetScrollViewToBottom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callDele_EventOnTableChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__clearDele_EventOnTableChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callDele_EventOnSendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__clearDele_EventOnSendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callDele_EventOnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__clearDele_EventOnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callDele_EventOnExpressionFunctionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__clearDele_EventOnExpressionFunctionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callDele_EventOnRoomIdInputEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__clearDele_EventOnRoomIdInputEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callDele_EventOnTalkButtonHold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__clearDele_EventOnTalkButtonHold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callDele_EventOnTalkButtonClickUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__clearDele_EventOnTalkButtonClickUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callDele_EventOnExitTalkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__clearDele_EventOnExitTalkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callDele_EventOnEnterTalkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__clearDele_EventOnEnterTalkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callDele_EventOnChatTargetChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__clearDele_EventOnChatTargetChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callDele_m_itemVoiceButtonClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__clearDele_m_itemVoiceButtonClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__callDele_m_itemPlayerIconClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.__clearDele_m_itemPlayerIconClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache4F);
		string name = "m_InputFocused";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_InputFocused);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_InputFocused);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache51, true);
		string name2 = "m_itemVoiceButtonClickEvent";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_itemVoiceButtonClickEvent);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache52, true);
		string name3 = "m_itemPlayerIconClickEvent";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_itemPlayerIconClickEvent);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache53, true);
		string name4 = "m_currentTableType";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_currentTableType);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_currentTableType);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache55, true);
		string name5 = "m_currentChatList";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_currentChatList);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_currentChatList);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache57, true);
		string name6 = "m_redMarkObjs";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_redMarkObjs);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_redMarkObjs);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache59, true);
		string name7 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_playerContext);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5B, true);
		string name8 = "EventOnTableChange";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_EventOnTableChange);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5C, true);
		string name9 = "EventOnSendButtonClick";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_EventOnSendButtonClick);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5D, true);
		string name10 = "EventOnCloseButtonClick";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_EventOnCloseButtonClick);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5E, true);
		string name11 = "EventOnExpressionFunctionButtonClick";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_EventOnExpressionFunctionButtonClick);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache5F, true);
		string name12 = "EventOnRoomIdInputEnd";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_EventOnRoomIdInputEnd);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache60, true);
		string name13 = "EventOnTalkButtonHold";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_EventOnTalkButtonHold);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache61, true);
		string name14 = "m_coroutineTalkButtonTestHolding";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_coroutineTalkButtonTestHolding);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_coroutineTalkButtonTestHolding);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache63, true);
		string name15 = "EventOnTalkButtonClickUp";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_EventOnTalkButtonClickUp);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache64, true);
		string name16 = "EventOnExitTalkButtonClick";
		LuaCSFunction get16 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_EventOnExitTalkButtonClick);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache65, true);
		string name17 = "EventOnEnterTalkButtonClick";
		LuaCSFunction get17 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_EventOnEnterTalkButtonClick);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache66, true);
		string name18 = "EventOnChatTargetChanged";
		LuaCSFunction get18 = null;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_EventOnChatTargetChanged);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache67, true);
		string name19 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_configDataLoader);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache69, true);
		string name20 = "m_lastUpdateChatInfoListMaxIndex";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_lastUpdateChatInfoListMaxIndex);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_lastUpdateChatInfoListMaxIndex);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6B, true);
		string name21 = "m_idList";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_idList);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_idList);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6D, true);
		string name22 = "m_nameList";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_nameList);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_nameList);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache6F, true);
		string name23 = "m_currPlayVoiceMsg";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_currPlayVoiceMsg);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_currPlayVoiceMsg);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache71, true);
		string name24 = "m_currentChannel";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_currentChannel);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_currentChannel);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache73, true);
		string name25 = "m_lastSelectButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_lastSelectButton);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_lastSelectButton);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache75, true);
		string name26 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_marginTransform);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache77, true);
		string name27 = "RoomInput";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_RoomInput);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_RoomInput);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache79, true);
		string name28 = "RoomIDShowText";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_RoomIDShowText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_RoomIDShowText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7B, true);
		string name29 = "RoomRequireIDText";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_RoomRequireIDText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_RoomRequireIDText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7D, true);
		string name30 = "RoomIdShowRoot";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_RoomIdShowRoot);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_RoomIdShowRoot);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache7F, true);
		string name31 = "ChangeRoomButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_ChangeRoomButton);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_ChangeRoomButton);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache81, true);
		string name32 = "voiceTimeText";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_voiceTimeText);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_voiceTimeText);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache83, true);
		string name33 = "voiceRecordStateUICtrl";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_voiceRecordStateUICtrl);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_voiceRecordStateUICtrl);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache85, true);
		string name34 = "recordTimeProgressBar";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_recordTimeProgressBar);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_recordTimeProgressBar);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache87, true);
		string name35 = "m_objPool";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_m_objPool);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_m_objPool);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache89, true);
		string name36 = "UnusedRoot";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_UnusedRoot);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_UnusedRoot);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8B, true);
		string name37 = "ListScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_ListScrollViewContent);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_ListScrollViewContent);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8D, true);
		string name38 = "ScrollView";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_ScrollView);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_ScrollView);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache8F, true);
		string name39 = "ViewPort";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_ViewPort);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_ViewPort);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache91, true);
		string name40 = "WorldButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_WorldButton);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_WorldButton);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache93, true);
		string name41 = "SystemButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_SystemButton);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_SystemButton);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache95, true);
		string name42 = "TeamButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_TeamButton);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_TeamButton);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache97, true);
		string name43 = "GroupButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_GroupButton);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_GroupButton);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache99, true);
		string name44 = "PrivateButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_PrivateButton);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_PrivateButton);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9B, true);
		string name45 = "GuildButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_GuildButton);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_GuildButton);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9D, true);
		string name46 = "WorldToggleRedMark";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_WorldToggleRedMark);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_WorldToggleRedMark);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cache9F, true);
		string name47 = "SystemToggleRedMark";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_SystemToggleRedMark);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_SystemToggleRedMark);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA1, true);
		string name48 = "TeamToggleRedMark";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_TeamToggleRedMark);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_TeamToggleRedMark);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA3, true);
		string name49 = "GroupToggleRedMark";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_GroupToggleRedMark);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_GroupToggleRedMark);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA5, true);
		string name50 = "PrivateToggleRedMark";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_PrivateToggleRedMark);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_PrivateToggleRedMark);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA7, true);
		string name51 = "GuildToggleRedMark";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_GuildToggleRedMark);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_GuildToggleRedMark);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheA9, true);
		string name52 = "CloseButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_CloseButton);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_CloseButton);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAB, true);
		string name53 = "BGButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_BGButton);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_BGButton);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAD, true);
		string name54 = "EmptyPanel";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_EmptyPanel);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_EmptyPanel);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheAF, true);
		string name55 = "NewChatTip";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_NewChatTip);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_NewChatTip);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB1, true);
		string name56 = "TalkButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_TalkButton);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_TalkButton);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB3, true);
		string name57 = "ExpressionFunctionButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_ExpressionFunctionButton);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_ExpressionFunctionButton);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB5, true);
		string name58 = "InputPanel";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_InputPanel);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_InputPanel);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB7, true);
		string name59 = "Placeholder";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_Placeholder);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_Placeholder);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheB9, true);
		string name60 = "ContentText";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_ContentText);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_ContentText);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBB, true);
		string name61 = "SendButton";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_SendButton);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_SendButton);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBD, true);
		string name62 = "CantInputObj";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_CantInputObj);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_CantInputObj);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheBF, true);
		string name63 = "ChooseListRoot";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_ChooseListRoot);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_ChooseListRoot);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC1, true);
		string name64 = "ChatTargetChooseDropdown";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_ChatTargetChooseDropdown);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_ChatTargetChooseDropdown);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC3, true);
		string name65 = "PlayerNameLabel";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_PlayerNameLabel);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_PlayerNameLabel);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC5, true);
		string name66 = "emojiInfoTxtName";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_emojiInfoTxtName);
		}
		LuaObject.addMember(l, name66, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC6, null, false);
		string name67 = "emojiShowAssetName";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_emojiShowAssetName);
		}
		LuaObject.addMember(l, name67, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC7, null, false);
		string name68 = "ChatManagerItem";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_ChatManagerItem);
		}
		LuaObject.addMember(l, name68, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC8, null, false);
		string name69 = "LeftWorldChatItem";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_LeftWorldChatItem);
		}
		LuaObject.addMember(l, name69, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheC9, null, false);
		string name70 = "RightWorldChatItem";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_RightWorldChatItem);
		}
		LuaObject.addMember(l, name70, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCA, null, false);
		string name71 = "LeftSystemChatItem";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_LeftSystemChatItem);
		}
		LuaObject.addMember(l, name71, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCB, null, false);
		string name72 = "ChatManagerItemPoolName";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_ChatManagerItemPoolName);
		}
		LuaObject.addMember(l, name72, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCC, null, false);
		string name73 = "LeftWorldChatItemPoolName";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_LeftWorldChatItemPoolName);
		}
		LuaObject.addMember(l, name73, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCD, null, false);
		string name74 = "RightWorldChatItemPoolName";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_RightWorldChatItemPoolName);
		}
		LuaObject.addMember(l, name74, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCE, null, false);
		string name75 = "LeftSystemChatItemPoolName";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_LeftSystemChatItemPoolName);
		}
		LuaObject.addMember(l, name75, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheCF, null, false);
		string name76 = "CurrPlayVoiceMsg";
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.get_CurrPlayVoiceMsg);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatUIController.set_CurrPlayVoiceMsg);
		}
		LuaObject.addMember(l, name76, get66, Lua_BlackJack_ProjectL_UI_ChatUIController.<>f__mg$cacheD1, true);
		LuaObject.createTypeMetatable(l, null, typeof(ChatUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012B5A RID: 76634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012B5B RID: 76635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012B5C RID: 76636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012B5D RID: 76637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012B5E RID: 76638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012B5F RID: 76639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012B60 RID: 76640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012B61 RID: 76641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012B62 RID: 76642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012B63 RID: 76643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012B64 RID: 76644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012B65 RID: 76645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012B66 RID: 76646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012B67 RID: 76647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012B68 RID: 76648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012B69 RID: 76649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012B6A RID: 76650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012B6B RID: 76651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012B6C RID: 76652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012B6D RID: 76653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012B6E RID: 76654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012B6F RID: 76655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012B70 RID: 76656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012B71 RID: 76657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012B72 RID: 76658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012B73 RID: 76659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012B74 RID: 76660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012B75 RID: 76661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012B76 RID: 76662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012B77 RID: 76663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012B78 RID: 76664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012B79 RID: 76665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012B7A RID: 76666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012B7B RID: 76667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012B7C RID: 76668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012B7D RID: 76669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012B7E RID: 76670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012B7F RID: 76671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012B80 RID: 76672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012B81 RID: 76673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012B82 RID: 76674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012B83 RID: 76675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012B84 RID: 76676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012B85 RID: 76677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012B86 RID: 76678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012B87 RID: 76679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012B88 RID: 76680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012B89 RID: 76681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012B8A RID: 76682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012B8B RID: 76683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012B8C RID: 76684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012B8D RID: 76685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012B8E RID: 76686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012B8F RID: 76687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012B90 RID: 76688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012B91 RID: 76689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012B92 RID: 76690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012B93 RID: 76691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04012B94 RID: 76692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012B95 RID: 76693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04012B96 RID: 76694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04012B97 RID: 76695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04012B98 RID: 76696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04012B99 RID: 76697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04012B9A RID: 76698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04012B9B RID: 76699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04012B9C RID: 76700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04012B9D RID: 76701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04012B9E RID: 76702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04012B9F RID: 76703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04012BA0 RID: 76704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04012BA1 RID: 76705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04012BA2 RID: 76706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04012BA3 RID: 76707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04012BA4 RID: 76708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04012BA5 RID: 76709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04012BA6 RID: 76710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04012BA7 RID: 76711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04012BA8 RID: 76712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04012BA9 RID: 76713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04012BAA RID: 76714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04012BAB RID: 76715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04012BAC RID: 76716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04012BAD RID: 76717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04012BAE RID: 76718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04012BAF RID: 76719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04012BB0 RID: 76720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04012BB1 RID: 76721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04012BB2 RID: 76722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04012BB3 RID: 76723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04012BB4 RID: 76724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04012BB5 RID: 76725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04012BB6 RID: 76726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04012BB7 RID: 76727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04012BB8 RID: 76728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04012BB9 RID: 76729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04012BBA RID: 76730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04012BBB RID: 76731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04012BBC RID: 76732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04012BBD RID: 76733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04012BBE RID: 76734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04012BBF RID: 76735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04012BC0 RID: 76736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04012BC1 RID: 76737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04012BC2 RID: 76738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04012BC3 RID: 76739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04012BC4 RID: 76740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04012BC5 RID: 76741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04012BC6 RID: 76742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04012BC7 RID: 76743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04012BC8 RID: 76744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04012BC9 RID: 76745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04012BCA RID: 76746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04012BCB RID: 76747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04012BCC RID: 76748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04012BCD RID: 76749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04012BCE RID: 76750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04012BCF RID: 76751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04012BD0 RID: 76752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04012BD1 RID: 76753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04012BD2 RID: 76754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04012BD3 RID: 76755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04012BD4 RID: 76756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04012BD5 RID: 76757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04012BD6 RID: 76758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04012BD7 RID: 76759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04012BD8 RID: 76760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04012BD9 RID: 76761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04012BDA RID: 76762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04012BDB RID: 76763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04012BDC RID: 76764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04012BDD RID: 76765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04012BDE RID: 76766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04012BDF RID: 76767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04012BE0 RID: 76768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04012BE1 RID: 76769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04012BE2 RID: 76770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04012BE3 RID: 76771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04012BE4 RID: 76772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04012BE5 RID: 76773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04012BE6 RID: 76774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04012BE7 RID: 76775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04012BE8 RID: 76776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04012BE9 RID: 76777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04012BEA RID: 76778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04012BEB RID: 76779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04012BEC RID: 76780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04012BED RID: 76781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04012BEE RID: 76782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04012BEF RID: 76783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04012BF0 RID: 76784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04012BF1 RID: 76785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04012BF2 RID: 76786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04012BF3 RID: 76787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04012BF4 RID: 76788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04012BF5 RID: 76789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04012BF6 RID: 76790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04012BF7 RID: 76791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04012BF8 RID: 76792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04012BF9 RID: 76793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04012BFA RID: 76794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04012BFB RID: 76795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04012BFC RID: 76796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04012BFD RID: 76797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04012BFE RID: 76798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04012BFF RID: 76799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04012C00 RID: 76800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04012C01 RID: 76801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04012C02 RID: 76802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04012C03 RID: 76803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04012C04 RID: 76804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04012C05 RID: 76805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04012C06 RID: 76806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04012C07 RID: 76807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04012C08 RID: 76808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04012C09 RID: 76809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04012C0A RID: 76810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04012C0B RID: 76811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04012C0C RID: 76812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04012C0D RID: 76813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04012C0E RID: 76814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04012C0F RID: 76815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04012C10 RID: 76816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04012C11 RID: 76817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x04012C12 RID: 76818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x04012C13 RID: 76819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x04012C14 RID: 76820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x04012C15 RID: 76821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x04012C16 RID: 76822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x04012C17 RID: 76823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x04012C18 RID: 76824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x04012C19 RID: 76825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x04012C1A RID: 76826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04012C1B RID: 76827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04012C1C RID: 76828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04012C1D RID: 76829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04012C1E RID: 76830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x04012C1F RID: 76831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x04012C20 RID: 76832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x04012C21 RID: 76833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x04012C22 RID: 76834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x04012C23 RID: 76835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04012C24 RID: 76836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x04012C25 RID: 76837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x04012C26 RID: 76838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x04012C27 RID: 76839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x04012C28 RID: 76840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x04012C29 RID: 76841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x04012C2A RID: 76842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04012C2B RID: 76843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;
}
