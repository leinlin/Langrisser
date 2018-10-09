using System;
using System.Collections;
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

// Token: 0x020014CF RID: 5327
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController : LuaObject
{
	// Token: 0x0601F2A9 RID: 127657 RVA: 0x00A2CD30 File Offset: 0x00A2AF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHero(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataJobConnectionInfo jci;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 3, out jci);
			heroJobTransferUIController.SetHero(hero, jci);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2AA RID: 127658 RVA: 0x00A2CD94 File Offset: 0x00A2AF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInHeroJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.UpdateViewInHeroJobTransfer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2AB RID: 127659 RVA: 0x00A2CDE0 File Offset: 0x00A2AFE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroJobTransferSucceed(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.OnHeroJobTransferSucceed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2AC RID: 127660 RVA: 0x00A2CE2C File Offset: 0x00A2B02C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SortJobConnectionIdByUISort_s(IntPtr l)
	{
		int result;
		try
		{
			int j;
			LuaObject.checkType(l, 1, out j);
			int j2;
			LuaObject.checkType(l, 2, out j2);
			int i = HeroJobTransferUIController.SortJobConnectionIdByUISort(j, j2);
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

	// Token: 0x0601F2AD RID: 127661 RVA: 0x00A2CE8C File Offset: 0x00A2B08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2AE RID: 127662 RVA: 0x00A2CEE0 File Offset: 0x00A2B0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DrawLines(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			List<int> ids;
			LuaObject.checkType<List<int>>(l, 2, out ids);
			IEnumerator o = heroJobTransferUIController.m_luaExportHelper.DrawLines(ids);
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

	// Token: 0x0601F2AF RID: 127663 RVA: 0x00A2CF48 File Offset: 0x00A2B148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DynamicSetTransferLines(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			List<int> ids;
			LuaObject.checkType<List<int>>(l, 2, out ids);
			heroJobTransferUIController.m_luaExportHelper.DynamicSetTransferLines(ids);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2B0 RID: 127664 RVA: 0x00A2CFA4 File Offset: 0x00A2B1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLineImageColor(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image img;
			LuaObject.checkType<Image>(l, 2, out img);
			bool canTransfer;
			LuaObject.checkType(l, 3, out canTransfer);
			heroJobTransferUIController.m_luaExportHelper.SetLineImageColor(img, canTransfer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2B1 RID: 127665 RVA: 0x00A2D010 File Offset: 0x00A2B210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearGridLayout(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.ClearGridLayout();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2B2 RID: 127666 RVA: 0x00A2D064 File Offset: 0x00A2B264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGridLayoutByRank(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			int rank;
			LuaObject.checkType(l, 2, out rank);
			GameObject gridLayoutByRank = heroJobTransferUIController.m_luaExportHelper.GetGridLayoutByRank(rank);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridLayoutByRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2B3 RID: 127667 RVA: 0x00A2D0CC File Offset: 0x00A2B2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobCardItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			HeroJobCardItemUIController ctrl;
			LuaObject.checkType<HeroJobCardItemUIController>(l, 2, out ctrl);
			heroJobTransferUIController.m_luaExportHelper.OnJobCardItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2B4 RID: 127668 RVA: 0x00A2D128 File Offset: 0x00A2B328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo heroInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out heroInfo);
			heroJobTransferUIController.m_luaExportHelper.SetHeroInfo(heroInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2B5 RID: 127669 RVA: 0x00A2D184 File Offset: 0x00A2B384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCanLearnSkills(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			List<ConfigDataSkillInfo> canLearnSkills;
			LuaObject.checkType<List<ConfigDataSkillInfo>>(l, 2, out canLearnSkills);
			heroJobTransferUIController.m_luaExportHelper.SetCanLearnSkills(canLearnSkills);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2B6 RID: 127670 RVA: 0x00A2D1E0 File Offset: 0x00A2B3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCanLearnSoldiers(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			List<ConfigDataSoldierInfo> canLearnSoldiers;
			LuaObject.checkType<List<ConfigDataSoldierInfo>>(l, 2, out canLearnSoldiers);
			heroJobTransferUIController.m_luaExportHelper.SetCanLearnSoldiers(canLearnSoldiers);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2B7 RID: 127671 RVA: 0x00A2D23C File Offset: 0x00A2B43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseHeroJobInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.CloseHeroJobInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2B8 RID: 127672 RVA: 0x00A2D290 File Offset: 0x00A2B490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobTransferButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.OnJobTransferButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2B9 RID: 127673 RVA: 0x00A2D2E4 File Offset: 0x00A2B4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseJobTransferConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.CloseJobTransferConfirmPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2BA RID: 127674 RVA: 0x00A2D338 File Offset: 0x00A2B538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseJobTransferLockedPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.CloseJobTransferLockedPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2BB RID: 127675 RVA: 0x00A2D38C File Offset: 0x00A2B58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobUnlockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.OnJobUnlockButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2BC RID: 127676 RVA: 0x00A2D3E0 File Offset: 0x00A2B5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnLockHeroJobReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.OnUnLockHeroJobReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2BD RID: 127677 RVA: 0x00A2D434 File Offset: 0x00A2B634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnLockHeroJobUnlockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.OnUnLockHeroJobUnlockButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2BE RID: 127678 RVA: 0x00A2D488 File Offset: 0x00A2B688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobTransferConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.OnJobTransferConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2BF RID: 127679 RVA: 0x00A2D4DC File Offset: 0x00A2B6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCanLearnSkillAndSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.GetCanLearnSkillAndSoldier();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2C0 RID: 127680 RVA: 0x00A2D530 File Offset: 0x00A2B730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkipBtnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.OnSkipBtnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2C1 RID: 127681 RVA: 0x00A2D584 File Offset: 0x00A2B784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayJobTransfetEffectStep1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			IEnumerator o = heroJobTransferUIController.m_luaExportHelper.PlayJobTransfetEffectStep1();
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

	// Token: 0x0601F2C2 RID: 127682 RVA: 0x00A2D5E0 File Offset: 0x00A2B7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayJobTransfetEffectStep2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			IEnumerator o = heroJobTransferUIController.m_luaExportHelper.PlayJobTransfetEffectStep2();
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

	// Token: 0x0601F2C3 RID: 127683 RVA: 0x00A2D63C File Offset: 0x00A2B83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowLearnedSkillAndSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			IEnumerator o = heroJobTransferUIController.m_luaExportHelper.ShowLearnedSkillAndSoldier();
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

	// Token: 0x0601F2C4 RID: 127684 RVA: 0x00A2D698 File Offset: 0x00A2B898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseLearnedSkillPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.CloseLearnedSkillPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2C5 RID: 127685 RVA: 0x00A2D6EC File Offset: 0x00A2B8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseLearnedPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.CloseLearnedPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2C6 RID: 127686 RVA: 0x00A2D740 File Offset: 0x00A2B940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobTransferEffectContinueButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.OnJobTransferEffectContinueButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2C7 RID: 127687 RVA: 0x00A2D794 File Offset: 0x00A2B994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTransferSucceedInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.SetTransferSucceedInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2C8 RID: 127688 RVA: 0x00A2D7E8 File Offset: 0x00A2B9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PropertyToString(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			int value;
			LuaObject.checkType(l, 2, out value);
			int value2;
			LuaObject.checkType(l, 3, out value2);
			Image img;
			LuaObject.checkType<Image>(l, 4, out img);
			string s = heroJobTransferUIController.m_luaExportHelper.PropertyToString(value, value2, img);
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

	// Token: 0x0601F2C9 RID: 127689 RVA: 0x00A2D86C File Offset: 0x00A2BA6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetImageState(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image img;
			LuaObject.checkType<Image>(l, 2, out img);
			int t;
			LuaObject.checkType(l, 3, out t);
			heroJobTransferUIController.m_luaExportHelper.SetImageState(img, t);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2CA RID: 127690 RVA: 0x00A2D8D8 File Offset: 0x00A2BAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMasterRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.OnMasterRewardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2CB RID: 127691 RVA: 0x00A2D92C File Offset: 0x00A2BB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseMasterInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.CloseMasterInfoPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2CC RID: 127692 RVA: 0x00A2D980 File Offset: 0x00A2BB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			UISpineGraphic o;
			LuaObject.checkType<UISpineGraphic>(l, 2, out o);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 3, out jobConnectionInfo);
			GameObject graphice;
			LuaObject.checkType<GameObject>(l, 4, out graphice);
			float scaleNum;
			LuaObject.checkType(l, 5, out scaleNum);
			string anim;
			LuaObject.checkType(l, 6, out anim);
			int team;
			LuaObject.checkType(l, 7, out team);
			heroJobTransferUIController.m_luaExportHelper.CreateSpineGraphic(ref o, jobConnectionInfo, graphice, scaleNum, anim, team);
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

	// Token: 0x0601F2CD RID: 127693 RVA: 0x00A2DA24 File Offset: 0x00A2BC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSoldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			UISpineGraphic o;
			LuaObject.checkType<UISpineGraphic>(l, 2, out o);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 3, out soldierInfo);
			GameObject graphice;
			LuaObject.checkType<GameObject>(l, 4, out graphice);
			float scales;
			LuaObject.checkType(l, 5, out scales);
			int team;
			LuaObject.checkType(l, 6, out team);
			heroJobTransferUIController.m_luaExportHelper.CreateSoldierGraphic(ref o, soldierInfo, graphice, scales, team);
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

	// Token: 0x0601F2CE RID: 127694 RVA: 0x00A2DABC File Offset: 0x00A2BCBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			UISpineGraphic o;
			LuaObject.checkType<UISpineGraphic>(l, 2, out o);
			heroJobTransferUIController.m_luaExportHelper.DestroyGraphic(ref o);
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

	// Token: 0x0601F2CF RID: 127695 RVA: 0x00A2DB20 File Offset: 0x00A2BD20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.OnGoldAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2D0 RID: 127696 RVA: 0x00A2DB74 File Offset: 0x00A2BD74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMagicStoneClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.OnMagicStoneClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2D1 RID: 127697 RVA: 0x00A2DBC8 File Offset: 0x00A2BDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2D2 RID: 127698 RVA: 0x00A2DC1C File Offset: 0x00A2BE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroJobTransferUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2D3 RID: 127699 RVA: 0x00A2DC88 File Offset: 0x00A2BE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2D4 RID: 127700 RVA: 0x00A2DCDC File Offset: 0x00A2BEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2D5 RID: 127701 RVA: 0x00A2DD30 File Offset: 0x00A2BF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroJobTransferUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F2D6 RID: 127702 RVA: 0x00A2DDD8 File Offset: 0x00A2BFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2D7 RID: 127703 RVA: 0x00A2DE2C File Offset: 0x00A2C02C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroJobTransferUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2D8 RID: 127704 RVA: 0x00A2DE98 File Offset: 0x00A2C098
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
				HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroJobTransferUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroJobTransferUIController heroJobTransferUIController2 = (HeroJobTransferUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroJobTransferUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F2D9 RID: 127705 RVA: 0x00A2DFA8 File Offset: 0x00A2C1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2DA RID: 127706 RVA: 0x00A2E014 File Offset: 0x00A2C214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2DB RID: 127707 RVA: 0x00A2E080 File Offset: 0x00A2C280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2DC RID: 127708 RVA: 0x00A2E0EC File Offset: 0x00A2C2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2DD RID: 127709 RVA: 0x00A2E158 File Offset: 0x00A2C358
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
				HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroJobTransferUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroJobTransferUIController heroJobTransferUIController2 = (HeroJobTransferUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroJobTransferUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F2DE RID: 127710 RVA: 0x00A2E268 File Offset: 0x00A2C468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			string s = heroJobTransferUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F2DF RID: 127711 RVA: 0x00A2E2C4 File Offset: 0x00A2C4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2E0 RID: 127712 RVA: 0x00A2E318 File Offset: 0x00A2C518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2E1 RID: 127713 RVA: 0x00A2E36C File Offset: 0x00A2C56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddGold(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.__callDele_EventOnAddGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2E2 RID: 127714 RVA: 0x00A2E3C0 File Offset: 0x00A2C5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddGold(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.__clearDele_EventOnAddGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2E3 RID: 127715 RVA: 0x00A2E414 File Offset: 0x00A2C614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroJobUnlock(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			heroJobTransferUIController.m_luaExportHelper.__callDele_EventOnHeroJobUnlock(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2E4 RID: 127716 RVA: 0x00A2E48C File Offset: 0x00A2C68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroJobUnlock(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			heroJobTransferUIController.m_luaExportHelper.__clearDele_EventOnHeroJobUnlock(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2E5 RID: 127717 RVA: 0x00A2E504 File Offset: 0x00A2C704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroJobTransferFinishedForUserGuide(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.__callDele_EventOnHeroJobTransferFinishedForUserGuide();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2E6 RID: 127718 RVA: 0x00A2E558 File Offset: 0x00A2C758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroJobTransferFinishedForUserGuide(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			heroJobTransferUIController.m_luaExportHelper.__clearDele_EventOnHeroJobTransferFinishedForUserGuide();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2E7 RID: 127719 RVA: 0x00A2E5AC File Offset: 0x00A2C7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			heroJobTransferUIController.m_luaExportHelper.__callDele_EventOnHeroJobTransfer(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2E8 RID: 127720 RVA: 0x00A2E624 File Offset: 0x00A2C824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			heroJobTransferUIController.m_luaExportHelper.__clearDele_EventOnHeroJobTransfer(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2E9 RID: 127721 RVA: 0x00A2E69C File Offset: 0x00A2C89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroJobCardClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo obj;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out obj);
			heroJobTransferUIController.m_luaExportHelper.__callDele_EventOnHeroJobCardClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2EA RID: 127722 RVA: 0x00A2E6F8 File Offset: 0x00A2C8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroJobCardClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo obj;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out obj);
			heroJobTransferUIController.m_luaExportHelper.__clearDele_EventOnHeroJobCardClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2EB RID: 127723 RVA: 0x00A2E754 File Offset: 0x00A2C954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroJobTransferUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroJobTransferUIController.EventOnReturn -= value;
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

	// Token: 0x0601F2EC RID: 127724 RVA: 0x00A2E7D4 File Offset: 0x00A2C9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddGold(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroJobTransferUIController.EventOnAddGold += value;
				}
				else if (num == 2)
				{
					heroJobTransferUIController.EventOnAddGold -= value;
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

	// Token: 0x0601F2ED RID: 127725 RVA: 0x00A2E854 File Offset: 0x00A2CA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroJobUnlock(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Action<int, int, Action> value;
			int num = LuaObject.checkDelegate<Action<int, int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroJobTransferUIController.EventOnHeroJobUnlock += value;
				}
				else if (num == 2)
				{
					heroJobTransferUIController.EventOnHeroJobUnlock -= value;
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

	// Token: 0x0601F2EE RID: 127726 RVA: 0x00A2E8D4 File Offset: 0x00A2CAD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroJobTransferFinishedForUserGuide(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroJobTransferUIController.EventOnHeroJobTransferFinishedForUserGuide += value;
				}
				else if (num == 2)
				{
					heroJobTransferUIController.EventOnHeroJobTransferFinishedForUserGuide -= value;
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

	// Token: 0x0601F2EF RID: 127727 RVA: 0x00A2E954 File Offset: 0x00A2CB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Action<int, int, Action> value;
			int num = LuaObject.checkDelegate<Action<int, int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroJobTransferUIController.EventOnHeroJobTransfer += value;
				}
				else if (num == 2)
				{
					heroJobTransferUIController.EventOnHeroJobTransfer -= value;
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

	// Token: 0x0601F2F0 RID: 127728 RVA: 0x00A2E9D4 File Offset: 0x00A2CBD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroJobCardClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Action<ConfigDataJobConnectionInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataJobConnectionInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroJobTransferUIController.EventOnHeroJobCardClick += value;
				}
				else if (num == 2)
				{
					heroJobTransferUIController.EventOnHeroJobCardClick -= value;
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

	// Token: 0x0601F2F1 RID: 127729 RVA: 0x00A2EA54 File Offset: 0x00A2CC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2F2 RID: 127730 RVA: 0x00A2EAAC File Offset: 0x00A2CCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			heroJobTransferUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2F3 RID: 127731 RVA: 0x00A2EB08 File Offset: 0x00A2CD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankLayout1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_rankLayout1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2F4 RID: 127732 RVA: 0x00A2EB60 File Offset: 0x00A2CD60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankLayout1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject rankLayout;
			LuaObject.checkType<GameObject>(l, 2, out rankLayout);
			heroJobTransferUIController.m_luaExportHelper.m_rankLayout1 = rankLayout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2F5 RID: 127733 RVA: 0x00A2EBBC File Offset: 0x00A2CDBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankLayout2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_rankLayout2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2F6 RID: 127734 RVA: 0x00A2EC14 File Offset: 0x00A2CE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankLayout2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject rankLayout;
			LuaObject.checkType<GameObject>(l, 2, out rankLayout);
			heroJobTransferUIController.m_luaExportHelper.m_rankLayout2 = rankLayout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2F7 RID: 127735 RVA: 0x00A2EC70 File Offset: 0x00A2CE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankLayout3(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_rankLayout3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2F8 RID: 127736 RVA: 0x00A2ECC8 File Offset: 0x00A2CEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankLayout3(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject rankLayout;
			LuaObject.checkType<GameObject>(l, 2, out rankLayout);
			heroJobTransferUIController.m_luaExportHelper.m_rankLayout3 = rankLayout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2F9 RID: 127737 RVA: 0x00A2ED24 File Offset: 0x00A2CF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankLayout4(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_rankLayout4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2FA RID: 127738 RVA: 0x00A2ED7C File Offset: 0x00A2CF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankLayout4(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject rankLayout;
			LuaObject.checkType<GameObject>(l, 2, out rankLayout);
			heroJobTransferUIController.m_luaExportHelper.m_rankLayout4 = rankLayout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2FB RID: 127739 RVA: 0x00A2EDD8 File Offset: 0x00A2CFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankLine1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_rankLine1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2FC RID: 127740 RVA: 0x00A2EE30 File Offset: 0x00A2D030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankLine1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject rankLine;
			LuaObject.checkType<GameObject>(l, 2, out rankLine);
			heroJobTransferUIController.m_luaExportHelper.m_rankLine1 = rankLine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2FD RID: 127741 RVA: 0x00A2EE8C File Offset: 0x00A2D08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankLine1Image(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_rankLine1Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2FE RID: 127742 RVA: 0x00A2EEE4 File Offset: 0x00A2D0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankLine1Image(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image rankLine1Image;
			LuaObject.checkType<Image>(l, 2, out rankLine1Image);
			heroJobTransferUIController.m_luaExportHelper.m_rankLine1Image = rankLine1Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F2FF RID: 127743 RVA: 0x00A2EF40 File Offset: 0x00A2D140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankLine2Image(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_rankLine2Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F300 RID: 127744 RVA: 0x00A2EF98 File Offset: 0x00A2D198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankLine2Image(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image rankLine2Image;
			LuaObject.checkType<Image>(l, 2, out rankLine2Image);
			heroJobTransferUIController.m_luaExportHelper.m_rankLine2Image = rankLine2Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F301 RID: 127745 RVA: 0x00A2EFF4 File Offset: 0x00A2D1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankLine2Image1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_rankLine2Image1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F302 RID: 127746 RVA: 0x00A2F04C File Offset: 0x00A2D24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankLine2Image1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image rankLine2Image;
			LuaObject.checkType<Image>(l, 2, out rankLine2Image);
			heroJobTransferUIController.m_luaExportHelper.m_rankLine2Image1 = rankLine2Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F303 RID: 127747 RVA: 0x00A2F0A8 File Offset: 0x00A2D2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankLine2Image2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_rankLine2Image2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F304 RID: 127748 RVA: 0x00A2F100 File Offset: 0x00A2D300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankLine2Image2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image rankLine2Image;
			LuaObject.checkType<Image>(l, 2, out rankLine2Image);
			heroJobTransferUIController.m_luaExportHelper.m_rankLine2Image2 = rankLine2Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F305 RID: 127749 RVA: 0x00A2F15C File Offset: 0x00A2D35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankLine3Image(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_rankLine3Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F306 RID: 127750 RVA: 0x00A2F1B4 File Offset: 0x00A2D3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankLine3Image(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image rankLine3Image;
			LuaObject.checkType<Image>(l, 2, out rankLine3Image);
			heroJobTransferUIController.m_luaExportHelper.m_rankLine3Image = rankLine3Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F307 RID: 127751 RVA: 0x00A2F210 File Offset: 0x00A2D410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankLine3Image1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_rankLine3Image1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F308 RID: 127752 RVA: 0x00A2F268 File Offset: 0x00A2D468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankLine3Image1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image rankLine3Image;
			LuaObject.checkType<Image>(l, 2, out rankLine3Image);
			heroJobTransferUIController.m_luaExportHelper.m_rankLine3Image1 = rankLine3Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F309 RID: 127753 RVA: 0x00A2F2C4 File Offset: 0x00A2D4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankLine3Image2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_rankLine3Image2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F30A RID: 127754 RVA: 0x00A2F31C File Offset: 0x00A2D51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankLine3Image2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image rankLine3Image;
			LuaObject.checkType<Image>(l, 2, out rankLine3Image);
			heroJobTransferUIController.m_luaExportHelper.m_rankLine3Image2 = rankLine3Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F30B RID: 127755 RVA: 0x00A2F378 File Offset: 0x00A2D578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F30C RID: 127756 RVA: 0x00A2F3D0 File Offset: 0x00A2D5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			heroJobTransferUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F30D RID: 127757 RVA: 0x00A2F42C File Offset: 0x00A2D62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldNumText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_goldNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F30E RID: 127758 RVA: 0x00A2F484 File Offset: 0x00A2D684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldNumText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text goldNumText;
			LuaObject.checkType<Text>(l, 2, out goldNumText);
			heroJobTransferUIController.m_luaExportHelper.m_goldNumText = goldNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F30F RID: 127759 RVA: 0x00A2F4E0 File Offset: 0x00A2D6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldAddBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_goldAddBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F310 RID: 127760 RVA: 0x00A2F538 File Offset: 0x00A2D738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldAddBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button goldAddBtn;
			LuaObject.checkType<Button>(l, 2, out goldAddBtn);
			heroJobTransferUIController.m_luaExportHelper.m_goldAddBtn = goldAddBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F311 RID: 127761 RVA: 0x00A2F594 File Offset: 0x00A2D794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_magicStoneNumText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_magicStoneNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F312 RID: 127762 RVA: 0x00A2F5EC File Offset: 0x00A2D7EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_magicStoneNumText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text magicStoneNumText;
			LuaObject.checkType<Text>(l, 2, out magicStoneNumText);
			heroJobTransferUIController.m_luaExportHelper.m_magicStoneNumText = magicStoneNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F313 RID: 127763 RVA: 0x00A2F648 File Offset: 0x00A2D848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_magicStoneBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_magicStoneBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F314 RID: 127764 RVA: 0x00A2F6A0 File Offset: 0x00A2D8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_magicStoneBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button magicStoneBtn;
			LuaObject.checkType<Button>(l, 2, out magicStoneBtn);
			heroJobTransferUIController.m_luaExportHelper.m_magicStoneBtn = magicStoneBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F315 RID: 127765 RVA: 0x00A2F6FC File Offset: 0x00A2D8FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroJobInfoPanelObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_heroJobInfoPanelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F316 RID: 127766 RVA: 0x00A2F754 File Offset: 0x00A2D954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroJobInfoPanelObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject heroJobInfoPanelObj;
			LuaObject.checkType<GameObject>(l, 2, out heroJobInfoPanelObj);
			heroJobTransferUIController.m_luaExportHelper.m_heroJobInfoPanelObj = heroJobInfoPanelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F317 RID: 127767 RVA: 0x00A2F7B0 File Offset: 0x00A2D9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F318 RID: 127768 RVA: 0x00A2F808 File Offset: 0x00A2DA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobNameText;
			LuaObject.checkType<Text>(l, 2, out jobNameText);
			heroJobTransferUIController.m_luaExportHelper.m_jobNameText = jobNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F319 RID: 127769 RVA: 0x00A2F864 File Offset: 0x00A2DA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobNameEnText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobNameEnText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F31A RID: 127770 RVA: 0x00A2F8BC File Offset: 0x00A2DABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobNameEnText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobNameEnText;
			LuaObject.checkType<Text>(l, 2, out jobNameEnText);
			heroJobTransferUIController.m_luaExportHelper.m_jobNameEnText = jobNameEnText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F31B RID: 127771 RVA: 0x00A2F918 File Offset: 0x00A2DB18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTypeBgImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTypeBgImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F31C RID: 127772 RVA: 0x00A2F970 File Offset: 0x00A2DB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTypeBgImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject jobTypeBgImage;
			LuaObject.checkType<GameObject>(l, 2, out jobTypeBgImage);
			heroJobTransferUIController.m_luaExportHelper.m_jobTypeBgImage = jobTypeBgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F31D RID: 127773 RVA: 0x00A2F9CC File Offset: 0x00A2DBCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTypeBgImage2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTypeBgImage2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F31E RID: 127774 RVA: 0x00A2FA24 File Offset: 0x00A2DC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTypeBgImage2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject jobTypeBgImage;
			LuaObject.checkType<GameObject>(l, 2, out jobTypeBgImage);
			heroJobTransferUIController.m_luaExportHelper.m_jobTypeBgImage2 = jobTypeBgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F31F RID: 127775 RVA: 0x00A2FA80 File Offset: 0x00A2DC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTypeText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTypeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F320 RID: 127776 RVA: 0x00A2FAD8 File Offset: 0x00A2DCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTypeText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobTypeText;
			LuaObject.checkType<Text>(l, 2, out jobTypeText);
			heroJobTransferUIController.m_luaExportHelper.m_jobTypeText = jobTypeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F321 RID: 127777 RVA: 0x00A2FB34 File Offset: 0x00A2DD34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMoveValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobMoveValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F322 RID: 127778 RVA: 0x00A2FB8C File Offset: 0x00A2DD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMoveValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobMoveValueText;
			LuaObject.checkType<Text>(l, 2, out jobMoveValueText);
			heroJobTransferUIController.m_luaExportHelper.m_jobMoveValueText = jobMoveValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F323 RID: 127779 RVA: 0x00A2FBE8 File Offset: 0x00A2DDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobRangeValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobRangeValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F324 RID: 127780 RVA: 0x00A2FC40 File Offset: 0x00A2DE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobRangeValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobRangeValueText;
			LuaObject.checkType<Text>(l, 2, out jobRangeValueText);
			heroJobTransferUIController.m_luaExportHelper.m_jobRangeValueText = jobRangeValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F325 RID: 127781 RVA: 0x00A2FC9C File Offset: 0x00A2DE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobAdvantageText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobAdvantageText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F326 RID: 127782 RVA: 0x00A2FCF4 File Offset: 0x00A2DEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobAdvantageText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobAdvantageText;
			LuaObject.checkType<Text>(l, 2, out jobAdvantageText);
			heroJobTransferUIController.m_luaExportHelper.m_jobAdvantageText = jobAdvantageText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F327 RID: 127783 RVA: 0x00A2FD50 File Offset: 0x00A2DF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobAdvantageText1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobAdvantageText1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F328 RID: 127784 RVA: 0x00A2FDA8 File Offset: 0x00A2DFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobAdvantageText1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobAdvantageText;
			LuaObject.checkType<Text>(l, 2, out jobAdvantageText);
			heroJobTransferUIController.m_luaExportHelper.m_jobAdvantageText1 = jobAdvantageText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F329 RID: 127785 RVA: 0x00A2FE04 File Offset: 0x00A2E004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobAdvantageText2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobAdvantageText2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F32A RID: 127786 RVA: 0x00A2FE5C File Offset: 0x00A2E05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobAdvantageText2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobAdvantageText;
			LuaObject.checkType<Text>(l, 2, out jobAdvantageText);
			heroJobTransferUIController.m_luaExportHelper.m_jobAdvantageText2 = jobAdvantageText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F32B RID: 127787 RVA: 0x00A2FEB8 File Offset: 0x00A2E0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_heroGraphicObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F32C RID: 127788 RVA: 0x00A2FF10 File Offset: 0x00A2E110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject heroGraphicObj;
			LuaObject.checkType<GameObject>(l, 2, out heroGraphicObj);
			heroJobTransferUIController.m_luaExportHelper.m_heroGraphicObj = heroGraphicObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F32D RID: 127789 RVA: 0x00A2FF6C File Offset: 0x00A2E16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobSoldierTypeImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobSoldierTypeImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F32E RID: 127790 RVA: 0x00A2FFC4 File Offset: 0x00A2E1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobSoldierTypeImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image jobSoldierTypeImage;
			LuaObject.checkType<Image>(l, 2, out jobSoldierTypeImage);
			heroJobTransferUIController.m_luaExportHelper.m_jobSoldierTypeImage = jobSoldierTypeImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F32F RID: 127791 RVA: 0x00A30020 File Offset: 0x00A2E220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransferButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransferButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F330 RID: 127792 RVA: 0x00A30078 File Offset: 0x00A2E278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransferButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button jobTransferButton;
			LuaObject.checkType<Button>(l, 2, out jobTransferButton);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransferButton = jobTransferButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F331 RID: 127793 RVA: 0x00A300D4 File Offset: 0x00A2E2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUnlockButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobUnlockButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F332 RID: 127794 RVA: 0x00A3012C File Offset: 0x00A2E32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUnlockButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button jobUnlockButton;
			LuaObject.checkType<Button>(l, 2, out jobUnlockButton);
			heroJobTransferUIController.m_luaExportHelper.m_jobUnlockButton = jobUnlockButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F333 RID: 127795 RVA: 0x00A30188 File Offset: 0x00A2E388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_masterButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_masterButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F334 RID: 127796 RVA: 0x00A301E0 File Offset: 0x00A2E3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_masterButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button masterButton;
			LuaObject.checkType<Button>(l, 2, out masterButton);
			heroJobTransferUIController.m_luaExportHelper.m_masterButton = masterButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F335 RID: 127797 RVA: 0x00A3023C File Offset: 0x00A2E43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_alreadyMasterValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_alreadyMasterValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F336 RID: 127798 RVA: 0x00A30294 File Offset: 0x00A2E494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_alreadyMasterValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text alreadyMasterValueText;
			LuaObject.checkType<Text>(l, 2, out alreadyMasterValueText);
			heroJobTransferUIController.m_luaExportHelper.m_alreadyMasterValueText = alreadyMasterValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F337 RID: 127799 RVA: 0x00A302F0 File Offset: 0x00A2E4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_masterInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_masterInfoPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F338 RID: 127800 RVA: 0x00A30348 File Offset: 0x00A2E548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_masterInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject masterInfoPanel;
			LuaObject.checkType<GameObject>(l, 2, out masterInfoPanel);
			heroJobTransferUIController.m_luaExportHelper.m_masterInfoPanel = masterInfoPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F339 RID: 127801 RVA: 0x00A303A4 File Offset: 0x00A2E5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_masterInfoPanelReturnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_masterInfoPanelReturnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F33A RID: 127802 RVA: 0x00A303FC File Offset: 0x00A2E5FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_masterInfoPanelReturnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button masterInfoPanelReturnButton;
			LuaObject.checkType<Button>(l, 2, out masterInfoPanelReturnButton);
			heroJobTransferUIController.m_luaExportHelper.m_masterInfoPanelReturnButton = masterInfoPanelReturnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F33B RID: 127803 RVA: 0x00A30458 File Offset: 0x00A2E658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_masterInfoPanelScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_masterInfoPanelScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F33C RID: 127804 RVA: 0x00A304B0 File Offset: 0x00A2E6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_masterInfoPanelScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject masterInfoPanelScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out masterInfoPanelScrollViewContent);
			heroJobTransferUIController.m_luaExportHelper.m_masterInfoPanelScrollViewContent = masterInfoPanelScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F33D RID: 127805 RVA: 0x00A3050C File Offset: 0x00A2E70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_masterItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_masterItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F33E RID: 127806 RVA: 0x00A30564 File Offset: 0x00A2E764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_masterItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject masterItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out masterItemPrefab);
			heroJobTransferUIController.m_luaExportHelper.m_masterItemPrefab = masterItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F33F RID: 127807 RVA: 0x00A305C0 File Offset: 0x00A2E7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLvBgImagesGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobLvBgImagesGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F340 RID: 127808 RVA: 0x00A30618 File Offset: 0x00A2E818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLvBgImagesGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject jobLvBgImagesGroup;
			LuaObject.checkType<GameObject>(l, 2, out jobLvBgImagesGroup);
			heroJobTransferUIController.m_luaExportHelper.m_jobLvBgImagesGroup = jobLvBgImagesGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F341 RID: 127809 RVA: 0x00A30674 File Offset: 0x00A2E874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLvImagesGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobLvImagesGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F342 RID: 127810 RVA: 0x00A306CC File Offset: 0x00A2E8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLvImagesGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject jobLvImagesGroup;
			LuaObject.checkType<GameObject>(l, 2, out jobLvImagesGroup);
			heroJobTransferUIController.m_luaExportHelper.m_jobLvImagesGroup = jobLvImagesGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F343 RID: 127811 RVA: 0x00A30728 File Offset: 0x00A2E928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedSkillIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedSkillIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F344 RID: 127812 RVA: 0x00A30780 File Offset: 0x00A2E980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedSkillIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject learnedSkillIconImg;
			LuaObject.checkType<GameObject>(l, 2, out learnedSkillIconImg);
			heroJobTransferUIController.m_luaExportHelper.m_learnedSkillIconImg = learnedSkillIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F345 RID: 127813 RVA: 0x00A307DC File Offset: 0x00A2E9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedSkillIconImg2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedSkillIconImg2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F346 RID: 127814 RVA: 0x00A30834 File Offset: 0x00A2EA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedSkillIconImg2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject learnedSkillIconImg;
			LuaObject.checkType<GameObject>(l, 2, out learnedSkillIconImg);
			heroJobTransferUIController.m_luaExportHelper.m_learnedSkillIconImg2 = learnedSkillIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F347 RID: 127815 RVA: 0x00A30890 File Offset: 0x00A2EA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_skillDetailPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F348 RID: 127816 RVA: 0x00A308E8 File Offset: 0x00A2EAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject skillDetailPanel;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailPanel);
			heroJobTransferUIController.m_luaExportHelper.m_skillDetailPanel = skillDetailPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F349 RID: 127817 RVA: 0x00A30944 File Offset: 0x00A2EB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedSoldierGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedSoldierGraphicObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F34A RID: 127818 RVA: 0x00A3099C File Offset: 0x00A2EB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedSoldierGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject learnedSoldierGraphicObj;
			LuaObject.checkType<GameObject>(l, 2, out learnedSoldierGraphicObj);
			heroJobTransferUIController.m_luaExportHelper.m_learnedSoldierGraphicObj = learnedSoldierGraphicObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F34B RID: 127819 RVA: 0x00A309F8 File Offset: 0x00A2EBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedSoldierGraphicObj2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedSoldierGraphicObj2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F34C RID: 127820 RVA: 0x00A30A50 File Offset: 0x00A2EC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedSoldierGraphicObj2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject learnedSoldierGraphicObj;
			LuaObject.checkType<GameObject>(l, 2, out learnedSoldierGraphicObj);
			heroJobTransferUIController.m_luaExportHelper.m_learnedSoldierGraphicObj2 = learnedSoldierGraphicObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F34D RID: 127821 RVA: 0x00A30AAC File Offset: 0x00A2ECAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedSoldierGraphicBg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedSoldierGraphicBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F34E RID: 127822 RVA: 0x00A30B04 File Offset: 0x00A2ED04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedSoldierGraphicBg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject learnedSoldierGraphicBg;
			LuaObject.checkType<GameObject>(l, 2, out learnedSoldierGraphicBg);
			heroJobTransferUIController.m_luaExportHelper.m_learnedSoldierGraphicBg = learnedSoldierGraphicBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F34F RID: 127823 RVA: 0x00A30B60 File Offset: 0x00A2ED60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedSoldierGraphicBg2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedSoldierGraphicBg2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F350 RID: 127824 RVA: 0x00A30BB8 File Offset: 0x00A2EDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedSoldierGraphicBg2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject learnedSoldierGraphicBg;
			LuaObject.checkType<GameObject>(l, 2, out learnedSoldierGraphicBg);
			heroJobTransferUIController.m_luaExportHelper.m_learnedSoldierGraphicBg2 = learnedSoldierGraphicBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F351 RID: 127825 RVA: 0x00A30C14 File Offset: 0x00A2EE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_soldierDetailPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F352 RID: 127826 RVA: 0x00A30C6C File Offset: 0x00A2EE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject soldierDetailPanel;
			LuaObject.checkType<GameObject>(l, 2, out soldierDetailPanel);
			heroJobTransferUIController.m_luaExportHelper.m_soldierDetailPanel = soldierDetailPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F353 RID: 127827 RVA: 0x00A30CC8 File Offset: 0x00A2EEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_transferLockPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_transferLockPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F354 RID: 127828 RVA: 0x00A30D20 File Offset: 0x00A2EF20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_transferLockPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject transferLockPanel;
			LuaObject.checkType<GameObject>(l, 2, out transferLockPanel);
			heroJobTransferUIController.m_luaExportHelper.m_transferLockPanel = transferLockPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F355 RID: 127829 RVA: 0x00A30D7C File Offset: 0x00A2EF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_transferLockPanelReturnBg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_transferLockPanelReturnBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F356 RID: 127830 RVA: 0x00A30DD4 File Offset: 0x00A2EFD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_transferLockPanelReturnBg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button transferLockPanelReturnBg;
			LuaObject.checkType<Button>(l, 2, out transferLockPanelReturnBg);
			heroJobTransferUIController.m_luaExportHelper.m_transferLockPanelReturnBg = transferLockPanelReturnBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F357 RID: 127831 RVA: 0x00A30E30 File Offset: 0x00A2F030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_transferLockQuesText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_transferLockQuesText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F358 RID: 127832 RVA: 0x00A30E88 File Offset: 0x00A2F088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_transferLockQuesText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text transferLockQuesText;
			LuaObject.checkType<Text>(l, 2, out transferLockQuesText);
			heroJobTransferUIController.m_luaExportHelper.m_transferLockQuesText = transferLockQuesText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F359 RID: 127833 RVA: 0x00A30EE4 File Offset: 0x00A2F0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_transferLockConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_transferLockConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F35A RID: 127834 RVA: 0x00A30F3C File Offset: 0x00A2F13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_transferLockConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button transferLockConfirmButton;
			LuaObject.checkType<Button>(l, 2, out transferLockConfirmButton);
			heroJobTransferUIController.m_luaExportHelper.m_transferLockConfirmButton = transferLockConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F35B RID: 127835 RVA: 0x00A30F98 File Offset: 0x00A2F198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_transferConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_transferConfirmPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F35C RID: 127836 RVA: 0x00A30FF0 File Offset: 0x00A2F1F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_transferConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject transferConfirmPanel;
			LuaObject.checkType<GameObject>(l, 2, out transferConfirmPanel);
			heroJobTransferUIController.m_luaExportHelper.m_transferConfirmPanel = transferConfirmPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F35D RID: 127837 RVA: 0x00A3104C File Offset: 0x00A2F24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confirmPanelJobNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_confirmPanelJobNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F35E RID: 127838 RVA: 0x00A310A4 File Offset: 0x00A2F2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_confirmPanelJobNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text confirmPanelJobNameText;
			LuaObject.checkType<Text>(l, 2, out confirmPanelJobNameText);
			heroJobTransferUIController.m_luaExportHelper.m_confirmPanelJobNameText = confirmPanelJobNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F35F RID: 127839 RVA: 0x00A31100 File Offset: 0x00A2F300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldCostValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_goldCostValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F360 RID: 127840 RVA: 0x00A31158 File Offset: 0x00A2F358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldCostValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text goldCostValueText;
			LuaObject.checkType<Text>(l, 2, out goldCostValueText);
			heroJobTransferUIController.m_luaExportHelper.m_goldCostValueText = goldCostValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F361 RID: 127841 RVA: 0x00A311B4 File Offset: 0x00A2F3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_magicStoneCostValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_magicStoneCostValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F362 RID: 127842 RVA: 0x00A3120C File Offset: 0x00A2F40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_magicStoneCostValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text magicStoneCostValueText;
			LuaObject.checkType<Text>(l, 2, out magicStoneCostValueText);
			heroJobTransferUIController.m_luaExportHelper.m_magicStoneCostValueText = magicStoneCostValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F363 RID: 127843 RVA: 0x00A31268 File Offset: 0x00A2F468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confirmBgButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_confirmBgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F364 RID: 127844 RVA: 0x00A312C0 File Offset: 0x00A2F4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_confirmBgButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button confirmBgButton;
			LuaObject.checkType<Button>(l, 2, out confirmBgButton);
			heroJobTransferUIController.m_luaExportHelper.m_confirmBgButton = confirmBgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F365 RID: 127845 RVA: 0x00A3131C File Offset: 0x00A2F51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confirmReturnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_confirmReturnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F366 RID: 127846 RVA: 0x00A31374 File Offset: 0x00A2F574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_confirmReturnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button confirmReturnButton;
			LuaObject.checkType<Button>(l, 2, out confirmReturnButton);
			heroJobTransferUIController.m_luaExportHelper.m_confirmReturnButton = confirmReturnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F367 RID: 127847 RVA: 0x00A313D0 File Offset: 0x00A2F5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confirmTransferButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_confirmTransferButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F368 RID: 127848 RVA: 0x00A31428 File Offset: 0x00A2F628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_confirmTransferButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button confirmTransferButton;
			LuaObject.checkType<Button>(l, 2, out confirmTransferButton);
			heroJobTransferUIController.m_luaExportHelper.m_confirmTransferButton = confirmTransferButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F369 RID: 127849 RVA: 0x00A31484 File Offset: 0x00A2F684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confirmTransferNoticeTextStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_confirmTransferNoticeTextStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F36A RID: 127850 RVA: 0x00A314DC File Offset: 0x00A2F6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_confirmTransferNoticeTextStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			CommonUIStateController confirmTransferNoticeTextStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out confirmTransferNoticeTextStateCtrl);
			heroJobTransferUIController.m_luaExportHelper.m_confirmTransferNoticeTextStateCtrl = confirmTransferNoticeTextStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F36B RID: 127851 RVA: 0x00A31538 File Offset: 0x00A2F738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unLockHeroJobPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_unLockHeroJobPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F36C RID: 127852 RVA: 0x00A31590 File Offset: 0x00A2F790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unLockHeroJobPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject unLockHeroJobPanel;
			LuaObject.checkType<GameObject>(l, 2, out unLockHeroJobPanel);
			heroJobTransferUIController.m_luaExportHelper.m_unLockHeroJobPanel = unLockHeroJobPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F36D RID: 127853 RVA: 0x00A315EC File Offset: 0x00A2F7EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unLockHeroJobPanelJobNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_unLockHeroJobPanelJobNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F36E RID: 127854 RVA: 0x00A31644 File Offset: 0x00A2F844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unLockHeroJobPanelJobNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text unLockHeroJobPanelJobNameText;
			LuaObject.checkType<Text>(l, 2, out unLockHeroJobPanelJobNameText);
			heroJobTransferUIController.m_luaExportHelper.m_unLockHeroJobPanelJobNameText = unLockHeroJobPanelJobNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F36F RID: 127855 RVA: 0x00A316A0 File Offset: 0x00A2F8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unLockHeroJobConditionsContentObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_unLockHeroJobConditionsContentObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F370 RID: 127856 RVA: 0x00A316F8 File Offset: 0x00A2F8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unLockHeroJobConditionsContentObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject unLockHeroJobConditionsContentObj;
			LuaObject.checkType<GameObject>(l, 2, out unLockHeroJobConditionsContentObj);
			heroJobTransferUIController.m_luaExportHelper.m_unLockHeroJobConditionsContentObj = unLockHeroJobConditionsContentObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F371 RID: 127857 RVA: 0x00A31754 File Offset: 0x00A2F954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlcokJobConditionPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_unlcokJobConditionPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F372 RID: 127858 RVA: 0x00A317AC File Offset: 0x00A2F9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlcokJobConditionPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject unlcokJobConditionPrefab;
			LuaObject.checkType<GameObject>(l, 2, out unlcokJobConditionPrefab);
			heroJobTransferUIController.m_luaExportHelper.m_unlcokJobConditionPrefab = unlcokJobConditionPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F373 RID: 127859 RVA: 0x00A31808 File Offset: 0x00A2FA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unLockHeroJobReturnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_unLockHeroJobReturnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F374 RID: 127860 RVA: 0x00A31860 File Offset: 0x00A2FA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unLockHeroJobReturnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button unLockHeroJobReturnButton;
			LuaObject.checkType<Button>(l, 2, out unLockHeroJobReturnButton);
			heroJobTransferUIController.m_luaExportHelper.m_unLockHeroJobReturnButton = unLockHeroJobReturnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F375 RID: 127861 RVA: 0x00A318BC File Offset: 0x00A2FABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unLockHeroJobUnlockButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_unLockHeroJobUnlockButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F376 RID: 127862 RVA: 0x00A31914 File Offset: 0x00A2FB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unLockHeroJobUnlockButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button unLockHeroJobUnlockButton;
			LuaObject.checkType<Button>(l, 2, out unLockHeroJobUnlockButton);
			heroJobTransferUIController.m_luaExportHelper.m_unLockHeroJobUnlockButton = unLockHeroJobUnlockButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F377 RID: 127863 RVA: 0x00A31970 File Offset: 0x00A2FB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransferEffectSkipBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransferEffectSkipBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F378 RID: 127864 RVA: 0x00A319C8 File Offset: 0x00A2FBC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransferEffectSkipBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button jobTransferEffectSkipBtn;
			LuaObject.checkType<Button>(l, 2, out jobTransferEffectSkipBtn);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransferEffectSkipBtn = jobTransferEffectSkipBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F379 RID: 127865 RVA: 0x00A31A24 File Offset: 0x00A2FC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_JobTransferEffectBgObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_JobTransferEffectBgObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F37A RID: 127866 RVA: 0x00A31A7C File Offset: 0x00A2FC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_JobTransferEffectBgObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject jobTransferEffectBgObj;
			LuaObject.checkType<GameObject>(l, 2, out jobTransferEffectBgObj);
			heroJobTransferUIController.m_luaExportHelper.m_JobTransferEffectBgObj = jobTransferEffectBgObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F37B RID: 127867 RVA: 0x00A31AD8 File Offset: 0x00A2FCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_JobTransferEffectBlackImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_JobTransferEffectBlackImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F37C RID: 127868 RVA: 0x00A31B30 File Offset: 0x00A2FD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_JobTransferEffectBlackImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject jobTransferEffectBlackImage;
			LuaObject.checkType<GameObject>(l, 2, out jobTransferEffectBlackImage);
			heroJobTransferUIController.m_luaExportHelper.m_JobTransferEffectBlackImage = jobTransferEffectBlackImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F37D RID: 127869 RVA: 0x00A31B8C File Offset: 0x00A2FD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_JobTransferEffectWhiteImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_JobTransferEffectWhiteImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F37E RID: 127870 RVA: 0x00A31BE4 File Offset: 0x00A2FDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_JobTransferEffectWhiteImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject jobTransferEffectWhiteImage;
			LuaObject.checkType<GameObject>(l, 2, out jobTransferEffectWhiteImage);
			heroJobTransferUIController.m_luaExportHelper.m_JobTransferEffectWhiteImage = jobTransferEffectWhiteImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F37F RID: 127871 RVA: 0x00A31C40 File Offset: 0x00A2FE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_JobTransferEffectBgImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_JobTransferEffectBgImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F380 RID: 127872 RVA: 0x00A31C98 File Offset: 0x00A2FE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_JobTransferEffectBgImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject jobTransferEffectBgImage;
			LuaObject.checkType<GameObject>(l, 2, out jobTransferEffectBgImage);
			heroJobTransferUIController.m_luaExportHelper.m_JobTransferEffectBgImage = jobTransferEffectBgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F381 RID: 127873 RVA: 0x00A31CF4 File Offset: 0x00A2FEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransferEffectContinueButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransferEffectContinueButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F382 RID: 127874 RVA: 0x00A31D4C File Offset: 0x00A2FF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransferEffectContinueButton(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button jobTransferEffectContinueButton;
			LuaObject.checkType<Button>(l, 2, out jobTransferEffectContinueButton);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransferEffectContinueButton = jobTransferEffectContinueButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F383 RID: 127875 RVA: 0x00A31DA8 File Offset: 0x00A2FFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroATGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_heroATGraphicObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F384 RID: 127876 RVA: 0x00A31E00 File Offset: 0x00A30000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroATGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject heroATGraphicObj;
			LuaObject.checkType<GameObject>(l, 2, out heroATGraphicObj);
			heroJobTransferUIController.m_luaExportHelper.m_heroATGraphicObj = heroATGraphicObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F385 RID: 127877 RVA: 0x00A31E5C File Offset: 0x00A3005C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransferGroundImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransferGroundImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F386 RID: 127878 RVA: 0x00A31EB4 File Offset: 0x00A300B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransferGroundImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject jobTransferGroundImage;
			LuaObject.checkType<GameObject>(l, 2, out jobTransferGroundImage);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransferGroundImage = jobTransferGroundImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F387 RID: 127879 RVA: 0x00A31F10 File Offset: 0x00A30110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobChangeSucceedText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobChangeSucceedText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F388 RID: 127880 RVA: 0x00A31F68 File Offset: 0x00A30168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobChangeSucceedText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject jobChangeSucceedText;
			LuaObject.checkType<GameObject>(l, 2, out jobChangeSucceedText);
			heroJobTransferUIController.m_luaExportHelper.m_jobChangeSucceedText = jobChangeSucceedText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F389 RID: 127881 RVA: 0x00A31FC4 File Offset: 0x00A301C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroATGraphicJobChangeEffectObj1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_heroATGraphicJobChangeEffectObj1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F38A RID: 127882 RVA: 0x00A3201C File Offset: 0x00A3021C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroATGraphicJobChangeEffectObj1(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject heroATGraphicJobChangeEffectObj;
			LuaObject.checkType<GameObject>(l, 2, out heroATGraphicJobChangeEffectObj);
			heroJobTransferUIController.m_luaExportHelper.m_heroATGraphicJobChangeEffectObj1 = heroATGraphicJobChangeEffectObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F38B RID: 127883 RVA: 0x00A32078 File Offset: 0x00A30278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroATGraphicJobChangeEffectObj2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_heroATGraphicJobChangeEffectObj2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F38C RID: 127884 RVA: 0x00A320D0 File Offset: 0x00A302D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroATGraphicJobChangeEffectObj2(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject heroATGraphicJobChangeEffectObj;
			LuaObject.checkType<GameObject>(l, 2, out heroATGraphicJobChangeEffectObj);
			heroJobTransferUIController.m_luaExportHelper.m_heroATGraphicJobChangeEffectObj2 = heroATGraphicJobChangeEffectObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F38D RID: 127885 RVA: 0x00A3212C File Offset: 0x00A3032C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobUpgradeInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F38E RID: 127886 RVA: 0x00A32184 File Offset: 0x00A30384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject jobUpgradeInfo;
			LuaObject.checkType<GameObject>(l, 2, out jobUpgradeInfo);
			heroJobTransferUIController.m_luaExportHelper.m_jobUpgradeInfo = jobUpgradeInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F38F RID: 127887 RVA: 0x00A321E0 File Offset: 0x00A303E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransHpText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransHpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F390 RID: 127888 RVA: 0x00A32238 File Offset: 0x00A30438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransHpText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobTransHpText;
			LuaObject.checkType<Text>(l, 2, out jobTransHpText);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransHpText = jobTransHpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F391 RID: 127889 RVA: 0x00A32294 File Offset: 0x00A30494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransATText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransATText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F392 RID: 127890 RVA: 0x00A322EC File Offset: 0x00A304EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransATText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobTransATText;
			LuaObject.checkType<Text>(l, 2, out jobTransATText);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransATText = jobTransATText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F393 RID: 127891 RVA: 0x00A32348 File Offset: 0x00A30548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransDFText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F394 RID: 127892 RVA: 0x00A323A0 File Offset: 0x00A305A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransDFText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobTransDFText;
			LuaObject.checkType<Text>(l, 2, out jobTransDFText);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransDFText = jobTransDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F395 RID: 127893 RVA: 0x00A323FC File Offset: 0x00A305FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransMagicText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransMagicText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F396 RID: 127894 RVA: 0x00A32454 File Offset: 0x00A30654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransMagicText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobTransMagicText;
			LuaObject.checkType<Text>(l, 2, out jobTransMagicText);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransMagicText = jobTransMagicText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F397 RID: 127895 RVA: 0x00A324B0 File Offset: 0x00A306B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransMagicDFText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransMagicDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F398 RID: 127896 RVA: 0x00A32508 File Offset: 0x00A30708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransMagicDFText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobTransMagicDFText;
			LuaObject.checkType<Text>(l, 2, out jobTransMagicDFText);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransMagicDFText = jobTransMagicDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F399 RID: 127897 RVA: 0x00A32564 File Offset: 0x00A30764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransDEXText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransDEXText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F39A RID: 127898 RVA: 0x00A325BC File Offset: 0x00A307BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransDEXText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text jobTransDEXText;
			LuaObject.checkType<Text>(l, 2, out jobTransDEXText);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransDEXText = jobTransDEXText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F39B RID: 127899 RVA: 0x00A32618 File Offset: 0x00A30818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransHpImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransHpImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F39C RID: 127900 RVA: 0x00A32670 File Offset: 0x00A30870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransHpImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image jobTransHpImage;
			LuaObject.checkType<Image>(l, 2, out jobTransHpImage);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransHpImage = jobTransHpImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F39D RID: 127901 RVA: 0x00A326CC File Offset: 0x00A308CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransATImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransATImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F39E RID: 127902 RVA: 0x00A32724 File Offset: 0x00A30924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransATImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image jobTransATImage;
			LuaObject.checkType<Image>(l, 2, out jobTransATImage);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransATImage = jobTransATImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F39F RID: 127903 RVA: 0x00A32780 File Offset: 0x00A30980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransDFImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransDFImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3A0 RID: 127904 RVA: 0x00A327D8 File Offset: 0x00A309D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransDFImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image jobTransDFImage;
			LuaObject.checkType<Image>(l, 2, out jobTransDFImage);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransDFImage = jobTransDFImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3A1 RID: 127905 RVA: 0x00A32834 File Offset: 0x00A30A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransMagicImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransMagicImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3A2 RID: 127906 RVA: 0x00A3288C File Offset: 0x00A30A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransMagicImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image jobTransMagicImage;
			LuaObject.checkType<Image>(l, 2, out jobTransMagicImage);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransMagicImage = jobTransMagicImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3A3 RID: 127907 RVA: 0x00A328E8 File Offset: 0x00A30AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransMagicDFImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransMagicDFImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3A4 RID: 127908 RVA: 0x00A32940 File Offset: 0x00A30B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransMagicDFImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image jobTransMagicDFImage;
			LuaObject.checkType<Image>(l, 2, out jobTransMagicDFImage);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransMagicDFImage = jobTransMagicDFImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3A5 RID: 127909 RVA: 0x00A3299C File Offset: 0x00A30B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransDEXImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobTransDEXImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3A6 RID: 127910 RVA: 0x00A329F4 File Offset: 0x00A30BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransDEXImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image jobTransDEXImage;
			LuaObject.checkType<Image>(l, 2, out jobTransDEXImage);
			heroJobTransferUIController.m_luaExportHelper.m_jobTransDEXImage = jobTransDEXImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3A7 RID: 127911 RVA: 0x00A32A50 File Offset: 0x00A30C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3A8 RID: 127912 RVA: 0x00A32AA8 File Offset: 0x00A30CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject learnedPanel;
			LuaObject.checkType<GameObject>(l, 2, out learnedPanel);
			heroJobTransferUIController.m_luaExportHelper.m_learnedPanel = learnedPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3A9 RID: 127913 RVA: 0x00A32B04 File Offset: 0x00A30D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanelCloseBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedPanelCloseBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3AA RID: 127914 RVA: 0x00A32B5C File Offset: 0x00A30D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedPanelCloseBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button learnedPanelCloseBtn;
			LuaObject.checkType<Button>(l, 2, out learnedPanelCloseBtn);
			heroJobTransferUIController.m_luaExportHelper.m_learnedPanelCloseBtn = learnedPanelCloseBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3AB RID: 127915 RVA: 0x00A32BB8 File Offset: 0x00A30DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanelSkillCloseBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSkillCloseBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3AC RID: 127916 RVA: 0x00A32C10 File Offset: 0x00A30E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedPanelSkillCloseBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Button learnedPanelSkillCloseBtn;
			LuaObject.checkType<Button>(l, 2, out learnedPanelSkillCloseBtn);
			heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSkillCloseBtn = learnedPanelSkillCloseBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3AD RID: 127917 RVA: 0x00A32C6C File Offset: 0x00A30E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanelSkillPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSkillPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3AE RID: 127918 RVA: 0x00A32CC4 File Offset: 0x00A30EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedPanelSkillPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject learnedPanelSkillPanel;
			LuaObject.checkType<GameObject>(l, 2, out learnedPanelSkillPanel);
			heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSkillPanel = learnedPanelSkillPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3AF RID: 127919 RVA: 0x00A32D20 File Offset: 0x00A30F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanelSoldierPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSoldierPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3B0 RID: 127920 RVA: 0x00A32D78 File Offset: 0x00A30F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedPanelSoldierPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject learnedPanelSoldierPanel;
			LuaObject.checkType<GameObject>(l, 2, out learnedPanelSoldierPanel);
			heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSoldierPanel = learnedPanelSoldierPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3B1 RID: 127921 RVA: 0x00A32DD4 File Offset: 0x00A30FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanelSkillIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSkillIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3B2 RID: 127922 RVA: 0x00A32E2C File Offset: 0x00A3102C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedPanelSkillIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Image learnedPanelSkillIcon;
			LuaObject.checkType<Image>(l, 2, out learnedPanelSkillIcon);
			heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSkillIcon = learnedPanelSkillIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3B3 RID: 127923 RVA: 0x00A32E88 File Offset: 0x00A31088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanelSoldierGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSoldierGraphicObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3B4 RID: 127924 RVA: 0x00A32EE0 File Offset: 0x00A310E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedPanelSoldierGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			GameObject learnedPanelSoldierGraphicObj;
			LuaObject.checkType<GameObject>(l, 2, out learnedPanelSoldierGraphicObj);
			heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSoldierGraphicObj = learnedPanelSoldierGraphicObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3B5 RID: 127925 RVA: 0x00A32F3C File Offset: 0x00A3113C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanelSkillName(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSkillName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3B6 RID: 127926 RVA: 0x00A32F94 File Offset: 0x00A31194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedPanelSkillName(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text learnedPanelSkillName;
			LuaObject.checkType<Text>(l, 2, out learnedPanelSkillName);
			heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSkillName = learnedPanelSkillName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3B7 RID: 127927 RVA: 0x00A32FF0 File Offset: 0x00A311F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanelSoldierName(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSoldierName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3B8 RID: 127928 RVA: 0x00A33048 File Offset: 0x00A31248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedPanelSoldierName(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Text learnedPanelSoldierName;
			LuaObject.checkType<Text>(l, 2, out learnedPanelSoldierName);
			heroJobTransferUIController.m_luaExportHelper.m_learnedPanelSoldierName = learnedPanelSoldierName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3B9 RID: 127929 RVA: 0x00A330A4 File Offset: 0x00A312A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_heroGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3BA RID: 127930 RVA: 0x00A330FC File Offset: 0x00A312FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			UISpineGraphic heroGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out heroGraphic);
			heroJobTransferUIController.m_luaExportHelper.m_heroGraphic = heroGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3BB RID: 127931 RVA: 0x00A33158 File Offset: 0x00A31358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroATGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_heroATGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3BC RID: 127932 RVA: 0x00A331B0 File Offset: 0x00A313B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroATGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			UISpineGraphic heroATGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out heroATGraphic);
			heroJobTransferUIController.m_luaExportHelper.m_heroATGraphic = heroATGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3BD RID: 127933 RVA: 0x00A3320C File Offset: 0x00A3140C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGraphicL(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_soldierGraphicL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3BE RID: 127934 RVA: 0x00A33264 File Offset: 0x00A31464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphicL(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierGraphicL;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierGraphicL);
			heroJobTransferUIController.m_luaExportHelper.m_soldierGraphicL = soldierGraphicL;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3BF RID: 127935 RVA: 0x00A332C0 File Offset: 0x00A314C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGraphicR(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_soldierGraphicR);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3C0 RID: 127936 RVA: 0x00A33318 File Offset: 0x00A31518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphicR(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierGraphicR;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierGraphicR);
			heroJobTransferUIController.m_luaExportHelper.m_soldierGraphicR = soldierGraphicR;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3C1 RID: 127937 RVA: 0x00A33374 File Offset: 0x00A31574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learndSoldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_learndSoldierGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3C2 RID: 127938 RVA: 0x00A333CC File Offset: 0x00A315CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learndSoldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			UISpineGraphic learndSoldierGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out learndSoldierGraphic);
			heroJobTransferUIController.m_luaExportHelper.m_learndSoldierGraphic = learndSoldierGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3C3 RID: 127939 RVA: 0x00A33428 File Offset: 0x00A31628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3C4 RID: 127940 RVA: 0x00A33480 File Offset: 0x00A31680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroJobTransferUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3C5 RID: 127941 RVA: 0x00A334DC File Offset: 0x00A316DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobConnectionIds(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobConnectionIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3C6 RID: 127942 RVA: 0x00A33534 File Offset: 0x00A31734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobConnectionIds(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			List<int> jobConnectionIds;
			LuaObject.checkType<List<int>>(l, 2, out jobConnectionIds);
			heroJobTransferUIController.m_luaExportHelper.m_jobConnectionIds = jobConnectionIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3C7 RID: 127943 RVA: 0x00A33590 File Offset: 0x00A31790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_oldSkillInfoList(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_oldSkillInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3C8 RID: 127944 RVA: 0x00A335E8 File Offset: 0x00A317E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_oldSkillInfoList(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			List<int> oldSkillInfoList;
			LuaObject.checkType<List<int>>(l, 2, out oldSkillInfoList);
			heroJobTransferUIController.m_luaExportHelper.m_oldSkillInfoList = oldSkillInfoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3C9 RID: 127945 RVA: 0x00A33644 File Offset: 0x00A31844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_oldSoldierInfoList(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_oldSoldierInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3CA RID: 127946 RVA: 0x00A3369C File Offset: 0x00A3189C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_oldSoldierInfoList(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			List<int> oldSoldierInfoList;
			LuaObject.checkType<List<int>>(l, 2, out oldSoldierInfoList);
			heroJobTransferUIController.m_luaExportHelper.m_oldSoldierInfoList = oldSoldierInfoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3CB RID: 127947 RVA: 0x00A336F8 File Offset: 0x00A318F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_heroCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3CC RID: 127948 RVA: 0x00A33750 File Offset: 0x00A31950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			HeroCharUIController heroCharUIController;
			LuaObject.checkType<HeroCharUIController>(l, 2, out heroCharUIController);
			heroJobTransferUIController.m_luaExportHelper.m_heroCharUIController = heroCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3CD RID: 127949 RVA: 0x00A337AC File Offset: 0x00A319AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curComputer(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_curComputer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3CE RID: 127950 RVA: 0x00A33804 File Offset: 0x00A31A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curComputer(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			HeroPropertyComputer curComputer;
			LuaObject.checkType<HeroPropertyComputer>(l, 2, out curComputer);
			heroJobTransferUIController.m_luaExportHelper.m_curComputer = curComputer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3CF RID: 127951 RVA: 0x00A33860 File Offset: 0x00A31A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_oldComputer(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_oldComputer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3D0 RID: 127952 RVA: 0x00A338B8 File Offset: 0x00A31AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_oldComputer(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			HeroPropertyComputer oldComputer;
			LuaObject.checkType<HeroPropertyComputer>(l, 2, out oldComputer);
			heroJobTransferUIController.m_luaExportHelper.m_oldComputer = oldComputer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3D1 RID: 127953 RVA: 0x00A33914 File Offset: 0x00A31B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curJobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_curJobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3D2 RID: 127954 RVA: 0x00A3396C File Offset: 0x00A31B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curJobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo curJobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out curJobConnectionInfo);
			heroJobTransferUIController.m_luaExportHelper.m_curJobConnectionInfo = curJobConnectionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3D3 RID: 127955 RVA: 0x00A339C8 File Offset: 0x00A31BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_oldJobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_oldJobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3D4 RID: 127956 RVA: 0x00A33A20 File Offset: 0x00A31C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_oldJobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo oldJobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out oldJobConnectionInfo);
			heroJobTransferUIController.m_luaExportHelper.m_oldJobConnectionInfo = oldJobConnectionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3D5 RID: 127957 RVA: 0x00A33A7C File Offset: 0x00A31C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobConnectionIdToJobCardCtrlDict(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_jobConnectionIdToJobCardCtrlDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3D6 RID: 127958 RVA: 0x00A33AD4 File Offset: 0x00A31CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobConnectionIdToJobCardCtrlDict(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			Dictionary<int, HeroJobCardItemUIController> jobConnectionIdToJobCardCtrlDict;
			LuaObject.checkType<Dictionary<int, HeroJobCardItemUIController>>(l, 2, out jobConnectionIdToJobCardCtrlDict);
			heroJobTransferUIController.m_luaExportHelper.m_jobConnectionIdToJobCardCtrlDict = jobConnectionIdToJobCardCtrlDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3D7 RID: 127959 RVA: 0x00A33B30 File Offset: 0x00A31D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isJobLocked(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_isJobLocked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3D8 RID: 127960 RVA: 0x00A33B88 File Offset: 0x00A31D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isJobLocked(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			bool isJobLocked;
			LuaObject.checkType(l, 2, out isJobLocked);
			heroJobTransferUIController.m_luaExportHelper.m_isJobLocked = isJobLocked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3D9 RID: 127961 RVA: 0x00A33BE4 File Offset: 0x00A31DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNeedMagicStone(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_isNeedMagicStone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3DA RID: 127962 RVA: 0x00A33C3C File Offset: 0x00A31E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNeedMagicStone(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			bool isNeedMagicStone;
			LuaObject.checkType(l, 2, out isNeedMagicStone);
			heroJobTransferUIController.m_luaExportHelper.m_isNeedMagicStone = isNeedMagicStone;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3DB RID: 127963 RVA: 0x00A33C98 File Offset: 0x00A31E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isShowLearnSkill(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_isShowLearnSkill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3DC RID: 127964 RVA: 0x00A33CF0 File Offset: 0x00A31EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isShowLearnSkill(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			bool isShowLearnSkill;
			LuaObject.checkType(l, 2, out isShowLearnSkill);
			heroJobTransferUIController.m_luaExportHelper.m_isShowLearnSkill = isShowLearnSkill;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3DD RID: 127965 RVA: 0x00A33D4C File Offset: 0x00A31F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isShowLearnSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_isShowLearnSoldier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3DE RID: 127966 RVA: 0x00A33DA4 File Offset: 0x00A31FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isShowLearnSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			bool isShowLearnSoldier;
			LuaObject.checkType(l, 2, out isShowLearnSoldier);
			heroJobTransferUIController.m_luaExportHelper.m_isShowLearnSoldier = isShowLearnSoldier;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3DF RID: 127967 RVA: 0x00A33E00 File Offset: 0x00A32000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isJobHasTransfered(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_isJobHasTransfered);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3E0 RID: 127968 RVA: 0x00A33E58 File Offset: 0x00A32058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isJobHasTransfered(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			bool isJobHasTransfered;
			LuaObject.checkType(l, 2, out isJobHasTransfered);
			heroJobTransferUIController.m_luaExportHelper.m_isJobHasTransfered = isJobHasTransfered;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3E1 RID: 127969 RVA: 0x00A33EB4 File Offset: 0x00A320B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isJobTransferContinue(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_isJobTransferContinue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3E2 RID: 127970 RVA: 0x00A33F0C File Offset: 0x00A3210C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isJobTransferContinue(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			bool isJobTransferContinue;
			LuaObject.checkType(l, 2, out isJobTransferContinue);
			heroJobTransferUIController.m_luaExportHelper.m_isJobTransferContinue = isJobTransferContinue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3E3 RID: 127971 RVA: 0x00A33F68 File Offset: 0x00A32168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3E4 RID: 127972 RVA: 0x00A33FC0 File Offset: 0x00A321C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroJobTransferUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3E5 RID: 127973 RVA: 0x00A3401C File Offset: 0x00A3221C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3E6 RID: 127974 RVA: 0x00A34074 File Offset: 0x00A32274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferUIController heroJobTransferUIController = (HeroJobTransferUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroJobTransferUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F3E7 RID: 127975 RVA: 0x00A340D0 File Offset: 0x00A322D0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroJobTransferUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.SetHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.UpdateViewInHeroJobTransfer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnHeroJobTransferSucceed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.SortJobConnectionIdByUISort_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.DrawLines);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.DynamicSetTransferLines);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.SetLineImageColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.ClearGridLayout);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.GetGridLayoutByRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnJobCardItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.SetHeroInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.SetCanLearnSkills);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.SetCanLearnSoldiers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.CloseHeroJobInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnJobTransferButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.CloseJobTransferConfirmPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.CloseJobTransferLockedPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnJobUnlockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnUnLockHeroJobReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnUnLockHeroJobUnlockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnJobTransferConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.GetCanLearnSkillAndSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnSkipBtnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.PlayJobTransfetEffectStep1);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.PlayJobTransfetEffectStep2);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.ShowLearnedSkillAndSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.CloseLearnedSkillPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.CloseLearnedPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnJobTransferEffectContinueButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.SetTransferSucceedInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.PropertyToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.SetImageState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnMasterRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.CloseMasterInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.CreateSoldierGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.DestroyGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnGoldAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnMagicStoneClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callDele_EventOnAddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__clearDele_EventOnAddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callDele_EventOnHeroJobUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__clearDele_EventOnHeroJobUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callDele_EventOnHeroJobTransferFinishedForUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__clearDele_EventOnHeroJobTransferFinishedForUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callDele_EventOnHeroJobTransfer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__clearDele_EventOnHeroJobTransfer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__callDele_EventOnHeroJobCardClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.__clearDele_EventOnHeroJobCardClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache41);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache42, true);
		string name2 = "EventOnAddGold";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_EventOnAddGold);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache43, true);
		string name3 = "EventOnHeroJobUnlock";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_EventOnHeroJobUnlock);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache44, true);
		string name4 = "EventOnHeroJobTransferFinishedForUserGuide";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_EventOnHeroJobTransferFinishedForUserGuide);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache45, true);
		string name5 = "EventOnHeroJobTransfer";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_EventOnHeroJobTransfer);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache46, true);
		string name6 = "EventOnHeroJobCardClick";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_EventOnHeroJobCardClick);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache47, true);
		string name7 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_marginTransform);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache49, true);
		string name8 = "m_rankLayout1";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_rankLayout1);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_rankLayout1);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4B, true);
		string name9 = "m_rankLayout2";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_rankLayout2);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_rankLayout2);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4D, true);
		string name10 = "m_rankLayout3";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_rankLayout3);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_rankLayout3);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache4F, true);
		string name11 = "m_rankLayout4";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_rankLayout4);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_rankLayout4);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache51, true);
		string name12 = "m_rankLine1";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_rankLine1);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_rankLine1);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache53, true);
		string name13 = "m_rankLine1Image";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_rankLine1Image);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_rankLine1Image);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache55, true);
		string name14 = "m_rankLine2Image";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_rankLine2Image);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_rankLine2Image);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache57, true);
		string name15 = "m_rankLine2Image1";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_rankLine2Image1);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_rankLine2Image1);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache59, true);
		string name16 = "m_rankLine2Image2";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_rankLine2Image2);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_rankLine2Image2);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5B, true);
		string name17 = "m_rankLine3Image";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_rankLine3Image);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_rankLine3Image);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5D, true);
		string name18 = "m_rankLine3Image1";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_rankLine3Image1);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_rankLine3Image1);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache5F, true);
		string name19 = "m_rankLine3Image2";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_rankLine3Image2);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_rankLine3Image2);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache61, true);
		string name20 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_returnButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache63, true);
		string name21 = "m_goldNumText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_goldNumText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_goldNumText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache65, true);
		string name22 = "m_goldAddBtn";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_goldAddBtn);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_goldAddBtn);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache67, true);
		string name23 = "m_magicStoneNumText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_magicStoneNumText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_magicStoneNumText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache69, true);
		string name24 = "m_magicStoneBtn";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_magicStoneBtn);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_magicStoneBtn);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6B, true);
		string name25 = "m_heroJobInfoPanelObj";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_heroJobInfoPanelObj);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_heroJobInfoPanelObj);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6D, true);
		string name26 = "m_jobNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobNameText);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobNameText);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache6F, true);
		string name27 = "m_jobNameEnText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobNameEnText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobNameEnText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache71, true);
		string name28 = "m_jobTypeBgImage";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTypeBgImage);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTypeBgImage);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache73, true);
		string name29 = "m_jobTypeBgImage2";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTypeBgImage2);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTypeBgImage2);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache75, true);
		string name30 = "m_jobTypeText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTypeText);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTypeText);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache77, true);
		string name31 = "m_jobMoveValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobMoveValueText);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobMoveValueText);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache79, true);
		string name32 = "m_jobRangeValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobRangeValueText);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobRangeValueText);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7B, true);
		string name33 = "m_jobAdvantageText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobAdvantageText);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobAdvantageText);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7D, true);
		string name34 = "m_jobAdvantageText1";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobAdvantageText1);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobAdvantageText1);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache7F, true);
		string name35 = "m_jobAdvantageText2";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobAdvantageText2);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobAdvantageText2);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache81, true);
		string name36 = "m_heroGraphicObj";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_heroGraphicObj);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_heroGraphicObj);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache83, true);
		string name37 = "m_jobSoldierTypeImage";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobSoldierTypeImage);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobSoldierTypeImage);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache85, true);
		string name38 = "m_jobTransferButton";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransferButton);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransferButton);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache87, true);
		string name39 = "m_jobUnlockButton";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobUnlockButton);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobUnlockButton);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache89, true);
		string name40 = "m_masterButton";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_masterButton);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_masterButton);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8B, true);
		string name41 = "m_alreadyMasterValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_alreadyMasterValueText);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_alreadyMasterValueText);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8D, true);
		string name42 = "m_masterInfoPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_masterInfoPanel);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_masterInfoPanel);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache8F, true);
		string name43 = "m_masterInfoPanelReturnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_masterInfoPanelReturnButton);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_masterInfoPanelReturnButton);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache91, true);
		string name44 = "m_masterInfoPanelScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_masterInfoPanelScrollViewContent);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_masterInfoPanelScrollViewContent);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache93, true);
		string name45 = "m_masterItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_masterItemPrefab);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_masterItemPrefab);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache95, true);
		string name46 = "m_jobLvBgImagesGroup";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobLvBgImagesGroup);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobLvBgImagesGroup);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache97, true);
		string name47 = "m_jobLvImagesGroup";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobLvImagesGroup);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobLvImagesGroup);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache99, true);
		string name48 = "m_learnedSkillIconImg";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedSkillIconImg);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedSkillIconImg);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9B, true);
		string name49 = "m_learnedSkillIconImg2";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedSkillIconImg2);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedSkillIconImg2);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9D, true);
		string name50 = "m_skillDetailPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_skillDetailPanel);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_skillDetailPanel);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache9F, true);
		string name51 = "m_learnedSoldierGraphicObj";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedSoldierGraphicObj);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedSoldierGraphicObj);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA1, true);
		string name52 = "m_learnedSoldierGraphicObj2";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedSoldierGraphicObj2);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedSoldierGraphicObj2);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA3, true);
		string name53 = "m_learnedSoldierGraphicBg";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedSoldierGraphicBg);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedSoldierGraphicBg);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA5, true);
		string name54 = "m_learnedSoldierGraphicBg2";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedSoldierGraphicBg2);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedSoldierGraphicBg2);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA7, true);
		string name55 = "m_soldierDetailPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_soldierDetailPanel);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_soldierDetailPanel);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheA9, true);
		string name56 = "m_transferLockPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_transferLockPanel);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_transferLockPanel);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAB, true);
		string name57 = "m_transferLockPanelReturnBg";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_transferLockPanelReturnBg);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_transferLockPanelReturnBg);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAD, true);
		string name58 = "m_transferLockQuesText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_transferLockQuesText);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_transferLockQuesText);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheAF, true);
		string name59 = "m_transferLockConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_transferLockConfirmButton);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_transferLockConfirmButton);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB1, true);
		string name60 = "m_transferConfirmPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_transferConfirmPanel);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_transferConfirmPanel);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB3, true);
		string name61 = "m_confirmPanelJobNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_confirmPanelJobNameText);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_confirmPanelJobNameText);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB5, true);
		string name62 = "m_goldCostValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_goldCostValueText);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_goldCostValueText);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB7, true);
		string name63 = "m_magicStoneCostValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_magicStoneCostValueText);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_magicStoneCostValueText);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheB9, true);
		string name64 = "m_confirmBgButton";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_confirmBgButton);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_confirmBgButton);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBB, true);
		string name65 = "m_confirmReturnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_confirmReturnButton);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_confirmReturnButton);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBD, true);
		string name66 = "m_confirmTransferButton";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_confirmTransferButton);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_confirmTransferButton);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheBF, true);
		string name67 = "m_confirmTransferNoticeTextStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_confirmTransferNoticeTextStateCtrl);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_confirmTransferNoticeTextStateCtrl);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC1, true);
		string name68 = "m_unLockHeroJobPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_unLockHeroJobPanel);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_unLockHeroJobPanel);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC3, true);
		string name69 = "m_unLockHeroJobPanelJobNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_unLockHeroJobPanelJobNameText);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_unLockHeroJobPanelJobNameText);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC5, true);
		string name70 = "m_unLockHeroJobConditionsContentObj";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_unLockHeroJobConditionsContentObj);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC6;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_unLockHeroJobConditionsContentObj);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC7, true);
		string name71 = "m_unlcokJobConditionPrefab";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_unlcokJobConditionPrefab);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC8;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_unlcokJobConditionPrefab);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheC9, true);
		string name72 = "m_unLockHeroJobReturnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_unLockHeroJobReturnButton);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCA;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_unLockHeroJobReturnButton);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCB, true);
		string name73 = "m_unLockHeroJobUnlockButton";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_unLockHeroJobUnlockButton);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCC;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_unLockHeroJobUnlockButton);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCD, true);
		string name74 = "m_jobTransferEffectSkipBtn";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransferEffectSkipBtn);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCE;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransferEffectSkipBtn);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheCF, true);
		string name75 = "m_JobTransferEffectBgObj";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_JobTransferEffectBgObj);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_JobTransferEffectBgObj);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD1, true);
		string name76 = "m_JobTransferEffectBlackImage";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_JobTransferEffectBlackImage);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD2;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_JobTransferEffectBlackImage);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD3, true);
		string name77 = "m_JobTransferEffectWhiteImage";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_JobTransferEffectWhiteImage);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD4;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_JobTransferEffectWhiteImage);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD5, true);
		string name78 = "m_JobTransferEffectBgImage";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_JobTransferEffectBgImage);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD6;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_JobTransferEffectBgImage);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD7, true);
		string name79 = "m_jobTransferEffectContinueButton";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransferEffectContinueButton);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD8;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransferEffectContinueButton);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheD9, true);
		string name80 = "m_heroATGraphicObj";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_heroATGraphicObj);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDA;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_heroATGraphicObj);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDB, true);
		string name81 = "m_jobTransferGroundImage";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransferGroundImage);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDC;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransferGroundImage);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDD, true);
		string name82 = "m_jobChangeSucceedText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobChangeSucceedText);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDE;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobChangeSucceedText);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheDF, true);
		string name83 = "m_heroATGraphicJobChangeEffectObj1";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_heroATGraphicJobChangeEffectObj1);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE0;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_heroATGraphicJobChangeEffectObj1);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE1, true);
		string name84 = "m_heroATGraphicJobChangeEffectObj2";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_heroATGraphicJobChangeEffectObj2);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE2;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_heroATGraphicJobChangeEffectObj2);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE3, true);
		string name85 = "m_jobUpgradeInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobUpgradeInfo);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE4;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobUpgradeInfo);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE5, true);
		string name86 = "m_jobTransHpText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransHpText);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE6;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransHpText);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE7, true);
		string name87 = "m_jobTransATText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransATText);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE8;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransATText);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheE9, true);
		string name88 = "m_jobTransDFText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransDFText);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEA;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransDFText);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEB, true);
		string name89 = "m_jobTransMagicText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransMagicText);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEC;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransMagicText);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheED, true);
		string name90 = "m_jobTransMagicDFText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransMagicDFText);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEE;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransMagicDFText);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheEF, true);
		string name91 = "m_jobTransDEXText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransDEXText);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF0;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransDEXText);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF1, true);
		string name92 = "m_jobTransHpImage";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransHpImage);
		}
		LuaCSFunction get92 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF2;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransHpImage);
		}
		LuaObject.addMember(l, name92, get92, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF3, true);
		string name93 = "m_jobTransATImage";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransATImage);
		}
		LuaCSFunction get93 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF4;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransATImage);
		}
		LuaObject.addMember(l, name93, get93, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF5, true);
		string name94 = "m_jobTransDFImage";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransDFImage);
		}
		LuaCSFunction get94 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF6;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransDFImage);
		}
		LuaObject.addMember(l, name94, get94, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF7, true);
		string name95 = "m_jobTransMagicImage";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransMagicImage);
		}
		LuaCSFunction get95 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF8;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransMagicImage);
		}
		LuaObject.addMember(l, name95, get95, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheF9, true);
		string name96 = "m_jobTransMagicDFImage";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransMagicDFImage);
		}
		LuaCSFunction get96 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFA;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransMagicDFImage);
		}
		LuaObject.addMember(l, name96, get96, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFB, true);
		string name97 = "m_jobTransDEXImage";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobTransDEXImage);
		}
		LuaCSFunction get97 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFC;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobTransDEXImage);
		}
		LuaObject.addMember(l, name97, get97, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFD, true);
		string name98 = "m_learnedPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedPanel);
		}
		LuaCSFunction get98 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFE;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedPanel);
		}
		LuaObject.addMember(l, name98, get98, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cacheFF, true);
		string name99 = "m_learnedPanelCloseBtn";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedPanelCloseBtn);
		}
		LuaCSFunction get99 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache100;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedPanelCloseBtn);
		}
		LuaObject.addMember(l, name99, get99, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache101, true);
		string name100 = "m_learnedPanelSkillCloseBtn";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedPanelSkillCloseBtn);
		}
		LuaCSFunction get100 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache102;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedPanelSkillCloseBtn);
		}
		LuaObject.addMember(l, name100, get100, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache103, true);
		string name101 = "m_learnedPanelSkillPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedPanelSkillPanel);
		}
		LuaCSFunction get101 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache104;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedPanelSkillPanel);
		}
		LuaObject.addMember(l, name101, get101, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache105, true);
		string name102 = "m_learnedPanelSoldierPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedPanelSoldierPanel);
		}
		LuaCSFunction get102 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache106;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedPanelSoldierPanel);
		}
		LuaObject.addMember(l, name102, get102, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache107, true);
		string name103 = "m_learnedPanelSkillIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedPanelSkillIcon);
		}
		LuaCSFunction get103 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache108;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedPanelSkillIcon);
		}
		LuaObject.addMember(l, name103, get103, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache109, true);
		string name104 = "m_learnedPanelSoldierGraphicObj";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedPanelSoldierGraphicObj);
		}
		LuaCSFunction get104 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedPanelSoldierGraphicObj);
		}
		LuaObject.addMember(l, name104, get104, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10B, true);
		string name105 = "m_learnedPanelSkillName";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedPanelSkillName);
		}
		LuaCSFunction get105 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedPanelSkillName);
		}
		LuaObject.addMember(l, name105, get105, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10D, true);
		string name106 = "m_learnedPanelSoldierName";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learnedPanelSoldierName);
		}
		LuaCSFunction get106 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10E;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learnedPanelSoldierName);
		}
		LuaObject.addMember(l, name106, get106, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache10F, true);
		string name107 = "m_heroGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_heroGraphic);
		}
		LuaCSFunction get107 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache110;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_heroGraphic);
		}
		LuaObject.addMember(l, name107, get107, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache111, true);
		string name108 = "m_heroATGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_heroATGraphic);
		}
		LuaCSFunction get108 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache112;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_heroATGraphic);
		}
		LuaObject.addMember(l, name108, get108, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache113, true);
		string name109 = "m_soldierGraphicL";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_soldierGraphicL);
		}
		LuaCSFunction get109 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache114;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_soldierGraphicL);
		}
		LuaObject.addMember(l, name109, get109, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache115, true);
		string name110 = "m_soldierGraphicR";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_soldierGraphicR);
		}
		LuaCSFunction get110 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache116;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_soldierGraphicR);
		}
		LuaObject.addMember(l, name110, get110, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache117, true);
		string name111 = "m_learndSoldierGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_learndSoldierGraphic);
		}
		LuaCSFunction get111 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache118;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_learndSoldierGraphic);
		}
		LuaObject.addMember(l, name111, get111, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache119, true);
		string name112 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_hero);
		}
		LuaCSFunction get112 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_hero);
		}
		LuaObject.addMember(l, name112, get112, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11B, true);
		string name113 = "m_jobConnectionIds";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobConnectionIds);
		}
		LuaCSFunction get113 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobConnectionIds);
		}
		LuaObject.addMember(l, name113, get113, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11D, true);
		string name114 = "m_oldSkillInfoList";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_oldSkillInfoList);
		}
		LuaCSFunction get114 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11E;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_oldSkillInfoList);
		}
		LuaObject.addMember(l, name114, get114, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache11F, true);
		string name115 = "m_oldSoldierInfoList";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_oldSoldierInfoList);
		}
		LuaCSFunction get115 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache120;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_oldSoldierInfoList);
		}
		LuaObject.addMember(l, name115, get115, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache121, true);
		string name116 = "m_heroCharUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_heroCharUIController);
		}
		LuaCSFunction get116 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache122;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_heroCharUIController);
		}
		LuaObject.addMember(l, name116, get116, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache123, true);
		string name117 = "m_curComputer";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_curComputer);
		}
		LuaCSFunction get117 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache124;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_curComputer);
		}
		LuaObject.addMember(l, name117, get117, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache125, true);
		string name118 = "m_oldComputer";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_oldComputer);
		}
		LuaCSFunction get118 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache126;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_oldComputer);
		}
		LuaObject.addMember(l, name118, get118, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache127, true);
		string name119 = "m_curJobConnectionInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_curJobConnectionInfo);
		}
		LuaCSFunction get119 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache128;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_curJobConnectionInfo);
		}
		LuaObject.addMember(l, name119, get119, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache129, true);
		string name120 = "m_oldJobConnectionInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_oldJobConnectionInfo);
		}
		LuaCSFunction get120 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_oldJobConnectionInfo);
		}
		LuaObject.addMember(l, name120, get120, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12B, true);
		string name121 = "m_jobConnectionIdToJobCardCtrlDict";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_jobConnectionIdToJobCardCtrlDict);
		}
		LuaCSFunction get121 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_jobConnectionIdToJobCardCtrlDict);
		}
		LuaObject.addMember(l, name121, get121, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12D, true);
		string name122 = "m_isJobLocked";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_isJobLocked);
		}
		LuaCSFunction get122 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12E;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_isJobLocked);
		}
		LuaObject.addMember(l, name122, get122, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache12F, true);
		string name123 = "m_isNeedMagicStone";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_isNeedMagicStone);
		}
		LuaCSFunction get123 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache130;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_isNeedMagicStone);
		}
		LuaObject.addMember(l, name123, get123, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache131, true);
		string name124 = "m_isShowLearnSkill";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_isShowLearnSkill);
		}
		LuaCSFunction get124 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache132;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_isShowLearnSkill);
		}
		LuaObject.addMember(l, name124, get124, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache133, true);
		string name125 = "m_isShowLearnSoldier";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_isShowLearnSoldier);
		}
		LuaCSFunction get125 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache134;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_isShowLearnSoldier);
		}
		LuaObject.addMember(l, name125, get125, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache135, true);
		string name126 = "m_isJobHasTransfered";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_isJobHasTransfered);
		}
		LuaCSFunction get126 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache136;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_isJobHasTransfered);
		}
		LuaObject.addMember(l, name126, get126, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache137, true);
		string name127 = "m_isJobTransferContinue";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_isJobTransferContinue);
		}
		LuaCSFunction get127 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache138;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_isJobTransferContinue);
		}
		LuaObject.addMember(l, name127, get127, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache139, true);
		string name128 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_playerContext);
		}
		LuaCSFunction get128 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name128, get128, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13B, true);
		string name129 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.get_m_configDataLoader);
		}
		LuaCSFunction get129 = Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name129, get129, Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.<>f__mg$cache13D, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroJobTransferUIController), typeof(UIControllerBase));
	}

	// Token: 0x040152ED RID: 86765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040152EE RID: 86766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040152EF RID: 86767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040152F0 RID: 86768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040152F1 RID: 86769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040152F2 RID: 86770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040152F3 RID: 86771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040152F4 RID: 86772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040152F5 RID: 86773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040152F6 RID: 86774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040152F7 RID: 86775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040152F8 RID: 86776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040152F9 RID: 86777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040152FA RID: 86778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040152FB RID: 86779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040152FC RID: 86780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040152FD RID: 86781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040152FE RID: 86782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040152FF RID: 86783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015300 RID: 86784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015301 RID: 86785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015302 RID: 86786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015303 RID: 86787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015304 RID: 86788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015305 RID: 86789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015306 RID: 86790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015307 RID: 86791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015308 RID: 86792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015309 RID: 86793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401530A RID: 86794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401530B RID: 86795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401530C RID: 86796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401530D RID: 86797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401530E RID: 86798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401530F RID: 86799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015310 RID: 86800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015311 RID: 86801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015312 RID: 86802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015313 RID: 86803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015314 RID: 86804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015315 RID: 86805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015316 RID: 86806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015317 RID: 86807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015318 RID: 86808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015319 RID: 86809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401531A RID: 86810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401531B RID: 86811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401531C RID: 86812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401531D RID: 86813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401531E RID: 86814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401531F RID: 86815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015320 RID: 86816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015321 RID: 86817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015322 RID: 86818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015323 RID: 86819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015324 RID: 86820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015325 RID: 86821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04015326 RID: 86822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015327 RID: 86823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015328 RID: 86824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015329 RID: 86825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401532A RID: 86826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401532B RID: 86827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401532C RID: 86828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401532D RID: 86829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401532E RID: 86830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401532F RID: 86831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04015330 RID: 86832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04015331 RID: 86833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04015332 RID: 86834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04015333 RID: 86835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04015334 RID: 86836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04015335 RID: 86837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04015336 RID: 86838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04015337 RID: 86839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04015338 RID: 86840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04015339 RID: 86841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401533A RID: 86842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401533B RID: 86843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401533C RID: 86844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401533D RID: 86845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401533E RID: 86846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0401533F RID: 86847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04015340 RID: 86848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04015341 RID: 86849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04015342 RID: 86850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04015343 RID: 86851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04015344 RID: 86852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04015345 RID: 86853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04015346 RID: 86854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04015347 RID: 86855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04015348 RID: 86856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04015349 RID: 86857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401534A RID: 86858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401534B RID: 86859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401534C RID: 86860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0401534D RID: 86861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0401534E RID: 86862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0401534F RID: 86863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04015350 RID: 86864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04015351 RID: 86865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04015352 RID: 86866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04015353 RID: 86867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04015354 RID: 86868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04015355 RID: 86869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04015356 RID: 86870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04015357 RID: 86871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04015358 RID: 86872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04015359 RID: 86873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401535A RID: 86874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0401535B RID: 86875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0401535C RID: 86876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0401535D RID: 86877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0401535E RID: 86878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0401535F RID: 86879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04015360 RID: 86880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04015361 RID: 86881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04015362 RID: 86882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04015363 RID: 86883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04015364 RID: 86884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04015365 RID: 86885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04015366 RID: 86886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04015367 RID: 86887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04015368 RID: 86888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04015369 RID: 86889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0401536A RID: 86890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0401536B RID: 86891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0401536C RID: 86892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0401536D RID: 86893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0401536E RID: 86894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0401536F RID: 86895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04015370 RID: 86896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04015371 RID: 86897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04015372 RID: 86898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04015373 RID: 86899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04015374 RID: 86900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04015375 RID: 86901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04015376 RID: 86902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04015377 RID: 86903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04015378 RID: 86904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04015379 RID: 86905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0401537A RID: 86906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0401537B RID: 86907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0401537C RID: 86908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0401537D RID: 86909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0401537E RID: 86910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x0401537F RID: 86911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04015380 RID: 86912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04015381 RID: 86913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04015382 RID: 86914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04015383 RID: 86915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04015384 RID: 86916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04015385 RID: 86917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04015386 RID: 86918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04015387 RID: 86919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04015388 RID: 86920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04015389 RID: 86921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0401538A RID: 86922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0401538B RID: 86923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x0401538C RID: 86924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x0401538D RID: 86925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x0401538E RID: 86926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x0401538F RID: 86927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04015390 RID: 86928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04015391 RID: 86929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04015392 RID: 86930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04015393 RID: 86931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04015394 RID: 86932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04015395 RID: 86933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04015396 RID: 86934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04015397 RID: 86935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04015398 RID: 86936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04015399 RID: 86937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x0401539A RID: 86938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x0401539B RID: 86939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x0401539C RID: 86940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x0401539D RID: 86941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x0401539E RID: 86942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x0401539F RID: 86943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x040153A0 RID: 86944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x040153A1 RID: 86945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x040153A2 RID: 86946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x040153A3 RID: 86947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x040153A4 RID: 86948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x040153A5 RID: 86949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x040153A6 RID: 86950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x040153A7 RID: 86951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x040153A8 RID: 86952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x040153A9 RID: 86953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x040153AA RID: 86954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x040153AB RID: 86955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x040153AC RID: 86956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x040153AD RID: 86957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x040153AE RID: 86958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x040153AF RID: 86959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x040153B0 RID: 86960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x040153B1 RID: 86961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x040153B2 RID: 86962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x040153B3 RID: 86963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x040153B4 RID: 86964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x040153B5 RID: 86965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x040153B6 RID: 86966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x040153B7 RID: 86967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x040153B8 RID: 86968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x040153B9 RID: 86969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x040153BA RID: 86970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x040153BB RID: 86971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x040153BC RID: 86972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x040153BD RID: 86973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x040153BE RID: 86974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x040153BF RID: 86975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x040153C0 RID: 86976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x040153C1 RID: 86977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x040153C2 RID: 86978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x040153C3 RID: 86979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x040153C4 RID: 86980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x040153C5 RID: 86981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x040153C6 RID: 86982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x040153C7 RID: 86983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x040153C8 RID: 86984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x040153C9 RID: 86985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x040153CA RID: 86986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x040153CB RID: 86987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x040153CC RID: 86988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x040153CD RID: 86989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x040153CE RID: 86990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x040153CF RID: 86991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x040153D0 RID: 86992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x040153D1 RID: 86993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x040153D2 RID: 86994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x040153D3 RID: 86995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x040153D4 RID: 86996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x040153D5 RID: 86997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x040153D6 RID: 86998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x040153D7 RID: 86999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x040153D8 RID: 87000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x040153D9 RID: 87001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x040153DA RID: 87002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x040153DB RID: 87003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x040153DC RID: 87004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x040153DD RID: 87005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x040153DE RID: 87006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x040153DF RID: 87007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x040153E0 RID: 87008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x040153E1 RID: 87009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x040153E2 RID: 87010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x040153E3 RID: 87011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x040153E4 RID: 87012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x040153E5 RID: 87013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x040153E6 RID: 87014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x040153E7 RID: 87015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x040153E8 RID: 87016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x040153E9 RID: 87017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x040153EA RID: 87018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x040153EB RID: 87019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x040153EC RID: 87020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x040153ED RID: 87021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x040153EE RID: 87022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x040153EF RID: 87023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x040153F0 RID: 87024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x040153F1 RID: 87025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x040153F2 RID: 87026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x040153F3 RID: 87027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x040153F4 RID: 87028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x040153F5 RID: 87029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x040153F6 RID: 87030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x040153F7 RID: 87031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x040153F8 RID: 87032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x040153F9 RID: 87033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x040153FA RID: 87034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x040153FB RID: 87035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x040153FC RID: 87036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x040153FD RID: 87037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x040153FE RID: 87038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x040153FF RID: 87039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x04015400 RID: 87040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x04015401 RID: 87041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x04015402 RID: 87042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x04015403 RID: 87043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x04015404 RID: 87044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x04015405 RID: 87045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x04015406 RID: 87046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x04015407 RID: 87047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x04015408 RID: 87048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x04015409 RID: 87049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x0401540A RID: 87050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x0401540B RID: 87051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x0401540C RID: 87052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x0401540D RID: 87053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x0401540E RID: 87054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x0401540F RID: 87055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x04015410 RID: 87056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x04015411 RID: 87057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x04015412 RID: 87058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x04015413 RID: 87059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x04015414 RID: 87060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x04015415 RID: 87061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x04015416 RID: 87062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x04015417 RID: 87063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x04015418 RID: 87064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x04015419 RID: 87065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x0401541A RID: 87066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x0401541B RID: 87067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x0401541C RID: 87068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x0401541D RID: 87069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x0401541E RID: 87070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x0401541F RID: 87071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x04015420 RID: 87072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x04015421 RID: 87073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x04015422 RID: 87074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x04015423 RID: 87075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x04015424 RID: 87076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x04015425 RID: 87077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x04015426 RID: 87078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x04015427 RID: 87079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x04015428 RID: 87080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x04015429 RID: 87081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x0401542A RID: 87082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;
}
