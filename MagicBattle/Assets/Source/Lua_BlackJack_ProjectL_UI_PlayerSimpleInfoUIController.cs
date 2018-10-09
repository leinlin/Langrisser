using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001532 RID: 5426
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController : LuaObject
{
	// Token: 0x06020502 RID: 132354 RVA: 0x00ABEB24 File Offset: 0x00ABCD24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdatePlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			BusinessCard playerInfo;
			LuaObject.checkType<BusinessCard>(l, 2, out playerInfo);
			bool isFriend;
			LuaObject.checkType(l, 3, out isFriend);
			bool canSendLike;
			LuaObject.checkType(l, 4, out canSendLike);
			bool isInBattle;
			LuaObject.checkType(l, 5, out isInBattle);
			bool isInTeamRoom;
			LuaObject.checkType(l, 6, out isInTeamRoom);
			playerSimpleInfoUIController.UpdatePlayerInfo(playerInfo, isFriend, canSendLike, isInBattle, isInTeamRoom);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020503 RID: 132355 RVA: 0x00ABEBB0 File Offset: 0x00ABCDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowOrHide(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			playerSimpleInfoUIController.ShowOrHide(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020504 RID: 132356 RVA: 0x00ABEC08 File Offset: 0x00ABCE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetViewRect(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Rect viewRect = playerSimpleInfoUIController.GetViewRect();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, viewRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020505 RID: 132357 RVA: 0x00ABEC64 File Offset: 0x00ABCE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPanelPosition(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Vector3 panelPosition;
			LuaObject.checkType(l, 2, out panelPosition);
			playerSimpleInfoUIController.SetPanelPosition(panelPosition);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020506 RID: 132358 RVA: 0x00ABECBC File Offset: 0x00ABCEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGuildButtonGroupStateByMode(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string guildButtonGroupStateByMode;
			LuaObject.checkType(l, 2, out guildButtonGroupStateByMode);
			playerSimpleInfoUIController.SetGuildButtonGroupStateByMode(guildButtonGroupStateByMode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020507 RID: 132359 RVA: 0x00ABED14 File Offset: 0x00ABCF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020508 RID: 132360 RVA: 0x00ABED68 File Offset: 0x00ABCF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPanelSize(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Vector2 panelSize = playerSimpleInfoUIController.m_luaExportHelper.GetPanelSize();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, panelSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020509 RID: 132361 RVA: 0x00ABEDC4 File Offset: 0x00ABCFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGuildButtonGroupListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.SetGuildButtonGroupListener();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602050A RID: 132362 RVA: 0x00ABEE18 File Offset: 0x00ABD018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExpelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnExpelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602050B RID: 132363 RVA: 0x00ABEE6C File Offset: 0x00ABD06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnVChairmanChangeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnVChairmanChangeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602050C RID: 132364 RVA: 0x00ABEEC0 File Offset: 0x00ABD0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnVChairmanButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnVChairmanButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602050D RID: 132365 RVA: 0x00ABEF14 File Offset: 0x00ABD114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChairmanMoveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnChairmanMoveButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602050E RID: 132366 RVA: 0x00ABEF68 File Offset: 0x00ABD168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChairmanRelieveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnChairmanRelieveButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602050F RID: 132367 RVA: 0x00ABEFBC File Offset: 0x00ABD1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWatchCardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnWatchCardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020510 RID: 132368 RVA: 0x00ABF010 File Offset: 0x00ABD210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPrivateChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnPrivateChatButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020511 RID: 132369 RVA: 0x00ABF064 File Offset: 0x00ABD264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPKButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnPKButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020512 RID: 132370 RVA: 0x00ABF0B8 File Offset: 0x00ABD2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPKGreyButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnPKGreyButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020513 RID: 132371 RVA: 0x00ABF10C File Offset: 0x00ABD30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDeleteFriendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnDeleteFriendButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020514 RID: 132372 RVA: 0x00ABF160 File Offset: 0x00ABD360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddFriendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnAddFriendButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020515 RID: 132373 RVA: 0x00ABF1B4 File Offset: 0x00ABD3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBlockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnBlockButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020516 RID: 132374 RVA: 0x00ABF208 File Offset: 0x00ABD408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLikeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnLikeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020517 RID: 132375 RVA: 0x00ABF25C File Offset: 0x00ABD45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.OnBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020518 RID: 132376 RVA: 0x00ABF2B0 File Offset: 0x00ABD4B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			playerSimpleInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020519 RID: 132377 RVA: 0x00ABF31C File Offset: 0x00ABD51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602051A RID: 132378 RVA: 0x00ABF370 File Offset: 0x00ABD570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602051B RID: 132379 RVA: 0x00ABF3C4 File Offset: 0x00ABD5C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = playerSimpleInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602051C RID: 132380 RVA: 0x00ABF46C File Offset: 0x00ABD66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602051D RID: 132381 RVA: 0x00ABF4C0 File Offset: 0x00ABD6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			playerSimpleInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602051E RID: 132382 RVA: 0x00ABF52C File Offset: 0x00ABD72C
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
				PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				playerSimpleInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PlayerSimpleInfoUIController playerSimpleInfoUIController2 = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				playerSimpleInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602051F RID: 132383 RVA: 0x00ABF63C File Offset: 0x00ABD83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerSimpleInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020520 RID: 132384 RVA: 0x00ABF6A8 File Offset: 0x00ABD8A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerSimpleInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020521 RID: 132385 RVA: 0x00ABF714 File Offset: 0x00ABD914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerSimpleInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020522 RID: 132386 RVA: 0x00ABF780 File Offset: 0x00ABD980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerSimpleInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020523 RID: 132387 RVA: 0x00ABF7EC File Offset: 0x00ABD9EC
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
				PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				playerSimpleInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PlayerSimpleInfoUIController playerSimpleInfoUIController2 = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				playerSimpleInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020524 RID: 132388 RVA: 0x00ABF8FC File Offset: 0x00ABDAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string s = playerSimpleInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020525 RID: 132389 RVA: 0x00ABF958 File Offset: 0x00ABDB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnWatchCardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__callDele_EventOnWatchCardButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020526 RID: 132390 RVA: 0x00ABF9B4 File Offset: 0x00ABDBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnWatchCardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__clearDele_EventOnWatchCardButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020527 RID: 132391 RVA: 0x00ABFA10 File Offset: 0x00ABDC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPrivateChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.__callDele_EventOnPrivateChatButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020528 RID: 132392 RVA: 0x00ABFA64 File Offset: 0x00ABDC64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPrivateChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.__clearDele_EventOnPrivateChatButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020529 RID: 132393 RVA: 0x00ABFAB8 File Offset: 0x00ABDCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPKButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__callDele_EventOnPKButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602052A RID: 132394 RVA: 0x00ABFB14 File Offset: 0x00ABDD14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPKButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__clearDele_EventOnPKButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602052B RID: 132395 RVA: 0x00ABFB70 File Offset: 0x00ABDD70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnDeleteFriendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			BusinessCard obj;
			LuaObject.checkType<BusinessCard>(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__callDele_EventOnDeleteFriendButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602052C RID: 132396 RVA: 0x00ABFBCC File Offset: 0x00ABDDCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDeleteFriendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			BusinessCard obj;
			LuaObject.checkType<BusinessCard>(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__clearDele_EventOnDeleteFriendButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602052D RID: 132397 RVA: 0x00ABFC28 File Offset: 0x00ABDE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddFriendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__callDele_EventOnAddFriendButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602052E RID: 132398 RVA: 0x00ABFC84 File Offset: 0x00ABDE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddFriendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__clearDele_EventOnAddFriendButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602052F RID: 132399 RVA: 0x00ABFCE0 File Offset: 0x00ABDEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBlockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__callDele_EventOnBlockButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020530 RID: 132400 RVA: 0x00ABFD3C File Offset: 0x00ABDF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBlockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__clearDele_EventOnBlockButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020531 RID: 132401 RVA: 0x00ABFD98 File Offset: 0x00ABDF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnLikeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__callDele_EventOnLikeButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020532 RID: 132402 RVA: 0x00ABFDF4 File Offset: 0x00ABDFF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnLikeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__clearDele_EventOnLikeButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020533 RID: 132403 RVA: 0x00ABFE50 File Offset: 0x00ABE050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.__callDele_EventOnBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020534 RID: 132404 RVA: 0x00ABFEA4 File Offset: 0x00ABE0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			playerSimpleInfoUIController.m_luaExportHelper.__clearDele_EventOnBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020535 RID: 132405 RVA: 0x00ABFEF8 File Offset: 0x00ABE0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChairmanRelieveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__callDele_EventOnChairmanRelieveButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020536 RID: 132406 RVA: 0x00ABFF54 File Offset: 0x00ABE154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChairmanRelieveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__clearDele_EventOnChairmanRelieveButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020537 RID: 132407 RVA: 0x00ABFFB0 File Offset: 0x00ABE1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChairmanMoveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__callDele_EventOnChairmanMoveButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020538 RID: 132408 RVA: 0x00AC000C File Offset: 0x00ABE20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChairmanMoveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__clearDele_EventOnChairmanMoveButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020539 RID: 132409 RVA: 0x00AC0068 File Offset: 0x00ABE268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnVChairmanChangeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			playerSimpleInfoUIController.m_luaExportHelper.__callDele_EventOnVChairmanChangeButtonClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602053A RID: 132410 RVA: 0x00AC00D4 File Offset: 0x00ABE2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnVChairmanChangeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			playerSimpleInfoUIController.m_luaExportHelper.__clearDele_EventOnVChairmanChangeButtonClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602053B RID: 132411 RVA: 0x00AC0140 File Offset: 0x00ABE340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnExpelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__callDele_EventOnExpelButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602053C RID: 132412 RVA: 0x00AC019C File Offset: 0x00ABE39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnExpelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerSimpleInfoUIController.m_luaExportHelper.__clearDele_EventOnExpelButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602053D RID: 132413 RVA: 0x00AC01F8 File Offset: 0x00ABE3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnWatchCardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUIController.EventOnWatchCardButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUIController.EventOnWatchCardButtonClick -= value;
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

	// Token: 0x0602053E RID: 132414 RVA: 0x00AC0278 File Offset: 0x00ABE478
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnPrivateChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUIController.EventOnPrivateChatButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUIController.EventOnPrivateChatButtonClick -= value;
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

	// Token: 0x0602053F RID: 132415 RVA: 0x00AC02F8 File Offset: 0x00ABE4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPKButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUIController.EventOnPKButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUIController.EventOnPKButtonClick -= value;
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

	// Token: 0x06020540 RID: 132416 RVA: 0x00AC0378 File Offset: 0x00ABE578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDeleteFriendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Action<BusinessCard> value;
			int num = LuaObject.checkDelegate<Action<BusinessCard>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUIController.EventOnDeleteFriendButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUIController.EventOnDeleteFriendButtonClick -= value;
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

	// Token: 0x06020541 RID: 132417 RVA: 0x00AC03F8 File Offset: 0x00ABE5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddFriendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUIController.EventOnAddFriendButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUIController.EventOnAddFriendButtonClick -= value;
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

	// Token: 0x06020542 RID: 132418 RVA: 0x00AC0478 File Offset: 0x00ABE678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBlockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUIController.EventOnBlockButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUIController.EventOnBlockButtonClick -= value;
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

	// Token: 0x06020543 RID: 132419 RVA: 0x00AC04F8 File Offset: 0x00ABE6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnLikeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUIController.EventOnLikeButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUIController.EventOnLikeButtonClick -= value;
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

	// Token: 0x06020544 RID: 132420 RVA: 0x00AC0578 File Offset: 0x00ABE778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUIController.EventOnBGButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUIController.EventOnBGButtonClick -= value;
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

	// Token: 0x06020545 RID: 132421 RVA: 0x00AC05F8 File Offset: 0x00ABE7F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChairmanRelieveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUIController.EventOnChairmanRelieveButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUIController.EventOnChairmanRelieveButtonClick -= value;
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

	// Token: 0x06020546 RID: 132422 RVA: 0x00AC0678 File Offset: 0x00ABE878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChairmanMoveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUIController.EventOnChairmanMoveButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUIController.EventOnChairmanMoveButtonClick -= value;
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

	// Token: 0x06020547 RID: 132423 RVA: 0x00AC06F8 File Offset: 0x00ABE8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnVChairmanChangeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Action<string, bool> value;
			int num = LuaObject.checkDelegate<Action<string, bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUIController.EventOnVChairmanChangeButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUIController.EventOnVChairmanChangeButtonClick -= value;
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

	// Token: 0x06020548 RID: 132424 RVA: 0x00AC0778 File Offset: 0x00ABE978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnExpelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSimpleInfoUIController.EventOnExpelButtonClick += value;
				}
				else if (num == 2)
				{
					playerSimpleInfoUIController.EventOnExpelButtonClick -= value;
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

	// Token: 0x06020549 RID: 132425 RVA: 0x00AC07F8 File Offset: 0x00ABE9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.m_luaExportHelper.m_playerInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602054A RID: 132426 RVA: 0x00AC0850 File Offset: 0x00ABEA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			BusinessCard playerInfo;
			LuaObject.checkType<BusinessCard>(l, 2, out playerInfo);
			playerSimpleInfoUIController.m_luaExportHelper.m_playerInfo = playerInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602054B RID: 132427 RVA: 0x00AC08AC File Offset: 0x00ABEAAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PanelRoot(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.PanelRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602054C RID: 132428 RVA: 0x00AC0900 File Offset: 0x00ABEB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PanelRoot(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			GameObject panelRoot;
			LuaObject.checkType<GameObject>(l, 2, out panelRoot);
			playerSimpleInfoUIController.PanelRoot = panelRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602054D RID: 132429 RVA: 0x00AC0958 File Offset: 0x00ABEB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerIcon(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.PlayerIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602054E RID: 132430 RVA: 0x00AC09AC File Offset: 0x00ABEBAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerIcon(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Image playerIcon;
			LuaObject.checkType<Image>(l, 2, out playerIcon);
			playerSimpleInfoUIController.PlayerIcon = playerIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602054F RID: 132431 RVA: 0x00AC0A04 File Offset: 0x00ABEC04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.m_headFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020550 RID: 132432 RVA: 0x00AC0A58 File Offset: 0x00ABEC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Transform headFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out headFrameTransform);
			playerSimpleInfoUIController.m_headFrameTransform = headFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020551 RID: 132433 RVA: 0x00AC0AB0 File Offset: 0x00ABECB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_likeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.m_likeUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020552 RID: 132434 RVA: 0x00AC0B04 File Offset: 0x00ABED04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_likeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController likeUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out likeUIStateController);
			playerSimpleInfoUIController.m_likeUIStateController = likeUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020553 RID: 132435 RVA: 0x00AC0B5C File Offset: 0x00ABED5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.LevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020554 RID: 132436 RVA: 0x00AC0BB0 File Offset: 0x00ABEDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			playerSimpleInfoUIController.LevelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020555 RID: 132437 RVA: 0x00AC0C08 File Offset: 0x00ABEE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.PlayerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020556 RID: 132438 RVA: 0x00AC0C5C File Offset: 0x00ABEE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			playerSimpleInfoUIController.PlayerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020557 RID: 132439 RVA: 0x00AC0CB4 File Offset: 0x00ABEEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LikeNumberText(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.LikeNumberText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020558 RID: 132440 RVA: 0x00AC0D08 File Offset: 0x00ABEF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LikeNumberText(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Text likeNumberText;
			LuaObject.checkType<Text>(l, 2, out likeNumberText);
			playerSimpleInfoUIController.LikeNumberText = likeNumberText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020559 RID: 132441 RVA: 0x00AC0D60 File Offset: 0x00ABEF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WatchButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.WatchButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602055A RID: 132442 RVA: 0x00AC0DB4 File Offset: 0x00ABEFB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WatchButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button watchButton;
			LuaObject.checkType<Button>(l, 2, out watchButton);
			playerSimpleInfoUIController.WatchButton = watchButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602055B RID: 132443 RVA: 0x00AC0E0C File Offset: 0x00ABF00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FightButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.FightButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602055C RID: 132444 RVA: 0x00AC0E60 File Offset: 0x00ABF060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FightButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button fightButton;
			LuaObject.checkType<Button>(l, 2, out fightButton);
			playerSimpleInfoUIController.FightButton = fightButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602055D RID: 132445 RVA: 0x00AC0EB8 File Offset: 0x00ABF0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FightGreyButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.FightGreyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602055E RID: 132446 RVA: 0x00AC0F0C File Offset: 0x00ABF10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FightGreyButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button fightGreyButton;
			LuaObject.checkType<Button>(l, 2, out fightGreyButton);
			playerSimpleInfoUIController.FightGreyButton = fightGreyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602055F RID: 132447 RVA: 0x00AC0F64 File Offset: 0x00ABF164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DeleteFriendButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.DeleteFriendButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020560 RID: 132448 RVA: 0x00AC0FB8 File Offset: 0x00ABF1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DeleteFriendButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button deleteFriendButton;
			LuaObject.checkType<Button>(l, 2, out deleteFriendButton);
			playerSimpleInfoUIController.DeleteFriendButton = deleteFriendButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020561 RID: 132449 RVA: 0x00AC1010 File Offset: 0x00ABF210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.ChatButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020562 RID: 132450 RVA: 0x00AC1064 File Offset: 0x00ABF264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChatButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button chatButton;
			LuaObject.checkType<Button>(l, 2, out chatButton);
			playerSimpleInfoUIController.ChatButton = chatButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020563 RID: 132451 RVA: 0x00AC10BC File Offset: 0x00ABF2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LikeButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.LikeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020564 RID: 132452 RVA: 0x00AC1110 File Offset: 0x00ABF310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LikeButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button likeButton;
			LuaObject.checkType<Button>(l, 2, out likeButton);
			playerSimpleInfoUIController.LikeButton = likeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020565 RID: 132453 RVA: 0x00AC1168 File Offset: 0x00ABF368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AddFriendButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.AddFriendButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020566 RID: 132454 RVA: 0x00AC11BC File Offset: 0x00ABF3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AddFriendButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button addFriendButton;
			LuaObject.checkType<Button>(l, 2, out addFriendButton);
			playerSimpleInfoUIController.AddFriendButton = addFriendButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020567 RID: 132455 RVA: 0x00AC1214 File Offset: 0x00ABF414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ShieldButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.ShieldButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020568 RID: 132456 RVA: 0x00AC1268 File Offset: 0x00ABF468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ShieldButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button shieldButton;
			LuaObject.checkType<Button>(l, 2, out shieldButton);
			playerSimpleInfoUIController.ShieldButton = shieldButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020569 RID: 132457 RVA: 0x00AC12C0 File Offset: 0x00ABF4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BGButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.BGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602056A RID: 132458 RVA: 0x00AC1314 File Offset: 0x00ABF514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BGButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button bgbutton;
			LuaObject.checkType<Button>(l, 2, out bgbutton);
			playerSimpleInfoUIController.BGButton = bgbutton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602056B RID: 132459 RVA: 0x00AC136C File Offset: 0x00ABF56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PanelOpenOrCloseStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.PanelOpenOrCloseStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602056C RID: 132460 RVA: 0x00AC13C0 File Offset: 0x00ABF5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PanelOpenOrCloseStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController panelOpenOrCloseStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out panelOpenOrCloseStateCtrl);
			playerSimpleInfoUIController.PanelOpenOrCloseStateCtrl = panelOpenOrCloseStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602056D RID: 132461 RVA: 0x00AC1418 File Offset: 0x00ABF618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PanelShowStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.PanelShowStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602056E RID: 132462 RVA: 0x00AC146C File Offset: 0x00ABF66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PanelShowStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController panelShowStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out panelShowStateCtrl);
			playerSimpleInfoUIController.PanelShowStateCtrl = panelShowStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602056F RID: 132463 RVA: 0x00AC14C4 File Offset: 0x00ABF6C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SociatyButtonGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.SociatyButtonGroupStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020570 RID: 132464 RVA: 0x00AC1518 File Offset: 0x00ABF718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SociatyButtonGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController sociatyButtonGroupStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out sociatyButtonGroupStateCtrl);
			playerSimpleInfoUIController.SociatyButtonGroupStateCtrl = sociatyButtonGroupStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020571 RID: 132465 RVA: 0x00AC1570 File Offset: 0x00ABF770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChairmanRelieveButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.ChairmanRelieveButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020572 RID: 132466 RVA: 0x00AC15C4 File Offset: 0x00ABF7C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChairmanRelieveButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button chairmanRelieveButton;
			LuaObject.checkType<Button>(l, 2, out chairmanRelieveButton);
			playerSimpleInfoUIController.ChairmanRelieveButton = chairmanRelieveButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020573 RID: 132467 RVA: 0x00AC161C File Offset: 0x00ABF81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChairmanMoveButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.ChairmanMoveButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020574 RID: 132468 RVA: 0x00AC1670 File Offset: 0x00ABF870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChairmanMoveButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button chairmanMoveButton;
			LuaObject.checkType<Button>(l, 2, out chairmanMoveButton);
			playerSimpleInfoUIController.ChairmanMoveButton = chairmanMoveButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020575 RID: 132469 RVA: 0x00AC16C8 File Offset: 0x00ABF8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_VChairmanButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.VChairmanButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020576 RID: 132470 RVA: 0x00AC171C File Offset: 0x00ABF91C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VChairmanButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button vchairmanButton;
			LuaObject.checkType<Button>(l, 2, out vchairmanButton);
			playerSimpleInfoUIController.VChairmanButton = vchairmanButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020577 RID: 132471 RVA: 0x00AC1774 File Offset: 0x00ABF974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_VChairmanChangeButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.VChairmanChangeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020578 RID: 132472 RVA: 0x00AC17C8 File Offset: 0x00ABF9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VChairmanChangeButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button vchairmanChangeButton;
			LuaObject.checkType<Button>(l, 2, out vchairmanChangeButton);
			playerSimpleInfoUIController.VChairmanChangeButton = vchairmanChangeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020579 RID: 132473 RVA: 0x00AC1820 File Offset: 0x00ABFA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExpelButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.ExpelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602057A RID: 132474 RVA: 0x00AC1874 File Offset: 0x00ABFA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExpelButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			Button expelButton;
			LuaObject.checkType<Button>(l, 2, out expelButton);
			playerSimpleInfoUIController.ExpelButton = expelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602057B RID: 132475 RVA: 0x00AC18CC File Offset: 0x00ABFACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canNotFightStringTableId(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)playerSimpleInfoUIController.m_luaExportHelper.m_canNotFightStringTableId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602057C RID: 132476 RVA: 0x00AC1924 File Offset: 0x00ABFB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canNotFightStringTableId(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			StringTableId canNotFightStringTableId;
			LuaObject.checkEnum<StringTableId>(l, 2, out canNotFightStringTableId);
			playerSimpleInfoUIController.m_luaExportHelper.m_canNotFightStringTableId = canNotFightStringTableId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602057D RID: 132477 RVA: 0x00AC1980 File Offset: 0x00ABFB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602057E RID: 132478 RVA: 0x00AC19D8 File Offset: 0x00ABFBD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			playerSimpleInfoUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602057F RID: 132479 RVA: 0x00AC1A34 File Offset: 0x00ABFC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PanelSize(IntPtr l)
	{
		int result;
		try
		{
			PlayerSimpleInfoUIController playerSimpleInfoUIController = (PlayerSimpleInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoUIController.PanelSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020580 RID: 132480 RVA: 0x00AC1A88 File Offset: 0x00ABFC88
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerSimpleInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.UpdatePlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.ShowOrHide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.GetViewRect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.SetPanelPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.SetGuildButtonGroupStateByMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.GetPanelSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.SetGuildButtonGroupListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnExpelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnVChairmanChangeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnVChairmanButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnChairmanMoveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnChairmanRelieveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnWatchCardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnPrivateChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnPKButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnPKGreyButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnDeleteFriendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnAddFriendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnBlockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnLikeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.OnBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callDele_EventOnWatchCardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__clearDele_EventOnWatchCardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callDele_EventOnPrivateChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__clearDele_EventOnPrivateChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callDele_EventOnPKButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__clearDele_EventOnPKButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callDele_EventOnDeleteFriendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__clearDele_EventOnDeleteFriendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callDele_EventOnAddFriendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__clearDele_EventOnAddFriendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callDele_EventOnBlockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__clearDele_EventOnBlockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callDele_EventOnLikeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__clearDele_EventOnLikeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callDele_EventOnBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__clearDele_EventOnBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callDele_EventOnChairmanRelieveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__clearDele_EventOnChairmanRelieveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callDele_EventOnChairmanMoveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__clearDele_EventOnChairmanMoveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callDele_EventOnVChairmanChangeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__clearDele_EventOnVChairmanChangeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__callDele_EventOnExpelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.__clearDele_EventOnExpelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3A);
		string name = "EventOnWatchCardButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_EventOnWatchCardButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3B, true);
		string name2 = "EventOnPrivateChatButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_EventOnPrivateChatButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3C, true);
		string name3 = "EventOnPKButtonClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_EventOnPKButtonClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3D, true);
		string name4 = "EventOnDeleteFriendButtonClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_EventOnDeleteFriendButtonClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3E, true);
		string name5 = "EventOnAddFriendButtonClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_EventOnAddFriendButtonClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache3F, true);
		string name6 = "EventOnBlockButtonClick";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_EventOnBlockButtonClick);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache40, true);
		string name7 = "EventOnLikeButtonClick";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_EventOnLikeButtonClick);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache41, true);
		string name8 = "EventOnBGButtonClick";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_EventOnBGButtonClick);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache42, true);
		string name9 = "EventOnChairmanRelieveButtonClick";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_EventOnChairmanRelieveButtonClick);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache43, true);
		string name10 = "EventOnChairmanMoveButtonClick";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_EventOnChairmanMoveButtonClick);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache44, true);
		string name11 = "EventOnVChairmanChangeButtonClick";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_EventOnVChairmanChangeButtonClick);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache45, true);
		string name12 = "EventOnExpelButtonClick";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_EventOnExpelButtonClick);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache46, true);
		string name13 = "m_playerInfo";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_m_playerInfo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_m_playerInfo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache48, true);
		string name14 = "PanelRoot";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_PanelRoot);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_PanelRoot);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4A, true);
		string name15 = "PlayerIcon";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_PlayerIcon);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_PlayerIcon);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4C, true);
		string name16 = "m_headFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_m_headFrameTransform);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_m_headFrameTransform);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4E, true);
		string name17 = "m_likeUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_m_likeUIStateController);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_m_likeUIStateController);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache50, true);
		string name18 = "LevelText";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_LevelText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_LevelText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache52, true);
		string name19 = "PlayerNameText";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_PlayerNameText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_PlayerNameText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache54, true);
		string name20 = "LikeNumberText";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_LikeNumberText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_LikeNumberText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache56, true);
		string name21 = "WatchButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_WatchButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_WatchButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache58, true);
		string name22 = "FightButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_FightButton);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_FightButton);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5A, true);
		string name23 = "FightGreyButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_FightGreyButton);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_FightGreyButton);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5C, true);
		string name24 = "DeleteFriendButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_DeleteFriendButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_DeleteFriendButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5E, true);
		string name25 = "ChatButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_ChatButton);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_ChatButton);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache60, true);
		string name26 = "LikeButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_LikeButton);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_LikeButton);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache62, true);
		string name27 = "AddFriendButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_AddFriendButton);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_AddFriendButton);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache64, true);
		string name28 = "ShieldButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_ShieldButton);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_ShieldButton);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache66, true);
		string name29 = "BGButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_BGButton);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_BGButton);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache68, true);
		string name30 = "PanelOpenOrCloseStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_PanelOpenOrCloseStateCtrl);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_PanelOpenOrCloseStateCtrl);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6A, true);
		string name31 = "PanelShowStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_PanelShowStateCtrl);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_PanelShowStateCtrl);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6C, true);
		string name32 = "SociatyButtonGroupStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_SociatyButtonGroupStateCtrl);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_SociatyButtonGroupStateCtrl);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6E, true);
		string name33 = "ChairmanRelieveButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_ChairmanRelieveButton);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_ChairmanRelieveButton);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache70, true);
		string name34 = "ChairmanMoveButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_ChairmanMoveButton);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_ChairmanMoveButton);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache72, true);
		string name35 = "VChairmanButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_VChairmanButton);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_VChairmanButton);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache74, true);
		string name36 = "VChairmanChangeButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_VChairmanChangeButton);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_VChairmanChangeButton);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache76, true);
		string name37 = "ExpelButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_ExpelButton);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_ExpelButton);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache78, true);
		string name38 = "m_canNotFightStringTableId";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_m_canNotFightStringTableId);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_m_canNotFightStringTableId);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7A, true);
		string name39 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_m_playerContext);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7C, true);
		string name40 = "PanelSize";
		if (Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.get_PanelSize);
		}
		LuaObject.addMember(l, name40, Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.<>f__mg$cache7D, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlayerSimpleInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016480 RID: 91264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016481 RID: 91265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016482 RID: 91266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016483 RID: 91267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016484 RID: 91268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016485 RID: 91269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016486 RID: 91270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016487 RID: 91271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016488 RID: 91272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016489 RID: 91273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401648A RID: 91274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401648B RID: 91275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401648C RID: 91276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401648D RID: 91277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401648E RID: 91278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401648F RID: 91279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016490 RID: 91280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016491 RID: 91281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016492 RID: 91282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016493 RID: 91283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016494 RID: 91284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016495 RID: 91285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016496 RID: 91286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016497 RID: 91287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016498 RID: 91288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016499 RID: 91289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401649A RID: 91290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401649B RID: 91291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401649C RID: 91292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401649D RID: 91293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401649E RID: 91294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401649F RID: 91295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040164A0 RID: 91296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040164A1 RID: 91297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040164A2 RID: 91298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040164A3 RID: 91299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040164A4 RID: 91300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040164A5 RID: 91301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040164A6 RID: 91302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040164A7 RID: 91303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040164A8 RID: 91304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040164A9 RID: 91305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040164AA RID: 91306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040164AB RID: 91307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040164AC RID: 91308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040164AD RID: 91309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040164AE RID: 91310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040164AF RID: 91311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040164B0 RID: 91312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040164B1 RID: 91313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040164B2 RID: 91314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040164B3 RID: 91315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040164B4 RID: 91316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040164B5 RID: 91317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040164B6 RID: 91318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040164B7 RID: 91319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040164B8 RID: 91320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040164B9 RID: 91321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040164BA RID: 91322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040164BB RID: 91323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040164BC RID: 91324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040164BD RID: 91325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040164BE RID: 91326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040164BF RID: 91327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040164C0 RID: 91328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040164C1 RID: 91329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040164C2 RID: 91330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040164C3 RID: 91331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040164C4 RID: 91332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040164C5 RID: 91333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040164C6 RID: 91334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040164C7 RID: 91335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040164C8 RID: 91336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040164C9 RID: 91337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040164CA RID: 91338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040164CB RID: 91339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040164CC RID: 91340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040164CD RID: 91341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040164CE RID: 91342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040164CF RID: 91343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040164D0 RID: 91344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040164D1 RID: 91345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040164D2 RID: 91346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040164D3 RID: 91347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040164D4 RID: 91348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040164D5 RID: 91349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040164D6 RID: 91350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040164D7 RID: 91351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040164D8 RID: 91352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040164D9 RID: 91353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040164DA RID: 91354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040164DB RID: 91355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040164DC RID: 91356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040164DD RID: 91357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040164DE RID: 91358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040164DF RID: 91359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040164E0 RID: 91360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040164E1 RID: 91361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040164E2 RID: 91362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040164E3 RID: 91363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040164E4 RID: 91364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040164E5 RID: 91365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040164E6 RID: 91366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040164E7 RID: 91367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040164E8 RID: 91368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040164E9 RID: 91369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040164EA RID: 91370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040164EB RID: 91371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040164EC RID: 91372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040164ED RID: 91373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040164EE RID: 91374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040164EF RID: 91375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040164F0 RID: 91376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040164F1 RID: 91377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040164F2 RID: 91378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040164F3 RID: 91379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040164F4 RID: 91380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040164F5 RID: 91381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040164F6 RID: 91382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040164F7 RID: 91383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040164F8 RID: 91384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040164F9 RID: 91385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040164FA RID: 91386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040164FB RID: 91387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040164FC RID: 91388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040164FD RID: 91389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;
}
