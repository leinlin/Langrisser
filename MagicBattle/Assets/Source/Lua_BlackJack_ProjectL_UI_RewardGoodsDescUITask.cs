using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200155B RID: 5467
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask : LuaObject
{
	// Token: 0x06020B11 RID: 133905 RVA: 0x00AEE990 File Offset: 0x00AECB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			RewardGoodsDescUITask o = new RewardGoodsDescUITask(name);
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

	// Token: 0x06020B12 RID: 133906 RVA: 0x00AEE9E4 File Offset: 0x00AECBE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			PrefabControllerBase ctrl;
			LuaObject.checkType<PrefabControllerBase>(l, 1, out ctrl);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int alignType;
			LuaObject.checkType(l, 4, out alignType);
			GameObject gameObjectForPosCalc;
			LuaObject.checkType<GameObject>(l, 5, out gameObjectForPosCalc);
			bool isNeedAutoClose;
			LuaObject.checkType(l, 6, out isNeedAutoClose);
			RewardGoodsDescUITask o = RewardGoodsDescUITask.StartUITask(ctrl, goodsType, goodsId, alignType, gameObjectForPosCalc, isNeedAutoClose);
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

	// Token: 0x06020B13 RID: 133907 RVA: 0x00AEEA78 File Offset: 0x00AECC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			bool b = rewardGoodsDescUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06020B14 RID: 133908 RVA: 0x00AEEAD4 File Offset: 0x00AECCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B15 RID: 133909 RVA: 0x00AEEB28 File Offset: 0x00AECD28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B16 RID: 133910 RVA: 0x00AEEB7C File Offset: 0x00AECD7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = rewardGoodsDescUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x06020B17 RID: 133911 RVA: 0x00AEEBE4 File Offset: 0x00AECDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = rewardGoodsDescUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x06020B18 RID: 133912 RVA: 0x00AEEC4C File Offset: 0x00AECE4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			rewardGoodsDescUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B19 RID: 133913 RVA: 0x00AEECA8 File Offset: 0x00AECEA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B1A RID: 133914 RVA: 0x00AEECFC File Offset: 0x00AECEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RewardGoodsDescUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.RewardGoodsDescUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B1B RID: 133915 RVA: 0x00AEED50 File Offset: 0x00AECF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetData(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.ResetData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B1C RID: 133916 RVA: 0x00AEEDA4 File Offset: 0x00AECFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = rewardGoodsDescUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x06020B1D RID: 133917 RVA: 0x00AEEE0C File Offset: 0x00AED00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B1E RID: 133918 RVA: 0x00AEEE60 File Offset: 0x00AED060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B1F RID: 133919 RVA: 0x00AEEEB4 File Offset: 0x00AED0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = rewardGoodsDescUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06020B20 RID: 133920 RVA: 0x00AEEF1C File Offset: 0x00AED11C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = rewardGoodsDescUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06020B21 RID: 133921 RVA: 0x00AEEF84 File Offset: 0x00AED184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B22 RID: 133922 RVA: 0x00AEEFF0 File Offset: 0x00AED1F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			bool b = rewardGoodsDescUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06020B23 RID: 133923 RVA: 0x00AEF04C File Offset: 0x00AED24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			List<string> o = rewardGoodsDescUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06020B24 RID: 133924 RVA: 0x00AEF0A8 File Offset: 0x00AED2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B25 RID: 133925 RVA: 0x00AEF0FC File Offset: 0x00AED2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B26 RID: 133926 RVA: 0x00AEF150 File Offset: 0x00AED350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B27 RID: 133927 RVA: 0x00AEF1A4 File Offset: 0x00AED3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B28 RID: 133928 RVA: 0x00AEF1F8 File Offset: 0x00AED3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B29 RID: 133929 RVA: 0x00AEF24C File Offset: 0x00AED44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B2A RID: 133930 RVA: 0x00AEF2A8 File Offset: 0x00AED4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B2B RID: 133931 RVA: 0x00AEF304 File Offset: 0x00AED504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B2C RID: 133932 RVA: 0x00AEF360 File Offset: 0x00AED560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B2D RID: 133933 RVA: 0x00AEF3BC File Offset: 0x00AED5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			bool b = rewardGoodsDescUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x06020B2E RID: 133934 RVA: 0x00AEF418 File Offset: 0x00AED618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			bool b = rewardGoodsDescUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x06020B2F RID: 133935 RVA: 0x00AEF474 File Offset: 0x00AED674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			bool b = rewardGoodsDescUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06020B30 RID: 133936 RVA: 0x00AEF4D0 File Offset: 0x00AED6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			UITaskBase o = rewardGoodsDescUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06020B31 RID: 133937 RVA: 0x00AEF52C File Offset: 0x00AED72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B32 RID: 133938 RVA: 0x00AEF580 File Offset: 0x00AED780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B33 RID: 133939 RVA: 0x00AEF5D4 File Offset: 0x00AED7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B34 RID: 133940 RVA: 0x00AEF628 File Offset: 0x00AED828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			rewardGoodsDescUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B35 RID: 133941 RVA: 0x00AEF67C File Offset: 0x00AED87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_Type(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RewardGoodsDescUITask.LuaExportHelper.ParamKey_Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B36 RID: 133942 RVA: 0x00AEF6C4 File Offset: 0x00AED8C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_Id(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RewardGoodsDescUITask.LuaExportHelper.ParamKey_Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B37 RID: 133943 RVA: 0x00AEF70C File Offset: 0x00AED90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_Ctrl(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RewardGoodsDescUITask.LuaExportHelper.ParamKey_Ctrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B38 RID: 133944 RVA: 0x00AEF754 File Offset: 0x00AED954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_AlignType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RewardGoodsDescUITask.LuaExportHelper.ParamKey_AlignType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B39 RID: 133945 RVA: 0x00AEF79C File Offset: 0x00AED99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_GameObjectForPosScale(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RewardGoodsDescUITask.LuaExportHelper.ParamKey_GameObjectForPosScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B3A RID: 133946 RVA: 0x00AEF7E4 File Offset: 0x00AED9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_IsNeedAutoClose(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RewardGoodsDescUITask.LuaExportHelper.ParamKey_IsNeedAutoClose);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B3B RID: 133947 RVA: 0x00AEF82C File Offset: 0x00AEDA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_controller(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUITask.m_luaExportHelper.m_controller);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B3C RID: 133948 RVA: 0x00AEF884 File Offset: 0x00AEDA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_controller(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			PrefabControllerBase controller;
			LuaObject.checkType<PrefabControllerBase>(l, 2, out controller);
			rewardGoodsDescUITask.m_luaExportHelper.m_controller = controller;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B3D RID: 133949 RVA: 0x00AEF8E0 File Offset: 0x00AEDAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rewardGoodsDescUITask.m_luaExportHelper.m_goodsType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B3E RID: 133950 RVA: 0x00AEF938 File Offset: 0x00AEDB38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			rewardGoodsDescUITask.m_luaExportHelper.m_goodsType = goodsType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B3F RID: 133951 RVA: 0x00AEF994 File Offset: 0x00AEDB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsId(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUITask.m_luaExportHelper.m_goodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B40 RID: 133952 RVA: 0x00AEF9EC File Offset: 0x00AEDBEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsId(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			rewardGoodsDescUITask.m_luaExportHelper.m_goodsId = goodsId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B41 RID: 133953 RVA: 0x00AEFA48 File Offset: 0x00AEDC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_alignType(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUITask.m_luaExportHelper.m_alignType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B42 RID: 133954 RVA: 0x00AEFAA0 File Offset: 0x00AEDCA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_alignType(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			int alignType;
			LuaObject.checkType(l, 2, out alignType);
			rewardGoodsDescUITask.m_luaExportHelper.m_alignType = alignType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B43 RID: 133955 RVA: 0x00AEFAFC File Offset: 0x00AEDCFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameObjectForPosCalc(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUITask.m_luaExportHelper.m_gameObjectForPosCalc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B44 RID: 133956 RVA: 0x00AEFB54 File Offset: 0x00AEDD54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gameObjectForPosCalc(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			GameObject gameObjectForPosCalc;
			LuaObject.checkType<GameObject>(l, 2, out gameObjectForPosCalc);
			rewardGoodsDescUITask.m_luaExportHelper.m_gameObjectForPosCalc = gameObjectForPosCalc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B45 RID: 133957 RVA: 0x00AEFBB0 File Offset: 0x00AEDDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNeedAutoClose(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUITask.m_luaExportHelper.m_isNeedAutoClose);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B46 RID: 133958 RVA: 0x00AEFC08 File Offset: 0x00AEDE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNeedAutoClose(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			bool isNeedAutoClose;
			LuaObject.checkType(l, 2, out isNeedAutoClose);
			rewardGoodsDescUITask.m_luaExportHelper.m_isNeedAutoClose = isNeedAutoClose;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B47 RID: 133959 RVA: 0x00AEFC64 File Offset: 0x00AEDE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					rewardGoodsDescUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					rewardGoodsDescUITask.EventOnClose -= value;
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

	// Token: 0x06020B48 RID: 133960 RVA: 0x00AEFCE4 File Offset: 0x00AEDEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B49 RID: 133961 RVA: 0x00AEFD3C File Offset: 0x00AEDF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			rewardGoodsDescUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B4A RID: 133962 RVA: 0x00AEFD98 File Offset: 0x00AEDF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B4B RID: 133963 RVA: 0x00AEFDF0 File Offset: 0x00AEDFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			rewardGoodsDescUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B4C RID: 133964 RVA: 0x00AEFE4C File Offset: 0x00AEE04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGoodsDescUIController(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUITask.m_luaExportHelper.m_rewardGoodsDescUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B4D RID: 133965 RVA: 0x00AEFEA4 File Offset: 0x00AEE0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGoodsDescUIController(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			RewardGoodsDescUIController rewardGoodsDescUIController;
			LuaObject.checkType<RewardGoodsDescUIController>(l, 2, out rewardGoodsDescUIController);
			rewardGoodsDescUITask.m_luaExportHelper.m_rewardGoodsDescUIController = rewardGoodsDescUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B4E RID: 133966 RVA: 0x00AEFF00 File Offset: 0x00AEE100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B4F RID: 133967 RVA: 0x00AEFF58 File Offset: 0x00AEE158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUITask rewardGoodsDescUITask = (RewardGoodsDescUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B50 RID: 133968 RVA: 0x00AEFFB0 File Offset: 0x00AEE1B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RewardGoodsDescUITask");
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.RewardGoodsDescUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.ResetData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache22);
		string name = "ParamKey_Type";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_ParamKey_Type);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache23, null, false);
		string name2 = "ParamKey_Id";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_ParamKey_Id);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache24, null, false);
		string name3 = "ParamKey_Ctrl";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_ParamKey_Ctrl);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache25, null, false);
		string name4 = "ParamKey_AlignType";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_ParamKey_AlignType);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache26, null, false);
		string name5 = "ParamKey_GameObjectForPosScale";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_ParamKey_GameObjectForPosScale);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache27, null, false);
		string name6 = "ParamKey_IsNeedAutoClose";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_ParamKey_IsNeedAutoClose);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache28, null, false);
		string name7 = "m_controller";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_m_controller);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.set_m_controller);
		}
		LuaObject.addMember(l, name7, get, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2A, true);
		string name8 = "m_goodsType";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_m_goodsType);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.set_m_goodsType);
		}
		LuaObject.addMember(l, name8, get2, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2C, true);
		string name9 = "m_goodsId";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_m_goodsId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.set_m_goodsId);
		}
		LuaObject.addMember(l, name9, get3, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2E, true);
		string name10 = "m_alignType";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_m_alignType);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.set_m_alignType);
		}
		LuaObject.addMember(l, name10, get4, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache30, true);
		string name11 = "m_gameObjectForPosCalc";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_m_gameObjectForPosCalc);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.set_m_gameObjectForPosCalc);
		}
		LuaObject.addMember(l, name11, get5, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache32, true);
		string name12 = "m_isNeedAutoClose";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_m_isNeedAutoClose);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.set_m_isNeedAutoClose);
		}
		LuaObject.addMember(l, name12, get6, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache34, true);
		string name13 = "EventOnClose";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name13, get7, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache35, true);
		string name14 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_m_layerDescArray);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name14, get8, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache37, true);
		string name15 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name15, get9, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache39, true);
		string name16 = "m_rewardGoodsDescUIController";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_m_rewardGoodsDescUIController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.set_m_rewardGoodsDescUIController);
		}
		LuaObject.addMember(l, name16, get10, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3B, true);
		string name17 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3C, null, true);
		string name18 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3D, null, true);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.<>f__mg$cache3E, typeof(RewardGoodsDescUITask), typeof(UITask));
	}

	// Token: 0x04016A3D RID: 92733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016A3E RID: 92734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016A3F RID: 92735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016A40 RID: 92736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016A41 RID: 92737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016A42 RID: 92738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016A43 RID: 92739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016A44 RID: 92740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016A45 RID: 92741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016A46 RID: 92742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016A47 RID: 92743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016A48 RID: 92744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016A49 RID: 92745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016A4A RID: 92746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016A4B RID: 92747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016A4C RID: 92748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016A4D RID: 92749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016A4E RID: 92750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016A4F RID: 92751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016A50 RID: 92752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016A51 RID: 92753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016A52 RID: 92754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016A53 RID: 92755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016A54 RID: 92756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016A55 RID: 92757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016A56 RID: 92758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016A57 RID: 92759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016A58 RID: 92760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016A59 RID: 92761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016A5A RID: 92762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016A5B RID: 92763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016A5C RID: 92764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016A5D RID: 92765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016A5E RID: 92766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016A5F RID: 92767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016A60 RID: 92768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016A61 RID: 92769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016A62 RID: 92770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016A63 RID: 92771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016A64 RID: 92772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016A65 RID: 92773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016A66 RID: 92774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016A67 RID: 92775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016A68 RID: 92776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016A69 RID: 92777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016A6A RID: 92778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016A6B RID: 92779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016A6C RID: 92780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016A6D RID: 92781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016A6E RID: 92782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016A6F RID: 92783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016A70 RID: 92784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016A71 RID: 92785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016A72 RID: 92786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016A73 RID: 92787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016A74 RID: 92788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016A75 RID: 92789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016A76 RID: 92790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016A77 RID: 92791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016A78 RID: 92792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04016A79 RID: 92793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04016A7A RID: 92794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04016A7B RID: 92795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;
}
