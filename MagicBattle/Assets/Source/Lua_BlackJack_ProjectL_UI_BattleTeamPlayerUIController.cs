using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013C5 RID: 5061
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController : LuaObject
{
	// Token: 0x0601C067 RID: 114791 RVA: 0x0089CBDC File Offset: 0x0089ADDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitEmojiText(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			int fontSize;
			LuaObject.checkType(l, 2, out fontSize);
			Image image;
			LuaObject.checkType<Image>(l, 3, out image);
			battleTeamPlayerUIController.InitEmojiText(fontSize, image);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C068 RID: 114792 RVA: 0x0089CC40 File Offset: 0x0089AE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			PlayerBattleStatus status;
			LuaObject.checkEnum<PlayerBattleStatus>(l, 2, out status);
			bool isOffline;
			LuaObject.checkType(l, 3, out isOffline);
			battleTeamPlayerUIController.SetStatus(status, isOffline);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C069 RID: 114793 RVA: 0x0089CCA4 File Offset: 0x0089AEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAction(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			bool action;
			LuaObject.checkType(l, 2, out action);
			battleTeamPlayerUIController.SetAction(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C06A RID: 114794 RVA: 0x0089CCFC File Offset: 0x0089AEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			battleTeamPlayerUIController.SetHeadIcon(headIcon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C06B RID: 114795 RVA: 0x0089CD54 File Offset: 0x0089AF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetName(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			battleTeamPlayerUIController.SetName(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C06C RID: 114796 RVA: 0x0089CDAC File Offset: 0x0089AFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			battleTeamPlayerUIController.SetLevel(level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C06D RID: 114797 RVA: 0x0089CE04 File Offset: 0x0089B004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			battleTeamPlayerUIController.SetPlayerIndex(playerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C06E RID: 114798 RVA: 0x0089CE5C File Offset: 0x0089B05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleTeamPlayerUIController.ShowPlayerIndex(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C06F RID: 114799 RVA: 0x0089CEB4 File Offset: 0x0089B0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroCount(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			int heroCount;
			LuaObject.checkType(l, 2, out heroCount);
			battleTeamPlayerUIController.SetHeroCount(heroCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C070 RID: 114800 RVA: 0x0089CF0C File Offset: 0x0089B10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroAlive(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			int heroIdx;
			LuaObject.checkType(l, 2, out heroIdx);
			bool isAlive;
			LuaObject.checkType(l, 3, out isAlive);
			battleTeamPlayerUIController.SetHeroAlive(heroIdx, isAlive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C071 RID: 114801 RVA: 0x0089CF70 File Offset: 0x0089B170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowChat(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			string txt;
			LuaObject.checkType(l, 2, out txt);
			battleTeamPlayerUIController.ShowChat(txt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C072 RID: 114802 RVA: 0x0089CFC8 File Offset: 0x0089B1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBigExpression(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			battleTeamPlayerUIController.ShowBigExpression(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C073 RID: 114803 RVA: 0x0089D020 File Offset: 0x0089B220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowVoice(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			ChatVoiceMessage voiceMessage;
			LuaObject.checkType<ChatVoiceMessage>(l, 2, out voiceMessage);
			battleTeamPlayerUIController.ShowVoice(voiceMessage);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C074 RID: 114804 RVA: 0x0089D078 File Offset: 0x0089B278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			battleTeamPlayerUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C075 RID: 114805 RVA: 0x0089D0CC File Offset: 0x0089B2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnVoiceTimeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			battleTeamPlayerUIController.m_luaExportHelper.OnVoiceTimeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C076 RID: 114806 RVA: 0x0089D120 File Offset: 0x0089B320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideChat(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			battleTeamPlayerUIController.m_luaExportHelper.HideChat();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C077 RID: 114807 RVA: 0x0089D174 File Offset: 0x0089B374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideBigExpression(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			battleTeamPlayerUIController.m_luaExportHelper.HideBigExpression();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C078 RID: 114808 RVA: 0x0089D1C8 File Offset: 0x0089B3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroPointBGGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			GameObject heroPointBGGameObject = battleTeamPlayerUIController.m_luaExportHelper.GetHeroPointBGGameObject(idx);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPointBGGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C079 RID: 114809 RVA: 0x0089D230 File Offset: 0x0089B430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroPointGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			GameObject heroPointGameObject = battleTeamPlayerUIController.m_luaExportHelper.GetHeroPointGameObject(idx);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPointGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C07A RID: 114810 RVA: 0x0089D298 File Offset: 0x0089B498
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHeroRedPointGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			GameObject heroRedPointGameObject = battleTeamPlayerUIController.m_luaExportHelper.GetHeroRedPointGameObject(idx);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroRedPointGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C07B RID: 114811 RVA: 0x0089D300 File Offset: 0x0089B500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			battleTeamPlayerUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C07C RID: 114812 RVA: 0x0089D354 File Offset: 0x0089B554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleTeamPlayerUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C07D RID: 114813 RVA: 0x0089D3C0 File Offset: 0x0089B5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			battleTeamPlayerUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C07E RID: 114814 RVA: 0x0089D414 File Offset: 0x0089B614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			battleTeamPlayerUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C07F RID: 114815 RVA: 0x0089D468 File Offset: 0x0089B668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleTeamPlayerUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C080 RID: 114816 RVA: 0x0089D510 File Offset: 0x0089B710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			battleTeamPlayerUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C081 RID: 114817 RVA: 0x0089D564 File Offset: 0x0089B764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleTeamPlayerUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C082 RID: 114818 RVA: 0x0089D5D0 File Offset: 0x0089B7D0
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
				BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleTeamPlayerUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleTeamPlayerUIController battleTeamPlayerUIController2 = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleTeamPlayerUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C083 RID: 114819 RVA: 0x0089D6E0 File Offset: 0x0089B8E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleTeamPlayerUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C084 RID: 114820 RVA: 0x0089D74C File Offset: 0x0089B94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleTeamPlayerUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C085 RID: 114821 RVA: 0x0089D7B8 File Offset: 0x0089B9B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleTeamPlayerUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C086 RID: 114822 RVA: 0x0089D824 File Offset: 0x0089BA24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleTeamPlayerUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C087 RID: 114823 RVA: 0x0089D890 File Offset: 0x0089BA90
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
				BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleTeamPlayerUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleTeamPlayerUIController battleTeamPlayerUIController2 = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleTeamPlayerUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C088 RID: 114824 RVA: 0x0089D9A0 File Offset: 0x0089BBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			string s = battleTeamPlayerUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C089 RID: 114825 RVA: 0x0089D9FC File Offset: 0x0089BBFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headIconImage(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_headIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C08A RID: 114826 RVA: 0x0089DA54 File Offset: 0x0089BC54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_headIconImage(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			Image headIconImage;
			LuaObject.checkType<Image>(l, 2, out headIconImage);
			battleTeamPlayerUIController.m_luaExportHelper.m_headIconImage = headIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C08B RID: 114827 RVA: 0x0089DAB0 File Offset: 0x0089BCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_headFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C08C RID: 114828 RVA: 0x0089DB08 File Offset: 0x0089BD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			Transform headFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out headFrameTransform);
			battleTeamPlayerUIController.m_luaExportHelper.m_headFrameTransform = headFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C08D RID: 114829 RVA: 0x0089DB64 File Offset: 0x0089BD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C08E RID: 114830 RVA: 0x0089DBBC File Offset: 0x0089BDBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			battleTeamPlayerUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C08F RID: 114831 RVA: 0x0089DC18 File Offset: 0x0089BE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C090 RID: 114832 RVA: 0x0089DC70 File Offset: 0x0089BE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			battleTeamPlayerUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C091 RID: 114833 RVA: 0x0089DCCC File Offset: 0x0089BECC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerTagImage(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_playerTagImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C092 RID: 114834 RVA: 0x0089DD24 File Offset: 0x0089BF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerTagImage(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			Image playerTagImage;
			LuaObject.checkType<Image>(l, 2, out playerTagImage);
			battleTeamPlayerUIController.m_luaExportHelper.m_playerTagImage = playerTagImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C093 RID: 114835 RVA: 0x0089DD80 File Offset: 0x0089BF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_chatUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C094 RID: 114836 RVA: 0x0089DDD8 File Offset: 0x0089BFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			CommonUIStateController chatUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out chatUIStateController);
			battleTeamPlayerUIController.m_luaExportHelper.m_chatUIStateController = chatUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C095 RID: 114837 RVA: 0x0089DE34 File Offset: 0x0089C034
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_dialogText(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_dialogText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C096 RID: 114838 RVA: 0x0089DE8C File Offset: 0x0089C08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogText(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			EmojiText dialogText;
			LuaObject.checkType<EmojiText>(l, 2, out dialogText);
			battleTeamPlayerUIController.m_luaExportHelper.m_dialogText = dialogText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C097 RID: 114839 RVA: 0x0089DEE8 File Offset: 0x0089C0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expressionImage(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_expressionImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C098 RID: 114840 RVA: 0x0089DF40 File Offset: 0x0089C140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expressionImage(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			Image expressionImage;
			LuaObject.checkType<Image>(l, 2, out expressionImage);
			battleTeamPlayerUIController.m_luaExportHelper.m_expressionImage = expressionImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C099 RID: 114841 RVA: 0x0089DF9C File Offset: 0x0089C19C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceButton(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_voiceButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C09A RID: 114842 RVA: 0x0089DFF4 File Offset: 0x0089C1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceButton(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			Button voiceButton;
			LuaObject.checkType<Button>(l, 2, out voiceButton);
			battleTeamPlayerUIController.m_luaExportHelper.m_voiceButton = voiceButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C09B RID: 114843 RVA: 0x0089E050 File Offset: 0x0089C250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceSpeakImageStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_voiceSpeakImageStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C09C RID: 114844 RVA: 0x0089E0A8 File Offset: 0x0089C2A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_voiceSpeakImageStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			CommonUIStateController voiceSpeakImageStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out voiceSpeakImageStateCtrl);
			battleTeamPlayerUIController.m_luaExportHelper.m_voiceSpeakImageStateCtrl = voiceSpeakImageStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C09D RID: 114845 RVA: 0x0089E104 File Offset: 0x0089C304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceTimeButtonText(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_voiceTimeButtonText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C09E RID: 114846 RVA: 0x0089E15C File Offset: 0x0089C35C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_voiceTimeButtonText(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			Text voiceTimeButtonText;
			LuaObject.checkType<Text>(l, 2, out voiceTimeButtonText);
			battleTeamPlayerUIController.m_luaExportHelper.m_voiceTimeButtonText = voiceTimeButtonText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C09F RID: 114847 RVA: 0x0089E1B8 File Offset: 0x0089C3B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_voiceContentText(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_voiceContentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0A0 RID: 114848 RVA: 0x0089E210 File Offset: 0x0089C410
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_voiceContentText(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			Text voiceContentText;
			LuaObject.checkType<Text>(l, 2, out voiceContentText);
			battleTeamPlayerUIController.m_luaExportHelper.m_voiceContentText = voiceContentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0A1 RID: 114849 RVA: 0x0089E26C File Offset: 0x0089C46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_statusActionGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_statusActionGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0A2 RID: 114850 RVA: 0x0089E2C4 File Offset: 0x0089C4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_statusActionGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			GameObject statusActionGameObject;
			LuaObject.checkType<GameObject>(l, 2, out statusActionGameObject);
			battleTeamPlayerUIController.m_luaExportHelper.m_statusActionGameObject = statusActionGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0A3 RID: 114851 RVA: 0x0089E320 File Offset: 0x0089C520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_statusReadyGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_statusReadyGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0A4 RID: 114852 RVA: 0x0089E378 File Offset: 0x0089C578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_statusReadyGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			GameObject statusReadyGameObject;
			LuaObject.checkType<GameObject>(l, 2, out statusReadyGameObject);
			battleTeamPlayerUIController.m_luaExportHelper.m_statusReadyGameObject = statusReadyGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0A5 RID: 114853 RVA: 0x0089E3D4 File Offset: 0x0089C5D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_statusAutoGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_statusAutoGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0A6 RID: 114854 RVA: 0x0089E42C File Offset: 0x0089C62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_statusAutoGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			GameObject statusAutoGameObject;
			LuaObject.checkType<GameObject>(l, 2, out statusAutoGameObject);
			battleTeamPlayerUIController.m_luaExportHelper.m_statusAutoGameObject = statusAutoGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0A7 RID: 114855 RVA: 0x0089E488 File Offset: 0x0089C688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_statusOfflineGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_statusOfflineGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0A8 RID: 114856 RVA: 0x0089E4E0 File Offset: 0x0089C6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_statusOfflineGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			GameObject statusOfflineGameObject;
			LuaObject.checkType<GameObject>(l, 2, out statusOfflineGameObject);
			battleTeamPlayerUIController.m_luaExportHelper.m_statusOfflineGameObject = statusOfflineGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0A9 RID: 114857 RVA: 0x0089E53C File Offset: 0x0089C73C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hideChatTime(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_hideChatTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0AA RID: 114858 RVA: 0x0089E594 File Offset: 0x0089C794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hideChatTime(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			float hideChatTime;
			LuaObject.checkType(l, 2, out hideChatTime);
			battleTeamPlayerUIController.m_luaExportHelper.m_hideChatTime = hideChatTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0AB RID: 114859 RVA: 0x0089E5F0 File Offset: 0x0089C7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceMessage(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTeamPlayerUIController.m_luaExportHelper.m_voiceMessage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0AC RID: 114860 RVA: 0x0089E648 File Offset: 0x0089C848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceMessage(IntPtr l)
	{
		int result;
		try
		{
			BattleTeamPlayerUIController battleTeamPlayerUIController = (BattleTeamPlayerUIController)LuaObject.checkSelf(l);
			ChatVoiceMessage voiceMessage;
			LuaObject.checkType<ChatVoiceMessage>(l, 2, out voiceMessage);
			battleTeamPlayerUIController.m_luaExportHelper.m_voiceMessage = voiceMessage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C0AD RID: 114861 RVA: 0x0089E6A4 File Offset: 0x0089C8A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleTeamPlayerUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.InitEmojiText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.SetStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.SetAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.SetHeadIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.SetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.SetLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.SetPlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.ShowPlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.SetHeroCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.SetHeroAlive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.ShowChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.ShowBigExpression);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.ShowVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.OnVoiceTimeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.HideChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.HideBigExpression);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.GetHeroPointBGGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.GetHeroPointGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.GetHeroRedPointGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache21);
		string name = "m_headIconImage";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_headIconImage);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_headIconImage);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache23, true);
		string name2 = "m_headFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_headFrameTransform);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_headFrameTransform);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache25, true);
		string name3 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_nameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache27, true);
		string name4 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_levelText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache29, true);
		string name5 = "m_playerTagImage";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_playerTagImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_playerTagImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2B, true);
		string name6 = "m_chatUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_chatUIStateController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_chatUIStateController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2D, true);
		string name7 = "m_dialogText";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_dialogText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_dialogText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache2F, true);
		string name8 = "m_expressionImage";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_expressionImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_expressionImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache31, true);
		string name9 = "m_voiceButton";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_voiceButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_voiceButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache33, true);
		string name10 = "m_voiceSpeakImageStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_voiceSpeakImageStateCtrl);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_voiceSpeakImageStateCtrl);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache35, true);
		string name11 = "m_voiceTimeButtonText";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_voiceTimeButtonText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_voiceTimeButtonText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache37, true);
		string name12 = "m_voiceContentText";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_voiceContentText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_voiceContentText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache39, true);
		string name13 = "m_statusActionGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_statusActionGameObject);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_statusActionGameObject);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3B, true);
		string name14 = "m_statusReadyGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_statusReadyGameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_statusReadyGameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3D, true);
		string name15 = "m_statusAutoGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_statusAutoGameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_statusAutoGameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache3F, true);
		string name16 = "m_statusOfflineGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_statusOfflineGameObject);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_statusOfflineGameObject);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache41, true);
		string name17 = "m_hideChatTime";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_hideChatTime);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_hideChatTime);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache43, true);
		string name18 = "m_voiceMessage";
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.get_m_voiceMessage);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.set_m_voiceMessage);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.<>f__mg$cache45, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleTeamPlayerUIController), typeof(UIControllerBase));
	}

	// Token: 0x040122BF RID: 74431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040122C0 RID: 74432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040122C1 RID: 74433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040122C2 RID: 74434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040122C3 RID: 74435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040122C4 RID: 74436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040122C5 RID: 74437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040122C6 RID: 74438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040122C7 RID: 74439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040122C8 RID: 74440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040122C9 RID: 74441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040122CA RID: 74442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040122CB RID: 74443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040122CC RID: 74444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040122CD RID: 74445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040122CE RID: 74446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040122CF RID: 74447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040122D0 RID: 74448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040122D1 RID: 74449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040122D2 RID: 74450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040122D3 RID: 74451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040122D4 RID: 74452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040122D5 RID: 74453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040122D6 RID: 74454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040122D7 RID: 74455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040122D8 RID: 74456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040122D9 RID: 74457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040122DA RID: 74458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040122DB RID: 74459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040122DC RID: 74460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040122DD RID: 74461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040122DE RID: 74462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040122DF RID: 74463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040122E0 RID: 74464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040122E1 RID: 74465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040122E2 RID: 74466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040122E3 RID: 74467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040122E4 RID: 74468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040122E5 RID: 74469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040122E6 RID: 74470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040122E7 RID: 74471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040122E8 RID: 74472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040122E9 RID: 74473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040122EA RID: 74474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040122EB RID: 74475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040122EC RID: 74476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040122ED RID: 74477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040122EE RID: 74478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040122EF RID: 74479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040122F0 RID: 74480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040122F1 RID: 74481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040122F2 RID: 74482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040122F3 RID: 74483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040122F4 RID: 74484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040122F5 RID: 74485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040122F6 RID: 74486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040122F7 RID: 74487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040122F8 RID: 74488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040122F9 RID: 74489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040122FA RID: 74490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040122FB RID: 74491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040122FC RID: 74492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040122FD RID: 74493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040122FE RID: 74494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040122FF RID: 74495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04012300 RID: 74496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04012301 RID: 74497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04012302 RID: 74498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04012303 RID: 74499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04012304 RID: 74500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;
}
