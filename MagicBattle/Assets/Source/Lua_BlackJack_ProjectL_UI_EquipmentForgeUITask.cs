using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200142B RID: 5163
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask : LuaObject
{
	// Token: 0x0601D9FA RID: 121338 RVA: 0x00968BA8 File Offset: 0x00966DA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			EquipmentForgeUITask o = new EquipmentForgeUITask(name);
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

	// Token: 0x0601D9FB RID: 121339 RVA: 0x00968BFC File Offset: 0x00966DFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9FC RID: 121340 RVA: 0x00968C50 File Offset: 0x00966E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D9FD RID: 121341 RVA: 0x00968CA4 File Offset: 0x00966EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = equipmentForgeUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601D9FE RID: 121342 RVA: 0x00968D0C File Offset: 0x00966F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = equipmentForgeUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601D9FF RID: 121343 RVA: 0x00968D74 File Offset: 0x00966F74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			equipmentForgeUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA00 RID: 121344 RVA: 0x00968DD0 File Offset: 0x00966FD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA01 RID: 121345 RVA: 0x00968E24 File Offset: 0x00967024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EquipmentForgeUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.EquipmentForgeUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA02 RID: 121346 RVA: 0x00968E78 File Offset: 0x00967078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentForgeUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.EquipmentForgeUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA03 RID: 121347 RVA: 0x00968ECC File Offset: 0x009670CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EquipmentForgeUIController_OnEquipmentEnhance(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			List<ulong> materialIds;
			LuaObject.checkType<List<ulong>>(l, 3, out materialIds);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 4, out onSucceed);
			int slot;
			LuaObject.checkType(l, 5, out slot);
			equipmentForgeUITask.m_luaExportHelper.EquipmentForgeUIController_OnEquipmentEnhance(instanceId, materialIds, onSucceed, slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA04 RID: 121348 RVA: 0x00968F50 File Offset: 0x00967150
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EquipmentForgeUIController_OnEquipmentStarLevelUp(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			ulong materialId;
			LuaObject.checkType(l, 3, out materialId);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 4, out onSucceed);
			int slot;
			LuaObject.checkType(l, 5, out slot);
			equipmentForgeUITask.m_luaExportHelper.EquipmentForgeUIController_OnEquipmentStarLevelUp(instanceId, materialId, onSucceed, slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA05 RID: 121349 RVA: 0x00968FD4 File Offset: 0x009671D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentForgeUIController_OnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			EquipmentForgeUIController.ForgeState forgeState;
			LuaObject.checkEnum<EquipmentForgeUIController.ForgeState>(l, 4, out forgeState);
			equipmentForgeUITask.m_luaExportHelper.EquipmentForgeUIController_OnGoldAddButtonClick(instanceId, slot, forgeState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA06 RID: 121350 RVA: 0x0096904C File Offset: 0x0096724C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentForgeUIController_OnEnhanceNeedItemClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int needCount;
			LuaObject.checkType(l, 4, out needCount);
			equipmentForgeUITask.m_luaExportHelper.EquipmentForgeUIController_OnEnhanceNeedItemClick(goodsType, goodsId, needCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA07 RID: 121351 RVA: 0x009690C4 File Offset: 0x009672C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentForge_OnGotoGetPath(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			GetPathData getPath;
			LuaObject.checkType<GetPathData>(l, 2, out getPath);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 3, out needGoods);
			equipmentForgeUITask.m_luaExportHelper.EquipmentForge_OnGotoGetPath(getPath, needGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA08 RID: 121352 RVA: 0x00969130 File Offset: 0x00967330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentForgeUIController_OnEnchantButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			ulong stoneInstanceId;
			LuaObject.checkType(l, 3, out stoneInstanceId);
			Action<int, List<CommonBattleProperty>> onSucceed;
			LuaObject.checkDelegate<Action<int, List<CommonBattleProperty>>>(l, 4, out onSucceed);
			equipmentForgeUITask.m_luaExportHelper.EquipmentForgeUIController_OnEnchantButtonClick(instanceId, stoneInstanceId, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA09 RID: 121353 RVA: 0x009691A8 File Offset: 0x009673A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentForgeUIController_OnEnchantSaveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			Action onSucceed;
			LuaObject.checkDelegate<Action>(l, 2, out onSucceed);
			equipmentForgeUITask.m_luaExportHelper.EquipmentForgeUIController_OnEnchantSaveButtonClick(onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA0A RID: 121354 RVA: 0x00969204 File Offset: 0x00967404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentForgeUIController_OnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.EquipmentForgeUIController_OnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA0B RID: 121355 RVA: 0x00969258 File Offset: 0x00967458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = equipmentForgeUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601DA0C RID: 121356 RVA: 0x009692C0 File Offset: 0x009674C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA0D RID: 121357 RVA: 0x00969314 File Offset: 0x00967514
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA0E RID: 121358 RVA: 0x00969368 File Offset: 0x00967568
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = equipmentForgeUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601DA0F RID: 121359 RVA: 0x009693D0 File Offset: 0x009675D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = equipmentForgeUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601DA10 RID: 121360 RVA: 0x00969438 File Offset: 0x00967638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			equipmentForgeUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA11 RID: 121361 RVA: 0x009694A4 File Offset: 0x009676A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			bool b = equipmentForgeUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601DA12 RID: 121362 RVA: 0x00969500 File Offset: 0x00967700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			List<string> o = equipmentForgeUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601DA13 RID: 121363 RVA: 0x0096955C File Offset: 0x0096775C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA14 RID: 121364 RVA: 0x009695B0 File Offset: 0x009677B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA15 RID: 121365 RVA: 0x00969604 File Offset: 0x00967804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA16 RID: 121366 RVA: 0x00969658 File Offset: 0x00967858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA17 RID: 121367 RVA: 0x009696AC File Offset: 0x009678AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA18 RID: 121368 RVA: 0x00969700 File Offset: 0x00967900
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			equipmentForgeUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA19 RID: 121369 RVA: 0x0096975C File Offset: 0x0096795C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			equipmentForgeUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA1A RID: 121370 RVA: 0x009697B8 File Offset: 0x009679B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			equipmentForgeUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA1B RID: 121371 RVA: 0x00969814 File Offset: 0x00967A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			equipmentForgeUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA1C RID: 121372 RVA: 0x00969870 File Offset: 0x00967A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			bool b = equipmentForgeUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601DA1D RID: 121373 RVA: 0x009698CC File Offset: 0x00967ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			bool b = equipmentForgeUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601DA1E RID: 121374 RVA: 0x00969928 File Offset: 0x00967B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			bool b = equipmentForgeUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601DA1F RID: 121375 RVA: 0x00969984 File Offset: 0x00967B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			UITaskBase o = equipmentForgeUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601DA20 RID: 121376 RVA: 0x009699E0 File Offset: 0x00967BE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA21 RID: 121377 RVA: 0x00969A34 File Offset: 0x00967C34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			equipmentForgeUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA22 RID: 121378 RVA: 0x00969A88 File Offset: 0x00967C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA23 RID: 121379 RVA: 0x00969AE0 File Offset: 0x00967CE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			equipmentForgeUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA24 RID: 121380 RVA: 0x00969B3C File Offset: 0x00967D3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA25 RID: 121381 RVA: 0x00969B94 File Offset: 0x00967D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			equipmentForgeUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA26 RID: 121382 RVA: 0x00969BF0 File Offset: 0x00967DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUITask.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA27 RID: 121383 RVA: 0x00969C48 File Offset: 0x00967E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			equipmentForgeUITask.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA28 RID: 121384 RVA: 0x00969CA4 File Offset: 0x00967EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_slot(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUITask.m_luaExportHelper.m_slot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA29 RID: 121385 RVA: 0x00969CFC File Offset: 0x00967EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_slot(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			equipmentForgeUITask.m_luaExportHelper.m_slot = slot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA2A RID: 121386 RVA: 0x00969D58 File Offset: 0x00967F58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_instanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUITask.m_luaExportHelper.m_instanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA2B RID: 121387 RVA: 0x00969DB0 File Offset: 0x00967FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_instanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			equipmentForgeUITask.m_luaExportHelper.m_instanceId = instanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA2C RID: 121388 RVA: 0x00969E0C File Offset: 0x0096800C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_forgeState(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)equipmentForgeUITask.m_luaExportHelper.m_forgeState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA2D RID: 121389 RVA: 0x00969E64 File Offset: 0x00968064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_forgeState(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			EquipmentForgeUIController.ForgeState forgeState;
			LuaObject.checkEnum<EquipmentForgeUIController.ForgeState>(l, 2, out forgeState);
			equipmentForgeUITask.m_luaExportHelper.m_forgeState = forgeState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA2E RID: 121390 RVA: 0x00969EC0 File Offset: 0x009680C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentForgeUIController(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUITask.m_luaExportHelper.m_equipmentForgeUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA2F RID: 121391 RVA: 0x00969F18 File Offset: 0x00968118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_equipmentForgeUIController(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			EquipmentForgeUIController equipmentForgeUIController;
			LuaObject.checkType<EquipmentForgeUIController>(l, 2, out equipmentForgeUIController);
			equipmentForgeUITask.m_luaExportHelper.m_equipmentForgeUIController = equipmentForgeUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA30 RID: 121392 RVA: 0x00969F74 File Offset: 0x00968174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA31 RID: 121393 RVA: 0x00969FCC File Offset: 0x009681CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			EquipmentForgeUITask equipmentForgeUITask = (EquipmentForgeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentForgeUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA32 RID: 121394 RVA: 0x0096A024 File Offset: 0x00968224
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentForgeUITask");
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.EquipmentForgeUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.EquipmentForgeUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.EquipmentForgeUIController_OnEquipmentEnhance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.EquipmentForgeUIController_OnEquipmentStarLevelUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.EquipmentForgeUIController_OnGoldAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.EquipmentForgeUIController_OnEnhanceNeedItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.EquipmentForge_OnGotoGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.EquipmentForgeUIController_OnEnchantButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.EquipmentForgeUIController_OnEnchantSaveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.EquipmentForgeUIController_OnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache26);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache28, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2A, true);
		string name3 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.get_m_hero);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.set_m_hero);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2C, true);
		string name4 = "m_slot";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.get_m_slot);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.set_m_slot);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2E, true);
		string name5 = "m_instanceId";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.get_m_instanceId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.set_m_instanceId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache30, true);
		string name6 = "m_forgeState";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.get_m_forgeState);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.set_m_forgeState);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache32, true);
		string name7 = "m_equipmentForgeUIController";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.get_m_equipmentForgeUIController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.set_m_equipmentForgeUIController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache34, true);
		string name8 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache35, null, true);
		string name9 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache36, null, true);
		if (Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.<>f__mg$cache37, typeof(EquipmentForgeUITask), typeof(UITask));
	}

	// Token: 0x04013B86 RID: 80774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013B87 RID: 80775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013B88 RID: 80776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013B89 RID: 80777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013B8A RID: 80778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013B8B RID: 80779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013B8C RID: 80780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013B8D RID: 80781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013B8E RID: 80782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013B8F RID: 80783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013B90 RID: 80784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013B91 RID: 80785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013B92 RID: 80786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013B93 RID: 80787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013B94 RID: 80788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013B95 RID: 80789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013B96 RID: 80790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013B97 RID: 80791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013B98 RID: 80792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013B99 RID: 80793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013B9A RID: 80794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013B9B RID: 80795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013B9C RID: 80796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013B9D RID: 80797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013B9E RID: 80798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013B9F RID: 80799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013BA0 RID: 80800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013BA1 RID: 80801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013BA2 RID: 80802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013BA3 RID: 80803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013BA4 RID: 80804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013BA5 RID: 80805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013BA6 RID: 80806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013BA7 RID: 80807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013BA8 RID: 80808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013BA9 RID: 80809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013BAA RID: 80810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013BAB RID: 80811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013BAC RID: 80812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013BAD RID: 80813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013BAE RID: 80814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013BAF RID: 80815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013BB0 RID: 80816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013BB1 RID: 80817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013BB2 RID: 80818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013BB3 RID: 80819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013BB4 RID: 80820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013BB5 RID: 80821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013BB6 RID: 80822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013BB7 RID: 80823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013BB8 RID: 80824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013BB9 RID: 80825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013BBA RID: 80826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013BBB RID: 80827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013BBC RID: 80828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013BBD RID: 80829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
