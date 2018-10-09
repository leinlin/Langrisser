using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001442 RID: 5186
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FettersUITask : LuaObject
{
	// Token: 0x0601DE01 RID: 122369 RVA: 0x00989414 File Offset: 0x00987614
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			FettersUITask o = new FettersUITask(name);
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

	// Token: 0x0601DE02 RID: 122370 RVA: 0x00989468 File Offset: 0x00987668
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = fettersUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601DE03 RID: 122371 RVA: 0x009894D0 File Offset: 0x009876D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = fettersUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601DE04 RID: 122372 RVA: 0x00989538 File Offset: 0x00987738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE05 RID: 122373 RVA: 0x0098958C File Offset: 0x0098778C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveUIStateToIntent(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.SaveUIStateToIntent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE06 RID: 122374 RVA: 0x009895E0 File Offset: 0x009877E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetUIStateFromIntent(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			UIIntent uiIntent;
			LuaObject.checkType<UIIntent>(l, 2, out uiIntent);
			fettersUITask.m_luaExportHelper.GetUIStateFromIntent(uiIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE07 RID: 122375 RVA: 0x0098963C File Offset: 0x0098783C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			bool b = fettersUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601DE08 RID: 122376 RVA: 0x00989698 File Offset: 0x00987898
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE09 RID: 122377 RVA: 0x009896EC File Offset: 0x009878EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			bool b = fettersUITask.m_luaExportHelper.IsNeedLoadStaticRes();
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

	// Token: 0x0601DE0A RID: 122378 RVA: 0x00989748 File Offset: 0x00987948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAllStaticResDescForLoad(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			List<UITaskBase.LayerDesc> o = fettersUITask.m_luaExportHelper.CollectAllStaticResDescForLoad();
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

	// Token: 0x0601DE0B RID: 122379 RVA: 0x009897A4 File Offset: 0x009879A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE0C RID: 122380 RVA: 0x009897F8 File Offset: 0x009879F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE0D RID: 122381 RVA: 0x0098984C File Offset: 0x00987A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE0E RID: 122382 RVA: 0x009898A0 File Offset: 0x00987AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE0F RID: 122383 RVA: 0x009898F4 File Offset: 0x00987AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PushAndPopLayerByState(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.PushAndPopLayerByState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE10 RID: 122384 RVA: 0x00989948 File Offset: 0x00987B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.FettersUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE11 RID: 122385 RVA: 0x0098999C File Offset: 0x00987B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.FettersUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE12 RID: 122386 RVA: 0x009899F0 File Offset: 0x00987BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersUIController_OnListItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersUITask.m_luaExportHelper.FettersUIController_OnListItemClick(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE13 RID: 122387 RVA: 0x00989A4C File Offset: 0x00987C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersUIController_OnInformationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersUITask.m_luaExportHelper.FettersUIController_OnInformationButtonClick(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE14 RID: 122388 RVA: 0x00989AA8 File Offset: 0x00987CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersUIController_OnFettersButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersUITask.m_luaExportHelper.FettersUIController_OnFettersButtonClick(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE15 RID: 122389 RVA: 0x00989B04 File Offset: 0x00987D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersFavorabilityUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.FettersFavorabilityUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE16 RID: 122390 RVA: 0x00989B58 File Offset: 0x00987D58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FettersFavorabilityUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.FettersFavorabilityUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE17 RID: 122391 RVA: 0x00989BAC File Offset: 0x00987DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersFavorabilityUIController_OnInformationButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersUITask.m_luaExportHelper.FettersFavorabilityUIController_OnInformationButtonClick(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE18 RID: 122392 RVA: 0x00989C08 File Offset: 0x00987E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersFavorabilityUIController_OnGiftButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersUITask.m_luaExportHelper.FettersFavorabilityUIController_OnGiftButtonClick(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE19 RID: 122393 RVA: 0x00989C64 File Offset: 0x00987E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersFavorabilityUIController_OnUseGift(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int itemId;
			LuaObject.checkType(l, 3, out itemId);
			int count;
			LuaObject.checkType(l, 4, out count);
			Action<List<Goods>> onsucceed;
			LuaObject.checkDelegate<Action<List<Goods>>>(l, 5, out onsucceed);
			fettersUITask.m_luaExportHelper.FettersFavorabilityUIController_OnUseGift(goodsType, itemId, count, onsucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE1A RID: 122394 RVA: 0x00989CE8 File Offset: 0x00987EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersFavorabilityUIController_GotoBagFullUITask(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.FettersFavorabilityUIController_GotoBagFullUITask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE1B RID: 122395 RVA: 0x00989D3C File Offset: 0x00987F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersFavorabilityUIController_OnHeroInteract(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.FettersFavorabilityUIController_OnHeroInteract();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE1C RID: 122396 RVA: 0x00989D90 File Offset: 0x00987F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersFavorabilityUIController_OnMemoryButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersUITask.m_luaExportHelper.FettersFavorabilityUIController_OnMemoryButtonClick(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE1D RID: 122397 RVA: 0x00989DEC File Offset: 0x00987FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersFavorabilityUIController_OnFettersButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersUITask.m_luaExportHelper.FettersFavorabilityUIController_OnFettersButtonClick(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE1E RID: 122398 RVA: 0x00989E48 File Offset: 0x00988048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersInformationUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.FettersInformationUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE1F RID: 122399 RVA: 0x00989E9C File Offset: 0x0098809C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersInformationUIController_OnVoiceItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			int heroPerformanceId;
			LuaObject.checkType(l, 2, out heroPerformanceId);
			fettersUITask.m_luaExportHelper.FettersInformationUIController_OnVoiceItemClick(heroPerformanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE20 RID: 122400 RVA: 0x00989EF8 File Offset: 0x009880F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersGiftUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.FettersGiftUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE21 RID: 122401 RVA: 0x00989F4C File Offset: 0x0098814C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersConfessionUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.FettersConfessionUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE22 RID: 122402 RVA: 0x00989FA0 File Offset: 0x009881A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersConfessionUIControlle_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.FettersConfessionUIControlle_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE23 RID: 122403 RVA: 0x00989FF4 File Offset: 0x009881F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersConfessionUIController_OnAddGold(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.FettersConfessionUIController_OnAddGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE24 RID: 122404 RVA: 0x0098A048 File Offset: 0x00988248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersConfessionUIController_OnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.FettersConfessionUIController_OnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE25 RID: 122405 RVA: 0x0098A09C File Offset: 0x0098829C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersConfessionUIController_OnSkillUnlockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			Action<List<Goods>> onSucceed;
			LuaObject.checkDelegate<Action<List<Goods>>>(l, 4, out onSucceed);
			fettersUITask.m_luaExportHelper.FettersConfessionUIController_OnSkillUnlockButtonClick(heroId, fetterId, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE26 RID: 122406 RVA: 0x0098A114 File Offset: 0x00988314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersConfessionUIController_OnEvolutionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 4, out onSucceed);
			fettersUITask.m_luaExportHelper.FettersConfessionUIController_OnEvolutionButtonClick(heroId, fetterId, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE27 RID: 122407 RVA: 0x0098A18C File Offset: 0x0098838C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersConfessionUIController_OnHeroFetterConfess(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			fettersUITask.m_luaExportHelper.FettersConfessionUIController_OnHeroFetterConfess(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE28 RID: 122408 RVA: 0x0098A1E8 File Offset: 0x009883E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersConfessionUIController_OnEvolutionMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int needCount;
			LuaObject.checkType(l, 4, out needCount);
			fettersUITask.m_luaExportHelper.FettersConfessionUIController_OnEvolutionMaterialClick(goodsType, goodsId, needCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE29 RID: 122409 RVA: 0x0098A260 File Offset: 0x00988460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FettersConfessionUIController_OnGotoGetPath(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			GetPathData getPath;
			LuaObject.checkType<GetPathData>(l, 2, out getPath);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 3, out needGoods);
			fettersUITask.m_luaExportHelper.FettersConfessionUIController_OnGotoGetPath(getPath, needGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE2A RID: 122410 RVA: 0x0098A2CC File Offset: 0x009884CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE2B RID: 122411 RVA: 0x0098A320 File Offset: 0x00988520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateTouchTimeText(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.UpdateTouchTimeText();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE2C RID: 122412 RVA: 0x0098A374 File Offset: 0x00988574
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = fettersUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601DE2D RID: 122413 RVA: 0x0098A3DC File Offset: 0x009885DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE2E RID: 122414 RVA: 0x0098A430 File Offset: 0x00988630
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE2F RID: 122415 RVA: 0x0098A484 File Offset: 0x00988684
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = fettersUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601DE30 RID: 122416 RVA: 0x0098A4EC File Offset: 0x009886EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = fettersUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601DE31 RID: 122417 RVA: 0x0098A554 File Offset: 0x00988754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			fettersUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE32 RID: 122418 RVA: 0x0098A5C0 File Offset: 0x009887C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			bool b = fettersUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601DE33 RID: 122419 RVA: 0x0098A61C File Offset: 0x0098881C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			List<string> o = fettersUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601DE34 RID: 122420 RVA: 0x0098A678 File Offset: 0x00988878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE35 RID: 122421 RVA: 0x0098A6CC File Offset: 0x009888CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE36 RID: 122422 RVA: 0x0098A720 File Offset: 0x00988920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE37 RID: 122423 RVA: 0x0098A774 File Offset: 0x00988974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE38 RID: 122424 RVA: 0x0098A7C8 File Offset: 0x009889C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE39 RID: 122425 RVA: 0x0098A81C File Offset: 0x00988A1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			fettersUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE3A RID: 122426 RVA: 0x0098A878 File Offset: 0x00988A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			fettersUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE3B RID: 122427 RVA: 0x0098A8D4 File Offset: 0x00988AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			fettersUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE3C RID: 122428 RVA: 0x0098A930 File Offset: 0x00988B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			fettersUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE3D RID: 122429 RVA: 0x0098A98C File Offset: 0x00988B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			bool b = fettersUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601DE3E RID: 122430 RVA: 0x0098A9E8 File Offset: 0x00988BE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			bool b = fettersUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601DE3F RID: 122431 RVA: 0x0098AA44 File Offset: 0x00988C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			bool b = fettersUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601DE40 RID: 122432 RVA: 0x0098AAA0 File Offset: 0x00988CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			UITaskBase o = fettersUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601DE41 RID: 122433 RVA: 0x0098AAFC File Offset: 0x00988CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE42 RID: 122434 RVA: 0x0098AB50 File Offset: 0x00988D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			fettersUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE43 RID: 122435 RVA: 0x0098ABA4 File Offset: 0x00988DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartHeroDungeon(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			Hero arg;
			LuaObject.checkType<Hero>(l, 2, out arg);
			UIIntent arg2;
			LuaObject.checkType<UIIntent>(l, 3, out arg2);
			fettersUITask.m_luaExportHelper.__callDele_EventOnStartHeroDungeon(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE44 RID: 122436 RVA: 0x0098AC10 File Offset: 0x00988E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartHeroDungeon(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			Hero arg;
			LuaObject.checkType<Hero>(l, 2, out arg);
			UIIntent arg2;
			LuaObject.checkType<UIIntent>(l, 3, out arg2);
			fettersUITask.m_luaExportHelper.__clearDele_EventOnStartHeroDungeon(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE45 RID: 122437 RVA: 0x0098AC7C File Offset: 0x00988E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE46 RID: 122438 RVA: 0x0098ACD4 File Offset: 0x00988ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			fettersUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE47 RID: 122439 RVA: 0x0098AD30 File Offset: 0x00988F30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE48 RID: 122440 RVA: 0x0098AD88 File Offset: 0x00988F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			fettersUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE49 RID: 122441 RVA: 0x0098ADE4 File Offset: 0x00988FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fettersUIController(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_fettersUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE4A RID: 122442 RVA: 0x0098AE3C File Offset: 0x0098903C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fettersUIController(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			FettersUIController fettersUIController;
			LuaObject.checkType<FettersUIController>(l, 2, out fettersUIController);
			fettersUITask.m_luaExportHelper.m_fettersUIController = fettersUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE4B RID: 122443 RVA: 0x0098AE98 File Offset: 0x00989098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fettersFavorabilityUIController(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_fettersFavorabilityUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE4C RID: 122444 RVA: 0x0098AEF0 File Offset: 0x009890F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fettersFavorabilityUIController(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			FettersFavorabilityUIController fettersFavorabilityUIController;
			LuaObject.checkType<FettersFavorabilityUIController>(l, 2, out fettersFavorabilityUIController);
			fettersUITask.m_luaExportHelper.m_fettersFavorabilityUIController = fettersFavorabilityUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE4D RID: 122445 RVA: 0x0098AF4C File Offset: 0x0098914C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_fettersInformationUIController(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_fettersInformationUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE4E RID: 122446 RVA: 0x0098AFA4 File Offset: 0x009891A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fettersInformationUIController(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			FettersInformationUIController fettersInformationUIController;
			LuaObject.checkType<FettersInformationUIController>(l, 2, out fettersInformationUIController);
			fettersUITask.m_luaExportHelper.m_fettersInformationUIController = fettersInformationUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE4F RID: 122447 RVA: 0x0098B000 File Offset: 0x00989200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fettersConfessionUIController(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_fettersConfessionUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE50 RID: 122448 RVA: 0x0098B058 File Offset: 0x00989258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fettersConfessionUIController(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			FettersConfessionUIController fettersConfessionUIController;
			LuaObject.checkType<FettersConfessionUIController>(l, 2, out fettersConfessionUIController);
			fettersUITask.m_luaExportHelper.m_fettersConfessionUIController = fettersConfessionUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE51 RID: 122449 RVA: 0x0098B0B4 File Offset: 0x009892B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MatthewMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Matthew");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE52 RID: 122450 RVA: 0x0098B0FC File Offset: 0x009892FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FavorabilityMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Favorability");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE53 RID: 122451 RVA: 0x0098B144 File Offset: 0x00989344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InformationMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Information");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE54 RID: 122452 RVA: 0x0098B18C File Offset: 0x0098938C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GiftMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Gift");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE55 RID: 122453 RVA: 0x0098B1D4 File Offset: 0x009893D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfessionMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Confession");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE56 RID: 122454 RVA: 0x0098B21C File Offset: 0x0098941C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curMode(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_curMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE57 RID: 122455 RVA: 0x0098B274 File Offset: 0x00989474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curMode(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			string curMode;
			LuaObject.checkType(l, 2, out curMode);
			fettersUITask.m_luaExportHelper.m_curMode = curMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE58 RID: 122456 RVA: 0x0098B2D0 File Offset: 0x009894D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastMode(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_lastMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE59 RID: 122457 RVA: 0x0098B328 File Offset: 0x00989528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastMode(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			string lastMode;
			LuaObject.checkType(l, 2, out lastMode);
			fettersUITask.m_luaExportHelper.m_lastMode = lastMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE5A RID: 122458 RVA: 0x0098B384 File Offset: 0x00989584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curLayerDescIndex(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_curLayerDescIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE5B RID: 122459 RVA: 0x0098B3DC File Offset: 0x009895DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curLayerDescIndex(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			int curLayerDescIndex;
			LuaObject.checkType(l, 2, out curLayerDescIndex);
			fettersUITask.m_luaExportHelper.m_curLayerDescIndex = curLayerDescIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE5C RID: 122460 RVA: 0x0098B438 File Offset: 0x00989638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE5D RID: 122461 RVA: 0x0098B490 File Offset: 0x00989690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersUITask.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE5E RID: 122462 RVA: 0x0098B4EC File Offset: 0x009896EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastHeroId(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_lastHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE5F RID: 122463 RVA: 0x0098B544 File Offset: 0x00989744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastHeroId(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			int lastHeroId;
			LuaObject.checkType(l, 2, out lastHeroId);
			fettersUITask.m_luaExportHelper.m_lastHeroId = lastHeroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE60 RID: 122464 RVA: 0x0098B5A0 File Offset: 0x009897A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE61 RID: 122465 RVA: 0x0098B5F8 File Offset: 0x009897F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			fettersUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE62 RID: 122466 RVA: 0x0098B654 File Offset: 0x00989854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE63 RID: 122467 RVA: 0x0098B6AC File Offset: 0x009898AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			fettersUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE64 RID: 122468 RVA: 0x0098B708 File Offset: 0x00989908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_nowSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE65 RID: 122469 RVA: 0x0098B760 File Offset: 0x00989960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			int nowSeconds;
			LuaObject.checkType(l, 2, out nowSeconds);
			fettersUITask.m_luaExportHelper.m_nowSeconds = nowSeconds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE66 RID: 122470 RVA: 0x0098B7BC File Offset: 0x009899BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartHeroDungeon(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			Action<Hero, UIIntent> value;
			int num = LuaObject.checkDelegate<Action<Hero, UIIntent>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersUITask.EventOnStartHeroDungeon += value;
				}
				else if (num == 2)
				{
					fettersUITask.EventOnStartHeroDungeon -= value;
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

	// Token: 0x0601DE67 RID: 122471 RVA: 0x0098B83C File Offset: 0x00989A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNeedShowFadeIn(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.m_isNeedShowFadeIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE68 RID: 122472 RVA: 0x0098B894 File Offset: 0x00989A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNeedShowFadeIn(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			bool isNeedShowFadeIn;
			LuaObject.checkType(l, 2, out isNeedShowFadeIn);
			fettersUITask.m_luaExportHelper.m_isNeedShowFadeIn = isNeedShowFadeIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE69 RID: 122473 RVA: 0x0098B8F0 File Offset: 0x00989AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE6A RID: 122474 RVA: 0x0098B948 File Offset: 0x00989B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			FettersUITask fettersUITask = (FettersUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE6B RID: 122475 RVA: 0x0098B9A0 File Offset: 0x00989BA0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FettersUITask");
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.SaveUIStateToIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.GetUIStateFromIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.IsNeedLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.CollectAllStaticResDescForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.PushAndPopLayerByState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersUIController_OnListItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersUIController_OnInformationButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersUIController_OnFettersButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersFavorabilityUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersFavorabilityUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersFavorabilityUIController_OnInformationButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersFavorabilityUIController_OnGiftButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersFavorabilityUIController_OnUseGift);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersFavorabilityUIController_GotoBagFullUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersFavorabilityUIController_OnHeroInteract);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersFavorabilityUIController_OnMemoryButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersFavorabilityUIController_OnFettersButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersInformationUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersInformationUIController_OnVoiceItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersGiftUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersConfessionUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersConfessionUIControlle_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersConfessionUIController_OnAddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersConfessionUIController_OnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersConfessionUIController_OnSkillUnlockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersConfessionUIController_OnEvolutionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersConfessionUIController_OnHeroFetterConfess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersConfessionUIController_OnEvolutionMaterialClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.FettersConfessionUIController_OnGotoGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.UpdateTouchTimeText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__callDele_EventOnStartHeroDungeon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.__clearDele_EventOnStartHeroDungeon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache42);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache44, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache46, true);
		string name3 = "m_fettersUIController";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_fettersUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_fettersUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache48, true);
		string name4 = "m_fettersFavorabilityUIController";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_fettersFavorabilityUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_fettersFavorabilityUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4A, true);
		string name5 = "m_fettersInformationUIController";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_fettersInformationUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_fettersInformationUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4C, true);
		string name6 = "m_fettersConfessionUIController";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_fettersConfessionUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_fettersConfessionUIController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4E, true);
		string name7 = "MatthewMode";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_MatthewMode);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache4F, null, false);
		string name8 = "FavorabilityMode";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_FavorabilityMode);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache50, null, false);
		string name9 = "InformationMode";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_InformationMode);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache51, null, false);
		string name10 = "GiftMode";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_GiftMode);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache52, null, false);
		string name11 = "ConfessionMode";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_ConfessionMode);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache53, null, false);
		string name12 = "m_curMode";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_curMode);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_curMode);
		}
		LuaObject.addMember(l, name12, get7, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache55, true);
		string name13 = "m_lastMode";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_lastMode);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_lastMode);
		}
		LuaObject.addMember(l, name13, get8, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache57, true);
		string name14 = "m_curLayerDescIndex";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_curLayerDescIndex);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_curLayerDescIndex);
		}
		LuaObject.addMember(l, name14, get9, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache59, true);
		string name15 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_hero);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_hero);
		}
		LuaObject.addMember(l, name15, get10, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5B, true);
		string name16 = "m_lastHeroId";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_lastHeroId);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_lastHeroId);
		}
		LuaObject.addMember(l, name16, get11, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5D, true);
		string name17 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_configDataLoader);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name17, get12, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache5F, true);
		string name18 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_playerContext);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name18, get13, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache61, true);
		string name19 = "m_nowSeconds";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_nowSeconds);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_nowSeconds);
		}
		LuaObject.addMember(l, name19, get14, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache63, true);
		string name20 = "EventOnStartHeroDungeon";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_EventOnStartHeroDungeon);
		}
		LuaObject.addMember(l, name20, get15, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache64, true);
		string name21 = "m_isNeedShowFadeIn";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_m_isNeedShowFadeIn);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.set_m_isNeedShowFadeIn);
		}
		LuaObject.addMember(l, name21, get16, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache66, true);
		string name22 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache67, null, true);
		string name23 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache68, null, true);
		if (Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FettersUITask.<>f__mg$cache69, typeof(FettersUITask), typeof(UITask));
	}

	// Token: 0x04013F5F RID: 81759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013F60 RID: 81760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013F61 RID: 81761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013F62 RID: 81762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013F63 RID: 81763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013F64 RID: 81764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013F65 RID: 81765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013F66 RID: 81766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013F67 RID: 81767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013F68 RID: 81768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013F69 RID: 81769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013F6A RID: 81770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013F6B RID: 81771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013F6C RID: 81772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013F6D RID: 81773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013F6E RID: 81774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013F6F RID: 81775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013F70 RID: 81776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013F71 RID: 81777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013F72 RID: 81778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013F73 RID: 81779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013F74 RID: 81780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013F75 RID: 81781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013F76 RID: 81782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013F77 RID: 81783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013F78 RID: 81784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013F79 RID: 81785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013F7A RID: 81786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013F7B RID: 81787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013F7C RID: 81788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013F7D RID: 81789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013F7E RID: 81790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013F7F RID: 81791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013F80 RID: 81792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013F81 RID: 81793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013F82 RID: 81794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013F83 RID: 81795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013F84 RID: 81796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013F85 RID: 81797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013F86 RID: 81798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013F87 RID: 81799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013F88 RID: 81800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013F89 RID: 81801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013F8A RID: 81802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013F8B RID: 81803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013F8C RID: 81804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013F8D RID: 81805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013F8E RID: 81806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013F8F RID: 81807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013F90 RID: 81808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013F91 RID: 81809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013F92 RID: 81810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013F93 RID: 81811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013F94 RID: 81812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013F95 RID: 81813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013F96 RID: 81814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04013F97 RID: 81815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04013F98 RID: 81816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04013F99 RID: 81817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04013F9A RID: 81818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04013F9B RID: 81819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04013F9C RID: 81820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04013F9D RID: 81821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013F9E RID: 81822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04013F9F RID: 81823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04013FA0 RID: 81824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013FA1 RID: 81825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04013FA2 RID: 81826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04013FA3 RID: 81827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04013FA4 RID: 81828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013FA5 RID: 81829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04013FA6 RID: 81830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04013FA7 RID: 81831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04013FA8 RID: 81832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04013FA9 RID: 81833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04013FAA RID: 81834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04013FAB RID: 81835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04013FAC RID: 81836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04013FAD RID: 81837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04013FAE RID: 81838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04013FAF RID: 81839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04013FB0 RID: 81840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04013FB1 RID: 81841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04013FB2 RID: 81842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04013FB3 RID: 81843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04013FB4 RID: 81844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04013FB5 RID: 81845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04013FB6 RID: 81846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04013FB7 RID: 81847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04013FB8 RID: 81848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04013FB9 RID: 81849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04013FBA RID: 81850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04013FBB RID: 81851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04013FBC RID: 81852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04013FBD RID: 81853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04013FBE RID: 81854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04013FBF RID: 81855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04013FC0 RID: 81856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04013FC1 RID: 81857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04013FC2 RID: 81858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04013FC3 RID: 81859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04013FC4 RID: 81860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04013FC5 RID: 81861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04013FC6 RID: 81862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04013FC7 RID: 81863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04013FC8 RID: 81864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;
}
