using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001458 RID: 5208
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendUIController : LuaObject
{
	// Token: 0x0601DF94 RID: 122772 RVA: 0x0099516C File Offset: 0x0099336C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFriendPanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<UserSummary> friendPanel;
			LuaObject.checkType<List<UserSummary>>(l, 2, out friendPanel);
			friendUIController.SetFriendPanel(friendPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF95 RID: 122773 RVA: 0x009951C4 File Offset: 0x009933C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAcrossServerFriendPanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<UserSummary> acrossServerFriendPanel;
			LuaObject.checkType<List<UserSummary>>(l, 2, out acrossServerFriendPanel);
			friendUIController.SetAcrossServerFriendPanel(acrossServerFriendPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF96 RID: 122774 RVA: 0x0099521C File Offset: 0x0099341C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRecentPanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<UserSummary> recentPanel;
			LuaObject.checkType<List<UserSummary>>(l, 2, out recentPanel);
			friendUIController.SetRecentPanel(recentPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF97 RID: 122775 RVA: 0x00995274 File Offset: 0x00993474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGroupPanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<ProChatGroupCompactInfo> groupPanel;
			LuaObject.checkType<List<ProChatGroupCompactInfo>>(l, 2, out groupPanel);
			friendUIController.SetGroupPanel(groupPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF98 RID: 122776 RVA: 0x009952CC File Offset: 0x009934CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFirstToggleOn(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.SetFirstToggleOn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF99 RID: 122777 RVA: 0x00995318 File Offset: 0x00993518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPanelScrollViewReset(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.SetPanelScrollViewReset();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF9A RID: 122778 RVA: 0x00995364 File Offset: 0x00993564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAddFriendRedMarkShow(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			friendUIController.IsAddFriendRedMarkShow(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF9B RID: 122779 RVA: 0x009953BC File Offset: 0x009935BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowFriendShipPointTip(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string s;
			LuaObject.checkType(l, 2, out s);
			friendUIController.ShowFriendShipPointTip(s);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF9C RID: 122780 RVA: 0x00995414 File Offset: 0x00993614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetShieldPanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<UserSummary> shieldPanel;
			LuaObject.checkType<List<UserSummary>>(l, 2, out shieldPanel);
			friendUIController.SetShieldPanel(shieldPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF9D RID: 122781 RVA: 0x0099546C File Offset: 0x0099366C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFindFriendList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<UserSummary> findFriendList;
			LuaObject.checkType<List<UserSummary>>(l, 2, out findFriendList);
			friendUIController.SetFindFriendList(findFriendList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF9E RID: 122782 RVA: 0x009954C4 File Offset: 0x009936C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRecommendFriendsList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<UserSummary> recommendFriendsList;
			LuaObject.checkType<List<UserSummary>>(l, 2, out recommendFriendsList);
			friendUIController.SetRecommendFriendsList(recommendFriendsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF9F RID: 122783 RVA: 0x0099551C File Offset: 0x0099371C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetApplyFriendsList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<UserSummary> applyFriendsList;
			LuaObject.checkType<List<UserSummary>>(l, 2, out applyFriendsList);
			friendUIController.SetApplyFriendsList(applyFriendsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFA0 RID: 122784 RVA: 0x00995574 File Offset: 0x00993774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInviteFriendToGroupPanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.SetInviteFriendToGroupPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFA1 RID: 122785 RVA: 0x009955C0 File Offset: 0x009937C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetWatchGroupStaffPanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			ProChatGroupInfo chatGroupInfo;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out chatGroupInfo);
			bool needOpenTween;
			LuaObject.checkType(l, 3, out needOpenTween);
			friendUIController.SetWatchGroupStaffPanel(chatGroupInfo, needOpenTween);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFA2 RID: 122786 RVA: 0x00995624 File Offset: 0x00993824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WatchGroupStaffPanelClose(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.WatchGroupStaffPanelClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFA3 RID: 122787 RVA: 0x00995670 File Offset: 0x00993870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GroupDissolved(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			ProChatGroupInfo chatGroupInfo;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out chatGroupInfo);
			friendUIController.GroupDissolved(chatGroupInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFA4 RID: 122788 RVA: 0x009956C8 File Offset: 0x009938C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWatchGroupStaffPanelChangeNamePanelBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.OnWatchGroupStaffPanelChangeNamePanelBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFA5 RID: 122789 RVA: 0x00995714 File Offset: 0x00993914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InviteFriendToGoupPanelClose(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.InviteFriendToGoupPanelClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFA6 RID: 122790 RVA: 0x00995760 File Offset: 0x00993960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFA7 RID: 122791 RVA: 0x009957B4 File Offset: 0x009939B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAddFriendPanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.SetAddFriendPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFA8 RID: 122792 RVA: 0x00995808 File Offset: 0x00993A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInviteFriendToGroupList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.SetInviteFriendToGroupList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFA9 RID: 122793 RVA: 0x0099585C File Offset: 0x00993A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInviteAcrossServerFriendToGroupList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.SetInviteAcrossServerFriendToGroupList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFAA RID: 122794 RVA: 0x009958B0 File Offset: 0x00993AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBasicBigFriendInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject parentScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out parentScrollViewContent);
			List<UserSummary> userList;
			LuaObject.checkType<List<UserSummary>>(l, 3, out userList);
			FriendInfoType friendInfoType;
			LuaObject.checkEnum<FriendInfoType>(l, 4, out friendInfoType);
			bool isChatGroupOwner;
			LuaObject.checkType(l, 5, out isChatGroupOwner);
			friendUIController.m_luaExportHelper.SetBasicBigFriendInfo(parentScrollViewContent, userList, friendInfoType, isChatGroupOwner);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFAB RID: 122795 RVA: 0x00995934 File Offset: 0x00993B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBasicSmallFriendInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject parentScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out parentScrollViewContent);
			List<UserSummary> userList;
			LuaObject.checkType<List<UserSummary>>(l, 3, out userList);
			FriendInfoType friendInfoType;
			LuaObject.checkEnum<FriendInfoType>(l, 4, out friendInfoType);
			friendUIController.m_luaExportHelper.SetBasicSmallFriendInfo(parentScrollViewContent, userList, friendInfoType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFAC RID: 122796 RVA: 0x009959AC File Offset: 0x00993BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetServerListInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.SetServerListInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFAD RID: 122797 RVA: 0x00995A00 File Offset: 0x00993C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFriendToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			friendUIController.m_luaExportHelper.OnFriendToggle(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFAE RID: 122798 RVA: 0x00995A5C File Offset: 0x00993C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAcrossServerToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			friendUIController.m_luaExportHelper.OnAcrossServerToggle(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFAF RID: 122799 RVA: 0x00995AB8 File Offset: 0x00993CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRecentToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			friendUIController.m_luaExportHelper.OnRecentToggle(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFB0 RID: 122800 RVA: 0x00995B14 File Offset: 0x00993D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGroupToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			friendUIController.m_luaExportHelper.OnGroupToggle(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFB1 RID: 122801 RVA: 0x00995B70 File Offset: 0x00993D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFB2 RID: 122802 RVA: 0x00995BC4 File Offset: 0x00993DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFB3 RID: 122803 RVA: 0x00995C18 File Offset: 0x00993E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShieldButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnShieldButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFB4 RID: 122804 RVA: 0x00995C6C File Offset: 0x00993E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShieldPanelCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnShieldPanelCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFB5 RID: 122805 RVA: 0x00995CC0 File Offset: 0x00993EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSendAllFriendshipPointButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnSendAllFriendshipPointButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFB6 RID: 122806 RVA: 0x00995D14 File Offset: 0x00993F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetAllFriendshipPointButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnGetAllFriendshipPointButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFB7 RID: 122807 RVA: 0x00995D68 File Offset: 0x00993F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddFriendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnAddFriendButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFB8 RID: 122808 RVA: 0x00995DBC File Offset: 0x00993FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddFriendPanelCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnAddFriendPanelCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFB9 RID: 122809 RVA: 0x00995E10 File Offset: 0x00994010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelectServerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnSelectServerButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFBA RID: 122810 RVA: 0x00995E64 File Offset: 0x00994064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnServerListPanelBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnServerListPanelBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFBB RID: 122811 RVA: 0x00995EB8 File Offset: 0x009940B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSendAllFriendshipPointButtonState(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.SetSendAllFriendshipPointButtonState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFBC RID: 122812 RVA: 0x00995F0C File Offset: 0x0099410C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGetAllFriendshipPointButtonState(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.SetGetAllFriendshipPointButtonState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFBD RID: 122813 RVA: 0x00995F60 File Offset: 0x00994160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddFriendPanelSearchButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnAddFriendPanelSearchButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFBE RID: 122814 RVA: 0x00995FB4 File Offset: 0x009941B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddFriendPanelChangeRecommendFriendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnAddFriendPanelChangeRecommendFriendButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFBF RID: 122815 RVA: 0x00996008 File Offset: 0x00994208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddFriendPanelAddAllButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnAddFriendPanelAddAllButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFC0 RID: 122816 RVA: 0x0099605C File Offset: 0x0099425C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddFriendPanelAcceptAllButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnAddFriendPanelAcceptAllButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFC1 RID: 122817 RVA: 0x009960B0 File Offset: 0x009942B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddFriendPanelRefuseAllButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnAddFriendPanelRefuseAllButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFC2 RID: 122818 RVA: 0x00996104 File Offset: 0x00994304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWatchGroupStaffPanelCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnWatchGroupStaffPanelCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFC3 RID: 122819 RVA: 0x00996158 File Offset: 0x00994358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWatchGroupStaffPanelChangeNameButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnWatchGroupStaffPanelChangeNameButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFC4 RID: 122820 RVA: 0x009961AC File Offset: 0x009943AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWatchGroupStaffPanelChangeNameConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnWatchGroupStaffPanelChangeNameConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFC5 RID: 122821 RVA: 0x00996200 File Offset: 0x00994400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnQuitGroupButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnQuitGroupButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFC6 RID: 122822 RVA: 0x00996254 File Offset: 0x00994454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCreateNewGroupButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnCreateNewGroupButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFC7 RID: 122823 RVA: 0x009962A8 File Offset: 0x009944A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInviteFriendToGroupButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnInviteFriendToGroupButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFC8 RID: 122824 RVA: 0x009962FC File Offset: 0x009944FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInviteFriendToGoupPanelConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.OnInviteFriendToGoupPanelConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFC9 RID: 122825 RVA: 0x00996350 File Offset: 0x00994550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInviteFriendToGroupPanelServerFriendToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			friendUIController.m_luaExportHelper.OnInviteFriendToGroupPanelServerFriendToggle(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFCA RID: 122826 RVA: 0x009963AC File Offset: 0x009945AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInviteFriendToGroupPanelFriendToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			friendUIController.m_luaExportHelper.OnInviteFriendToGroupPanelFriendToggle(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFCB RID: 122827 RVA: 0x00996408 File Offset: 0x00994608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayerItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(FriendBigItemUIController)))
			{
				FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
				FriendBigItemUIController ctrl;
				LuaObject.checkType<FriendBigItemUIController>(l, 2, out ctrl);
				friendUIController.m_luaExportHelper.OnPlayerItemButtonClick(ctrl);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(FriendSmallItemUIController)))
			{
				FriendUIController friendUIController2 = (FriendUIController)LuaObject.checkSelf(l);
				FriendSmallItemUIController ctrl2;
				LuaObject.checkType<FriendSmallItemUIController>(l, 2, out ctrl2);
				friendUIController2.m_luaExportHelper.OnPlayerItemButtonClick(ctrl2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OnPlayerItemButtonClick to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFCC RID: 122828 RVA: 0x009964E8 File Offset: 0x009946E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemAddFriendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(FriendBigItemUIController)))
			{
				FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
				FriendBigItemUIController ctrl;
				LuaObject.checkType<FriendBigItemUIController>(l, 2, out ctrl);
				friendUIController.m_luaExportHelper.OnItemAddFriendButtonClick(ctrl);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(FriendSmallItemUIController)))
			{
				FriendUIController friendUIController2 = (FriendUIController)LuaObject.checkSelf(l);
				FriendSmallItemUIController ctrl2;
				LuaObject.checkType<FriendSmallItemUIController>(l, 2, out ctrl2);
				friendUIController2.m_luaExportHelper.OnItemAddFriendButtonClick(ctrl2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OnItemAddFriendButtonClick to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFCD RID: 122829 RVA: 0x009965C8 File Offset: 0x009947C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemKickFromGroupButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController ctrl;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out ctrl);
			friendUIController.m_luaExportHelper.OnItemKickFromGroupButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFCE RID: 122830 RVA: 0x00996624 File Offset: 0x00994824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnblockPlayerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController ctrl;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out ctrl);
			friendUIController.m_luaExportHelper.OnUnblockPlayerButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFCF RID: 122831 RVA: 0x00996680 File Offset: 0x00994880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(FriendBigItemUIController)))
			{
				FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
				FriendBigItemUIController ctrl;
				LuaObject.checkType<FriendBigItemUIController>(l, 2, out ctrl);
				friendUIController.m_luaExportHelper.OnChatButtonClick(ctrl);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(FriendSmallItemUIController)))
			{
				FriendUIController friendUIController2 = (FriendUIController)LuaObject.checkSelf(l);
				FriendSmallItemUIController ctrl2;
				LuaObject.checkType<FriendSmallItemUIController>(l, 2, out ctrl2);
				friendUIController2.m_luaExportHelper.OnChatButtonClick(ctrl2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OnChatButtonClick to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFD0 RID: 122832 RVA: 0x00996760 File Offset: 0x00994960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSendFriendshipPointButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController ctrl;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out ctrl);
			friendUIController.m_luaExportHelper.OnSendFriendshipPointButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFD1 RID: 122833 RVA: 0x009967BC File Offset: 0x009949BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetFriendshipPointButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController ctrl;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out ctrl);
			friendUIController.m_luaExportHelper.OnGetFriendshipPointButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFD2 RID: 122834 RVA: 0x00996818 File Offset: 0x00994A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFriendshipPointDoneButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			FriendBigItemUIController ctrl;
			LuaObject.checkType<FriendBigItemUIController>(l, 2, out ctrl);
			friendUIController.m_luaExportHelper.OnFriendshipPointDoneButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFD3 RID: 122835 RVA: 0x00996874 File Offset: 0x00994A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFriendApplyAceeptButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			FriendSmallItemUIController ctrl;
			LuaObject.checkType<FriendSmallItemUIController>(l, 2, out ctrl);
			friendUIController.m_luaExportHelper.OnFriendApplyAceeptButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFD4 RID: 122836 RVA: 0x009968D0 File Offset: 0x00994AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFriendApplyDeclineButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			FriendSmallItemUIController ctrl;
			LuaObject.checkType<FriendSmallItemUIController>(l, 2, out ctrl);
			friendUIController.m_luaExportHelper.OnFriendApplyDeclineButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFD5 RID: 122837 RVA: 0x0099692C File Offset: 0x00994B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInviteFriendToGroupToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			FriendSmallItemUIController ctrl;
			LuaObject.checkType<FriendSmallItemUIController>(l, 3, out ctrl);
			friendUIController.m_luaExportHelper.OnInviteFriendToGroupToggleValueChanged(isOn, ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFD6 RID: 122838 RVA: 0x00996998 File Offset: 0x00994B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGroupChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			FriendGroupUIController ctrl;
			LuaObject.checkType<FriendGroupUIController>(l, 2, out ctrl);
			friendUIController.m_luaExportHelper.OnGroupChatButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFD7 RID: 122839 RVA: 0x009969F4 File Offset: 0x00994BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWatchGroupStaffButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			FriendGroupUIController ctrl;
			LuaObject.checkType<FriendGroupUIController>(l, 2, out ctrl);
			friendUIController.m_luaExportHelper.OnWatchGroupStaffButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFD8 RID: 122840 RVA: 0x00996A50 File Offset: 0x00994C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			friendUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFD9 RID: 122841 RVA: 0x00996ABC File Offset: 0x00994CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFDA RID: 122842 RVA: 0x00996B10 File Offset: 0x00994D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFDB RID: 122843 RVA: 0x00996B64 File Offset: 0x00994D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = friendUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DFDC RID: 122844 RVA: 0x00996C0C File Offset: 0x00994E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFDD RID: 122845 RVA: 0x00996C60 File Offset: 0x00994E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			friendUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFDE RID: 122846 RVA: 0x00996CCC File Offset: 0x00994ECC
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
				FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				friendUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FriendUIController friendUIController2 = (FriendUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				friendUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DFDF RID: 122847 RVA: 0x00996DDC File Offset: 0x00994FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFE0 RID: 122848 RVA: 0x00996E48 File Offset: 0x00995048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFE1 RID: 122849 RVA: 0x00996EB4 File Offset: 0x009950B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFE2 RID: 122850 RVA: 0x00996F20 File Offset: 0x00995120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFE3 RID: 122851 RVA: 0x00996F8C File Offset: 0x0099518C
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
				FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				friendUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FriendUIController friendUIController2 = (FriendUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				friendUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DFE4 RID: 122852 RVA: 0x0099709C File Offset: 0x0099529C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string s = friendUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DFE5 RID: 122853 RVA: 0x009970F8 File Offset: 0x009952F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFE6 RID: 122854 RVA: 0x0099714C File Offset: 0x0099534C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFE7 RID: 122855 RVA: 0x009971A0 File Offset: 0x009953A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFE8 RID: 122856 RVA: 0x009971F4 File Offset: 0x009953F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFE9 RID: 122857 RVA: 0x00997248 File Offset: 0x00995448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowPanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			FriendPanelType obj;
			LuaObject.checkEnum<FriendPanelType>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__callDele_EventOnShowPanel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFEA RID: 122858 RVA: 0x009972A4 File Offset: 0x009954A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowPanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			FriendPanelType obj;
			LuaObject.checkEnum<FriendPanelType>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__clearDele_EventOnShowPanel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFEB RID: 122859 RVA: 0x00997300 File Offset: 0x00995500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<string> obj;
			LuaObject.checkType<List<string>>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__callDele_EventOnAddFriend(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFEC RID: 122860 RVA: 0x0099735C File Offset: 0x0099555C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<string> obj;
			LuaObject.checkType<List<string>>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__clearDele_EventOnAddFriend(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFED RID: 122861 RVA: 0x009973B8 File Offset: 0x009955B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnKickFromGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			ProChatGroupInfo arg;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out arg);
			UserSummary arg2;
			LuaObject.checkType<UserSummary>(l, 3, out arg2);
			friendUIController.m_luaExportHelper.__callDele_EventOnKickFromGroup(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFEE RID: 122862 RVA: 0x00997424 File Offset: 0x00995624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnKickFromGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			ProChatGroupInfo arg;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out arg);
			UserSummary arg2;
			LuaObject.checkType<UserSummary>(l, 3, out arg2);
			friendUIController.m_luaExportHelper.__clearDele_EventOnKickFromGroup(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFEF RID: 122863 RVA: 0x00997490 File Offset: 0x00995690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUnblockPlayer(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			friendUIController.m_luaExportHelper.__callDele_EventOnUnblockPlayer(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFF0 RID: 122864 RVA: 0x009974EC File Offset: 0x009956EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnUnblockPlayer(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			friendUIController.m_luaExportHelper.__clearDele_EventOnUnblockPlayer(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFF1 RID: 122865 RVA: 0x00997548 File Offset: 0x00995748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChat(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			UserSummary obj;
			LuaObject.checkType<UserSummary>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__callDele_EventOnChat(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFF2 RID: 122866 RVA: 0x009975A4 File Offset: 0x009957A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChat(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			UserSummary obj;
			LuaObject.checkType<UserSummary>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__clearDele_EventOnChat(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFF3 RID: 122867 RVA: 0x00997600 File Offset: 0x00995800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSendFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			friendUIController.m_luaExportHelper.__callDele_EventOnSendFriendshipPoint(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFF4 RID: 122868 RVA: 0x0099765C File Offset: 0x0099585C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSendFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			friendUIController.m_luaExportHelper.__clearDele_EventOnSendFriendshipPoint(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFF5 RID: 122869 RVA: 0x009976B8 File Offset: 0x009958B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			friendUIController.m_luaExportHelper.__callDele_EventOnGetFriendshipPoint(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFF6 RID: 122870 RVA: 0x00997714 File Offset: 0x00995914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			friendUIController.m_luaExportHelper.__clearDele_EventOnGetFriendshipPoint(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFF7 RID: 122871 RVA: 0x00997770 File Offset: 0x00995970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnFindFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			string arg2;
			LuaObject.checkType(l, 3, out arg2);
			friendUIController.m_luaExportHelper.__callDele_EventOnFindFriend(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFF8 RID: 122872 RVA: 0x009977DC File Offset: 0x009959DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnFindFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			string arg2;
			LuaObject.checkType(l, 3, out arg2);
			friendUIController.m_luaExportHelper.__clearDele_EventOnFindFriend(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFF9 RID: 122873 RVA: 0x00997848 File Offset: 0x00995A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSendAllFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__callDele_EventOnSendAllFriendshipPoint();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFFA RID: 122874 RVA: 0x0099789C File Offset: 0x00995A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSendAllFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__clearDele_EventOnSendAllFriendshipPoint();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFFB RID: 122875 RVA: 0x009978F0 File Offset: 0x00995AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetAllFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__callDele_EventOnGetAllFriendshipPoint();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFFC RID: 122876 RVA: 0x00997944 File Offset: 0x00995B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetAllFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__clearDele_EventOnGetAllFriendshipPoint();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFFD RID: 122877 RVA: 0x00997998 File Offset: 0x00995B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetRecommendFriendsList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__callDele_EventOnGetRecommendFriendsList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFFE RID: 122878 RVA: 0x009979EC File Offset: 0x00995BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetRecommendFriendsList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			friendUIController.m_luaExportHelper.__clearDele_EventOnGetRecommendFriendsList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DFFF RID: 122879 RVA: 0x00997A40 File Offset: 0x00995C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnFriendApplyAceept(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<string> obj;
			LuaObject.checkType<List<string>>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__callDele_EventOnFriendApplyAceept(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E000 RID: 122880 RVA: 0x00997A9C File Offset: 0x00995C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnFriendApplyAceept(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<string> obj;
			LuaObject.checkType<List<string>>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__clearDele_EventOnFriendApplyAceept(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E001 RID: 122881 RVA: 0x00997AF8 File Offset: 0x00995CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnFriendApplyDecline(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<string> obj;
			LuaObject.checkType<List<string>>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__callDele_EventOnFriendApplyDecline(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E002 RID: 122882 RVA: 0x00997B54 File Offset: 0x00995D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnFriendApplyDecline(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<string> obj;
			LuaObject.checkType<List<string>>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__clearDele_EventOnFriendApplyDecline(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E003 RID: 122883 RVA: 0x00997BB0 File Offset: 0x00995DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowPlayerSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			UserSummary arg;
			LuaObject.checkType<UserSummary>(l, 2, out arg);
			Vector3 arg2;
			LuaObject.checkType(l, 3, out arg2);
			PlayerSimpleInfoUITask.PostionType arg3;
			LuaObject.checkEnum<PlayerSimpleInfoUITask.PostionType>(l, 4, out arg3);
			friendUIController.m_luaExportHelper.__callDele_EventOnShowPlayerSimpleInfo(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E004 RID: 122884 RVA: 0x00997C28 File Offset: 0x00995E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowPlayerSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			UserSummary arg;
			LuaObject.checkType<UserSummary>(l, 2, out arg);
			Vector3 arg2;
			LuaObject.checkType(l, 3, out arg2);
			PlayerSimpleInfoUITask.PostionType arg3;
			LuaObject.checkEnum<PlayerSimpleInfoUITask.PostionType>(l, 4, out arg3);
			friendUIController.m_luaExportHelper.__clearDele_EventOnShowPlayerSimpleInfo(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E005 RID: 122885 RVA: 0x00997CA0 File Offset: 0x00995EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGroupChat(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			friendUIController.m_luaExportHelper.__callDele_EventOnGroupChat(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E006 RID: 122886 RVA: 0x00997CFC File Offset: 0x00995EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGroupChat(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			friendUIController.m_luaExportHelper.__clearDele_EventOnGroupChat(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E007 RID: 122887 RVA: 0x00997D58 File Offset: 0x00995F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnWatchGroupStaff(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			friendUIController.m_luaExportHelper.__callDele_EventOnWatchGroupStaff(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E008 RID: 122888 RVA: 0x00997DC4 File Offset: 0x00995FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnWatchGroupStaff(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			friendUIController.m_luaExportHelper.__clearDele_EventOnWatchGroupStaff(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E009 RID: 122889 RVA: 0x00997E30 File Offset: 0x00996030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCreateNewGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<string> obj;
			LuaObject.checkType<List<string>>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__callDele_EventOnCreateNewGroup(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E00A RID: 122890 RVA: 0x00997E8C File Offset: 0x0099608C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCreateNewGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<string> obj;
			LuaObject.checkType<List<string>>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__clearDele_EventOnCreateNewGroup(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E00B RID: 122891 RVA: 0x00997EE8 File Offset: 0x009960E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnInviteFriendToGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			List<string> arg2;
			LuaObject.checkType<List<string>>(l, 3, out arg2);
			friendUIController.m_luaExportHelper.__callDele_EventOnInviteFriendToGroup(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E00C RID: 122892 RVA: 0x00997F54 File Offset: 0x00996154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnInviteFriendToGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			List<string> arg2;
			LuaObject.checkType<List<string>>(l, 3, out arg2);
			friendUIController.m_luaExportHelper.__clearDele_EventOnInviteFriendToGroup(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E00D RID: 122893 RVA: 0x00997FC0 File Offset: 0x009961C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeGroupName(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			string arg2;
			LuaObject.checkType(l, 3, out arg2);
			friendUIController.m_luaExportHelper.__callDele_EventOnChangeGroupName(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E00E RID: 122894 RVA: 0x0099802C File Offset: 0x0099622C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangeGroupName(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			string arg2;
			LuaObject.checkType(l, 3, out arg2);
			friendUIController.m_luaExportHelper.__clearDele_EventOnChangeGroupName(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E00F RID: 122895 RVA: 0x00998098 File Offset: 0x00996298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnLeaveGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			ProChatGroupInfo obj;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__callDele_EventOnLeaveGroup(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E010 RID: 122896 RVA: 0x009980F4 File Offset: 0x009962F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnLeaveGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			ProChatGroupInfo obj;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out obj);
			friendUIController.m_luaExportHelper.__clearDele_EventOnLeaveGroup(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E011 RID: 122897 RVA: 0x00998150 File Offset: 0x00996350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnReturn -= value;
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

	// Token: 0x0601E012 RID: 122898 RVA: 0x009981D0 File Offset: 0x009963D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601E013 RID: 122899 RVA: 0x00998250 File Offset: 0x00996450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowPanel(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<FriendPanelType> value;
			int num = LuaObject.checkDelegate<Action<FriendPanelType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnShowPanel += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnShowPanel -= value;
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

	// Token: 0x0601E014 RID: 122900 RVA: 0x009982D0 File Offset: 0x009964D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<List<string>> value;
			int num = LuaObject.checkDelegate<Action<List<string>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnAddFriend += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnAddFriend -= value;
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

	// Token: 0x0601E015 RID: 122901 RVA: 0x00998350 File Offset: 0x00996550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnKickFromGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<ProChatGroupInfo, UserSummary> value;
			int num = LuaObject.checkDelegate<Action<ProChatGroupInfo, UserSummary>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnKickFromGroup += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnKickFromGroup -= value;
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

	// Token: 0x0601E016 RID: 122902 RVA: 0x009983D0 File Offset: 0x009965D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUnblockPlayer(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnUnblockPlayer += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnUnblockPlayer -= value;
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

	// Token: 0x0601E017 RID: 122903 RVA: 0x00998450 File Offset: 0x00996650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChat(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<UserSummary> value;
			int num = LuaObject.checkDelegate<Action<UserSummary>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnChat += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnChat -= value;
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

	// Token: 0x0601E018 RID: 122904 RVA: 0x009984D0 File Offset: 0x009966D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSendFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnSendFriendshipPoint += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnSendFriendshipPoint -= value;
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

	// Token: 0x0601E019 RID: 122905 RVA: 0x00998550 File Offset: 0x00996750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnGetFriendshipPoint += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnGetFriendshipPoint -= value;
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

	// Token: 0x0601E01A RID: 122906 RVA: 0x009985D0 File Offset: 0x009967D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnFindFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<int, string> value;
			int num = LuaObject.checkDelegate<Action<int, string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnFindFriend += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnFindFriend -= value;
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

	// Token: 0x0601E01B RID: 122907 RVA: 0x00998650 File Offset: 0x00996850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSendAllFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnSendAllFriendshipPoint += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnSendAllFriendshipPoint -= value;
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

	// Token: 0x0601E01C RID: 122908 RVA: 0x009986D0 File Offset: 0x009968D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetAllFriendshipPoint(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnGetAllFriendshipPoint += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnGetAllFriendshipPoint -= value;
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

	// Token: 0x0601E01D RID: 122909 RVA: 0x00998750 File Offset: 0x00996950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetRecommendFriendsList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnGetRecommendFriendsList += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnGetRecommendFriendsList -= value;
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

	// Token: 0x0601E01E RID: 122910 RVA: 0x009987D0 File Offset: 0x009969D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnFriendApplyAceept(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<List<string>> value;
			int num = LuaObject.checkDelegate<Action<List<string>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnFriendApplyAceept += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnFriendApplyAceept -= value;
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

	// Token: 0x0601E01F RID: 122911 RVA: 0x00998850 File Offset: 0x00996A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnFriendApplyDecline(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<List<string>> value;
			int num = LuaObject.checkDelegate<Action<List<string>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnFriendApplyDecline += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnFriendApplyDecline -= value;
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

	// Token: 0x0601E020 RID: 122912 RVA: 0x009988D0 File Offset: 0x00996AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowPlayerSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<UserSummary, Vector3, PlayerSimpleInfoUITask.PostionType> value;
			int num = LuaObject.checkDelegate<Action<UserSummary, Vector3, PlayerSimpleInfoUITask.PostionType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnShowPlayerSimpleInfo += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnShowPlayerSimpleInfo -= value;
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

	// Token: 0x0601E021 RID: 122913 RVA: 0x00998950 File Offset: 0x00996B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGroupChat(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnGroupChat += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnGroupChat -= value;
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

	// Token: 0x0601E022 RID: 122914 RVA: 0x009989D0 File Offset: 0x00996BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnWatchGroupStaff(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<string, bool> value;
			int num = LuaObject.checkDelegate<Action<string, bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnWatchGroupStaff += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnWatchGroupStaff -= value;
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

	// Token: 0x0601E023 RID: 122915 RVA: 0x00998A50 File Offset: 0x00996C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCreateNewGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<List<string>> value;
			int num = LuaObject.checkDelegate<Action<List<string>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnCreateNewGroup += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnCreateNewGroup -= value;
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

	// Token: 0x0601E024 RID: 122916 RVA: 0x00998AD0 File Offset: 0x00996CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnInviteFriendToGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<string, List<string>> value;
			int num = LuaObject.checkDelegate<Action<string, List<string>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnInviteFriendToGroup += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnInviteFriendToGroup -= value;
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

	// Token: 0x0601E025 RID: 122917 RVA: 0x00998B50 File Offset: 0x00996D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeGroupName(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<string, string> value;
			int num = LuaObject.checkDelegate<Action<string, string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnChangeGroupName += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnChangeGroupName -= value;
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

	// Token: 0x0601E026 RID: 122918 RVA: 0x00998BD0 File Offset: 0x00996DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnLeaveGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Action<ProChatGroupInfo> value;
			int num = LuaObject.checkDelegate<Action<ProChatGroupInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendUIController.EventOnLeaveGroup += value;
				}
				else if (num == 2)
				{
					friendUIController.EventOnLeaveGroup -= value;
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

	// Token: 0x0601E027 RID: 122919 RVA: 0x00998C50 File Offset: 0x00996E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E028 RID: 122920 RVA: 0x00998CA8 File Offset: 0x00996EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			friendUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E029 RID: 122921 RVA: 0x00998D04 File Offset: 0x00996F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E02A RID: 122922 RVA: 0x00998D5C File Offset: 0x00996F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			friendUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E02B RID: 122923 RVA: 0x00998DB8 File Offset: 0x00996FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E02C RID: 122924 RVA: 0x00998E10 File Offset: 0x00997010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			friendUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E02D RID: 122925 RVA: 0x00998E6C File Offset: 0x0099706C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shieldButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_shieldButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E02E RID: 122926 RVA: 0x00998EC4 File Offset: 0x009970C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shieldButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button shieldButton;
			LuaObject.checkType<Button>(l, 2, out shieldButton);
			friendUIController.m_luaExportHelper.m_shieldButton = shieldButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E02F RID: 122927 RVA: 0x00998F20 File Offset: 0x00997120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E030 RID: 122928 RVA: 0x00998F78 File Offset: 0x00997178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button addFriendButton;
			LuaObject.checkType<Button>(l, 2, out addFriendButton);
			friendUIController.m_luaExportHelper.m_addFriendButton = addFriendButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E031 RID: 122929 RVA: 0x00998FD4 File Offset: 0x009971D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendRedMark(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E032 RID: 122930 RVA: 0x0099902C File Offset: 0x0099722C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendRedMark(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject addFriendRedMark;
			LuaObject.checkType<GameObject>(l, 2, out addFriendRedMark);
			friendUIController.m_luaExportHelper.m_addFriendRedMark = addFriendRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E033 RID: 122931 RVA: 0x00999088 File Offset: 0x00997288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_createNewGroupButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_createNewGroupButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E034 RID: 122932 RVA: 0x009990E0 File Offset: 0x009972E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_createNewGroupButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button createNewGroupButton;
			LuaObject.checkType<Button>(l, 2, out createNewGroupButton);
			friendUIController.m_luaExportHelper.m_createNewGroupButton = createNewGroupButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E035 RID: 122933 RVA: 0x0099913C File Offset: 0x0099733C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendCountUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_friendCountUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E036 RID: 122934 RVA: 0x00999194 File Offset: 0x00997394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendCountUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			CommonUIStateController friendCountUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out friendCountUIStateController);
			friendUIController.m_luaExportHelper.m_friendCountUIStateController = friendCountUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E037 RID: 122935 RVA: 0x009991F0 File Offset: 0x009973F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendTypeCount(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_friendTypeCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E038 RID: 122936 RVA: 0x00999248 File Offset: 0x00997448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendTypeCount(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Text friendTypeCount;
			LuaObject.checkType<Text>(l, 2, out friendTypeCount);
			friendUIController.m_luaExportHelper.m_friendTypeCount = friendTypeCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E039 RID: 122937 RVA: 0x009992A4 File Offset: 0x009974A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_panelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_panelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E03A RID: 122938 RVA: 0x009992FC File Offset: 0x009974FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_panelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			CommonUIStateController panelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out panelUIStateController);
			friendUIController.m_luaExportHelper.m_panelUIStateController = panelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E03B RID: 122939 RVA: 0x00999358 File Offset: 0x00997558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendShipPointTipStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_friendShipPointTipStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E03C RID: 122940 RVA: 0x009993B0 File Offset: 0x009975B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendShipPointTipStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			CommonUIStateController friendShipPointTipStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out friendShipPointTipStateCtrl);
			friendUIController.m_luaExportHelper.m_friendShipPointTipStateCtrl = friendShipPointTipStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E03D RID: 122941 RVA: 0x0099940C File Offset: 0x0099760C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendShipPointTipText(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_friendShipPointTipText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E03E RID: 122942 RVA: 0x00999464 File Offset: 0x00997664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendShipPointTipText(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Text friendShipPointTipText;
			LuaObject.checkType<Text>(l, 2, out friendShipPointTipText);
			friendUIController.m_luaExportHelper.m_friendShipPointTipText = friendShipPointTipText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E03F RID: 122943 RVA: 0x009994C0 File Offset: 0x009976C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getAllFriendshipPointButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_getAllFriendshipPointButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E040 RID: 122944 RVA: 0x00999518 File Offset: 0x00997718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getAllFriendshipPointButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button getAllFriendshipPointButton;
			LuaObject.checkType<Button>(l, 2, out getAllFriendshipPointButton);
			friendUIController.m_luaExportHelper.m_getAllFriendshipPointButton = getAllFriendshipPointButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E041 RID: 122945 RVA: 0x00999574 File Offset: 0x00997774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getAllFriendshipPointButtonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_getAllFriendshipPointButtonUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E042 RID: 122946 RVA: 0x009995CC File Offset: 0x009977CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getAllFriendshipPointButtonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			CommonUIStateController getAllFriendshipPointButtonUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out getAllFriendshipPointButtonUIStateCtrl);
			friendUIController.m_luaExportHelper.m_getAllFriendshipPointButtonUIStateCtrl = getAllFriendshipPointButtonUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E043 RID: 122947 RVA: 0x00999628 File Offset: 0x00997828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sendAllFriendshipPointButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_sendAllFriendshipPointButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E044 RID: 122948 RVA: 0x00999680 File Offset: 0x00997880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sendAllFriendshipPointButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button sendAllFriendshipPointButton;
			LuaObject.checkType<Button>(l, 2, out sendAllFriendshipPointButton);
			friendUIController.m_luaExportHelper.m_sendAllFriendshipPointButton = sendAllFriendshipPointButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E045 RID: 122949 RVA: 0x009996DC File Offset: 0x009978DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sendAllFriendshipPointButtonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_sendAllFriendshipPointButtonUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E046 RID: 122950 RVA: 0x00999734 File Offset: 0x00997934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sendAllFriendshipPointButtonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			CommonUIStateController sendAllFriendshipPointButtonUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out sendAllFriendshipPointButtonUIStateCtrl);
			friendUIController.m_luaExportHelper.m_sendAllFriendshipPointButtonUIStateCtrl = sendAllFriendshipPointButtonUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E047 RID: 122951 RVA: 0x00999790 File Offset: 0x00997990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_friendToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E048 RID: 122952 RVA: 0x009997E8 File Offset: 0x009979E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Toggle friendToggle;
			LuaObject.checkType<Toggle>(l, 2, out friendToggle);
			friendUIController.m_luaExportHelper.m_friendToggle = friendToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E049 RID: 122953 RVA: 0x00999844 File Offset: 0x00997A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_acrossServerToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_acrossServerToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E04A RID: 122954 RVA: 0x0099989C File Offset: 0x00997A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_acrossServerToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Toggle acrossServerToggle;
			LuaObject.checkType<Toggle>(l, 2, out acrossServerToggle);
			friendUIController.m_luaExportHelper.m_acrossServerToggle = acrossServerToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E04B RID: 122955 RVA: 0x009998F8 File Offset: 0x00997AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recentToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_recentToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E04C RID: 122956 RVA: 0x00999950 File Offset: 0x00997B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recentToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Toggle recentToggle;
			LuaObject.checkType<Toggle>(l, 2, out recentToggle);
			friendUIController.m_luaExportHelper.m_recentToggle = recentToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E04D RID: 122957 RVA: 0x009999AC File Offset: 0x00997BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_groupToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E04E RID: 122958 RVA: 0x00999A04 File Offset: 0x00997C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Toggle groupToggle;
			LuaObject.checkType<Toggle>(l, 2, out groupToggle);
			friendUIController.m_luaExportHelper.m_groupToggle = groupToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E04F RID: 122959 RVA: 0x00999A60 File Offset: 0x00997C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E050 RID: 122960 RVA: 0x00999AB8 File Offset: 0x00997CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			CommonUIStateController addFriendPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out addFriendPanelUIStateController);
			friendUIController.m_luaExportHelper.m_addFriendPanelUIStateController = addFriendPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E051 RID: 122961 RVA: 0x00999B14 File Offset: 0x00997D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E052 RID: 122962 RVA: 0x00999B6C File Offset: 0x00997D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button addFriendPanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out addFriendPanelCloseButton);
			friendUIController.m_luaExportHelper.m_addFriendPanelCloseButton = addFriendPanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E053 RID: 122963 RVA: 0x00999BC8 File Offset: 0x00997DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E054 RID: 122964 RVA: 0x00999C20 File Offset: 0x00997E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button addFriendPanelBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out addFriendPanelBackgroundButton);
			friendUIController.m_luaExportHelper.m_addFriendPanelBackgroundButton = addFriendPanelBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E055 RID: 122965 RVA: 0x00999C7C File Offset: 0x00997E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelSelectServerButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelSelectServerButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E056 RID: 122966 RVA: 0x00999CD4 File Offset: 0x00997ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelSelectServerButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button addFriendPanelSelectServerButton;
			LuaObject.checkType<Button>(l, 2, out addFriendPanelSelectServerButton);
			friendUIController.m_luaExportHelper.m_addFriendPanelSelectServerButton = addFriendPanelSelectServerButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E057 RID: 122967 RVA: 0x00999D30 File Offset: 0x00997F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelServerNameText(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelServerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E058 RID: 122968 RVA: 0x00999D88 File Offset: 0x00997F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelServerNameText(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Text addFriendPanelServerNameText;
			LuaObject.checkType<Text>(l, 2, out addFriendPanelServerNameText);
			friendUIController.m_luaExportHelper.m_addFriendPanelServerNameText = addFriendPanelServerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E059 RID: 122969 RVA: 0x00999DE4 File Offset: 0x00997FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelSearchButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelSearchButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E05A RID: 122970 RVA: 0x00999E3C File Offset: 0x0099803C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelSearchButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button addFriendPanelSearchButton;
			LuaObject.checkType<Button>(l, 2, out addFriendPanelSearchButton);
			friendUIController.m_luaExportHelper.m_addFriendPanelSearchButton = addFriendPanelSearchButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E05B RID: 122971 RVA: 0x00999E98 File Offset: 0x00998098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelInputText(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelInputText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E05C RID: 122972 RVA: 0x00999EF0 File Offset: 0x009980F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelInputText(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			InputField addFriendPanelInputText;
			LuaObject.checkType<InputField>(l, 2, out addFriendPanelInputText);
			friendUIController.m_luaExportHelper.m_addFriendPanelInputText = addFriendPanelInputText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E05D RID: 122973 RVA: 0x00999F4C File Offset: 0x0099814C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelChangeButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelChangeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E05E RID: 122974 RVA: 0x00999FA4 File Offset: 0x009981A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelChangeButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button addFriendPanelChangeButton;
			LuaObject.checkType<Button>(l, 2, out addFriendPanelChangeButton);
			friendUIController.m_luaExportHelper.m_addFriendPanelChangeButton = addFriendPanelChangeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E05F RID: 122975 RVA: 0x0099A000 File Offset: 0x00998200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelRefuseAllButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelRefuseAllButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E060 RID: 122976 RVA: 0x0099A058 File Offset: 0x00998258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelRefuseAllButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button addFriendPanelRefuseAllButton;
			LuaObject.checkType<Button>(l, 2, out addFriendPanelRefuseAllButton);
			friendUIController.m_luaExportHelper.m_addFriendPanelRefuseAllButton = addFriendPanelRefuseAllButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E061 RID: 122977 RVA: 0x0099A0B4 File Offset: 0x009982B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelRecommendScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelRecommendScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E062 RID: 122978 RVA: 0x0099A10C File Offset: 0x0099830C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelRecommendScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject addFriendPanelRecommendScrollView;
			LuaObject.checkType<GameObject>(l, 2, out addFriendPanelRecommendScrollView);
			friendUIController.m_luaExportHelper.m_addFriendPanelRecommendScrollView = addFriendPanelRecommendScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E063 RID: 122979 RVA: 0x0099A168 File Offset: 0x00998368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelRecommendScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelRecommendScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E064 RID: 122980 RVA: 0x0099A1C0 File Offset: 0x009983C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelRecommendScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject addFriendPanelRecommendScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out addFriendPanelRecommendScrollViewContent);
			friendUIController.m_luaExportHelper.m_addFriendPanelRecommendScrollViewContent = addFriendPanelRecommendScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E065 RID: 122981 RVA: 0x0099A21C File Offset: 0x0099841C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelApplyScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelApplyScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E066 RID: 122982 RVA: 0x0099A274 File Offset: 0x00998474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelApplyScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject addFriendPanelApplyScrollView;
			LuaObject.checkType<GameObject>(l, 2, out addFriendPanelApplyScrollView);
			friendUIController.m_luaExportHelper.m_addFriendPanelApplyScrollView = addFriendPanelApplyScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E067 RID: 122983 RVA: 0x0099A2D0 File Offset: 0x009984D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelApplyScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelApplyScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E068 RID: 122984 RVA: 0x0099A328 File Offset: 0x00998528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelApplyScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject addFriendPanelApplyScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out addFriendPanelApplyScrollViewContent);
			friendUIController.m_luaExportHelper.m_addFriendPanelApplyScrollViewContent = addFriendPanelApplyScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E069 RID: 122985 RVA: 0x0099A384 File Offset: 0x00998584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelRecommendTextGameObject(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelRecommendTextGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E06A RID: 122986 RVA: 0x0099A3DC File Offset: 0x009985DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelRecommendTextGameObject(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject addFriendPanelRecommendTextGameObject;
			LuaObject.checkType<GameObject>(l, 2, out addFriendPanelRecommendTextGameObject);
			friendUIController.m_luaExportHelper.m_addFriendPanelRecommendTextGameObject = addFriendPanelRecommendTextGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E06B RID: 122987 RVA: 0x0099A438 File Offset: 0x00998638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelFindFriendTextGameObject(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelFindFriendTextGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E06C RID: 122988 RVA: 0x0099A490 File Offset: 0x00998690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelFindFriendTextGameObject(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject addFriendPanelFindFriendTextGameObject;
			LuaObject.checkType<GameObject>(l, 2, out addFriendPanelFindFriendTextGameObject);
			friendUIController.m_luaExportHelper.m_addFriendPanelFindFriendTextGameObject = addFriendPanelFindFriendTextGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E06D RID: 122989 RVA: 0x0099A4EC File Offset: 0x009986EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addFriendPanelNotFindFriendGameObject(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_addFriendPanelNotFindFriendGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E06E RID: 122990 RVA: 0x0099A544 File Offset: 0x00998744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addFriendPanelNotFindFriendGameObject(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject addFriendPanelNotFindFriendGameObject;
			LuaObject.checkType<GameObject>(l, 2, out addFriendPanelNotFindFriendGameObject);
			friendUIController.m_luaExportHelper.m_addFriendPanelNotFindFriendGameObject = addFriendPanelNotFindFriendGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E06F RID: 122991 RVA: 0x0099A5A0 File Offset: 0x009987A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverListPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_serverListPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E070 RID: 122992 RVA: 0x0099A5F8 File Offset: 0x009987F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverListPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			CommonUIStateController serverListPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out serverListPanelUIStateController);
			friendUIController.m_luaExportHelper.m_serverListPanelUIStateController = serverListPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E071 RID: 122993 RVA: 0x0099A654 File Offset: 0x00998854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverItemGameObject(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_serverItemGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E072 RID: 122994 RVA: 0x0099A6AC File Offset: 0x009988AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverItemGameObject(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject serverItemGameObject;
			LuaObject.checkType<GameObject>(l, 2, out serverItemGameObject);
			friendUIController.m_luaExportHelper.m_serverItemGameObject = serverItemGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E073 RID: 122995 RVA: 0x0099A708 File Offset: 0x00998908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverItemName(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_serverItemName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E074 RID: 122996 RVA: 0x0099A760 File Offset: 0x00998960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverItemName(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Text serverItemName;
			LuaObject.checkType<Text>(l, 2, out serverItemName);
			friendUIController.m_luaExportHelper.m_serverItemName = serverItemName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E075 RID: 122997 RVA: 0x0099A7BC File Offset: 0x009989BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverListGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_serverListGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E076 RID: 122998 RVA: 0x0099A814 File Offset: 0x00998A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverListGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject serverListGroup;
			LuaObject.checkType<GameObject>(l, 2, out serverListGroup);
			friendUIController.m_luaExportHelper.m_serverListGroup = serverListGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E077 RID: 122999 RVA: 0x0099A870 File Offset: 0x00998A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverListPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_serverListPanelBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E078 RID: 123000 RVA: 0x0099A8C8 File Offset: 0x00998AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverListPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button serverListPanelBGButton;
			LuaObject.checkType<Button>(l, 2, out serverListPanelBGButton);
			friendUIController.m_luaExportHelper.m_serverListPanelBGButton = serverListPanelBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E079 RID: 123001 RVA: 0x0099A924 File Offset: 0x00998B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_watchGroupStaffPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_watchGroupStaffPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E07A RID: 123002 RVA: 0x0099A97C File Offset: 0x00998B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_watchGroupStaffPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			CommonUIStateController watchGroupStaffPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out watchGroupStaffPanelUIStateController);
			friendUIController.m_luaExportHelper.m_watchGroupStaffPanelUIStateController = watchGroupStaffPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E07B RID: 123003 RVA: 0x0099A9D8 File Offset: 0x00998BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_watchGroupStaffPanelBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_watchGroupStaffPanelBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E07C RID: 123004 RVA: 0x0099AA30 File Offset: 0x00998C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_watchGroupStaffPanelBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button watchGroupStaffPanelBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out watchGroupStaffPanelBackgroundButton);
			friendUIController.m_luaExportHelper.m_watchGroupStaffPanelBackgroundButton = watchGroupStaffPanelBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E07D RID: 123005 RVA: 0x0099AA8C File Offset: 0x00998C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_watchGroupStaffPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_watchGroupStaffPanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E07E RID: 123006 RVA: 0x0099AAE4 File Offset: 0x00998CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_watchGroupStaffPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button watchGroupStaffPanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out watchGroupStaffPanelCloseButton);
			friendUIController.m_luaExportHelper.m_watchGroupStaffPanelCloseButton = watchGroupStaffPanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E07F RID: 123007 RVA: 0x0099AB40 File Offset: 0x00998D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_watchGroupStaffPanelChangeGroupNameButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_watchGroupStaffPanelChangeGroupNameButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E080 RID: 123008 RVA: 0x0099AB98 File Offset: 0x00998D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_watchGroupStaffPanelChangeGroupNameButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button watchGroupStaffPanelChangeGroupNameButton;
			LuaObject.checkType<Button>(l, 2, out watchGroupStaffPanelChangeGroupNameButton);
			friendUIController.m_luaExportHelper.m_watchGroupStaffPanelChangeGroupNameButton = watchGroupStaffPanelChangeGroupNameButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E081 RID: 123009 RVA: 0x0099ABF4 File Offset: 0x00998DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_watchGroupStaffPanelQuitGroupButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_watchGroupStaffPanelQuitGroupButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E082 RID: 123010 RVA: 0x0099AC4C File Offset: 0x00998E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_watchGroupStaffPanelQuitGroupButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button watchGroupStaffPanelQuitGroupButton;
			LuaObject.checkType<Button>(l, 2, out watchGroupStaffPanelQuitGroupButton);
			friendUIController.m_luaExportHelper.m_watchGroupStaffPanelQuitGroupButton = watchGroupStaffPanelQuitGroupButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E083 RID: 123011 RVA: 0x0099ACA8 File Offset: 0x00998EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_watchGroupStaffPanelInviteFriendButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_watchGroupStaffPanelInviteFriendButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E084 RID: 123012 RVA: 0x0099AD00 File Offset: 0x00998F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_watchGroupStaffPanelInviteFriendButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button watchGroupStaffPanelInviteFriendButton;
			LuaObject.checkType<Button>(l, 2, out watchGroupStaffPanelInviteFriendButton);
			friendUIController.m_luaExportHelper.m_watchGroupStaffPanelInviteFriendButton = watchGroupStaffPanelInviteFriendButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E085 RID: 123013 RVA: 0x0099AD5C File Offset: 0x00998F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_watchGroupStaffPanelScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_watchGroupStaffPanelScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E086 RID: 123014 RVA: 0x0099ADB4 File Offset: 0x00998FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_watchGroupStaffPanelScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject watchGroupStaffPanelScrollView;
			LuaObject.checkType<GameObject>(l, 2, out watchGroupStaffPanelScrollView);
			friendUIController.m_luaExportHelper.m_watchGroupStaffPanelScrollView = watchGroupStaffPanelScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E087 RID: 123015 RVA: 0x0099AE10 File Offset: 0x00999010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_watchGroupStaffPanelScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_watchGroupStaffPanelScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E088 RID: 123016 RVA: 0x0099AE68 File Offset: 0x00999068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_watchGroupStaffPanelScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject watchGroupStaffPanelScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out watchGroupStaffPanelScrollViewContent);
			friendUIController.m_luaExportHelper.m_watchGroupStaffPanelScrollViewContent = watchGroupStaffPanelScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E089 RID: 123017 RVA: 0x0099AEC4 File Offset: 0x009990C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_watchGroupStaffPanelCountText(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_watchGroupStaffPanelCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E08A RID: 123018 RVA: 0x0099AF1C File Offset: 0x0099911C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_watchGroupStaffPanelCountText(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Text watchGroupStaffPanelCountText;
			LuaObject.checkType<Text>(l, 2, out watchGroupStaffPanelCountText);
			friendUIController.m_luaExportHelper.m_watchGroupStaffPanelCountText = watchGroupStaffPanelCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E08B RID: 123019 RVA: 0x0099AF78 File Offset: 0x00999178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupTitleName(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_groupTitleName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E08C RID: 123020 RVA: 0x0099AFD0 File Offset: 0x009991D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupTitleName(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Text groupTitleName;
			LuaObject.checkType<Text>(l, 2, out groupTitleName);
			friendUIController.m_luaExportHelper.m_groupTitleName = groupTitleName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E08D RID: 123021 RVA: 0x0099B02C File Offset: 0x0099922C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeGroupNameUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_changeGroupNameUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E08E RID: 123022 RVA: 0x0099B084 File Offset: 0x00999284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeGroupNameUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			CommonUIStateController changeGroupNameUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out changeGroupNameUIStateController);
			friendUIController.m_luaExportHelper.m_changeGroupNameUIStateController = changeGroupNameUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E08F RID: 123023 RVA: 0x0099B0E0 File Offset: 0x009992E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeGroupNameBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_changeGroupNameBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E090 RID: 123024 RVA: 0x0099B138 File Offset: 0x00999338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeGroupNameBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button changeGroupNameBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out changeGroupNameBackgroundButton);
			friendUIController.m_luaExportHelper.m_changeGroupNameBackgroundButton = changeGroupNameBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E091 RID: 123025 RVA: 0x0099B194 File Offset: 0x00999394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeGroupNameConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_changeGroupNameConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E092 RID: 123026 RVA: 0x0099B1EC File Offset: 0x009993EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeGroupNameConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button changeGroupNameConfirmButton;
			LuaObject.checkType<Button>(l, 2, out changeGroupNameConfirmButton);
			friendUIController.m_luaExportHelper.m_changeGroupNameConfirmButton = changeGroupNameConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E093 RID: 123027 RVA: 0x0099B248 File Offset: 0x00999448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeNamePanelInputField(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_changeNamePanelInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E094 RID: 123028 RVA: 0x0099B2A0 File Offset: 0x009994A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeNamePanelInputField(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			InputField changeNamePanelInputField;
			LuaObject.checkType<InputField>(l, 2, out changeNamePanelInputField);
			friendUIController.m_luaExportHelper.m_changeNamePanelInputField = changeNamePanelInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E095 RID: 123029 RVA: 0x0099B2FC File Offset: 0x009994FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteFriendToGroupPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E096 RID: 123030 RVA: 0x0099B354 File Offset: 0x00999554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteFriendToGroupPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			CommonUIStateController inviteFriendToGroupPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out inviteFriendToGroupPanelUIStateController);
			friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelUIStateController = inviteFriendToGroupPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E097 RID: 123031 RVA: 0x0099B3B0 File Offset: 0x009995B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteFriendToGroupPanelScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E098 RID: 123032 RVA: 0x0099B408 File Offset: 0x00999608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteFriendToGroupPanelScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject inviteFriendToGroupPanelScrollView;
			LuaObject.checkType<GameObject>(l, 2, out inviteFriendToGroupPanelScrollView);
			friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelScrollView = inviteFriendToGroupPanelScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E099 RID: 123033 RVA: 0x0099B464 File Offset: 0x00999664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteFriendToGroupPanelScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E09A RID: 123034 RVA: 0x0099B4BC File Offset: 0x009996BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteFriendToGroupPanelScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject inviteFriendToGroupPanelScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out inviteFriendToGroupPanelScrollViewContent);
			friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelScrollViewContent = inviteFriendToGroupPanelScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E09B RID: 123035 RVA: 0x0099B518 File Offset: 0x00999718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteFriendToGroupPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E09C RID: 123036 RVA: 0x0099B570 File Offset: 0x00999770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteFriendToGroupPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button inviteFriendToGroupPanelConfirmButton;
			LuaObject.checkType<Button>(l, 2, out inviteFriendToGroupPanelConfirmButton);
			friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelConfirmButton = inviteFriendToGroupPanelConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E09D RID: 123037 RVA: 0x0099B5CC File Offset: 0x009997CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteFriendToGroupPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E09E RID: 123038 RVA: 0x0099B624 File Offset: 0x00999824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteFriendToGroupPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button inviteFriendToGroupPanelCancelButton;
			LuaObject.checkType<Button>(l, 2, out inviteFriendToGroupPanelCancelButton);
			friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelCancelButton = inviteFriendToGroupPanelCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E09F RID: 123039 RVA: 0x0099B680 File Offset: 0x00999880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteFriendToGroupPanelBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0A0 RID: 123040 RVA: 0x0099B6D8 File Offset: 0x009998D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteFriendToGroupPanelBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button inviteFriendToGroupPanelBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out inviteFriendToGroupPanelBackgroundButton);
			friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelBackgroundButton = inviteFriendToGroupPanelBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0A1 RID: 123041 RVA: 0x0099B734 File Offset: 0x00999934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteFriendToGroupPanelCountText(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0A2 RID: 123042 RVA: 0x0099B78C File Offset: 0x0099998C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteFriendToGroupPanelCountText(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Text inviteFriendToGroupPanelCountText;
			LuaObject.checkType<Text>(l, 2, out inviteFriendToGroupPanelCountText);
			friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelCountText = inviteFriendToGroupPanelCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0A3 RID: 123043 RVA: 0x0099B7E8 File Offset: 0x009999E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteFriendToGroupPanelServerFriendToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelServerFriendToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0A4 RID: 123044 RVA: 0x0099B840 File Offset: 0x00999A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteFriendToGroupPanelServerFriendToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Toggle inviteFriendToGroupPanelServerFriendToggle;
			LuaObject.checkType<Toggle>(l, 2, out inviteFriendToGroupPanelServerFriendToggle);
			friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelServerFriendToggle = inviteFriendToGroupPanelServerFriendToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0A5 RID: 123045 RVA: 0x0099B89C File Offset: 0x00999A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteFriendToGroupPanelFriendToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelFriendToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0A6 RID: 123046 RVA: 0x0099B8F4 File Offset: 0x00999AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteFriendToGroupPanelFriendToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Toggle inviteFriendToGroupPanelFriendToggle;
			LuaObject.checkType<Toggle>(l, 2, out inviteFriendToGroupPanelFriendToggle);
			friendUIController.m_luaExportHelper.m_inviteFriendToGroupPanelFriendToggle = inviteFriendToGroupPanelFriendToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0A7 RID: 123047 RVA: 0x0099B950 File Offset: 0x00999B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shieldPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_shieldPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0A8 RID: 123048 RVA: 0x0099B9A8 File Offset: 0x00999BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shieldPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			CommonUIStateController shieldPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out shieldPanelUIStateController);
			friendUIController.m_luaExportHelper.m_shieldPanelUIStateController = shieldPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0A9 RID: 123049 RVA: 0x0099BA04 File Offset: 0x00999C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shieldPanelScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_shieldPanelScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0AA RID: 123050 RVA: 0x0099BA5C File Offset: 0x00999C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shieldPanelScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject shieldPanelScrollView;
			LuaObject.checkType<GameObject>(l, 2, out shieldPanelScrollView);
			friendUIController.m_luaExportHelper.m_shieldPanelScrollView = shieldPanelScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0AB RID: 123051 RVA: 0x0099BAB8 File Offset: 0x00999CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shieldPanelScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_shieldPanelScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0AC RID: 123052 RVA: 0x0099BB10 File Offset: 0x00999D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shieldPanelScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject shieldPanelScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out shieldPanelScrollViewContent);
			friendUIController.m_luaExportHelper.m_shieldPanelScrollViewContent = shieldPanelScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0AD RID: 123053 RVA: 0x0099BB6C File Offset: 0x00999D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shieldPanelBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_shieldPanelBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0AE RID: 123054 RVA: 0x0099BBC4 File Offset: 0x00999DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shieldPanelBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button shieldPanelBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out shieldPanelBackgroundButton);
			friendUIController.m_luaExportHelper.m_shieldPanelBackgroundButton = shieldPanelBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0AF RID: 123055 RVA: 0x0099BC20 File Offset: 0x00999E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shieldPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_shieldPanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0B0 RID: 123056 RVA: 0x0099BC78 File Offset: 0x00999E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shieldPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Button shieldPanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out shieldPanelCloseButton);
			friendUIController.m_luaExportHelper.m_shieldPanelCloseButton = shieldPanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0B1 RID: 123057 RVA: 0x0099BCD4 File Offset: 0x00999ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shieldPanelShieldCount(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_shieldPanelShieldCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0B2 RID: 123058 RVA: 0x0099BD2C File Offset: 0x00999F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shieldPanelShieldCount(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			Text shieldPanelShieldCount;
			LuaObject.checkType<Text>(l, 2, out shieldPanelShieldCount);
			friendUIController.m_luaExportHelper.m_shieldPanelShieldCount = shieldPanelShieldCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0B3 RID: 123059 RVA: 0x0099BD88 File Offset: 0x00999F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_friendScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0B4 RID: 123060 RVA: 0x0099BDE0 File Offset: 0x00999FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject friendScrollView;
			LuaObject.checkType<GameObject>(l, 2, out friendScrollView);
			friendUIController.m_luaExportHelper.m_friendScrollView = friendScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0B5 RID: 123061 RVA: 0x0099BE3C File Offset: 0x0099A03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_friendScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0B6 RID: 123062 RVA: 0x0099BE94 File Offset: 0x0099A094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject friendScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out friendScrollViewContent);
			friendUIController.m_luaExportHelper.m_friendScrollViewContent = friendScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0B7 RID: 123063 RVA: 0x0099BEF0 File Offset: 0x0099A0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_groupScrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0B8 RID: 123064 RVA: 0x0099BF48 File Offset: 0x0099A148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupScrollView(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject groupScrollView;
			LuaObject.checkType<GameObject>(l, 2, out groupScrollView);
			friendUIController.m_luaExportHelper.m_groupScrollView = groupScrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0B9 RID: 123065 RVA: 0x0099BFA4 File Offset: 0x0099A1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_groupScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0BA RID: 123066 RVA: 0x0099BFFC File Offset: 0x0099A1FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject groupScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out groupScrollViewContent);
			friendUIController.m_luaExportHelper.m_groupScrollViewContent = groupScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0BB RID: 123067 RVA: 0x0099C058 File Offset: 0x0099A258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendBigItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_friendBigItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0BC RID: 123068 RVA: 0x0099C0B0 File Offset: 0x0099A2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendBigItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject friendBigItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out friendBigItemPrefab);
			friendUIController.m_luaExportHelper.m_friendBigItemPrefab = friendBigItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0BD RID: 123069 RVA: 0x0099C10C File Offset: 0x0099A30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendSmallItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_friendSmallItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0BE RID: 123070 RVA: 0x0099C164 File Offset: 0x0099A364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendSmallItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject friendSmallItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out friendSmallItemPrefab);
			friendUIController.m_luaExportHelper.m_friendSmallItemPrefab = friendSmallItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0BF RID: 123071 RVA: 0x0099C1C0 File Offset: 0x0099A3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_groupItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0C0 RID: 123072 RVA: 0x0099C218 File Offset: 0x0099A418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			GameObject groupItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out groupItemPrefab);
			friendUIController.m_luaExportHelper.m_groupItemPrefab = groupItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0C1 RID: 123073 RVA: 0x0099C274 File Offset: 0x0099A474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentServerID(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_currentServerID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0C2 RID: 123074 RVA: 0x0099C2CC File Offset: 0x0099A4CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentServerID(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			int currentServerID;
			LuaObject.checkType(l, 2, out currentServerID);
			friendUIController.m_luaExportHelper.m_currentServerID = currentServerID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0C3 RID: 123075 RVA: 0x0099C328 File Offset: 0x0099A528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentChatGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_currentChatGroupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0C4 RID: 123076 RVA: 0x0099C380 File Offset: 0x0099A580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentChatGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			ProChatGroupInfo currentChatGroupInfo;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out currentChatGroupInfo);
			friendUIController.m_luaExportHelper.m_currentChatGroupInfo = currentChatGroupInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0C5 RID: 123077 RVA: 0x0099C3DC File Offset: 0x0099A5DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isCreateNewGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_isCreateNewGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0C6 RID: 123078 RVA: 0x0099C434 File Offset: 0x0099A634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isCreateNewGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			bool isCreateNewGroup;
			LuaObject.checkType(l, 2, out isCreateNewGroup);
			friendUIController.m_luaExportHelper.m_isCreateNewGroup = isCreateNewGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0C7 RID: 123079 RVA: 0x0099C490 File Offset: 0x0099A690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_maxInviteToGroupCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, FriendUIController.LuaExportHelper.m_maxInviteToGroupCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0C8 RID: 123080 RVA: 0x0099C4D8 File Offset: 0x0099A6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFindFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_isFindFriend);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0C9 RID: 123081 RVA: 0x0099C52C File Offset: 0x0099A72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFindFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			bool isFindFriend;
			LuaObject.checkType(l, 2, out isFindFriend);
			friendUIController.m_isFindFriend = isFindFriend;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0CA RID: 123082 RVA: 0x0099C584 File Offset: 0x0099A784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isRecommendFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_isRecommendFriend);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0CB RID: 123083 RVA: 0x0099C5D8 File Offset: 0x0099A7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isRecommendFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			bool isRecommendFriend;
			LuaObject.checkType(l, 2, out isRecommendFriend);
			friendUIController.m_isRecommendFriend = isRecommendFriend;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0CC RID: 123084 RVA: 0x0099C630 File Offset: 0x0099A830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recommendFriendList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_recommendFriendList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0CD RID: 123085 RVA: 0x0099C688 File Offset: 0x0099A888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recommendFriendList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<UserSummary> recommendFriendList;
			LuaObject.checkType<List<UserSummary>>(l, 2, out recommendFriendList);
			friendUIController.m_luaExportHelper.m_recommendFriendList = recommendFriendList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0CE RID: 123086 RVA: 0x0099C6E4 File Offset: 0x0099A8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_applyFriendList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_applyFriendList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0CF RID: 123087 RVA: 0x0099C73C File Offset: 0x0099A93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_applyFriendList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<UserSummary> applyFriendList;
			LuaObject.checkType<List<UserSummary>>(l, 2, out applyFriendList);
			friendUIController.m_luaExportHelper.m_applyFriendList = applyFriendList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0D0 RID: 123088 RVA: 0x0099C798 File Offset: 0x0099A998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inviteToGroupList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_inviteToGroupList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0D1 RID: 123089 RVA: 0x0099C7F0 File Offset: 0x0099A9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inviteToGroupList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<string> inviteToGroupList;
			LuaObject.checkType<List<string>>(l, 2, out inviteToGroupList);
			friendUIController.m_luaExportHelper.m_inviteToGroupList = inviteToGroupList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0D2 RID: 123090 RVA: 0x0099C84C File Offset: 0x0099AA4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupStaffList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_groupStaffList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0D3 RID: 123091 RVA: 0x0099C8A4 File Offset: 0x0099AAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupStaffList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<UserSummary> groupStaffList;
			LuaObject.checkType<List<UserSummary>>(l, 2, out groupStaffList);
			friendUIController.m_luaExportHelper.m_groupStaffList = groupStaffList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0D4 RID: 123092 RVA: 0x0099C900 File Offset: 0x0099AB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendApplyAcceptList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_friendApplyAcceptList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0D5 RID: 123093 RVA: 0x0099C958 File Offset: 0x0099AB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendApplyAcceptList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<string> friendApplyAcceptList;
			LuaObject.checkType<List<string>>(l, 2, out friendApplyAcceptList);
			friendUIController.m_luaExportHelper.m_friendApplyAcceptList = friendApplyAcceptList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0D6 RID: 123094 RVA: 0x0099C9B4 File Offset: 0x0099ABB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendApplyDeclineList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_friendApplyDeclineList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0D7 RID: 123095 RVA: 0x0099CA0C File Offset: 0x0099AC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendApplyDeclineList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<string> friendApplyDeclineList;
			LuaObject.checkType<List<string>>(l, 2, out friendApplyDeclineList);
			friendUIController.m_luaExportHelper.m_friendApplyDeclineList = friendApplyDeclineList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0D8 RID: 123096 RVA: 0x0099CA68 File Offset: 0x0099AC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendAddList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_friendAddList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0D9 RID: 123097 RVA: 0x0099CAC0 File Offset: 0x0099ACC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendAddList(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			List<string> friendAddList;
			LuaObject.checkType<List<string>>(l, 2, out friendAddList);
			friendUIController.m_luaExportHelper.m_friendAddList = friendAddList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0DA RID: 123098 RVA: 0x0099CB1C File Offset: 0x0099AD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0DB RID: 123099 RVA: 0x0099CB74 File Offset: 0x0099AD74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			friendUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0DC RID: 123100 RVA: 0x0099CBD0 File Offset: 0x0099ADD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0DD RID: 123101 RVA: 0x0099CC28 File Offset: 0x0099AE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FriendUIController friendUIController = (FriendUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			friendUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E0DE RID: 123102 RVA: 0x0099CC84 File Offset: 0x0099AE84
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendUIController");
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetFriendPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetAcrossServerFriendPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetRecentPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetGroupPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetFirstToggleOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetPanelScrollViewReset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.IsAddFriendRedMarkShow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.ShowFriendShipPointTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetShieldPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetFindFriendList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetRecommendFriendsList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetApplyFriendsList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetInviteFriendToGroupPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetWatchGroupStaffPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.WatchGroupStaffPanelClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.GroupDissolved);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnWatchGroupStaffPanelChangeNamePanelBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.InviteFriendToGoupPanelClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetAddFriendPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetInviteFriendToGroupList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetInviteAcrossServerFriendToGroupList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetBasicBigFriendInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetBasicSmallFriendInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetServerListInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnFriendToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnAcrossServerToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnRecentToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnGroupToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnShieldButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnShieldPanelCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnSendAllFriendshipPointButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnGetAllFriendshipPointButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnAddFriendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnAddFriendPanelCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnSelectServerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnServerListPanelBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetSendAllFriendshipPointButtonState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.SetGetAllFriendshipPointButtonState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnAddFriendPanelSearchButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnAddFriendPanelChangeRecommendFriendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnAddFriendPanelAddAllButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnAddFriendPanelAcceptAllButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnAddFriendPanelRefuseAllButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnWatchGroupStaffPanelCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnWatchGroupStaffPanelChangeNameButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnWatchGroupStaffPanelChangeNameConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnQuitGroupButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnCreateNewGroupButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnInviteFriendToGroupButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnInviteFriendToGoupPanelConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnInviteFriendToGroupPanelServerFriendToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnInviteFriendToGroupPanelFriendToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnPlayerItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnItemAddFriendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnItemKickFromGroupButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnUnblockPlayerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnSendFriendshipPointButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnGetFriendshipPointButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnFriendshipPointDoneButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnFriendApplyAceeptButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnFriendApplyDeclineButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnInviteFriendToGroupToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnGroupChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.OnWatchGroupStaffButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnShowPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnShowPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnAddFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnAddFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnKickFromGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnKickFromGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnUnblockPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnUnblockPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnSendFriendshipPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnSendFriendshipPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnGetFriendshipPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnGetFriendshipPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnFindFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnFindFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnSendAllFriendshipPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnSendAllFriendshipPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnGetAllFriendshipPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnGetAllFriendshipPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnGetRecommendFriendsList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnGetRecommendFriendsList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnFriendApplyAceept);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnFriendApplyAceept);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnFriendApplyDecline);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnFriendApplyDecline);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnShowPlayerSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnShowPlayerSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnGroupChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnGroupChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnWatchGroupStaff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnWatchGroupStaff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnCreateNewGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnCreateNewGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnInviteFriendToGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnInviteFriendToGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnChangeGroupName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnChangeGroupName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__callDele_EventOnLeaveGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.__clearDele_EventOnLeaveGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7C);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7D, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7E, true);
		string name3 = "EventOnShowPanel";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnShowPanel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache7F, true);
		string name4 = "EventOnAddFriend";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnAddFriend);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache80, true);
		string name5 = "EventOnKickFromGroup";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnKickFromGroup);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache81, true);
		string name6 = "EventOnUnblockPlayer";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnUnblockPlayer);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache82, true);
		string name7 = "EventOnChat";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnChat);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache83, true);
		string name8 = "EventOnSendFriendshipPoint";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnSendFriendshipPoint);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache84, true);
		string name9 = "EventOnGetFriendshipPoint";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnGetFriendshipPoint);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache85, true);
		string name10 = "EventOnFindFriend";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnFindFriend);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache86, true);
		string name11 = "EventOnSendAllFriendshipPoint";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnSendAllFriendshipPoint);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache87, true);
		string name12 = "EventOnGetAllFriendshipPoint";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnGetAllFriendshipPoint);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache88, true);
		string name13 = "EventOnGetRecommendFriendsList";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnGetRecommendFriendsList);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache89, true);
		string name14 = "EventOnFriendApplyAceept";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnFriendApplyAceept);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8A, true);
		string name15 = "EventOnFriendApplyDecline";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnFriendApplyDecline);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8B, true);
		string name16 = "EventOnShowPlayerSimpleInfo";
		LuaCSFunction get16 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnShowPlayerSimpleInfo);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8C, true);
		string name17 = "EventOnGroupChat";
		LuaCSFunction get17 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnGroupChat);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8D, true);
		string name18 = "EventOnWatchGroupStaff";
		LuaCSFunction get18 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnWatchGroupStaff);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8E, true);
		string name19 = "EventOnCreateNewGroup";
		LuaCSFunction get19 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnCreateNewGroup);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache8F, true);
		string name20 = "EventOnInviteFriendToGroup";
		LuaCSFunction get20 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnInviteFriendToGroup);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache90, true);
		string name21 = "EventOnChangeGroupName";
		LuaCSFunction get21 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnChangeGroupName);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache91, true);
		string name22 = "EventOnLeaveGroup";
		LuaCSFunction get22 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_EventOnLeaveGroup);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache92, true);
		string name23 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_marginTransform);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache94, true);
		string name24 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_returnButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache96, true);
		string name25 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_helpButton);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache98, true);
		string name26 = "m_shieldButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_shieldButton);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_shieldButton);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9A, true);
		string name27 = "m_addFriendButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendButton);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendButton);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9C, true);
		string name28 = "m_addFriendRedMark";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendRedMark);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendRedMark);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9E, true);
		string name29 = "m_createNewGroupButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_createNewGroupButton);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache9F;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_createNewGroupButton);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA0, true);
		string name30 = "m_friendCountUIStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_friendCountUIStateController);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA1;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_friendCountUIStateController);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA2, true);
		string name31 = "m_friendTypeCount";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_friendTypeCount);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA3;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_friendTypeCount);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA4, true);
		string name32 = "m_panelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_panelUIStateController);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA5;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_panelUIStateController);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA6, true);
		string name33 = "m_friendShipPointTipStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_friendShipPointTipStateCtrl);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA7;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_friendShipPointTipStateCtrl);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA8, true);
		string name34 = "m_friendShipPointTipText";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_friendShipPointTipText);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheA9;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_friendShipPointTipText);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAA, true);
		string name35 = "m_getAllFriendshipPointButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_getAllFriendshipPointButton);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAB;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_getAllFriendshipPointButton);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAC, true);
		string name36 = "m_getAllFriendshipPointButtonUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_getAllFriendshipPointButtonUIStateCtrl);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAD;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_getAllFriendshipPointButtonUIStateCtrl);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAE, true);
		string name37 = "m_sendAllFriendshipPointButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_sendAllFriendshipPointButton);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheAF;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_sendAllFriendshipPointButton);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB0, true);
		string name38 = "m_sendAllFriendshipPointButtonUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_sendAllFriendshipPointButtonUIStateCtrl);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB1;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_sendAllFriendshipPointButtonUIStateCtrl);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB2, true);
		string name39 = "m_friendToggle";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_friendToggle);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB3;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_friendToggle);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB4, true);
		string name40 = "m_acrossServerToggle";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_acrossServerToggle);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB5;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_acrossServerToggle);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB6, true);
		string name41 = "m_recentToggle";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_recentToggle);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB7;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_recentToggle);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB8, true);
		string name42 = "m_groupToggle";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_groupToggle);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheB9;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_groupToggle);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBA, true);
		string name43 = "m_addFriendPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelUIStateController);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBB;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelUIStateController);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBC, true);
		string name44 = "m_addFriendPanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelCloseButton);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBD;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelCloseButton);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBE, true);
		string name45 = "m_addFriendPanelBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelBackgroundButton);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheBF;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelBackgroundButton);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC0, true);
		string name46 = "m_addFriendPanelSelectServerButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelSelectServerButton);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC1;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelSelectServerButton);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC2, true);
		string name47 = "m_addFriendPanelServerNameText";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelServerNameText);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC3;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelServerNameText);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC4, true);
		string name48 = "m_addFriendPanelSearchButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelSearchButton);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC5;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelSearchButton);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC6, true);
		string name49 = "m_addFriendPanelInputText";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelInputText);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC7;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelInputText);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC8, true);
		string name50 = "m_addFriendPanelChangeButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelChangeButton);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheC9;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelChangeButton);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCA, true);
		string name51 = "m_addFriendPanelRefuseAllButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelRefuseAllButton);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCB;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelRefuseAllButton);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCC, true);
		string name52 = "m_addFriendPanelRecommendScrollView";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelRecommendScrollView);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCD;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelRecommendScrollView);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCE, true);
		string name53 = "m_addFriendPanelRecommendScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelRecommendScrollViewContent);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheCF;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelRecommendScrollViewContent);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD0, true);
		string name54 = "m_addFriendPanelApplyScrollView";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelApplyScrollView);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD1;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelApplyScrollView);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD2, true);
		string name55 = "m_addFriendPanelApplyScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelApplyScrollViewContent);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD3;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelApplyScrollViewContent);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD4, true);
		string name56 = "m_addFriendPanelRecommendTextGameObject";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelRecommendTextGameObject);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD5;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelRecommendTextGameObject);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD6, true);
		string name57 = "m_addFriendPanelFindFriendTextGameObject";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelFindFriendTextGameObject);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD7;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelFindFriendTextGameObject);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD8, true);
		string name58 = "m_addFriendPanelNotFindFriendGameObject";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_addFriendPanelNotFindFriendGameObject);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheD9;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_addFriendPanelNotFindFriendGameObject);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDA, true);
		string name59 = "m_serverListPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_serverListPanelUIStateController);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDB;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_serverListPanelUIStateController);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDC, true);
		string name60 = "m_serverItemGameObject";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_serverItemGameObject);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDD;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_serverItemGameObject);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDE, true);
		string name61 = "m_serverItemName";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_serverItemName);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheDF;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_serverItemName);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE0, true);
		string name62 = "m_serverListGroup";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_serverListGroup);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE1;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_serverListGroup);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE2, true);
		string name63 = "m_serverListPanelBGButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_serverListPanelBGButton);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE3;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_serverListPanelBGButton);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE4, true);
		string name64 = "m_watchGroupStaffPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_watchGroupStaffPanelUIStateController);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE5;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_watchGroupStaffPanelUIStateController);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE6, true);
		string name65 = "m_watchGroupStaffPanelBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_watchGroupStaffPanelBackgroundButton);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE7;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_watchGroupStaffPanelBackgroundButton);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE8, true);
		string name66 = "m_watchGroupStaffPanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_watchGroupStaffPanelCloseButton);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheE9;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_watchGroupStaffPanelCloseButton);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEA, true);
		string name67 = "m_watchGroupStaffPanelChangeGroupNameButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_watchGroupStaffPanelChangeGroupNameButton);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEB;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_watchGroupStaffPanelChangeGroupNameButton);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEC, true);
		string name68 = "m_watchGroupStaffPanelQuitGroupButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_watchGroupStaffPanelQuitGroupButton);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheED;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_watchGroupStaffPanelQuitGroupButton);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEE, true);
		string name69 = "m_watchGroupStaffPanelInviteFriendButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_watchGroupStaffPanelInviteFriendButton);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheEF;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_watchGroupStaffPanelInviteFriendButton);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF0, true);
		string name70 = "m_watchGroupStaffPanelScrollView";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_watchGroupStaffPanelScrollView);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF1;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_watchGroupStaffPanelScrollView);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF2, true);
		string name71 = "m_watchGroupStaffPanelScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_watchGroupStaffPanelScrollViewContent);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF3;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_watchGroupStaffPanelScrollViewContent);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF4, true);
		string name72 = "m_watchGroupStaffPanelCountText";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_watchGroupStaffPanelCountText);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF5;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_watchGroupStaffPanelCountText);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF6, true);
		string name73 = "m_groupTitleName";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_groupTitleName);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF7;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_groupTitleName);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF8, true);
		string name74 = "m_changeGroupNameUIStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_changeGroupNameUIStateController);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheF9;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_changeGroupNameUIStateController);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFA, true);
		string name75 = "m_changeGroupNameBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_changeGroupNameBackgroundButton);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFB;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_changeGroupNameBackgroundButton);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFC, true);
		string name76 = "m_changeGroupNameConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_changeGroupNameConfirmButton);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFD;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_changeGroupNameConfirmButton);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFE, true);
		string name77 = "m_changeNamePanelInputField";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_changeNamePanelInputField);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cacheFF;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_changeNamePanelInputField);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache100, true);
		string name78 = "m_inviteFriendToGroupPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_inviteFriendToGroupPanelUIStateController);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache101;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_inviteFriendToGroupPanelUIStateController);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache102, true);
		string name79 = "m_inviteFriendToGroupPanelScrollView";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_inviteFriendToGroupPanelScrollView);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache103;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_inviteFriendToGroupPanelScrollView);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache104, true);
		string name80 = "m_inviteFriendToGroupPanelScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_inviteFriendToGroupPanelScrollViewContent);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache105;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_inviteFriendToGroupPanelScrollViewContent);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache106, true);
		string name81 = "m_inviteFriendToGroupPanelConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_inviteFriendToGroupPanelConfirmButton);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache107;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_inviteFriendToGroupPanelConfirmButton);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache108, true);
		string name82 = "m_inviteFriendToGroupPanelCancelButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_inviteFriendToGroupPanelCancelButton);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache109;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_inviteFriendToGroupPanelCancelButton);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10A, true);
		string name83 = "m_inviteFriendToGroupPanelBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_inviteFriendToGroupPanelBackgroundButton);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10B;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_inviteFriendToGroupPanelBackgroundButton);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10C, true);
		string name84 = "m_inviteFriendToGroupPanelCountText";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_inviteFriendToGroupPanelCountText);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10D;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_inviteFriendToGroupPanelCountText);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10E, true);
		string name85 = "m_inviteFriendToGroupPanelServerFriendToggle";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_inviteFriendToGroupPanelServerFriendToggle);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache10F;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_inviteFriendToGroupPanelServerFriendToggle);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache110, true);
		string name86 = "m_inviteFriendToGroupPanelFriendToggle";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_inviteFriendToGroupPanelFriendToggle);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache111;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_inviteFriendToGroupPanelFriendToggle);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache112, true);
		string name87 = "m_shieldPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_shieldPanelUIStateController);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache113;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_shieldPanelUIStateController);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache114, true);
		string name88 = "m_shieldPanelScrollView";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_shieldPanelScrollView);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache115;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_shieldPanelScrollView);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache116, true);
		string name89 = "m_shieldPanelScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_shieldPanelScrollViewContent);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache117;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_shieldPanelScrollViewContent);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache118, true);
		string name90 = "m_shieldPanelBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_shieldPanelBackgroundButton);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache119;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_shieldPanelBackgroundButton);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11A, true);
		string name91 = "m_shieldPanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_shieldPanelCloseButton);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11B;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_shieldPanelCloseButton);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11C, true);
		string name92 = "m_shieldPanelShieldCount";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_shieldPanelShieldCount);
		}
		LuaCSFunction get92 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11D;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_shieldPanelShieldCount);
		}
		LuaObject.addMember(l, name92, get92, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11E, true);
		string name93 = "m_friendScrollView";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_friendScrollView);
		}
		LuaCSFunction get93 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache11F;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_friendScrollView);
		}
		LuaObject.addMember(l, name93, get93, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache120, true);
		string name94 = "m_friendScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_friendScrollViewContent);
		}
		LuaCSFunction get94 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache121;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_friendScrollViewContent);
		}
		LuaObject.addMember(l, name94, get94, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache122, true);
		string name95 = "m_groupScrollView";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_groupScrollView);
		}
		LuaCSFunction get95 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache123;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_groupScrollView);
		}
		LuaObject.addMember(l, name95, get95, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache124, true);
		string name96 = "m_groupScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_groupScrollViewContent);
		}
		LuaCSFunction get96 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache125;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_groupScrollViewContent);
		}
		LuaObject.addMember(l, name96, get96, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache126, true);
		string name97 = "m_friendBigItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_friendBigItemPrefab);
		}
		LuaCSFunction get97 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache127;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_friendBigItemPrefab);
		}
		LuaObject.addMember(l, name97, get97, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache128, true);
		string name98 = "m_friendSmallItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_friendSmallItemPrefab);
		}
		LuaCSFunction get98 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache129;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_friendSmallItemPrefab);
		}
		LuaObject.addMember(l, name98, get98, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12A, true);
		string name99 = "m_groupItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_groupItemPrefab);
		}
		LuaCSFunction get99 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12B;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_groupItemPrefab);
		}
		LuaObject.addMember(l, name99, get99, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12C, true);
		string name100 = "m_currentServerID";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_currentServerID);
		}
		LuaCSFunction get100 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12D;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_currentServerID);
		}
		LuaObject.addMember(l, name100, get100, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12E, true);
		string name101 = "m_currentChatGroupInfo";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_currentChatGroupInfo);
		}
		LuaCSFunction get101 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache12F;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_currentChatGroupInfo);
		}
		LuaObject.addMember(l, name101, get101, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache130, true);
		string name102 = "m_isCreateNewGroup";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_isCreateNewGroup);
		}
		LuaCSFunction get102 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache131;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_isCreateNewGroup);
		}
		LuaObject.addMember(l, name102, get102, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache132, true);
		string name103 = "m_maxInviteToGroupCount";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_maxInviteToGroupCount);
		}
		LuaObject.addMember(l, name103, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache133, null, false);
		string name104 = "m_isFindFriend";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_isFindFriend);
		}
		LuaCSFunction get103 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache134;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_isFindFriend);
		}
		LuaObject.addMember(l, name104, get103, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache135, true);
		string name105 = "m_isRecommendFriend";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_isRecommendFriend);
		}
		LuaCSFunction get104 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache136;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_isRecommendFriend);
		}
		LuaObject.addMember(l, name105, get104, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache137, true);
		string name106 = "m_recommendFriendList";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_recommendFriendList);
		}
		LuaCSFunction get105 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache138;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_recommendFriendList);
		}
		LuaObject.addMember(l, name106, get105, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache139, true);
		string name107 = "m_applyFriendList";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_applyFriendList);
		}
		LuaCSFunction get106 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13A;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_applyFriendList);
		}
		LuaObject.addMember(l, name107, get106, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13B, true);
		string name108 = "m_inviteToGroupList";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_inviteToGroupList);
		}
		LuaCSFunction get107 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13C;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_inviteToGroupList);
		}
		LuaObject.addMember(l, name108, get107, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13D, true);
		string name109 = "m_groupStaffList";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_groupStaffList);
		}
		LuaCSFunction get108 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13E;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_groupStaffList);
		}
		LuaObject.addMember(l, name109, get108, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache13F, true);
		string name110 = "m_friendApplyAcceptList";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_friendApplyAcceptList);
		}
		LuaCSFunction get109 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache140;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_friendApplyAcceptList);
		}
		LuaObject.addMember(l, name110, get109, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache141, true);
		string name111 = "m_friendApplyDeclineList";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_friendApplyDeclineList);
		}
		LuaCSFunction get110 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache142;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_friendApplyDeclineList);
		}
		LuaObject.addMember(l, name111, get110, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache143, true);
		string name112 = "m_friendAddList";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_friendAddList);
		}
		LuaCSFunction get111 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache144;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_friendAddList);
		}
		LuaObject.addMember(l, name112, get111, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache145, true);
		string name113 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_configDataLoader);
		}
		LuaCSFunction get112 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache146;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name113, get112, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache147, true);
		string name114 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.get_m_playerContext);
		}
		LuaCSFunction get113 = Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache148;
		if (Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache149 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache149 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name114, get113, Lua_BlackJack_ProjectL_UI_FriendUIController.<>f__mg$cache149, true);
		LuaObject.createTypeMetatable(l, null, typeof(FriendUIController), typeof(UIControllerBase));
	}

	// Token: 0x040140C6 RID: 82118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040140C7 RID: 82119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040140C8 RID: 82120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040140C9 RID: 82121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040140CA RID: 82122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040140CB RID: 82123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040140CC RID: 82124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040140CD RID: 82125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040140CE RID: 82126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040140CF RID: 82127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040140D0 RID: 82128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040140D1 RID: 82129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040140D2 RID: 82130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040140D3 RID: 82131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040140D4 RID: 82132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040140D5 RID: 82133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040140D6 RID: 82134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040140D7 RID: 82135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040140D8 RID: 82136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040140D9 RID: 82137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040140DA RID: 82138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040140DB RID: 82139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040140DC RID: 82140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040140DD RID: 82141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040140DE RID: 82142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040140DF RID: 82143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040140E0 RID: 82144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040140E1 RID: 82145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040140E2 RID: 82146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040140E3 RID: 82147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040140E4 RID: 82148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040140E5 RID: 82149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040140E6 RID: 82150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040140E7 RID: 82151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040140E8 RID: 82152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040140E9 RID: 82153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040140EA RID: 82154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040140EB RID: 82155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040140EC RID: 82156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040140ED RID: 82157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040140EE RID: 82158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040140EF RID: 82159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040140F0 RID: 82160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040140F1 RID: 82161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040140F2 RID: 82162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040140F3 RID: 82163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040140F4 RID: 82164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040140F5 RID: 82165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040140F6 RID: 82166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040140F7 RID: 82167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040140F8 RID: 82168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040140F9 RID: 82169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040140FA RID: 82170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040140FB RID: 82171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040140FC RID: 82172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040140FD RID: 82173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040140FE RID: 82174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040140FF RID: 82175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014100 RID: 82176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014101 RID: 82177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04014102 RID: 82178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04014103 RID: 82179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04014104 RID: 82180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04014105 RID: 82181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04014106 RID: 82182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04014107 RID: 82183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014108 RID: 82184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014109 RID: 82185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401410A RID: 82186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401410B RID: 82187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401410C RID: 82188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401410D RID: 82189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401410E RID: 82190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401410F RID: 82191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04014110 RID: 82192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04014111 RID: 82193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04014112 RID: 82194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04014113 RID: 82195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04014114 RID: 82196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04014115 RID: 82197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04014116 RID: 82198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04014117 RID: 82199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04014118 RID: 82200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04014119 RID: 82201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401411A RID: 82202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401411B RID: 82203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401411C RID: 82204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401411D RID: 82205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401411E RID: 82206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401411F RID: 82207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04014120 RID: 82208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04014121 RID: 82209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04014122 RID: 82210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04014123 RID: 82211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04014124 RID: 82212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04014125 RID: 82213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04014126 RID: 82214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04014127 RID: 82215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04014128 RID: 82216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04014129 RID: 82217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0401412A RID: 82218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0401412B RID: 82219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0401412C RID: 82220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0401412D RID: 82221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401412E RID: 82222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401412F RID: 82223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04014130 RID: 82224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04014131 RID: 82225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04014132 RID: 82226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04014133 RID: 82227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04014134 RID: 82228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04014135 RID: 82229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04014136 RID: 82230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04014137 RID: 82231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04014138 RID: 82232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04014139 RID: 82233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0401413A RID: 82234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0401413B RID: 82235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0401413C RID: 82236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0401413D RID: 82237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0401413E RID: 82238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0401413F RID: 82239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04014140 RID: 82240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04014141 RID: 82241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04014142 RID: 82242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04014143 RID: 82243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04014144 RID: 82244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04014145 RID: 82245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04014146 RID: 82246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04014147 RID: 82247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04014148 RID: 82248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04014149 RID: 82249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0401414A RID: 82250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0401414B RID: 82251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0401414C RID: 82252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0401414D RID: 82253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0401414E RID: 82254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0401414F RID: 82255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04014150 RID: 82256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04014151 RID: 82257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04014152 RID: 82258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04014153 RID: 82259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04014154 RID: 82260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04014155 RID: 82261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04014156 RID: 82262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04014157 RID: 82263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04014158 RID: 82264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04014159 RID: 82265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x0401415A RID: 82266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x0401415B RID: 82267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x0401415C RID: 82268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x0401415D RID: 82269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0401415E RID: 82270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0401415F RID: 82271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04014160 RID: 82272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04014161 RID: 82273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04014162 RID: 82274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04014163 RID: 82275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04014164 RID: 82276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04014165 RID: 82277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04014166 RID: 82278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04014167 RID: 82279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04014168 RID: 82280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04014169 RID: 82281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x0401416A RID: 82282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x0401416B RID: 82283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x0401416C RID: 82284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x0401416D RID: 82285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x0401416E RID: 82286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x0401416F RID: 82287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04014170 RID: 82288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04014171 RID: 82289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04014172 RID: 82290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04014173 RID: 82291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04014174 RID: 82292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04014175 RID: 82293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04014176 RID: 82294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04014177 RID: 82295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04014178 RID: 82296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04014179 RID: 82297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x0401417A RID: 82298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x0401417B RID: 82299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x0401417C RID: 82300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x0401417D RID: 82301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x0401417E RID: 82302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x0401417F RID: 82303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x04014180 RID: 82304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x04014181 RID: 82305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x04014182 RID: 82306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x04014183 RID: 82307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x04014184 RID: 82308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x04014185 RID: 82309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x04014186 RID: 82310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04014187 RID: 82311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04014188 RID: 82312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04014189 RID: 82313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x0401418A RID: 82314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x0401418B RID: 82315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x0401418C RID: 82316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x0401418D RID: 82317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x0401418E RID: 82318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x0401418F RID: 82319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04014190 RID: 82320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x04014191 RID: 82321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x04014192 RID: 82322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x04014193 RID: 82323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x04014194 RID: 82324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x04014195 RID: 82325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x04014196 RID: 82326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04014197 RID: 82327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04014198 RID: 82328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04014199 RID: 82329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x0401419A RID: 82330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x0401419B RID: 82331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x0401419C RID: 82332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x0401419D RID: 82333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x0401419E RID: 82334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x0401419F RID: 82335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x040141A0 RID: 82336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x040141A1 RID: 82337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x040141A2 RID: 82338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x040141A3 RID: 82339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x040141A4 RID: 82340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x040141A5 RID: 82341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x040141A6 RID: 82342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x040141A7 RID: 82343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x040141A8 RID: 82344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x040141A9 RID: 82345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x040141AA RID: 82346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x040141AB RID: 82347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x040141AC RID: 82348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x040141AD RID: 82349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x040141AE RID: 82350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x040141AF RID: 82351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x040141B0 RID: 82352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x040141B1 RID: 82353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x040141B2 RID: 82354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x040141B3 RID: 82355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x040141B4 RID: 82356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x040141B5 RID: 82357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x040141B6 RID: 82358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x040141B7 RID: 82359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x040141B8 RID: 82360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x040141B9 RID: 82361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x040141BA RID: 82362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x040141BB RID: 82363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x040141BC RID: 82364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x040141BD RID: 82365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x040141BE RID: 82366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x040141BF RID: 82367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x040141C0 RID: 82368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x040141C1 RID: 82369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x040141C2 RID: 82370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x040141C3 RID: 82371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x040141C4 RID: 82372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x040141C5 RID: 82373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x040141C6 RID: 82374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x040141C7 RID: 82375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x040141C8 RID: 82376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x040141C9 RID: 82377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x040141CA RID: 82378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x040141CB RID: 82379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x040141CC RID: 82380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x040141CD RID: 82381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x040141CE RID: 82382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x040141CF RID: 82383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x040141D0 RID: 82384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x040141D1 RID: 82385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x040141D2 RID: 82386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x040141D3 RID: 82387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x040141D4 RID: 82388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x040141D5 RID: 82389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x040141D6 RID: 82390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x040141D7 RID: 82391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x040141D8 RID: 82392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x040141D9 RID: 82393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x040141DA RID: 82394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x040141DB RID: 82395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x040141DC RID: 82396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x040141DD RID: 82397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x040141DE RID: 82398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x040141DF RID: 82399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x040141E0 RID: 82400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x040141E1 RID: 82401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x040141E2 RID: 82402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x040141E3 RID: 82403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x040141E4 RID: 82404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x040141E5 RID: 82405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x040141E6 RID: 82406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x040141E7 RID: 82407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x040141E8 RID: 82408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x040141E9 RID: 82409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x040141EA RID: 82410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x040141EB RID: 82411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x040141EC RID: 82412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x040141ED RID: 82413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x040141EE RID: 82414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x040141EF RID: 82415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x040141F0 RID: 82416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x040141F1 RID: 82417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x040141F2 RID: 82418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x040141F3 RID: 82419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x040141F4 RID: 82420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x040141F5 RID: 82421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x040141F6 RID: 82422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x040141F7 RID: 82423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x040141F8 RID: 82424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x040141F9 RID: 82425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x040141FA RID: 82426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x040141FB RID: 82427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x040141FC RID: 82428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x040141FD RID: 82429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x040141FE RID: 82430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x040141FF RID: 82431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x04014200 RID: 82432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x04014201 RID: 82433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x04014202 RID: 82434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x04014203 RID: 82435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x04014204 RID: 82436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x04014205 RID: 82437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x04014206 RID: 82438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x04014207 RID: 82439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x04014208 RID: 82440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x04014209 RID: 82441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x0401420A RID: 82442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x0401420B RID: 82443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x0401420C RID: 82444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x0401420D RID: 82445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x0401420E RID: 82446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;

	// Token: 0x0401420F RID: 82447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache149;
}
