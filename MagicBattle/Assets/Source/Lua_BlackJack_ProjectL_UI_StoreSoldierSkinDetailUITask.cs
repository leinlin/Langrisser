using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200158A RID: 5514
[Preserve]
public class Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask : LuaObject
{
	// Token: 0x06021501 RID: 136449 RVA: 0x00B3EAAC File Offset: 0x00B3CCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			StoreSoldierSkinDetailUITask o = new StoreSoldierSkinDetailUITask(name);
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

	// Token: 0x06021502 RID: 136450 RVA: 0x00B3EB00 File Offset: 0x00B3CD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.OnBgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021503 RID: 136451 RVA: 0x00B3EB4C File Offset: 0x00B3CD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.OnBuyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021504 RID: 136452 RVA: 0x00B3EB98 File Offset: 0x00B3CD98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartSoldierSkinDetailPanel_s(IntPtr l)
	{
		int result;
		try
		{
			int soldierSkinId;
			LuaObject.checkType(l, 1, out soldierSkinId);
			StoreSoldierSkinDetailUITask.StartTaskFromType startType;
			LuaObject.checkEnum<StoreSoldierSkinDetailUITask.StartTaskFromType>(l, 2, out startType);
			UIIntent preUIIntent;
			LuaObject.checkType<UIIntent>(l, 3, out preUIIntent);
			StoreSoldierSkinDetailUITask o = StoreSoldierSkinDetailUITask.StartSoldierSkinDetailPanel(soldierSkinId, startType, preUIIntent);
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

	// Token: 0x06021505 RID: 136453 RVA: 0x00B3EC08 File Offset: 0x00B3CE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPause(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021506 RID: 136454 RVA: 0x00B3EC5C File Offset: 0x00B3CE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021507 RID: 136455 RVA: 0x00B3ECB0 File Offset: 0x00B3CEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021508 RID: 136456 RVA: 0x00B3ED04 File Offset: 0x00B3CF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			bool b = storeSoldierSkinDetailUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06021509 RID: 136457 RVA: 0x00B3ED60 File Offset: 0x00B3CF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedUpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			bool b = storeSoldierSkinDetailUITask.m_luaExportHelper.IsNeedUpdateDataCache();
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

	// Token: 0x0602150A RID: 136458 RVA: 0x00B3EDBC File Offset: 0x00B3CFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.UpdateDataCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602150B RID: 136459 RVA: 0x00B3EE10 File Offset: 0x00B3D010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602150C RID: 136460 RVA: 0x00B3EE64 File Offset: 0x00B3D064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602150D RID: 136461 RVA: 0x00B3EEB8 File Offset: 0x00B3D0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0602150E RID: 136462 RVA: 0x00B3EF20 File Offset: 0x00B3D120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602150F RID: 136463 RVA: 0x00B3EF74 File Offset: 0x00B3D174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021510 RID: 136464 RVA: 0x00B3EFC8 File Offset: 0x00B3D1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06021511 RID: 136465 RVA: 0x00B3F030 File Offset: 0x00B3D230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06021512 RID: 136466 RVA: 0x00B3F098 File Offset: 0x00B3D298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021513 RID: 136467 RVA: 0x00B3F104 File Offset: 0x00B3D304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			bool b = storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06021514 RID: 136468 RVA: 0x00B3F160 File Offset: 0x00B3D360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			List<string> o = storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06021515 RID: 136469 RVA: 0x00B3F1BC File Offset: 0x00B3D3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021516 RID: 136470 RVA: 0x00B3F210 File Offset: 0x00B3D410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021517 RID: 136471 RVA: 0x00B3F264 File Offset: 0x00B3D464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021518 RID: 136472 RVA: 0x00B3F2B8 File Offset: 0x00B3D4B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021519 RID: 136473 RVA: 0x00B3F30C File Offset: 0x00B3D50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602151A RID: 136474 RVA: 0x00B3F360 File Offset: 0x00B3D560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602151B RID: 136475 RVA: 0x00B3F3BC File Offset: 0x00B3D5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602151C RID: 136476 RVA: 0x00B3F418 File Offset: 0x00B3D618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602151D RID: 136477 RVA: 0x00B3F474 File Offset: 0x00B3D674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602151E RID: 136478 RVA: 0x00B3F4D0 File Offset: 0x00B3D6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			bool b = storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0602151F RID: 136479 RVA: 0x00B3F52C File Offset: 0x00B3D72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			bool b = storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06021520 RID: 136480 RVA: 0x00B3F588 File Offset: 0x00B3D788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			bool b = storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06021521 RID: 136481 RVA: 0x00B3F5E4 File Offset: 0x00B3D7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			UITaskBase o = storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06021522 RID: 136482 RVA: 0x00B3F640 File Offset: 0x00B3D840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021523 RID: 136483 RVA: 0x00B3F694 File Offset: 0x00B3D894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021524 RID: 136484 RVA: 0x00B3F6E8 File Offset: 0x00B3D8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBuySuccessEnd(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callDele_EventOnBuySuccessEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021525 RID: 136485 RVA: 0x00B3F73C File Offset: 0x00B3D93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBuySuccessEnd(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__clearDele_EventOnBuySuccessEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021526 RID: 136486 RVA: 0x00B3F790 File Offset: 0x00B3D990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021527 RID: 136487 RVA: 0x00B3F7E4 File Offset: 0x00B3D9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021528 RID: 136488 RVA: 0x00B3F838 File Offset: 0x00B3DA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBuySuccessEnd(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeSoldierSkinDetailUITask.EventOnBuySuccessEnd += value;
				}
				else if (num == 2)
				{
					storeSoldierSkinDetailUITask.EventOnBuySuccessEnd -= value;
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

	// Token: 0x06021529 RID: 136489 RVA: 0x00B3F8B8 File Offset: 0x00B3DAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeSoldierSkinDetailUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					storeSoldierSkinDetailUITask.EventOnClose -= value;
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

	// Token: 0x0602152A RID: 136490 RVA: 0x00B3F938 File Offset: 0x00B3DB38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierSkinConfigId(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUITask.m_soldierSkinConfigId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602152B RID: 136491 RVA: 0x00B3F98C File Offset: 0x00B3DB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierSkinConfigId(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			int soldierSkinConfigId;
			LuaObject.checkType(l, 2, out soldierSkinConfigId);
			storeSoldierSkinDetailUITask.m_soldierSkinConfigId = soldierSkinConfigId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602152C RID: 136492 RVA: 0x00B3F9E4 File Offset: 0x00B3DBE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startFormType(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeSoldierSkinDetailUITask.m_startFormType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602152D RID: 136493 RVA: 0x00B3FA38 File Offset: 0x00B3DC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startFormType(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			StoreSoldierSkinDetailUITask.StartTaskFromType startFormType;
			LuaObject.checkEnum<StoreSoldierSkinDetailUITask.StartTaskFromType>(l, 2, out startFormType);
			storeSoldierSkinDetailUITask.m_startFormType = startFormType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602152E RID: 136494 RVA: 0x00B3FA90 File Offset: 0x00B3DC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierSkinDetailPanelCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUITask.m_soldierSkinDetailPanelCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602152F RID: 136495 RVA: 0x00B3FAE4 File Offset: 0x00B3DCE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierSkinDetailPanelCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			StoreSoldierSkinDetailUIController soldierSkinDetailPanelCtrl;
			LuaObject.checkType<StoreSoldierSkinDetailUIController>(l, 2, out soldierSkinDetailPanelCtrl);
			storeSoldierSkinDetailUITask.m_soldierSkinDetailPanelCtrl = soldierSkinDetailPanelCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021530 RID: 136496 RVA: 0x00B3FB3C File Offset: 0x00B3DD3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021531 RID: 136497 RVA: 0x00B3FB94 File Offset: 0x00B3DD94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			storeSoldierSkinDetailUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021532 RID: 136498 RVA: 0x00B3FBF0 File Offset: 0x00B3DDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021533 RID: 136499 RVA: 0x00B3FC48 File Offset: 0x00B3DE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			storeSoldierSkinDetailUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021534 RID: 136500 RVA: 0x00B3FCA4 File Offset: 0x00B3DEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_SoldierSkinConfigID(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "SoldierSkinFixedStoreID");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021535 RID: 136501 RVA: 0x00B3FCEC File Offset: 0x00B3DEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_StartTaskFromType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "StartTaskFromType");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021536 RID: 136502 RVA: 0x00B3FD34 File Offset: 0x00B3DF34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021537 RID: 136503 RVA: 0x00B3FD8C File Offset: 0x00B3DF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = (StoreSoldierSkinDetailUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021538 RID: 136504 RVA: 0x00B3FDE4 File Offset: 0x00B3DFE4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.StoreSoldierSkinDetailUITask");
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.OnBgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.OnBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.StartSoldierSkinDetailPanel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.IsNeedUpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.UpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callDele_EventOnBuySuccessEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__clearDele_EventOnBuySuccessEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache25);
		string name = "EventOnBuySuccessEnd";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.set_EventOnBuySuccessEnd);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache26, true);
		string name2 = "EventOnClose";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache27, true);
		string name3 = "m_soldierSkinConfigId";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.get_m_soldierSkinConfigId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.set_m_soldierSkinConfigId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache29, true);
		string name4 = "m_startFormType";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.get_m_startFormType);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.set_m_startFormType);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2B, true);
		string name5 = "m_soldierSkinDetailPanelCtrl";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.get_m_soldierSkinDetailPanelCtrl);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.set_m_soldierSkinDetailPanelCtrl);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2D, true);
		string name6 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.get_m_layerDescArray);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache2F, true);
		string name7 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache31, true);
		string name8 = "ParamKey_SoldierSkinConfigID";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.get_ParamKey_SoldierSkinConfigID);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache32, null, false);
		string name9 = "ParamKey_StartTaskFromType";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.get_ParamKey_StartTaskFromType);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache33, null, false);
		string name10 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache34, null, true);
		string name11 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache35, null, true);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.<>f__mg$cache36, typeof(StoreSoldierSkinDetailUITask), typeof(UITask));
	}

	// Token: 0x040173CF RID: 95183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040173D0 RID: 95184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040173D1 RID: 95185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040173D2 RID: 95186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040173D3 RID: 95187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040173D4 RID: 95188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040173D5 RID: 95189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040173D6 RID: 95190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040173D7 RID: 95191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040173D8 RID: 95192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040173D9 RID: 95193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040173DA RID: 95194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040173DB RID: 95195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040173DC RID: 95196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040173DD RID: 95197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040173DE RID: 95198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040173DF RID: 95199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040173E0 RID: 95200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040173E1 RID: 95201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040173E2 RID: 95202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040173E3 RID: 95203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040173E4 RID: 95204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040173E5 RID: 95205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040173E6 RID: 95206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040173E7 RID: 95207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040173E8 RID: 95208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040173E9 RID: 95209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040173EA RID: 95210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040173EB RID: 95211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040173EC RID: 95212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040173ED RID: 95213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040173EE RID: 95214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040173EF RID: 95215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040173F0 RID: 95216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040173F1 RID: 95217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040173F2 RID: 95218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040173F3 RID: 95219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040173F4 RID: 95220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040173F5 RID: 95221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040173F6 RID: 95222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040173F7 RID: 95223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040173F8 RID: 95224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040173F9 RID: 95225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040173FA RID: 95226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040173FB RID: 95227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040173FC RID: 95228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040173FD RID: 95229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040173FE RID: 95230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040173FF RID: 95231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017400 RID: 95232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017401 RID: 95233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017402 RID: 95234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017403 RID: 95235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017404 RID: 95236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017405 RID: 95237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;
}
