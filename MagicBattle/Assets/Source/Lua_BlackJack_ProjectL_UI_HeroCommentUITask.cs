using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014AE RID: 5294
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroCommentUITask : LuaObject
{
	// Token: 0x0601EB9B RID: 125851 RVA: 0x009F407C File Offset: 0x009F227C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			HeroCommentUITask o = new HeroCommentUITask(name);
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

	// Token: 0x0601EB9C RID: 125852 RVA: 0x009F40D0 File Offset: 0x009F22D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB9D RID: 125853 RVA: 0x009F4124 File Offset: 0x009F2324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EB9E RID: 125854 RVA: 0x009F4178 File Offset: 0x009F2378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroCommentUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601EB9F RID: 125855 RVA: 0x009F41E0 File Offset: 0x009F23E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroCommentUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601EBA0 RID: 125856 RVA: 0x009F4248 File Offset: 0x009F2448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			heroCommentUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBA1 RID: 125857 RVA: 0x009F42A4 File Offset: 0x009F24A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNeedUpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			bool b = heroCommentUITask.m_luaExportHelper.IsNeedUpdateDataCache();
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

	// Token: 0x0601EBA2 RID: 125858 RVA: 0x009F4300 File Offset: 0x009F2500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.UpdateDataCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBA3 RID: 125859 RVA: 0x009F4354 File Offset: 0x009F2554
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			bool b = heroCommentUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601EBA4 RID: 125860 RVA: 0x009F43B0 File Offset: 0x009F25B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			List<string> o = heroCommentUITask.m_luaExportHelper.CollectAllDynamicResForLoad();
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

	// Token: 0x0601EBA5 RID: 125861 RVA: 0x009F440C File Offset: 0x009F260C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBA6 RID: 125862 RVA: 0x009F4460 File Offset: 0x009F2660
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HeroCommentUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.HeroCommentUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBA7 RID: 125863 RVA: 0x009F44B4 File Offset: 0x009F26B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCommentUIController_OnCommentGet(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool isNeedReset;
			LuaObject.checkType(l, 3, out isNeedReset);
			heroCommentUITask.m_luaExportHelper.HeroCommentUIController_OnCommentGet(heroId, isNeedReset);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBA8 RID: 125864 RVA: 0x009F4520 File Offset: 0x009F2720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCommentUIController_OnRankingQuery(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			heroCommentUITask.m_luaExportHelper.HeroCommentUIController_OnRankingQuery(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBA9 RID: 125865 RVA: 0x009F457C File Offset: 0x009F277C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCommentUIController_OnRankingListLockClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.HeroCommentUIController_OnRankingListLockClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBAA RID: 125866 RVA: 0x009F45D0 File Offset: 0x009F27D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCommentUIController_OnCommentSend(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			string commentStr;
			LuaObject.checkType(l, 3, out commentStr);
			heroCommentUITask.m_luaExportHelper.HeroCommentUIController_OnCommentSend(heroId, commentStr);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBAB RID: 125867 RVA: 0x009F463C File Offset: 0x009F283C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCommentUIController_OnCommentPraised(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ulong instanceId;
			LuaObject.checkType(l, 3, out instanceId);
			heroCommentUITask.m_luaExportHelper.HeroCommentUIController_OnCommentPraised(heroId, instanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBAC RID: 125868 RVA: 0x009F46A8 File Offset: 0x009F28A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCommentUIController_OnCommenterHeroView(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroCommentEntry comment;
			LuaObject.checkType<HeroCommentEntry>(l, 3, out comment);
			heroCommentUITask.m_luaExportHelper.HeroCommentUIController_OnCommenterHeroView(heroId, comment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBAD RID: 125869 RVA: 0x009F4714 File Offset: 0x009F2914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroCommentUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601EBAE RID: 125870 RVA: 0x009F477C File Offset: 0x009F297C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBAF RID: 125871 RVA: 0x009F47D0 File Offset: 0x009F29D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBB0 RID: 125872 RVA: 0x009F4824 File Offset: 0x009F2A24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroCommentUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601EBB1 RID: 125873 RVA: 0x009F488C File Offset: 0x009F2A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroCommentUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601EBB2 RID: 125874 RVA: 0x009F48F4 File Offset: 0x009F2AF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			heroCommentUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBB3 RID: 125875 RVA: 0x009F4960 File Offset: 0x009F2B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			bool b = heroCommentUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601EBB4 RID: 125876 RVA: 0x009F49BC File Offset: 0x009F2BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			List<string> o = heroCommentUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601EBB5 RID: 125877 RVA: 0x009F4A18 File Offset: 0x009F2C18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBB6 RID: 125878 RVA: 0x009F4A6C File Offset: 0x009F2C6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBB7 RID: 125879 RVA: 0x009F4AC0 File Offset: 0x009F2CC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBB8 RID: 125880 RVA: 0x009F4B14 File Offset: 0x009F2D14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBB9 RID: 125881 RVA: 0x009F4B68 File Offset: 0x009F2D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBBA RID: 125882 RVA: 0x009F4BBC File Offset: 0x009F2DBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroCommentUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBBB RID: 125883 RVA: 0x009F4C18 File Offset: 0x009F2E18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroCommentUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBBC RID: 125884 RVA: 0x009F4C74 File Offset: 0x009F2E74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroCommentUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBBD RID: 125885 RVA: 0x009F4CD0 File Offset: 0x009F2ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			heroCommentUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBBE RID: 125886 RVA: 0x009F4D2C File Offset: 0x009F2F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			bool b = heroCommentUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601EBBF RID: 125887 RVA: 0x009F4D88 File Offset: 0x009F2F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			bool b = heroCommentUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601EBC0 RID: 125888 RVA: 0x009F4DE4 File Offset: 0x009F2FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			bool b = heroCommentUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601EBC1 RID: 125889 RVA: 0x009F4E40 File Offset: 0x009F3040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			UITaskBase o = heroCommentUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601EBC2 RID: 125890 RVA: 0x009F4E9C File Offset: 0x009F309C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBC3 RID: 125891 RVA: 0x009F4EF0 File Offset: 0x009F30F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			heroCommentUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBC4 RID: 125892 RVA: 0x009F4F44 File Offset: 0x009F3144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currRankList(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUITask.m_luaExportHelper.m_currRankList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBC5 RID: 125893 RVA: 0x009F4F9C File Offset: 0x009F319C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currRankList(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			RankingListInfo currRankList;
			LuaObject.checkType<RankingListInfo>(l, 2, out currRankList);
			heroCommentUITask.m_luaExportHelper.m_currRankList = currRankList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBC6 RID: 125894 RVA: 0x009F4FF8 File Offset: 0x009F31F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UIMode_HeroComment(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroCommentUITask.UIMode_HeroComment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBC7 RID: 125895 RVA: 0x009F5040 File Offset: 0x009F3240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UIMode_HeroComment(IntPtr l)
	{
		int result;
		try
		{
			string uimode_HeroComment;
			LuaObject.checkType(l, 2, out uimode_HeroComment);
			HeroCommentUITask.UIMode_HeroComment = uimode_HeroComment;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBC8 RID: 125896 RVA: 0x009F508C File Offset: 0x009F328C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UIModel_RankingList(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroCommentUITask.UIModel_RankingList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBC9 RID: 125897 RVA: 0x009F50D4 File Offset: 0x009F32D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UIModel_RankingList(IntPtr l)
	{
		int result;
		try
		{
			string uimodel_RankingList;
			LuaObject.checkType(l, 2, out uimodel_RankingList);
			HeroCommentUITask.UIModel_RankingList = uimodel_RankingList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBCA RID: 125898 RVA: 0x009F5120 File Offset: 0x009F3320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBCB RID: 125899 RVA: 0x009F5178 File Offset: 0x009F3378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			heroCommentUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBCC RID: 125900 RVA: 0x009F51D4 File Offset: 0x009F33D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBCD RID: 125901 RVA: 0x009F522C File Offset: 0x009F342C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			heroCommentUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBCE RID: 125902 RVA: 0x009F5288 File Offset: 0x009F3488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUITask.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBCF RID: 125903 RVA: 0x009F52E0 File Offset: 0x009F34E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroCommentUITask.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBD0 RID: 125904 RVA: 0x009F533C File Offset: 0x009F353C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNeedResetScrollViewPos(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUITask.m_luaExportHelper.m_isNeedResetScrollViewPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBD1 RID: 125905 RVA: 0x009F5394 File Offset: 0x009F3594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNeedResetScrollViewPos(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			bool isNeedResetScrollViewPos;
			LuaObject.checkType(l, 2, out isNeedResetScrollViewPos);
			heroCommentUITask.m_luaExportHelper.m_isNeedResetScrollViewPos = isNeedResetScrollViewPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBD2 RID: 125906 RVA: 0x009F53F0 File Offset: 0x009F35F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCommentUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUITask.m_luaExportHelper.m_heroCommentUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBD3 RID: 125907 RVA: 0x009F5448 File Offset: 0x009F3648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCommentUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			HeroCommentUIController heroCommentUIController;
			LuaObject.checkType<HeroCommentUIController>(l, 2, out heroCommentUIController);
			heroCommentUITask.m_luaExportHelper.m_heroCommentUIController = heroCommentUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBD4 RID: 125908 RVA: 0x009F54A4 File Offset: 0x009F36A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNeedShowHeroDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUITask.m_luaExportHelper.m_isNeedShowHeroDetailPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBD5 RID: 125909 RVA: 0x009F54FC File Offset: 0x009F36FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNeedShowHeroDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			bool isNeedShowHeroDetailPanel;
			LuaObject.checkType(l, 2, out isNeedShowHeroDetailPanel);
			heroCommentUITask.m_luaExportHelper.m_isNeedShowHeroDetailPanel = isNeedShowHeroDetailPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBD6 RID: 125910 RVA: 0x009F5558 File Offset: 0x009F3758
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerHero(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUITask.m_luaExportHelper.m_playerHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBD7 RID: 125911 RVA: 0x009F55B0 File Offset: 0x009F37B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHero(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			Hero playerHero;
			LuaObject.checkType<Hero>(l, 2, out playerHero);
			heroCommentUITask.m_luaExportHelper.m_playerHero = playerHero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBD8 RID: 125912 RVA: 0x009F560C File Offset: 0x009F380C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerComment(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUITask.m_luaExportHelper.m_playerComment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBD9 RID: 125913 RVA: 0x009F5664 File Offset: 0x009F3864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerComment(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			HeroCommentEntry playerComment;
			LuaObject.checkType<HeroCommentEntry>(l, 2, out playerComment);
			heroCommentUITask.m_luaExportHelper.m_playerComment = playerComment;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBDA RID: 125914 RVA: 0x009F56C0 File Offset: 0x009F38C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBDB RID: 125915 RVA: 0x009F5718 File Offset: 0x009F3918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentUITask heroCommentUITask = (HeroCommentUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBDC RID: 125916 RVA: 0x009F5770 File Offset: 0x009F3970
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroCommentUITask");
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.IsNeedUpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.UpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.HeroCommentUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.HeroCommentUIController_OnCommentGet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.HeroCommentUIController_OnRankingQuery);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.HeroCommentUIController_OnRankingListLockClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.HeroCommentUIController_OnCommentSend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.HeroCommentUIController_OnCommentPraised);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.HeroCommentUIController_OnCommenterHeroView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache27);
		string name = "m_currRankList";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_m_currRankList);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.set_m_currRankList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache29, true);
		string name2 = "UIMode_HeroComment";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_UIMode_HeroComment);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.set_UIMode_HeroComment);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2B, false);
		string name3 = "UIModel_RankingList";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_UIModel_RankingList);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.set_UIModel_RankingList);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2D, false);
		string name4 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_m_layerDescArray);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache2F, true);
		string name5 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache31, true);
		string name6 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_m_hero);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.set_m_hero);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache33, true);
		string name7 = "m_isNeedResetScrollViewPos";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_m_isNeedResetScrollViewPos);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.set_m_isNeedResetScrollViewPos);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache35, true);
		string name8 = "m_heroCommentUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_m_heroCommentUIController);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.set_m_heroCommentUIController);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache37, true);
		string name9 = "m_isNeedShowHeroDetailPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_m_isNeedShowHeroDetailPanel);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.set_m_isNeedShowHeroDetailPanel);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache39, true);
		string name10 = "m_playerHero";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_m_playerHero);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.set_m_playerHero);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3B, true);
		string name11 = "m_playerComment";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_m_playerComment);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.set_m_playerComment);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3D, true);
		string name12 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3E, null, true);
		string name13 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache3F, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroCommentUITask.<>f__mg$cache40, typeof(HeroCommentUITask), typeof(UITask));
	}

	// Token: 0x04014C21 RID: 85025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014C22 RID: 85026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014C23 RID: 85027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014C24 RID: 85028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014C25 RID: 85029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014C26 RID: 85030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014C27 RID: 85031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014C28 RID: 85032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014C29 RID: 85033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014C2A RID: 85034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014C2B RID: 85035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014C2C RID: 85036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014C2D RID: 85037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014C2E RID: 85038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014C2F RID: 85039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014C30 RID: 85040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014C31 RID: 85041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014C32 RID: 85042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014C33 RID: 85043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014C34 RID: 85044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014C35 RID: 85045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014C36 RID: 85046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014C37 RID: 85047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014C38 RID: 85048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014C39 RID: 85049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014C3A RID: 85050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014C3B RID: 85051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014C3C RID: 85052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014C3D RID: 85053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014C3E RID: 85054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014C3F RID: 85055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014C40 RID: 85056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014C41 RID: 85057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014C42 RID: 85058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014C43 RID: 85059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014C44 RID: 85060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014C45 RID: 85061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014C46 RID: 85062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014C47 RID: 85063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014C48 RID: 85064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014C49 RID: 85065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014C4A RID: 85066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014C4B RID: 85067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014C4C RID: 85068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014C4D RID: 85069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014C4E RID: 85070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014C4F RID: 85071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014C50 RID: 85072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014C51 RID: 85073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014C52 RID: 85074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014C53 RID: 85075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014C54 RID: 85076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014C55 RID: 85077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014C56 RID: 85078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014C57 RID: 85079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014C58 RID: 85080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014C59 RID: 85081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014C5A RID: 85082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014C5B RID: 85083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014C5C RID: 85084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04014C5D RID: 85085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04014C5E RID: 85086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04014C5F RID: 85087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04014C60 RID: 85088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04014C61 RID: 85089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;
}
