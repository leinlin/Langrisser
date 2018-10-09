using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001525 RID: 5413
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController : LuaObject
{
	// Token: 0x0602021D RID: 131613 RVA: 0x00AA7534 File Offset: 0x00AA5734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateChatInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient chatClientInfo;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out chatClientInfo);
			bool isPlaying;
			LuaObject.checkType(l, 3, out isPlaying);
			playerChatItemUIController.UpdateChatInfo(chatClientInfo, isPlaying);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602021E RID: 131614 RVA: 0x00AA7598 File Offset: 0x00AA5798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitEmojiText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			int fontSize;
			LuaObject.checkType(l, 2, out fontSize);
			Image image;
			LuaObject.checkType<Image>(l, 3, out image);
			playerChatItemUIController.InitEmojiText(fontSize, image);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602021F RID: 131615 RVA: 0x00AA75FC File Offset: 0x00AA57FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsPlaying(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			bool b = playerChatItemUIController.IsPlaying();
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

	// Token: 0x06020220 RID: 131616 RVA: 0x00AA7650 File Offset: 0x00AA5850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayState(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			bool playState;
			LuaObject.checkType(l, 2, out playState);
			playerChatItemUIController.SetPlayState(playState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020221 RID: 131617 RVA: 0x00AA76A8 File Offset: 0x00AA58A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegClickEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Action<ChatComponent.ChatMessageClient> voiceAction;
			LuaObject.checkDelegate<Action<ChatComponent.ChatMessageClient>>(l, 2, out voiceAction);
			Action<ChatMessage, GameObject> playeIconAction;
			LuaObject.checkDelegate<Action<ChatMessage, GameObject>>(l, 3, out playeIconAction);
			playerChatItemUIController.RegClickEvent(voiceAction, playeIconAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020222 RID: 131618 RVA: 0x00AA770C File Offset: 0x00AA590C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			playerChatItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020223 RID: 131619 RVA: 0x00AA7760 File Offset: 0x00AA5960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToVoiceMode(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			playerChatItemUIController.m_luaExportHelper.SetToVoiceMode();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020224 RID: 131620 RVA: 0x00AA77B4 File Offset: 0x00AA59B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToTextMode(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			playerChatItemUIController.m_luaExportHelper.SetToTextMode();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020225 RID: 131621 RVA: 0x00AA7808 File Offset: 0x00AA5A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToBigExpressionMode(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			playerChatItemUIController.m_luaExportHelper.SetToBigExpressionMode();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020226 RID: 131622 RVA: 0x00AA785C File Offset: 0x00AA5A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChatMsgTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			DateTime chatMsgTime;
			LuaObject.checkValueType<DateTime>(l, 2, out chatMsgTime);
			string s = playerChatItemUIController.m_luaExportHelper.SetChatMsgTime(chatMsgTime);
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

	// Token: 0x06020227 RID: 131623 RVA: 0x00AA78C4 File Offset: 0x00AA5AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnVoiceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			playerChatItemUIController.m_luaExportHelper.OnVoiceButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020228 RID: 131624 RVA: 0x00AA7918 File Offset: 0x00AA5B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayerHeadClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			playerChatItemUIController.m_luaExportHelper.OnPlayerHeadClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020229 RID: 131625 RVA: 0x00AA796C File Offset: 0x00AA5B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			playerChatItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602022A RID: 131626 RVA: 0x00AA79D8 File Offset: 0x00AA5BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			playerChatItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602022B RID: 131627 RVA: 0x00AA7A2C File Offset: 0x00AA5C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			playerChatItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602022C RID: 131628 RVA: 0x00AA7A80 File Offset: 0x00AA5C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = playerChatItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602022D RID: 131629 RVA: 0x00AA7B28 File Offset: 0x00AA5D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			playerChatItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602022E RID: 131630 RVA: 0x00AA7B7C File Offset: 0x00AA5D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			playerChatItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602022F RID: 131631 RVA: 0x00AA7BE8 File Offset: 0x00AA5DE8
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
				PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				playerChatItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PlayerChatItemUIController playerChatItemUIController2 = (PlayerChatItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				playerChatItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020230 RID: 131632 RVA: 0x00AA7CF8 File Offset: 0x00AA5EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerChatItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020231 RID: 131633 RVA: 0x00AA7D64 File Offset: 0x00AA5F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerChatItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020232 RID: 131634 RVA: 0x00AA7DD0 File Offset: 0x00AA5FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerChatItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020233 RID: 131635 RVA: 0x00AA7E3C File Offset: 0x00AA603C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerChatItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020234 RID: 131636 RVA: 0x00AA7EA8 File Offset: 0x00AA60A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				playerChatItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PlayerChatItemUIController playerChatItemUIController2 = (PlayerChatItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				playerChatItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020235 RID: 131637 RVA: 0x00AA7FB8 File Offset: 0x00AA61B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			string s = playerChatItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020236 RID: 131638 RVA: 0x00AA8014 File Offset: 0x00AA6214
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnVoiceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient obj;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out obj);
			playerChatItemUIController.m_luaExportHelper.__callDele_EventOnVoiceButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020237 RID: 131639 RVA: 0x00AA8070 File Offset: 0x00AA6270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnVoiceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient obj;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out obj);
			playerChatItemUIController.m_luaExportHelper.__clearDele_EventOnVoiceButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020238 RID: 131640 RVA: 0x00AA80CC File Offset: 0x00AA62CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPlayerHeadClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			ChatMessage arg;
			LuaObject.checkType<ChatMessage>(l, 2, out arg);
			GameObject arg2;
			LuaObject.checkType<GameObject>(l, 3, out arg2);
			playerChatItemUIController.m_luaExportHelper.__callDele_EventOnPlayerHeadClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020239 RID: 131641 RVA: 0x00AA8138 File Offset: 0x00AA6338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPlayerHeadClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			ChatMessage arg;
			LuaObject.checkType<ChatMessage>(l, 2, out arg);
			GameObject arg2;
			LuaObject.checkType<GameObject>(l, 3, out arg2);
			playerChatItemUIController.m_luaExportHelper.__clearDele_EventOnPlayerHeadClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602023A RID: 131642 RVA: 0x00AA81A4 File Offset: 0x00AA63A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnVoiceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Action<ChatComponent.ChatMessageClient> value;
			int num = LuaObject.checkDelegate<Action<ChatComponent.ChatMessageClient>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerChatItemUIController.EventOnVoiceButtonClick += value;
				}
				else if (num == 2)
				{
					playerChatItemUIController.EventOnVoiceButtonClick -= value;
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

	// Token: 0x0602023B RID: 131643 RVA: 0x00AA8224 File Offset: 0x00AA6424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPlayerHeadClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Action<ChatMessage, GameObject> value;
			int num = LuaObject.checkDelegate<Action<ChatMessage, GameObject>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerChatItemUIController.EventOnPlayerHeadClick += value;
				}
				else if (num == 2)
				{
					playerChatItemUIController.EventOnPlayerHeadClick -= value;
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

	// Token: 0x0602023C RID: 131644 RVA: 0x00AA82A4 File Offset: 0x00AA64A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isUIEventInited(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.m_luaExportHelper.m_isUIEventInited);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602023D RID: 131645 RVA: 0x00AA82FC File Offset: 0x00AA64FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isUIEventInited(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			bool isUIEventInited;
			LuaObject.checkType(l, 2, out isUIEventInited);
			playerChatItemUIController.m_luaExportHelper.m_isUIEventInited = isUIEventInited;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602023E RID: 131646 RVA: 0x00AA8358 File Offset: 0x00AA6558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isEmojiTextInit(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.m_isEmojiTextInit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602023F RID: 131647 RVA: 0x00AA83AC File Offset: 0x00AA65AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isEmojiTextInit(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			bool isEmojiTextInit;
			LuaObject.checkType(l, 2, out isEmojiTextInit);
			playerChatItemUIController.m_isEmojiTextInit = isEmojiTextInit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020240 RID: 131648 RVA: 0x00AA8404 File Offset: 0x00AA6604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currChatInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.m_currChatInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020241 RID: 131649 RVA: 0x00AA8458 File Offset: 0x00AA6658
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_currChatInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			ChatComponent.ChatMessageClient currChatInfo;
			LuaObject.checkType<ChatComponent.ChatMessageClient>(l, 2, out currChatInfo);
			playerChatItemUIController.m_currChatInfo = currChatInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020242 RID: 131650 RVA: 0x00AA84B0 File Offset: 0x00AA66B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.PlayerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020243 RID: 131651 RVA: 0x00AA8504 File Offset: 0x00AA6704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			playerChatItemUIController.PlayerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020244 RID: 131652 RVA: 0x00AA855C File Offset: 0x00AA675C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SendTimeText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.SendTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020245 RID: 131653 RVA: 0x00AA85B0 File Offset: 0x00AA67B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SendTimeText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Text sendTimeText;
			LuaObject.checkType<Text>(l, 2, out sendTimeText);
			playerChatItemUIController.SendTimeText = sendTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020246 RID: 131654 RVA: 0x00AA8608 File Offset: 0x00AA6808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerIconImage(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.PlayerIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020247 RID: 131655 RVA: 0x00AA865C File Offset: 0x00AA685C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerIconImage(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Image playerIconImage;
			LuaObject.checkType<Image>(l, 2, out playerIconImage);
			playerChatItemUIController.PlayerIconImage = playerIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020248 RID: 131656 RVA: 0x00AA86B4 File Offset: 0x00AA68B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.PlayerHeadFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020249 RID: 131657 RVA: 0x00AA8708 File Offset: 0x00AA6908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Transform playerHeadFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out playerHeadFrameTransform);
			playerChatItemUIController.PlayerHeadFrameTransform = playerHeadFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602024A RID: 131658 RVA: 0x00AA8760 File Offset: 0x00AA6960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerLevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.PlayerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602024B RID: 131659 RVA: 0x00AA87B4 File Offset: 0x00AA69B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PlayerLevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			playerChatItemUIController.PlayerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602024C RID: 131660 RVA: 0x00AA880C File Offset: 0x00AA6A0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerIconButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.PlayerIconButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602024D RID: 131661 RVA: 0x00AA8860 File Offset: 0x00AA6A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerIconButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Button playerIconButton;
			LuaObject.checkType<Button>(l, 2, out playerIconButton);
			playerChatItemUIController.PlayerIconButton = playerIconButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602024E RID: 131662 RVA: 0x00AA88B8 File Offset: 0x00AA6AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ContentText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.ContentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602024F RID: 131663 RVA: 0x00AA890C File Offset: 0x00AA6B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ContentText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			EmojiText contentText;
			LuaObject.checkType<EmojiText>(l, 2, out contentText);
			playerChatItemUIController.ContentText = contentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020250 RID: 131664 RVA: 0x00AA8964 File Offset: 0x00AA6B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ContentGo(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.ContentGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020251 RID: 131665 RVA: 0x00AA89B8 File Offset: 0x00AA6BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ContentGo(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			GameObject contentGo;
			LuaObject.checkType<GameObject>(l, 2, out contentGo);
			playerChatItemUIController.ContentGo = contentGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020252 RID: 131666 RVA: 0x00AA8A10 File Offset: 0x00AA6C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_VoicePlayerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.VoicePlayerStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020253 RID: 131667 RVA: 0x00AA8A64 File Offset: 0x00AA6C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VoicePlayerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController voicePlayerStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out voicePlayerStateCtrl);
			playerChatItemUIController.VoicePlayerStateCtrl = voicePlayerStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020254 RID: 131668 RVA: 0x00AA8ABC File Offset: 0x00AA6CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_VoiceButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.VoiceButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020255 RID: 131669 RVA: 0x00AA8B10 File Offset: 0x00AA6D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VoiceButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Button voiceButton;
			LuaObject.checkType<Button>(l, 2, out voiceButton);
			playerChatItemUIController.VoiceButton = voiceButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020256 RID: 131670 RVA: 0x00AA8B68 File Offset: 0x00AA6D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_VoiceLengthText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.VoiceLengthText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020257 RID: 131671 RVA: 0x00AA8BBC File Offset: 0x00AA6DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VoiceLengthText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Text voiceLengthText;
			LuaObject.checkType<Text>(l, 2, out voiceLengthText);
			playerChatItemUIController.VoiceLengthText = voiceLengthText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020258 RID: 131672 RVA: 0x00AA8C14 File Offset: 0x00AA6E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_VoiceContentText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.VoiceContentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020259 RID: 131673 RVA: 0x00AA8C68 File Offset: 0x00AA6E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VoiceContentText(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Text voiceContentText;
			LuaObject.checkType<Text>(l, 2, out voiceContentText);
			playerChatItemUIController.VoiceContentText = voiceContentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602025A RID: 131674 RVA: 0x00AA8CC0 File Offset: 0x00AA6EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_VoiceRoot(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.VoiceRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602025B RID: 131675 RVA: 0x00AA8D14 File Offset: 0x00AA6F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VoiceRoot(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			GameObject voiceRoot;
			LuaObject.checkType<GameObject>(l, 2, out voiceRoot);
			playerChatItemUIController.VoiceRoot = voiceRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602025C RID: 131676 RVA: 0x00AA8D6C File Offset: 0x00AA6F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FaceRoot(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.FaceRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602025D RID: 131677 RVA: 0x00AA8DC0 File Offset: 0x00AA6FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FaceRoot(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			GameObject faceRoot;
			LuaObject.checkType<GameObject>(l, 2, out faceRoot);
			playerChatItemUIController.FaceRoot = faceRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602025E RID: 131678 RVA: 0x00AA8E18 File Offset: 0x00AA7018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FaceIcon(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.FaceIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602025F RID: 131679 RVA: 0x00AA8E6C File Offset: 0x00AA706C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FaceIcon(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			Image faceIcon;
			LuaObject.checkType<Image>(l, 2, out faceIcon);
			playerChatItemUIController.FaceIcon = faceIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020260 RID: 131680 RVA: 0x00AA8EC4 File Offset: 0x00AA70C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_itemStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerChatItemUIController.itemStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020261 RID: 131681 RVA: 0x00AA8F18 File Offset: 0x00AA7118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_itemStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerChatItemUIController playerChatItemUIController = (PlayerChatItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController itemStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out itemStateCtrl);
			playerChatItemUIController.itemStateCtrl = itemStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020262 RID: 131682 RVA: 0x00AA8F70 File Offset: 0x00AA7170
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerChatItemUIController");
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.UpdateChatInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.InitEmojiText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.IsPlaying);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.SetPlayState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.RegClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.SetToVoiceMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.SetToTextMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.SetToBigExpressionMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.SetChatMsgTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.OnVoiceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.OnPlayerHeadClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callDele_EventOnVoiceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__clearDele_EventOnVoiceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__callDele_EventOnPlayerHeadClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.__clearDele_EventOnPlayerHeadClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1C);
		string name = "EventOnVoiceButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_EventOnVoiceButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1D, true);
		string name2 = "EventOnPlayerHeadClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_EventOnPlayerHeadClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1E, true);
		string name3 = "m_isUIEventInited";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_m_isUIEventInited);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_m_isUIEventInited);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache20, true);
		string name4 = "m_isEmojiTextInit";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_m_isEmojiTextInit);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_m_isEmojiTextInit);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache22, true);
		string name5 = "m_currChatInfo";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_m_currChatInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_m_currChatInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache24, true);
		string name6 = "PlayerNameText";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_PlayerNameText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_PlayerNameText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache26, true);
		string name7 = "SendTimeText";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_SendTimeText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_SendTimeText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache28, true);
		string name8 = "PlayerIconImage";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_PlayerIconImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_PlayerIconImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2A, true);
		string name9 = "PlayerHeadFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_PlayerHeadFrameTransform);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_PlayerHeadFrameTransform);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2C, true);
		string name10 = "PlayerLevelText";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_PlayerLevelText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_PlayerLevelText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2E, true);
		string name11 = "PlayerIconButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_PlayerIconButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_PlayerIconButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache30, true);
		string name12 = "ContentText";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_ContentText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_ContentText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache32, true);
		string name13 = "ContentGo";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_ContentGo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_ContentGo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache34, true);
		string name14 = "VoicePlayerStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_VoicePlayerStateCtrl);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_VoicePlayerStateCtrl);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache36, true);
		string name15 = "VoiceButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_VoiceButton);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_VoiceButton);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache38, true);
		string name16 = "VoiceLengthText";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_VoiceLengthText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_VoiceLengthText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3A, true);
		string name17 = "VoiceContentText";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_VoiceContentText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_VoiceContentText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3C, true);
		string name18 = "VoiceRoot";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_VoiceRoot);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_VoiceRoot);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3E, true);
		string name19 = "FaceRoot";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_FaceRoot);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_FaceRoot);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache40, true);
		string name20 = "FaceIcon";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_FaceIcon);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_FaceIcon);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache42, true);
		string name21 = "itemStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.get_itemStateCtrl);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.set_itemStateCtrl);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.<>f__mg$cache44, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlayerChatItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040161B5 RID: 90549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040161B6 RID: 90550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040161B7 RID: 90551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040161B8 RID: 90552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040161B9 RID: 90553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040161BA RID: 90554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040161BB RID: 90555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040161BC RID: 90556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040161BD RID: 90557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040161BE RID: 90558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040161BF RID: 90559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040161C0 RID: 90560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040161C1 RID: 90561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040161C2 RID: 90562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040161C3 RID: 90563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040161C4 RID: 90564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040161C5 RID: 90565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040161C6 RID: 90566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040161C7 RID: 90567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040161C8 RID: 90568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040161C9 RID: 90569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040161CA RID: 90570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040161CB RID: 90571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040161CC RID: 90572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040161CD RID: 90573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040161CE RID: 90574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040161CF RID: 90575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040161D0 RID: 90576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040161D1 RID: 90577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040161D2 RID: 90578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040161D3 RID: 90579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040161D4 RID: 90580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040161D5 RID: 90581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040161D6 RID: 90582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040161D7 RID: 90583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040161D8 RID: 90584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040161D9 RID: 90585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040161DA RID: 90586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040161DB RID: 90587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040161DC RID: 90588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040161DD RID: 90589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040161DE RID: 90590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040161DF RID: 90591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040161E0 RID: 90592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040161E1 RID: 90593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040161E2 RID: 90594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040161E3 RID: 90595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040161E4 RID: 90596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040161E5 RID: 90597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040161E6 RID: 90598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040161E7 RID: 90599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040161E8 RID: 90600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040161E9 RID: 90601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040161EA RID: 90602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040161EB RID: 90603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040161EC RID: 90604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040161ED RID: 90605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040161EE RID: 90606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040161EF RID: 90607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040161F0 RID: 90608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040161F1 RID: 90609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040161F2 RID: 90610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040161F3 RID: 90611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040161F4 RID: 90612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040161F5 RID: 90613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040161F6 RID: 90614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040161F7 RID: 90615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040161F8 RID: 90616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040161F9 RID: 90617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;
}
