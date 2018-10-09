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
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200156F RID: 5487
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SelectCardUIController : LuaObject
{
	// Token: 0x06020E65 RID: 134757 RVA: 0x00B09870 File Offset: 0x00B07A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInSelectCard(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			selectCardUIController.UpdateViewInSelectCard(cardPoolId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E66 RID: 134758 RVA: 0x00B098C8 File Offset: 0x00B07AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateSharePlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.UpdateSharePlayerInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E67 RID: 134759 RVA: 0x00B09914 File Offset: 0x00B07B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E68 RID: 134760 RVA: 0x00B09960 File Offset: 0x00B07B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetShareTenSelectCardUIController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			ShareTenSelectCardUIController shareTenSelectCardUIController;
			LuaObject.checkType<ShareTenSelectCardUIController>(l, 2, out shareTenSelectCardUIController);
			selectCardUIController.SetShareTenSelectCardUIController(shareTenSelectCardUIController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E69 RID: 134761 RVA: 0x00B099B8 File Offset: 0x00B07BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectCardRewards(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			SelectCardBackground3DController selectCardBackground3DController;
			LuaObject.checkType<SelectCardBackground3DController>(l, 3, out selectCardBackground3DController);
			selectCardUIController.ShowSelectCardRewards(rewards, selectCardBackground3DController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E6A RID: 134762 RVA: 0x00B09A1C File Offset: 0x00B07C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseTenSelectPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			selectCardUIController.CloseTenSelectPanel(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E6B RID: 134763 RVA: 0x00B09A74 File Offset: 0x00B07C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsShowSelectCardResult(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			bool b = selectCardUIController.IsShowSelectCardResult();
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

	// Token: 0x06020E6C RID: 134764 RVA: 0x00B09AC8 File Offset: 0x00B07CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E6D RID: 134765 RVA: 0x00B09B1C File Offset: 0x00B07D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayRewardsEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			IEnumerator o = selectCardUIController.m_luaExportHelper.PlayRewardsEffect(rewards);
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

	// Token: 0x06020E6E RID: 134766 RVA: 0x00B09B84 File Offset: 0x00B07D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaySingleRewardEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Goods goods;
			LuaObject.checkType<Goods>(l, 2, out goods);
			bool isNeedClockEffect;
			LuaObject.checkType(l, 3, out isNeedClockEffect);
			int rank;
			LuaObject.checkType(l, 4, out rank);
			int maxRank;
			LuaObject.checkType(l, 5, out maxRank);
			int index;
			LuaObject.checkType(l, 6, out index);
			IEnumerator o = selectCardUIController.m_luaExportHelper.PlaySingleRewardEffect(goods, isNeedClockEffect, rank, maxRank, index);
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

	// Token: 0x06020E6F RID: 134767 RVA: 0x00B09C20 File Offset: 0x00B07E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopClockEffectSoundOnSkipButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.StopClockEffectSoundOnSkipButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E70 RID: 134768 RVA: 0x00B09C74 File Offset: 0x00B07E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AfterShowClockEffectFinished(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Goods goods;
			LuaObject.checkType<Goods>(l, 2, out goods);
			int index;
			LuaObject.checkType(l, 3, out index);
			int rank;
			LuaObject.checkType(l, 4, out rank);
			IEnumerator o = selectCardUIController.m_luaExportHelper.AfterShowClockEffectFinished(goods, index, rank);
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

	// Token: 0x06020E71 RID: 134769 RVA: 0x00B09CF8 File Offset: 0x00B07EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClockButtonDrag(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			selectCardUIController.m_luaExportHelper.OnClockButtonDrag(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E72 RID: 134770 RVA: 0x00B09D54 File Offset: 0x00B07F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnContinueButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnContinueButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E73 RID: 134771 RVA: 0x00B09DA8 File Offset: 0x00B07FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayTotalRewardsEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			IEnumerator o = selectCardUIController.m_luaExportHelper.PlayTotalRewardsEffect();
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

	// Token: 0x06020E74 RID: 134772 RVA: 0x00B09E04 File Offset: 0x00B08004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAfterSelectCurrecyPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.SetAfterSelectCurrecyPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E75 RID: 134773 RVA: 0x00B09E58 File Offset: 0x00B08058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSingleSelectRewardInfo(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Goods goods;
			LuaObject.checkType<Goods>(l, 2, out goods);
			int index;
			LuaObject.checkType(l, 3, out index);
			int rank;
			LuaObject.checkType(l, 4, out rank);
			selectCardUIController.m_luaExportHelper.SetSingleSelectRewardInfo(goods, index, rank);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E76 RID: 134774 RVA: 0x00B09ED0 File Offset: 0x00B080D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTenSelectRewardsInfo(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			List<Goods> tenSelectRewardsInfo;
			LuaObject.checkType<List<Goods>>(l, 2, out tenSelectRewardsInfo);
			selectCardUIController.m_luaExportHelper.SetTenSelectRewardsInfo(tenSelectRewardsInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E77 RID: 134775 RVA: 0x00B09F2C File Offset: 0x00B0812C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateCardPoolTabs(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.CreateCardPoolTabs();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E78 RID: 134776 RVA: 0x00B09F80 File Offset: 0x00B08180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SummonToggleCtrl_EventOnToggleClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			SummonToggleUIController ctrl;
			LuaObject.checkType<SummonToggleUIController>(l, 2, out ctrl);
			selectCardUIController.m_luaExportHelper.SummonToggleCtrl_EventOnToggleClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E79 RID: 134777 RVA: 0x00B09FDC File Offset: 0x00B081DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetValuesAfterToggleChanged(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.SetValuesAfterToggleChanged();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E7A RID: 134778 RVA: 0x00B0A030 File Offset: 0x00B08230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelectButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			Text titleText;
			LuaObject.checkType<Text>(l, 3, out titleText);
			Text numText;
			LuaObject.checkType<Text>(l, 4, out numText);
			bool isSingle;
			LuaObject.checkType(l, 5, out isSingle);
			selectCardUIController.m_luaExportHelper.SetSelectButton(iconImage, titleText, numText, isSingle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E7B RID: 134779 RVA: 0x00B0A0B4 File Offset: 0x00B082B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActivityDetailButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnActivityDetailButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E7C RID: 134780 RVA: 0x00B0A108 File Offset: 0x00B08308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSingleSelectButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnSingleSelectButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E7D RID: 134781 RVA: 0x00B0A15C File Offset: 0x00B0835C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTenSelectButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnTenSelectButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E7E RID: 134782 RVA: 0x00B0A1B0 File Offset: 0x00B083B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelectAgainButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnSelectAgainButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E7F RID: 134783 RVA: 0x00B0A204 File Offset: 0x00B08404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowChangeCrystalToTicketPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.ShowChangeCrystalToTicketPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E80 RID: 134784 RVA: 0x00B0A258 File Offset: 0x00B08458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChangeCrystalToTicketPanelCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.ChangeCrystalToTicketPanelCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E81 RID: 134785 RVA: 0x00B0A2AC File Offset: 0x00B084AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseChangeCrystalToTicketPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.CloseChangeCrystalToTicketPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E82 RID: 134786 RVA: 0x00B0A300 File Offset: 0x00B08500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChangeCrystalToTicketPanelConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.ChangeCrystalToTicketPanelConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E83 RID: 134787 RVA: 0x00B0A354 File Offset: 0x00B08554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCrystalAndTicketNotEnoughPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.ShowCrystalAndTicketNotEnoughPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E84 RID: 134788 RVA: 0x00B0A3A8 File Offset: 0x00B085A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CrystalAndTicketNotEnoughPanelCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.CrystalAndTicketNotEnoughPanelCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E85 RID: 134789 RVA: 0x00B0A3FC File Offset: 0x00B085FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseCrystalAndTicketNotEnoughPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.CloseCrystalAndTicketNotEnoughPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E86 RID: 134790 RVA: 0x00B0A450 File Offset: 0x00B08650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CrystalAndTicketNotEnoughPanelConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.CrystalAndTicketNotEnoughPanelConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E87 RID: 134791 RVA: 0x00B0A4A4 File Offset: 0x00B086A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBuyDiamondButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnBuyDiamondButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E88 RID: 134792 RVA: 0x00B0A4F8 File Offset: 0x00B086F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddCrystalBtnClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnAddCrystalBtnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E89 RID: 134793 RVA: 0x00B0A54C File Offset: 0x00B0874C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E8A RID: 134794 RVA: 0x00B0A5A0 File Offset: 0x00B087A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkipShowRewardEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.SkipShowRewardEffect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E8B RID: 134795 RVA: 0x00B0A5F4 File Offset: 0x00B087F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close3DUIEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.Close3DUIEffect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E8C RID: 134796 RVA: 0x00B0A648 File Offset: 0x00B08848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseShowSelectRewardsPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.CloseShowSelectRewardsPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E8D RID: 134797 RVA: 0x00B0A69C File Offset: 0x00B0889C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDetailScrollView(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.ShowDetailScrollView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E8E RID: 134798 RVA: 0x00B0A6F0 File Offset: 0x00B088F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreatePoolItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			PoolContentItemData item;
			LuaObject.checkType<PoolContentItemData>(l, 2, out item);
			selectCardUIController.m_luaExportHelper.CreatePoolItemPrefab(item);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E8F RID: 134799 RVA: 0x00B0A74C File Offset: 0x00B0894C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDetailButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnDetailButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E90 RID: 134800 RVA: 0x00B0A7A0 File Offset: 0x00B089A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseDetailPanelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnCloseDetailPanelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E91 RID: 134801 RVA: 0x00B0A7F4 File Offset: 0x00B089F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnArchiveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnArchiveButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E92 RID: 134802 RVA: 0x00B0A848 File Offset: 0x00B08A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E93 RID: 134803 RVA: 0x00B0A89C File Offset: 0x00B08A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWeiBoShareOnceClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnWeiBoShareOnceClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E94 RID: 134804 RVA: 0x00B0A8F0 File Offset: 0x00B08AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWeChatShareOnceClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnWeChatShareOnceClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E95 RID: 134805 RVA: 0x00B0A944 File Offset: 0x00B08B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWeiBoShareTenClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnWeiBoShareTenClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E96 RID: 134806 RVA: 0x00B0A998 File Offset: 0x00B08B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWeChatShareTenClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.OnWeChatShareTenClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E97 RID: 134807 RVA: 0x00B0A9EC File Offset: 0x00B08BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CaptureOnceFrame(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			int sharePlatform;
			LuaObject.checkType(l, 2, out sharePlatform);
			IEnumerator o = selectCardUIController.m_luaExportHelper.CaptureOnceFrame(sharePlatform);
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

	// Token: 0x06020E98 RID: 134808 RVA: 0x00B0AA54 File Offset: 0x00B08C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CaptureTenFrame(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			int sharePlatform;
			LuaObject.checkType(l, 2, out sharePlatform);
			IEnumerator o = selectCardUIController.m_luaExportHelper.CaptureTenFrame(sharePlatform);
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

	// Token: 0x06020E99 RID: 134809 RVA: 0x00B0AABC File Offset: 0x00B08CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			selectCardUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E9A RID: 134810 RVA: 0x00B0AB28 File Offset: 0x00B08D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E9B RID: 134811 RVA: 0x00B0AB7C File Offset: 0x00B08D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E9C RID: 134812 RVA: 0x00B0ABD0 File Offset: 0x00B08DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = selectCardUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020E9D RID: 134813 RVA: 0x00B0AC78 File Offset: 0x00B08E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E9E RID: 134814 RVA: 0x00B0ACCC File Offset: 0x00B08ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			selectCardUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E9F RID: 134815 RVA: 0x00B0AD38 File Offset: 0x00B08F38
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
				SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				selectCardUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				SelectCardUIController selectCardUIController2 = (SelectCardUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				selectCardUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020EA0 RID: 134816 RVA: 0x00B0AE48 File Offset: 0x00B09048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			selectCardUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EA1 RID: 134817 RVA: 0x00B0AEB4 File Offset: 0x00B090B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			selectCardUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EA2 RID: 134818 RVA: 0x00B0AF20 File Offset: 0x00B09120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			selectCardUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EA3 RID: 134819 RVA: 0x00B0AF8C File Offset: 0x00B0918C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			selectCardUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EA4 RID: 134820 RVA: 0x00B0AFF8 File Offset: 0x00B091F8
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
				SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				selectCardUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				SelectCardUIController selectCardUIController2 = (SelectCardUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				selectCardUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020EA5 RID: 134821 RVA: 0x00B0B108 File Offset: 0x00B09308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			string s = selectCardUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020EA6 RID: 134822 RVA: 0x00B0B164 File Offset: 0x00B09364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnWeiBoShareTen(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__callDele_EventOnWeiBoShareTen();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EA7 RID: 134823 RVA: 0x00B0B1B8 File Offset: 0x00B093B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnWeiBoShareTen(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__clearDele_EventOnWeiBoShareTen();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EA8 RID: 134824 RVA: 0x00B0B20C File Offset: 0x00B0940C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnWeChatShareTen(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__callDele_EventOnWeChatShareTen();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EA9 RID: 134825 RVA: 0x00B0B260 File Offset: 0x00B09460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnWeChatShareTen(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__clearDele_EventOnWeChatShareTen();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EAA RID: 134826 RVA: 0x00B0B2B4 File Offset: 0x00B094B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnArchive(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__callDele_EventOnArchive();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EAB RID: 134827 RVA: 0x00B0B308 File Offset: 0x00B09508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnArchive(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__clearDele_EventOnArchive();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EAC RID: 134828 RVA: 0x00B0B35C File Offset: 0x00B0955C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EAD RID: 134829 RVA: 0x00B0B3B0 File Offset: 0x00B095B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EAE RID: 134830 RVA: 0x00B0B404 File Offset: 0x00B09604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectCard(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			selectCardUIController.m_luaExportHelper.__callDele_EventOnSelectCard(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EAF RID: 134831 RVA: 0x00B0B470 File Offset: 0x00B09670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectCard(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			selectCardUIController.m_luaExportHelper.__clearDele_EventOnSelectCard(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EB0 RID: 134832 RVA: 0x00B0B4DC File Offset: 0x00B096DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowSelectCardHelp(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__callDele_EventOnShowSelectCardHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EB1 RID: 134833 RVA: 0x00B0B530 File Offset: 0x00B09730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowSelectCardHelp(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__clearDele_EventOnShowSelectCardHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EB2 RID: 134834 RVA: 0x00B0B584 File Offset: 0x00B09784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowActivityDetail(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			CardPool obj;
			LuaObject.checkType<CardPool>(l, 2, out obj);
			selectCardUIController.m_luaExportHelper.__callDele_EventOnShowActivityDetail(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EB3 RID: 134835 RVA: 0x00B0B5E0 File Offset: 0x00B097E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowActivityDetail(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			CardPool obj;
			LuaObject.checkType<CardPool>(l, 2, out obj);
			selectCardUIController.m_luaExportHelper.__clearDele_EventOnShowActivityDetail(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EB4 RID: 134836 RVA: 0x00B0B63C File Offset: 0x00B0983C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBagCapcityNotEnough(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__callDele_EventOnBagCapcityNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EB5 RID: 134837 RVA: 0x00B0B690 File Offset: 0x00B09890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBagCapcityNotEnough(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__clearDele_EventOnBagCapcityNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EB6 RID: 134838 RVA: 0x00B0B6E4 File Offset: 0x00B098E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__callDele_EventOnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EB7 RID: 134839 RVA: 0x00B0B738 File Offset: 0x00B09938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__clearDele_EventOnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EB8 RID: 134840 RVA: 0x00B0B78C File Offset: 0x00B0998C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__callDele_EventOnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EB9 RID: 134841 RVA: 0x00B0B7E0 File Offset: 0x00B099E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			selectCardUIController.m_luaExportHelper.__clearDele_EventOnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EBA RID: 134842 RVA: 0x00B0B834 File Offset: 0x00B09A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EBB RID: 134843 RVA: 0x00B0B88C File Offset: 0x00B09A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			selectCardUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EBC RID: 134844 RVA: 0x00B0B8E8 File Offset: 0x00B09AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mainUIGo(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_mainUIGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EBD RID: 134845 RVA: 0x00B0B940 File Offset: 0x00B09B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mainUIGo(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject mainUIGo;
			LuaObject.checkType<GameObject>(l, 2, out mainUIGo);
			selectCardUIController.m_luaExportHelper.m_mainUIGo = mainUIGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EBE RID: 134846 RVA: 0x00B0B99C File Offset: 0x00B09B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_normalCardNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_normalCardNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EBF RID: 134847 RVA: 0x00B0B9F4 File Offset: 0x00B09BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_normalCardNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text normalCardNumText;
			LuaObject.checkType<Text>(l, 2, out normalCardNumText);
			selectCardUIController.m_luaExportHelper.m_normalCardNumText = normalCardNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EC0 RID: 134848 RVA: 0x00B0BA50 File Offset: 0x00B09C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_diamondsCardNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_diamondsCardNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EC1 RID: 134849 RVA: 0x00B0BAA8 File Offset: 0x00B09CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_diamondsCardNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text diamondsCardNumText;
			LuaObject.checkType<Text>(l, 2, out diamondsCardNumText);
			selectCardUIController.m_luaExportHelper.m_diamondsCardNumText = diamondsCardNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EC2 RID: 134850 RVA: 0x00B0BB04 File Offset: 0x00B09D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_diamondsAddBtn(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_diamondsAddBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EC3 RID: 134851 RVA: 0x00B0BB5C File Offset: 0x00B09D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_diamondsAddBtn(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button diamondsAddBtn;
			LuaObject.checkType<Button>(l, 2, out diamondsAddBtn);
			selectCardUIController.m_luaExportHelper.m_diamondsAddBtn = diamondsAddBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EC4 RID: 134852 RVA: 0x00B0BBB8 File Offset: 0x00B09DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_diamondsNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_diamondsNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EC5 RID: 134853 RVA: 0x00B0BC10 File Offset: 0x00B09E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_diamondsNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text diamondsNumText;
			LuaObject.checkType<Text>(l, 2, out diamondsNumText);
			selectCardUIController.m_luaExportHelper.m_diamondsNumText = diamondsNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EC6 RID: 134854 RVA: 0x00B0BC6C File Offset: 0x00B09E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_adsImage(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_adsImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EC7 RID: 134855 RVA: 0x00B0BCC4 File Offset: 0x00B09EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_adsImage(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Image adsImage;
			LuaObject.checkType<Image>(l, 2, out adsImage);
			selectCardUIController.m_luaExportHelper.m_adsImage = adsImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EC8 RID: 134856 RVA: 0x00B0BD20 File Offset: 0x00B09F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_adsTimeText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_adsTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EC9 RID: 134857 RVA: 0x00B0BD78 File Offset: 0x00B09F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_adsTimeText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text adsTimeText;
			LuaObject.checkType<Text>(l, 2, out adsTimeText);
			selectCardUIController.m_luaExportHelper.m_adsTimeText = adsTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ECA RID: 134858 RVA: 0x00B0BDD4 File Offset: 0x00B09FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityDetailButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_activityDetailButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ECB RID: 134859 RVA: 0x00B0BE2C File Offset: 0x00B0A02C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityDetailButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button activityDetailButton;
			LuaObject.checkType<Button>(l, 2, out activityDetailButton);
			selectCardUIController.m_luaExportHelper.m_activityDetailButton = activityDetailButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ECC RID: 134860 RVA: 0x00B0BE88 File Offset: 0x00B0A088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ECD RID: 134861 RVA: 0x00B0BEE0 File Offset: 0x00B0A0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			selectCardUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ECE RID: 134862 RVA: 0x00B0BF3C File Offset: 0x00B0A13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cardPoolToggleGroupGo(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_cardPoolToggleGroupGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ECF RID: 134863 RVA: 0x00B0BF94 File Offset: 0x00B0A194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cardPoolToggleGroupGo(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject cardPoolToggleGroupGo;
			LuaObject.checkType<GameObject>(l, 2, out cardPoolToggleGroupGo);
			selectCardUIController.m_luaExportHelper.m_cardPoolToggleGroupGo = cardPoolToggleGroupGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ED0 RID: 134864 RVA: 0x00B0BFF0 File Offset: 0x00B0A1F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ticketSummonToggle(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_ticketSummonToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ED1 RID: 134865 RVA: 0x00B0C048 File Offset: 0x00B0A248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ticketSummonToggle(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Toggle ticketSummonToggle;
			LuaObject.checkType<Toggle>(l, 2, out ticketSummonToggle);
			selectCardUIController.m_luaExportHelper.m_ticketSummonToggle = ticketSummonToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ED2 RID: 134866 RVA: 0x00B0C0A4 File Offset: 0x00B0A2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_magicStoneSummonToggle(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_magicStoneSummonToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ED3 RID: 134867 RVA: 0x00B0C0FC File Offset: 0x00B0A2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_magicStoneSummonToggle(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Toggle magicStoneSummonToggle;
			LuaObject.checkType<Toggle>(l, 2, out magicStoneSummonToggle);
			selectCardUIController.m_luaExportHelper.m_magicStoneSummonToggle = magicStoneSummonToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ED4 RID: 134868 RVA: 0x00B0C158 File Offset: 0x00B0A358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipSummonToggle(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_equipSummonToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ED5 RID: 134869 RVA: 0x00B0C1B0 File Offset: 0x00B0A3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipSummonToggle(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Toggle equipSummonToggle;
			LuaObject.checkType<Toggle>(l, 2, out equipSummonToggle);
			selectCardUIController.m_luaExportHelper.m_equipSummonToggle = equipSummonToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ED6 RID: 134870 RVA: 0x00B0C20C File Offset: 0x00B0A40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectBtn(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ED7 RID: 134871 RVA: 0x00B0C264 File Offset: 0x00B0A464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectBtn(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button singleSelectBtn;
			LuaObject.checkType<Button>(l, 2, out singleSelectBtn);
			selectCardUIController.m_luaExportHelper.m_singleSelectBtn = singleSelectBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ED8 RID: 134872 RVA: 0x00B0C2C0 File Offset: 0x00B0A4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectBtnIconImg(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectBtnIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ED9 RID: 134873 RVA: 0x00B0C318 File Offset: 0x00B0A518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectBtnIconImg(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Image singleSelectBtnIconImg;
			LuaObject.checkType<Image>(l, 2, out singleSelectBtnIconImg);
			selectCardUIController.m_luaExportHelper.m_singleSelectBtnIconImg = singleSelectBtnIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EDA RID: 134874 RVA: 0x00B0C374 File Offset: 0x00B0A574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectBtnNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectBtnNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EDB RID: 134875 RVA: 0x00B0C3CC File Offset: 0x00B0A5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectBtnNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text singleSelectBtnNumText;
			LuaObject.checkType<Text>(l, 2, out singleSelectBtnNumText);
			selectCardUIController.m_luaExportHelper.m_singleSelectBtnNumText = singleSelectBtnNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EDC RID: 134876 RVA: 0x00B0C428 File Offset: 0x00B0A628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectBtnTitleText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectBtnTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EDD RID: 134877 RVA: 0x00B0C480 File Offset: 0x00B0A680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectBtnTitleText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text singleSelectBtnTitleText;
			LuaObject.checkType<Text>(l, 2, out singleSelectBtnTitleText);
			selectCardUIController.m_luaExportHelper.m_singleSelectBtnTitleText = singleSelectBtnTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EDE RID: 134878 RVA: 0x00B0C4DC File Offset: 0x00B0A6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tenSelectBtn(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_tenSelectBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EDF RID: 134879 RVA: 0x00B0C534 File Offset: 0x00B0A734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tenSelectBtn(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button tenSelectBtn;
			LuaObject.checkType<Button>(l, 2, out tenSelectBtn);
			selectCardUIController.m_luaExportHelper.m_tenSelectBtn = tenSelectBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EE0 RID: 134880 RVA: 0x00B0C590 File Offset: 0x00B0A790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tenSelectBtnIconImg(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_tenSelectBtnIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EE1 RID: 134881 RVA: 0x00B0C5E8 File Offset: 0x00B0A7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tenSelectBtnIconImg(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Image tenSelectBtnIconImg;
			LuaObject.checkType<Image>(l, 2, out tenSelectBtnIconImg);
			selectCardUIController.m_luaExportHelper.m_tenSelectBtnIconImg = tenSelectBtnIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EE2 RID: 134882 RVA: 0x00B0C644 File Offset: 0x00B0A844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tenSelectBtnNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_tenSelectBtnNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EE3 RID: 134883 RVA: 0x00B0C69C File Offset: 0x00B0A89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tenSelectBtnNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text tenSelectBtnNumText;
			LuaObject.checkType<Text>(l, 2, out tenSelectBtnNumText);
			selectCardUIController.m_luaExportHelper.m_tenSelectBtnNumText = tenSelectBtnNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EE4 RID: 134884 RVA: 0x00B0C6F8 File Offset: 0x00B0A8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tenSelectBtnTitleText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_tenSelectBtnTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EE5 RID: 134885 RVA: 0x00B0C750 File Offset: 0x00B0A950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tenSelectBtnTitleText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text tenSelectBtnTitleText;
			LuaObject.checkType<Text>(l, 2, out tenSelectBtnTitleText);
			selectCardUIController.m_luaExportHelper.m_tenSelectBtnTitleText = tenSelectBtnTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EE6 RID: 134886 RVA: 0x00B0C7AC File Offset: 0x00B0A9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tenSelectBtn3DEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_tenSelectBtn3DEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EE7 RID: 134887 RVA: 0x00B0C804 File Offset: 0x00B0AA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tenSelectBtn3DEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject tenSelectBtn3DEffect;
			LuaObject.checkType<GameObject>(l, 2, out tenSelectBtn3DEffect);
			selectCardUIController.m_luaExportHelper.m_tenSelectBtn3DEffect = tenSelectBtn3DEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EE8 RID: 134888 RVA: 0x00B0C860 File Offset: 0x00B0AA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buyDiamondButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_buyDiamondButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EE9 RID: 134889 RVA: 0x00B0C8B8 File Offset: 0x00B0AAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buyDiamondButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button buyDiamondButton;
			LuaObject.checkType<Button>(l, 2, out buyDiamondButton);
			selectCardUIController.m_luaExportHelper.m_buyDiamondButton = buyDiamondButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EEA RID: 134890 RVA: 0x00B0C914 File Offset: 0x00B0AB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_summonToggleItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_summonToggleItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EEB RID: 134891 RVA: 0x00B0C96C File Offset: 0x00B0AB6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_summonToggleItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject summonToggleItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out summonToggleItemPrefab);
			selectCardUIController.m_luaExportHelper.m_summonToggleItemPrefab = summonToggleItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EEC RID: 134892 RVA: 0x00B0C9C8 File Offset: 0x00B0ABC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_afterSelectPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_afterSelectPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EED RID: 134893 RVA: 0x00B0CA20 File Offset: 0x00B0AC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_afterSelectPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject afterSelectPanel;
			LuaObject.checkType<GameObject>(l, 2, out afterSelectPanel);
			selectCardUIController.m_luaExportHelper.m_afterSelectPanel = afterSelectPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EEE RID: 134894 RVA: 0x00B0CA7C File Offset: 0x00B0AC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectArrowButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectArrowButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EEF RID: 134895 RVA: 0x00B0CAD4 File Offset: 0x00B0ACD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectArrowButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject singleSelectArrowButton;
			LuaObject.checkType<GameObject>(l, 2, out singleSelectArrowButton);
			selectCardUIController.m_luaExportHelper.m_singleSelectArrowButton = singleSelectArrowButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EF0 RID: 134896 RVA: 0x00B0CB30 File Offset: 0x00B0AD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectOpenNoticePanelGo(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectOpenNoticePanelGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EF1 RID: 134897 RVA: 0x00B0CB88 File Offset: 0x00B0AD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectOpenNoticePanelGo(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject singleSelectOpenNoticePanelGo;
			LuaObject.checkType<GameObject>(l, 2, out singleSelectOpenNoticePanelGo);
			selectCardUIController.m_luaExportHelper.m_singleSelectOpenNoticePanelGo = singleSelectOpenNoticePanelGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EF2 RID: 134898 RVA: 0x00B0CBE4 File Offset: 0x00B0ADE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectOpenNoticePanelImage(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectOpenNoticePanelImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EF3 RID: 134899 RVA: 0x00B0CC3C File Offset: 0x00B0AE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectOpenNoticePanelImage(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject singleSelectOpenNoticePanelImage;
			LuaObject.checkType<GameObject>(l, 2, out singleSelectOpenNoticePanelImage);
			selectCardUIController.m_luaExportHelper.m_singleSelectOpenNoticePanelImage = singleSelectOpenNoticePanelImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EF4 RID: 134900 RVA: 0x00B0CC98 File Offset: 0x00B0AE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EF5 RID: 134901 RVA: 0x00B0CCF0 File Offset: 0x00B0AEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject singleSelectPanel;
			LuaObject.checkType<GameObject>(l, 2, out singleSelectPanel);
			selectCardUIController.m_luaExportHelper.m_singleSelectPanel = singleSelectPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EF6 RID: 134902 RVA: 0x00B0CD4C File Offset: 0x00B0AF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleHeroWordPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleHeroWordPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EF7 RID: 134903 RVA: 0x00B0CDA4 File Offset: 0x00B0AFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleHeroWordPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject singleHeroWordPanel;
			LuaObject.checkType<GameObject>(l, 2, out singleHeroWordPanel);
			selectCardUIController.m_luaExportHelper.m_singleHeroWordPanel = singleHeroWordPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EF8 RID: 134904 RVA: 0x00B0CE00 File Offset: 0x00B0B000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectContinueImage(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectContinueImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EF9 RID: 134905 RVA: 0x00B0CE58 File Offset: 0x00B0B058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectContinueImage(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button singleSelectContinueImage;
			LuaObject.checkType<Button>(l, 2, out singleSelectContinueImage);
			selectCardUIController.m_luaExportHelper.m_singleSelectContinueImage = singleSelectContinueImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EFA RID: 134906 RVA: 0x00B0CEB4 File Offset: 0x00B0B0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectNewTextObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectNewTextObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EFB RID: 134907 RVA: 0x00B0CF0C File Offset: 0x00B0B10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectNewTextObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject singleSelectNewTextObj;
			LuaObject.checkType<GameObject>(l, 2, out singleSelectNewTextObj);
			selectCardUIController.m_luaExportHelper.m_singleSelectNewTextObj = singleSelectNewTextObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EFC RID: 134908 RVA: 0x00B0CF68 File Offset: 0x00B0B168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectGetTextObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectGetTextObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EFD RID: 134909 RVA: 0x00B0CFC0 File Offset: 0x00B0B1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectGetTextObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject singleSelectGetTextObj;
			LuaObject.checkType<GameObject>(l, 2, out singleSelectGetTextObj);
			selectCardUIController.m_luaExportHelper.m_singleSelectGetTextObj = singleSelectGetTextObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EFE RID: 134910 RVA: 0x00B0D01C File Offset: 0x00B0B21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectStarGroupObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectStarGroupObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020EFF RID: 134911 RVA: 0x00B0D074 File Offset: 0x00B0B274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectStarGroupObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject singleSelectStarGroupObj;
			LuaObject.checkType<GameObject>(l, 2, out singleSelectStarGroupObj);
			selectCardUIController.m_luaExportHelper.m_singleSelectStarGroupObj = singleSelectStarGroupObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F00 RID: 134912 RVA: 0x00B0D0D0 File Offset: 0x00B0B2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectSkipButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_selectSkipButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F01 RID: 134913 RVA: 0x00B0D128 File Offset: 0x00B0B328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectSkipButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button selectSkipButton;
			LuaObject.checkType<Button>(l, 2, out selectSkipButton);
			selectCardUIController.m_luaExportHelper.m_selectSkipButton = selectSkipButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F02 RID: 134914 RVA: 0x00B0D184 File Offset: 0x00B0B384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectItemImage(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectItemImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F03 RID: 134915 RVA: 0x00B0D1DC File Offset: 0x00B0B3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectItemImage(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Image singleSelectItemImage;
			LuaObject.checkType<Image>(l, 2, out singleSelectItemImage);
			selectCardUIController.m_luaExportHelper.m_singleSelectItemImage = singleSelectItemImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F04 RID: 134916 RVA: 0x00B0D238 File Offset: 0x00B0B438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectFragmentIconImg(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectFragmentIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F05 RID: 134917 RVA: 0x00B0D290 File Offset: 0x00B0B490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectFragmentIconImg(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Image singleSelectFragmentIconImg;
			LuaObject.checkType<Image>(l, 2, out singleSelectFragmentIconImg);
			selectCardUIController.m_luaExportHelper.m_singleSelectFragmentIconImg = singleSelectFragmentIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F06 RID: 134918 RVA: 0x00B0D2EC File Offset: 0x00B0B4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectFragmentCount(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectFragmentCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F07 RID: 134919 RVA: 0x00B0D344 File Offset: 0x00B0B544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectFragmentCount(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text singleSelectFragmentCount;
			LuaObject.checkType<Text>(l, 2, out singleSelectFragmentCount);
			selectCardUIController.m_luaExportHelper.m_singleSelectFragmentCount = singleSelectFragmentCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F08 RID: 134920 RVA: 0x00B0D3A0 File Offset: 0x00B0B5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectFragmentSSRImg(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectFragmentSSRImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F09 RID: 134921 RVA: 0x00B0D3F8 File Offset: 0x00B0B5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectFragmentSSRImg(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Image singleSelectFragmentSSRImg;
			LuaObject.checkType<Image>(l, 2, out singleSelectFragmentSSRImg);
			selectCardUIController.m_luaExportHelper.m_singleSelectFragmentSSRImg = singleSelectFragmentSSRImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F0A RID: 134922 RVA: 0x00B0D454 File Offset: 0x00B0B654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleSelectFragmentSRImg(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleSelectFragmentSRImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F0B RID: 134923 RVA: 0x00B0D4AC File Offset: 0x00B0B6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleSelectFragmentSRImg(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Image singleSelectFragmentSRImg;
			LuaObject.checkType<Image>(l, 2, out singleSelectFragmentSRImg);
			selectCardUIController.m_luaExportHelper.m_singleSelectFragmentSRImg = singleSelectFragmentSRImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F0C RID: 134924 RVA: 0x00B0D508 File Offset: 0x00B0B708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleShareButtonDummy(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_singleShareButtonDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F0D RID: 134925 RVA: 0x00B0D560 File Offset: 0x00B0B760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleShareButtonDummy(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject singleShareButtonDummy;
			LuaObject.checkType<GameObject>(l, 2, out singleShareButtonDummy);
			selectCardUIController.m_luaExportHelper.m_singleShareButtonDummy = singleShareButtonDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F0E RID: 134926 RVA: 0x00B0D5BC File Offset: 0x00B0B7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sharePhotoDummy(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_sharePhotoDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F0F RID: 134927 RVA: 0x00B0D614 File Offset: 0x00B0B814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sharePhotoDummy(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject sharePhotoDummy;
			LuaObject.checkType<GameObject>(l, 2, out sharePhotoDummy);
			selectCardUIController.m_luaExportHelper.m_sharePhotoDummy = sharePhotoDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F10 RID: 134928 RVA: 0x00B0D670 File Offset: 0x00B0B870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tenSelectPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_tenSelectPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F11 RID: 134929 RVA: 0x00B0D6C8 File Offset: 0x00B0B8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tenSelectPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject tenSelectPanel;
			LuaObject.checkType<GameObject>(l, 2, out tenSelectPanel);
			selectCardUIController.m_luaExportHelper.m_tenSelectPanel = tenSelectPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F12 RID: 134930 RVA: 0x00B0D724 File Offset: 0x00B0B924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tenSelectContentObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_tenSelectContentObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F13 RID: 134931 RVA: 0x00B0D77C File Offset: 0x00B0B97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tenSelectContentObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject tenSelectContentObj;
			LuaObject.checkType<GameObject>(l, 2, out tenSelectContentObj);
			selectCardUIController.m_luaExportHelper.m_tenSelectContentObj = tenSelectContentObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F14 RID: 134932 RVA: 0x00B0D7D8 File Offset: 0x00B0B9D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_afterSelectConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_afterSelectConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F15 RID: 134933 RVA: 0x00B0D830 File Offset: 0x00B0BA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_afterSelectConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button afterSelectConfirmButton;
			LuaObject.checkType<Button>(l, 2, out afterSelectConfirmButton);
			selectCardUIController.m_luaExportHelper.m_afterSelectConfirmButton = afterSelectConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F16 RID: 134934 RVA: 0x00B0D88C File Offset: 0x00B0BA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectAgainButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_selectAgainButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F17 RID: 134935 RVA: 0x00B0D8E4 File Offset: 0x00B0BAE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectAgainButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button selectAgainButton;
			LuaObject.checkType<Button>(l, 2, out selectAgainButton);
			selectCardUIController.m_luaExportHelper.m_selectAgainButton = selectAgainButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F18 RID: 134936 RVA: 0x00B0D940 File Offset: 0x00B0BB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectAgainButtonSingleBgObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_selectAgainButtonSingleBgObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F19 RID: 134937 RVA: 0x00B0D998 File Offset: 0x00B0BB98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectAgainButtonSingleBgObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject selectAgainButtonSingleBgObj;
			LuaObject.checkType<GameObject>(l, 2, out selectAgainButtonSingleBgObj);
			selectCardUIController.m_luaExportHelper.m_selectAgainButtonSingleBgObj = selectAgainButtonSingleBgObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F1A RID: 134938 RVA: 0x00B0D9F4 File Offset: 0x00B0BBF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectAgainButtonTenBgObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_selectAgainButtonTenBgObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F1B RID: 134939 RVA: 0x00B0DA4C File Offset: 0x00B0BC4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectAgainButtonTenBgObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject selectAgainButtonTenBgObj;
			LuaObject.checkType<GameObject>(l, 2, out selectAgainButtonTenBgObj);
			selectCardUIController.m_luaExportHelper.m_selectAgainButtonTenBgObj = selectAgainButtonTenBgObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F1C RID: 134940 RVA: 0x00B0DAA8 File Offset: 0x00B0BCA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectAgainBtnIconImg(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_selectAgainBtnIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F1D RID: 134941 RVA: 0x00B0DB00 File Offset: 0x00B0BD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectAgainBtnIconImg(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Image selectAgainBtnIconImg;
			LuaObject.checkType<Image>(l, 2, out selectAgainBtnIconImg);
			selectCardUIController.m_luaExportHelper.m_selectAgainBtnIconImg = selectAgainBtnIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F1E RID: 134942 RVA: 0x00B0DB5C File Offset: 0x00B0BD5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectAgainBtnNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_selectAgainBtnNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F1F RID: 134943 RVA: 0x00B0DBB4 File Offset: 0x00B0BDB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectAgainBtnNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text selectAgainBtnNumText;
			LuaObject.checkType<Text>(l, 2, out selectAgainBtnNumText);
			selectCardUIController.m_luaExportHelper.m_selectAgainBtnNumText = selectAgainBtnNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F20 RID: 134944 RVA: 0x00B0DC10 File Offset: 0x00B0BE10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectAgainBtnTitleText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_selectAgainBtnTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F21 RID: 134945 RVA: 0x00B0DC68 File Offset: 0x00B0BE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectAgainBtnTitleText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text selectAgainBtnTitleText;
			LuaObject.checkType<Text>(l, 2, out selectAgainBtnTitleText);
			selectCardUIController.m_luaExportHelper.m_selectAgainBtnTitleText = selectAgainBtnTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F22 RID: 134946 RVA: 0x00B0DCC4 File Offset: 0x00B0BEC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tenShareButtonDummy(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_tenShareButtonDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F23 RID: 134947 RVA: 0x00B0DD1C File Offset: 0x00B0BF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tenShareButtonDummy(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject tenShareButtonDummy;
			LuaObject.checkType<GameObject>(l, 2, out tenShareButtonDummy);
			selectCardUIController.m_luaExportHelper.m_tenShareButtonDummy = tenShareButtonDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F24 RID: 134948 RVA: 0x00B0DD78 File Offset: 0x00B0BF78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_diamondsAddBtn2(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_diamondsAddBtn2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F25 RID: 134949 RVA: 0x00B0DDD0 File Offset: 0x00B0BFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_diamondsAddBtn2(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button diamondsAddBtn;
			LuaObject.checkType<Button>(l, 2, out diamondsAddBtn);
			selectCardUIController.m_luaExportHelper.m_diamondsAddBtn2 = diamondsAddBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F26 RID: 134950 RVA: 0x00B0DE2C File Offset: 0x00B0C02C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeCrystalToTicketPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_changeCrystalToTicketPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F27 RID: 134951 RVA: 0x00B0DE84 File Offset: 0x00B0C084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeCrystalToTicketPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject changeCrystalToTicketPanel;
			LuaObject.checkType<GameObject>(l, 2, out changeCrystalToTicketPanel);
			selectCardUIController.m_luaExportHelper.m_changeCrystalToTicketPanel = changeCrystalToTicketPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F28 RID: 134952 RVA: 0x00B0DEE0 File Offset: 0x00B0C0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeCrystalToTicketPanelTip(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_changeCrystalToTicketPanelTip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F29 RID: 134953 RVA: 0x00B0DF38 File Offset: 0x00B0C138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeCrystalToTicketPanelTip(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text changeCrystalToTicketPanelTip;
			LuaObject.checkType<Text>(l, 2, out changeCrystalToTicketPanelTip);
			selectCardUIController.m_luaExportHelper.m_changeCrystalToTicketPanelTip = changeCrystalToTicketPanelTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F2A RID: 134954 RVA: 0x00B0DF94 File Offset: 0x00B0C194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeCrystalToTicketPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_changeCrystalToTicketPanelCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F2B RID: 134955 RVA: 0x00B0DFEC File Offset: 0x00B0C1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeCrystalToTicketPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button changeCrystalToTicketPanelCancelButton;
			LuaObject.checkType<Button>(l, 2, out changeCrystalToTicketPanelCancelButton);
			selectCardUIController.m_luaExportHelper.m_changeCrystalToTicketPanelCancelButton = changeCrystalToTicketPanelCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F2C RID: 134956 RVA: 0x00B0E048 File Offset: 0x00B0C248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeCrystalToTicketPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_changeCrystalToTicketPanelConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F2D RID: 134957 RVA: 0x00B0E0A0 File Offset: 0x00B0C2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeCrystalToTicketPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button changeCrystalToTicketPanelConfirmButton;
			LuaObject.checkType<Button>(l, 2, out changeCrystalToTicketPanelConfirmButton);
			selectCardUIController.m_luaExportHelper.m_changeCrystalToTicketPanelConfirmButton = changeCrystalToTicketPanelConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F2E RID: 134958 RVA: 0x00B0E0FC File Offset: 0x00B0C2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_crystalAndTicketNotEnoughPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_crystalAndTicketNotEnoughPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F2F RID: 134959 RVA: 0x00B0E154 File Offset: 0x00B0C354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_crystalAndTicketNotEnoughPanel(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject crystalAndTicketNotEnoughPanel;
			LuaObject.checkType<GameObject>(l, 2, out crystalAndTicketNotEnoughPanel);
			selectCardUIController.m_luaExportHelper.m_crystalAndTicketNotEnoughPanel = crystalAndTicketNotEnoughPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F30 RID: 134960 RVA: 0x00B0E1B0 File Offset: 0x00B0C3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_crystalAndTicketNotEnoughPanelTip(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_crystalAndTicketNotEnoughPanelTip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F31 RID: 134961 RVA: 0x00B0E208 File Offset: 0x00B0C408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_crystalAndTicketNotEnoughPanelTip(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text crystalAndTicketNotEnoughPanelTip;
			LuaObject.checkType<Text>(l, 2, out crystalAndTicketNotEnoughPanelTip);
			selectCardUIController.m_luaExportHelper.m_crystalAndTicketNotEnoughPanelTip = crystalAndTicketNotEnoughPanelTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F32 RID: 134962 RVA: 0x00B0E264 File Offset: 0x00B0C464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_crystalAndTicketNotEnoughPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_crystalAndTicketNotEnoughPanelCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F33 RID: 134963 RVA: 0x00B0E2BC File Offset: 0x00B0C4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_crystalAndTicketNotEnoughPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button crystalAndTicketNotEnoughPanelCancelButton;
			LuaObject.checkType<Button>(l, 2, out crystalAndTicketNotEnoughPanelCancelButton);
			selectCardUIController.m_luaExportHelper.m_crystalAndTicketNotEnoughPanelCancelButton = crystalAndTicketNotEnoughPanelCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F34 RID: 134964 RVA: 0x00B0E318 File Offset: 0x00B0C518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_crystalAndTicketNotEnoughPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_crystalAndTicketNotEnoughPanelConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F35 RID: 134965 RVA: 0x00B0E370 File Offset: 0x00B0C570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_crystalAndTicketNotEnoughPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button crystalAndTicketNotEnoughPanelConfirmButton;
			LuaObject.checkType<Button>(l, 2, out crystalAndTicketNotEnoughPanelConfirmButton);
			selectCardUIController.m_luaExportHelper.m_crystalAndTicketNotEnoughPanelConfirmButton = crystalAndTicketNotEnoughPanelConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F36 RID: 134966 RVA: 0x00B0E3CC File Offset: 0x00B0C5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_afterSelectPanelNormalCardNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_afterSelectPanelNormalCardNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F37 RID: 134967 RVA: 0x00B0E424 File Offset: 0x00B0C624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_afterSelectPanelNormalCardNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text afterSelectPanelNormalCardNumText;
			LuaObject.checkType<Text>(l, 2, out afterSelectPanelNormalCardNumText);
			selectCardUIController.m_luaExportHelper.m_afterSelectPanelNormalCardNumText = afterSelectPanelNormalCardNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F38 RID: 134968 RVA: 0x00B0E480 File Offset: 0x00B0C680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_afterSelectPanelDiamondsCardNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_afterSelectPanelDiamondsCardNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F39 RID: 134969 RVA: 0x00B0E4D8 File Offset: 0x00B0C6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_afterSelectPanelDiamondsCardNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text afterSelectPanelDiamondsCardNumText;
			LuaObject.checkType<Text>(l, 2, out afterSelectPanelDiamondsCardNumText);
			selectCardUIController.m_luaExportHelper.m_afterSelectPanelDiamondsCardNumText = afterSelectPanelDiamondsCardNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F3A RID: 134970 RVA: 0x00B0E534 File Offset: 0x00B0C734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_afterSelectPanelDiamondsNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_afterSelectPanelDiamondsNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F3B RID: 134971 RVA: 0x00B0E58C File Offset: 0x00B0C78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_afterSelectPanelDiamondsNumText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text afterSelectPanelDiamondsNumText;
			LuaObject.checkType<Text>(l, 2, out afterSelectPanelDiamondsNumText);
			selectCardUIController.m_luaExportHelper.m_afterSelectPanelDiamondsNumText = afterSelectPanelDiamondsNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F3C RID: 134972 RVA: 0x00B0E5E8 File Offset: 0x00B0C7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_archiveButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_archiveButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F3D RID: 134973 RVA: 0x00B0E640 File Offset: 0x00B0C840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_archiveButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button archiveButton;
			LuaObject.checkType<Button>(l, 2, out archiveButton);
			selectCardUIController.m_luaExportHelper.m_archiveButton = archiveButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F3E RID: 134974 RVA: 0x00B0E69C File Offset: 0x00B0C89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_detailButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F3F RID: 134975 RVA: 0x00B0E6F4 File Offset: 0x00B0C8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button detailButton;
			LuaObject.checkType<Button>(l, 2, out detailButton);
			selectCardUIController.m_luaExportHelper.m_detailButton = detailButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F40 RID: 134976 RVA: 0x00B0E750 File Offset: 0x00B0C950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailPanelObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_detailPanelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F41 RID: 134977 RVA: 0x00B0E7A8 File Offset: 0x00B0C9A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailPanelObj(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject detailPanelObj;
			LuaObject.checkType<GameObject>(l, 2, out detailPanelObj);
			selectCardUIController.m_luaExportHelper.m_detailPanelObj = detailPanelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F42 RID: 134978 RVA: 0x00B0E804 File Offset: 0x00B0CA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_detailPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F43 RID: 134979 RVA: 0x00B0E85C File Offset: 0x00B0CA5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			CommonUIStateController detailPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out detailPanelStateCtrl);
			selectCardUIController.m_luaExportHelper.m_detailPanelStateCtrl = detailPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F44 RID: 134980 RVA: 0x00B0E8B8 File Offset: 0x00B0CAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailCloseButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_detailCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F45 RID: 134981 RVA: 0x00B0E910 File Offset: 0x00B0CB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailCloseButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button detailCloseButton;
			LuaObject.checkType<Button>(l, 2, out detailCloseButton);
			selectCardUIController.m_luaExportHelper.m_detailCloseButton = detailCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F46 RID: 134982 RVA: 0x00B0E96C File Offset: 0x00B0CB6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailReturnBgButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_detailReturnBgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F47 RID: 134983 RVA: 0x00B0E9C4 File Offset: 0x00B0CBC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailReturnBgButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button detailReturnBgButton;
			LuaObject.checkType<Button>(l, 2, out detailReturnBgButton);
			selectCardUIController.m_luaExportHelper.m_detailReturnBgButton = detailReturnBgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F48 RID: 134984 RVA: 0x00B0EA20 File Offset: 0x00B0CC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailScrollRect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_detailScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F49 RID: 134985 RVA: 0x00B0EA78 File Offset: 0x00B0CC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailScrollRect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			ScrollRect detailScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out detailScrollRect);
			selectCardUIController.m_luaExportHelper.m_detailScrollRect = detailScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F4A RID: 134986 RVA: 0x00B0EAD4 File Offset: 0x00B0CCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailWeightTitleText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_detailWeightTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F4B RID: 134987 RVA: 0x00B0EB2C File Offset: 0x00B0CD2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailWeightTitleText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text detailWeightTitleText;
			LuaObject.checkType<Text>(l, 2, out detailWeightTitleText);
			selectCardUIController.m_luaExportHelper.m_detailWeightTitleText = detailWeightTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F4C RID: 134988 RVA: 0x00B0EB88 File Offset: 0x00B0CD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailSSRWeightText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_detailSSRWeightText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F4D RID: 134989 RVA: 0x00B0EBE0 File Offset: 0x00B0CDE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailSSRWeightText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text detailSSRWeightText;
			LuaObject.checkType<Text>(l, 2, out detailSSRWeightText);
			selectCardUIController.m_luaExportHelper.m_detailSSRWeightText = detailSSRWeightText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F4E RID: 134990 RVA: 0x00B0EC3C File Offset: 0x00B0CE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailSRWeightText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_detailSRWeightText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F4F RID: 134991 RVA: 0x00B0EC94 File Offset: 0x00B0CE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailSRWeightText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text detailSRWeightText;
			LuaObject.checkType<Text>(l, 2, out detailSRWeightText);
			selectCardUIController.m_luaExportHelper.m_detailSRWeightText = detailSRWeightText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F50 RID: 134992 RVA: 0x00B0ECF0 File Offset: 0x00B0CEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailRWeightText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_detailRWeightText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F51 RID: 134993 RVA: 0x00B0ED48 File Offset: 0x00B0CF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailRWeightText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text detailRWeightText;
			LuaObject.checkType<Text>(l, 2, out detailRWeightText);
			selectCardUIController.m_luaExportHelper.m_detailRWeightText = detailRWeightText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F52 RID: 134994 RVA: 0x00B0EDA4 File Offset: 0x00B0CFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailScrollViewContentTitleText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_detailScrollViewContentTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F53 RID: 134995 RVA: 0x00B0EDFC File Offset: 0x00B0CFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailScrollViewContentTitleText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text detailScrollViewContentTitleText;
			LuaObject.checkType<Text>(l, 2, out detailScrollViewContentTitleText);
			selectCardUIController.m_luaExportHelper.m_detailScrollViewContentTitleText = detailScrollViewContentTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F54 RID: 134996 RVA: 0x00B0EE58 File Offset: 0x00B0D058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_detailScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F55 RID: 134997 RVA: 0x00B0EEB0 File Offset: 0x00B0D0B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject detailScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out detailScrollViewContent);
			selectCardUIController.m_luaExportHelper.m_detailScrollViewContent = detailScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F56 RID: 134998 RVA: 0x00B0EF0C File Offset: 0x00B0D10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_poolItemWithRankPrefab(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_poolItemWithRankPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F57 RID: 134999 RVA: 0x00B0EF64 File Offset: 0x00B0D164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_poolItemWithRankPrefab(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			GameObject poolItemWithRankPrefab;
			LuaObject.checkType<GameObject>(l, 2, out poolItemWithRankPrefab);
			selectCardUIController.m_luaExportHelper.m_poolItemWithRankPrefab = poolItemWithRankPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F58 RID: 135000 RVA: 0x00B0EFC0 File Offset: 0x00B0D1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_weiBoShareOneButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_weiBoShareOneButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F59 RID: 135001 RVA: 0x00B0F018 File Offset: 0x00B0D218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_weiBoShareOneButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button weiBoShareOneButton;
			LuaObject.checkType<Button>(l, 2, out weiBoShareOneButton);
			selectCardUIController.m_luaExportHelper.m_weiBoShareOneButton = weiBoShareOneButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F5A RID: 135002 RVA: 0x00B0F074 File Offset: 0x00B0D274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_weChatShareOneButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_weChatShareOneButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F5B RID: 135003 RVA: 0x00B0F0CC File Offset: 0x00B0D2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_weChatShareOneButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button weChatShareOneButton;
			LuaObject.checkType<Button>(l, 2, out weChatShareOneButton);
			selectCardUIController.m_luaExportHelper.m_weChatShareOneButton = weChatShareOneButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F5C RID: 135004 RVA: 0x00B0F128 File Offset: 0x00B0D328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_weiBoShareTenButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_weiBoShareTenButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F5D RID: 135005 RVA: 0x00B0F180 File Offset: 0x00B0D380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_weiBoShareTenButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button weiBoShareTenButton;
			LuaObject.checkType<Button>(l, 2, out weiBoShareTenButton);
			selectCardUIController.m_luaExportHelper.m_weiBoShareTenButton = weiBoShareTenButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F5E RID: 135006 RVA: 0x00B0F1DC File Offset: 0x00B0D3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_weChatShareTenButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_weChatShareTenButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F5F RID: 135007 RVA: 0x00B0F234 File Offset: 0x00B0D434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_weChatShareTenButton(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Button weChatShareTenButton;
			LuaObject.checkType<Button>(l, 2, out weChatShareTenButton);
			selectCardUIController.m_luaExportHelper.m_weChatShareTenButton = weChatShareTenButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F60 RID: 135008 RVA: 0x00B0F290 File Offset: 0x00B0D490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F61 RID: 135009 RVA: 0x00B0F2E8 File Offset: 0x00B0D4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			selectCardUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F62 RID: 135010 RVA: 0x00B0F344 File Offset: 0x00B0D544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLvText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_playerLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F63 RID: 135011 RVA: 0x00B0F39C File Offset: 0x00B0D59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLvText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text playerLvText;
			LuaObject.checkType<Text>(l, 2, out playerLvText);
			selectCardUIController.m_luaExportHelper.m_playerLvText = playerLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F64 RID: 135012 RVA: 0x00B0F3F8 File Offset: 0x00B0D5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverNameText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_serverNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F65 RID: 135013 RVA: 0x00B0F450 File Offset: 0x00B0D650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverNameText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text serverNameText;
			LuaObject.checkType<Text>(l, 2, out serverNameText);
			selectCardUIController.m_luaExportHelper.m_serverNameText = serverNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F66 RID: 135014 RVA: 0x00B0F4AC File Offset: 0x00B0D6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_heroNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F67 RID: 135015 RVA: 0x00B0F504 File Offset: 0x00B0D704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Text heroNameText;
			LuaObject.checkType<Text>(l, 2, out heroNameText);
			selectCardUIController.m_luaExportHelper.m_heroNameText = heroNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F68 RID: 135016 RVA: 0x00B0F560 File Offset: 0x00B0D760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nToShareHeroId(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_nToShareHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F69 RID: 135017 RVA: 0x00B0F5B8 File Offset: 0x00B0D7B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nToShareHeroId(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			int nToShareHeroId;
			LuaObject.checkType(l, 2, out nToShareHeroId);
			selectCardUIController.m_luaExportHelper.m_nToShareHeroId = nToShareHeroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F6A RID: 135018 RVA: 0x00B0F614 File Offset: 0x00B0D814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnWeiBoShareTen(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					selectCardUIController.EventOnWeiBoShareTen += value;
				}
				else if (num == 2)
				{
					selectCardUIController.EventOnWeiBoShareTen -= value;
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

	// Token: 0x06020F6B RID: 135019 RVA: 0x00B0F694 File Offset: 0x00B0D894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnWeChatShareTen(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					selectCardUIController.EventOnWeChatShareTen += value;
				}
				else if (num == 2)
				{
					selectCardUIController.EventOnWeChatShareTen -= value;
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

	// Token: 0x06020F6C RID: 135020 RVA: 0x00B0F714 File Offset: 0x00B0D914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnArchive(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					selectCardUIController.EventOnArchive += value;
				}
				else if (num == 2)
				{
					selectCardUIController.EventOnArchive -= value;
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

	// Token: 0x06020F6D RID: 135021 RVA: 0x00B0F794 File Offset: 0x00B0D994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					selectCardUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					selectCardUIController.EventOnReturn -= value;
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

	// Token: 0x06020F6E RID: 135022 RVA: 0x00B0F814 File Offset: 0x00B0DA14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectCard(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Action<int, bool> value;
			int num = LuaObject.checkDelegate<Action<int, bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					selectCardUIController.EventOnSelectCard += value;
				}
				else if (num == 2)
				{
					selectCardUIController.EventOnSelectCard -= value;
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

	// Token: 0x06020F6F RID: 135023 RVA: 0x00B0F894 File Offset: 0x00B0DA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowSelectCardHelp(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					selectCardUIController.EventOnShowSelectCardHelp += value;
				}
				else if (num == 2)
				{
					selectCardUIController.EventOnShowSelectCardHelp -= value;
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

	// Token: 0x06020F70 RID: 135024 RVA: 0x00B0F914 File Offset: 0x00B0DB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowActivityDetail(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Action<CardPool> value;
			int num = LuaObject.checkDelegate<Action<CardPool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					selectCardUIController.EventOnShowActivityDetail += value;
				}
				else if (num == 2)
				{
					selectCardUIController.EventOnShowActivityDetail -= value;
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

	// Token: 0x06020F71 RID: 135025 RVA: 0x00B0F994 File Offset: 0x00B0DB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBagCapcityNotEnough(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					selectCardUIController.EventOnBagCapcityNotEnough += value;
				}
				else if (num == 2)
				{
					selectCardUIController.EventOnBagCapcityNotEnough -= value;
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

	// Token: 0x06020F72 RID: 135026 RVA: 0x00B0FA14 File Offset: 0x00B0DC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					selectCardUIController.EventOnCrystalNotEnough += value;
				}
				else if (num == 2)
				{
					selectCardUIController.EventOnCrystalNotEnough -= value;
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

	// Token: 0x06020F73 RID: 135027 RVA: 0x00B0FA94 File Offset: 0x00B0DC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					selectCardUIController.EventOnAddCrystal += value;
				}
				else if (num == 2)
				{
					selectCardUIController.EventOnAddCrystal -= value;
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

	// Token: 0x06020F74 RID: 135028 RVA: 0x00B0FB14 File Offset: 0x00B0DD14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cardPoolId(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_cardPoolId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F75 RID: 135029 RVA: 0x00B0FB6C File Offset: 0x00B0DD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cardPoolId(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			selectCardUIController.m_luaExportHelper.m_cardPoolId = cardPoolId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F76 RID: 135030 RVA: 0x00B0FBC8 File Offset: 0x00B0DDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cardPool(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_cardPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F77 RID: 135031 RVA: 0x00B0FC20 File Offset: 0x00B0DE20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cardPool(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			selectCardUIController.m_luaExportHelper.m_cardPool = cardPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F78 RID: 135032 RVA: 0x00B0FC7C File Offset: 0x00B0DE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isClockHold(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_isClockHold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F79 RID: 135033 RVA: 0x00B0FCD4 File Offset: 0x00B0DED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isClockHold(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			bool isClockHold;
			LuaObject.checkType(l, 2, out isClockHold);
			selectCardUIController.m_luaExportHelper.m_isClockHold = isClockHold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F7A RID: 135034 RVA: 0x00B0FD30 File Offset: 0x00B0DF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSingleSelect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_isSingleSelect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F7B RID: 135035 RVA: 0x00B0FD88 File Offset: 0x00B0DF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSingleSelect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			bool isSingleSelect;
			LuaObject.checkType(l, 2, out isSingleSelect);
			selectCardUIController.m_luaExportHelper.m_isSingleSelect = isSingleSelect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F7C RID: 135036 RVA: 0x00B0FDE4 File Offset: 0x00B0DFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isContinueButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_isContinueButtonClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F7D RID: 135037 RVA: 0x00B0FE3C File Offset: 0x00B0E03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isContinueButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			bool isContinueButtonClick;
			LuaObject.checkType(l, 2, out isContinueButtonClick);
			selectCardUIController.m_luaExportHelper.m_isContinueButtonClick = isContinueButtonClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F7E RID: 135038 RVA: 0x00B0FE98 File Offset: 0x00B0E098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectRewards(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_selectRewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F7F RID: 135039 RVA: 0x00B0FEF0 File Offset: 0x00B0E0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectRewards(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			List<Goods> selectRewards;
			LuaObject.checkType<List<Goods>>(l, 2, out selectRewards);
			selectCardUIController.m_luaExportHelper.m_selectRewards = selectRewards;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F80 RID: 135040 RVA: 0x00B0FF4C File Offset: 0x00B0E14C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PoolItemNameText(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SelectCardUIController.LuaExportHelper.PoolItemNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F81 RID: 135041 RVA: 0x00B0FF94 File Offset: 0x00B0E194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NormalCardId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SelectCardUIController.LuaExportHelper.NormalCardId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F82 RID: 135042 RVA: 0x00B0FFDC File Offset: 0x00B0E1DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CrystalCardId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SelectCardUIController.LuaExportHelper.CrystalCardId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F83 RID: 135043 RVA: 0x00B10024 File Offset: 0x00B0E224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F84 RID: 135044 RVA: 0x00B1007C File Offset: 0x00B0E27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			selectCardUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F85 RID: 135045 RVA: 0x00B100D8 File Offset: 0x00B0E2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F86 RID: 135046 RVA: 0x00B10130 File Offset: 0x00B0E330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			selectCardUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F87 RID: 135047 RVA: 0x00B1018C File Offset: 0x00B0E38C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_heroCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F88 RID: 135048 RVA: 0x00B101E4 File Offset: 0x00B0E3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			HeroCharUIController heroCharUIController;
			LuaObject.checkType<HeroCharUIController>(l, 2, out heroCharUIController);
			selectCardUIController.m_luaExportHelper.m_heroCharUIController = heroCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F89 RID: 135049 RVA: 0x00B10240 File Offset: 0x00B0E440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectCardBackground3DController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_selectCardBackground3DController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F8A RID: 135050 RVA: 0x00B10298 File Offset: 0x00B0E498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectCardBackground3DController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			SelectCardBackground3DController selectCardBackground3DController;
			LuaObject.checkType<SelectCardBackground3DController>(l, 2, out selectCardBackground3DController);
			selectCardUIController.m_luaExportHelper.m_selectCardBackground3DController = selectCardBackground3DController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F8B RID: 135051 RVA: 0x00B102F4 File Offset: 0x00B0E4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shareTenSelectCardUIController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_shareTenSelectCardUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F8C RID: 135052 RVA: 0x00B1034C File Offset: 0x00B0E54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shareTenSelectCardUIController(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			ShareTenSelectCardUIController shareTenSelectCardUIController;
			LuaObject.checkType<ShareTenSelectCardUIController>(l, 2, out shareTenSelectCardUIController);
			selectCardUIController.m_luaExportHelper.m_shareTenSelectCardUIController = shareTenSelectCardUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F8D RID: 135053 RVA: 0x00B103A8 File Offset: 0x00B0E5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hasShowClockEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_hasShowClockEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F8E RID: 135054 RVA: 0x00B10400 File Offset: 0x00B0E600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hasShowClockEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			bool hasShowClockEffect;
			LuaObject.checkType(l, 2, out hasShowClockEffect);
			selectCardUIController.m_luaExportHelper.m_hasShowClockEffect = hasShowClockEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F8F RID: 135055 RVA: 0x00B1045C File Offset: 0x00B0E65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggleCtrlList(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardUIController.m_luaExportHelper.m_toggleCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F90 RID: 135056 RVA: 0x00B104B4 File Offset: 0x00B0E6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggleCtrlList(IntPtr l)
	{
		int result;
		try
		{
			SelectCardUIController selectCardUIController = (SelectCardUIController)LuaObject.checkSelf(l);
			List<SummonToggleUIController> toggleCtrlList;
			LuaObject.checkType<List<SummonToggleUIController>>(l, 2, out toggleCtrlList);
			selectCardUIController.m_luaExportHelper.m_toggleCtrlList = toggleCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020F91 RID: 135057 RVA: 0x00B10510 File Offset: 0x00B0E710
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SelectCardUIController");
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.UpdateViewInSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.UpdateSharePlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.SetShareTenSelectCardUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.ShowSelectCardRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.CloseTenSelectPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.IsShowSelectCardResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.PlayRewardsEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.PlaySingleRewardEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.StopClockEffectSoundOnSkipButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.AfterShowClockEffectFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnClockButtonDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnContinueButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.PlayTotalRewardsEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.SetAfterSelectCurrecyPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.SetSingleSelectRewardInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.SetTenSelectRewardsInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.CreateCardPoolTabs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.SummonToggleCtrl_EventOnToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.SetValuesAfterToggleChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.SetSelectButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnActivityDetailButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnSingleSelectButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnTenSelectButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnSelectAgainButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.ShowChangeCrystalToTicketPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.ChangeCrystalToTicketPanelCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.CloseChangeCrystalToTicketPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.ChangeCrystalToTicketPanelConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.ShowCrystalAndTicketNotEnoughPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.CrystalAndTicketNotEnoughPanelCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.CloseCrystalAndTicketNotEnoughPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.CrystalAndTicketNotEnoughPanelConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnBuyDiamondButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnAddCrystalBtnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.SkipShowRewardEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.Close3DUIEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.CloseShowSelectRewardsPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.ShowDetailScrollView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.CreatePoolItemPrefab);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnDetailButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnCloseDetailPanelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnArchiveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnWeiBoShareOnceClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnWeChatShareOnceClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnWeiBoShareTenClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.OnWeChatShareTenClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.CaptureOnceFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.CaptureTenFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callDele_EventOnWeiBoShareTen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__clearDele_EventOnWeiBoShareTen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callDele_EventOnWeChatShareTen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__clearDele_EventOnWeChatShareTen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callDele_EventOnArchive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__clearDele_EventOnArchive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callDele_EventOnSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__clearDele_EventOnSelectCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callDele_EventOnShowSelectCardHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__clearDele_EventOnShowSelectCardHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callDele_EventOnShowActivityDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__clearDele_EventOnShowActivityDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callDele_EventOnBagCapcityNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__clearDele_EventOnBagCapcityNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callDele_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__clearDele_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__callDele_EventOnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.__clearDele_EventOnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache54);
		string name = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_returnButton);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache56, true);
		string name2 = "m_mainUIGo";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_mainUIGo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_mainUIGo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache58, true);
		string name3 = "m_normalCardNumText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_normalCardNumText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_normalCardNumText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5A, true);
		string name4 = "m_diamondsCardNumText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_diamondsCardNumText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_diamondsCardNumText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5C, true);
		string name5 = "m_diamondsAddBtn";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_diamondsAddBtn);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_diamondsAddBtn);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5E, true);
		string name6 = "m_diamondsNumText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_diamondsNumText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_diamondsNumText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache60, true);
		string name7 = "m_adsImage";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_adsImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_adsImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache62, true);
		string name8 = "m_adsTimeText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_adsTimeText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_adsTimeText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache64, true);
		string name9 = "m_activityDetailButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_activityDetailButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_activityDetailButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache66, true);
		string name10 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_marginTransform);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache68, true);
		string name11 = "m_cardPoolToggleGroupGo";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_cardPoolToggleGroupGo);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_cardPoolToggleGroupGo);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6A, true);
		string name12 = "m_ticketSummonToggle";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_ticketSummonToggle);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_ticketSummonToggle);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6C, true);
		string name13 = "m_magicStoneSummonToggle";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_magicStoneSummonToggle);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_magicStoneSummonToggle);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6E, true);
		string name14 = "m_equipSummonToggle";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_equipSummonToggle);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_equipSummonToggle);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache70, true);
		string name15 = "m_singleSelectBtn";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectBtn);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectBtn);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache72, true);
		string name16 = "m_singleSelectBtnIconImg";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectBtnIconImg);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectBtnIconImg);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache74, true);
		string name17 = "m_singleSelectBtnNumText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectBtnNumText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectBtnNumText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache76, true);
		string name18 = "m_singleSelectBtnTitleText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectBtnTitleText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectBtnTitleText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache78, true);
		string name19 = "m_tenSelectBtn";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_tenSelectBtn);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_tenSelectBtn);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7A, true);
		string name20 = "m_tenSelectBtnIconImg";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_tenSelectBtnIconImg);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_tenSelectBtnIconImg);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7C, true);
		string name21 = "m_tenSelectBtnNumText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_tenSelectBtnNumText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_tenSelectBtnNumText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7E, true);
		string name22 = "m_tenSelectBtnTitleText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_tenSelectBtnTitleText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_tenSelectBtnTitleText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache80, true);
		string name23 = "m_tenSelectBtn3DEffect";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_tenSelectBtn3DEffect);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_tenSelectBtn3DEffect);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache82, true);
		string name24 = "m_buyDiamondButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_buyDiamondButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_buyDiamondButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache84, true);
		string name25 = "m_summonToggleItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_summonToggleItemPrefab);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_summonToggleItemPrefab);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache86, true);
		string name26 = "m_afterSelectPanel";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_afterSelectPanel);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_afterSelectPanel);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache88, true);
		string name27 = "m_singleSelectArrowButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectArrowButton);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectArrowButton);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8A, true);
		string name28 = "m_singleSelectOpenNoticePanelGo";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectOpenNoticePanelGo);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectOpenNoticePanelGo);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8C, true);
		string name29 = "m_singleSelectOpenNoticePanelImage";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectOpenNoticePanelImage);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectOpenNoticePanelImage);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8E, true);
		string name30 = "m_singleSelectPanel";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectPanel);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectPanel);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache90, true);
		string name31 = "m_singleHeroWordPanel";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleHeroWordPanel);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleHeroWordPanel);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache92, true);
		string name32 = "m_singleSelectContinueImage";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectContinueImage);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectContinueImage);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache94, true);
		string name33 = "m_singleSelectNewTextObj";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectNewTextObj);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectNewTextObj);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache96, true);
		string name34 = "m_singleSelectGetTextObj";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectGetTextObj);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectGetTextObj);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache98, true);
		string name35 = "m_singleSelectStarGroupObj";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectStarGroupObj);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectStarGroupObj);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9A, true);
		string name36 = "m_selectSkipButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_selectSkipButton);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_selectSkipButton);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9C, true);
		string name37 = "m_singleSelectItemImage";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectItemImage);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectItemImage);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9E, true);
		string name38 = "m_singleSelectFragmentIconImg";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectFragmentIconImg);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache9F;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectFragmentIconImg);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA0, true);
		string name39 = "m_singleSelectFragmentCount";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectFragmentCount);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA1;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectFragmentCount);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA2, true);
		string name40 = "m_singleSelectFragmentSSRImg";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectFragmentSSRImg);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA3;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectFragmentSSRImg);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA4, true);
		string name41 = "m_singleSelectFragmentSRImg";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleSelectFragmentSRImg);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA5;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleSelectFragmentSRImg);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA6, true);
		string name42 = "m_singleShareButtonDummy";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_singleShareButtonDummy);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA7;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_singleShareButtonDummy);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA8, true);
		string name43 = "m_sharePhotoDummy";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_sharePhotoDummy);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheA9;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_sharePhotoDummy);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAA, true);
		string name44 = "m_tenSelectPanel";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_tenSelectPanel);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAB;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_tenSelectPanel);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAC, true);
		string name45 = "m_tenSelectContentObj";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_tenSelectContentObj);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAD;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_tenSelectContentObj);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAE, true);
		string name46 = "m_afterSelectConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_afterSelectConfirmButton);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheAF;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_afterSelectConfirmButton);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB0, true);
		string name47 = "m_selectAgainButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_selectAgainButton);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB1;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_selectAgainButton);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB2, true);
		string name48 = "m_selectAgainButtonSingleBgObj";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_selectAgainButtonSingleBgObj);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB3;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_selectAgainButtonSingleBgObj);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB4, true);
		string name49 = "m_selectAgainButtonTenBgObj";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_selectAgainButtonTenBgObj);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB5;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_selectAgainButtonTenBgObj);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB6, true);
		string name50 = "m_selectAgainBtnIconImg";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_selectAgainBtnIconImg);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB7;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_selectAgainBtnIconImg);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB8, true);
		string name51 = "m_selectAgainBtnNumText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_selectAgainBtnNumText);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheB9;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_selectAgainBtnNumText);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBA, true);
		string name52 = "m_selectAgainBtnTitleText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_selectAgainBtnTitleText);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBB;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_selectAgainBtnTitleText);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBC, true);
		string name53 = "m_tenShareButtonDummy";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_tenShareButtonDummy);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBD;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_tenShareButtonDummy);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBE, true);
		string name54 = "m_diamondsAddBtn2";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_diamondsAddBtn2);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheBF;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_diamondsAddBtn2);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC0, true);
		string name55 = "m_changeCrystalToTicketPanel";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_changeCrystalToTicketPanel);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC1;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_changeCrystalToTicketPanel);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC2, true);
		string name56 = "m_changeCrystalToTicketPanelTip";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_changeCrystalToTicketPanelTip);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC3;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_changeCrystalToTicketPanelTip);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC4, true);
		string name57 = "m_changeCrystalToTicketPanelCancelButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_changeCrystalToTicketPanelCancelButton);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC5;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_changeCrystalToTicketPanelCancelButton);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC6, true);
		string name58 = "m_changeCrystalToTicketPanelConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_changeCrystalToTicketPanelConfirmButton);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC7;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_changeCrystalToTicketPanelConfirmButton);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC8, true);
		string name59 = "m_crystalAndTicketNotEnoughPanel";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_crystalAndTicketNotEnoughPanel);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheC9;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_crystalAndTicketNotEnoughPanel);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCA, true);
		string name60 = "m_crystalAndTicketNotEnoughPanelTip";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_crystalAndTicketNotEnoughPanelTip);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCB;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_crystalAndTicketNotEnoughPanelTip);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCC, true);
		string name61 = "m_crystalAndTicketNotEnoughPanelCancelButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_crystalAndTicketNotEnoughPanelCancelButton);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCD;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_crystalAndTicketNotEnoughPanelCancelButton);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCE, true);
		string name62 = "m_crystalAndTicketNotEnoughPanelConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_crystalAndTicketNotEnoughPanelConfirmButton);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheCF;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_crystalAndTicketNotEnoughPanelConfirmButton);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD0, true);
		string name63 = "m_afterSelectPanelNormalCardNumText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_afterSelectPanelNormalCardNumText);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD1;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_afterSelectPanelNormalCardNumText);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD2, true);
		string name64 = "m_afterSelectPanelDiamondsCardNumText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_afterSelectPanelDiamondsCardNumText);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD3;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_afterSelectPanelDiamondsCardNumText);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD4, true);
		string name65 = "m_afterSelectPanelDiamondsNumText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_afterSelectPanelDiamondsNumText);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD5;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_afterSelectPanelDiamondsNumText);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD6, true);
		string name66 = "m_archiveButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_archiveButton);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD7;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_archiveButton);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD8, true);
		string name67 = "m_detailButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_detailButton);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheD9;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_detailButton);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDA, true);
		string name68 = "m_detailPanelObj";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_detailPanelObj);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDB;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_detailPanelObj);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDC, true);
		string name69 = "m_detailPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_detailPanelStateCtrl);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDD;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_detailPanelStateCtrl);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDE, true);
		string name70 = "m_detailCloseButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_detailCloseButton);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheDF;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_detailCloseButton);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE0, true);
		string name71 = "m_detailReturnBgButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_detailReturnBgButton);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE1;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_detailReturnBgButton);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE2, true);
		string name72 = "m_detailScrollRect";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_detailScrollRect);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE3;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_detailScrollRect);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE4, true);
		string name73 = "m_detailWeightTitleText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_detailWeightTitleText);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE5;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_detailWeightTitleText);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE6, true);
		string name74 = "m_detailSSRWeightText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_detailSSRWeightText);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE7;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_detailSSRWeightText);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE8, true);
		string name75 = "m_detailSRWeightText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_detailSRWeightText);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheE9;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_detailSRWeightText);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEA, true);
		string name76 = "m_detailRWeightText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_detailRWeightText);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEB;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_detailRWeightText);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEC, true);
		string name77 = "m_detailScrollViewContentTitleText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_detailScrollViewContentTitleText);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheED;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_detailScrollViewContentTitleText);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEE, true);
		string name78 = "m_detailScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_detailScrollViewContent);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheEF;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_detailScrollViewContent);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF0, true);
		string name79 = "m_poolItemWithRankPrefab";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_poolItemWithRankPrefab);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF1;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_poolItemWithRankPrefab);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF2, true);
		string name80 = "m_weiBoShareOneButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_weiBoShareOneButton);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF3;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_weiBoShareOneButton);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF4, true);
		string name81 = "m_weChatShareOneButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_weChatShareOneButton);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF5;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_weChatShareOneButton);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF6, true);
		string name82 = "m_weiBoShareTenButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_weiBoShareTenButton);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF7;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_weiBoShareTenButton);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF8, true);
		string name83 = "m_weChatShareTenButton";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_weChatShareTenButton);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheF9;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_weChatShareTenButton);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFA, true);
		string name84 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_playerNameText);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFB;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFC, true);
		string name85 = "m_playerLvText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_playerLvText);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFD;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_playerLvText);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFE, true);
		string name86 = "m_serverNameText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_serverNameText);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cacheFF;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_serverNameText);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache100, true);
		string name87 = "m_heroNameText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_heroNameText);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache101;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_heroNameText);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache102, true);
		string name88 = "m_nToShareHeroId";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_nToShareHeroId);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache103;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_nToShareHeroId);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache104, true);
		string name89 = "EventOnWeiBoShareTen";
		LuaCSFunction get89 = null;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_EventOnWeiBoShareTen);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache105, true);
		string name90 = "EventOnWeChatShareTen";
		LuaCSFunction get90 = null;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_EventOnWeChatShareTen);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache106, true);
		string name91 = "EventOnArchive";
		LuaCSFunction get91 = null;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_EventOnArchive);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache107, true);
		string name92 = "EventOnReturn";
		LuaCSFunction get92 = null;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name92, get92, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache108, true);
		string name93 = "EventOnSelectCard";
		LuaCSFunction get93 = null;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_EventOnSelectCard);
		}
		LuaObject.addMember(l, name93, get93, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache109, true);
		string name94 = "EventOnShowSelectCardHelp";
		LuaCSFunction get94 = null;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_EventOnShowSelectCardHelp);
		}
		LuaObject.addMember(l, name94, get94, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10A, true);
		string name95 = "EventOnShowActivityDetail";
		LuaCSFunction get95 = null;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_EventOnShowActivityDetail);
		}
		LuaObject.addMember(l, name95, get95, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10B, true);
		string name96 = "EventOnBagCapcityNotEnough";
		LuaCSFunction get96 = null;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_EventOnBagCapcityNotEnough);
		}
		LuaObject.addMember(l, name96, get96, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10C, true);
		string name97 = "EventOnCrystalNotEnough";
		LuaCSFunction get97 = null;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, name97, get97, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10D, true);
		string name98 = "EventOnAddCrystal";
		LuaCSFunction get98 = null;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_EventOnAddCrystal);
		}
		LuaObject.addMember(l, name98, get98, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10E, true);
		string name99 = "m_cardPoolId";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_cardPoolId);
		}
		LuaCSFunction get99 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache10F;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_cardPoolId);
		}
		LuaObject.addMember(l, name99, get99, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache110, true);
		string name100 = "m_cardPool";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_cardPool);
		}
		LuaCSFunction get100 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache111;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_cardPool);
		}
		LuaObject.addMember(l, name100, get100, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache112, true);
		string name101 = "m_isClockHold";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_isClockHold);
		}
		LuaCSFunction get101 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache113;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_isClockHold);
		}
		LuaObject.addMember(l, name101, get101, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache114, true);
		string name102 = "m_isSingleSelect";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_isSingleSelect);
		}
		LuaCSFunction get102 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache115;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_isSingleSelect);
		}
		LuaObject.addMember(l, name102, get102, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache116, true);
		string name103 = "m_isContinueButtonClick";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_isContinueButtonClick);
		}
		LuaCSFunction get103 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache117;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_isContinueButtonClick);
		}
		LuaObject.addMember(l, name103, get103, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache118, true);
		string name104 = "m_selectRewards";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_selectRewards);
		}
		LuaCSFunction get104 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache119;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_selectRewards);
		}
		LuaObject.addMember(l, name104, get104, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11A, true);
		string name105 = "PoolItemNameText";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_PoolItemNameText);
		}
		LuaObject.addMember(l, name105, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11B, null, false);
		string name106 = "NormalCardId";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_NormalCardId);
		}
		LuaObject.addMember(l, name106, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11C, null, false);
		string name107 = "CrystalCardId";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_CrystalCardId);
		}
		LuaObject.addMember(l, name107, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11D, null, false);
		string name108 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_playerContext);
		}
		LuaCSFunction get105 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11E;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name108, get105, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache11F, true);
		string name109 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_configDataLoader);
		}
		LuaCSFunction get106 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache120;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name109, get106, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache121, true);
		string name110 = "m_heroCharUIController";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_heroCharUIController);
		}
		LuaCSFunction get107 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache122;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_heroCharUIController);
		}
		LuaObject.addMember(l, name110, get107, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache123, true);
		string name111 = "m_selectCardBackground3DController";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_selectCardBackground3DController);
		}
		LuaCSFunction get108 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache124;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_selectCardBackground3DController);
		}
		LuaObject.addMember(l, name111, get108, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache125, true);
		string name112 = "m_shareTenSelectCardUIController";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_shareTenSelectCardUIController);
		}
		LuaCSFunction get109 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache126;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_shareTenSelectCardUIController);
		}
		LuaObject.addMember(l, name112, get109, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache127, true);
		string name113 = "m_hasShowClockEffect";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_hasShowClockEffect);
		}
		LuaCSFunction get110 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache128;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_hasShowClockEffect);
		}
		LuaObject.addMember(l, name113, get110, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache129, true);
		string name114 = "m_toggleCtrlList";
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.get_m_toggleCtrlList);
		}
		LuaCSFunction get111 = Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache12A;
		if (Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardUIController.set_m_toggleCtrlList);
		}
		LuaObject.addMember(l, name114, get111, Lua_BlackJack_ProjectL_UI_SelectCardUIController.<>f__mg$cache12B, true);
		LuaObject.createTypeMetatable(l, null, typeof(SelectCardUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016D69 RID: 93545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016D6A RID: 93546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016D6B RID: 93547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016D6C RID: 93548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016D6D RID: 93549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016D6E RID: 93550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016D6F RID: 93551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016D70 RID: 93552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016D71 RID: 93553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016D72 RID: 93554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016D73 RID: 93555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016D74 RID: 93556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016D75 RID: 93557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016D76 RID: 93558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016D77 RID: 93559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016D78 RID: 93560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016D79 RID: 93561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016D7A RID: 93562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016D7B RID: 93563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016D7C RID: 93564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016D7D RID: 93565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016D7E RID: 93566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016D7F RID: 93567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016D80 RID: 93568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016D81 RID: 93569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016D82 RID: 93570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016D83 RID: 93571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016D84 RID: 93572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016D85 RID: 93573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016D86 RID: 93574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016D87 RID: 93575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016D88 RID: 93576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016D89 RID: 93577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016D8A RID: 93578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016D8B RID: 93579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016D8C RID: 93580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016D8D RID: 93581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016D8E RID: 93582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016D8F RID: 93583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016D90 RID: 93584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016D91 RID: 93585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016D92 RID: 93586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016D93 RID: 93587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016D94 RID: 93588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016D95 RID: 93589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016D96 RID: 93590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016D97 RID: 93591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016D98 RID: 93592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016D99 RID: 93593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016D9A RID: 93594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016D9B RID: 93595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016D9C RID: 93596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016D9D RID: 93597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016D9E RID: 93598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016D9F RID: 93599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016DA0 RID: 93600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016DA1 RID: 93601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016DA2 RID: 93602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016DA3 RID: 93603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016DA4 RID: 93604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04016DA5 RID: 93605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04016DA6 RID: 93606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04016DA7 RID: 93607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04016DA8 RID: 93608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04016DA9 RID: 93609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04016DAA RID: 93610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04016DAB RID: 93611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04016DAC RID: 93612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04016DAD RID: 93613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04016DAE RID: 93614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04016DAF RID: 93615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04016DB0 RID: 93616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04016DB1 RID: 93617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04016DB2 RID: 93618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04016DB3 RID: 93619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04016DB4 RID: 93620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04016DB5 RID: 93621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04016DB6 RID: 93622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04016DB7 RID: 93623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04016DB8 RID: 93624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04016DB9 RID: 93625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04016DBA RID: 93626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04016DBB RID: 93627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04016DBC RID: 93628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04016DBD RID: 93629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04016DBE RID: 93630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04016DBF RID: 93631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04016DC0 RID: 93632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04016DC1 RID: 93633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04016DC2 RID: 93634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04016DC3 RID: 93635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04016DC4 RID: 93636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04016DC5 RID: 93637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04016DC6 RID: 93638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04016DC7 RID: 93639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04016DC8 RID: 93640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04016DC9 RID: 93641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04016DCA RID: 93642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04016DCB RID: 93643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04016DCC RID: 93644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04016DCD RID: 93645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04016DCE RID: 93646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04016DCF RID: 93647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04016DD0 RID: 93648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04016DD1 RID: 93649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04016DD2 RID: 93650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04016DD3 RID: 93651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04016DD4 RID: 93652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04016DD5 RID: 93653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04016DD6 RID: 93654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04016DD7 RID: 93655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04016DD8 RID: 93656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04016DD9 RID: 93657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04016DDA RID: 93658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04016DDB RID: 93659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04016DDC RID: 93660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04016DDD RID: 93661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04016DDE RID: 93662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04016DDF RID: 93663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04016DE0 RID: 93664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04016DE1 RID: 93665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04016DE2 RID: 93666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04016DE3 RID: 93667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04016DE4 RID: 93668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04016DE5 RID: 93669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04016DE6 RID: 93670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04016DE7 RID: 93671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04016DE8 RID: 93672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04016DE9 RID: 93673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04016DEA RID: 93674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04016DEB RID: 93675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04016DEC RID: 93676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04016DED RID: 93677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04016DEE RID: 93678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04016DEF RID: 93679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04016DF0 RID: 93680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04016DF1 RID: 93681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04016DF2 RID: 93682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04016DF3 RID: 93683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04016DF4 RID: 93684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04016DF5 RID: 93685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04016DF6 RID: 93686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04016DF7 RID: 93687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04016DF8 RID: 93688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04016DF9 RID: 93689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04016DFA RID: 93690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04016DFB RID: 93691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04016DFC RID: 93692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04016DFD RID: 93693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04016DFE RID: 93694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04016DFF RID: 93695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04016E00 RID: 93696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04016E01 RID: 93697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04016E02 RID: 93698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04016E03 RID: 93699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04016E04 RID: 93700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04016E05 RID: 93701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04016E06 RID: 93702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04016E07 RID: 93703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04016E08 RID: 93704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04016E09 RID: 93705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04016E0A RID: 93706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04016E0B RID: 93707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04016E0C RID: 93708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04016E0D RID: 93709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04016E0E RID: 93710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04016E0F RID: 93711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04016E10 RID: 93712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04016E11 RID: 93713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04016E12 RID: 93714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04016E13 RID: 93715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04016E14 RID: 93716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04016E15 RID: 93717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04016E16 RID: 93718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04016E17 RID: 93719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04016E18 RID: 93720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04016E19 RID: 93721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04016E1A RID: 93722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04016E1B RID: 93723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04016E1C RID: 93724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04016E1D RID: 93725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04016E1E RID: 93726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04016E1F RID: 93727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04016E20 RID: 93728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x04016E21 RID: 93729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x04016E22 RID: 93730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x04016E23 RID: 93731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x04016E24 RID: 93732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x04016E25 RID: 93733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x04016E26 RID: 93734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x04016E27 RID: 93735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x04016E28 RID: 93736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x04016E29 RID: 93737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04016E2A RID: 93738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04016E2B RID: 93739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04016E2C RID: 93740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04016E2D RID: 93741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x04016E2E RID: 93742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x04016E2F RID: 93743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x04016E30 RID: 93744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x04016E31 RID: 93745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x04016E32 RID: 93746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04016E33 RID: 93747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x04016E34 RID: 93748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x04016E35 RID: 93749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x04016E36 RID: 93750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x04016E37 RID: 93751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x04016E38 RID: 93752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x04016E39 RID: 93753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04016E3A RID: 93754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04016E3B RID: 93755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04016E3C RID: 93756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x04016E3D RID: 93757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x04016E3E RID: 93758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04016E3F RID: 93759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x04016E40 RID: 93760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x04016E41 RID: 93761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04016E42 RID: 93762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04016E43 RID: 93763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x04016E44 RID: 93764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x04016E45 RID: 93765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x04016E46 RID: 93766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x04016E47 RID: 93767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x04016E48 RID: 93768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x04016E49 RID: 93769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x04016E4A RID: 93770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x04016E4B RID: 93771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x04016E4C RID: 93772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x04016E4D RID: 93773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x04016E4E RID: 93774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x04016E4F RID: 93775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x04016E50 RID: 93776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x04016E51 RID: 93777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x04016E52 RID: 93778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x04016E53 RID: 93779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x04016E54 RID: 93780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x04016E55 RID: 93781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x04016E56 RID: 93782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x04016E57 RID: 93783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x04016E58 RID: 93784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x04016E59 RID: 93785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x04016E5A RID: 93786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x04016E5B RID: 93787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x04016E5C RID: 93788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x04016E5D RID: 93789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x04016E5E RID: 93790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x04016E5F RID: 93791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x04016E60 RID: 93792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x04016E61 RID: 93793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x04016E62 RID: 93794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x04016E63 RID: 93795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x04016E64 RID: 93796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x04016E65 RID: 93797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x04016E66 RID: 93798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x04016E67 RID: 93799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x04016E68 RID: 93800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x04016E69 RID: 93801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x04016E6A RID: 93802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x04016E6B RID: 93803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x04016E6C RID: 93804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x04016E6D RID: 93805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x04016E6E RID: 93806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x04016E6F RID: 93807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x04016E70 RID: 93808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x04016E71 RID: 93809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x04016E72 RID: 93810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x04016E73 RID: 93811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x04016E74 RID: 93812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x04016E75 RID: 93813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x04016E76 RID: 93814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x04016E77 RID: 93815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x04016E78 RID: 93816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x04016E79 RID: 93817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x04016E7A RID: 93818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x04016E7B RID: 93819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x04016E7C RID: 93820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x04016E7D RID: 93821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x04016E7E RID: 93822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x04016E7F RID: 93823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x04016E80 RID: 93824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x04016E81 RID: 93825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x04016E82 RID: 93826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x04016E83 RID: 93827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x04016E84 RID: 93828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x04016E85 RID: 93829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x04016E86 RID: 93830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x04016E87 RID: 93831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x04016E88 RID: 93832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x04016E89 RID: 93833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x04016E8A RID: 93834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x04016E8B RID: 93835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x04016E8C RID: 93836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x04016E8D RID: 93837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x04016E8E RID: 93838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x04016E8F RID: 93839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x04016E90 RID: 93840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x04016E91 RID: 93841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x04016E92 RID: 93842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x04016E93 RID: 93843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x04016E94 RID: 93844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;
}
