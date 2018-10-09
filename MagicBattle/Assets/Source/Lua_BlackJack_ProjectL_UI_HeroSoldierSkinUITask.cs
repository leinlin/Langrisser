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

// Token: 0x020014E7 RID: 5351
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask : LuaObject
{
	// Token: 0x0601F8FD RID: 129277 RVA: 0x00A5F89C File Offset: 0x00A5DA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			HeroSoldierSkinUITask o = new HeroSoldierSkinUITask(name);
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

	// Token: 0x0601F8FE RID: 129278 RVA: 0x00A5F8F0 File Offset: 0x00A5DAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroSoldierSkinUITask.OnNewIntent(intent);
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

	// Token: 0x0601F8FF RID: 129279 RVA: 0x00A5F954 File Offset: 0x00A5DB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSoldierSkinUIController_OnCloseHeroCharChangeTask(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.HeroSoldierSkinUIController_OnCloseHeroCharChangeTask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F900 RID: 129280 RVA: 0x00A5F9A0 File Offset: 0x00A5DBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F901 RID: 129281 RVA: 0x00A5F9EC File Offset: 0x00A5DBEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StoreSoldierSkinDetailUITask_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.StoreSoldierSkinDetailUITask_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F902 RID: 129282 RVA: 0x00A5FA38 File Offset: 0x00A5DC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BringLayerToTop(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.BringLayerToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F903 RID: 129283 RVA: 0x00A5FA84 File Offset: 0x00A5DC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			Hero hero;
			LuaObject.checkType<Hero>(l, 1, out hero);
			bool isFromHeroInfoTab;
			LuaObject.checkType(l, 2, out isFromHeroInfoTab);
			ConfigDataSoldierInfo curSoldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 3, out curSoldierInfo);
			UIIntent preUIIntent;
			LuaObject.checkType<UIIntent>(l, 4, out preUIIntent);
			HeroSoldierSkinUITask o = HeroSoldierSkinUITask.StartUITask(hero, isFromHeroInfoTab, curSoldierInfo, preUIIntent);
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

	// Token: 0x0601F904 RID: 129284 RVA: 0x00A5FB00 File Offset: 0x00A5DD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSoldierSkinUITask_OnLoadAllResCompleted_s(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask.HeroSoldierSkinUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F905 RID: 129285 RVA: 0x00A5FB40 File Offset: 0x00A5DD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			bool b = heroSoldierSkinUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601F906 RID: 129286 RVA: 0x00A5FB9C File Offset: 0x00A5DD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F907 RID: 129287 RVA: 0x00A5FBF0 File Offset: 0x00A5DDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F908 RID: 129288 RVA: 0x00A5FC44 File Offset: 0x00A5DE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroSoldierSkinUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601F909 RID: 129289 RVA: 0x00A5FCAC File Offset: 0x00A5DEAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroSoldierSkinUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601F90A RID: 129290 RVA: 0x00A5FD14 File Offset: 0x00A5DF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPause(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F90B RID: 129291 RVA: 0x00A5FD68 File Offset: 0x00A5DF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			heroSoldierSkinUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F90C RID: 129292 RVA: 0x00A5FDC4 File Offset: 0x00A5DFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F90D RID: 129293 RVA: 0x00A5FE18 File Offset: 0x00A5E018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F90E RID: 129294 RVA: 0x00A5FE6C File Offset: 0x00A5E06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSoldierSkinUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			bool isFromHeroInfoTab;
			LuaObject.checkType(l, 2, out isFromHeroInfoTab);
			heroSoldierSkinUITask.m_luaExportHelper.HeroSoldierSkinUIController_OnReturn(isFromHeroInfoTab);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F90F RID: 129295 RVA: 0x00A5FEC8 File Offset: 0x00A5E0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSoldierSkinUIController_OnBuyHeroSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			int heroSkinInfoId;
			LuaObject.checkType(l, 2, out heroSkinInfoId);
			heroSoldierSkinUITask.m_luaExportHelper.HeroSoldierSkinUIController_OnBuyHeroSkin(heroSkinInfoId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F910 RID: 129296 RVA: 0x00A5FF24 File Offset: 0x00A5E124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSoldierSkinUIController_OnBuySoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			int soldierSkinInfoId;
			LuaObject.checkType(l, 2, out soldierSkinInfoId);
			heroSoldierSkinUITask.m_luaExportHelper.HeroSoldierSkinUIController_OnBuySoldierSkin(soldierSkinInfoId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F911 RID: 129297 RVA: 0x00A5FF80 File Offset: 0x00A5E180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSoldierSkinUIController_OnWearModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int modelSkinId;
			LuaObject.checkType(l, 4, out modelSkinId);
			heroSoldierSkinUITask.m_luaExportHelper.HeroSoldierSkinUIController_OnWearModelSkin(heroId, jobRelatedId, modelSkinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F912 RID: 129298 RVA: 0x00A5FFF8 File Offset: 0x00A5E1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSoldierSkinUIController_OnTakeOffModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			heroSoldierSkinUITask.m_luaExportHelper.HeroSoldierSkinUIController_OnTakeOffModelSkin(heroId, jobRelatedId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F913 RID: 129299 RVA: 0x00A60064 File Offset: 0x00A5E264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSoldierSkinUIController_OnWearSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			int soldierSkinId;
			LuaObject.checkType(l, 4, out soldierSkinId);
			heroSoldierSkinUITask.m_luaExportHelper.HeroSoldierSkinUIController_OnWearSoldierSkin(heroId, soldierId, soldierSkinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F914 RID: 129300 RVA: 0x00A600DC File Offset: 0x00A5E2DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSoldierSkinUIController_OnTakeOffSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			heroSoldierSkinUITask.m_luaExportHelper.HeroSoldierSkinUIController_OnTakeOffSoldierSkin(heroId, soldierId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F915 RID: 129301 RVA: 0x00A60148 File Offset: 0x00A5E348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroSoldierSkinUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601F916 RID: 129302 RVA: 0x00A601B0 File Offset: 0x00A5E3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F917 RID: 129303 RVA: 0x00A60204 File Offset: 0x00A5E404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F918 RID: 129304 RVA: 0x00A60258 File Offset: 0x00A5E458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroSoldierSkinUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601F919 RID: 129305 RVA: 0x00A602C0 File Offset: 0x00A5E4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroSoldierSkinUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601F91A RID: 129306 RVA: 0x00A60328 File Offset: 0x00A5E528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F91B RID: 129307 RVA: 0x00A60394 File Offset: 0x00A5E594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			bool b = heroSoldierSkinUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601F91C RID: 129308 RVA: 0x00A603F0 File Offset: 0x00A5E5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			List<string> o = heroSoldierSkinUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601F91D RID: 129309 RVA: 0x00A6044C File Offset: 0x00A5E64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F91E RID: 129310 RVA: 0x00A604A0 File Offset: 0x00A5E6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F91F RID: 129311 RVA: 0x00A604F4 File Offset: 0x00A5E6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F920 RID: 129312 RVA: 0x00A60548 File Offset: 0x00A5E748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F921 RID: 129313 RVA: 0x00A6059C File Offset: 0x00A5E79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F922 RID: 129314 RVA: 0x00A605F0 File Offset: 0x00A5E7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F923 RID: 129315 RVA: 0x00A6064C File Offset: 0x00A5E84C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F924 RID: 129316 RVA: 0x00A606A8 File Offset: 0x00A5E8A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F925 RID: 129317 RVA: 0x00A60704 File Offset: 0x00A5E904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F926 RID: 129318 RVA: 0x00A60760 File Offset: 0x00A5E960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			bool b = heroSoldierSkinUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601F927 RID: 129319 RVA: 0x00A607BC File Offset: 0x00A5E9BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			bool b = heroSoldierSkinUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601F928 RID: 129320 RVA: 0x00A60818 File Offset: 0x00A5EA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			bool b = heroSoldierSkinUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601F929 RID: 129321 RVA: 0x00A60874 File Offset: 0x00A5EA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			UITaskBase o = heroSoldierSkinUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601F92A RID: 129322 RVA: 0x00A608D0 File Offset: 0x00A5EAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F92B RID: 129323 RVA: 0x00A60924 File Offset: 0x00A5EB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F92C RID: 129324 RVA: 0x00A60978 File Offset: 0x00A5EB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F92D RID: 129325 RVA: 0x00A609CC File Offset: 0x00A5EBCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			heroSoldierSkinUITask.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F92E RID: 129326 RVA: 0x00A60A20 File Offset: 0x00A5EC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSoldierSkinUITask.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroSoldierSkinUITask.EventOnReturn -= value;
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

	// Token: 0x0601F92F RID: 129327 RVA: 0x00A60AA0 File Offset: 0x00A5ECA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F930 RID: 129328 RVA: 0x00A60AF8 File Offset: 0x00A5ECF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			heroSoldierSkinUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F931 RID: 129329 RVA: 0x00A60B54 File Offset: 0x00A5ED54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F932 RID: 129330 RVA: 0x00A60BAC File Offset: 0x00A5EDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			heroSoldierSkinUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F933 RID: 129331 RVA: 0x00A60C08 File Offset: 0x00A5EE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroSoldierSkinUITask.LuaExportHelper.ParamKey_SoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F934 RID: 129332 RVA: 0x00A60C50 File Offset: 0x00A5EE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_IsFromHeroInfoTab(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroSoldierSkinUITask.LuaExportHelper.ParamKey_IsFromHeroInfoTab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F935 RID: 129333 RVA: 0x00A60C98 File Offset: 0x00A5EE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_HeroObject(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroSoldierSkinUITask.LuaExportHelper.ParamKey_HeroObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F936 RID: 129334 RVA: 0x00A60CE0 File Offset: 0x00A5EEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUITask.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F937 RID: 129335 RVA: 0x00A60D38 File Offset: 0x00A5EF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroSoldierSkinUITask.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F938 RID: 129336 RVA: 0x00A60D94 File Offset: 0x00A5EF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFromHeroInfoTab(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUITask.m_luaExportHelper.m_isFromHeroInfoTab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F939 RID: 129337 RVA: 0x00A60DEC File Offset: 0x00A5EFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFromHeroInfoTab(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			bool isFromHeroInfoTab;
			LuaObject.checkType(l, 2, out isFromHeroInfoTab);
			heroSoldierSkinUITask.m_luaExportHelper.m_isFromHeroInfoTab = isFromHeroInfoTab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F93A RID: 129338 RVA: 0x00A60E48 File Offset: 0x00A5F048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUITask.m_luaExportHelper.m_curSoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F93B RID: 129339 RVA: 0x00A60EA0 File Offset: 0x00A5F0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo curSoldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out curSoldierInfo);
			heroSoldierSkinUITask.m_luaExportHelper.m_curSoldierInfo = curSoldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F93C RID: 129340 RVA: 0x00A60EFC File Offset: 0x00A5F0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSoldierSkinUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUITask.m_luaExportHelper.m_heroSoldierSkinUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F93D RID: 129341 RVA: 0x00A60F54 File Offset: 0x00A5F154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSoldierSkinUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			HeroSoldierSkinUIController heroSoldierSkinUIController;
			LuaObject.checkType<HeroSoldierSkinUIController>(l, 2, out heroSoldierSkinUIController);
			heroSoldierSkinUITask.m_luaExportHelper.m_heroSoldierSkinUIController = heroSoldierSkinUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F93E RID: 129342 RVA: 0x00A60FB0 File Offset: 0x00A5F1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F93F RID: 129343 RVA: 0x00A61008 File Offset: 0x00A5F208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroSoldierSkinUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F940 RID: 129344 RVA: 0x00A61064 File Offset: 0x00A5F264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F941 RID: 129345 RVA: 0x00A610BC File Offset: 0x00A5F2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroSoldierSkinUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F942 RID: 129346 RVA: 0x00A61118 File Offset: 0x00A5F318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F943 RID: 129347 RVA: 0x00A61170 File Offset: 0x00A5F370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroSoldierSkinUITask heroSoldierSkinUITask = (HeroSoldierSkinUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSoldierSkinUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F944 RID: 129348 RVA: 0x00A611C8 File Offset: 0x00A5F3C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroSoldierSkinUITask");
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.HeroSoldierSkinUIController_OnCloseHeroCharChangeTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.StoreSoldierSkinDetailUITask_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.BringLayerToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.HeroSoldierSkinUITask_OnLoadAllResCompleted_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.HeroSoldierSkinUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.HeroSoldierSkinUIController_OnBuyHeroSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.HeroSoldierSkinUIController_OnBuySoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.HeroSoldierSkinUIController_OnWearModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.HeroSoldierSkinUIController_OnTakeOffModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.HeroSoldierSkinUIController_OnWearSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.HeroSoldierSkinUIController_OnTakeOffSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache2F);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache30, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache32, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache34, true);
		string name4 = "ParamKey_SoldierInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_ParamKey_SoldierInfo);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache35, null, false);
		string name5 = "ParamKey_IsFromHeroInfoTab";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_ParamKey_IsFromHeroInfoTab);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache36, null, false);
		string name6 = "ParamKey_HeroObject";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_ParamKey_HeroObject);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache37, null, false);
		string name7 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_m_hero);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.set_m_hero);
		}
		LuaObject.addMember(l, name7, get4, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache39, true);
		string name8 = "m_isFromHeroInfoTab";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_m_isFromHeroInfoTab);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.set_m_isFromHeroInfoTab);
		}
		LuaObject.addMember(l, name8, get5, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3B, true);
		string name9 = "m_curSoldierInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_m_curSoldierInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.set_m_curSoldierInfo);
		}
		LuaObject.addMember(l, name9, get6, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3D, true);
		string name10 = "m_heroSoldierSkinUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_m_heroSoldierSkinUIController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.set_m_heroSoldierSkinUIController);
		}
		LuaObject.addMember(l, name10, get7, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache3F, true);
		string name11 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_m_playerContext);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name11, get8, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache41, true);
		string name12 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_m_configDataLoader);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name12, get9, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache43, true);
		string name13 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache44, null, true);
		string name14 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache45, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.<>f__mg$cache46, typeof(HeroSoldierSkinUITask), typeof(UITask));
	}

	// Token: 0x04015911 RID: 88337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015912 RID: 88338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015913 RID: 88339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015914 RID: 88340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015915 RID: 88341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015916 RID: 88342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015917 RID: 88343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015918 RID: 88344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015919 RID: 88345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401591A RID: 88346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401591B RID: 88347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401591C RID: 88348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401591D RID: 88349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401591E RID: 88350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401591F RID: 88351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015920 RID: 88352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015921 RID: 88353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015922 RID: 88354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015923 RID: 88355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015924 RID: 88356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015925 RID: 88357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015926 RID: 88358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015927 RID: 88359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015928 RID: 88360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015929 RID: 88361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401592A RID: 88362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401592B RID: 88363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401592C RID: 88364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401592D RID: 88365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401592E RID: 88366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401592F RID: 88367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015930 RID: 88368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015931 RID: 88369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015932 RID: 88370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015933 RID: 88371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015934 RID: 88372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015935 RID: 88373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015936 RID: 88374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015937 RID: 88375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015938 RID: 88376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015939 RID: 88377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401593A RID: 88378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401593B RID: 88379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401593C RID: 88380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401593D RID: 88381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401593E RID: 88382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401593F RID: 88383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015940 RID: 88384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015941 RID: 88385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015942 RID: 88386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015943 RID: 88387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015944 RID: 88388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015945 RID: 88389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015946 RID: 88390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015947 RID: 88391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015948 RID: 88392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015949 RID: 88393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401594A RID: 88394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401594B RID: 88395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401594C RID: 88396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401594D RID: 88397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401594E RID: 88398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401594F RID: 88399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04015950 RID: 88400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04015951 RID: 88401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04015952 RID: 88402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04015953 RID: 88403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04015954 RID: 88404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04015955 RID: 88405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04015956 RID: 88406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04015957 RID: 88407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;
}
