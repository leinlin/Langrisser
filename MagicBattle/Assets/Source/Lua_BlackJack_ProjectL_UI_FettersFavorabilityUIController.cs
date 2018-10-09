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

// Token: 0x0200143A RID: 5178
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController : LuaObject
{
	// Token: 0x0601DBCB RID: 121803 RVA: 0x00977408 File Offset: 0x00975608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInFettersFavorability(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersFavorabilityUIController.UpdateViewInFettersFavorability(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBCC RID: 121804 RVA: 0x00977460 File Offset: 0x00975660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenFettersFavorability(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.OpenFettersFavorability();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBCD RID: 121805 RVA: 0x009774AC File Offset: 0x009756AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTouchRecoverTime(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			TimeSpan touchRecoverTime;
			LuaObject.checkValueType<TimeSpan>(l, 2, out touchRecoverTime);
			fettersFavorabilityUIController.SetTouchRecoverTime(touchRecoverTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBCE RID: 121806 RVA: 0x00977504 File Offset: 0x00975704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroInteractSucceed(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			int heroPerformanceId;
			LuaObject.checkType(l, 3, out heroPerformanceId);
			HeroInteractionResultType heroInteractionResultType;
			LuaObject.checkEnum<HeroInteractionResultType>(l, 4, out heroInteractionResultType);
			int addExp;
			LuaObject.checkType(l, 5, out addExp);
			fettersFavorabilityUIController.OnHeroInteractSucceed(rewards, heroPerformanceId, heroInteractionResultType, addExp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBCF RID: 121807 RVA: 0x00977584 File Offset: 0x00975784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInFettersGift(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersFavorabilityUIController.UpdateViewInFettersGift(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBD0 RID: 121808 RVA: 0x009775DC File Offset: 0x009757DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenFettersGift(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.OpenFettersGift();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBD1 RID: 121809 RVA: 0x00977628 File Offset: 0x00975828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayHeroPerformance(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			int heroPerformanceId;
			LuaObject.checkType(l, 2, out heroPerformanceId);
			fettersFavorabilityUIController.PlayHeroPerformance(heroPerformanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBD2 RID: 121810 RVA: 0x00977680 File Offset: 0x00975880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoToInformationPanel(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			bool isGotoOrReturn;
			LuaObject.checkType(l, 2, out isGotoOrReturn);
			fettersFavorabilityUIController.GoToInformationPanel(isGotoOrReturn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBD3 RID: 121811 RVA: 0x009776D8 File Offset: 0x009758D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBD4 RID: 121812 RVA: 0x0097772C File Offset: 0x0097592C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBD5 RID: 121813 RVA: 0x00977780 File Offset: 0x00975980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFavorabilityValue(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.SetFavorabilityValue();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBD6 RID: 121814 RVA: 0x009777D4 File Offset: 0x009759D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTouchCountState(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.SetTouchCountState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBD7 RID: 121815 RVA: 0x00977828 File Offset: 0x00975A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DragTrigger_EventOnSliderFull(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.DragTrigger_EventOnSliderFull();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBD8 RID: 121816 RVA: 0x0097787C File Offset: 0x00975A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DragTrigger_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.DragTrigger_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBD9 RID: 121817 RVA: 0x009778D0 File Offset: 0x00975AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DragTrigger_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.DragTrigger_EventOnEndDrag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBDA RID: 121818 RVA: 0x00977924 File Offset: 0x00975B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DragTrigger_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.DragTrigger_EventOnBeginDrag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBDB RID: 121819 RVA: 0x00977978 File Offset: 0x00975B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DragTrigger_EventOnSliderEmpty(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.DragTrigger_EventOnSliderEmpty();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBDC RID: 121820 RVA: 0x009779CC File Offset: 0x00975BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTouchStateCtrlOut(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			string touchStateCtrlOut;
			LuaObject.checkType(l, 2, out touchStateCtrlOut);
			fettersFavorabilityUIController.m_luaExportHelper.SetTouchStateCtrlOut(touchStateCtrlOut);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBDD RID: 121821 RVA: 0x00977A28 File Offset: 0x00975C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCharGoTweenPos(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			bool charGoTweenPos;
			LuaObject.checkType(l, 2, out charGoTweenPos);
			fettersFavorabilityUIController.m_luaExportHelper.SetCharGoTweenPos(charGoTweenPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBDE RID: 121822 RVA: 0x00977A84 File Offset: 0x00975C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AfterHeroInteractionResultEffect(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			string stateName;
			LuaObject.checkType(l, 2, out stateName);
			int heroPerformanceId;
			LuaObject.checkType(l, 3, out heroPerformanceId);
			fettersFavorabilityUIController.m_luaExportHelper.AfterHeroInteractionResultEffect(stateName, heroPerformanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBDF RID: 121823 RVA: 0x00977AF0 File Offset: 0x00975CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayFavorbilityLevelUp(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			int heroPerformanceId;
			LuaObject.checkType(l, 2, out heroPerformanceId);
			fettersFavorabilityUIController.m_luaExportHelper.PlayFavorbilityLevelUp(heroPerformanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBE0 RID: 121824 RVA: 0x00977B4C File Offset: 0x00975D4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Co_PlayHeroInteractEffect(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			int heroPerformanceId;
			LuaObject.checkType(l, 2, out heroPerformanceId);
			IEnumerator o = fettersFavorabilityUIController.m_luaExportHelper.Co_PlayHeroInteractEffect(heroPerformanceId);
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

	// Token: 0x0601DBE1 RID: 121825 RVA: 0x00977BB4 File Offset: 0x00975DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCharContinueButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.OnCharContinueButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBE2 RID: 121826 RVA: 0x00977C08 File Offset: 0x00975E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowUnlockEvents(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.ShowUnlockEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBE3 RID: 121827 RVA: 0x00977C5C File Offset: 0x00975E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUnlockEvents(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersFavorabilityUIController.m_luaExportHelper.GetUnlockEvents(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBE4 RID: 121828 RVA: 0x00977CB8 File Offset: 0x00975EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnlockEventBackButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.OnUnlockEventBackButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBE5 RID: 121829 RVA: 0x00977D0C File Offset: 0x00975F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPresentContent(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.SetPresentContent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBE6 RID: 121830 RVA: 0x00977D60 File Offset: 0x00975F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GiftBagItemComparer(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			BagItemBase a;
			LuaObject.checkType<BagItemBase>(l, 2, out a);
			BagItemBase b;
			LuaObject.checkType<BagItemBase>(l, 3, out b);
			int i = fettersFavorabilityUIController.m_luaExportHelper.GiftBagItemComparer(a, b);
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

	// Token: 0x0601DBE7 RID: 121831 RVA: 0x00977DD4 File Offset: 0x00975FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSendButtonClickDown(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.OnSendButtonClickDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBE8 RID: 121832 RVA: 0x00977E28 File Offset: 0x00976028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendUseGiftEvent(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.SendUseGiftEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBE9 RID: 121833 RVA: 0x00977E7C File Offset: 0x0097607C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WaitTimeThenDoEvent(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			IEnumerator o = fettersFavorabilityUIController.m_luaExportHelper.WaitTimeThenDoEvent(count);
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

	// Token: 0x0601DBEA RID: 121834 RVA: 0x00977EE4 File Offset: 0x009760E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUseGiftItemSucceed(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			fettersFavorabilityUIController.m_luaExportHelper.OnUseGiftItemSucceed(rewards);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBEB RID: 121835 RVA: 0x00977F40 File Offset: 0x00976140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGiftItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			FettersGiftItemUIController ctrl;
			LuaObject.checkType<FettersGiftItemUIController>(l, 2, out ctrl);
			bool isNeedShowDesc;
			LuaObject.checkType(l, 3, out isNeedShowDesc);
			fettersFavorabilityUIController.m_luaExportHelper.OnGiftItemClick(ctrl, isNeedShowDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBEC RID: 121836 RVA: 0x00977FAC File Offset: 0x009761AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LocalAddExpTick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.LocalAddExpTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBED RID: 121837 RVA: 0x00978000 File Offset: 0x00976200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetFavorabilityValue(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			int curFavoribilityLv;
			LuaObject.checkType(l, 2, out curFavoribilityLv);
			int addLv;
			LuaObject.checkType(l, 3, out addLv);
			float finalSliderValue;
			LuaObject.checkType(l, 4, out finalSliderValue);
			IEnumerator o = fettersFavorabilityUIController.m_luaExportHelper.Co_SetFavorabilityValue(curFavoribilityLv, addLv, finalSliderValue);
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

	// Token: 0x0601DBEE RID: 121838 RVA: 0x00978084 File Offset: 0x00976284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetItemCountPanel(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.SetItemCountPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBEF RID: 121839 RVA: 0x009780D8 File Offset: 0x009762D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBF0 RID: 121840 RVA: 0x0097812C File Offset: 0x0097632C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_OnAnimationFinishedEnableInput(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			IEnumerator o = fettersFavorabilityUIController.m_luaExportHelper.Co_OnAnimationFinishedEnableInput(time);
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

	// Token: 0x0601DBF1 RID: 121841 RVA: 0x00978194 File Offset: 0x00976394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBF2 RID: 121842 RVA: 0x009781E8 File Offset: 0x009763E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInformationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.OnInformationButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBF3 RID: 121843 RVA: 0x0097823C File Offset: 0x0097643C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFettersButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.OnFettersButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBF4 RID: 121844 RVA: 0x00978290 File Offset: 0x00976490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.OnMemoryButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBF5 RID: 121845 RVA: 0x009782E4 File Offset: 0x009764E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGiftButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.OnGiftButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBF6 RID: 121846 RVA: 0x00978338 File Offset: 0x00976538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetGiftScrollViewPosition(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.ResetGiftScrollViewPosition();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBF7 RID: 121847 RVA: 0x0097838C File Offset: 0x0097658C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InactiveWordGameObject(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.InactiveWordGameObject();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBF8 RID: 121848 RVA: 0x009783E0 File Offset: 0x009765E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			fettersFavorabilityUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBF9 RID: 121849 RVA: 0x0097844C File Offset: 0x0097664C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBFA RID: 121850 RVA: 0x009784A0 File Offset: 0x009766A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBFB RID: 121851 RVA: 0x009784F4 File Offset: 0x009766F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = fettersFavorabilityUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DBFC RID: 121852 RVA: 0x0097859C File Offset: 0x0097679C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBFD RID: 121853 RVA: 0x009785F0 File Offset: 0x009767F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			fettersFavorabilityUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBFE RID: 121854 RVA: 0x0097865C File Offset: 0x0097685C
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
				FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				fettersFavorabilityUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FettersFavorabilityUIController fettersFavorabilityUIController2 = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				fettersFavorabilityUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DBFF RID: 121855 RVA: 0x0097876C File Offset: 0x0097696C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersFavorabilityUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC00 RID: 121856 RVA: 0x009787D8 File Offset: 0x009769D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersFavorabilityUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC01 RID: 121857 RVA: 0x00978844 File Offset: 0x00976A44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersFavorabilityUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC02 RID: 121858 RVA: 0x009788B0 File Offset: 0x00976AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersFavorabilityUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC03 RID: 121859 RVA: 0x0097891C File Offset: 0x00976B1C
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
				FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				fettersFavorabilityUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FettersFavorabilityUIController fettersFavorabilityUIController2 = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				fettersFavorabilityUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DC04 RID: 121860 RVA: 0x00978A2C File Offset: 0x00976C2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			string s = fettersFavorabilityUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DC05 RID: 121861 RVA: 0x00978A88 File Offset: 0x00976C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC06 RID: 121862 RVA: 0x00978ADC File Offset: 0x00976CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC07 RID: 121863 RVA: 0x00978B30 File Offset: 0x00976D30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC08 RID: 121864 RVA: 0x00978B84 File Offset: 0x00976D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC09 RID: 121865 RVA: 0x00978BD8 File Offset: 0x00976DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSliderFull(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.__callDele_EventOnSliderFull();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC0A RID: 121866 RVA: 0x00978C2C File Offset: 0x00976E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSliderFull(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.__clearDele_EventOnSliderFull();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC0B RID: 121867 RVA: 0x00978C80 File Offset: 0x00976E80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnGiftButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersFavorabilityUIController.m_luaExportHelper.__callDele_EventOnGiftButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC0C RID: 121868 RVA: 0x00978CDC File Offset: 0x00976EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGiftButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersFavorabilityUIController.m_luaExportHelper.__clearDele_EventOnGiftButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC0D RID: 121869 RVA: 0x00978D38 File Offset: 0x00976F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnMemoryButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersFavorabilityUIController.m_luaExportHelper.__callDele_EventOnMemoryButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC0E RID: 121870 RVA: 0x00978D94 File Offset: 0x00976F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnMemoryButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersFavorabilityUIController.m_luaExportHelper.__clearDele_EventOnMemoryButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC0F RID: 121871 RVA: 0x00978DF0 File Offset: 0x00976FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnFettersButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersFavorabilityUIController.m_luaExportHelper.__callDele_EventOnFettersButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC10 RID: 121872 RVA: 0x00978E4C File Offset: 0x0097704C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnFettersButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersFavorabilityUIController.m_luaExportHelper.__clearDele_EventOnFettersButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC11 RID: 121873 RVA: 0x00978EA8 File Offset: 0x009770A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnInformationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersFavorabilityUIController.m_luaExportHelper.__callDele_EventOnInformationButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC12 RID: 121874 RVA: 0x00978F04 File Offset: 0x00977104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnInformationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersFavorabilityUIController.m_luaExportHelper.__clearDele_EventOnInformationButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC13 RID: 121875 RVA: 0x00978F60 File Offset: 0x00977160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUseGift(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			Action<List<Goods>> arg4;
			LuaObject.checkDelegate<Action<List<Goods>>>(l, 5, out arg4);
			fettersFavorabilityUIController.m_luaExportHelper.__callDele_EventOnUseGift(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC14 RID: 121876 RVA: 0x00978FE4 File Offset: 0x009771E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnUseGift(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			Action<List<Goods>> arg4;
			LuaObject.checkDelegate<Action<List<Goods>>>(l, 5, out arg4);
			fettersFavorabilityUIController.m_luaExportHelper.__clearDele_EventOnUseGift(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC15 RID: 121877 RVA: 0x00979068 File Offset: 0x00977268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoBagFullPanel(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.__callDele_EventOnGotoBagFullPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC16 RID: 121878 RVA: 0x009790BC File Offset: 0x009772BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoBagFullPanel(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			fettersFavorabilityUIController.m_luaExportHelper.__clearDele_EventOnGotoBagFullPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC17 RID: 121879 RVA: 0x00979110 File Offset: 0x00977310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersFavorabilityUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					fettersFavorabilityUIController.EventOnReturn -= value;
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

	// Token: 0x0601DC18 RID: 121880 RVA: 0x00979190 File Offset: 0x00977390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersFavorabilityUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					fettersFavorabilityUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601DC19 RID: 121881 RVA: 0x00979210 File Offset: 0x00977410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSliderFull(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersFavorabilityUIController.EventOnSliderFull += value;
				}
				else if (num == 2)
				{
					fettersFavorabilityUIController.EventOnSliderFull -= value;
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

	// Token: 0x0601DC1A RID: 121882 RVA: 0x00979290 File Offset: 0x00977490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGiftButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Action<Hero> value;
			int num = LuaObject.checkDelegate<Action<Hero>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersFavorabilityUIController.EventOnGiftButtonClick += value;
				}
				else if (num == 2)
				{
					fettersFavorabilityUIController.EventOnGiftButtonClick -= value;
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

	// Token: 0x0601DC1B RID: 121883 RVA: 0x00979310 File Offset: 0x00977510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnMemoryButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Action<Hero> value;
			int num = LuaObject.checkDelegate<Action<Hero>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersFavorabilityUIController.EventOnMemoryButtonClick += value;
				}
				else if (num == 2)
				{
					fettersFavorabilityUIController.EventOnMemoryButtonClick -= value;
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

	// Token: 0x0601DC1C RID: 121884 RVA: 0x00979390 File Offset: 0x00977590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnFettersButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Action<Hero> value;
			int num = LuaObject.checkDelegate<Action<Hero>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersFavorabilityUIController.EventOnFettersButtonClick += value;
				}
				else if (num == 2)
				{
					fettersFavorabilityUIController.EventOnFettersButtonClick -= value;
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

	// Token: 0x0601DC1D RID: 121885 RVA: 0x00979410 File Offset: 0x00977610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnInformationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Action<Hero> value;
			int num = LuaObject.checkDelegate<Action<Hero>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersFavorabilityUIController.EventOnInformationButtonClick += value;
				}
				else if (num == 2)
				{
					fettersFavorabilityUIController.EventOnInformationButtonClick -= value;
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

	// Token: 0x0601DC1E RID: 121886 RVA: 0x00979490 File Offset: 0x00977690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUseGift(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Action<GoodsType, int, int, Action<List<Goods>>> value;
			int num = LuaObject.checkDelegate<Action<GoodsType, int, int, Action<List<Goods>>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersFavorabilityUIController.EventOnUseGift += value;
				}
				else if (num == 2)
				{
					fettersFavorabilityUIController.EventOnUseGift -= value;
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

	// Token: 0x0601DC1F RID: 121887 RVA: 0x00979510 File Offset: 0x00977710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoBagFullPanel(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersFavorabilityUIController.EventOnGotoBagFullPanel += value;
				}
				else if (num == 2)
				{
					fettersFavorabilityUIController.EventOnGotoBagFullPanel -= value;
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

	// Token: 0x0601DC20 RID: 121888 RVA: 0x00979590 File Offset: 0x00977790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC21 RID: 121889 RVA: 0x009795E8 File Offset: 0x009777E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			fettersFavorabilityUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC22 RID: 121890 RVA: 0x00979644 File Offset: 0x00977844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_commonUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC23 RID: 121891 RVA: 0x0097969C File Offset: 0x0097789C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController commonUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out commonUIStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_commonUIStateCtrl = commonUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC24 RID: 121892 RVA: 0x009796F8 File Offset: 0x009778F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sexStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_sexStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC25 RID: 121893 RVA: 0x00979750 File Offset: 0x00977950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sexStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController sexStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out sexStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_sexStateCtrl = sexStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC26 RID: 121894 RVA: 0x009797AC File Offset: 0x009779AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_touchInOutStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_touchInOutStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC27 RID: 121895 RVA: 0x00979804 File Offset: 0x00977A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchInOutStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController touchInOutStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out touchInOutStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_touchInOutStateCtrl = touchInOutStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC28 RID: 121896 RVA: 0x00979860 File Offset: 0x00977A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelUpStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_levelUpStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC29 RID: 121897 RVA: 0x009798B8 File Offset: 0x00977AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelUpStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController levelUpStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out levelUpStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_levelUpStateCtrl = levelUpStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC2A RID: 121898 RVA: 0x00979914 File Offset: 0x00977B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_touchStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_touchStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC2B RID: 121899 RVA: 0x0097996C File Offset: 0x00977B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController touchStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out touchStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_touchStateCtrl = touchStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC2C RID: 121900 RVA: 0x009799C8 File Offset: 0x00977BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_infoStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC2D RID: 121901 RVA: 0x00979A20 File Offset: 0x00977C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController infoStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out infoStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_infoStateCtrl = infoStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC2E RID: 121902 RVA: 0x00979A7C File Offset: 0x00977C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC2F RID: 121903 RVA: 0x00979AD4 File Offset: 0x00977CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController presentStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out presentStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentStateCtrl = presentStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC30 RID: 121904 RVA: 0x00979B30 File Offset: 0x00977D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC31 RID: 121905 RVA: 0x00979B88 File Offset: 0x00977D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			fettersFavorabilityUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC32 RID: 121906 RVA: 0x00979BE4 File Offset: 0x00977DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC33 RID: 121907 RVA: 0x00979C3C File Offset: 0x00977E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			fettersFavorabilityUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC34 RID: 121908 RVA: 0x00979C98 File Offset: 0x00977E98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_favorabilityValueTextStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityValueTextStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC35 RID: 121909 RVA: 0x00979CF0 File Offset: 0x00977EF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_favorabilityValueTextStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController favorabilityValueTextStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out favorabilityValueTextStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityValueTextStateCtrl = favorabilityValueTextStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC36 RID: 121910 RVA: 0x00979D4C File Offset: 0x00977F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_favorabilityValueText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC37 RID: 121911 RVA: 0x00979DA4 File Offset: 0x00977FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_favorabilityValueText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Text favorabilityValueText;
			LuaObject.checkType<Text>(l, 2, out favorabilityValueText);
			fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityValueText = favorabilityValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC38 RID: 121912 RVA: 0x00979E00 File Offset: 0x00978000
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_favorabilityAddUpArrowGo(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityAddUpArrowGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC39 RID: 121913 RVA: 0x00979E58 File Offset: 0x00978058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_favorabilityAddUpArrowGo(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject favorabilityAddUpArrowGo;
			LuaObject.checkType<GameObject>(l, 2, out favorabilityAddUpArrowGo);
			fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityAddUpArrowGo = favorabilityAddUpArrowGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC3A RID: 121914 RVA: 0x00979EB4 File Offset: 0x009780B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_favorabilityAddValueText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityAddValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC3B RID: 121915 RVA: 0x00979F0C File Offset: 0x0097810C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_favorabilityAddValueText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Text favorabilityAddValueText;
			LuaObject.checkType<Text>(l, 2, out favorabilityAddValueText);
			fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityAddValueText = favorabilityAddValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC3C RID: 121916 RVA: 0x00979F68 File Offset: 0x00978168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_favorabilityHeroNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityHeroNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC3D RID: 121917 RVA: 0x00979FC0 File Offset: 0x009781C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_favorabilityHeroNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Text favorabilityHeroNameText;
			LuaObject.checkType<Text>(l, 2, out favorabilityHeroNameText);
			fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityHeroNameText = favorabilityHeroNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC3E RID: 121918 RVA: 0x0097A01C File Offset: 0x0097821C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_favorabilityLvText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC3F RID: 121919 RVA: 0x0097A074 File Offset: 0x00978274
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_favorabilityLvText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Text favorabilityLvText;
			LuaObject.checkType<Text>(l, 2, out favorabilityLvText);
			fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityLvText = favorabilityLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC40 RID: 121920 RVA: 0x0097A0D0 File Offset: 0x009782D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_favorabilityMaleSlider(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityMaleSlider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC41 RID: 121921 RVA: 0x0097A128 File Offset: 0x00978328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_favorabilityMaleSlider(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Slider favorabilityMaleSlider;
			LuaObject.checkType<Slider>(l, 2, out favorabilityMaleSlider);
			fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityMaleSlider = favorabilityMaleSlider;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC42 RID: 121922 RVA: 0x0097A184 File Offset: 0x00978384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_favorabilityFemaleSlider(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityFemaleSlider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC43 RID: 121923 RVA: 0x0097A1DC File Offset: 0x009783DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_favorabilityFemaleSlider(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Slider favorabilityFemaleSlider;
			LuaObject.checkType<Slider>(l, 2, out favorabilityFemaleSlider);
			fettersFavorabilityUIController.m_luaExportHelper.m_favorabilityFemaleSlider = favorabilityFemaleSlider;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC44 RID: 121924 RVA: 0x0097A238 File Offset: 0x00978438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelUpEffectGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_levelUpEffectGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC45 RID: 121925 RVA: 0x0097A290 File Offset: 0x00978490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelUpEffectGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject levelUpEffectGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out levelUpEffectGroupGameObject);
			fettersFavorabilityUIController.m_luaExportHelper.m_levelUpEffectGroupGameObject = levelUpEffectGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC46 RID: 121926 RVA: 0x0097A2EC File Offset: 0x009784EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_femaleQinMiDuGameObject(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_femaleQinMiDuGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC47 RID: 121927 RVA: 0x0097A344 File Offset: 0x00978544
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_femaleQinMiDuGameObject(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject femaleQinMiDuGameObject;
			LuaObject.checkType<GameObject>(l, 2, out femaleQinMiDuGameObject);
			fettersFavorabilityUIController.m_luaExportHelper.m_femaleQinMiDuGameObject = femaleQinMiDuGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC48 RID: 121928 RVA: 0x0097A3A0 File Offset: 0x009785A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_maleQinMiDuGameObject(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_maleQinMiDuGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC49 RID: 121929 RVA: 0x0097A3F8 File Offset: 0x009785F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_maleQinMiDuGameObject(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject maleQinMiDuGameObject;
			LuaObject.checkType<GameObject>(l, 2, out maleQinMiDuGameObject);
			fettersFavorabilityUIController.m_luaExportHelper.m_maleQinMiDuGameObject = maleQinMiDuGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC4A RID: 121930 RVA: 0x0097A454 File Offset: 0x00978654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGameObjectRoot(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_charGameObjectRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC4B RID: 121931 RVA: 0x0097A4AC File Offset: 0x009786AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGameObjectRoot(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject charGameObjectRoot;
			LuaObject.checkType<GameObject>(l, 2, out charGameObjectRoot);
			fettersFavorabilityUIController.m_luaExportHelper.m_charGameObjectRoot = charGameObjectRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC4C RID: 121932 RVA: 0x0097A508 File Offset: 0x00978708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGameObject(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_charGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC4D RID: 121933 RVA: 0x0097A560 File Offset: 0x00978760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGameObject(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject charGameObject;
			LuaObject.checkType<GameObject>(l, 2, out charGameObject);
			fettersFavorabilityUIController.m_luaExportHelper.m_charGameObject = charGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC4E RID: 121934 RVA: 0x0097A5BC File Offset: 0x009787BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wordGameObject(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_wordGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC4F RID: 121935 RVA: 0x0097A614 File Offset: 0x00978814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wordGameObject(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject wordGameObject;
			LuaObject.checkType<GameObject>(l, 2, out wordGameObject);
			fettersFavorabilityUIController.m_luaExportHelper.m_wordGameObject = wordGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC50 RID: 121936 RVA: 0x0097A670 File Offset: 0x00978870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charContinueButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_charContinueButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC51 RID: 121937 RVA: 0x0097A6C8 File Offset: 0x009788C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charContinueButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Button charContinueButton;
			LuaObject.checkType<Button>(l, 2, out charContinueButton);
			fettersFavorabilityUIController.m_luaExportHelper.m_charContinueButton = charContinueButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC52 RID: 121938 RVA: 0x0097A724 File Offset: 0x00978924
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_touchNumberStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_touchNumberStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC53 RID: 121939 RVA: 0x0097A77C File Offset: 0x0097897C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchNumberStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController touchNumberStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out touchNumberStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_touchNumberStateCtrl = touchNumberStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC54 RID: 121940 RVA: 0x0097A7D8 File Offset: 0x009789D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_touchCountStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_touchCountStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC55 RID: 121941 RVA: 0x0097A830 File Offset: 0x00978A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchCountStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController touchCountStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out touchCountStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_touchCountStateCtrl = touchCountStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC56 RID: 121942 RVA: 0x0097A88C File Offset: 0x00978A8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_touchTimeText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_touchTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC57 RID: 121943 RVA: 0x0097A8E4 File Offset: 0x00978AE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_touchTimeText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Text touchTimeText;
			LuaObject.checkType<Text>(l, 2, out touchTimeText);
			fettersFavorabilityUIController.m_luaExportHelper.m_touchTimeText = touchTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC58 RID: 121944 RVA: 0x0097A940 File Offset: 0x00978B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressEffectSlider(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_progressEffectSlider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC59 RID: 121945 RVA: 0x0097A998 File Offset: 0x00978B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressEffectSlider(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Slider progressEffectSlider;
			LuaObject.checkType<Slider>(l, 2, out progressEffectSlider);
			fettersFavorabilityUIController.m_luaExportHelper.m_progressEffectSlider = progressEffectSlider;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC5A RID: 121946 RVA: 0x0097A9F4 File Offset: 0x00978BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressMaleSlider(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_progressMaleSlider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC5B RID: 121947 RVA: 0x0097AA4C File Offset: 0x00978C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressMaleSlider(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Slider progressMaleSlider;
			LuaObject.checkType<Slider>(l, 2, out progressMaleSlider);
			fettersFavorabilityUIController.m_luaExportHelper.m_progressMaleSlider = progressMaleSlider;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC5C RID: 121948 RVA: 0x0097AAA8 File Offset: 0x00978CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressFemaleSlider(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_progressFemaleSlider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC5D RID: 121949 RVA: 0x0097AB00 File Offset: 0x00978D00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_progressFemaleSlider(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Slider progressFemaleSlider;
			LuaObject.checkType<Slider>(l, 2, out progressFemaleSlider);
			fettersFavorabilityUIController.m_luaExportHelper.m_progressFemaleSlider = progressFemaleSlider;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC5E RID: 121950 RVA: 0x0097AB5C File Offset: 0x00978D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressEffectGroup(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_progressEffectGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC5F RID: 121951 RVA: 0x0097ABB4 File Offset: 0x00978DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressEffectGroup(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject progressEffectGroup;
			LuaObject.checkType<GameObject>(l, 2, out progressEffectGroup);
			fettersFavorabilityUIController.m_luaExportHelper.m_progressEffectGroup = progressEffectGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC60 RID: 121952 RVA: 0x0097AC10 File Offset: 0x00978E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_maleBGImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_maleBGImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC61 RID: 121953 RVA: 0x0097AC68 File Offset: 0x00978E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_maleBGImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject maleBGImage;
			LuaObject.checkType<GameObject>(l, 2, out maleBGImage);
			fettersFavorabilityUIController.m_luaExportHelper.m_maleBGImage = maleBGImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC62 RID: 121954 RVA: 0x0097ACC4 File Offset: 0x00978EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_femaleBGImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_femaleBGImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC63 RID: 121955 RVA: 0x0097AD1C File Offset: 0x00978F1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_femaleBGImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject femaleBGImage;
			LuaObject.checkType<GameObject>(l, 2, out femaleBGImage);
			fettersFavorabilityUIController.m_luaExportHelper.m_femaleBGImage = femaleBGImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC64 RID: 121956 RVA: 0x0097AD78 File Offset: 0x00978F78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_levelUpStarEffectGroup(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_levelUpStarEffectGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC65 RID: 121957 RVA: 0x0097ADD0 File Offset: 0x00978FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelUpStarEffectGroup(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject levelUpStarEffectGroup;
			LuaObject.checkType<GameObject>(l, 2, out levelUpStarEffectGroup);
			fettersFavorabilityUIController.m_luaExportHelper.m_levelUpStarEffectGroup = levelUpStarEffectGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC66 RID: 121958 RVA: 0x0097AE2C File Offset: 0x0097902C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_informationButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_informationButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC67 RID: 121959 RVA: 0x0097AE84 File Offset: 0x00979084
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_informationButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Button informationButton;
			LuaObject.checkType<Button>(l, 2, out informationButton);
			fettersFavorabilityUIController.m_luaExportHelper.m_informationButton = informationButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC68 RID: 121960 RVA: 0x0097AEE0 File Offset: 0x009790E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_informationButtonNewImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_informationButtonNewImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC69 RID: 121961 RVA: 0x0097AF38 File Offset: 0x00979138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_informationButtonNewImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject informationButtonNewImage;
			LuaObject.checkType<GameObject>(l, 2, out informationButtonNewImage);
			fettersFavorabilityUIController.m_luaExportHelper.m_informationButtonNewImage = informationButtonNewImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC6A RID: 121962 RVA: 0x0097AF94 File Offset: 0x00979194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fettersButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_fettersButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC6B RID: 121963 RVA: 0x0097AFEC File Offset: 0x009791EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fettersButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Button fettersButton;
			LuaObject.checkType<Button>(l, 2, out fettersButton);
			fettersFavorabilityUIController.m_luaExportHelper.m_fettersButton = fettersButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC6C RID: 121964 RVA: 0x0097B048 File Offset: 0x00979248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fettersButtonRedMark(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_fettersButtonRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC6D RID: 121965 RVA: 0x0097B0A0 File Offset: 0x009792A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_fettersButtonRedMark(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject fettersButtonRedMark;
			LuaObject.checkType<GameObject>(l, 2, out fettersButtonRedMark);
			fettersFavorabilityUIController.m_luaExportHelper.m_fettersButtonRedMark = fettersButtonRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC6E RID: 121966 RVA: 0x0097B0FC File Offset: 0x009792FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fettersButtonPercentText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_fettersButtonPercentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC6F RID: 121967 RVA: 0x0097B154 File Offset: 0x00979354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fettersButtonPercentText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Text fettersButtonPercentText;
			LuaObject.checkType<Text>(l, 2, out fettersButtonPercentText);
			fettersFavorabilityUIController.m_luaExportHelper.m_fettersButtonPercentText = fettersButtonPercentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC70 RID: 121968 RVA: 0x0097B1B0 File Offset: 0x009793B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_memoryButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC71 RID: 121969 RVA: 0x0097B208 File Offset: 0x00979408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Button memoryButton;
			LuaObject.checkType<Button>(l, 2, out memoryButton);
			fettersFavorabilityUIController.m_luaExportHelper.m_memoryButton = memoryButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC72 RID: 121970 RVA: 0x0097B264 File Offset: 0x00979464
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_memoryButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_memoryButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC73 RID: 121971 RVA: 0x0097B2BC File Offset: 0x009794BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_memoryButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController memoryButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out memoryButtonStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_memoryButtonStateCtrl = memoryButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC74 RID: 121972 RVA: 0x0097B318 File Offset: 0x00979518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryButtonNewImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_memoryButtonNewImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC75 RID: 121973 RVA: 0x0097B370 File Offset: 0x00979570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryButtonNewImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject memoryButtonNewImage;
			LuaObject.checkType<GameObject>(l, 2, out memoryButtonNewImage);
			fettersFavorabilityUIController.m_luaExportHelper.m_memoryButtonNewImage = memoryButtonNewImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC76 RID: 121974 RVA: 0x0097B3CC File Offset: 0x009795CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryButtonPercentText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_memoryButtonPercentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC77 RID: 121975 RVA: 0x0097B424 File Offset: 0x00979624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryButtonPercentText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Text memoryButtonPercentText;
			LuaObject.checkType<Text>(l, 2, out memoryButtonPercentText);
			fettersFavorabilityUIController.m_luaExportHelper.m_memoryButtonPercentText = memoryButtonPercentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC78 RID: 121976 RVA: 0x0097B480 File Offset: 0x00979680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC79 RID: 121977 RVA: 0x0097B4D8 File Offset: 0x009796D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Button presentButton;
			LuaObject.checkType<Button>(l, 2, out presentButton);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentButton = presentButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC7A RID: 121978 RVA: 0x0097B534 File Offset: 0x00979734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_touchImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_touchImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC7B RID: 121979 RVA: 0x0097B58C File Offset: 0x0097978C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject touchImage;
			LuaObject.checkType<GameObject>(l, 2, out touchImage);
			fettersFavorabilityUIController.m_luaExportHelper.m_touchImage = touchImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC7C RID: 121980 RVA: 0x0097B5E8 File Offset: 0x009797E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockEventStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_unlockEventStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC7D RID: 121981 RVA: 0x0097B640 File Offset: 0x00979840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockEventStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController unlockEventStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out unlockEventStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_unlockEventStateCtrl = unlockEventStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC7E RID: 121982 RVA: 0x0097B69C File Offset: 0x0097989C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_unlockEventTitleText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_unlockEventTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC7F RID: 121983 RVA: 0x0097B6F4 File Offset: 0x009798F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockEventTitleText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Text unlockEventTitleText;
			LuaObject.checkType<Text>(l, 2, out unlockEventTitleText);
			fettersFavorabilityUIController.m_luaExportHelper.m_unlockEventTitleText = unlockEventTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC80 RID: 121984 RVA: 0x0097B750 File Offset: 0x00979950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockEventContentText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_unlockEventContentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC81 RID: 121985 RVA: 0x0097B7A8 File Offset: 0x009799A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockEventContentText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Text unlockEventContentText;
			LuaObject.checkType<Text>(l, 2, out unlockEventContentText);
			fettersFavorabilityUIController.m_luaExportHelper.m_unlockEventContentText = unlockEventContentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC82 RID: 121986 RVA: 0x0097B804 File Offset: 0x00979A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockEventBackButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_unlockEventBackButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC83 RID: 121987 RVA: 0x0097B85C File Offset: 0x00979A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockEventBackButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Button unlockEventBackButton;
			LuaObject.checkType<Button>(l, 2, out unlockEventBackButton);
			fettersFavorabilityUIController.m_luaExportHelper.m_unlockEventBackButton = unlockEventBackButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC84 RID: 121988 RVA: 0x0097B8B8 File Offset: 0x00979AB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_presentPanel(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC85 RID: 121989 RVA: 0x0097B910 File Offset: 0x00979B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentPanel(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject presentPanel;
			LuaObject.checkType<GameObject>(l, 2, out presentPanel);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentPanel = presentPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC86 RID: 121990 RVA: 0x0097B96C File Offset: 0x00979B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentContentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentContentStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC87 RID: 121991 RVA: 0x0097B9C4 File Offset: 0x00979BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentContentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController presentContentStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out presentContentStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentContentStateCtrl = presentContentStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC88 RID: 121992 RVA: 0x0097BA20 File Offset: 0x00979C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentScrollRect(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC89 RID: 121993 RVA: 0x0097BA78 File Offset: 0x00979C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentScrollRect(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			ScrollRect presentScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out presentScrollRect);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentScrollRect = presentScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC8A RID: 121994 RVA: 0x0097BAD4 File Offset: 0x00979CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentContent(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC8B RID: 121995 RVA: 0x0097BB2C File Offset: 0x00979D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentContent(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject presentContent;
			LuaObject.checkType<GameObject>(l, 2, out presentContent);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentContent = presentContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC8C RID: 121996 RVA: 0x0097BB88 File Offset: 0x00979D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentItemCountShowUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentItemCountShowUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC8D RID: 121997 RVA: 0x0097BBE0 File Offset: 0x00979DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentItemCountShowUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController presentItemCountShowUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out presentItemCountShowUIStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentItemCountShowUIStateCtrl = presentItemCountShowUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC8E RID: 121998 RVA: 0x0097BC3C File Offset: 0x00979E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentContinuousTouchUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentContinuousTouchUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC8F RID: 121999 RVA: 0x0097BC94 File Offset: 0x00979E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentContinuousTouchUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController presentContinuousTouchUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out presentContinuousTouchUIStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentContinuousTouchUIStateCtrl = presentContinuousTouchUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC90 RID: 122000 RVA: 0x0097BCF0 File Offset: 0x00979EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentItemCountText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentItemCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC91 RID: 122001 RVA: 0x0097BD48 File Offset: 0x00979F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentItemCountText(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Text presentItemCountText;
			LuaObject.checkType<Text>(l, 2, out presentItemCountText);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentItemCountText = presentItemCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC92 RID: 122002 RVA: 0x0097BDA4 File Offset: 0x00979FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentItemIconImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentItemIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC93 RID: 122003 RVA: 0x0097BDFC File Offset: 0x00979FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentItemIconImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Image presentItemIconImage;
			LuaObject.checkType<Image>(l, 2, out presentItemIconImage);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentItemIconImage = presentItemIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC94 RID: 122004 RVA: 0x0097BE58 File Offset: 0x0097A058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentItemIconEffectImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentItemIconEffectImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC95 RID: 122005 RVA: 0x0097BEB0 File Offset: 0x0097A0B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentItemIconEffectImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Image presentItemIconEffectImage;
			LuaObject.checkType<Image>(l, 2, out presentItemIconEffectImage);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentItemIconEffectImage = presentItemIconEffectImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC96 RID: 122006 RVA: 0x0097BF0C File Offset: 0x0097A10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentExpEffect(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentExpEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC97 RID: 122007 RVA: 0x0097BF64 File Offset: 0x0097A164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentExpEffect(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController presentExpEffect;
			LuaObject.checkType<CommonUIStateController>(l, 2, out presentExpEffect);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentExpEffect = presentExpEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC98 RID: 122008 RVA: 0x0097BFC0 File Offset: 0x0097A1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentSendButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentSendButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC99 RID: 122009 RVA: 0x0097C018 File Offset: 0x0097A218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentSendButton(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Button presentSendButton;
			LuaObject.checkType<Button>(l, 2, out presentSendButton);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentSendButton = presentSendButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC9A RID: 122010 RVA: 0x0097C074 File Offset: 0x0097A274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentSendButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentSendButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC9B RID: 122011 RVA: 0x0097C0CC File Offset: 0x0097A2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentSendButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			CommonUIStateController presentSendButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out presentSendButtonStateCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentSendButtonStateCtrl = presentSendButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC9C RID: 122012 RVA: 0x0097C128 File Offset: 0x0097A328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentSendButtonMaskImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentSendButtonMaskImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC9D RID: 122013 RVA: 0x0097C180 File Offset: 0x0097A380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentSendButtonMaskImage(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject presentSendButtonMaskImage;
			LuaObject.checkType<GameObject>(l, 2, out presentSendButtonMaskImage);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentSendButtonMaskImage = presentSendButtonMaskImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC9E RID: 122014 RVA: 0x0097C1DC File Offset: 0x0097A3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_presentItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DC9F RID: 122015 RVA: 0x0097C234 File Offset: 0x0097A434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			GameObject presentItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out presentItemPrefab);
			fettersFavorabilityUIController.m_luaExportHelper.m_presentItemPrefab = presentItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCA0 RID: 122016 RVA: 0x0097C290 File Offset: 0x0097A490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isMale(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_isMale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCA1 RID: 122017 RVA: 0x0097C2E8 File Offset: 0x0097A4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isMale(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			bool isMale;
			LuaObject.checkType(l, 2, out isMale);
			fettersFavorabilityUIController.m_luaExportHelper.m_isMale = isMale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCA2 RID: 122018 RVA: 0x0097C344 File Offset: 0x0097A544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isInGiftMode(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_isInGiftMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCA3 RID: 122019 RVA: 0x0097C39C File Offset: 0x0097A59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isInGiftMode(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			bool isInGiftMode;
			LuaObject.checkType(l, 2, out isInGiftMode);
			fettersFavorabilityUIController.m_luaExportHelper.m_isInGiftMode = isInGiftMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCA4 RID: 122020 RVA: 0x0097C3F8 File Offset: 0x0097A5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCA5 RID: 122021 RVA: 0x0097C450 File Offset: 0x0097A650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersFavorabilityUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCA6 RID: 122022 RVA: 0x0097C4AC File Offset: 0x0097A6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_heroCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCA7 RID: 122023 RVA: 0x0097C504 File Offset: 0x0097A704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			HeroCharUIController heroCharUIController;
			LuaObject.checkType<HeroCharUIController>(l, 2, out heroCharUIController);
			fettersFavorabilityUIController.m_luaExportHelper.m_heroCharUIController = heroCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCA8 RID: 122024 RVA: 0x0097C560 File Offset: 0x0097A760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroFavoribilityLevelUpRewards(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_heroFavoribilityLevelUpRewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCA9 RID: 122025 RVA: 0x0097C5B8 File Offset: 0x0097A7B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroFavoribilityLevelUpRewards(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			List<Goods> heroFavoribilityLevelUpRewards;
			LuaObject.checkType<List<Goods>>(l, 2, out heroFavoribilityLevelUpRewards);
			fettersFavorabilityUIController.m_luaExportHelper.m_heroFavoribilityLevelUpRewards = heroFavoribilityLevelUpRewards;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCAA RID: 122026 RVA: 0x0097C614 File Offset: 0x0097A814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroFavoribilityOldLevel(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_heroFavoribilityOldLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCAB RID: 122027 RVA: 0x0097C66C File Offset: 0x0097A86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroFavoribilityOldLevel(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			int heroFavoribilityOldLevel;
			LuaObject.checkType(l, 2, out heroFavoribilityOldLevel);
			fettersFavorabilityUIController.m_luaExportHelper.m_heroFavoribilityOldLevel = heroFavoribilityOldLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCAC RID: 122028 RVA: 0x0097C6C8 File Offset: 0x0097A8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curUnlockEventIndex(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_curUnlockEventIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCAD RID: 122029 RVA: 0x0097C720 File Offset: 0x0097A920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curUnlockEventIndex(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			int curUnlockEventIndex;
			LuaObject.checkType(l, 2, out curUnlockEventIndex);
			fettersFavorabilityUIController.m_luaExportHelper.m_curUnlockEventIndex = curUnlockEventIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCAE RID: 122030 RVA: 0x0097C77C File Offset: 0x0097A97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockEventTitleList(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_unlockEventTitleList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCAF RID: 122031 RVA: 0x0097C7D4 File Offset: 0x0097A9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockEventTitleList(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			List<string> unlockEventTitleList;
			LuaObject.checkType<List<string>>(l, 2, out unlockEventTitleList);
			fettersFavorabilityUIController.m_luaExportHelper.m_unlockEventTitleList = unlockEventTitleList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCB0 RID: 122032 RVA: 0x0097C830 File Offset: 0x0097AA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockEventContentList(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_unlockEventContentList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCB1 RID: 122033 RVA: 0x0097C888 File Offset: 0x0097AA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockEventContentList(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			List<string> unlockEventContentList;
			LuaObject.checkType<List<string>>(l, 2, out unlockEventContentList);
			fettersFavorabilityUIController.m_luaExportHelper.m_unlockEventContentList = unlockEventContentList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCB2 RID: 122034 RVA: 0x0097C8E4 File Offset: 0x0097AAE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempAddExp(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_tempAddExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCB3 RID: 122035 RVA: 0x0097C93C File Offset: 0x0097AB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempAddExp(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			int tempAddExp;
			LuaObject.checkType(l, 2, out tempAddExp);
			fettersFavorabilityUIController.m_luaExportHelper.m_tempAddExp = tempAddExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCB4 RID: 122036 RVA: 0x0097C998 File Offset: 0x0097AB98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempFavorabilityExp(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_tempFavorabilityExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCB5 RID: 122037 RVA: 0x0097C9F0 File Offset: 0x0097ABF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempFavorabilityExp(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			int tempFavorabilityExp;
			LuaObject.checkType(l, 2, out tempFavorabilityExp);
			fettersFavorabilityUIController.m_luaExportHelper.m_tempFavorabilityExp = tempFavorabilityExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCB6 RID: 122038 RVA: 0x0097CA4C File Offset: 0x0097AC4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_totalUseExpItemCount(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_totalUseExpItemCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCB7 RID: 122039 RVA: 0x0097CAA4 File Offset: 0x0097ACA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_totalUseExpItemCount(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			int totalUseExpItemCount;
			LuaObject.checkType(l, 2, out totalUseExpItemCount);
			fettersFavorabilityUIController.m_luaExportHelper.m_totalUseExpItemCount = totalUseExpItemCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCB8 RID: 122040 RVA: 0x0097CB00 File Offset: 0x0097AD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempFavorabilityLevel(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_tempFavorabilityLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCB9 RID: 122041 RVA: 0x0097CB58 File Offset: 0x0097AD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempFavorabilityLevel(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			int tempFavorabilityLevel;
			LuaObject.checkType(l, 2, out tempFavorabilityLevel);
			fettersFavorabilityUIController.m_luaExportHelper.m_tempFavorabilityLevel = tempFavorabilityLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCBA RID: 122042 RVA: 0x0097CBB4 File Offset: 0x0097ADB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curGiftBagItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_curGiftBagItemCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCBB RID: 122043 RVA: 0x0097CC0C File Offset: 0x0097AE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curGiftBagItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			FettersGiftItemUIController curGiftBagItemCtrl;
			LuaObject.checkType<FettersGiftItemUIController>(l, 2, out curGiftBagItemCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_curGiftBagItemCtrl = curGiftBagItemCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCBC RID: 122044 RVA: 0x0097CC68 File Offset: 0x0097AE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sendButtonDownGiftBagItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_sendButtonDownGiftBagItemCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCBD RID: 122045 RVA: 0x0097CCC0 File Offset: 0x0097AEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sendButtonDownGiftBagItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			FettersGiftItemUIController sendButtonDownGiftBagItemCtrl;
			LuaObject.checkType<FettersGiftItemUIController>(l, 2, out sendButtonDownGiftBagItemCtrl);
			fettersFavorabilityUIController.m_luaExportHelper.m_sendButtonDownGiftBagItemCtrl = sendButtonDownGiftBagItemCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCBE RID: 122046 RVA: 0x0097CD1C File Offset: 0x0097AF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_giftBagItemCache(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_giftBagItemCache);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCBF RID: 122047 RVA: 0x0097CD74 File Offset: 0x0097AF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_giftBagItemCache(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			List<BagItemBase> giftBagItemCache;
			LuaObject.checkType<List<BagItemBase>>(l, 2, out giftBagItemCache);
			fettersFavorabilityUIController.m_luaExportHelper.m_giftBagItemCache = giftBagItemCache;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCC0 RID: 122048 RVA: 0x0097CDD0 File Offset: 0x0097AFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCC1 RID: 122049 RVA: 0x0097CE28 File Offset: 0x0097B028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			fettersFavorabilityUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCC2 RID: 122050 RVA: 0x0097CE84 File Offset: 0x0097B084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersFavorabilityUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCC3 RID: 122051 RVA: 0x0097CEDC File Offset: 0x0097B0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FettersFavorabilityUIController fettersFavorabilityUIController = (FettersFavorabilityUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			fettersFavorabilityUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCC4 RID: 122052 RVA: 0x0097CF38 File Offset: 0x0097B138
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FettersFavorabilityUIController");
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.UpdateViewInFettersFavorability);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OpenFettersFavorability);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.SetTouchRecoverTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnHeroInteractSucceed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.UpdateViewInFettersGift);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OpenFettersGift);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.PlayHeroPerformance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.GoToInformationPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.SetFavorabilityValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.SetTouchCountState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.DragTrigger_EventOnSliderFull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.DragTrigger_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.DragTrigger_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.DragTrigger_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.DragTrigger_EventOnSliderEmpty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.SetTouchStateCtrlOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.SetCharGoTweenPos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.AfterHeroInteractionResultEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.PlayFavorbilityLevelUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.Co_PlayHeroInteractEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnCharContinueButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.ShowUnlockEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.GetUnlockEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnUnlockEventBackButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.SetPresentContent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.GiftBagItemComparer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnSendButtonClickDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.SendUseGiftEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.WaitTimeThenDoEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnUseGiftItemSucceed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnGiftItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.LocalAddExpTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.Co_SetFavorabilityValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.SetItemCountPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.Co_OnAnimationFinishedEnableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnInformationButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnFettersButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnMemoryButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.OnGiftButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.ResetGiftScrollViewPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.InactiveWordGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callDele_EventOnSliderFull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__clearDele_EventOnSliderFull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callDele_EventOnGiftButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__clearDele_EventOnGiftButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callDele_EventOnMemoryButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__clearDele_EventOnMemoryButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callDele_EventOnFettersButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__clearDele_EventOnFettersButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callDele_EventOnInformationButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__clearDele_EventOnInformationButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callDele_EventOnUseGift);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__clearDele_EventOnUseGift);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__callDele_EventOnGotoBagFullPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.__clearDele_EventOnGotoBagFullPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4B);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4C, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4D, true);
		string name3 = "EventOnSliderFull";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_EventOnSliderFull);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4E, true);
		string name4 = "EventOnGiftButtonClick";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_EventOnGiftButtonClick);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache4F, true);
		string name5 = "EventOnMemoryButtonClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_EventOnMemoryButtonClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache50, true);
		string name6 = "EventOnFettersButtonClick";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_EventOnFettersButtonClick);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache51, true);
		string name7 = "EventOnInformationButtonClick";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_EventOnInformationButtonClick);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache52, true);
		string name8 = "EventOnUseGift";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_EventOnUseGift);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache53, true);
		string name9 = "EventOnGotoBagFullPanel";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_EventOnGotoBagFullPanel);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache54, true);
		string name10 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_marginTransform);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache56, true);
		string name11 = "m_commonUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_commonUIStateCtrl);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_commonUIStateCtrl);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache58, true);
		string name12 = "m_sexStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_sexStateCtrl);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_sexStateCtrl);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5A, true);
		string name13 = "m_touchInOutStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_touchInOutStateCtrl);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_touchInOutStateCtrl);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5C, true);
		string name14 = "m_levelUpStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_levelUpStateCtrl);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_levelUpStateCtrl);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5E, true);
		string name15 = "m_touchStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_touchStateCtrl);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_touchStateCtrl);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache60, true);
		string name16 = "m_infoStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_infoStateCtrl);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_infoStateCtrl);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache62, true);
		string name17 = "m_presentStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentStateCtrl);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentStateCtrl);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache64, true);
		string name18 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_returnButton);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache66, true);
		string name19 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_helpButton);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache68, true);
		string name20 = "m_favorabilityValueTextStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_favorabilityValueTextStateCtrl);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_favorabilityValueTextStateCtrl);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6A, true);
		string name21 = "m_favorabilityValueText";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_favorabilityValueText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_favorabilityValueText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6C, true);
		string name22 = "m_favorabilityAddUpArrowGo";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_favorabilityAddUpArrowGo);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_favorabilityAddUpArrowGo);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6E, true);
		string name23 = "m_favorabilityAddValueText";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_favorabilityAddValueText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_favorabilityAddValueText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache70, true);
		string name24 = "m_favorabilityHeroNameText";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_favorabilityHeroNameText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_favorabilityHeroNameText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache72, true);
		string name25 = "m_favorabilityLvText";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_favorabilityLvText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_favorabilityLvText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache74, true);
		string name26 = "m_favorabilityMaleSlider";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_favorabilityMaleSlider);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_favorabilityMaleSlider);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache76, true);
		string name27 = "m_favorabilityFemaleSlider";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_favorabilityFemaleSlider);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_favorabilityFemaleSlider);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache78, true);
		string name28 = "m_levelUpEffectGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_levelUpEffectGroupGameObject);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_levelUpEffectGroupGameObject);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7A, true);
		string name29 = "m_femaleQinMiDuGameObject";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_femaleQinMiDuGameObject);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_femaleQinMiDuGameObject);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7C, true);
		string name30 = "m_maleQinMiDuGameObject";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_maleQinMiDuGameObject);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_maleQinMiDuGameObject);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7E, true);
		string name31 = "m_charGameObjectRoot";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_charGameObjectRoot);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_charGameObjectRoot);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache80, true);
		string name32 = "m_charGameObject";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_charGameObject);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_charGameObject);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache82, true);
		string name33 = "m_wordGameObject";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_wordGameObject);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_wordGameObject);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache84, true);
		string name34 = "m_charContinueButton";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_charContinueButton);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_charContinueButton);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache86, true);
		string name35 = "m_touchNumberStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_touchNumberStateCtrl);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_touchNumberStateCtrl);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache88, true);
		string name36 = "m_touchCountStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_touchCountStateCtrl);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_touchCountStateCtrl);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8A, true);
		string name37 = "m_touchTimeText";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_touchTimeText);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_touchTimeText);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8C, true);
		string name38 = "m_progressEffectSlider";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_progressEffectSlider);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_progressEffectSlider);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8E, true);
		string name39 = "m_progressMaleSlider";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_progressMaleSlider);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_progressMaleSlider);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache90, true);
		string name40 = "m_progressFemaleSlider";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_progressFemaleSlider);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_progressFemaleSlider);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache92, true);
		string name41 = "m_progressEffectGroup";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_progressEffectGroup);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_progressEffectGroup);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache94, true);
		string name42 = "m_maleBGImage";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_maleBGImage);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_maleBGImage);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache96, true);
		string name43 = "m_femaleBGImage";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_femaleBGImage);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_femaleBGImage);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache98, true);
		string name44 = "m_levelUpStarEffectGroup";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_levelUpStarEffectGroup);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_levelUpStarEffectGroup);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9A, true);
		string name45 = "m_informationButton";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_informationButton);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_informationButton);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9C, true);
		string name46 = "m_informationButtonNewImage";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_informationButtonNewImage);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_informationButtonNewImage);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9E, true);
		string name47 = "m_fettersButton";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_fettersButton);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cache9F;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_fettersButton);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA0, true);
		string name48 = "m_fettersButtonRedMark";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_fettersButtonRedMark);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA1;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_fettersButtonRedMark);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA2, true);
		string name49 = "m_fettersButtonPercentText";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_fettersButtonPercentText);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA3;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_fettersButtonPercentText);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA4, true);
		string name50 = "m_memoryButton";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_memoryButton);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA5;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_memoryButton);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA6, true);
		string name51 = "m_memoryButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_memoryButtonStateCtrl);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA7;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_memoryButtonStateCtrl);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA8, true);
		string name52 = "m_memoryButtonNewImage";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_memoryButtonNewImage);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheA9;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_memoryButtonNewImage);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAA, true);
		string name53 = "m_memoryButtonPercentText";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_memoryButtonPercentText);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAB;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_memoryButtonPercentText);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAC, true);
		string name54 = "m_presentButton";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentButton);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAD;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentButton);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAE, true);
		string name55 = "m_touchImage";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_touchImage);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheAF;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_touchImage);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB0, true);
		string name56 = "m_unlockEventStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_unlockEventStateCtrl);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB1;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_unlockEventStateCtrl);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB2, true);
		string name57 = "m_unlockEventTitleText";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_unlockEventTitleText);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB3;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_unlockEventTitleText);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB4, true);
		string name58 = "m_unlockEventContentText";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_unlockEventContentText);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB5;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_unlockEventContentText);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB6, true);
		string name59 = "m_unlockEventBackButton";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_unlockEventBackButton);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB7;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_unlockEventBackButton);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB8, true);
		string name60 = "m_presentPanel";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentPanel);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheB9;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentPanel);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBA, true);
		string name61 = "m_presentContentStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentContentStateCtrl);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBB;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentContentStateCtrl);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBC, true);
		string name62 = "m_presentScrollRect";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentScrollRect);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBD;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentScrollRect);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBE, true);
		string name63 = "m_presentContent";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentContent);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheBF;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentContent);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC0, true);
		string name64 = "m_presentItemCountShowUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentItemCountShowUIStateCtrl);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC1;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentItemCountShowUIStateCtrl);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC2, true);
		string name65 = "m_presentContinuousTouchUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentContinuousTouchUIStateCtrl);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC3;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentContinuousTouchUIStateCtrl);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC4, true);
		string name66 = "m_presentItemCountText";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentItemCountText);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC5;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentItemCountText);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC6, true);
		string name67 = "m_presentItemIconImage";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentItemIconImage);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC7;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentItemIconImage);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC8, true);
		string name68 = "m_presentItemIconEffectImage";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentItemIconEffectImage);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheC9;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentItemIconEffectImage);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCA, true);
		string name69 = "m_presentExpEffect";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentExpEffect);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCB;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentExpEffect);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCC, true);
		string name70 = "m_presentSendButton";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentSendButton);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCD;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentSendButton);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCE, true);
		string name71 = "m_presentSendButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentSendButtonStateCtrl);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheCF;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentSendButtonStateCtrl);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD0, true);
		string name72 = "m_presentSendButtonMaskImage";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentSendButtonMaskImage);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD1;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentSendButtonMaskImage);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD2, true);
		string name73 = "m_presentItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_presentItemPrefab);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD3;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_presentItemPrefab);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD4, true);
		string name74 = "m_isMale";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_isMale);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD5;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_isMale);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD6, true);
		string name75 = "m_isInGiftMode";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_isInGiftMode);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD7;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_isInGiftMode);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD8, true);
		string name76 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_hero);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheD9;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_hero);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDA, true);
		string name77 = "m_heroCharUIController";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_heroCharUIController);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDB;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_heroCharUIController);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDC, true);
		string name78 = "m_heroFavoribilityLevelUpRewards";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_heroFavoribilityLevelUpRewards);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDD;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_heroFavoribilityLevelUpRewards);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDE, true);
		string name79 = "m_heroFavoribilityOldLevel";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_heroFavoribilityOldLevel);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheDF;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_heroFavoribilityOldLevel);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE0, true);
		string name80 = "m_curUnlockEventIndex";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_curUnlockEventIndex);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE1;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_curUnlockEventIndex);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE2, true);
		string name81 = "m_unlockEventTitleList";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_unlockEventTitleList);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE3;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_unlockEventTitleList);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE4, true);
		string name82 = "m_unlockEventContentList";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_unlockEventContentList);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE5;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_unlockEventContentList);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE6, true);
		string name83 = "m_tempAddExp";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_tempAddExp);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE7;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_tempAddExp);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE8, true);
		string name84 = "m_tempFavorabilityExp";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_tempFavorabilityExp);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheE9;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_tempFavorabilityExp);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEA, true);
		string name85 = "m_totalUseExpItemCount";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_totalUseExpItemCount);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEB;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_totalUseExpItemCount);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEC, true);
		string name86 = "m_tempFavorabilityLevel";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_tempFavorabilityLevel);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheED;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_tempFavorabilityLevel);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEE, true);
		string name87 = "m_curGiftBagItemCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_curGiftBagItemCtrl);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheEF;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_curGiftBagItemCtrl);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF0, true);
		string name88 = "m_sendButtonDownGiftBagItemCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_sendButtonDownGiftBagItemCtrl);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF1;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_sendButtonDownGiftBagItemCtrl);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF2, true);
		string name89 = "m_giftBagItemCache";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_giftBagItemCache);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF3;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_giftBagItemCache);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF4, true);
		string name90 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_playerContext);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF5;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF6, true);
		string name91 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.get_m_configDataLoader);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF7;
		if (Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.<>f__mg$cacheF8, true);
		LuaObject.createTypeMetatable(l, null, typeof(FettersFavorabilityUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013D39 RID: 81209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013D3A RID: 81210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013D3B RID: 81211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013D3C RID: 81212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013D3D RID: 81213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013D3E RID: 81214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013D3F RID: 81215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013D40 RID: 81216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013D41 RID: 81217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013D42 RID: 81218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013D43 RID: 81219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013D44 RID: 81220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013D45 RID: 81221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013D46 RID: 81222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013D47 RID: 81223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013D48 RID: 81224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013D49 RID: 81225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013D4A RID: 81226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013D4B RID: 81227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013D4C RID: 81228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013D4D RID: 81229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013D4E RID: 81230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013D4F RID: 81231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013D50 RID: 81232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013D51 RID: 81233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013D52 RID: 81234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013D53 RID: 81235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013D54 RID: 81236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013D55 RID: 81237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013D56 RID: 81238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013D57 RID: 81239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013D58 RID: 81240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013D59 RID: 81241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013D5A RID: 81242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013D5B RID: 81243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013D5C RID: 81244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013D5D RID: 81245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013D5E RID: 81246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013D5F RID: 81247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013D60 RID: 81248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013D61 RID: 81249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013D62 RID: 81250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013D63 RID: 81251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013D64 RID: 81252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013D65 RID: 81253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013D66 RID: 81254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013D67 RID: 81255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013D68 RID: 81256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013D69 RID: 81257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013D6A RID: 81258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013D6B RID: 81259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013D6C RID: 81260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013D6D RID: 81261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013D6E RID: 81262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013D6F RID: 81263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013D70 RID: 81264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04013D71 RID: 81265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04013D72 RID: 81266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04013D73 RID: 81267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04013D74 RID: 81268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04013D75 RID: 81269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04013D76 RID: 81270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04013D77 RID: 81271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013D78 RID: 81272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04013D79 RID: 81273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04013D7A RID: 81274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013D7B RID: 81275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04013D7C RID: 81276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04013D7D RID: 81277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04013D7E RID: 81278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013D7F RID: 81279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04013D80 RID: 81280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04013D81 RID: 81281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04013D82 RID: 81282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04013D83 RID: 81283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04013D84 RID: 81284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04013D85 RID: 81285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04013D86 RID: 81286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04013D87 RID: 81287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04013D88 RID: 81288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04013D89 RID: 81289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04013D8A RID: 81290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04013D8B RID: 81291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04013D8C RID: 81292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04013D8D RID: 81293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04013D8E RID: 81294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04013D8F RID: 81295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04013D90 RID: 81296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04013D91 RID: 81297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04013D92 RID: 81298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04013D93 RID: 81299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04013D94 RID: 81300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04013D95 RID: 81301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04013D96 RID: 81302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04013D97 RID: 81303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04013D98 RID: 81304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04013D99 RID: 81305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04013D9A RID: 81306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04013D9B RID: 81307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04013D9C RID: 81308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04013D9D RID: 81309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04013D9E RID: 81310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04013D9F RID: 81311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04013DA0 RID: 81312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04013DA1 RID: 81313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04013DA2 RID: 81314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04013DA3 RID: 81315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04013DA4 RID: 81316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04013DA5 RID: 81317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04013DA6 RID: 81318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04013DA7 RID: 81319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04013DA8 RID: 81320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04013DA9 RID: 81321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04013DAA RID: 81322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04013DAB RID: 81323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04013DAC RID: 81324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04013DAD RID: 81325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04013DAE RID: 81326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04013DAF RID: 81327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04013DB0 RID: 81328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04013DB1 RID: 81329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04013DB2 RID: 81330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04013DB3 RID: 81331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04013DB4 RID: 81332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04013DB5 RID: 81333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04013DB6 RID: 81334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04013DB7 RID: 81335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04013DB8 RID: 81336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04013DB9 RID: 81337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04013DBA RID: 81338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04013DBB RID: 81339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04013DBC RID: 81340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04013DBD RID: 81341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04013DBE RID: 81342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04013DBF RID: 81343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04013DC0 RID: 81344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04013DC1 RID: 81345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04013DC2 RID: 81346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04013DC3 RID: 81347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04013DC4 RID: 81348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04013DC5 RID: 81349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04013DC6 RID: 81350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04013DC7 RID: 81351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04013DC8 RID: 81352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04013DC9 RID: 81353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04013DCA RID: 81354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04013DCB RID: 81355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04013DCC RID: 81356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04013DCD RID: 81357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04013DCE RID: 81358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04013DCF RID: 81359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04013DD0 RID: 81360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04013DD1 RID: 81361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04013DD2 RID: 81362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04013DD3 RID: 81363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04013DD4 RID: 81364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04013DD5 RID: 81365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04013DD6 RID: 81366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04013DD7 RID: 81367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04013DD8 RID: 81368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04013DD9 RID: 81369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04013DDA RID: 81370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04013DDB RID: 81371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04013DDC RID: 81372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04013DDD RID: 81373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04013DDE RID: 81374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04013DDF RID: 81375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04013DE0 RID: 81376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04013DE1 RID: 81377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04013DE2 RID: 81378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04013DE3 RID: 81379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04013DE4 RID: 81380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04013DE5 RID: 81381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04013DE6 RID: 81382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04013DE7 RID: 81383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04013DE8 RID: 81384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04013DE9 RID: 81385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04013DEA RID: 81386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04013DEB RID: 81387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04013DEC RID: 81388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04013DED RID: 81389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04013DEE RID: 81390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04013DEF RID: 81391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04013DF0 RID: 81392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x04013DF1 RID: 81393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x04013DF2 RID: 81394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x04013DF3 RID: 81395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x04013DF4 RID: 81396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x04013DF5 RID: 81397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x04013DF6 RID: 81398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x04013DF7 RID: 81399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x04013DF8 RID: 81400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x04013DF9 RID: 81401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04013DFA RID: 81402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04013DFB RID: 81403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04013DFC RID: 81404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04013DFD RID: 81405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x04013DFE RID: 81406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x04013DFF RID: 81407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x04013E00 RID: 81408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x04013E01 RID: 81409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x04013E02 RID: 81410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04013E03 RID: 81411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x04013E04 RID: 81412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x04013E05 RID: 81413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x04013E06 RID: 81414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x04013E07 RID: 81415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x04013E08 RID: 81416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x04013E09 RID: 81417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04013E0A RID: 81418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04013E0B RID: 81419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04013E0C RID: 81420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x04013E0D RID: 81421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x04013E0E RID: 81422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04013E0F RID: 81423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x04013E10 RID: 81424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x04013E11 RID: 81425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04013E12 RID: 81426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04013E13 RID: 81427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x04013E14 RID: 81428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x04013E15 RID: 81429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x04013E16 RID: 81430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x04013E17 RID: 81431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x04013E18 RID: 81432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x04013E19 RID: 81433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x04013E1A RID: 81434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x04013E1B RID: 81435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x04013E1C RID: 81436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x04013E1D RID: 81437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x04013E1E RID: 81438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x04013E1F RID: 81439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x04013E20 RID: 81440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x04013E21 RID: 81441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x04013E22 RID: 81442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x04013E23 RID: 81443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x04013E24 RID: 81444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x04013E25 RID: 81445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x04013E26 RID: 81446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x04013E27 RID: 81447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x04013E28 RID: 81448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x04013E29 RID: 81449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x04013E2A RID: 81450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x04013E2B RID: 81451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x04013E2C RID: 81452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x04013E2D RID: 81453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x04013E2E RID: 81454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x04013E2F RID: 81455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x04013E30 RID: 81456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x04013E31 RID: 81457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;
}
