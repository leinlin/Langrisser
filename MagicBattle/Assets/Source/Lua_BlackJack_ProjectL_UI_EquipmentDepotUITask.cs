using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001426 RID: 5158
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask : LuaObject
{
	// Token: 0x0601D73D RID: 120637 RVA: 0x009532EC File Offset: 0x009514EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			EquipmentDepotUITask o = new EquipmentDepotUITask(name);
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

	// Token: 0x0601D73E RID: 120638 RVA: 0x00953340 File Offset: 0x00951540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D73F RID: 120639 RVA: 0x00953394 File Offset: 0x00951594
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D740 RID: 120640 RVA: 0x009533E8 File Offset: 0x009515E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = equipmentDepotUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601D741 RID: 120641 RVA: 0x00953450 File Offset: 0x00951650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = equipmentDepotUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601D742 RID: 120642 RVA: 0x009534B8 File Offset: 0x009516B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			equipmentDepotUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D743 RID: 120643 RVA: 0x00953514 File Offset: 0x00951714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D744 RID: 120644 RVA: 0x00953568 File Offset: 0x00951768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentDepotUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.EquipmentDepotUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D745 RID: 120645 RVA: 0x009535BC File Offset: 0x009517BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentDepotUIController_OnEquipmentWear(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ulong instanceId;
			LuaObject.checkType(l, 3, out instanceId);
			int slot;
			LuaObject.checkType(l, 4, out slot);
			equipmentDepotUITask.m_luaExportHelper.EquipmentDepotUIController_OnEquipmentWear(heroId, instanceId, slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D746 RID: 120646 RVA: 0x00953634 File Offset: 0x00951834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentDepotUIController_OnEquipmentLockAndUnLock(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			equipmentDepotUITask.m_luaExportHelper.EquipmentDepotUIController_OnEquipmentLockAndUnLock(instanceId, slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D747 RID: 120647 RVA: 0x009536A0 File Offset: 0x009518A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentDepotUIController_OnEquipmentTakeOff(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			equipmentDepotUITask.m_luaExportHelper.EquipmentDepotUIController_OnEquipmentTakeOff(heroId, slot, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D748 RID: 120648 RVA: 0x00953718 File Offset: 0x00951918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentDepotUIController_OnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.EquipmentDepotUIController_OnGoldAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D749 RID: 120649 RVA: 0x0095376C File Offset: 0x0095196C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = equipmentDepotUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601D74A RID: 120650 RVA: 0x009537D4 File Offset: 0x009519D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D74B RID: 120651 RVA: 0x00953828 File Offset: 0x00951A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D74C RID: 120652 RVA: 0x0095387C File Offset: 0x00951A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = equipmentDepotUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601D74D RID: 120653 RVA: 0x009538E4 File Offset: 0x00951AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = equipmentDepotUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601D74E RID: 120654 RVA: 0x0095394C File Offset: 0x00951B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			equipmentDepotUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D74F RID: 120655 RVA: 0x009539B8 File Offset: 0x00951BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			bool b = equipmentDepotUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601D750 RID: 120656 RVA: 0x00953A14 File Offset: 0x00951C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			List<string> o = equipmentDepotUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601D751 RID: 120657 RVA: 0x00953A70 File Offset: 0x00951C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D752 RID: 120658 RVA: 0x00953AC4 File Offset: 0x00951CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D753 RID: 120659 RVA: 0x00953B18 File Offset: 0x00951D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D754 RID: 120660 RVA: 0x00953B6C File Offset: 0x00951D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D755 RID: 120661 RVA: 0x00953BC0 File Offset: 0x00951DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D756 RID: 120662 RVA: 0x00953C14 File Offset: 0x00951E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			equipmentDepotUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D757 RID: 120663 RVA: 0x00953C70 File Offset: 0x00951E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			equipmentDepotUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D758 RID: 120664 RVA: 0x00953CCC File Offset: 0x00951ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			equipmentDepotUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D759 RID: 120665 RVA: 0x00953D28 File Offset: 0x00951F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			equipmentDepotUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D75A RID: 120666 RVA: 0x00953D84 File Offset: 0x00951F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			bool b = equipmentDepotUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601D75B RID: 120667 RVA: 0x00953DE0 File Offset: 0x00951FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			bool b = equipmentDepotUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601D75C RID: 120668 RVA: 0x00953E3C File Offset: 0x0095203C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			bool b = equipmentDepotUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601D75D RID: 120669 RVA: 0x00953E98 File Offset: 0x00952098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			UITaskBase o = equipmentDepotUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601D75E RID: 120670 RVA: 0x00953EF4 File Offset: 0x009520F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D75F RID: 120671 RVA: 0x00953F48 File Offset: 0x00952148
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			equipmentDepotUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D760 RID: 120672 RVA: 0x00953F9C File Offset: 0x0095219C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D761 RID: 120673 RVA: 0x00953FF4 File Offset: 0x009521F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			equipmentDepotUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D762 RID: 120674 RVA: 0x00954050 File Offset: 0x00952250
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D763 RID: 120675 RVA: 0x009540A8 File Offset: 0x009522A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			equipmentDepotUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D764 RID: 120676 RVA: 0x00954104 File Offset: 0x00952304
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUITask.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D765 RID: 120677 RVA: 0x0095415C File Offset: 0x0095235C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			equipmentDepotUITask.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D766 RID: 120678 RVA: 0x009541B8 File Offset: 0x009523B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_slot(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUITask.m_luaExportHelper.m_slot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D767 RID: 120679 RVA: 0x00954210 File Offset: 0x00952410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_slot(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			equipmentDepotUITask.m_luaExportHelper.m_slot = slot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D768 RID: 120680 RVA: 0x0095426C File Offset: 0x0095246C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_state(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUITask.m_luaExportHelper.m_state);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D769 RID: 120681 RVA: 0x009542C4 File Offset: 0x009524C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_state(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			int state;
			LuaObject.checkType(l, 2, out state);
			equipmentDepotUITask.m_luaExportHelper.m_state = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D76A RID: 120682 RVA: 0x00954320 File Offset: 0x00952520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_instanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUITask.m_luaExportHelper.m_instanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D76B RID: 120683 RVA: 0x00954378 File Offset: 0x00952578
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_instanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			equipmentDepotUITask.m_luaExportHelper.m_instanceId = instanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D76C RID: 120684 RVA: 0x009543D4 File Offset: 0x009525D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAlreadyEnter(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUITask.m_luaExportHelper.m_isAlreadyEnter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D76D RID: 120685 RVA: 0x0095442C File Offset: 0x0095262C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isAlreadyEnter(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			bool isAlreadyEnter;
			LuaObject.checkType(l, 2, out isAlreadyEnter);
			equipmentDepotUITask.m_luaExportHelper.m_isAlreadyEnter = isAlreadyEnter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D76E RID: 120686 RVA: 0x00954488 File Offset: 0x00952688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentDepotUIController(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUITask.m_luaExportHelper.m_equipmentDepotUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D76F RID: 120687 RVA: 0x009544E0 File Offset: 0x009526E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentDepotUIController(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			EquipmentDepotUIController equipmentDepotUIController;
			LuaObject.checkType<EquipmentDepotUIController>(l, 2, out equipmentDepotUIController);
			equipmentDepotUITask.m_luaExportHelper.m_equipmentDepotUIController = equipmentDepotUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D770 RID: 120688 RVA: 0x0095453C File Offset: 0x0095273C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D771 RID: 120689 RVA: 0x00954594 File Offset: 0x00952794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			EquipmentDepotUITask equipmentDepotUITask = (EquipmentDepotUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentDepotUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D772 RID: 120690 RVA: 0x009545EC File Offset: 0x009527EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentDepotUITask");
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.EquipmentDepotUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.EquipmentDepotUIController_OnEquipmentWear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.EquipmentDepotUIController_OnEquipmentLockAndUnLock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.EquipmentDepotUIController_OnEquipmentTakeOff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.EquipmentDepotUIController_OnGoldAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache21);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache23, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache25, true);
		string name3 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.get_m_hero);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.set_m_hero);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache27, true);
		string name4 = "m_slot";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.get_m_slot);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.set_m_slot);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache29, true);
		string name5 = "m_state";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.get_m_state);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.set_m_state);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2B, true);
		string name6 = "m_instanceId";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.get_m_instanceId);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.set_m_instanceId);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2D, true);
		string name7 = "m_isAlreadyEnter";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.get_m_isAlreadyEnter);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.set_m_isAlreadyEnter);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache2F, true);
		string name8 = "m_equipmentDepotUIController";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.get_m_equipmentDepotUIController);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.set_m_equipmentDepotUIController);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache31, true);
		string name9 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache32, null, true);
		string name10 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache33, null, true);
		if (Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.<>f__mg$cache34, typeof(EquipmentDepotUITask), typeof(UITask));
	}

	// Token: 0x040138D3 RID: 80083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040138D4 RID: 80084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040138D5 RID: 80085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040138D6 RID: 80086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040138D7 RID: 80087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040138D8 RID: 80088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040138D9 RID: 80089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040138DA RID: 80090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040138DB RID: 80091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040138DC RID: 80092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040138DD RID: 80093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040138DE RID: 80094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040138DF RID: 80095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040138E0 RID: 80096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040138E1 RID: 80097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040138E2 RID: 80098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040138E3 RID: 80099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040138E4 RID: 80100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040138E5 RID: 80101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040138E6 RID: 80102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040138E7 RID: 80103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040138E8 RID: 80104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040138E9 RID: 80105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040138EA RID: 80106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040138EB RID: 80107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040138EC RID: 80108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040138ED RID: 80109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040138EE RID: 80110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040138EF RID: 80111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040138F0 RID: 80112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040138F1 RID: 80113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040138F2 RID: 80114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040138F3 RID: 80115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040138F4 RID: 80116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040138F5 RID: 80117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040138F6 RID: 80118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040138F7 RID: 80119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040138F8 RID: 80120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040138F9 RID: 80121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040138FA RID: 80122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040138FB RID: 80123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040138FC RID: 80124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040138FD RID: 80125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040138FE RID: 80126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040138FF RID: 80127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013900 RID: 80128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013901 RID: 80129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013902 RID: 80130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013903 RID: 80131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013904 RID: 80132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013905 RID: 80133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013906 RID: 80134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013907 RID: 80135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
