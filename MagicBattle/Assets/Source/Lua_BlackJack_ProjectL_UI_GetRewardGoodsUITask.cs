using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001461 RID: 5217
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask : LuaObject
{
	// Token: 0x0601E222 RID: 123426 RVA: 0x009A9BCC File Offset: 0x009A7DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			GetRewardGoodsUITask o = new GetRewardGoodsUITask(name);
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

	// Token: 0x0601E223 RID: 123427 RVA: 0x009A9C20 File Offset: 0x009A7E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = getRewardGoodsUITask.OnNewIntent(intent);
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

	// Token: 0x0601E224 RID: 123428 RVA: 0x009A9C84 File Offset: 0x009A7E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			List<Goods> rewardGoodsList;
			LuaObject.checkType<List<Goods>>(l, 1, out rewardGoodsList);
			GetRewardGoodsUITask o = GetRewardGoodsUITask.StartUITask(rewardGoodsList);
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

	// Token: 0x0601E225 RID: 123429 RVA: 0x009A9CD8 File Offset: 0x009A7ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = getRewardGoodsUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601E226 RID: 123430 RVA: 0x009A9D40 File Offset: 0x009A7F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = getRewardGoodsUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601E227 RID: 123431 RVA: 0x009A9DA8 File Offset: 0x009A7FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			getRewardGoodsUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E228 RID: 123432 RVA: 0x009A9E04 File Offset: 0x009A8004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			bool b = getRewardGoodsUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601E229 RID: 123433 RVA: 0x009A9E60 File Offset: 0x009A8060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E22A RID: 123434 RVA: 0x009A9EB4 File Offset: 0x009A80B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E22B RID: 123435 RVA: 0x009A9F08 File Offset: 0x009A8108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E22C RID: 123436 RVA: 0x009A9F5C File Offset: 0x009A815C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRewardGoodsUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.GetRewardGoodsUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E22D RID: 123437 RVA: 0x009A9FB0 File Offset: 0x009A81B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = getRewardGoodsUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601E22E RID: 123438 RVA: 0x009AA018 File Offset: 0x009A8218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E22F RID: 123439 RVA: 0x009AA06C File Offset: 0x009A826C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E230 RID: 123440 RVA: 0x009AA0C0 File Offset: 0x009A82C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = getRewardGoodsUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601E231 RID: 123441 RVA: 0x009AA128 File Offset: 0x009A8328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = getRewardGoodsUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601E232 RID: 123442 RVA: 0x009AA190 File Offset: 0x009A8390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E233 RID: 123443 RVA: 0x009AA1FC File Offset: 0x009A83FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			bool b = getRewardGoodsUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601E234 RID: 123444 RVA: 0x009AA258 File Offset: 0x009A8458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			List<string> o = getRewardGoodsUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601E235 RID: 123445 RVA: 0x009AA2B4 File Offset: 0x009A84B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E236 RID: 123446 RVA: 0x009AA308 File Offset: 0x009A8508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E237 RID: 123447 RVA: 0x009AA35C File Offset: 0x009A855C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E238 RID: 123448 RVA: 0x009AA3B0 File Offset: 0x009A85B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E239 RID: 123449 RVA: 0x009AA404 File Offset: 0x009A8604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E23A RID: 123450 RVA: 0x009AA458 File Offset: 0x009A8658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E23B RID: 123451 RVA: 0x009AA4B4 File Offset: 0x009A86B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E23C RID: 123452 RVA: 0x009AA510 File Offset: 0x009A8710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E23D RID: 123453 RVA: 0x009AA56C File Offset: 0x009A876C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E23E RID: 123454 RVA: 0x009AA5C8 File Offset: 0x009A87C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			bool b = getRewardGoodsUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601E23F RID: 123455 RVA: 0x009AA624 File Offset: 0x009A8824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			bool b = getRewardGoodsUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601E240 RID: 123456 RVA: 0x009AA680 File Offset: 0x009A8880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			bool b = getRewardGoodsUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601E241 RID: 123457 RVA: 0x009AA6DC File Offset: 0x009A88DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			UITaskBase o = getRewardGoodsUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601E242 RID: 123458 RVA: 0x009AA738 File Offset: 0x009A8938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E243 RID: 123459 RVA: 0x009AA78C File Offset: 0x009A898C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E244 RID: 123460 RVA: 0x009AA7E0 File Offset: 0x009A89E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E245 RID: 123461 RVA: 0x009AA834 File Offset: 0x009A8A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			getRewardGoodsUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E246 RID: 123462 RVA: 0x009AA888 File Offset: 0x009A8A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					getRewardGoodsUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					getRewardGoodsUITask.EventOnClose -= value;
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

	// Token: 0x0601E247 RID: 123463 RVA: 0x009AA908 File Offset: 0x009A8B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getRewardGoodsUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E248 RID: 123464 RVA: 0x009AA960 File Offset: 0x009A8B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			getRewardGoodsUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E249 RID: 123465 RVA: 0x009AA9BC File Offset: 0x009A8BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getRewardGoodsUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E24A RID: 123466 RVA: 0x009AAA14 File Offset: 0x009A8C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			getRewardGoodsUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E24B RID: 123467 RVA: 0x009AAA70 File Offset: 0x009A8C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_RewardGoodsList(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GetRewardGoodsUITask.LuaExportHelper.ParamKey_RewardGoodsList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E24C RID: 123468 RVA: 0x009AAAB8 File Offset: 0x009A8CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getRewardGoodsUIController(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getRewardGoodsUITask.m_luaExportHelper.m_getRewardGoodsUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E24D RID: 123469 RVA: 0x009AAB10 File Offset: 0x009A8D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getRewardGoodsUIController(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			GetRewardGoodsUIController getRewardGoodsUIController;
			LuaObject.checkType<GetRewardGoodsUIController>(l, 2, out getRewardGoodsUIController);
			getRewardGoodsUITask.m_luaExportHelper.m_getRewardGoodsUIController = getRewardGoodsUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E24E RID: 123470 RVA: 0x009AAB6C File Offset: 0x009A8D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGoodsList(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getRewardGoodsUITask.m_luaExportHelper.m_rewardGoodsList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E24F RID: 123471 RVA: 0x009AABC4 File Offset: 0x009A8DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGoodsList(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			List<Goods> rewardGoodsList;
			LuaObject.checkType<List<Goods>>(l, 2, out rewardGoodsList);
			getRewardGoodsUITask.m_luaExportHelper.m_rewardGoodsList = rewardGoodsList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E250 RID: 123472 RVA: 0x009AAC20 File Offset: 0x009A8E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getRewardGoodsUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E251 RID: 123473 RVA: 0x009AAC78 File Offset: 0x009A8E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			GetRewardGoodsUITask getRewardGoodsUITask = (GetRewardGoodsUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getRewardGoodsUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E252 RID: 123474 RVA: 0x009AACD0 File Offset: 0x009A8ED0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GetRewardGoodsUITask");
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.GetRewardGoodsUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache22);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache23, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache25, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache27, true);
		string name4 = "ParamKey_RewardGoodsList";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.get_ParamKey_RewardGoodsList);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache28, null, false);
		string name5 = "m_getRewardGoodsUIController";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.get_m_getRewardGoodsUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.set_m_getRewardGoodsUIController);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2A, true);
		string name6 = "m_rewardGoodsList";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.get_m_rewardGoodsList);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.set_m_rewardGoodsList);
		}
		LuaObject.addMember(l, name6, get5, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2C, true);
		string name7 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2D, null, true);
		string name8 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2E, null, true);
		if (Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.<>f__mg$cache2F, typeof(GetRewardGoodsUITask), typeof(UITask));
	}

	// Token: 0x04014342 RID: 82754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014343 RID: 82755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014344 RID: 82756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014345 RID: 82757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014346 RID: 82758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014347 RID: 82759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014348 RID: 82760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014349 RID: 82761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401434A RID: 82762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401434B RID: 82763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401434C RID: 82764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401434D RID: 82765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401434E RID: 82766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401434F RID: 82767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014350 RID: 82768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014351 RID: 82769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014352 RID: 82770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014353 RID: 82771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014354 RID: 82772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014355 RID: 82773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014356 RID: 82774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014357 RID: 82775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014358 RID: 82776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014359 RID: 82777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401435A RID: 82778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401435B RID: 82779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401435C RID: 82780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401435D RID: 82781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401435E RID: 82782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401435F RID: 82783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014360 RID: 82784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014361 RID: 82785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014362 RID: 82786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014363 RID: 82787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014364 RID: 82788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014365 RID: 82789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014366 RID: 82790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014367 RID: 82791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014368 RID: 82792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014369 RID: 82793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401436A RID: 82794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401436B RID: 82795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401436C RID: 82796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401436D RID: 82797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401436E RID: 82798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401436F RID: 82799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014370 RID: 82800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014371 RID: 82801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
