using System;
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

// Token: 0x0200141B RID: 5147
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DrillTutorUIController : LuaObject
{
	// Token: 0x0601D367 RID: 119655 RVA: 0x009348A4 File Offset: 0x00932AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D368 RID: 119656 RVA: 0x009348F0 File Offset: 0x00932AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInDrillTutor(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			drillTutorUIController.UpdateViewInDrillTutor(slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D369 RID: 119657 RVA: 0x00934948 File Offset: 0x00932B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayStartTeachEffect(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Action onEffectFinish;
			LuaObject.checkDelegate<Action>(l, 2, out onEffectFinish);
			drillTutorUIController.PlayStartTeachEffect(onEffectFinish);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D36A RID: 119658 RVA: 0x009349A0 File Offset: 0x00932BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D36B RID: 119659 RVA: 0x009349EC File Offset: 0x00932BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D36C RID: 119660 RVA: 0x00934A40 File Offset: 0x00932C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDifficultScrollViewPosition(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.SetDifficultScrollViewPosition();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D36D RID: 119661 RVA: 0x00934A94 File Offset: 0x00932C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetConfirmButtonState(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.SetConfirmButtonState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D36E RID: 119662 RVA: 0x00934AE8 File Offset: 0x00932CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDifficultBgBySlot(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.SetDifficultBgBySlot();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D36F RID: 119663 RVA: 0x00934B3C File Offset: 0x00932D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDifficultInfo(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.SetDifficultInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D370 RID: 119664 RVA: 0x00934B90 File Offset: 0x00932D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDifficultItemClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			TrainingDifficultItemUIController ctrl;
			LuaObject.checkType<TrainingDifficultItemUIController>(l, 2, out ctrl);
			drillTutorUIController.m_luaExportHelper.OnDifficultItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D371 RID: 119665 RVA: 0x00934BEC File Offset: 0x00932DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetWorkHour(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.SetWorkHour();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D372 RID: 119666 RVA: 0x00934C40 File Offset: 0x00932E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRecommendHeroGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			GameObject recommendHeroGroup;
			LuaObject.checkType<GameObject>(l, 2, out recommendHeroGroup);
			drillTutorUIController.m_luaExportHelper.SetRecommendHeroGroup(recommendHeroGroup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D373 RID: 119667 RVA: 0x00934C9C File Offset: 0x00932E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurChooseHeros(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.SetCurChooseHeros();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D374 RID: 119668 RVA: 0x00934CF0 File Offset: 0x00932EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRewardGroupList(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.SetRewardGroupList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D375 RID: 119669 RVA: 0x00934D44 File Offset: 0x00932F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRewardsList(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			List<Goods> rewardsList = drillTutorUIController.m_luaExportHelper.GetRewardsList();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardsList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D376 RID: 119670 RVA: 0x00934DA0 File Offset: 0x00932FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChooseHeroListPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.SetChooseHeroListPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D377 RID: 119671 RVA: 0x00934DF4 File Offset: 0x00932FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListItemComparator(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Hero h;
			LuaObject.checkType<Hero>(l, 2, out h);
			Hero h2;
			LuaObject.checkType<Hero>(l, 3, out h2);
			int i = drillTutorUIController.m_luaExportHelper.HeroListItemComparator(h, h2);
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

	// Token: 0x0601D378 RID: 119672 RVA: 0x00934E68 File Offset: 0x00933068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTrainingHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			TrainingHeroItemUIController ctrl;
			LuaObject.checkType<TrainingHeroItemUIController>(l, 2, out ctrl);
			drillTutorUIController.m_luaExportHelper.OnTrainingHeroItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D379 RID: 119673 RVA: 0x00934EC4 File Offset: 0x009330C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroListResultDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.SetHeroListResultDetailPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D37A RID: 119674 RVA: 0x00934F18 File Offset: 0x00933118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalcHeroTotalAchievementvalue(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			int i = drillTutorUIController.m_luaExportHelper.CalcHeroTotalAchievementvalue(heroIds);
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

	// Token: 0x0601D37B RID: 119675 RVA: 0x00934F80 File Offset: 0x00933180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChooseHeroButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.OnChooseHeroButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D37C RID: 119676 RVA: 0x00934FD4 File Offset: 0x009331D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroListConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.OnHeroListConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D37D RID: 119677 RVA: 0x00935028 File Offset: 0x00933228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroListPanelBGBackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.OnHeroListPanelBGBackButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D37E RID: 119678 RVA: 0x0093507C File Offset: 0x0093327C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDetailConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.OnDetailConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D37F RID: 119679 RVA: 0x009350D0 File Offset: 0x009332D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLevelToggleChanged(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			drillTutorUIController.m_luaExportHelper.OnLevelToggleChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D380 RID: 119680 RVA: 0x0093512C File Offset: 0x0093332C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStarLvToggleChanged(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			drillTutorUIController.m_luaExportHelper.OnStarLvToggleChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D381 RID: 119681 RVA: 0x00935188 File Offset: 0x00933388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAchievementToggleChanged(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			drillTutorUIController.m_luaExportHelper.OnAchievementToggleChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D382 RID: 119682 RVA: 0x009351E4 File Offset: 0x009333E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroSortButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.OnHeroSortButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D383 RID: 119683 RVA: 0x00935238 File Offset: 0x00933438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseSortTypesPanel(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.CloseSortTypesPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D384 RID: 119684 RVA: 0x0093528C File Offset: 0x0093348C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D385 RID: 119685 RVA: 0x009352E0 File Offset: 0x009334E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetData(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.ResetData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D386 RID: 119686 RVA: 0x00935334 File Offset: 0x00933534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			drillTutorUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D387 RID: 119687 RVA: 0x009353A0 File Offset: 0x009335A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D388 RID: 119688 RVA: 0x009353F4 File Offset: 0x009335F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D389 RID: 119689 RVA: 0x00935448 File Offset: 0x00933648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = drillTutorUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D38A RID: 119690 RVA: 0x009354F0 File Offset: 0x009336F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D38B RID: 119691 RVA: 0x00935544 File Offset: 0x00933744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			drillTutorUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D38C RID: 119692 RVA: 0x009355B0 File Offset: 0x009337B0
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
				DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				drillTutorUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				DrillTutorUIController drillTutorUIController2 = (DrillTutorUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				drillTutorUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D38D RID: 119693 RVA: 0x009356C0 File Offset: 0x009338C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillTutorUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D38E RID: 119694 RVA: 0x0093572C File Offset: 0x0093392C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillTutorUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D38F RID: 119695 RVA: 0x00935798 File Offset: 0x00933998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillTutorUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D390 RID: 119696 RVA: 0x00935804 File Offset: 0x00933A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			drillTutorUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D391 RID: 119697 RVA: 0x00935870 File Offset: 0x00933A70
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
				DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				drillTutorUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				DrillTutorUIController drillTutorUIController2 = (DrillTutorUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				drillTutorUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D392 RID: 119698 RVA: 0x00935980 File Offset: 0x00933B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			string s = drillTutorUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D393 RID: 119699 RVA: 0x009359DC File Offset: 0x00933BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D394 RID: 119700 RVA: 0x00935A30 File Offset: 0x00933C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D395 RID: 119701 RVA: 0x00935A84 File Offset: 0x00933C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowTutorHelp(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.__callDele_EventOnShowTutorHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D396 RID: 119702 RVA: 0x00935AD8 File Offset: 0x00933CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowTutorHelp(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			drillTutorUIController.m_luaExportHelper.__clearDele_EventOnShowTutorHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D397 RID: 119703 RVA: 0x00935B2C File Offset: 0x00933D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnConfirmAssistant(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			List<int> arg2;
			LuaObject.checkType<List<int>>(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			int arg4;
			LuaObject.checkType(l, 5, out arg4);
			drillTutorUIController.m_luaExportHelper.__callDele_EventOnConfirmAssistant(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D398 RID: 119704 RVA: 0x00935BB0 File Offset: 0x00933DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnConfirmAssistant(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			List<int> arg2;
			LuaObject.checkType<List<int>>(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			int arg4;
			LuaObject.checkType(l, 5, out arg4);
			drillTutorUIController.m_luaExportHelper.__clearDele_EventOnConfirmAssistant(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D399 RID: 119705 RVA: 0x00935C34 File Offset: 0x00933E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillTutorUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					drillTutorUIController.EventOnReturn -= value;
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

	// Token: 0x0601D39A RID: 119706 RVA: 0x00935CB4 File Offset: 0x00933EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowTutorHelp(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillTutorUIController.EventOnShowTutorHelp += value;
				}
				else if (num == 2)
				{
					drillTutorUIController.EventOnShowTutorHelp -= value;
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

	// Token: 0x0601D39B RID: 119707 RVA: 0x00935D34 File Offset: 0x00933F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnConfirmAssistant(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Action<int, List<int>, int, int> value;
			int num = LuaObject.checkDelegate<Action<int, List<int>, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					drillTutorUIController.EventOnConfirmAssistant += value;
				}
				else if (num == 2)
				{
					drillTutorUIController.EventOnConfirmAssistant -= value;
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

	// Token: 0x0601D39C RID: 119708 RVA: 0x00935DB4 File Offset: 0x00933FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D39D RID: 119709 RVA: 0x00935E0C File Offset: 0x0093400C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			drillTutorUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D39E RID: 119710 RVA: 0x00935E68 File Offset: 0x00934068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D39F RID: 119711 RVA: 0x00935EC0 File Offset: 0x009340C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			drillTutorUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3A0 RID: 119712 RVA: 0x00935F1C File Offset: 0x0093411C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recommendHeroGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_recommendHeroGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3A1 RID: 119713 RVA: 0x00935F74 File Offset: 0x00934174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recommendHeroGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			GameObject recommendHeroGroup;
			LuaObject.checkType<GameObject>(l, 2, out recommendHeroGroup);
			drillTutorUIController.m_luaExportHelper.m_recommendHeroGroup = recommendHeroGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3A2 RID: 119714 RVA: 0x00935FD0 File Offset: 0x009341D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroGroupButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroGroupButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3A3 RID: 119715 RVA: 0x00936028 File Offset: 0x00934228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroGroupButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Button heroGroupButton;
			LuaObject.checkType<Button>(l, 2, out heroGroupButton);
			drillTutorUIController.m_luaExportHelper.m_heroGroupButton = heroGroupButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3A4 RID: 119716 RVA: 0x00936084 File Offset: 0x00934284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chooseHeroDummy1(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_chooseHeroDummy1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3A5 RID: 119717 RVA: 0x009360DC File Offset: 0x009342DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chooseHeroDummy1(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			GameObject chooseHeroDummy;
			LuaObject.checkType<GameObject>(l, 2, out chooseHeroDummy);
			drillTutorUIController.m_luaExportHelper.m_chooseHeroDummy1 = chooseHeroDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3A6 RID: 119718 RVA: 0x00936138 File Offset: 0x00934338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chooseHeroDummy2(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_chooseHeroDummy2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3A7 RID: 119719 RVA: 0x00936190 File Offset: 0x00934390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chooseHeroDummy2(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			GameObject chooseHeroDummy;
			LuaObject.checkType<GameObject>(l, 2, out chooseHeroDummy);
			drillTutorUIController.m_luaExportHelper.m_chooseHeroDummy2 = chooseHeroDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3A8 RID: 119720 RVA: 0x009361EC File Offset: 0x009343EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chooseHeroDummy3(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_chooseHeroDummy3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3A9 RID: 119721 RVA: 0x00936244 File Offset: 0x00934444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chooseHeroDummy3(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			GameObject chooseHeroDummy;
			LuaObject.checkType<GameObject>(l, 2, out chooseHeroDummy);
			drillTutorUIController.m_luaExportHelper.m_chooseHeroDummy3 = chooseHeroDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3AA RID: 119722 RVA: 0x009362A0 File Offset: 0x009344A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDetailAchivementValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroDetailAchivementValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3AB RID: 119723 RVA: 0x009362F8 File Offset: 0x009344F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDetailAchivementValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Text heroDetailAchivementValueText;
			LuaObject.checkType<Text>(l, 2, out heroDetailAchivementValueText);
			drillTutorUIController.m_luaExportHelper.m_heroDetailAchivementValueText = heroDetailAchivementValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3AC RID: 119724 RVA: 0x00936354 File Offset: 0x00934554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3AD RID: 119725 RVA: 0x009363AC File Offset: 0x009345AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			CommonUIStateController heroListPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out heroListPanelStateCtrl);
			drillTutorUIController.m_luaExportHelper.m_heroListPanelStateCtrl = heroListPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3AE RID: 119726 RVA: 0x00936408 File Offset: 0x00934608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListPanelBGBackButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListPanelBGBackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3AF RID: 119727 RVA: 0x00936460 File Offset: 0x00934660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListPanelBGBackButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Button heroListPanelBGBackButton;
			LuaObject.checkType<Button>(l, 2, out heroListPanelBGBackButton);
			drillTutorUIController.m_luaExportHelper.m_heroListPanelBGBackButton = heroListPanelBGBackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3B0 RID: 119728 RVA: 0x009364BC File Offset: 0x009346BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListPanelHeroGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListPanelHeroGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3B1 RID: 119729 RVA: 0x00936514 File Offset: 0x00934714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListPanelHeroGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			GameObject heroListPanelHeroGroup;
			LuaObject.checkType<GameObject>(l, 2, out heroListPanelHeroGroup);
			drillTutorUIController.m_luaExportHelper.m_heroListPanelHeroGroup = heroListPanelHeroGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3B2 RID: 119730 RVA: 0x00936570 File Offset: 0x00934770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3B3 RID: 119731 RVA: 0x009365C8 File Offset: 0x009347C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			ScrollRect heroListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out heroListScrollRect);
			drillTutorUIController.m_luaExportHelper.m_heroListScrollRect = heroListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3B4 RID: 119732 RVA: 0x00936624 File Offset: 0x00934824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3B5 RID: 119733 RVA: 0x0093667C File Offset: 0x0093487C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			GameObject heroListScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out heroListScrollViewContent);
			drillTutorUIController.m_luaExportHelper.m_heroListScrollViewContent = heroListScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3B6 RID: 119734 RVA: 0x009366D8 File Offset: 0x009348D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3B7 RID: 119735 RVA: 0x00936730 File Offset: 0x00934930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Button heroListConfirmButton;
			LuaObject.checkType<Button>(l, 2, out heroListConfirmButton);
			drillTutorUIController.m_luaExportHelper.m_heroListConfirmButton = heroListConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3B8 RID: 119736 RVA: 0x0093678C File Offset: 0x0093498C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListChooseCountValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListChooseCountValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3B9 RID: 119737 RVA: 0x009367E4 File Offset: 0x009349E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListChooseCountValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Text heroListChooseCountValueText;
			LuaObject.checkType<Text>(l, 2, out heroListChooseCountValueText);
			drillTutorUIController.m_luaExportHelper.m_heroListChooseCountValueText = heroListChooseCountValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3BA RID: 119738 RVA: 0x00936840 File Offset: 0x00934A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListAchivementValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListAchivementValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3BB RID: 119739 RVA: 0x00936898 File Offset: 0x00934A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListAchivementValueText(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Text heroListAchivementValueText;
			LuaObject.checkType<Text>(l, 2, out heroListAchivementValueText);
			drillTutorUIController.m_luaExportHelper.m_heroListAchivementValueText = heroListAchivementValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3BC RID: 119740 RVA: 0x009368F4 File Offset: 0x00934AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListSortButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListSortButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3BD RID: 119741 RVA: 0x0093694C File Offset: 0x00934B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListSortButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Button heroListSortButton;
			LuaObject.checkType<Button>(l, 2, out heroListSortButton);
			drillTutorUIController.m_luaExportHelper.m_heroListSortButton = heroListSortButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3BE RID: 119742 RVA: 0x009369A8 File Offset: 0x00934BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListSortButtonTypeText(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListSortButtonTypeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3BF RID: 119743 RVA: 0x00936A00 File Offset: 0x00934C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListSortButtonTypeText(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Text heroListSortButtonTypeText;
			LuaObject.checkType<Text>(l, 2, out heroListSortButtonTypeText);
			drillTutorUIController.m_luaExportHelper.m_heroListSortButtonTypeText = heroListSortButtonTypeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3C0 RID: 119744 RVA: 0x00936A5C File Offset: 0x00934C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListSortTypesStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListSortTypesStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3C1 RID: 119745 RVA: 0x00936AB4 File Offset: 0x00934CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListSortTypesStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			CommonUIStateController heroListSortTypesStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out heroListSortTypesStateCtrl);
			drillTutorUIController.m_luaExportHelper.m_heroListSortTypesStateCtrl = heroListSortTypesStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3C2 RID: 119746 RVA: 0x00936B10 File Offset: 0x00934D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListSortTypesLevelToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListSortTypesLevelToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3C3 RID: 119747 RVA: 0x00936B68 File Offset: 0x00934D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListSortTypesLevelToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Toggle heroListSortTypesLevelToggle;
			LuaObject.checkType<Toggle>(l, 2, out heroListSortTypesLevelToggle);
			drillTutorUIController.m_luaExportHelper.m_heroListSortTypesLevelToggle = heroListSortTypesLevelToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3C4 RID: 119748 RVA: 0x00936BC4 File Offset: 0x00934DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListSortTypesStarLvToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListSortTypesStarLvToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3C5 RID: 119749 RVA: 0x00936C1C File Offset: 0x00934E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListSortTypesStarLvToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Toggle heroListSortTypesStarLvToggle;
			LuaObject.checkType<Toggle>(l, 2, out heroListSortTypesStarLvToggle);
			drillTutorUIController.m_luaExportHelper.m_heroListSortTypesStarLvToggle = heroListSortTypesStarLvToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3C6 RID: 119750 RVA: 0x00936C78 File Offset: 0x00934E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroListSortTypesAchievementToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroListSortTypesAchievementToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3C7 RID: 119751 RVA: 0x00936CD0 File Offset: 0x00934ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroListSortTypesAchievementToggle(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Toggle heroListSortTypesAchievementToggle;
			LuaObject.checkType<Toggle>(l, 2, out heroListSortTypesAchievementToggle);
			drillTutorUIController.m_luaExportHelper.m_heroListSortTypesAchievementToggle = heroListSortTypesAchievementToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3C8 RID: 119752 RVA: 0x00936D2C File Offset: 0x00934F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailDifficultyLevelBGImage(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_detailDifficultyLevelBGImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3C9 RID: 119753 RVA: 0x00936D84 File Offset: 0x00934F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailDifficultyLevelBGImage(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Image detailDifficultyLevelBGImage;
			LuaObject.checkType<Image>(l, 2, out detailDifficultyLevelBGImage);
			drillTutorUIController.m_luaExportHelper.m_detailDifficultyLevelBGImage = detailDifficultyLevelBGImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3CA RID: 119754 RVA: 0x00936DE0 File Offset: 0x00934FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamNumberText(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_teamNumberText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3CB RID: 119755 RVA: 0x00936E38 File Offset: 0x00935038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamNumberText(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Text teamNumberText;
			LuaObject.checkType<Text>(l, 2, out teamNumberText);
			drillTutorUIController.m_luaExportHelper.m_teamNumberText = teamNumberText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3CC RID: 119756 RVA: 0x00936E94 File Offset: 0x00935094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailDifficultyGroupScrollRect(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_detailDifficultyGroupScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3CD RID: 119757 RVA: 0x00936EEC File Offset: 0x009350EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailDifficultyGroupScrollRect(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			ScrollRect detailDifficultyGroupScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out detailDifficultyGroupScrollRect);
			drillTutorUIController.m_luaExportHelper.m_detailDifficultyGroupScrollRect = detailDifficultyGroupScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3CE RID: 119758 RVA: 0x00936F48 File Offset: 0x00935148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailDifficultyGroupContent(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_detailDifficultyGroupContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3CF RID: 119759 RVA: 0x00936FA0 File Offset: 0x009351A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailDifficultyGroupContent(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			GameObject detailDifficultyGroupContent;
			LuaObject.checkType<GameObject>(l, 2, out detailDifficultyGroupContent);
			drillTutorUIController.m_luaExportHelper.m_detailDifficultyGroupContent = detailDifficultyGroupContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3D0 RID: 119760 RVA: 0x00936FFC File Offset: 0x009351FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailRewardGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_detailRewardGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3D1 RID: 119761 RVA: 0x00937054 File Offset: 0x00935254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailRewardGroup(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			GameObject detailRewardGroup;
			LuaObject.checkType<GameObject>(l, 2, out detailRewardGroup);
			drillTutorUIController.m_luaExportHelper.m_detailRewardGroup = detailRewardGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3D2 RID: 119762 RVA: 0x009370B0 File Offset: 0x009352B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailTeachingTimeToggle1(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_detailTeachingTimeToggle1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3D3 RID: 119763 RVA: 0x00937108 File Offset: 0x00935308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailTeachingTimeToggle1(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Toggle detailTeachingTimeToggle;
			LuaObject.checkType<Toggle>(l, 2, out detailTeachingTimeToggle);
			drillTutorUIController.m_luaExportHelper.m_detailTeachingTimeToggle1 = detailTeachingTimeToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3D4 RID: 119764 RVA: 0x00937164 File Offset: 0x00935364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailTeachingTimeToggle2(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_detailTeachingTimeToggle2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3D5 RID: 119765 RVA: 0x009371BC File Offset: 0x009353BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailTeachingTimeToggle2(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Toggle detailTeachingTimeToggle;
			LuaObject.checkType<Toggle>(l, 2, out detailTeachingTimeToggle);
			drillTutorUIController.m_luaExportHelper.m_detailTeachingTimeToggle2 = detailTeachingTimeToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3D6 RID: 119766 RVA: 0x00937218 File Offset: 0x00935418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailTeachingTimeToggle3(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_detailTeachingTimeToggle3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3D7 RID: 119767 RVA: 0x00937270 File Offset: 0x00935470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailTeachingTimeToggle3(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Toggle detailTeachingTimeToggle;
			LuaObject.checkType<Toggle>(l, 2, out detailTeachingTimeToggle);
			drillTutorUIController.m_luaExportHelper.m_detailTeachingTimeToggle3 = detailTeachingTimeToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3D8 RID: 119768 RVA: 0x009372CC File Offset: 0x009354CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_detailConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3D9 RID: 119769 RVA: 0x00937324 File Offset: 0x00935524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			Button detailConfirmButton;
			LuaObject.checkType<Button>(l, 2, out detailConfirmButton);
			drillTutorUIController.m_luaExportHelper.m_detailConfirmButton = detailConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3DA RID: 119770 RVA: 0x00937380 File Offset: 0x00935580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailConfirmButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_detailConfirmButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3DB RID: 119771 RVA: 0x009373D8 File Offset: 0x009355D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailConfirmButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			CommonUIStateController detailConfirmButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out detailConfirmButtonStateCtrl);
			drillTutorUIController.m_luaExportHelper.m_detailConfirmButtonStateCtrl = detailConfirmButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3DC RID: 119772 RVA: 0x00937434 File Offset: 0x00935634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teachStartPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_teachStartPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3DD RID: 119773 RVA: 0x0093748C File Offset: 0x0093568C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teachStartPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			CommonUIStateController teachStartPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out teachStartPanelStateCtrl);
			drillTutorUIController.m_luaExportHelper.m_teachStartPanelStateCtrl = teachStartPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3DE RID: 119774 RVA: 0x009374E8 File Offset: 0x009356E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroItemprefab(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_heroItemprefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3DF RID: 119775 RVA: 0x00937540 File Offset: 0x00935740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroItemprefab(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			GameObject heroItemprefab;
			LuaObject.checkType<GameObject>(l, 2, out heroItemprefab);
			drillTutorUIController.m_luaExportHelper.m_heroItemprefab = heroItemprefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3E0 RID: 119776 RVA: 0x0093759C File Offset: 0x0093579C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curHeroSortType(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)drillTutorUIController.m_luaExportHelper.m_curHeroSortType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3E1 RID: 119777 RVA: 0x009375F4 File Offset: 0x009357F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curHeroSortType(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			DrillTutorUIController.HeroSortType curHeroSortType;
			LuaObject.checkEnum<DrillTutorUIController.HeroSortType>(l, 2, out curHeroSortType);
			drillTutorUIController.m_luaExportHelper.m_curHeroSortType = curHeroSortType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3E2 RID: 119778 RVA: 0x00937650 File Offset: 0x00935850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curChooseHeroIds(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_curChooseHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3E3 RID: 119779 RVA: 0x009376A8 File Offset: 0x009358A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curChooseHeroIds(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			List<int> curChooseHeroIds;
			LuaObject.checkType<List<int>>(l, 2, out curChooseHeroIds);
			drillTutorUIController.m_luaExportHelper.m_curChooseHeroIds = curChooseHeroIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3E4 RID: 119780 RVA: 0x00937704 File Offset: 0x00935904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempChooseHeroIds(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_tempChooseHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3E5 RID: 119781 RVA: 0x0093775C File Offset: 0x0093595C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempChooseHeroIds(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			List<int> tempChooseHeroIds;
			LuaObject.checkType<List<int>>(l, 2, out tempChooseHeroIds);
			drillTutorUIController.m_luaExportHelper.m_tempChooseHeroIds = tempChooseHeroIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3E6 RID: 119782 RVA: 0x009377B8 File Offset: 0x009359B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3E7 RID: 119783 RVA: 0x00937810 File Offset: 0x00935A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			drillTutorUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3E8 RID: 119784 RVA: 0x0093786C File Offset: 0x00935A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3E9 RID: 119785 RVA: 0x009378C4 File Offset: 0x00935AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			drillTutorUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3EA RID: 119786 RVA: 0x00937920 File Offset: 0x00935B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curHeroAssistantsTask(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_curHeroAssistantsTask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3EB RID: 119787 RVA: 0x00937978 File Offset: 0x00935B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curHeroAssistantsTask(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			HeroAssistantsTask curHeroAssistantsTask;
			LuaObject.checkType<HeroAssistantsTask>(l, 2, out curHeroAssistantsTask);
			drillTutorUIController.m_luaExportHelper.m_curHeroAssistantsTask = curHeroAssistantsTask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3EC RID: 119788 RVA: 0x009379D4 File Offset: 0x00935BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curDifficultLevel(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_curDifficultLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3ED RID: 119789 RVA: 0x00937A2C File Offset: 0x00935C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curDifficultLevel(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			int curDifficultLevel;
			LuaObject.checkType(l, 2, out curDifficultLevel);
			drillTutorUIController.m_luaExportHelper.m_curDifficultLevel = curDifficultLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3EE RID: 119790 RVA: 0x00937A88 File Offset: 0x00935C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curWorkSeconds(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_curWorkSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3EF RID: 119791 RVA: 0x00937AE0 File Offset: 0x00935CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curWorkSeconds(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			int curWorkSeconds;
			LuaObject.checkType(l, 2, out curWorkSeconds);
			drillTutorUIController.m_luaExportHelper.m_curWorkSeconds = curWorkSeconds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3F0 RID: 119792 RVA: 0x00937B3C File Offset: 0x00935D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allTaskList(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_allTaskList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3F1 RID: 119793 RVA: 0x00937B94 File Offset: 0x00935D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allTaskList(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			List<HeroAssistantsTask> allTaskList;
			LuaObject.checkType<List<HeroAssistantsTask>>(l, 2, out allTaskList);
			drillTutorUIController.m_luaExportHelper.m_allTaskList = allTaskList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3F2 RID: 119794 RVA: 0x00937BF0 File Offset: 0x00935DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_slot(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_slot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3F3 RID: 119795 RVA: 0x00937C48 File Offset: 0x00935E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_slot(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			drillTutorUIController.m_luaExportHelper.m_slot = slot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3F4 RID: 119796 RVA: 0x00937CA4 File Offset: 0x00935EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drillTutorUIController.m_luaExportHelper.m_isFirstIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3F5 RID: 119797 RVA: 0x00937CFC File Offset: 0x00935EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			DrillTutorUIController drillTutorUIController = (DrillTutorUIController)LuaObject.checkSelf(l);
			bool isFirstIn;
			LuaObject.checkType(l, 2, out isFirstIn);
			drillTutorUIController.m_luaExportHelper.m_isFirstIn = isFirstIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D3F6 RID: 119798 RVA: 0x00937D58 File Offset: 0x00935F58
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DrillTutorUIController");
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.UpdateViewInDrillTutor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.PlayStartTeachEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.SetDifficultScrollViewPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.SetConfirmButtonState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.SetDifficultBgBySlot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.SetDifficultInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnDifficultItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.SetWorkHour);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.SetRecommendHeroGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.SetCurChooseHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.SetRewardGroupList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.GetRewardsList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.SetChooseHeroListPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.HeroListItemComparator);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnTrainingHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.SetHeroListResultDetailPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.CalcHeroTotalAchievementvalue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnChooseHeroButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnHeroListConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnHeroListPanelBGBackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnDetailConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnLevelToggleChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnStarLvToggleChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnAchievementToggleChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnHeroSortButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.CloseSortTypesPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.ResetData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callDele_EventOnShowTutorHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__clearDele_EventOnShowTutorHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__callDele_EventOnConfirmAssistant);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.__clearDele_EventOnConfirmAssistant);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache31);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache32, true);
		string name2 = "EventOnShowTutorHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_EventOnShowTutorHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache33, true);
		string name3 = "EventOnConfirmAssistant";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_EventOnConfirmAssistant);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache34, true);
		string name4 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_returnButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache36, true);
		string name5 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_helpButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache38, true);
		string name6 = "m_recommendHeroGroup";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_recommendHeroGroup);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_recommendHeroGroup);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3A, true);
		string name7 = "m_heroGroupButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroGroupButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroGroupButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3C, true);
		string name8 = "m_chooseHeroDummy1";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_chooseHeroDummy1);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_chooseHeroDummy1);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3E, true);
		string name9 = "m_chooseHeroDummy2";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_chooseHeroDummy2);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_chooseHeroDummy2);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache40, true);
		string name10 = "m_chooseHeroDummy3";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_chooseHeroDummy3);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_chooseHeroDummy3);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache42, true);
		string name11 = "m_heroDetailAchivementValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroDetailAchivementValueText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroDetailAchivementValueText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache44, true);
		string name12 = "m_heroListPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListPanelStateCtrl);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListPanelStateCtrl);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache46, true);
		string name13 = "m_heroListPanelBGBackButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListPanelBGBackButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListPanelBGBackButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache48, true);
		string name14 = "m_heroListPanelHeroGroup";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListPanelHeroGroup);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListPanelHeroGroup);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4A, true);
		string name15 = "m_heroListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListScrollRect);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListScrollRect);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4C, true);
		string name16 = "m_heroListScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListScrollViewContent);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListScrollViewContent);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4E, true);
		string name17 = "m_heroListConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListConfirmButton);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListConfirmButton);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache50, true);
		string name18 = "m_heroListChooseCountValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListChooseCountValueText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListChooseCountValueText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache52, true);
		string name19 = "m_heroListAchivementValueText";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListAchivementValueText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListAchivementValueText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache54, true);
		string name20 = "m_heroListSortButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListSortButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListSortButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache56, true);
		string name21 = "m_heroListSortButtonTypeText";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListSortButtonTypeText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListSortButtonTypeText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache58, true);
		string name22 = "m_heroListSortTypesStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListSortTypesStateCtrl);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListSortTypesStateCtrl);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5A, true);
		string name23 = "m_heroListSortTypesLevelToggle";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListSortTypesLevelToggle);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListSortTypesLevelToggle);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5C, true);
		string name24 = "m_heroListSortTypesStarLvToggle";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListSortTypesStarLvToggle);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListSortTypesStarLvToggle);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5E, true);
		string name25 = "m_heroListSortTypesAchievementToggle";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroListSortTypesAchievementToggle);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroListSortTypesAchievementToggle);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache60, true);
		string name26 = "m_detailDifficultyLevelBGImage";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_detailDifficultyLevelBGImage);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_detailDifficultyLevelBGImage);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache62, true);
		string name27 = "m_teamNumberText";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_teamNumberText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_teamNumberText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache64, true);
		string name28 = "m_detailDifficultyGroupScrollRect";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_detailDifficultyGroupScrollRect);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_detailDifficultyGroupScrollRect);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache66, true);
		string name29 = "m_detailDifficultyGroupContent";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_detailDifficultyGroupContent);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_detailDifficultyGroupContent);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache68, true);
		string name30 = "m_detailRewardGroup";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_detailRewardGroup);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_detailRewardGroup);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6A, true);
		string name31 = "m_detailTeachingTimeToggle1";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_detailTeachingTimeToggle1);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_detailTeachingTimeToggle1);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6C, true);
		string name32 = "m_detailTeachingTimeToggle2";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_detailTeachingTimeToggle2);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_detailTeachingTimeToggle2);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6E, true);
		string name33 = "m_detailTeachingTimeToggle3";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_detailTeachingTimeToggle3);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_detailTeachingTimeToggle3);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache70, true);
		string name34 = "m_detailConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_detailConfirmButton);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_detailConfirmButton);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache72, true);
		string name35 = "m_detailConfirmButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_detailConfirmButtonStateCtrl);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_detailConfirmButtonStateCtrl);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache74, true);
		string name36 = "m_teachStartPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_teachStartPanelStateCtrl);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_teachStartPanelStateCtrl);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache76, true);
		string name37 = "m_heroItemprefab";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_heroItemprefab);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_heroItemprefab);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache78, true);
		string name38 = "m_curHeroSortType";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_curHeroSortType);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_curHeroSortType);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7A, true);
		string name39 = "m_curChooseHeroIds";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_curChooseHeroIds);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_curChooseHeroIds);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7C, true);
		string name40 = "m_tempChooseHeroIds";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_tempChooseHeroIds);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_tempChooseHeroIds);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7E, true);
		string name41 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_playerContext);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache80, true);
		string name42 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_configDataLoader);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache82, true);
		string name43 = "m_curHeroAssistantsTask";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_curHeroAssistantsTask);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_curHeroAssistantsTask);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache84, true);
		string name44 = "m_curDifficultLevel";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_curDifficultLevel);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_curDifficultLevel);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache86, true);
		string name45 = "m_curWorkSeconds";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_curWorkSeconds);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_curWorkSeconds);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache88, true);
		string name46 = "m_allTaskList";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_allTaskList);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_allTaskList);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8A, true);
		string name47 = "m_slot";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_slot);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_slot);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8C, true);
		string name48 = "m_isFirstIn";
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.get_m_isFirstIn);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.set_m_isFirstIn);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_DrillTutorUIController.<>f__mg$cache8E, true);
		LuaObject.createTypeMetatable(l, null, typeof(DrillTutorUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013513 RID: 79123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013514 RID: 79124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013515 RID: 79125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013516 RID: 79126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013517 RID: 79127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013518 RID: 79128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013519 RID: 79129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401351A RID: 79130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401351B RID: 79131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401351C RID: 79132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401351D RID: 79133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401351E RID: 79134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401351F RID: 79135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013520 RID: 79136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013521 RID: 79137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013522 RID: 79138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013523 RID: 79139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013524 RID: 79140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013525 RID: 79141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013526 RID: 79142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013527 RID: 79143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013528 RID: 79144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013529 RID: 79145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401352A RID: 79146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401352B RID: 79147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401352C RID: 79148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401352D RID: 79149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401352E RID: 79150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401352F RID: 79151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013530 RID: 79152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013531 RID: 79153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013532 RID: 79154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013533 RID: 79155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013534 RID: 79156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013535 RID: 79157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013536 RID: 79158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013537 RID: 79159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013538 RID: 79160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013539 RID: 79161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401353A RID: 79162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401353B RID: 79163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401353C RID: 79164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401353D RID: 79165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401353E RID: 79166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401353F RID: 79167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013540 RID: 79168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013541 RID: 79169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013542 RID: 79170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013543 RID: 79171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013544 RID: 79172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013545 RID: 79173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013546 RID: 79174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013547 RID: 79175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013548 RID: 79176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013549 RID: 79177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401354A RID: 79178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401354B RID: 79179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401354C RID: 79180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401354D RID: 79181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401354E RID: 79182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401354F RID: 79183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04013550 RID: 79184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04013551 RID: 79185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013552 RID: 79186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04013553 RID: 79187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04013554 RID: 79188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013555 RID: 79189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04013556 RID: 79190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04013557 RID: 79191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04013558 RID: 79192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013559 RID: 79193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401355A RID: 79194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401355B RID: 79195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401355C RID: 79196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401355D RID: 79197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401355E RID: 79198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401355F RID: 79199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04013560 RID: 79200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04013561 RID: 79201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04013562 RID: 79202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04013563 RID: 79203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04013564 RID: 79204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04013565 RID: 79205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04013566 RID: 79206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04013567 RID: 79207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04013568 RID: 79208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04013569 RID: 79209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401356A RID: 79210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401356B RID: 79211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401356C RID: 79212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401356D RID: 79213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401356E RID: 79214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401356F RID: 79215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04013570 RID: 79216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04013571 RID: 79217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04013572 RID: 79218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04013573 RID: 79219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04013574 RID: 79220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04013575 RID: 79221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04013576 RID: 79222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04013577 RID: 79223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04013578 RID: 79224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04013579 RID: 79225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0401357A RID: 79226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401357B RID: 79227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401357C RID: 79228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401357D RID: 79229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401357E RID: 79230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401357F RID: 79231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04013580 RID: 79232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04013581 RID: 79233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04013582 RID: 79234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04013583 RID: 79235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04013584 RID: 79236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04013585 RID: 79237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04013586 RID: 79238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04013587 RID: 79239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04013588 RID: 79240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04013589 RID: 79241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0401358A RID: 79242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0401358B RID: 79243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0401358C RID: 79244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0401358D RID: 79245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0401358E RID: 79246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0401358F RID: 79247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04013590 RID: 79248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04013591 RID: 79249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04013592 RID: 79250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04013593 RID: 79251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04013594 RID: 79252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04013595 RID: 79253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04013596 RID: 79254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04013597 RID: 79255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04013598 RID: 79256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04013599 RID: 79257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0401359A RID: 79258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0401359B RID: 79259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0401359C RID: 79260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0401359D RID: 79261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0401359E RID: 79262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401359F RID: 79263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x040135A0 RID: 79264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x040135A1 RID: 79265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;
}
