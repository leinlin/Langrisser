using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013E1 RID: 5089
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BuyEnergyUITask : LuaObject
{
	// Token: 0x0601C8A6 RID: 116902 RVA: 0x008DED9C File Offset: 0x008DCF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			BuyEnergyUITask o = new BuyEnergyUITask(name);
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

	// Token: 0x0601C8A7 RID: 116903 RVA: 0x008DEDF0 File Offset: 0x008DCFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			bool showEnergyNotEnoughTips;
			LuaObject.checkType(l, 1, out showEnergyNotEnoughTips);
			BuyEnergyUITask o = BuyEnergyUITask.StartUITask(showEnergyNotEnoughTips);
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

	// Token: 0x0601C8A8 RID: 116904 RVA: 0x008DEE44 File Offset: 0x008DD044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8A9 RID: 116905 RVA: 0x008DEE98 File Offset: 0x008DD098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8AA RID: 116906 RVA: 0x008DEEEC File Offset: 0x008DD0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8AB RID: 116907 RVA: 0x008DEF40 File Offset: 0x008DD140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBuyEnergyNetTask(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.StartBuyEnergyNetTask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8AC RID: 116908 RVA: 0x008DEF94 File Offset: 0x008DD194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUseEnergyMedicineNetTask(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.StartUseEnergyMedicineNetTask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8AD RID: 116909 RVA: 0x008DEFE8 File Offset: 0x008DD1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEnergyRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			int energy;
			LuaObject.checkType(l, 2, out energy);
			buyEnergyUITask.m_luaExportHelper.ShowEnergyRewardGoodsUITask(energy);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8AE RID: 116910 RVA: 0x008DF044 File Offset: 0x008DD244
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRewardGoodsUITask_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.GetRewardGoodsUITask_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8AF RID: 116911 RVA: 0x008DF098 File Offset: 0x008DD298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyEnergyUIController_OnUseEnergyMedicine(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.BuyEnergyUIController_OnUseEnergyMedicine();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8B0 RID: 116912 RVA: 0x008DF0EC File Offset: 0x008DD2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyEnergyUIController_OnBuyEnergy(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.BuyEnergyUIController_OnBuyEnergy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8B1 RID: 116913 RVA: 0x008DF140 File Offset: 0x008DD340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyEnergyUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.BuyEnergyUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8B2 RID: 116914 RVA: 0x008DF194 File Offset: 0x008DD394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = buyEnergyUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601C8B3 RID: 116915 RVA: 0x008DF1FC File Offset: 0x008DD3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8B4 RID: 116916 RVA: 0x008DF250 File Offset: 0x008DD450
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8B5 RID: 116917 RVA: 0x008DF2A4 File Offset: 0x008DD4A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = buyEnergyUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601C8B6 RID: 116918 RVA: 0x008DF30C File Offset: 0x008DD50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = buyEnergyUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601C8B7 RID: 116919 RVA: 0x008DF374 File Offset: 0x008DD574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			buyEnergyUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8B8 RID: 116920 RVA: 0x008DF3E0 File Offset: 0x008DD5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			bool b = buyEnergyUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601C8B9 RID: 116921 RVA: 0x008DF43C File Offset: 0x008DD63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			List<string> o = buyEnergyUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601C8BA RID: 116922 RVA: 0x008DF498 File Offset: 0x008DD698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8BB RID: 116923 RVA: 0x008DF4EC File Offset: 0x008DD6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8BC RID: 116924 RVA: 0x008DF540 File Offset: 0x008DD740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8BD RID: 116925 RVA: 0x008DF594 File Offset: 0x008DD794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8BE RID: 116926 RVA: 0x008DF5E8 File Offset: 0x008DD7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8BF RID: 116927 RVA: 0x008DF63C File Offset: 0x008DD83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			buyEnergyUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8C0 RID: 116928 RVA: 0x008DF698 File Offset: 0x008DD898
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			buyEnergyUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8C1 RID: 116929 RVA: 0x008DF6F4 File Offset: 0x008DD8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			buyEnergyUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8C2 RID: 116930 RVA: 0x008DF750 File Offset: 0x008DD950
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			buyEnergyUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8C3 RID: 116931 RVA: 0x008DF7AC File Offset: 0x008DD9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			bool b = buyEnergyUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601C8C4 RID: 116932 RVA: 0x008DF808 File Offset: 0x008DDA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			bool b = buyEnergyUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601C8C5 RID: 116933 RVA: 0x008DF864 File Offset: 0x008DDA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			bool b = buyEnergyUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601C8C6 RID: 116934 RVA: 0x008DF8C0 File Offset: 0x008DDAC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			UITaskBase o = buyEnergyUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601C8C7 RID: 116935 RVA: 0x008DF91C File Offset: 0x008DDB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8C8 RID: 116936 RVA: 0x008DF970 File Offset: 0x008DDB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			buyEnergyUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8C9 RID: 116937 RVA: 0x008DF9C4 File Offset: 0x008DDBC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8CA RID: 116938 RVA: 0x008DFA1C File Offset: 0x008DDC1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			buyEnergyUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8CB RID: 116939 RVA: 0x008DFA78 File Offset: 0x008DDC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8CC RID: 116940 RVA: 0x008DFAD0 File Offset: 0x008DDCD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			buyEnergyUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8CD RID: 116941 RVA: 0x008DFB2C File Offset: 0x008DDD2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_buyEnergyUIController(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUITask.m_luaExportHelper.m_buyEnergyUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8CE RID: 116942 RVA: 0x008DFB84 File Offset: 0x008DDD84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_buyEnergyUIController(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			BuyEnergyUIController buyEnergyUIController;
			LuaObject.checkType<BuyEnergyUIController>(l, 2, out buyEnergyUIController);
			buyEnergyUITask.m_luaExportHelper.m_buyEnergyUIController = buyEnergyUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8CF RID: 116943 RVA: 0x008DFBE0 File Offset: 0x008DDDE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUITask.m_luaExportHelper.m_getRewardGoodsUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8D0 RID: 116944 RVA: 0x008DFC38 File Offset: 0x008DDE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			GetRewardGoodsUITask getRewardGoodsUITask;
			LuaObject.checkType<GetRewardGoodsUITask>(l, 2, out getRewardGoodsUITask);
			buyEnergyUITask.m_luaExportHelper.m_getRewardGoodsUITask = getRewardGoodsUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8D1 RID: 116945 RVA: 0x008DFC94 File Offset: 0x008DDE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyMedicineItemID(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUITask.m_luaExportHelper.m_energyMedicineItemID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8D2 RID: 116946 RVA: 0x008DFCEC File Offset: 0x008DDEEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_energyMedicineItemID(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			int energyMedicineItemID;
			LuaObject.checkType(l, 2, out energyMedicineItemID);
			buyEnergyUITask.m_luaExportHelper.m_energyMedicineItemID = energyMedicineItemID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8D3 RID: 116947 RVA: 0x008DFD48 File Offset: 0x008DDF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getEnergyByUseEnergyMedicine(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUITask.m_luaExportHelper.m_getEnergyByUseEnergyMedicine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8D4 RID: 116948 RVA: 0x008DFDA0 File Offset: 0x008DDFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getEnergyByUseEnergyMedicine(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			int getEnergyByUseEnergyMedicine;
			LuaObject.checkType(l, 2, out getEnergyByUseEnergyMedicine);
			buyEnergyUITask.m_luaExportHelper.m_getEnergyByUseEnergyMedicine = getEnergyByUseEnergyMedicine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8D5 RID: 116949 RVA: 0x008DFDFC File Offset: 0x008DDFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Params_NeedEnergyNotEnoughTips(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "NeedShowEnergyNotEnoughTips");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8D6 RID: 116950 RVA: 0x008DFE44 File Offset: 0x008DE044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8D7 RID: 116951 RVA: 0x008DFE9C File Offset: 0x008DE09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUITask buyEnergyUITask = (BuyEnergyUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8D8 RID: 116952 RVA: 0x008DFEF4 File Offset: 0x008DE0F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BuyEnergyUITask");
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.StartBuyEnergyNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.StartUseEnergyMedicineNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.ShowEnergyRewardGoodsUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.GetRewardGoodsUITask_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.BuyEnergyUIController_OnUseEnergyMedicine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.BuyEnergyUIController_OnBuyEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.BuyEnergyUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache21);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache23, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache25, true);
		string name3 = "m_buyEnergyUIController";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.get_m_buyEnergyUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.set_m_buyEnergyUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache27, true);
		string name4 = "m_getRewardGoodsUITask";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.get_m_getRewardGoodsUITask);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.set_m_getRewardGoodsUITask);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache29, true);
		string name5 = "m_energyMedicineItemID";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.get_m_energyMedicineItemID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.set_m_energyMedicineItemID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2B, true);
		string name6 = "m_getEnergyByUseEnergyMedicine";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.get_m_getEnergyByUseEnergyMedicine);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.set_m_getEnergyByUseEnergyMedicine);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2D, true);
		string name7 = "Params_NeedEnergyNotEnoughTips";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.get_Params_NeedEnergyNotEnoughTips);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2E, null, false);
		string name8 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache2F, null, true);
		string name9 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache30, null, true);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.<>f__mg$cache31, typeof(BuyEnergyUITask), typeof(UITask));
	}

	// Token: 0x04012AC6 RID: 76486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012AC7 RID: 76487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012AC8 RID: 76488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012AC9 RID: 76489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012ACA RID: 76490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012ACB RID: 76491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012ACC RID: 76492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012ACD RID: 76493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012ACE RID: 76494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012ACF RID: 76495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012AD0 RID: 76496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012AD1 RID: 76497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012AD2 RID: 76498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012AD3 RID: 76499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012AD4 RID: 76500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012AD5 RID: 76501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012AD6 RID: 76502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012AD7 RID: 76503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012AD8 RID: 76504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012AD9 RID: 76505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012ADA RID: 76506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012ADB RID: 76507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012ADC RID: 76508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012ADD RID: 76509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012ADE RID: 76510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012ADF RID: 76511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012AE0 RID: 76512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012AE1 RID: 76513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012AE2 RID: 76514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012AE3 RID: 76515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012AE4 RID: 76516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012AE5 RID: 76517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012AE6 RID: 76518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012AE7 RID: 76519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012AE8 RID: 76520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012AE9 RID: 76521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012AEA RID: 76522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012AEB RID: 76523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012AEC RID: 76524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012AED RID: 76525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012AEE RID: 76526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012AEF RID: 76527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012AF0 RID: 76528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012AF1 RID: 76529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012AF2 RID: 76530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012AF3 RID: 76531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012AF4 RID: 76532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012AF5 RID: 76533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012AF6 RID: 76534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012AF7 RID: 76535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;
}
