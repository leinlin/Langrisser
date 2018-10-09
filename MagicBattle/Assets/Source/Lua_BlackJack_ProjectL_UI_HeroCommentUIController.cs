using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014AD RID: 5293
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroCommentUIController : LuaObject
{
	// Token: 0x0601EAAD RID: 125613 RVA: 0x009EC84C File Offset: 0x009EAA4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAAE RID: 125614 RVA: 0x009EC898 File Offset: 0x009EAA98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HeroCommentUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			bool isNeedResetScrollViewPos;
			LuaObject.checkType(l, 3, out isNeedResetScrollViewPos);
			heroCommentUIController.HeroCommentUpdateView(hero, isNeedResetScrollViewPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAAF RID: 125615 RVA: 0x009EC8FC File Offset: 0x009EAAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRankingListLock(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			bool isLock;
			LuaObject.checkType(l, 2, out isLock);
			heroCommentUIController.UpdateRankingListLock(isLock);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAB0 RID: 125616 RVA: 0x009EC954 File Offset: 0x009EAB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRankingList(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			RankingListInfo rankInfoList;
			LuaObject.checkType<RankingListInfo>(l, 2, out rankInfoList);
			heroCommentUIController.UpdateRankingList(rankInfoList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAB1 RID: 125617 RVA: 0x009EC9AC File Offset: 0x009EABAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPlayerHeroDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			HeroCommentEntry commentEntry;
			LuaObject.checkType<HeroCommentEntry>(l, 2, out commentEntry);
			Hero hero;
			LuaObject.checkType<Hero>(l, 3, out hero);
			heroCommentUIController.ShowPlayerHeroDetailPanel(commentEntry, hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAB2 RID: 125618 RVA: 0x009ECA10 File Offset: 0x009EAC10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAB3 RID: 125619 RVA: 0x009ECA64 File Offset: 0x009EAC64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateComments(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.CreateComments();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAB4 RID: 125620 RVA: 0x009ECAB8 File Offset: 0x009EACB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNormalCommentsInAllComments(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			List<HeroCommentEntry> allComments;
			LuaObject.checkType<List<HeroCommentEntry>>(l, 2, out allComments);
			List<HeroCommentEntry> hotComments;
			LuaObject.checkType<List<HeroCommentEntry>>(l, 3, out hotComments);
			int needShowedCount;
			LuaObject.checkType(l, 4, out needShowedCount);
			List<HeroCommentEntry> normalCommentsInAllComments = heroCommentUIController.m_luaExportHelper.GetNormalCommentsInAllComments(allComments, hotComments, needShowedCount);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, normalCommentsInAllComments);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAB5 RID: 125621 RVA: 0x009ECB3C File Offset: 0x009EAD3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CommentComparerByTime(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			HeroCommentEntry c;
			LuaObject.checkType<HeroCommentEntry>(l, 2, out c);
			HeroCommentEntry c2;
			LuaObject.checkType<HeroCommentEntry>(l, 3, out c2);
			int i = heroCommentUIController.m_luaExportHelper.CommentComparerByTime(c, c2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAB6 RID: 125622 RVA: 0x009ECBB0 File Offset: 0x009EADB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CommentComparerByPraisedNum(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			HeroCommentEntry c;
			LuaObject.checkType<HeroCommentEntry>(l, 2, out c);
			HeroCommentEntry c2;
			LuaObject.checkType<HeroCommentEntry>(l, 3, out c2);
			int i = heroCommentUIController.m_luaExportHelper.CommentComparerByPraisedNum(c, c2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAB7 RID: 125623 RVA: 0x009ECC24 File Offset: 0x009EAE24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCommentsWithCount(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			List<HeroCommentEntry> commentList;
			LuaObject.checkType<List<HeroCommentEntry>>(l, 2, out commentList);
			int count;
			LuaObject.checkType(l, 3, out count);
			List<HeroCommentEntry> commentsWithCount = heroCommentUIController.m_luaExportHelper.GetCommentsWithCount(commentList, count);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commentsWithCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAB8 RID: 125624 RVA: 0x009ECC98 File Offset: 0x009EAE98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateCommentByList(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			List<HeroCommentEntry> commentList;
			LuaObject.checkType<List<HeroCommentEntry>>(l, 2, out commentList);
			GameObject content;
			LuaObject.checkType<GameObject>(l, 3, out content);
			bool isShowPraisedIcon;
			LuaObject.checkType(l, 4, out isShowPraisedIcon);
			heroCommentUIController.m_luaExportHelper.CreateCommentByList(commentList, content, isShowPraisedIcon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAB9 RID: 125625 RVA: 0x009ECD10 File Offset: 0x009EAF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkillItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			heroCommentUIController.m_luaExportHelper.OnSkillItemClick(skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EABA RID: 125626 RVA: 0x009ECD6C File Offset: 0x009EAF6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetSkillDescPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillDescPanel;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillDescPanel);
			heroCommentUIController.m_luaExportHelper.SetSkillDescPanel(skillDescPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EABB RID: 125627 RVA: 0x009ECDC8 File Offset: 0x009EAFC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetSoldierPropAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			int oldValue;
			LuaObject.checkType(l, 2, out oldValue);
			int newValue;
			LuaObject.checkType(l, 3, out newValue);
			Text txt;
			LuaObject.checkType<Text>(l, 4, out txt);
			heroCommentUIController.m_luaExportHelper.SetSoldierPropAddText(oldValue, newValue, txt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EABC RID: 125628 RVA: 0x009ECE40 File Offset: 0x009EB040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosePlayerHeroDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.ClosePlayerHeroDetailPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EABD RID: 125629 RVA: 0x009ECE94 File Offset: 0x009EB094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCommentItemNameClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			HeroCommentEntry comment;
			LuaObject.checkType<HeroCommentEntry>(l, 2, out comment);
			heroCommentUIController.m_luaExportHelper.OnCommentItemNameClick(comment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EABE RID: 125630 RVA: 0x009ECEF0 File Offset: 0x009EB0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCommentItemPraisedBtnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			heroCommentUIController.m_luaExportHelper.OnCommentItemPraisedBtnClick(instanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EABF RID: 125631 RVA: 0x009ECF4C File Offset: 0x009EB14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnMoreCommentButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.OnMoreCommentButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAC0 RID: 125632 RVA: 0x009ECFA0 File Offset: 0x009EB1A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAC1 RID: 125633 RVA: 0x009ECFF4 File Offset: 0x009EB1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAllCommentToggleClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			heroCommentUIController.m_luaExportHelper.OnAllCommentToggleClick(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAC2 RID: 125634 RVA: 0x009ED050 File Offset: 0x009EB250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHotCommentToggleClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			heroCommentUIController.m_luaExportHelper.OnHotCommentToggleClick(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAC3 RID: 125635 RVA: 0x009ED0AC File Offset: 0x009EB2AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRankingListCommentToggleClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			heroCommentUIController.m_luaExportHelper.OnRankingListCommentToggleClick(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAC4 RID: 125636 RVA: 0x009ED108 File Offset: 0x009EB308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRankingListLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.OnRankingListLockButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAC5 RID: 125637 RVA: 0x009ED15C File Offset: 0x009EB35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCommentSendButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.OnCommentSendButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAC6 RID: 125638 RVA: 0x009ED1B0 File Offset: 0x009EB3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			UISpineGraphic o;
			LuaObject.checkType<UISpineGraphic>(l, 2, out o);
			string assetName;
			LuaObject.checkType(l, 3, out assetName);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 4, out parent);
			int direction;
			LuaObject.checkType(l, 5, out direction);
			Vector2 offset;
			LuaObject.checkType(l, 6, out offset);
			float scale;
			LuaObject.checkType(l, 7, out scale);
			List<ReplaceAnim> anims;
			LuaObject.checkType<List<ReplaceAnim>>(l, 8, out anims);
			heroCommentUIController.m_luaExportHelper.CreateSpineGraphic(ref o, assetName, parent, direction, offset, scale, anims);
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

	// Token: 0x0601EAC7 RID: 125639 RVA: 0x009ED260 File Offset: 0x009EB460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			UISpineGraphic o;
			LuaObject.checkType<UISpineGraphic>(l, 2, out o);
			heroCommentUIController.m_luaExportHelper.DestroySpineGraphic(ref o);
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

	// Token: 0x0601EAC8 RID: 125640 RVA: 0x009ED2C4 File Offset: 0x009EB4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewToTop(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.ResetScrollViewToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAC9 RID: 125641 RVA: 0x009ED318 File Offset: 0x009EB518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroCommentUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EACA RID: 125642 RVA: 0x009ED384 File Offset: 0x009EB584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EACB RID: 125643 RVA: 0x009ED3D8 File Offset: 0x009EB5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EACC RID: 125644 RVA: 0x009ED42C File Offset: 0x009EB62C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroCommentUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601EACD RID: 125645 RVA: 0x009ED4D4 File Offset: 0x009EB6D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EACE RID: 125646 RVA: 0x009ED528 File Offset: 0x009EB728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroCommentUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EACF RID: 125647 RVA: 0x009ED594 File Offset: 0x009EB794
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
				HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroCommentUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroCommentUIController heroCommentUIController2 = (HeroCommentUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroCommentUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601EAD0 RID: 125648 RVA: 0x009ED6A4 File Offset: 0x009EB8A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCommentUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAD1 RID: 125649 RVA: 0x009ED710 File Offset: 0x009EB910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCommentUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAD2 RID: 125650 RVA: 0x009ED77C File Offset: 0x009EB97C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCommentUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAD3 RID: 125651 RVA: 0x009ED7E8 File Offset: 0x009EB9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCommentUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAD4 RID: 125652 RVA: 0x009ED854 File Offset: 0x009EBA54
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
				HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroCommentUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroCommentUIController heroCommentUIController2 = (HeroCommentUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroCommentUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601EAD5 RID: 125653 RVA: 0x009ED964 File Offset: 0x009EBB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			string s = heroCommentUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601EAD6 RID: 125654 RVA: 0x009ED9C0 File Offset: 0x009EBBC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAD7 RID: 125655 RVA: 0x009EDA14 File Offset: 0x009EBC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAD8 RID: 125656 RVA: 0x009EDA68 File Offset: 0x009EBC68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnCommentSend(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			string arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroCommentUIController.m_luaExportHelper.__callDele_EventOnCommentSend(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAD9 RID: 125657 RVA: 0x009EDAD4 File Offset: 0x009EBCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCommentSend(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			string arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroCommentUIController.m_luaExportHelper.__clearDele_EventOnCommentSend(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EADA RID: 125658 RVA: 0x009EDB40 File Offset: 0x009EBD40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnNameClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			HeroCommentEntry arg2;
			LuaObject.checkType<HeroCommentEntry>(l, 3, out arg2);
			heroCommentUIController.m_luaExportHelper.__callDele_EventOnNameClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EADB RID: 125659 RVA: 0x009EDBAC File Offset: 0x009EBDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNameClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			HeroCommentEntry arg2;
			LuaObject.checkType<HeroCommentEntry>(l, 3, out arg2);
			heroCommentUIController.m_luaExportHelper.__clearDele_EventOnNameClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EADC RID: 125660 RVA: 0x009EDC18 File Offset: 0x009EBE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPraisedBtnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroCommentUIController.m_luaExportHelper.__callDele_EventOnPraisedBtnClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EADD RID: 125661 RVA: 0x009EDC84 File Offset: 0x009EBE84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnPraisedBtnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroCommentUIController.m_luaExportHelper.__clearDele_EventOnPraisedBtnClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EADE RID: 125662 RVA: 0x009EDCF0 File Offset: 0x009EBEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetHeroComments(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroCommentUIController.m_luaExportHelper.__callDele_EventOnGetHeroComments(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EADF RID: 125663 RVA: 0x009EDD5C File Offset: 0x009EBF5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetHeroComments(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroCommentUIController.m_luaExportHelper.__clearDele_EventOnGetHeroComments(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAE0 RID: 125664 RVA: 0x009EDDC8 File Offset: 0x009EBFC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRankingQurey(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroCommentUIController.m_luaExportHelper.__callDele_EventOnRankingQurey(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAE1 RID: 125665 RVA: 0x009EDE24 File Offset: 0x009EC024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRankingQurey(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroCommentUIController.m_luaExportHelper.__clearDele_EventOnRankingQurey(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAE2 RID: 125666 RVA: 0x009EDE80 File Offset: 0x009EC080
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnRankingListLockClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.__callDele_EventOnRankingListLockClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAE3 RID: 125667 RVA: 0x009EDED4 File Offset: 0x009EC0D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnRankingListLockClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			heroCommentUIController.m_luaExportHelper.__clearDele_EventOnRankingListLockClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAE4 RID: 125668 RVA: 0x009EDF28 File Offset: 0x009EC128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroCommentUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroCommentUIController.EventOnReturn -= value;
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

	// Token: 0x0601EAE5 RID: 125669 RVA: 0x009EDFA8 File Offset: 0x009EC1A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnCommentSend(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Action<int, string> value;
			int num = LuaObject.checkDelegate<Action<int, string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroCommentUIController.EventOnCommentSend += value;
				}
				else if (num == 2)
				{
					heroCommentUIController.EventOnCommentSend -= value;
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

	// Token: 0x0601EAE6 RID: 125670 RVA: 0x009EE028 File Offset: 0x009EC228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNameClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Action<int, HeroCommentEntry> value;
			int num = LuaObject.checkDelegate<Action<int, HeroCommentEntry>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroCommentUIController.EventOnNameClick += value;
				}
				else if (num == 2)
				{
					heroCommentUIController.EventOnNameClick -= value;
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

	// Token: 0x0601EAE7 RID: 125671 RVA: 0x009EE0A8 File Offset: 0x009EC2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPraisedBtnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Action<int, ulong> value;
			int num = LuaObject.checkDelegate<Action<int, ulong>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroCommentUIController.EventOnPraisedBtnClick += value;
				}
				else if (num == 2)
				{
					heroCommentUIController.EventOnPraisedBtnClick -= value;
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

	// Token: 0x0601EAE8 RID: 125672 RVA: 0x009EE128 File Offset: 0x009EC328
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnGetHeroComments(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Action<int, bool> value;
			int num = LuaObject.checkDelegate<Action<int, bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroCommentUIController.EventOnGetHeroComments += value;
				}
				else if (num == 2)
				{
					heroCommentUIController.EventOnGetHeroComments -= value;
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

	// Token: 0x0601EAE9 RID: 125673 RVA: 0x009EE1A8 File Offset: 0x009EC3A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRankingQurey(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroCommentUIController.EventOnRankingQurey += value;
				}
				else if (num == 2)
				{
					heroCommentUIController.EventOnRankingQurey -= value;
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

	// Token: 0x0601EAEA RID: 125674 RVA: 0x009EE228 File Offset: 0x009EC428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRankingListLockClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroCommentUIController.EventOnRankingListLockClick += value;
				}
				else if (num == 2)
				{
					heroCommentUIController.EventOnRankingListLockClick -= value;
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

	// Token: 0x0601EAEB RID: 125675 RVA: 0x009EE2A8 File Offset: 0x009EC4A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAEC RID: 125676 RVA: 0x009EE300 File Offset: 0x009EC500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			heroCommentUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAED RID: 125677 RVA: 0x009EE35C File Offset: 0x009EC55C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAEE RID: 125678 RVA: 0x009EE3B4 File Offset: 0x009EC5B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			heroCommentUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAEF RID: 125679 RVA: 0x009EE410 File Offset: 0x009EC610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAF0 RID: 125680 RVA: 0x009EE468 File Offset: 0x009EC668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			heroCommentUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAF1 RID: 125681 RVA: 0x009EE4C4 File Offset: 0x009EC6C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_commentNormalToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commentNormalToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAF2 RID: 125682 RVA: 0x009EE51C File Offset: 0x009EC71C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commentNormalToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Toggle commentNormalToggle;
			LuaObject.checkType<Toggle>(l, 2, out commentNormalToggle);
			heroCommentUIController.m_luaExportHelper.m_commentNormalToggle = commentNormalToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAF3 RID: 125683 RVA: 0x009EE578 File Offset: 0x009EC778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commentNormalToggleUnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commentNormalToggleUnClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAF4 RID: 125684 RVA: 0x009EE5D0 File Offset: 0x009EC7D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commentNormalToggleUnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject commentNormalToggleUnClick;
			LuaObject.checkType<GameObject>(l, 2, out commentNormalToggleUnClick);
			heroCommentUIController.m_luaExportHelper.m_commentNormalToggleUnClick = commentNormalToggleUnClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAF5 RID: 125685 RVA: 0x009EE62C File Offset: 0x009EC82C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_commentNormalToggleClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commentNormalToggleClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAF6 RID: 125686 RVA: 0x009EE684 File Offset: 0x009EC884
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_commentNormalToggleClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject commentNormalToggleClick;
			LuaObject.checkType<GameObject>(l, 2, out commentNormalToggleClick);
			heroCommentUIController.m_luaExportHelper.m_commentNormalToggleClick = commentNormalToggleClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAF7 RID: 125687 RVA: 0x009EE6E0 File Offset: 0x009EC8E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commentHotToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commentHotToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAF8 RID: 125688 RVA: 0x009EE738 File Offset: 0x009EC938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commentHotToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Toggle commentHotToggle;
			LuaObject.checkType<Toggle>(l, 2, out commentHotToggle);
			heroCommentUIController.m_luaExportHelper.m_commentHotToggle = commentHotToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAF9 RID: 125689 RVA: 0x009EE794 File Offset: 0x009EC994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commentHotToggleUnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commentHotToggleUnClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAFA RID: 125690 RVA: 0x009EE7EC File Offset: 0x009EC9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commentHotToggleUnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject commentHotToggleUnClick;
			LuaObject.checkType<GameObject>(l, 2, out commentHotToggleUnClick);
			heroCommentUIController.m_luaExportHelper.m_commentHotToggleUnClick = commentHotToggleUnClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAFB RID: 125691 RVA: 0x009EE848 File Offset: 0x009ECA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commentHotToggleClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commentHotToggleClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAFC RID: 125692 RVA: 0x009EE8A0 File Offset: 0x009ECAA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_commentHotToggleClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject commentHotToggleClick;
			LuaObject.checkType<GameObject>(l, 2, out commentHotToggleClick);
			heroCommentUIController.m_luaExportHelper.m_commentHotToggleClick = commentHotToggleClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAFD RID: 125693 RVA: 0x009EE8FC File Offset: 0x009ECAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commentRankingToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commentRankingToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAFE RID: 125694 RVA: 0x009EE954 File Offset: 0x009ECB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commentRankingToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Toggle commentRankingToggle;
			LuaObject.checkType<Toggle>(l, 2, out commentRankingToggle);
			heroCommentUIController.m_luaExportHelper.m_commentRankingToggle = commentRankingToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAFF RID: 125695 RVA: 0x009EE9B0 File Offset: 0x009ECBB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_commnetRankingUnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commnetRankingUnClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB00 RID: 125696 RVA: 0x009EEA08 File Offset: 0x009ECC08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_commnetRankingUnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject commnetRankingUnClick;
			LuaObject.checkType<GameObject>(l, 2, out commnetRankingUnClick);
			heroCommentUIController.m_luaExportHelper.m_commnetRankingUnClick = commnetRankingUnClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB01 RID: 125697 RVA: 0x009EEA64 File Offset: 0x009ECC64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_commnetRankingClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commnetRankingClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB02 RID: 125698 RVA: 0x009EEABC File Offset: 0x009ECCBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commnetRankingClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject commnetRankingClick;
			LuaObject.checkType<GameObject>(l, 2, out commnetRankingClick);
			heroCommentUIController.m_luaExportHelper.m_commnetRankingClick = commnetRankingClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB03 RID: 125699 RVA: 0x009EEB18 File Offset: 0x009ECD18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rankingListLockButton(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_rankingListLockButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB04 RID: 125700 RVA: 0x009EEB70 File Offset: 0x009ECD70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rankingListLockButton(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Button rankingListLockButton;
			LuaObject.checkType<Button>(l, 2, out rankingListLockButton);
			heroCommentUIController.m_luaExportHelper.m_rankingListLockButton = rankingListLockButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB05 RID: 125701 RVA: 0x009EEBCC File Offset: 0x009ECDCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noCommentPanelObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_noCommentPanelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB06 RID: 125702 RVA: 0x009EEC24 File Offset: 0x009ECE24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_noCommentPanelObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject noCommentPanelObj;
			LuaObject.checkType<GameObject>(l, 2, out noCommentPanelObj);
			heroCommentUIController.m_luaExportHelper.m_noCommentPanelObj = noCommentPanelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB07 RID: 125703 RVA: 0x009EEC80 File Offset: 0x009ECE80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hotCommentListObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_hotCommentListObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB08 RID: 125704 RVA: 0x009EECD8 File Offset: 0x009ECED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hotCommentListObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject hotCommentListObj;
			LuaObject.checkType<GameObject>(l, 2, out hotCommentListObj);
			heroCommentUIController.m_luaExportHelper.m_hotCommentListObj = hotCommentListObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB09 RID: 125705 RVA: 0x009EED34 File Offset: 0x009ECF34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_normalCommentListObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_normalCommentListObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB0A RID: 125706 RVA: 0x009EED8C File Offset: 0x009ECF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_normalCommentListObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject normalCommentListObj;
			LuaObject.checkType<GameObject>(l, 2, out normalCommentListObj);
			heroCommentUIController.m_luaExportHelper.m_normalCommentListObj = normalCommentListObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB0B RID: 125707 RVA: 0x009EEDE8 File Offset: 0x009ECFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_moreCommentTextObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_moreCommentTextObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB0C RID: 125708 RVA: 0x009EEE40 File Offset: 0x009ED040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_moreCommentTextObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject moreCommentTextObj;
			LuaObject.checkType<GameObject>(l, 2, out moreCommentTextObj);
			heroCommentUIController.m_luaExportHelper.m_moreCommentTextObj = moreCommentTextObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB0D RID: 125709 RVA: 0x009EEE9C File Offset: 0x009ED09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commentListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commentListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB0E RID: 125710 RVA: 0x009EEEF4 File Offset: 0x009ED0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commentListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			ScrollRect commentListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out commentListScrollRect);
			heroCommentUIController.m_luaExportHelper.m_commentListScrollRect = commentListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB0F RID: 125711 RVA: 0x009EEF50 File Offset: 0x009ED150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inputCommentGo(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_inputCommentGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB10 RID: 125712 RVA: 0x009EEFA8 File Offset: 0x009ED1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inputCommentGo(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject inputCommentGo;
			LuaObject.checkType<GameObject>(l, 2, out inputCommentGo);
			heroCommentUIController.m_luaExportHelper.m_inputCommentGo = inputCommentGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB11 RID: 125713 RVA: 0x009EF004 File Offset: 0x009ED204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commentInputField(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commentInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB12 RID: 125714 RVA: 0x009EF05C File Offset: 0x009ED25C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commentInputField(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			InputField commentInputField;
			LuaObject.checkType<InputField>(l, 2, out commentInputField);
			heroCommentUIController.m_luaExportHelper.m_commentInputField = commentInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB13 RID: 125715 RVA: 0x009EF0B8 File Offset: 0x009ED2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commentSendButton(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commentSendButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB14 RID: 125716 RVA: 0x009EF110 File Offset: 0x009ED310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commentSendButton(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Button commentSendButton;
			LuaObject.checkType<Button>(l, 2, out commentSendButton);
			heroCommentUIController.m_luaExportHelper.m_commentSendButton = commentSendButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB15 RID: 125717 RVA: 0x009EF16C File Offset: 0x009ED36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commentItemPrefabObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_commentItemPrefabObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB16 RID: 125718 RVA: 0x009EF1C4 File Offset: 0x009ED3C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commentItemPrefabObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject commentItemPrefabObj;
			LuaObject.checkType<GameObject>(l, 2, out commentItemPrefabObj);
			heroCommentUIController.m_luaExportHelper.m_commentItemPrefabObj = commentItemPrefabObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB17 RID: 125719 RVA: 0x009EF220 File Offset: 0x009ED420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_moreCommentButton(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_moreCommentButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB18 RID: 125720 RVA: 0x009EF278 File Offset: 0x009ED478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_moreCommentButton(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Button moreCommentButton;
			LuaObject.checkType<Button>(l, 2, out moreCommentButton);
			heroCommentUIController.m_luaExportHelper.m_moreCommentButton = moreCommentButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB19 RID: 125721 RVA: 0x009EF2D4 File Offset: 0x009ED4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankingListGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_rankingListGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB1A RID: 125722 RVA: 0x009EF32C File Offset: 0x009ED52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankingListGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject rankingListGroup;
			LuaObject.checkType<GameObject>(l, 2, out rankingListGroup);
			heroCommentUIController.m_luaExportHelper.m_rankingListGroup = rankingListGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB1B RID: 125723 RVA: 0x009EF388 File Offset: 0x009ED588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankingListUICtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_rankingListUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB1C RID: 125724 RVA: 0x009EF3DC File Offset: 0x009ED5DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rankingListUICtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			RankingListUIController rankingListUICtrl;
			LuaObject.checkType<RankingListUIController>(l, 2, out rankingListUICtrl);
			heroCommentUIController.m_rankingListUICtrl = rankingListUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB1D RID: 125725 RVA: 0x009EF434 File Offset: 0x009ED634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroDetailPanelObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroDetailPanelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB1E RID: 125726 RVA: 0x009EF48C File Offset: 0x009ED68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroDetailPanelObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject playerHeroDetailPanelObj;
			LuaObject.checkType<GameObject>(l, 2, out playerHeroDetailPanelObj);
			heroCommentUIController.m_luaExportHelper.m_playerHeroDetailPanelObj = playerHeroDetailPanelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB1F RID: 125727 RVA: 0x009EF4E8 File Offset: 0x009ED6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroDetailCloseImage(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroDetailCloseImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB20 RID: 125728 RVA: 0x009EF540 File Offset: 0x009ED740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroDetailCloseImage(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Button playerHeroDetailCloseImage;
			LuaObject.checkType<Button>(l, 2, out playerHeroDetailCloseImage);
			heroCommentUIController.m_luaExportHelper.m_playerHeroDetailCloseImage = playerHeroDetailCloseImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB21 RID: 125729 RVA: 0x009EF59C File Offset: 0x009ED79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroDetailCloseBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroDetailCloseBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB22 RID: 125730 RVA: 0x009EF5F4 File Offset: 0x009ED7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroDetailCloseBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Button playerHeroDetailCloseBtn;
			LuaObject.checkType<Button>(l, 2, out playerHeroDetailCloseBtn);
			heroCommentUIController.m_luaExportHelper.m_playerHeroDetailCloseBtn = playerHeroDetailCloseBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB23 RID: 125731 RVA: 0x009EF650 File Offset: 0x009ED850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroLvStarsObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroLvStarsObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB24 RID: 125732 RVA: 0x009EF6A8 File Offset: 0x009ED8A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroLvStarsObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject playerHeroLvStarsObj;
			LuaObject.checkType<GameObject>(l, 2, out playerHeroLvStarsObj);
			heroCommentUIController.m_luaExportHelper.m_playerHeroLvStarsObj = playerHeroLvStarsObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB25 RID: 125733 RVA: 0x009EF704 File Offset: 0x009ED904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroJobNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroJobNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB26 RID: 125734 RVA: 0x009EF75C File Offset: 0x009ED95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroJobNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroJobNameText;
			LuaObject.checkType<Text>(l, 2, out playerHeroJobNameText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroJobNameText = playerHeroJobNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB27 RID: 125735 RVA: 0x009EF7B8 File Offset: 0x009ED9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroJobLvStarsObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroJobLvStarsObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB28 RID: 125736 RVA: 0x009EF810 File Offset: 0x009EDA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroJobLvStarsObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject playerHeroJobLvStarsObj;
			LuaObject.checkType<GameObject>(l, 2, out playerHeroJobLvStarsObj);
			heroCommentUIController.m_luaExportHelper.m_playerHeroJobLvStarsObj = playerHeroJobLvStarsObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB29 RID: 125737 RVA: 0x009EF86C File Offset: 0x009EDA6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroJobMasterImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroJobMasterImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB2A RID: 125738 RVA: 0x009EF8C4 File Offset: 0x009EDAC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroJobMasterImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroJobMasterImg;
			LuaObject.checkType<Image>(l, 2, out playerHeroJobMasterImg);
			heroCommentUIController.m_luaExportHelper.m_playerHeroJobMasterImg = playerHeroJobMasterImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB2B RID: 125739 RVA: 0x009EF920 File Offset: 0x009EDB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroHalfBodyImage(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroHalfBodyImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB2C RID: 125740 RVA: 0x009EF978 File Offset: 0x009EDB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroHalfBodyImage(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroHalfBodyImage;
			LuaObject.checkType<Image>(l, 2, out playerHeroHalfBodyImage);
			heroCommentUIController.m_luaExportHelper.m_playerHeroHalfBodyImage = playerHeroHalfBodyImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB2D RID: 125741 RVA: 0x009EF9D4 File Offset: 0x009EDBD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroPropHPImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropHPImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB2E RID: 125742 RVA: 0x009EFA2C File Offset: 0x009EDC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroPropHPImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroPropHPImg;
			LuaObject.checkType<Image>(l, 2, out playerHeroPropHPImg);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropHPImg = playerHeroPropHPImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB2F RID: 125743 RVA: 0x009EFA88 File Offset: 0x009EDC88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroPropDFImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropDFImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB30 RID: 125744 RVA: 0x009EFAE0 File Offset: 0x009EDCE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroPropDFImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroPropDFImg;
			LuaObject.checkType<Image>(l, 2, out playerHeroPropDFImg);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropDFImg = playerHeroPropDFImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB31 RID: 125745 RVA: 0x009EFB3C File Offset: 0x009EDD3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroPropATImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropATImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB32 RID: 125746 RVA: 0x009EFB94 File Offset: 0x009EDD94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroPropATImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroPropATImg;
			LuaObject.checkType<Image>(l, 2, out playerHeroPropATImg);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropATImg = playerHeroPropATImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB33 RID: 125747 RVA: 0x009EFBF0 File Offset: 0x009EDDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroPropMagicDFImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropMagicDFImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB34 RID: 125748 RVA: 0x009EFC48 File Offset: 0x009EDE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroPropMagicDFImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroPropMagicDFImg;
			LuaObject.checkType<Image>(l, 2, out playerHeroPropMagicDFImg);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropMagicDFImg = playerHeroPropMagicDFImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB35 RID: 125749 RVA: 0x009EFCA4 File Offset: 0x009EDEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroPropMagicImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropMagicImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB36 RID: 125750 RVA: 0x009EFCFC File Offset: 0x009EDEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroPropMagicImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroPropMagicImg;
			LuaObject.checkType<Image>(l, 2, out playerHeroPropMagicImg);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropMagicImg = playerHeroPropMagicImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB37 RID: 125751 RVA: 0x009EFD58 File Offset: 0x009EDF58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerHeroPropDEXImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropDEXImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB38 RID: 125752 RVA: 0x009EFDB0 File Offset: 0x009EDFB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerHeroPropDEXImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroPropDEXImg;
			LuaObject.checkType<Image>(l, 2, out playerHeroPropDEXImg);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropDEXImg = playerHeroPropDEXImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB39 RID: 125753 RVA: 0x009EFE0C File Offset: 0x009EE00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB3A RID: 125754 RVA: 0x009EFE64 File Offset: 0x009EE064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroPropHPValueText;
			LuaObject.checkType<Text>(l, 2, out playerHeroPropHPValueText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropHPValueText = playerHeroPropHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB3B RID: 125755 RVA: 0x009EFEC0 File Offset: 0x009EE0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB3C RID: 125756 RVA: 0x009EFF18 File Offset: 0x009EE118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerHeroPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroPropDFValueText;
			LuaObject.checkType<Text>(l, 2, out playerHeroPropDFValueText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropDFValueText = playerHeroPropDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB3D RID: 125757 RVA: 0x009EFF74 File Offset: 0x009EE174
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerHeroPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB3E RID: 125758 RVA: 0x009EFFCC File Offset: 0x009EE1CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerHeroPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroPropATValueText;
			LuaObject.checkType<Text>(l, 2, out playerHeroPropATValueText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropATValueText = playerHeroPropATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB3F RID: 125759 RVA: 0x009F0028 File Offset: 0x009EE228
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerHeroPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB40 RID: 125760 RVA: 0x009F0080 File Offset: 0x009EE280
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerHeroPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroPropMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out playerHeroPropMagicDFValueText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropMagicDFValueText = playerHeroPropMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB41 RID: 125761 RVA: 0x009F00DC File Offset: 0x009EE2DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerHeroPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropMagicValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB42 RID: 125762 RVA: 0x009F0134 File Offset: 0x009EE334
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerHeroPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroPropMagicValueText;
			LuaObject.checkType<Text>(l, 2, out playerHeroPropMagicValueText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropMagicValueText = playerHeroPropMagicValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB43 RID: 125763 RVA: 0x009F0190 File Offset: 0x009EE390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroPropDEXValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropDEXValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB44 RID: 125764 RVA: 0x009F01E8 File Offset: 0x009EE3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroPropDEXValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroPropDEXValueText;
			LuaObject.checkType<Text>(l, 2, out playerHeroPropDEXValueText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropDEXValueText = playerHeroPropDEXValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB45 RID: 125765 RVA: 0x009F0244 File Offset: 0x009EE444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroPropHPAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropHPAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB46 RID: 125766 RVA: 0x009F029C File Offset: 0x009EE49C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerHeroPropHPAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroPropHPAddText;
			LuaObject.checkType<Text>(l, 2, out playerHeroPropHPAddText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropHPAddText = playerHeroPropHPAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB47 RID: 125767 RVA: 0x009F02F8 File Offset: 0x009EE4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroPropDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB48 RID: 125768 RVA: 0x009F0350 File Offset: 0x009EE550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerHeroPropDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroPropDFAddText;
			LuaObject.checkType<Text>(l, 2, out playerHeroPropDFAddText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropDFAddText = playerHeroPropDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB49 RID: 125769 RVA: 0x009F03AC File Offset: 0x009EE5AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerHeroPropATAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropATAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB4A RID: 125770 RVA: 0x009F0404 File Offset: 0x009EE604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroPropATAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroPropATAddText;
			LuaObject.checkType<Text>(l, 2, out playerHeroPropATAddText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropATAddText = playerHeroPropATAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB4B RID: 125771 RVA: 0x009F0460 File Offset: 0x009EE660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroPropMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropMagicDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB4C RID: 125772 RVA: 0x009F04B8 File Offset: 0x009EE6B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerHeroPropMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroPropMagicDFAddText;
			LuaObject.checkType<Text>(l, 2, out playerHeroPropMagicDFAddText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropMagicDFAddText = playerHeroPropMagicDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB4D RID: 125773 RVA: 0x009F0514 File Offset: 0x009EE714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerHeroPropMagicAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropMagicAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB4E RID: 125774 RVA: 0x009F056C File Offset: 0x009EE76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroPropMagicAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroPropMagicAddText;
			LuaObject.checkType<Text>(l, 2, out playerHeroPropMagicAddText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropMagicAddText = playerHeroPropMagicAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB4F RID: 125775 RVA: 0x009F05C8 File Offset: 0x009EE7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroPropDEXAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroPropDEXAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB50 RID: 125776 RVA: 0x009F0620 File Offset: 0x009EE820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroPropDEXAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroPropDEXAddText;
			LuaObject.checkType<Text>(l, 2, out playerHeroPropDEXAddText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroPropDEXAddText = playerHeroPropDEXAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB51 RID: 125777 RVA: 0x009F067C File Offset: 0x009EE87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB52 RID: 125778 RVA: 0x009F06D4 File Offset: 0x009EE8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			heroCommentUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB53 RID: 125779 RVA: 0x009F0730 File Offset: 0x009EE930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroLvValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroLvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB54 RID: 125780 RVA: 0x009F0788 File Offset: 0x009EE988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroLvValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroLvValueText;
			LuaObject.checkType<Text>(l, 2, out playerHeroLvValueText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroLvValueText = playerHeroLvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB55 RID: 125781 RVA: 0x009F07E4 File Offset: 0x009EE9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB56 RID: 125782 RVA: 0x009F083C File Offset: 0x009EEA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroNameText;
			LuaObject.checkType<Text>(l, 2, out playerHeroNameText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroNameText = playerHeroNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB57 RID: 125783 RVA: 0x009F0898 File Offset: 0x009EEA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroSoldierIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroSoldierIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB58 RID: 125784 RVA: 0x009F08F0 File Offset: 0x009EEAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroSoldierIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroSoldierIconImg;
			LuaObject.checkType<Image>(l, 2, out playerHeroSoldierIconImg);
			heroCommentUIController.m_luaExportHelper.m_playerHeroSoldierIconImg = playerHeroSoldierIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB59 RID: 125785 RVA: 0x009F094C File Offset: 0x009EEB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroEquipments1(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroEquipments1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB5A RID: 125786 RVA: 0x009F09A4 File Offset: 0x009EEBA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerHeroEquipments1(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroEquipments;
			LuaObject.checkType<Image>(l, 2, out playerHeroEquipments);
			heroCommentUIController.m_luaExportHelper.m_playerHeroEquipments1 = playerHeroEquipments;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB5B RID: 125787 RVA: 0x009F0A00 File Offset: 0x009EEC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroEquipments2(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroEquipments2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB5C RID: 125788 RVA: 0x009F0A58 File Offset: 0x009EEC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroEquipments2(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroEquipments;
			LuaObject.checkType<Image>(l, 2, out playerHeroEquipments);
			heroCommentUIController.m_luaExportHelper.m_playerHeroEquipments2 = playerHeroEquipments;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB5D RID: 125789 RVA: 0x009F0AB4 File Offset: 0x009EECB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroEquipments3(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroEquipments3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB5E RID: 125790 RVA: 0x009F0B0C File Offset: 0x009EED0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroEquipments3(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroEquipments;
			LuaObject.checkType<Image>(l, 2, out playerHeroEquipments);
			heroCommentUIController.m_luaExportHelper.m_playerHeroEquipments3 = playerHeroEquipments;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB5F RID: 125791 RVA: 0x009F0B68 File Offset: 0x009EED68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroEquipments4(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroEquipments4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB60 RID: 125792 RVA: 0x009F0BC0 File Offset: 0x009EEDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroEquipments4(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroEquipments;
			LuaObject.checkType<Image>(l, 2, out playerHeroEquipments);
			heroCommentUIController.m_luaExportHelper.m_playerHeroEquipments4 = playerHeroEquipments;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB61 RID: 125793 RVA: 0x009F0C1C File Offset: 0x009EEE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroTalentIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroTalentIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB62 RID: 125794 RVA: 0x009F0C74 File Offset: 0x009EEE74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroTalentIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroTalentIcon;
			LuaObject.checkType<Image>(l, 2, out playerHeroTalentIcon);
			heroCommentUIController.m_luaExportHelper.m_playerHeroTalentIcon = playerHeroTalentIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB63 RID: 125795 RVA: 0x009F0CD0 File Offset: 0x009EEED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroSkillIcon1(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroSkillIcon1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB64 RID: 125796 RVA: 0x009F0D28 File Offset: 0x009EEF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroSkillIcon1(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroSkillIcon;
			LuaObject.checkType<Image>(l, 2, out playerHeroSkillIcon);
			heroCommentUIController.m_luaExportHelper.m_playerHeroSkillIcon1 = playerHeroSkillIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB65 RID: 125797 RVA: 0x009F0D84 File Offset: 0x009EEF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroSkillIcon2(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroSkillIcon2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB66 RID: 125798 RVA: 0x009F0DDC File Offset: 0x009EEFDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerHeroSkillIcon2(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroSkillIcon;
			LuaObject.checkType<Image>(l, 2, out playerHeroSkillIcon);
			heroCommentUIController.m_luaExportHelper.m_playerHeroSkillIcon2 = playerHeroSkillIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB67 RID: 125799 RVA: 0x009F0E38 File Offset: 0x009EF038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerHeroSkillIcon3(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroSkillIcon3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB68 RID: 125800 RVA: 0x009F0E90 File Offset: 0x009EF090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroSkillIcon3(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Image playerHeroSkillIcon;
			LuaObject.checkType<Image>(l, 2, out playerHeroSkillIcon);
			heroCommentUIController.m_luaExportHelper.m_playerHeroSkillIcon3 = playerHeroSkillIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB69 RID: 125801 RVA: 0x009F0EEC File Offset: 0x009EF0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroSkillDescObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB6A RID: 125802 RVA: 0x009F0F44 File Offset: 0x009EF144
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerHeroSkillDescObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject playerHeroSkillDescObj;
			LuaObject.checkType<GameObject>(l, 2, out playerHeroSkillDescObj);
			heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescObj = playerHeroSkillDescObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB6B RID: 125803 RVA: 0x009F0FA0 File Offset: 0x009EF1A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroSkillDescNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB6C RID: 125804 RVA: 0x009F0FF8 File Offset: 0x009EF1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroSkillDescNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroSkillDescNameText;
			LuaObject.checkType<Text>(l, 2, out playerHeroSkillDescNameText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescNameText = playerHeroSkillDescNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB6D RID: 125805 RVA: 0x009F1054 File Offset: 0x009EF254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerHeroSkillDescCostObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescCostObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB6E RID: 125806 RVA: 0x009F10AC File Offset: 0x009EF2AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroSkillDescCostObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject playerHeroSkillDescCostObj;
			LuaObject.checkType<GameObject>(l, 2, out playerHeroSkillDescCostObj);
			heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescCostObj = playerHeroSkillDescCostObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB6F RID: 125807 RVA: 0x009F1108 File Offset: 0x009EF308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB70 RID: 125808 RVA: 0x009F1160 File Offset: 0x009EF360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroSkillDescText;
			LuaObject.checkType<Text>(l, 2, out playerHeroSkillDescText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescText = playerHeroSkillDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB71 RID: 125809 RVA: 0x009F11BC File Offset: 0x009EF3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroSkillDescTypeText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescTypeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB72 RID: 125810 RVA: 0x009F1214 File Offset: 0x009EF414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroSkillDescTypeText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroSkillDescTypeText;
			LuaObject.checkType<Text>(l, 2, out playerHeroSkillDescTypeText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescTypeText = playerHeroSkillDescTypeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB73 RID: 125811 RVA: 0x009F1270 File Offset: 0x009EF470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeroSkillDescCDText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescCDText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB74 RID: 125812 RVA: 0x009F12C8 File Offset: 0x009EF4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroSkillDescCDText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroSkillDescCDText;
			LuaObject.checkType<Text>(l, 2, out playerHeroSkillDescCDText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescCDText = playerHeroSkillDescCDText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB75 RID: 125813 RVA: 0x009F1324 File Offset: 0x009EF524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerHeroSkillDescDistanceText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescDistanceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB76 RID: 125814 RVA: 0x009F137C File Offset: 0x009EF57C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerHeroSkillDescDistanceText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroSkillDescDistanceText;
			LuaObject.checkType<Text>(l, 2, out playerHeroSkillDescDistanceText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescDistanceText = playerHeroSkillDescDistanceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB77 RID: 125815 RVA: 0x009F13D8 File Offset: 0x009EF5D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerHeroSkillDescRangeText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescRangeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB78 RID: 125816 RVA: 0x009F1430 File Offset: 0x009EF630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroSkillDescRangeText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text playerHeroSkillDescRangeText;
			LuaObject.checkType<Text>(l, 2, out playerHeroSkillDescRangeText);
			heroCommentUIController.m_luaExportHelper.m_playerHeroSkillDescRangeText = playerHeroSkillDescRangeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB79 RID: 125817 RVA: 0x009F148C File Offset: 0x009EF68C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_soldierGraphicObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB7A RID: 125818 RVA: 0x009F14E4 File Offset: 0x009EF6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			GameObject soldierGraphicObj;
			LuaObject.checkType<GameObject>(l, 2, out soldierGraphicObj);
			heroCommentUIController.m_luaExportHelper.m_soldierGraphicObj = soldierGraphicObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB7B RID: 125819 RVA: 0x009F1540 File Offset: 0x009EF740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHPValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_soldierHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB7C RID: 125820 RVA: 0x009F1598 File Offset: 0x009EF798
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierHPValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text soldierHPValueText;
			LuaObject.checkType<Text>(l, 2, out soldierHPValueText);
			heroCommentUIController.m_luaExportHelper.m_soldierHPValueText = soldierHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB7D RID: 125821 RVA: 0x009F15F4 File Offset: 0x009EF7F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierATValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_soldierATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB7E RID: 125822 RVA: 0x009F164C File Offset: 0x009EF84C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierATValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text soldierATValueText;
			LuaObject.checkType<Text>(l, 2, out soldierATValueText);
			heroCommentUIController.m_luaExportHelper.m_soldierATValueText = soldierATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB7F RID: 125823 RVA: 0x009F16A8 File Offset: 0x009EF8A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_soldierDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB80 RID: 125824 RVA: 0x009F1700 File Offset: 0x009EF900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text soldierDFValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDFValueText);
			heroCommentUIController.m_luaExportHelper.m_soldierDFValueText = soldierDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB81 RID: 125825 RVA: 0x009F175C File Offset: 0x009EF95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_soldierMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB82 RID: 125826 RVA: 0x009F17B4 File Offset: 0x009EF9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text soldierMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out soldierMagicDFValueText);
			heroCommentUIController.m_luaExportHelper.m_soldierMagicDFValueText = soldierMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB83 RID: 125827 RVA: 0x009F1810 File Offset: 0x009EFA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHPAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_soldierHPAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB84 RID: 125828 RVA: 0x009F1868 File Offset: 0x009EFA68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierHPAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text soldierHPAddText;
			LuaObject.checkType<Text>(l, 2, out soldierHPAddText);
			heroCommentUIController.m_luaExportHelper.m_soldierHPAddText = soldierHPAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB85 RID: 125829 RVA: 0x009F18C4 File Offset: 0x009EFAC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierATAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_soldierATAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB86 RID: 125830 RVA: 0x009F191C File Offset: 0x009EFB1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierATAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text soldierATAddText;
			LuaObject.checkType<Text>(l, 2, out soldierATAddText);
			heroCommentUIController.m_luaExportHelper.m_soldierATAddText = soldierATAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB87 RID: 125831 RVA: 0x009F1978 File Offset: 0x009EFB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_soldierDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB88 RID: 125832 RVA: 0x009F19D0 File Offset: 0x009EFBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text soldierDFAddText;
			LuaObject.checkType<Text>(l, 2, out soldierDFAddText);
			heroCommentUIController.m_luaExportHelper.m_soldierDFAddText = soldierDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB89 RID: 125833 RVA: 0x009F1A2C File Offset: 0x009EFC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_soldierMagicDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB8A RID: 125834 RVA: 0x009F1A84 File Offset: 0x009EFC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Text soldierMagicDFAddText;
			LuaObject.checkType<Text>(l, 2, out soldierMagicDFAddText);
			heroCommentUIController.m_luaExportHelper.m_soldierMagicDFAddText = soldierMagicDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB8B RID: 125835 RVA: 0x009F1AE0 File Offset: 0x009EFCE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB8C RID: 125836 RVA: 0x009F1B38 File Offset: 0x009EFD38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroCommentUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB8D RID: 125837 RVA: 0x009F1B94 File Offset: 0x009EFD94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB8E RID: 125838 RVA: 0x009F1BEC File Offset: 0x009EFDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroCommentUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB8F RID: 125839 RVA: 0x009F1C48 File Offset: 0x009EFE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB90 RID: 125840 RVA: 0x009F1CA0 File Offset: 0x009EFEA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroCommentUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB91 RID: 125841 RVA: 0x009F1CFC File Offset: 0x009EFEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierInfoGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_soldierInfoGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB92 RID: 125842 RVA: 0x009F1D54 File Offset: 0x009EFF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierInfoGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierInfoGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierInfoGraphic);
			heroCommentUIController.m_luaExportHelper.m_soldierInfoGraphic = soldierInfoGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB93 RID: 125843 RVA: 0x009F1DB0 File Offset: 0x009EFFB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_heroCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB94 RID: 125844 RVA: 0x009F1E08 File Offset: 0x009F0008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			HeroCharUIController heroCharUIController;
			LuaObject.checkType<HeroCharUIController>(l, 2, out heroCharUIController);
			heroCommentUIController.m_luaExportHelper.m_heroCharUIController = heroCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB95 RID: 125845 RVA: 0x009F1E64 File Offset: 0x009F0064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curToggleState(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)heroCommentUIController.m_luaExportHelper.m_curToggleState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB96 RID: 125846 RVA: 0x009F1EBC File Offset: 0x009F00BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_curToggleState(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			HeroCommentUIController.ToggleState curToggleState;
			LuaObject.checkEnum<HeroCommentUIController.ToggleState>(l, 2, out curToggleState);
			heroCommentUIController.m_luaExportHelper.m_curToggleState = curToggleState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB97 RID: 125847 RVA: 0x009F1F18 File Offset: 0x009F0118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_curShowedNormalCommentCount(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUIController.m_luaExportHelper.m_curShowedNormalCommentCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB98 RID: 125848 RVA: 0x009F1F70 File Offset: 0x009F0170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curShowedNormalCommentCount(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUIController heroCommentUIController = (HeroCommentUIController)LuaObject.checkSelf(l);
			int curShowedNormalCommentCount;
			LuaObject.checkType(l, 2, out curShowedNormalCommentCount);
			heroCommentUIController.m_luaExportHelper.m_curShowedNormalCommentCount = curShowedNormalCommentCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB99 RID: 125849 RVA: 0x009F1FCC File Offset: 0x009F01CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroCommentUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.HeroCommentUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.UpdateRankingListLock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.UpdateRankingList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.ShowPlayerHeroDetailPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.CreateComments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.GetNormalCommentsInAllComments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.CommentComparerByTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.CommentComparerByPraisedNum);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.GetCommentsWithCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.CreateCommentByList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.OnSkillItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.SetSkillDescPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.SetSoldierPropAddText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.ClosePlayerHeroDetailPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.OnCommentItemNameClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.OnCommentItemPraisedBtnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.OnMoreCommentButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.OnAllCommentToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.OnHotCommentToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.OnRankingListCommentToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.OnRankingListLockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.OnCommentSendButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.ResetScrollViewToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callDele_EventOnCommentSend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__clearDele_EventOnCommentSend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callDele_EventOnNameClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__clearDele_EventOnNameClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callDele_EventOnPraisedBtnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__clearDele_EventOnPraisedBtnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callDele_EventOnGetHeroComments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__clearDele_EventOnGetHeroComments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callDele_EventOnRankingQurey);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__clearDele_EventOnRankingQurey);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__callDele_EventOnRankingListLockClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.__clearDele_EventOnRankingListLockClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache36);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache37, true);
		string name2 = "EventOnCommentSend";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_EventOnCommentSend);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache38, true);
		string name3 = "EventOnNameClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_EventOnNameClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache39, true);
		string name4 = "EventOnPraisedBtnClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_EventOnPraisedBtnClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3A, true);
		string name5 = "EventOnGetHeroComments";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_EventOnGetHeroComments);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3B, true);
		string name6 = "EventOnRankingQurey";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_EventOnRankingQurey);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3C, true);
		string name7 = "EventOnRankingListLockClick";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_EventOnRankingListLockClick);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3D, true);
		string name8 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_stateCtrl);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache3F, true);
		string name9 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_returnButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache41, true);
		string name10 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_marginTransform);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache43, true);
		string name11 = "m_commentNormalToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commentNormalToggle);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commentNormalToggle);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache45, true);
		string name12 = "m_commentNormalToggleUnClick";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commentNormalToggleUnClick);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commentNormalToggleUnClick);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache47, true);
		string name13 = "m_commentNormalToggleClick";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commentNormalToggleClick);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commentNormalToggleClick);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache49, true);
		string name14 = "m_commentHotToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commentHotToggle);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commentHotToggle);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4B, true);
		string name15 = "m_commentHotToggleUnClick";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commentHotToggleUnClick);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commentHotToggleUnClick);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4D, true);
		string name16 = "m_commentHotToggleClick";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commentHotToggleClick);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commentHotToggleClick);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache4F, true);
		string name17 = "m_commentRankingToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commentRankingToggle);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commentRankingToggle);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache51, true);
		string name18 = "m_commnetRankingUnClick";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commnetRankingUnClick);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commnetRankingUnClick);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache53, true);
		string name19 = "m_commnetRankingClick";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commnetRankingClick);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commnetRankingClick);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache55, true);
		string name20 = "m_rankingListLockButton";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_rankingListLockButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_rankingListLockButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache57, true);
		string name21 = "m_noCommentPanelObj";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_noCommentPanelObj);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_noCommentPanelObj);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache59, true);
		string name22 = "m_hotCommentListObj";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_hotCommentListObj);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_hotCommentListObj);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5B, true);
		string name23 = "m_normalCommentListObj";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_normalCommentListObj);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_normalCommentListObj);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5D, true);
		string name24 = "m_moreCommentTextObj";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_moreCommentTextObj);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_moreCommentTextObj);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache5F, true);
		string name25 = "m_commentListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commentListScrollRect);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commentListScrollRect);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache61, true);
		string name26 = "m_inputCommentGo";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_inputCommentGo);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_inputCommentGo);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache63, true);
		string name27 = "m_commentInputField";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commentInputField);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commentInputField);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache65, true);
		string name28 = "m_commentSendButton";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commentSendButton);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commentSendButton);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache67, true);
		string name29 = "m_commentItemPrefabObj";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_commentItemPrefabObj);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_commentItemPrefabObj);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache69, true);
		string name30 = "m_moreCommentButton";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_moreCommentButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_moreCommentButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6B, true);
		string name31 = "m_rankingListGroup";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_rankingListGroup);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_rankingListGroup);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6D, true);
		string name32 = "m_rankingListUICtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_rankingListUICtrl);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_rankingListUICtrl);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache6F, true);
		string name33 = "m_playerHeroDetailPanelObj";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroDetailPanelObj);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroDetailPanelObj);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache71, true);
		string name34 = "m_playerHeroDetailCloseImage";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroDetailCloseImage);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroDetailCloseImage);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache73, true);
		string name35 = "m_playerHeroDetailCloseBtn";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroDetailCloseBtn);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroDetailCloseBtn);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache75, true);
		string name36 = "m_playerHeroLvStarsObj";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroLvStarsObj);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroLvStarsObj);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache77, true);
		string name37 = "m_playerHeroJobNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroJobNameText);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroJobNameText);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache79, true);
		string name38 = "m_playerHeroJobLvStarsObj";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroJobLvStarsObj);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroJobLvStarsObj);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7B, true);
		string name39 = "m_playerHeroJobMasterImg";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroJobMasterImg);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroJobMasterImg);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7D, true);
		string name40 = "m_playerHeroHalfBodyImage";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroHalfBodyImage);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroHalfBodyImage);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache7F, true);
		string name41 = "m_playerHeroPropHPImg";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropHPImg);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropHPImg);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache81, true);
		string name42 = "m_playerHeroPropDFImg";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropDFImg);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropDFImg);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache83, true);
		string name43 = "m_playerHeroPropATImg";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropATImg);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropATImg);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache85, true);
		string name44 = "m_playerHeroPropMagicDFImg";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropMagicDFImg);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropMagicDFImg);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache87, true);
		string name45 = "m_playerHeroPropMagicImg";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropMagicImg);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropMagicImg);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache89, true);
		string name46 = "m_playerHeroPropDEXImg";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropDEXImg);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropDEXImg);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8B, true);
		string name47 = "m_playerHeroPropHPValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropHPValueText);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropHPValueText);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8D, true);
		string name48 = "m_playerHeroPropDFValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropDFValueText);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropDFValueText);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache8F, true);
		string name49 = "m_playerHeroPropATValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropATValueText);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropATValueText);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache91, true);
		string name50 = "m_playerHeroPropMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropMagicDFValueText);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropMagicDFValueText);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache93, true);
		string name51 = "m_playerHeroPropMagicValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropMagicValueText);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropMagicValueText);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache95, true);
		string name52 = "m_playerHeroPropDEXValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropDEXValueText);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropDEXValueText);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache97, true);
		string name53 = "m_playerHeroPropHPAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropHPAddText);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropHPAddText);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache99, true);
		string name54 = "m_playerHeroPropDFAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropDFAddText);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropDFAddText);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9B, true);
		string name55 = "m_playerHeroPropATAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropATAddText);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropATAddText);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9D, true);
		string name56 = "m_playerHeroPropMagicDFAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropMagicDFAddText);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropMagicDFAddText);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cache9F, true);
		string name57 = "m_playerHeroPropMagicAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropMagicAddText);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropMagicAddText);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA1, true);
		string name58 = "m_playerHeroPropDEXAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroPropDEXAddText);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroPropDEXAddText);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA3, true);
		string name59 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerNameText);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA5, true);
		string name60 = "m_playerHeroLvValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroLvValueText);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroLvValueText);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA7, true);
		string name61 = "m_playerHeroNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroNameText);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroNameText);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheA9, true);
		string name62 = "m_playerHeroSoldierIconImg";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroSoldierIconImg);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroSoldierIconImg);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAB, true);
		string name63 = "m_playerHeroEquipments1";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroEquipments1);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroEquipments1);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAD, true);
		string name64 = "m_playerHeroEquipments2";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroEquipments2);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroEquipments2);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheAF, true);
		string name65 = "m_playerHeroEquipments3";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroEquipments3);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroEquipments3);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB1, true);
		string name66 = "m_playerHeroEquipments4";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroEquipments4);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroEquipments4);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB3, true);
		string name67 = "m_playerHeroTalentIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroTalentIcon);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroTalentIcon);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB5, true);
		string name68 = "m_playerHeroSkillIcon1";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroSkillIcon1);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroSkillIcon1);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB7, true);
		string name69 = "m_playerHeroSkillIcon2";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroSkillIcon2);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroSkillIcon2);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheB9, true);
		string name70 = "m_playerHeroSkillIcon3";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroSkillIcon3);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroSkillIcon3);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBB, true);
		string name71 = "m_playerHeroSkillDescObj";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroSkillDescObj);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroSkillDescObj);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBD, true);
		string name72 = "m_playerHeroSkillDescNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroSkillDescNameText);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroSkillDescNameText);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheBF, true);
		string name73 = "m_playerHeroSkillDescCostObj";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroSkillDescCostObj);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroSkillDescCostObj);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC1, true);
		string name74 = "m_playerHeroSkillDescText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroSkillDescText);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroSkillDescText);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC3, true);
		string name75 = "m_playerHeroSkillDescTypeText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroSkillDescTypeText);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroSkillDescTypeText);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC5, true);
		string name76 = "m_playerHeroSkillDescCDText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroSkillDescCDText);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC6;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroSkillDescCDText);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC7, true);
		string name77 = "m_playerHeroSkillDescDistanceText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroSkillDescDistanceText);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC8;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroSkillDescDistanceText);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheC9, true);
		string name78 = "m_playerHeroSkillDescRangeText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerHeroSkillDescRangeText);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCA;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerHeroSkillDescRangeText);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCB, true);
		string name79 = "m_soldierGraphicObj";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_soldierGraphicObj);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCC;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_soldierGraphicObj);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCD, true);
		string name80 = "m_soldierHPValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_soldierHPValueText);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCE;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_soldierHPValueText);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheCF, true);
		string name81 = "m_soldierATValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_soldierATValueText);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_soldierATValueText);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD1, true);
		string name82 = "m_soldierDFValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_soldierDFValueText);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD2;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_soldierDFValueText);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD3, true);
		string name83 = "m_soldierMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_soldierMagicDFValueText);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD4;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_soldierMagicDFValueText);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD5, true);
		string name84 = "m_soldierHPAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_soldierHPAddText);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD6;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_soldierHPAddText);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD7, true);
		string name85 = "m_soldierATAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_soldierATAddText);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD8;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_soldierATAddText);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheD9, true);
		string name86 = "m_soldierDFAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_soldierDFAddText);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDA;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_soldierDFAddText);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDB, true);
		string name87 = "m_soldierMagicDFAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_soldierMagicDFAddText);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDC;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_soldierMagicDFAddText);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDD, true);
		string name88 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_playerContext);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDE;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheDF, true);
		string name89 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_configDataLoader);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE0;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE1, true);
		string name90 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_hero);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE2;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_hero);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE3, true);
		string name91 = "m_soldierInfoGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_soldierInfoGraphic);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE4;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_soldierInfoGraphic);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE5, true);
		string name92 = "m_heroCharUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_heroCharUIController);
		}
		LuaCSFunction get92 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE6;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_heroCharUIController);
		}
		LuaObject.addMember(l, name92, get92, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE7, true);
		string name93 = "m_curToggleState";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_curToggleState);
		}
		LuaCSFunction get93 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE8;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_curToggleState);
		}
		LuaObject.addMember(l, name93, get93, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheE9, true);
		string name94 = "m_curShowedNormalCommentCount";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.get_m_curShowedNormalCommentCount);
		}
		LuaCSFunction get94 = Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheEA;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.set_m_curShowedNormalCommentCount);
		}
		LuaObject.addMember(l, name94, get94, Lua_BlackJack_ProjectL_UI_HeroCommentUIController.<>f__mg$cacheEB, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroCommentUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014B35 RID: 84789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014B36 RID: 84790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014B37 RID: 84791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014B38 RID: 84792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014B39 RID: 84793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014B3A RID: 84794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014B3B RID: 84795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014B3C RID: 84796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014B3D RID: 84797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014B3E RID: 84798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014B3F RID: 84799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014B40 RID: 84800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014B41 RID: 84801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014B42 RID: 84802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014B43 RID: 84803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014B44 RID: 84804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014B45 RID: 84805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014B46 RID: 84806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014B47 RID: 84807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014B48 RID: 84808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014B49 RID: 84809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014B4A RID: 84810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014B4B RID: 84811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014B4C RID: 84812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014B4D RID: 84813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014B4E RID: 84814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014B4F RID: 84815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014B50 RID: 84816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014B51 RID: 84817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014B52 RID: 84818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014B53 RID: 84819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014B54 RID: 84820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014B55 RID: 84821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014B56 RID: 84822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014B57 RID: 84823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014B58 RID: 84824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014B59 RID: 84825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014B5A RID: 84826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014B5B RID: 84827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014B5C RID: 84828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014B5D RID: 84829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014B5E RID: 84830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014B5F RID: 84831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014B60 RID: 84832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014B61 RID: 84833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014B62 RID: 84834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014B63 RID: 84835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014B64 RID: 84836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014B65 RID: 84837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014B66 RID: 84838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014B67 RID: 84839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014B68 RID: 84840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014B69 RID: 84841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014B6A RID: 84842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014B6B RID: 84843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014B6C RID: 84844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014B6D RID: 84845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014B6E RID: 84846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014B6F RID: 84847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014B70 RID: 84848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04014B71 RID: 84849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04014B72 RID: 84850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04014B73 RID: 84851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04014B74 RID: 84852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04014B75 RID: 84853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04014B76 RID: 84854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014B77 RID: 84855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014B78 RID: 84856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014B79 RID: 84857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04014B7A RID: 84858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04014B7B RID: 84859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04014B7C RID: 84860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04014B7D RID: 84861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04014B7E RID: 84862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04014B7F RID: 84863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04014B80 RID: 84864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04014B81 RID: 84865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04014B82 RID: 84866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04014B83 RID: 84867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04014B84 RID: 84868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04014B85 RID: 84869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04014B86 RID: 84870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04014B87 RID: 84871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04014B88 RID: 84872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04014B89 RID: 84873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04014B8A RID: 84874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04014B8B RID: 84875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04014B8C RID: 84876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04014B8D RID: 84877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04014B8E RID: 84878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04014B8F RID: 84879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04014B90 RID: 84880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04014B91 RID: 84881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04014B92 RID: 84882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04014B93 RID: 84883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04014B94 RID: 84884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04014B95 RID: 84885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04014B96 RID: 84886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04014B97 RID: 84887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04014B98 RID: 84888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04014B99 RID: 84889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04014B9A RID: 84890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04014B9B RID: 84891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04014B9C RID: 84892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04014B9D RID: 84893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04014B9E RID: 84894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04014B9F RID: 84895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04014BA0 RID: 84896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04014BA1 RID: 84897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04014BA2 RID: 84898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04014BA3 RID: 84899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04014BA4 RID: 84900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04014BA5 RID: 84901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04014BA6 RID: 84902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04014BA7 RID: 84903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04014BA8 RID: 84904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04014BA9 RID: 84905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04014BAA RID: 84906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04014BAB RID: 84907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04014BAC RID: 84908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04014BAD RID: 84909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04014BAE RID: 84910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04014BAF RID: 84911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04014BB0 RID: 84912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04014BB1 RID: 84913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04014BB2 RID: 84914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04014BB3 RID: 84915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04014BB4 RID: 84916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04014BB5 RID: 84917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04014BB6 RID: 84918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04014BB7 RID: 84919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04014BB8 RID: 84920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04014BB9 RID: 84921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04014BBA RID: 84922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04014BBB RID: 84923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04014BBC RID: 84924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04014BBD RID: 84925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04014BBE RID: 84926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04014BBF RID: 84927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04014BC0 RID: 84928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04014BC1 RID: 84929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04014BC2 RID: 84930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04014BC3 RID: 84931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04014BC4 RID: 84932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04014BC5 RID: 84933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04014BC6 RID: 84934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04014BC7 RID: 84935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04014BC8 RID: 84936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04014BC9 RID: 84937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04014BCA RID: 84938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04014BCB RID: 84939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04014BCC RID: 84940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04014BCD RID: 84941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04014BCE RID: 84942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04014BCF RID: 84943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04014BD0 RID: 84944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04014BD1 RID: 84945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04014BD2 RID: 84946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04014BD3 RID: 84947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04014BD4 RID: 84948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04014BD5 RID: 84949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04014BD6 RID: 84950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04014BD7 RID: 84951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04014BD8 RID: 84952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04014BD9 RID: 84953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04014BDA RID: 84954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04014BDB RID: 84955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04014BDC RID: 84956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04014BDD RID: 84957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04014BDE RID: 84958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04014BDF RID: 84959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04014BE0 RID: 84960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04014BE1 RID: 84961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04014BE2 RID: 84962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04014BE3 RID: 84963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04014BE4 RID: 84964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04014BE5 RID: 84965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04014BE6 RID: 84966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04014BE7 RID: 84967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04014BE8 RID: 84968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04014BE9 RID: 84969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04014BEA RID: 84970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04014BEB RID: 84971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04014BEC RID: 84972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x04014BED RID: 84973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x04014BEE RID: 84974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x04014BEF RID: 84975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x04014BF0 RID: 84976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x04014BF1 RID: 84977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x04014BF2 RID: 84978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x04014BF3 RID: 84979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x04014BF4 RID: 84980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x04014BF5 RID: 84981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04014BF6 RID: 84982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04014BF7 RID: 84983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04014BF8 RID: 84984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04014BF9 RID: 84985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x04014BFA RID: 84986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x04014BFB RID: 84987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x04014BFC RID: 84988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x04014BFD RID: 84989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x04014BFE RID: 84990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04014BFF RID: 84991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x04014C00 RID: 84992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x04014C01 RID: 84993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x04014C02 RID: 84994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x04014C03 RID: 84995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x04014C04 RID: 84996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x04014C05 RID: 84997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04014C06 RID: 84998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04014C07 RID: 84999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04014C08 RID: 85000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x04014C09 RID: 85001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x04014C0A RID: 85002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04014C0B RID: 85003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x04014C0C RID: 85004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x04014C0D RID: 85005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04014C0E RID: 85006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04014C0F RID: 85007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x04014C10 RID: 85008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x04014C11 RID: 85009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x04014C12 RID: 85010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x04014C13 RID: 85011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x04014C14 RID: 85012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x04014C15 RID: 85013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x04014C16 RID: 85014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x04014C17 RID: 85015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x04014C18 RID: 85016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x04014C19 RID: 85017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x04014C1A RID: 85018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x04014C1B RID: 85019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x04014C1C RID: 85020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x04014C1D RID: 85021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x04014C1E RID: 85022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x04014C1F RID: 85023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x04014C20 RID: 85024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;
}
