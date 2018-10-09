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

// Token: 0x020014D2 RID: 5330
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroListUIController : LuaObject
{
	// Token: 0x0601F41F RID: 128031 RVA: 0x00A385E4 File Offset: 0x00A367E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateViewInHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			bool isNeedRebuildHeroList;
			LuaObject.checkType(l, 2, out isNeedRebuildHeroList);
			heroListUIController.UpdateViewInHeroList(isNeedRebuildHeroList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F420 RID: 128032 RVA: 0x00A3863C File Offset: 0x00A3683C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroPowerValue(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.SetHeroPowerValue();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F421 RID: 128033 RVA: 0x00A38688 File Offset: 0x00A36888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetHeroPowerValue(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.ResetHeroPowerValue();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F422 RID: 128034 RVA: 0x00A386D4 File Offset: 0x00A368D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopAllCoroutineInHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.StopAllCoroutineInHeroList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F423 RID: 128035 RVA: 0x00A38720 File Offset: 0x00A36920
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHeroCharSkinPreview(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			string spinePath;
			LuaObject.checkType(l, 2, out spinePath);
			int heroSkinId;
			LuaObject.checkType(l, 3, out heroSkinId);
			heroListUIController.SetHeroCharSkinPreview(spinePath, heroSkinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F424 RID: 128036 RVA: 0x00A38784 File Offset: 0x00A36984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			List<Hero> unlockedList;
			LuaObject.checkType<List<Hero>>(l, 2, out unlockedList);
			List<Hero> lockedList;
			LuaObject.checkType<List<Hero>>(l, 3, out lockedList);
			heroListUIController.SetCurHeroList(unlockedList, lockedList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F425 RID: 128037 RVA: 0x00A387E8 File Offset: 0x00A369E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToInitState(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.SetToInitState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F426 RID: 128038 RVA: 0x00A38834 File Offset: 0x00A36A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToAtLeftState(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.SetToAtLeftState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F427 RID: 128039 RVA: 0x00A38880 File Offset: 0x00A36A80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClickHeroByIdForUserGuide(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			heroListUIController.ClickHeroByIdForUserGuide(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F428 RID: 128040 RVA: 0x00A388D8 File Offset: 0x00A36AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClickLowLevelHeroForUserGuide(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.ClickLowLevelHeroForUserGuide();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F429 RID: 128041 RVA: 0x00A38924 File Offset: 0x00A36B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClickLockedHeroForUserGuide(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			bool b = heroListUIController.ClickLockedHeroForUserGuide();
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

	// Token: 0x0601F42A RID: 128042 RVA: 0x00A38978 File Offset: 0x00A36B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F42B RID: 128043 RVA: 0x00A389C4 File Offset: 0x00A36BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowButtonGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			heroListUIController.ShowButtonGameObject(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F42C RID: 128044 RVA: 0x00A38A1C File Offset: 0x00A36C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetPanelPos(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.ResetPanelPos();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F42D RID: 128045 RVA: 0x00A38A68 File Offset: 0x00A36C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InactiveCharWordPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.InactiveCharWordPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F42E RID: 128046 RVA: 0x00A38AB4 File Offset: 0x00A36CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			List<Hero> curHeroList = heroListUIController.GetCurHeroList();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, curHeroList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F42F RID: 128047 RVA: 0x00A38B08 File Offset: 0x00A36D08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HaveHeroCanCompose(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			bool b = heroListUIController.HaveHeroCanCompose();
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

	// Token: 0x0601F430 RID: 128048 RVA: 0x00A38B5C File Offset: 0x00A36D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayHeroPerformance(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			int heroPerformanceId;
			LuaObject.checkType(l, 2, out heroPerformanceId);
			heroListUIController.PlayHeroPerformance(heroPerformanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F431 RID: 128049 RVA: 0x00A38BB4 File Offset: 0x00A36DB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F432 RID: 128050 RVA: 0x00A38C08 File Offset: 0x00A36E08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F433 RID: 128051 RVA: 0x00A38C5C File Offset: 0x00A36E5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.CreateHeroList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F434 RID: 128052 RVA: 0x00A38CB0 File Offset: 0x00A36EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetPowerValue(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			float newValue;
			LuaObject.checkType(l, 2, out newValue);
			float oldValue;
			LuaObject.checkType(l, 3, out oldValue);
			IEnumerator o = heroListUIController.m_luaExportHelper.Co_SetPowerValue(newValue, oldValue);
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

	// Token: 0x0601F435 RID: 128053 RVA: 0x00A38D24 File Offset: 0x00A36F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			HeroItemUIController goCtrl;
			LuaObject.checkType<HeroItemUIController>(l, 2, out goCtrl);
			heroListUIController.m_luaExportHelper.OnHeroItemClick(goCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F436 RID: 128054 RVA: 0x00A38D80 File Offset: 0x00A36F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroFragmentSearchButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnHeroFragmentSearchButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F437 RID: 128055 RVA: 0x00A38DD4 File Offset: 0x00A36FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBreakButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnBreakButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F438 RID: 128056 RVA: 0x00A38E28 File Offset: 0x00A37028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayBreakButtonClickEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			IEnumerator o = heroListUIController.m_luaExportHelper.PlayBreakButtonClickEffect(heroId);
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

	// Token: 0x0601F439 RID: 128057 RVA: 0x00A38E90 File Offset: 0x00A37090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComposeLockedHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Hero h;
			LuaObject.checkType<Hero>(l, 2, out h);
			heroListUIController.m_luaExportHelper.ComposeLockedHero(h);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F43A RID: 128058 RVA: 0x00A38EEC File Offset: 0x00A370EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseComposeHeroPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.CloseComposeHeroPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F43B RID: 128059 RVA: 0x00A38F40 File Offset: 0x00A37140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ConfirmComposeHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.ConfirmComposeHero();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F43C RID: 128060 RVA: 0x00A38F94 File Offset: 0x00A37194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnComposeHeroSucceed(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnComposeHeroSucceed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F43D RID: 128061 RVA: 0x00A38FE8 File Offset: 0x00A371E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayHeroGetEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			IEnumerator o = heroListUIController.m_luaExportHelper.PlayHeroGetEffect();
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

	// Token: 0x0601F43E RID: 128062 RVA: 0x00A39044 File Offset: 0x00A37244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExtractionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnExtractionButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F43F RID: 128063 RVA: 0x00A39098 File Offset: 0x00A37298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentsButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnEquipmentsButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F440 RID: 128064 RVA: 0x00A390EC File Offset: 0x00A372EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroJobUpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnHeroJobUpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F441 RID: 128065 RVA: 0x00A39140 File Offset: 0x00A37340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroCharSkinChangeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnHeroCharSkinChangeButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F442 RID: 128066 RVA: 0x00A39194 File Offset: 0x00A37394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCharUIController_OnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.HeroCharUIController_OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F443 RID: 128067 RVA: 0x00A391E8 File Offset: 0x00A373E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroItemPosInList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject child;
			LuaObject.checkType<GameObject>(l, 2, out child);
			List<HeroItemUIController> parent;
			LuaObject.checkType<List<HeroItemUIController>>(l, 3, out parent);
			int heroItemPosInList = heroListUIController.m_luaExportHelper.GetHeroItemPosInList(child, parent);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemPosInList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F444 RID: 128068 RVA: 0x00A3925C File Offset: 0x00A3745C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F445 RID: 128069 RVA: 0x00A392B0 File Offset: 0x00A374B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSortTypeButtonAndToggles(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.SetSortTypeButtonAndToggles();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F446 RID: 128070 RVA: 0x00A39304 File Offset: 0x00A37504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetData(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.ResetData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F447 RID: 128071 RVA: 0x00A39358 File Offset: 0x00A37558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFilterButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnFilterButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F448 RID: 128072 RVA: 0x00A393AC File Offset: 0x00A375AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewPosition(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.ResetScrollViewPosition();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F449 RID: 128073 RVA: 0x00A39400 File Offset: 0x00A37600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDetailButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnDetailButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F44A RID: 128074 RVA: 0x00A39454 File Offset: 0x00A37654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSummonButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnSummonButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F44B RID: 128075 RVA: 0x00A394A8 File Offset: 0x00A376A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaySummonButtonClickEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			IEnumerator o = heroListUIController.m_luaExportHelper.PlaySummonButtonClickEffect();
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

	// Token: 0x0601F44C RID: 128076 RVA: 0x00A39504 File Offset: 0x00A37704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCommentButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnCommentButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F44D RID: 128077 RVA: 0x00A39558 File Offset: 0x00A37758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddHeroButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnAddHeroButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F44E RID: 128078 RVA: 0x00A395AC File Offset: 0x00A377AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSpeedUpHeroButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnSpeedUpHeroButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F44F RID: 128079 RVA: 0x00A39600 File Offset: 0x00A37800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResetHeroButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnResetHeroButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F450 RID: 128080 RVA: 0x00A39654 File Offset: 0x00A37854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLevelToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			heroListUIController.m_luaExportHelper.OnLevelToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F451 RID: 128081 RVA: 0x00A396B0 File Offset: 0x00A378B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStarLevelToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			heroListUIController.m_luaExportHelper.OnStarLevelToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F452 RID: 128082 RVA: 0x00A3970C File Offset: 0x00A3790C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRankToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			heroListUIController.m_luaExportHelper.OnRankToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F453 RID: 128083 RVA: 0x00A39768 File Offset: 0x00A37968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPowerToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			heroListUIController.m_luaExportHelper.OnPowerToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F454 RID: 128084 RVA: 0x00A397C4 File Offset: 0x00A379C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSortButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.OnSortButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F455 RID: 128085 RVA: 0x00A39818 File Offset: 0x00A37A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseSortTypesPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.CloseSortTypesPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F456 RID: 128086 RVA: 0x00A3986C File Offset: 0x00A37A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroListUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F457 RID: 128087 RVA: 0x00A398D8 File Offset: 0x00A37AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F458 RID: 128088 RVA: 0x00A3992C File Offset: 0x00A37B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F459 RID: 128089 RVA: 0x00A39980 File Offset: 0x00A37B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroListUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F45A RID: 128090 RVA: 0x00A39A28 File Offset: 0x00A37C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F45B RID: 128091 RVA: 0x00A39A7C File Offset: 0x00A37C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroListUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F45C RID: 128092 RVA: 0x00A39AE8 File Offset: 0x00A37CE8
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
				HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroListUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroListUIController heroListUIController2 = (HeroListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroListUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F45D RID: 128093 RVA: 0x00A39BF8 File Offset: 0x00A37DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroListUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F45E RID: 128094 RVA: 0x00A39C64 File Offset: 0x00A37E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroListUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F45F RID: 128095 RVA: 0x00A39CD0 File Offset: 0x00A37ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroListUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F460 RID: 128096 RVA: 0x00A39D3C File Offset: 0x00A37F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroListUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F461 RID: 128097 RVA: 0x00A39DA8 File Offset: 0x00A37FA8
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
				HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroListUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroListUIController heroListUIController2 = (HeroListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroListUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F462 RID: 128098 RVA: 0x00A39EB8 File Offset: 0x00A380B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			string s = heroListUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F463 RID: 128099 RVA: 0x00A39F14 File Offset: 0x00A38114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F464 RID: 128100 RVA: 0x00A39F68 File Offset: 0x00A38168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F465 RID: 128101 RVA: 0x00A39FBC File Offset: 0x00A381BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnFilter(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__callDele_EventOnFilter();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F466 RID: 128102 RVA: 0x00A3A010 File Offset: 0x00A38210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnFilter(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnFilter();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F467 RID: 128103 RVA: 0x00A3A064 File Offset: 0x00A38264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnDetail(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__callDele_EventOnDetail();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F468 RID: 128104 RVA: 0x00A3A0B8 File Offset: 0x00A382B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDetail(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnDetail();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F469 RID: 128105 RVA: 0x00A3A10C File Offset: 0x00A3830C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnComment(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__callDele_EventOnComment();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F46A RID: 128106 RVA: 0x00A3A160 File Offset: 0x00A38360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnComment(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnComment();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F46B RID: 128107 RVA: 0x00A3A1B4 File Offset: 0x00A383B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__callDele_EventOnEquipment();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F46C RID: 128108 RVA: 0x00A3A208 File Offset: 0x00A38408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnEquipment();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F46D RID: 128109 RVA: 0x00A3A25C File Offset: 0x00A3845C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnJob(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__callDele_EventOnJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F46E RID: 128110 RVA: 0x00A3A2B0 File Offset: 0x00A384B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnJob(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F46F RID: 128111 RVA: 0x00A3A304 File Offset: 0x00A38504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroCharClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__callDele_EventOnHeroCharClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F470 RID: 128112 RVA: 0x00A3A358 File Offset: 0x00A38558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroCharClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnHeroCharClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F471 RID: 128113 RVA: 0x00A3A3AC File Offset: 0x00A385AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroBreak(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroListUIController.m_luaExportHelper.__callDele_EventOnHeroBreak(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F472 RID: 128114 RVA: 0x00A3A408 File Offset: 0x00A38608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroBreak(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnHeroBreak(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F473 RID: 128115 RVA: 0x00A3A464 File Offset: 0x00A38664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			heroListUIController.m_luaExportHelper.__callDele_EventOnAddHero(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F474 RID: 128116 RVA: 0x00A3A4C0 File Offset: 0x00A386C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnAddHero(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F475 RID: 128117 RVA: 0x00A3A51C File Offset: 0x00A3871C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnComposeHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			heroListUIController.m_luaExportHelper.__callDele_EventOnComposeHero(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F476 RID: 128118 RVA: 0x00A3A588 File Offset: 0x00A38788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnComposeHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnComposeHero(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F477 RID: 128119 RVA: 0x00A3A5F4 File Offset: 0x00A387F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSortToggleClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			HeroListUIController.HeroSortType obj;
			LuaObject.checkEnum<HeroListUIController.HeroSortType>(l, 2, out obj);
			heroListUIController.m_luaExportHelper.__callDele_EventOnSortToggleClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F478 RID: 128120 RVA: 0x00A3A650 File Offset: 0x00A38850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSortToggleClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			HeroListUIController.HeroSortType obj;
			LuaObject.checkEnum<HeroListUIController.HeroSortType>(l, 2, out obj);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnSortToggleClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F479 RID: 128121 RVA: 0x00A3A6AC File Offset: 0x00A388AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowGetPath(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			heroListUIController.m_luaExportHelper.__callDele_EventOnShowGetPath(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F47A RID: 128122 RVA: 0x00A3A724 File Offset: 0x00A38924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowGetPath(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnShowGetPath(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F47B RID: 128123 RVA: 0x00A3A79C File Offset: 0x00A3899C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnInitHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			List<Hero> arg;
			LuaObject.checkType<List<Hero>>(l, 2, out arg);
			List<Hero> arg2;
			LuaObject.checkType<List<Hero>>(l, 3, out arg2);
			heroListUIController.m_luaExportHelper.__callDele_EventOnInitHeroList(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F47C RID: 128124 RVA: 0x00A3A808 File Offset: 0x00A38A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnInitHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			List<Hero> arg;
			LuaObject.checkType<List<Hero>>(l, 2, out arg);
			List<Hero> arg2;
			LuaObject.checkType<List<Hero>>(l, 3, out arg2);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnInitHeroList(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F47D RID: 128125 RVA: 0x00A3A874 File Offset: 0x00A38A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUpdateViewInListAndDetail(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			bool arg3;
			LuaObject.checkType(l, 4, out arg3);
			int arg4;
			LuaObject.checkType(l, 5, out arg4);
			heroListUIController.m_luaExportHelper.__callDele_EventOnUpdateViewInListAndDetail(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F47E RID: 128126 RVA: 0x00A3A8F8 File Offset: 0x00A38AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnUpdateViewInListAndDetail(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			bool arg3;
			LuaObject.checkType(l, 4, out arg3);
			int arg4;
			LuaObject.checkType(l, 5, out arg4);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnUpdateViewInListAndDetail(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F47F RID: 128127 RVA: 0x00A3A97C File Offset: 0x00A38B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroCharSkinChangeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__callDele_EventOnHeroCharSkinChangeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F480 RID: 128128 RVA: 0x00A3A9D0 File Offset: 0x00A38BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroCharSkinChangeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnHeroCharSkinChangeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F481 RID: 128129 RVA: 0x00A3AA24 File Offset: 0x00A38C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGoToMemoryExtractionStore(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__callDele_EventOnGoToMemoryExtractionStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F482 RID: 128130 RVA: 0x00A3AA78 File Offset: 0x00A38C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoToMemoryExtractionStore(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			heroListUIController.m_luaExportHelper.__clearDele_EventOnGoToMemoryExtractionStore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F483 RID: 128131 RVA: 0x00A3AACC File Offset: 0x00A38CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnReturn -= value;
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

	// Token: 0x0601F484 RID: 128132 RVA: 0x00A3AB4C File Offset: 0x00A38D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnFilter(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnFilter += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnFilter -= value;
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

	// Token: 0x0601F485 RID: 128133 RVA: 0x00A3ABCC File Offset: 0x00A38DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDetail(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnDetail += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnDetail -= value;
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

	// Token: 0x0601F486 RID: 128134 RVA: 0x00A3AC4C File Offset: 0x00A38E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnComment(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnComment += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnComment -= value;
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

	// Token: 0x0601F487 RID: 128135 RVA: 0x00A3ACCC File Offset: 0x00A38ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnEquipment += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnEquipment -= value;
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

	// Token: 0x0601F488 RID: 128136 RVA: 0x00A3AD4C File Offset: 0x00A38F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnJob(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnJob += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnJob -= value;
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

	// Token: 0x0601F489 RID: 128137 RVA: 0x00A3ADCC File Offset: 0x00A38FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroCharClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnHeroCharClick += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnHeroCharClick -= value;
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

	// Token: 0x0601F48A RID: 128138 RVA: 0x00A3AE4C File Offset: 0x00A3904C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroBreak(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnHeroBreak += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnHeroBreak -= value;
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

	// Token: 0x0601F48B RID: 128139 RVA: 0x00A3AECC File Offset: 0x00A390CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnAddHero += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnAddHero -= value;
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

	// Token: 0x0601F48C RID: 128140 RVA: 0x00A3AF4C File Offset: 0x00A3914C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnComposeHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action<int, Action> value;
			int num = LuaObject.checkDelegate<Action<int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnComposeHero += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnComposeHero -= value;
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

	// Token: 0x0601F48D RID: 128141 RVA: 0x00A3AFCC File Offset: 0x00A391CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSortToggleClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action<HeroListUIController.HeroSortType> value;
			int num = LuaObject.checkDelegate<Action<HeroListUIController.HeroSortType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnSortToggleClick += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnSortToggleClick -= value;
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

	// Token: 0x0601F48E RID: 128142 RVA: 0x00A3B04C File Offset: 0x00A3924C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowGetPath(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action<GoodsType, int, int> value;
			int num = LuaObject.checkDelegate<Action<GoodsType, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnShowGetPath += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnShowGetPath -= value;
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

	// Token: 0x0601F48F RID: 128143 RVA: 0x00A3B0CC File Offset: 0x00A392CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnInitHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action<List<Hero>, List<Hero>> value;
			int num = LuaObject.checkDelegate<Action<List<Hero>, List<Hero>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnInitHeroList += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnInitHeroList -= value;
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

	// Token: 0x0601F490 RID: 128144 RVA: 0x00A3B14C File Offset: 0x00A3934C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUpdateViewInListAndDetail(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action<int, bool, bool, int> value;
			int num = LuaObject.checkDelegate<Action<int, bool, bool, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnUpdateViewInListAndDetail += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnUpdateViewInListAndDetail -= value;
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

	// Token: 0x0601F491 RID: 128145 RVA: 0x00A3B1CC File Offset: 0x00A393CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroCharSkinChangeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnHeroCharSkinChangeButtonClick += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnHeroCharSkinChangeButtonClick -= value;
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

	// Token: 0x0601F492 RID: 128146 RVA: 0x00A3B24C File Offset: 0x00A3944C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoToMemoryExtractionStore(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroListUIController.EventOnGoToMemoryExtractionStore += value;
				}
				else if (num == 2)
				{
					heroListUIController.EventOnGoToMemoryExtractionStore -= value;
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

	// Token: 0x0601F493 RID: 128147 RVA: 0x00A3B2CC File Offset: 0x00A394CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollViewUnlockedHeroContent(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_scrollViewUnlockedHeroContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F494 RID: 128148 RVA: 0x00A3B324 File Offset: 0x00A39524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollViewUnlockedHeroContent(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject scrollViewUnlockedHeroContent;
			LuaObject.checkType<GameObject>(l, 2, out scrollViewUnlockedHeroContent);
			heroListUIController.m_luaExportHelper.m_scrollViewUnlockedHeroContent = scrollViewUnlockedHeroContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F495 RID: 128149 RVA: 0x00A3B380 File Offset: 0x00A39580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollViewLockedHeroContent(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_scrollViewLockedHeroContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F496 RID: 128150 RVA: 0x00A3B3D8 File Offset: 0x00A395D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollViewLockedHeroContent(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject scrollViewLockedHeroContent;
			LuaObject.checkType<GameObject>(l, 2, out scrollViewLockedHeroContent);
			heroListUIController.m_luaExportHelper.m_scrollViewLockedHeroContent = scrollViewLockedHeroContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F497 RID: 128151 RVA: 0x00A3B434 File Offset: 0x00A39634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollView(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_scrollView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F498 RID: 128152 RVA: 0x00A3B48C File Offset: 0x00A3968C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollView(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			ScrollRect scrollView;
			LuaObject.checkType<ScrollRect>(l, 2, out scrollView);
			heroListUIController.m_luaExportHelper.m_scrollView = scrollView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F499 RID: 128153 RVA: 0x00A3B4E8 File Offset: 0x00A396E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cvText(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_cvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F49A RID: 128154 RVA: 0x00A3B540 File Offset: 0x00A39740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cvText(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Text cvText;
			LuaObject.checkType<Text>(l, 2, out cvText);
			heroListUIController.m_luaExportHelper.m_cvText = cvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F49B RID: 128155 RVA: 0x00A3B59C File Offset: 0x00A3979C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commentButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_commentButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F49C RID: 128156 RVA: 0x00A3B5F4 File Offset: 0x00A397F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commentButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button commentButton;
			LuaObject.checkType<Button>(l, 2, out commentButton);
			heroListUIController.m_luaExportHelper.m_commentButton = commentButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F49D RID: 128157 RVA: 0x00A3B650 File Offset: 0x00A39850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_detailButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F49E RID: 128158 RVA: 0x00A3B6A8 File Offset: 0x00A398A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button detailButton;
			LuaObject.checkType<Button>(l, 2, out detailButton);
			heroListUIController.m_luaExportHelper.m_detailButton = detailButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F49F RID: 128159 RVA: 0x00A3B704 File Offset: 0x00A39904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailButtonRedPointImage(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_detailButtonRedPointImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4A0 RID: 128160 RVA: 0x00A3B75C File Offset: 0x00A3995C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailButtonRedPointImage(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject detailButtonRedPointImage;
			LuaObject.checkType<GameObject>(l, 2, out detailButtonRedPointImage);
			heroListUIController.m_luaExportHelper.m_detailButtonRedPointImage = detailButtonRedPointImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4A1 RID: 128161 RVA: 0x00A3B7B8 File Offset: 0x00A399B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_summonButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_summonButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4A2 RID: 128162 RVA: 0x00A3B810 File Offset: 0x00A39A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_summonButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button summonButton;
			LuaObject.checkType<Button>(l, 2, out summonButton);
			heroListUIController.m_luaExportHelper.m_summonButton = summonButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4A3 RID: 128163 RVA: 0x00A3B86C File Offset: 0x00A39A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_summonButtonPressEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_summonButtonPressEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4A4 RID: 128164 RVA: 0x00A3B8C4 File Offset: 0x00A39AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_summonButtonPressEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject summonButtonPressEffect;
			LuaObject.checkType<GameObject>(l, 2, out summonButtonPressEffect);
			heroListUIController.m_luaExportHelper.m_summonButtonPressEffect = summonButtonPressEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4A5 RID: 128165 RVA: 0x00A3B920 File Offset: 0x00A39B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_summonButtonReadyEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_summonButtonReadyEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4A6 RID: 128166 RVA: 0x00A3B978 File Offset: 0x00A39B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_summonButtonReadyEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject summonButtonReadyEffect;
			LuaObject.checkType<GameObject>(l, 2, out summonButtonReadyEffect);
			heroListUIController.m_luaExportHelper.m_summonButtonReadyEffect = summonButtonReadyEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4A7 RID: 128167 RVA: 0x00A3B9D4 File Offset: 0x00A39BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_filterButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_filterButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4A8 RID: 128168 RVA: 0x00A3BA2C File Offset: 0x00A39C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button filterButton;
			LuaObject.checkType<Button>(l, 2, out filterButton);
			heroListUIController.m_luaExportHelper.m_filterButton = filterButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4A9 RID: 128169 RVA: 0x00A3BA88 File Offset: 0x00A39C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addheroButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_addheroButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4AA RID: 128170 RVA: 0x00A3BAE0 File Offset: 0x00A39CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addheroButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button addheroButton;
			LuaObject.checkType<Button>(l, 2, out addheroButton);
			heroListUIController.m_luaExportHelper.m_addheroButton = addheroButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4AB RID: 128171 RVA: 0x00A3BB3C File Offset: 0x00A39D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_speedUpHeroButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_speedUpHeroButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4AC RID: 128172 RVA: 0x00A3BB94 File Offset: 0x00A39D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_speedUpHeroButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button speedUpHeroButton;
			LuaObject.checkType<Button>(l, 2, out speedUpHeroButton);
			heroListUIController.m_luaExportHelper.m_speedUpHeroButton = speedUpHeroButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4AD RID: 128173 RVA: 0x00A3BBF0 File Offset: 0x00A39DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resetHeroButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_resetHeroButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4AE RID: 128174 RVA: 0x00A3BC48 File Offset: 0x00A39E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resetHeroButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button resetHeroButton;
			LuaObject.checkType<Button>(l, 2, out resetHeroButton);
			heroListUIController.m_luaExportHelper.m_resetHeroButton = resetHeroButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4AF RID: 128175 RVA: 0x00A3BCA4 File Offset: 0x00A39EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroIdInputField(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroIdInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4B0 RID: 128176 RVA: 0x00A3BCFC File Offset: 0x00A39EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIdInputField(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			InputField heroIdInputField;
			LuaObject.checkType<InputField>(l, 2, out heroIdInputField);
			heroListUIController.m_luaExportHelper.m_heroIdInputField = heroIdInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4B1 RID: 128177 RVA: 0x00A3BD58 File Offset: 0x00A39F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_composeConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_composeConfirmPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4B2 RID: 128178 RVA: 0x00A3BDB0 File Offset: 0x00A39FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_composeConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject composeConfirmPanel;
			LuaObject.checkType<GameObject>(l, 2, out composeConfirmPanel);
			heroListUIController.m_luaExportHelper.m_composeConfirmPanel = composeConfirmPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4B3 RID: 128179 RVA: 0x00A3BE0C File Offset: 0x00A3A00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_composeCostText(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_composeCostText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4B4 RID: 128180 RVA: 0x00A3BE64 File Offset: 0x00A3A064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_composeCostText(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Text composeCostText;
			LuaObject.checkType<Text>(l, 2, out composeCostText);
			heroListUIController.m_luaExportHelper.m_composeCostText = composeCostText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4B5 RID: 128181 RVA: 0x00A3BEC0 File Offset: 0x00A3A0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_composeCancelButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_composeCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4B6 RID: 128182 RVA: 0x00A3BF18 File Offset: 0x00A3A118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_composeCancelButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button composeCancelButton;
			LuaObject.checkType<Button>(l, 2, out composeCancelButton);
			heroListUIController.m_luaExportHelper.m_composeCancelButton = composeCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4B7 RID: 128183 RVA: 0x00A3BF74 File Offset: 0x00A3A174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_composeConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_composeConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4B8 RID: 128184 RVA: 0x00A3BFCC File Offset: 0x00A3A1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_composeConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button composeConfirmButton;
			LuaObject.checkType<Button>(l, 2, out composeConfirmButton);
			heroListUIController.m_luaExportHelper.m_composeConfirmButton = composeConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4B9 RID: 128185 RVA: 0x00A3C028 File Offset: 0x00A3A228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4BA RID: 128186 RVA: 0x00A3C080 File Offset: 0x00A3A280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			heroListUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4BB RID: 128187 RVA: 0x00A3C0DC File Offset: 0x00A3A2DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroNameTextCh(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroNameTextCh);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4BC RID: 128188 RVA: 0x00A3C134 File Offset: 0x00A3A334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroNameTextCh(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Text heroNameTextCh;
			LuaObject.checkType<Text>(l, 2, out heroNameTextCh);
			heroListUIController.m_luaExportHelper.m_heroNameTextCh = heroNameTextCh;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4BD RID: 128189 RVA: 0x00A3C190 File Offset: 0x00A3A390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroNameTextEn(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroNameTextEn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4BE RID: 128190 RVA: 0x00A3C1E8 File Offset: 0x00A3A3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroNameTextEn(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Text heroNameTextEn;
			LuaObject.checkType<Text>(l, 2, out heroNameTextEn);
			heroListUIController.m_luaExportHelper.m_heroNameTextEn = heroNameTextEn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4BF RID: 128191 RVA: 0x00A3C244 File Offset: 0x00A3A444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroRankImage(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroRankImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4C0 RID: 128192 RVA: 0x00A3C29C File Offset: 0x00A3A49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroRankImage(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Image heroRankImage;
			LuaObject.checkType<Image>(l, 2, out heroRankImage);
			heroListUIController.m_luaExportHelper.m_heroRankImage = heroRankImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4C1 RID: 128193 RVA: 0x00A3C2F8 File Offset: 0x00A3A4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4C2 RID: 128194 RVA: 0x00A3C350 File Offset: 0x00A3A550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject heroStar;
			LuaObject.checkType<GameObject>(l, 2, out heroStar);
			heroListUIController.m_luaExportHelper.m_heroStar = heroStar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4C3 RID: 128195 RVA: 0x00A3C3AC File Offset: 0x00A3A5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGameObjectRoot(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_charGameObjectRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4C4 RID: 128196 RVA: 0x00A3C404 File Offset: 0x00A3A604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGameObjectRoot(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject charGameObjectRoot;
			LuaObject.checkType<GameObject>(l, 2, out charGameObjectRoot);
			heroListUIController.m_luaExportHelper.m_charGameObjectRoot = charGameObjectRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4C5 RID: 128197 RVA: 0x00A3C460 File Offset: 0x00A3A660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charWordGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_charWordGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4C6 RID: 128198 RVA: 0x00A3C4B8 File Offset: 0x00A3A6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charWordGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject charWordGameObject;
			LuaObject.checkType<GameObject>(l, 2, out charWordGameObject);
			heroListUIController.m_luaExportHelper.m_charWordGameObject = charWordGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4C7 RID: 128199 RVA: 0x00A3C514 File Offset: 0x00A3A714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charSummonEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_charSummonEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4C8 RID: 128200 RVA: 0x00A3C56C File Offset: 0x00A3A76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charSummonEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject charSummonEffect;
			LuaObject.checkType<GameObject>(l, 2, out charSummonEffect);
			heroListUIController.m_luaExportHelper.m_charSummonEffect = charSummonEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4C9 RID: 128201 RVA: 0x00A3C5C8 File Offset: 0x00A3A7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroInfoPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4CA RID: 128202 RVA: 0x00A3C620 File Offset: 0x00A3A820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject heroInfoPanel;
			LuaObject.checkType<GameObject>(l, 2, out heroInfoPanel);
			heroListUIController.m_luaExportHelper.m_heroInfoPanel = heroInfoPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4CB RID: 128203 RVA: 0x00A3C67C File Offset: 0x00A3A87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharSkinChangeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroCharSkinChangeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4CC RID: 128204 RVA: 0x00A3C6D4 File Offset: 0x00A3A8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharSkinChangeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button heroCharSkinChangeButton;
			LuaObject.checkType<Button>(l, 2, out heroCharSkinChangeButton);
			heroListUIController.m_luaExportHelper.m_heroCharSkinChangeButton = heroCharSkinChangeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4CD RID: 128205 RVA: 0x00A3C730 File Offset: 0x00A3A930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroJobUpButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroJobUpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4CE RID: 128206 RVA: 0x00A3C788 File Offset: 0x00A3A988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroJobUpButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button heroJobUpButton;
			LuaObject.checkType<Button>(l, 2, out heroJobUpButton);
			heroListUIController.m_luaExportHelper.m_heroJobUpButton = heroJobUpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4CF RID: 128207 RVA: 0x00A3C7E4 File Offset: 0x00A3A9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroEquipmentsButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroEquipmentsButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4D0 RID: 128208 RVA: 0x00A3C83C File Offset: 0x00A3AA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroEquipmentsButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button heroEquipmentsButton;
			LuaObject.checkType<Button>(l, 2, out heroEquipmentsButton);
			heroListUIController.m_luaExportHelper.m_heroEquipmentsButton = heroEquipmentsButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4D1 RID: 128209 RVA: 0x00A3C898 File Offset: 0x00A3AA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroEquipmentsContent(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroEquipmentsContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4D2 RID: 128210 RVA: 0x00A3C8F0 File Offset: 0x00A3AAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroEquipmentsContent(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject heroEquipmentsContent;
			LuaObject.checkType<GameObject>(l, 2, out heroEquipmentsContent);
			heroListUIController.m_luaExportHelper.m_heroEquipmentsContent = heroEquipmentsContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4D3 RID: 128211 RVA: 0x00A3C94C File Offset: 0x00A3AB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroEquipmentsRedPointImage(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroEquipmentsRedPointImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4D4 RID: 128212 RVA: 0x00A3C9A4 File Offset: 0x00A3ABA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroEquipmentsRedPointImage(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject heroEquipmentsRedPointImage;
			LuaObject.checkType<GameObject>(l, 2, out heroEquipmentsRedPointImage);
			heroListUIController.m_luaExportHelper.m_heroEquipmentsRedPointImage = heroEquipmentsRedPointImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4D5 RID: 128213 RVA: 0x00A3CA00 File Offset: 0x00A3AC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_powerValueStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_powerValueStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4D6 RID: 128214 RVA: 0x00A3CA58 File Offset: 0x00A3AC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_powerValueStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			CommonUIStateController powerValueStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out powerValueStateCtrl);
			heroListUIController.m_luaExportHelper.m_powerValueStateCtrl = powerValueStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4D7 RID: 128215 RVA: 0x00A3CAB4 File Offset: 0x00A3ACB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_powerValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_powerValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4D8 RID: 128216 RVA: 0x00A3CB0C File Offset: 0x00A3AD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_powerValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Text powerValueText;
			LuaObject.checkType<Text>(l, 2, out powerValueText);
			heroListUIController.m_luaExportHelper.m_powerValueText = powerValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4D9 RID: 128217 RVA: 0x00A3CB68 File Offset: 0x00A3AD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_powerArrowGo(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_powerArrowGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4DA RID: 128218 RVA: 0x00A3CBC0 File Offset: 0x00A3ADC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_powerArrowGo(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject powerArrowGo;
			LuaObject.checkType<GameObject>(l, 2, out powerArrowGo);
			heroListUIController.m_luaExportHelper.m_powerArrowGo = powerArrowGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4DB RID: 128219 RVA: 0x00A3CC1C File Offset: 0x00A3AE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_breakButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4DC RID: 128220 RVA: 0x00A3CC74 File Offset: 0x00A3AE74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button breakButton;
			LuaObject.checkType<Button>(l, 2, out breakButton);
			heroListUIController.m_luaExportHelper.m_breakButton = breakButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4DD RID: 128221 RVA: 0x00A3CCD0 File Offset: 0x00A3AED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakButtonReadyEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_breakButtonReadyEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4DE RID: 128222 RVA: 0x00A3CD28 File Offset: 0x00A3AF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakButtonReadyEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject breakButtonReadyEffect;
			LuaObject.checkType<GameObject>(l, 2, out breakButtonReadyEffect);
			heroListUIController.m_luaExportHelper.m_breakButtonReadyEffect = breakButtonReadyEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4DF RID: 128223 RVA: 0x00A3CD84 File Offset: 0x00A3AF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakButtonPressEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_breakButtonPressEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4E0 RID: 128224 RVA: 0x00A3CDDC File Offset: 0x00A3AFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakButtonPressEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject breakButtonPressEffect;
			LuaObject.checkType<GameObject>(l, 2, out breakButtonPressEffect);
			heroListUIController.m_luaExportHelper.m_breakButtonPressEffect = breakButtonPressEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4E1 RID: 128225 RVA: 0x00A3CE38 File Offset: 0x00A3B038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakAddBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_breakAddBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4E2 RID: 128226 RVA: 0x00A3CE90 File Offset: 0x00A3B090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakAddBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button breakAddBtn;
			LuaObject.checkType<Button>(l, 2, out breakAddBtn);
			heroListUIController.m_luaExportHelper.m_breakAddBtn = breakAddBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4E3 RID: 128227 RVA: 0x00A3CEEC File Offset: 0x00A3B0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakNumText(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_breakNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4E4 RID: 128228 RVA: 0x00A3CF44 File Offset: 0x00A3B144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakNumText(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Text breakNumText;
			LuaObject.checkType<Text>(l, 2, out breakNumText);
			heroListUIController.m_luaExportHelper.m_breakNumText = breakNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4E5 RID: 128229 RVA: 0x00A3CFA0 File Offset: 0x00A3B1A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_breakIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_breakIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4E6 RID: 128230 RVA: 0x00A3CFF8 File Offset: 0x00A3B1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_breakIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Image breakIconImage;
			LuaObject.checkType<Image>(l, 2, out breakIconImage);
			heroListUIController.m_luaExportHelper.m_breakIconImage = breakIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4E7 RID: 128231 RVA: 0x00A3D054 File Offset: 0x00A3B254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_extractionButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_extractionButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4E8 RID: 128232 RVA: 0x00A3D0AC File Offset: 0x00A3B2AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extractionButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button extractionButton;
			LuaObject.checkType<Button>(l, 2, out extractionButton);
			heroListUIController.m_luaExportHelper.m_extractionButton = extractionButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4E9 RID: 128233 RVA: 0x00A3D108 File Offset: 0x00A3B308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_extractionTipsStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_extractionTipsStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4EA RID: 128234 RVA: 0x00A3D160 File Offset: 0x00A3B360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extractionTipsStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			CommonUIStateController extractionTipsStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out extractionTipsStateCtrl);
			heroListUIController.m_luaExportHelper.m_extractionTipsStateCtrl = extractionTipsStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4EB RID: 128235 RVA: 0x00A3D1BC File Offset: 0x00A3B3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_sortButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4EC RID: 128236 RVA: 0x00A3D214 File Offset: 0x00A3B414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sortButton(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button sortButton;
			LuaObject.checkType<Button>(l, 2, out sortButton);
			heroListUIController.m_luaExportHelper.m_sortButton = sortButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4ED RID: 128237 RVA: 0x00A3D270 File Offset: 0x00A3B470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_sortButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4EE RID: 128238 RVA: 0x00A3D2C8 File Offset: 0x00A3B4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sortButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			CommonUIStateController sortButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out sortButtonStateCtrl);
			heroListUIController.m_luaExportHelper.m_sortButtonStateCtrl = sortButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4EF RID: 128239 RVA: 0x00A3D324 File Offset: 0x00A3B524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortTypesPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_sortTypesPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4F0 RID: 128240 RVA: 0x00A3D37C File Offset: 0x00A3B57C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sortTypesPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			CommonUIStateController sortTypesPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out sortTypesPanelStateCtrl);
			heroListUIController.m_luaExportHelper.m_sortTypesPanelStateCtrl = sortTypesPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4F1 RID: 128241 RVA: 0x00A3D3D8 File Offset: 0x00A3B5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortTypesReturnBgImage(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_sortTypesReturnBgImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4F2 RID: 128242 RVA: 0x00A3D430 File Offset: 0x00A3B630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sortTypesReturnBgImage(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Button sortTypesReturnBgImage;
			LuaObject.checkType<Button>(l, 2, out sortTypesReturnBgImage);
			heroListUIController.m_luaExportHelper.m_sortTypesReturnBgImage = sortTypesReturnBgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4F3 RID: 128243 RVA: 0x00A3D48C File Offset: 0x00A3B68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortTypesLevelToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_sortTypesLevelToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4F4 RID: 128244 RVA: 0x00A3D4E4 File Offset: 0x00A3B6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sortTypesLevelToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Toggle sortTypesLevelToggle;
			LuaObject.checkType<Toggle>(l, 2, out sortTypesLevelToggle);
			heroListUIController.m_luaExportHelper.m_sortTypesLevelToggle = sortTypesLevelToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4F5 RID: 128245 RVA: 0x00A3D540 File Offset: 0x00A3B740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortTypesStarToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_sortTypesStarToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4F6 RID: 128246 RVA: 0x00A3D598 File Offset: 0x00A3B798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sortTypesStarToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Toggle sortTypesStarToggle;
			LuaObject.checkType<Toggle>(l, 2, out sortTypesStarToggle);
			heroListUIController.m_luaExportHelper.m_sortTypesStarToggle = sortTypesStarToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4F7 RID: 128247 RVA: 0x00A3D5F4 File Offset: 0x00A3B7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortTypesRarityToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_sortTypesRarityToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4F8 RID: 128248 RVA: 0x00A3D64C File Offset: 0x00A3B84C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_sortTypesRarityToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Toggle sortTypesRarityToggle;
			LuaObject.checkType<Toggle>(l, 2, out sortTypesRarityToggle);
			heroListUIController.m_luaExportHelper.m_sortTypesRarityToggle = sortTypesRarityToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4F9 RID: 128249 RVA: 0x00A3D6A8 File Offset: 0x00A3B8A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sortTypesPowerToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_sortTypesPowerToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4FA RID: 128250 RVA: 0x00A3D700 File Offset: 0x00A3B900
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_sortTypesPowerToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			Toggle sortTypesPowerToggle;
			LuaObject.checkType<Toggle>(l, 2, out sortTypesPowerToggle);
			heroListUIController.m_luaExportHelper.m_sortTypesPowerToggle = sortTypesPowerToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4FB RID: 128251 RVA: 0x00A3D75C File Offset: 0x00A3B95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Level");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4FC RID: 128252 RVA: 0x00A3D7A4 File Offset: 0x00A3B9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StarLevelType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "StarLevel");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4FD RID: 128253 RVA: 0x00A3D7EC File Offset: 0x00A3B9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RankType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Rank");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4FE RID: 128254 RVA: 0x00A3D834 File Offset: 0x00A3BA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PowerType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Power");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F4FF RID: 128255 RVA: 0x00A3D87C File Offset: 0x00A3BA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isUnLockHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_isUnLockHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F500 RID: 128256 RVA: 0x00A3D8D0 File Offset: 0x00A3BAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isUnLockHero(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			bool isUnLockHero;
			LuaObject.checkType(l, 2, out isUnLockHero);
			heroListUIController.m_isUnLockHero = isUnLockHero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F501 RID: 128257 RVA: 0x00A3D928 File Offset: 0x00A3BB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPowerValue(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroPowerValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F502 RID: 128258 RVA: 0x00A3D980 File Offset: 0x00A3BB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroPowerValue(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			int heroPowerValue;
			LuaObject.checkType(l, 2, out heroPowerValue);
			heroListUIController.m_luaExportHelper.m_heroPowerValue = heroPowerValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F503 RID: 128259 RVA: 0x00A3D9DC File Offset: 0x00A3BBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curHeroNeedFragmentCount(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_curHeroNeedFragmentCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F504 RID: 128260 RVA: 0x00A3DA34 File Offset: 0x00A3BC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curHeroNeedFragmentCount(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			int curHeroNeedFragmentCount;
			LuaObject.checkType(l, 2, out curHeroNeedFragmentCount);
			heroListUIController.m_luaExportHelper.m_curHeroNeedFragmentCount = curHeroNeedFragmentCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F505 RID: 128261 RVA: 0x00A3DA90 File Offset: 0x00A3BC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSelectedHeroIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_curSelectedHeroIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F506 RID: 128262 RVA: 0x00A3DAE4 File Offset: 0x00A3BCE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_curSelectedHeroIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			int curSelectedHeroIndex;
			LuaObject.checkType(l, 2, out curSelectedHeroIndex);
			heroListUIController.m_curSelectedHeroIndex = curSelectedHeroIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F507 RID: 128263 RVA: 0x00A3DB3C File Offset: 0x00A3BD3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSeletedHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_curSeletedHeroList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F508 RID: 128264 RVA: 0x00A3DB90 File Offset: 0x00A3BD90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSeletedHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			GameObject curSeletedHeroList;
			LuaObject.checkType<GameObject>(l, 2, out curSeletedHeroList);
			heroListUIController.m_curSeletedHeroList = curSeletedHeroList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F509 RID: 128265 RVA: 0x00A3DBE8 File Offset: 0x00A3BDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_heroCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F50A RID: 128266 RVA: 0x00A3DC40 File Offset: 0x00A3BE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			HeroCharUIController heroCharUIController;
			LuaObject.checkType<HeroCharUIController>(l, 2, out heroCharUIController);
			heroListUIController.m_luaExportHelper.m_heroCharUIController = heroCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F50B RID: 128267 RVA: 0x00A3DC9C File Offset: 0x00A3BE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unLockedHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_unLockedHeroList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F50C RID: 128268 RVA: 0x00A3DCF0 File Offset: 0x00A3BEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unLockedHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			List<Hero> unLockedHeroList;
			LuaObject.checkType<List<Hero>>(l, 2, out unLockedHeroList);
			heroListUIController.m_unLockedHeroList = unLockedHeroList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F50D RID: 128269 RVA: 0x00A3DD48 File Offset: 0x00A3BF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_lockedHeroList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F50E RID: 128270 RVA: 0x00A3DD9C File Offset: 0x00A3BF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockedHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			List<Hero> lockedHeroList;
			LuaObject.checkType<List<Hero>>(l, 2, out lockedHeroList);
			heroListUIController.m_lockedHeroList = lockedHeroList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F50F RID: 128271 RVA: 0x00A3DDF4 File Offset: 0x00A3BFF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unLockedHeroCtrlList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_unLockedHeroCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F510 RID: 128272 RVA: 0x00A3DE48 File Offset: 0x00A3C048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unLockedHeroCtrlList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			List<HeroItemUIController> unLockedHeroCtrlList;
			LuaObject.checkType<List<HeroItemUIController>>(l, 2, out unLockedHeroCtrlList);
			heroListUIController.m_unLockedHeroCtrlList = unLockedHeroCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F511 RID: 128273 RVA: 0x00A3DEA0 File Offset: 0x00A3C0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedHeroCtrlList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_lockedHeroCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F512 RID: 128274 RVA: 0x00A3DEF4 File Offset: 0x00A3C0F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lockedHeroCtrlList(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			List<HeroItemUIController> lockedHeroCtrlList;
			LuaObject.checkType<List<HeroItemUIController>>(l, 2, out lockedHeroCtrlList);
			heroListUIController.m_lockedHeroCtrlList = lockedHeroCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F513 RID: 128275 RVA: 0x00A3DF4C File Offset: 0x00A3C14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F514 RID: 128276 RVA: 0x00A3DFA4 File Offset: 0x00A3C1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroListUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F515 RID: 128277 RVA: 0x00A3E000 File Offset: 0x00A3C200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroListUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F516 RID: 128278 RVA: 0x00A3E058 File Offset: 0x00A3C258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroListUIController heroListUIController = (HeroListUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroListUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F517 RID: 128279 RVA: 0x00A3E0B4 File Offset: 0x00A3C2B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroListUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.UpdateViewInHeroList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.SetHeroPowerValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.ResetHeroPowerValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.StopAllCoroutineInHeroList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.SetHeroCharSkinPreview);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.SetCurHeroList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.SetToInitState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.SetToAtLeftState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.ClickHeroByIdForUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.ClickLowLevelHeroForUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.ClickLockedHeroForUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.ShowButtonGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.ResetPanelPos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.InactiveCharWordPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.GetCurHeroList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.HaveHeroCanCompose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.PlayHeroPerformance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.CreateHeroList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.Co_SetPowerValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnHeroFragmentSearchButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnBreakButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.PlayBreakButtonClickEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.ComposeLockedHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.CloseComposeHeroPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.ConfirmComposeHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnComposeHeroSucceed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.PlayHeroGetEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnExtractionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnEquipmentsButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnHeroJobUpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnHeroCharSkinChangeButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.HeroCharUIController_OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.GetHeroItemPosInList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.SetSortTypeButtonAndToggles);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.ResetData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnFilterButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.ResetScrollViewPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnDetailButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnSummonButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.PlaySummonButtonClickEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnCommentButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnAddHeroButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnSpeedUpHeroButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnResetHeroButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnLevelToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnStarLevelToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnRankToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnPowerToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.OnSortButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.CloseSortTypesPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnFilter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnFilter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnHeroCharClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnHeroCharClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnHeroBreak);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnHeroBreak);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnAddHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnAddHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnComposeHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnComposeHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnSortToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnSortToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnShowGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnShowGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnInitHeroList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnInitHeroList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnUpdateViewInListAndDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnUpdateViewInListAndDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnHeroCharSkinChangeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnHeroCharSkinChangeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__callDele_EventOnGoToMemoryExtractionStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.__clearDele_EventOnGoToMemoryExtractionStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache63);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache64, true);
		string name2 = "EventOnFilter";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnFilter);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache65, true);
		string name3 = "EventOnDetail";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnDetail);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache66, true);
		string name4 = "EventOnComment";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnComment);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache67, true);
		string name5 = "EventOnEquipment";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnEquipment);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache68, true);
		string name6 = "EventOnJob";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnJob);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache69, true);
		string name7 = "EventOnHeroCharClick";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnHeroCharClick);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6A, true);
		string name8 = "EventOnHeroBreak";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnHeroBreak);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6B, true);
		string name9 = "EventOnAddHero";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnAddHero);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6C, true);
		string name10 = "EventOnComposeHero";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnComposeHero);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6D, true);
		string name11 = "EventOnSortToggleClick";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnSortToggleClick);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6E, true);
		string name12 = "EventOnShowGetPath";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnShowGetPath);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache6F, true);
		string name13 = "EventOnInitHeroList";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnInitHeroList);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache70, true);
		string name14 = "EventOnUpdateViewInListAndDetail";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnUpdateViewInListAndDetail);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache71, true);
		string name15 = "EventOnHeroCharSkinChangeButtonClick";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnHeroCharSkinChangeButtonClick);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache72, true);
		string name16 = "EventOnGoToMemoryExtractionStore";
		LuaCSFunction get16 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_EventOnGoToMemoryExtractionStore);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache73, true);
		string name17 = "m_scrollViewUnlockedHeroContent";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_scrollViewUnlockedHeroContent);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_scrollViewUnlockedHeroContent);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache75, true);
		string name18 = "m_scrollViewLockedHeroContent";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_scrollViewLockedHeroContent);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_scrollViewLockedHeroContent);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache77, true);
		string name19 = "m_scrollView";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_scrollView);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_scrollView);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache79, true);
		string name20 = "m_cvText";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_cvText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_cvText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7B, true);
		string name21 = "m_commentButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_commentButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_commentButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7D, true);
		string name22 = "m_detailButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_detailButton);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_detailButton);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache7F, true);
		string name23 = "m_detailButtonRedPointImage";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_detailButtonRedPointImage);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_detailButtonRedPointImage);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache81, true);
		string name24 = "m_summonButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_summonButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_summonButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache83, true);
		string name25 = "m_summonButtonPressEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_summonButtonPressEffect);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_summonButtonPressEffect);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache85, true);
		string name26 = "m_summonButtonReadyEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_summonButtonReadyEffect);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_summonButtonReadyEffect);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache87, true);
		string name27 = "m_filterButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_filterButton);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_filterButton);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache89, true);
		string name28 = "m_addheroButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_addheroButton);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_addheroButton);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8B, true);
		string name29 = "m_speedUpHeroButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_speedUpHeroButton);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_speedUpHeroButton);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8D, true);
		string name30 = "m_resetHeroButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_resetHeroButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_resetHeroButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache8F, true);
		string name31 = "m_heroIdInputField";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroIdInputField);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroIdInputField);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache91, true);
		string name32 = "m_composeConfirmPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_composeConfirmPanel);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_composeConfirmPanel);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache93, true);
		string name33 = "m_composeCostText";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_composeCostText);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_composeCostText);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache95, true);
		string name34 = "m_composeCancelButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_composeCancelButton);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_composeCancelButton);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache97, true);
		string name35 = "m_composeConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_composeConfirmButton);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_composeConfirmButton);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache99, true);
		string name36 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_returnButton);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9B, true);
		string name37 = "m_heroNameTextCh";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroNameTextCh);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroNameTextCh);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9D, true);
		string name38 = "m_heroNameTextEn";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroNameTextEn);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroNameTextEn);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cache9F, true);
		string name39 = "m_heroRankImage";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroRankImage);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroRankImage);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA1, true);
		string name40 = "m_heroStar";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroStar);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroStar);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA3, true);
		string name41 = "m_charGameObjectRoot";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_charGameObjectRoot);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_charGameObjectRoot);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA5, true);
		string name42 = "m_charWordGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_charWordGameObject);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_charWordGameObject);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA7, true);
		string name43 = "m_charSummonEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_charSummonEffect);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_charSummonEffect);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheA9, true);
		string name44 = "m_heroInfoPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroInfoPanel);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroInfoPanel);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAB, true);
		string name45 = "m_heroCharSkinChangeButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroCharSkinChangeButton);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroCharSkinChangeButton);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAD, true);
		string name46 = "m_heroJobUpButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroJobUpButton);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroJobUpButton);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheAF, true);
		string name47 = "m_heroEquipmentsButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroEquipmentsButton);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroEquipmentsButton);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB1, true);
		string name48 = "m_heroEquipmentsContent";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroEquipmentsContent);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroEquipmentsContent);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB3, true);
		string name49 = "m_heroEquipmentsRedPointImage";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroEquipmentsRedPointImage);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroEquipmentsRedPointImage);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB5, true);
		string name50 = "m_powerValueStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_powerValueStateCtrl);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_powerValueStateCtrl);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB7, true);
		string name51 = "m_powerValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_powerValueText);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_powerValueText);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheB9, true);
		string name52 = "m_powerArrowGo";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_powerArrowGo);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_powerArrowGo);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBB, true);
		string name53 = "m_breakButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_breakButton);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_breakButton);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBD, true);
		string name54 = "m_breakButtonReadyEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_breakButtonReadyEffect);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_breakButtonReadyEffect);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheBF, true);
		string name55 = "m_breakButtonPressEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_breakButtonPressEffect);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_breakButtonPressEffect);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC1, true);
		string name56 = "m_breakAddBtn";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_breakAddBtn);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_breakAddBtn);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC3, true);
		string name57 = "m_breakNumText";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_breakNumText);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_breakNumText);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC5, true);
		string name58 = "m_breakIconImage";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_breakIconImage);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC6;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_breakIconImage);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC7, true);
		string name59 = "m_extractionButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_extractionButton);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC8;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_extractionButton);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheC9, true);
		string name60 = "m_extractionTipsStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_extractionTipsStateCtrl);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCA;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_extractionTipsStateCtrl);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCB, true);
		string name61 = "m_sortButton";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_sortButton);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCC;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_sortButton);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCD, true);
		string name62 = "m_sortButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_sortButtonStateCtrl);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCE;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_sortButtonStateCtrl);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheCF, true);
		string name63 = "m_sortTypesPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_sortTypesPanelStateCtrl);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD0;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_sortTypesPanelStateCtrl);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD1, true);
		string name64 = "m_sortTypesReturnBgImage";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_sortTypesReturnBgImage);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD2;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_sortTypesReturnBgImage);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD3, true);
		string name65 = "m_sortTypesLevelToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_sortTypesLevelToggle);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD4;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_sortTypesLevelToggle);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD5, true);
		string name66 = "m_sortTypesStarToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_sortTypesStarToggle);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD6;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_sortTypesStarToggle);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD7, true);
		string name67 = "m_sortTypesRarityToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_sortTypesRarityToggle);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD8;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_sortTypesRarityToggle);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheD9, true);
		string name68 = "m_sortTypesPowerToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_sortTypesPowerToggle);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDA;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_sortTypesPowerToggle);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDB, true);
		string name69 = "LevelType";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_LevelType);
		}
		LuaObject.addMember(l, name69, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDC, null, false);
		string name70 = "StarLevelType";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_StarLevelType);
		}
		LuaObject.addMember(l, name70, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDD, null, false);
		string name71 = "RankType";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_RankType);
		}
		LuaObject.addMember(l, name71, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDE, null, false);
		string name72 = "PowerType";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_PowerType);
		}
		LuaObject.addMember(l, name72, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheDF, null, false);
		string name73 = "m_isUnLockHero";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_isUnLockHero);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE0;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_isUnLockHero);
		}
		LuaObject.addMember(l, name73, get69, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE1, true);
		string name74 = "m_heroPowerValue";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroPowerValue);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE2;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroPowerValue);
		}
		LuaObject.addMember(l, name74, get70, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE3, true);
		string name75 = "m_curHeroNeedFragmentCount";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_curHeroNeedFragmentCount);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE4;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_curHeroNeedFragmentCount);
		}
		LuaObject.addMember(l, name75, get71, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE5, true);
		string name76 = "m_curSelectedHeroIndex";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_curSelectedHeroIndex);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE6;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_curSelectedHeroIndex);
		}
		LuaObject.addMember(l, name76, get72, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE7, true);
		string name77 = "m_curSeletedHeroList";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_curSeletedHeroList);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE8;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_curSeletedHeroList);
		}
		LuaObject.addMember(l, name77, get73, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheE9, true);
		string name78 = "m_heroCharUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_heroCharUIController);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEA;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_heroCharUIController);
		}
		LuaObject.addMember(l, name78, get74, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEB, true);
		string name79 = "m_unLockedHeroList";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_unLockedHeroList);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEC;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_unLockedHeroList);
		}
		LuaObject.addMember(l, name79, get75, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheED, true);
		string name80 = "m_lockedHeroList";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_lockedHeroList);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEE;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_lockedHeroList);
		}
		LuaObject.addMember(l, name80, get76, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheEF, true);
		string name81 = "m_unLockedHeroCtrlList";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_unLockedHeroCtrlList);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF0;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_unLockedHeroCtrlList);
		}
		LuaObject.addMember(l, name81, get77, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF1, true);
		string name82 = "m_lockedHeroCtrlList";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_lockedHeroCtrlList);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF2;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_lockedHeroCtrlList);
		}
		LuaObject.addMember(l, name82, get78, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF3, true);
		string name83 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_playerContext);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF4;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name83, get79, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF5, true);
		string name84 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.get_m_configDataLoader);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF6;
		if (Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroListUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name84, get80, Lua_BlackJack_ProjectL_UI_HeroListUIController.<>f__mg$cacheF7, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroListUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401545D RID: 87133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401545E RID: 87134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401545F RID: 87135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015460 RID: 87136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015461 RID: 87137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015462 RID: 87138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015463 RID: 87139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015464 RID: 87140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015465 RID: 87141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015466 RID: 87142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015467 RID: 87143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015468 RID: 87144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015469 RID: 87145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401546A RID: 87146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401546B RID: 87147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401546C RID: 87148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401546D RID: 87149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401546E RID: 87150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401546F RID: 87151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015470 RID: 87152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015471 RID: 87153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015472 RID: 87154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015473 RID: 87155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015474 RID: 87156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015475 RID: 87157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015476 RID: 87158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015477 RID: 87159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015478 RID: 87160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015479 RID: 87161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401547A RID: 87162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401547B RID: 87163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401547C RID: 87164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401547D RID: 87165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401547E RID: 87166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401547F RID: 87167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015480 RID: 87168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015481 RID: 87169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015482 RID: 87170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015483 RID: 87171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015484 RID: 87172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015485 RID: 87173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015486 RID: 87174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015487 RID: 87175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015488 RID: 87176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015489 RID: 87177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401548A RID: 87178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401548B RID: 87179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401548C RID: 87180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401548D RID: 87181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401548E RID: 87182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401548F RID: 87183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015490 RID: 87184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015491 RID: 87185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015492 RID: 87186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015493 RID: 87187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015494 RID: 87188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015495 RID: 87189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04015496 RID: 87190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015497 RID: 87191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015498 RID: 87192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015499 RID: 87193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401549A RID: 87194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401549B RID: 87195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401549C RID: 87196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401549D RID: 87197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401549E RID: 87198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401549F RID: 87199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040154A0 RID: 87200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040154A1 RID: 87201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040154A2 RID: 87202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040154A3 RID: 87203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040154A4 RID: 87204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040154A5 RID: 87205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040154A6 RID: 87206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040154A7 RID: 87207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040154A8 RID: 87208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040154A9 RID: 87209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040154AA RID: 87210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040154AB RID: 87211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040154AC RID: 87212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040154AD RID: 87213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040154AE RID: 87214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040154AF RID: 87215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040154B0 RID: 87216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040154B1 RID: 87217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040154B2 RID: 87218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040154B3 RID: 87219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040154B4 RID: 87220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040154B5 RID: 87221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040154B6 RID: 87222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040154B7 RID: 87223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040154B8 RID: 87224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040154B9 RID: 87225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040154BA RID: 87226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040154BB RID: 87227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040154BC RID: 87228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040154BD RID: 87229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040154BE RID: 87230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040154BF RID: 87231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040154C0 RID: 87232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040154C1 RID: 87233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040154C2 RID: 87234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040154C3 RID: 87235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040154C4 RID: 87236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040154C5 RID: 87237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040154C6 RID: 87238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040154C7 RID: 87239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040154C8 RID: 87240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040154C9 RID: 87241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040154CA RID: 87242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040154CB RID: 87243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040154CC RID: 87244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040154CD RID: 87245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040154CE RID: 87246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040154CF RID: 87247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040154D0 RID: 87248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040154D1 RID: 87249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040154D2 RID: 87250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040154D3 RID: 87251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040154D4 RID: 87252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040154D5 RID: 87253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040154D6 RID: 87254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040154D7 RID: 87255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040154D8 RID: 87256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040154D9 RID: 87257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040154DA RID: 87258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040154DB RID: 87259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040154DC RID: 87260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040154DD RID: 87261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040154DE RID: 87262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x040154DF RID: 87263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x040154E0 RID: 87264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x040154E1 RID: 87265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x040154E2 RID: 87266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x040154E3 RID: 87267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x040154E4 RID: 87268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x040154E5 RID: 87269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x040154E6 RID: 87270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x040154E7 RID: 87271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x040154E8 RID: 87272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x040154E9 RID: 87273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x040154EA RID: 87274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x040154EB RID: 87275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x040154EC RID: 87276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x040154ED RID: 87277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x040154EE RID: 87278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x040154EF RID: 87279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x040154F0 RID: 87280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x040154F1 RID: 87281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x040154F2 RID: 87282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x040154F3 RID: 87283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x040154F4 RID: 87284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x040154F5 RID: 87285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x040154F6 RID: 87286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x040154F7 RID: 87287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x040154F8 RID: 87288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x040154F9 RID: 87289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x040154FA RID: 87290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x040154FB RID: 87291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x040154FC RID: 87292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x040154FD RID: 87293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x040154FE RID: 87294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x040154FF RID: 87295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04015500 RID: 87296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04015501 RID: 87297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04015502 RID: 87298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04015503 RID: 87299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04015504 RID: 87300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04015505 RID: 87301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04015506 RID: 87302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04015507 RID: 87303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04015508 RID: 87304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04015509 RID: 87305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x0401550A RID: 87306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x0401550B RID: 87307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x0401550C RID: 87308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x0401550D RID: 87309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x0401550E RID: 87310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x0401550F RID: 87311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04015510 RID: 87312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04015511 RID: 87313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04015512 RID: 87314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04015513 RID: 87315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04015514 RID: 87316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x04015515 RID: 87317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x04015516 RID: 87318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x04015517 RID: 87319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x04015518 RID: 87320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x04015519 RID: 87321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x0401551A RID: 87322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x0401551B RID: 87323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x0401551C RID: 87324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x0401551D RID: 87325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x0401551E RID: 87326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x0401551F RID: 87327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04015520 RID: 87328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04015521 RID: 87329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x04015522 RID: 87330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x04015523 RID: 87331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x04015524 RID: 87332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x04015525 RID: 87333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x04015526 RID: 87334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04015527 RID: 87335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x04015528 RID: 87336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x04015529 RID: 87337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x0401552A RID: 87338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x0401552B RID: 87339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x0401552C RID: 87340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x0401552D RID: 87341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x0401552E RID: 87342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x0401552F RID: 87343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04015530 RID: 87344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x04015531 RID: 87345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x04015532 RID: 87346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04015533 RID: 87347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x04015534 RID: 87348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x04015535 RID: 87349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04015536 RID: 87350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04015537 RID: 87351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x04015538 RID: 87352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x04015539 RID: 87353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x0401553A RID: 87354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x0401553B RID: 87355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x0401553C RID: 87356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x0401553D RID: 87357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x0401553E RID: 87358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x0401553F RID: 87359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x04015540 RID: 87360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x04015541 RID: 87361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x04015542 RID: 87362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x04015543 RID: 87363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x04015544 RID: 87364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x04015545 RID: 87365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x04015546 RID: 87366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x04015547 RID: 87367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x04015548 RID: 87368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x04015549 RID: 87369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x0401554A RID: 87370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x0401554B RID: 87371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x0401554C RID: 87372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x0401554D RID: 87373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x0401554E RID: 87374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x0401554F RID: 87375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x04015550 RID: 87376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x04015551 RID: 87377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x04015552 RID: 87378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x04015553 RID: 87379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x04015554 RID: 87380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;
}
