using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013FD RID: 5117
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ClimbTowerUIController : LuaObject
{
	// Token: 0x0601CC37 RID: 117815 RVA: 0x008FAA24 File Offset: 0x008F8C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC38 RID: 117816 RVA: 0x008FAA70 File Offset: 0x008F8C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNextFlushTime(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			TimeSpan nextFlushTime;
			LuaObject.checkValueType<TimeSpan>(l, 2, out nextFlushTime);
			climbTowerUIController.SetNextFlushTime(nextFlushTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC39 RID: 117817 RVA: 0x008FAAC8 File Offset: 0x008F8CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetClearAllFloors(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			bool clearAllFloors;
			LuaObject.checkType(l, 2, out clearAllFloors);
			climbTowerUIController.SetClearAllFloors(clearAllFloors);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC3A RID: 117818 RVA: 0x008FAB20 File Offset: 0x008F8D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowClearEffectBegin(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			bool isRaid;
			LuaObject.checkType(l, 2, out isRaid);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			climbTowerUIController.ShowClearEffectBegin(isRaid, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC3B RID: 117819 RVA: 0x008FAB84 File Offset: 0x008F8D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowClearEffectEnd(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.ShowClearEffectEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC3C RID: 117820 RVA: 0x008FABD0 File Offset: 0x008F8DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetProgress(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			float progress;
			LuaObject.checkType(l, 2, out progress);
			climbTowerUIController.SetProgress(progress);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC3D RID: 117821 RVA: 0x008FAC28 File Offset: 0x008F8E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurrentTowerFloor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo currentTowerFloor;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out currentTowerFloor);
			climbTowerUIController.SetCurrentTowerFloor(currentTowerFloor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC3E RID: 117822 RVA: 0x008FAC80 File Offset: 0x008F8E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTowerFloor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 3, out floorInfo);
			ConfigDataTowerLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTowerLevelInfo>(l, 4, out levelInfo);
			bool isCleared;
			LuaObject.checkType(l, 5, out isCleared);
			bool isLocked;
			LuaObject.checkType(l, 6, out isLocked);
			climbTowerUIController.SetTowerFloor(idx, floorInfo, levelInfo, isCleared, isLocked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC3F RID: 117823 RVA: 0x008FAD0C File Offset: 0x008F8F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRaidButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			climbTowerUIController.ShowRaidButton(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC40 RID: 117824 RVA: 0x008FAD64 File Offset: 0x008F8F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRaidTowerFloor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo historyMaxFloorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out historyMaxFloorInfo);
			ConfigDataTowerFloorInfo raidMaxFloorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 3, out raidMaxFloorInfo);
			bool canRaid;
			LuaObject.checkType(l, 4, out canRaid);
			climbTowerUIController.SetRaidTowerFloor(historyMaxFloorInfo, raidMaxFloorInfo, canRaid);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC41 RID: 117825 RVA: 0x008FADD8 File Offset: 0x008F8FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRewardPreview(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.ShowRewardPreview();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC42 RID: 117826 RVA: 0x008FAE24 File Offset: 0x008F9024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRaidPanel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			int curEnrgy;
			LuaObject.checkType(l, 2, out curEnrgy);
			int costEnergy;
			LuaObject.checkType(l, 3, out costEnergy);
			ConfigDataTowerFloorInfo reachFloorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 4, out reachFloorInfo);
			climbTowerUIController.ShowRaidPanel(curEnrgy, costEnergy, reachFloorInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC43 RID: 117827 RVA: 0x008FAE98 File Offset: 0x008F9098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC44 RID: 117828 RVA: 0x008FAEEC File Offset: 0x008F90EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowClearEffectBegin(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			bool isRaid;
			LuaObject.checkType(l, 2, out isRaid);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			IEnumerator o = climbTowerUIController.m_luaExportHelper.Co_ShowClearEffectBegin(isRaid, onEnd);
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

	// Token: 0x0601CC45 RID: 117829 RVA: 0x008FAF60 File Offset: 0x008F9160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideRewardPreview(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.HideRewardPreview();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC46 RID: 117830 RVA: 0x008FAFB4 File Offset: 0x008F91B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideRaidPanel(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			climbTowerUIController.m_luaExportHelper.HideRaidPanel(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC47 RID: 117831 RVA: 0x008FB010 File Offset: 0x008F9210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC48 RID: 117832 RVA: 0x008FB064 File Offset: 0x008F9264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC49 RID: 117833 RVA: 0x008FB0B8 File Offset: 0x008F92B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC4A RID: 117834 RVA: 0x008FB10C File Offset: 0x008F930C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRaidButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.OnRaidButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC4B RID: 117835 RVA: 0x008FB160 File Offset: 0x008F9360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.OnShowRewardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC4C RID: 117836 RVA: 0x008FB1B4 File Offset: 0x008F93B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRewardPreviewCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.OnRewardPreviewCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC4D RID: 117837 RVA: 0x008FB208 File Offset: 0x008F9408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRaidPanelConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.OnRaidPanelConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC4E RID: 117838 RVA: 0x008FB25C File Offset: 0x008F945C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRaidPanelCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.OnRaidPanelCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC4F RID: 117839 RVA: 0x008FB2B0 File Offset: 0x008F94B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClimbTowerFloorItemUIController_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			ClimbTowerFloorItemUIController ctrl;
			LuaObject.checkType<ClimbTowerFloorItemUIController>(l, 2, out ctrl);
			climbTowerUIController.m_luaExportHelper.ClimbTowerFloorItemUIController_OnButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC50 RID: 117840 RVA: 0x008FB30C File Offset: 0x008F950C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			climbTowerUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC51 RID: 117841 RVA: 0x008FB378 File Offset: 0x008F9578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC52 RID: 117842 RVA: 0x008FB3CC File Offset: 0x008F95CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC53 RID: 117843 RVA: 0x008FB420 File Offset: 0x008F9620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = climbTowerUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CC54 RID: 117844 RVA: 0x008FB4C8 File Offset: 0x008F96C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC55 RID: 117845 RVA: 0x008FB51C File Offset: 0x008F971C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			climbTowerUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC56 RID: 117846 RVA: 0x008FB588 File Offset: 0x008F9788
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
				ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				climbTowerUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ClimbTowerUIController climbTowerUIController2 = (ClimbTowerUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				climbTowerUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CC57 RID: 117847 RVA: 0x008FB698 File Offset: 0x008F9898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC58 RID: 117848 RVA: 0x008FB704 File Offset: 0x008F9904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC59 RID: 117849 RVA: 0x008FB770 File Offset: 0x008F9970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC5A RID: 117850 RVA: 0x008FB7DC File Offset: 0x008F99DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC5B RID: 117851 RVA: 0x008FB848 File Offset: 0x008F9A48
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
				ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				climbTowerUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ClimbTowerUIController climbTowerUIController2 = (ClimbTowerUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				climbTowerUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CC5C RID: 117852 RVA: 0x008FB958 File Offset: 0x008F9B58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			string s = climbTowerUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CC5D RID: 117853 RVA: 0x008FB9B4 File Offset: 0x008F9BB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC5E RID: 117854 RVA: 0x008FBA08 File Offset: 0x008F9C08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC5F RID: 117855 RVA: 0x008FBA5C File Offset: 0x008F9C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC60 RID: 117856 RVA: 0x008FBAB0 File Offset: 0x008F9CB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC61 RID: 117857 RVA: 0x008FBB04 File Offset: 0x008F9D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowRaid(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__callDele_EventOnShowRaid();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC62 RID: 117858 RVA: 0x008FBB58 File Offset: 0x008F9D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowRaid(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__clearDele_EventOnShowRaid();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC63 RID: 117859 RVA: 0x008FBBAC File Offset: 0x008F9DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__callDele_EventOnShowLevelInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC64 RID: 117860 RVA: 0x008FBC00 File Offset: 0x008F9E00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnShowLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__clearDele_EventOnShowLevelInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC65 RID: 117861 RVA: 0x008FBC54 File Offset: 0x008F9E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnConfirmRaid(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__callDele_EventOnConfirmRaid();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC66 RID: 117862 RVA: 0x008FBCA8 File Offset: 0x008F9EA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnConfirmRaid(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			climbTowerUIController.m_luaExportHelper.__clearDele_EventOnConfirmRaid();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC67 RID: 117863 RVA: 0x008FBCFC File Offset: 0x008F9EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					climbTowerUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					climbTowerUIController.EventOnReturn -= value;
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

	// Token: 0x0601CC68 RID: 117864 RVA: 0x008FBD7C File Offset: 0x008F9F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					climbTowerUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					climbTowerUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601CC69 RID: 117865 RVA: 0x008FBDFC File Offset: 0x008F9FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowRaid(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					climbTowerUIController.EventOnShowRaid += value;
				}
				else if (num == 2)
				{
					climbTowerUIController.EventOnShowRaid -= value;
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

	// Token: 0x0601CC6A RID: 117866 RVA: 0x008FBE7C File Offset: 0x008FA07C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					climbTowerUIController.EventOnShowLevelInfo += value;
				}
				else if (num == 2)
				{
					climbTowerUIController.EventOnShowLevelInfo -= value;
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

	// Token: 0x0601CC6B RID: 117867 RVA: 0x008FBEFC File Offset: 0x008FA0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnConfirmRaid(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					climbTowerUIController.EventOnConfirmRaid += value;
				}
				else if (num == 2)
				{
					climbTowerUIController.EventOnConfirmRaid -= value;
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

	// Token: 0x0601CC6C RID: 117868 RVA: 0x008FBF7C File Offset: 0x008FA17C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC6D RID: 117869 RVA: 0x008FBFD4 File Offset: 0x008FA1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			climbTowerUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC6E RID: 117870 RVA: 0x008FC030 File Offset: 0x008FA230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC6F RID: 117871 RVA: 0x008FC088 File Offset: 0x008FA288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			climbTowerUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC70 RID: 117872 RVA: 0x008FC0E4 File Offset: 0x008FA2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC71 RID: 117873 RVA: 0x008FC13C File Offset: 0x008FA33C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			climbTowerUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC72 RID: 117874 RVA: 0x008FC198 File Offset: 0x008FA398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showRewardButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_showRewardButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC73 RID: 117875 RVA: 0x008FC1F0 File Offset: 0x008FA3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showRewardButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Button showRewardButton;
			LuaObject.checkType<Button>(l, 2, out showRewardButton);
			climbTowerUIController.m_luaExportHelper.m_showRewardButton = showRewardButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC74 RID: 117876 RVA: 0x008FC24C File Offset: 0x008FA44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC75 RID: 117877 RVA: 0x008FC2A4 File Offset: 0x008FA4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			climbTowerUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC76 RID: 117878 RVA: 0x008FC300 File Offset: 0x008FA500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clearUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_clearUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC77 RID: 117879 RVA: 0x008FC358 File Offset: 0x008FA558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clearUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			CommonUIStateController clearUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out clearUIStateController);
			climbTowerUIController.m_luaExportHelper.m_clearUIStateController = clearUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC78 RID: 117880 RVA: 0x008FC3B4 File Offset: 0x008FA5B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_raidButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC79 RID: 117881 RVA: 0x008FC40C File Offset: 0x008FA60C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raidButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Button raidButton;
			LuaObject.checkType<Button>(l, 2, out raidButton);
			climbTowerUIController.m_luaExportHelper.m_raidButton = raidButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC7A RID: 117882 RVA: 0x008FC468 File Offset: 0x008FA668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_raidButtonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC7B RID: 117883 RVA: 0x008FC4C0 File Offset: 0x008FA6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raidButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			CommonUIStateController raidButtonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out raidButtonUIStateController);
			climbTowerUIController.m_luaExportHelper.m_raidButtonUIStateController = raidButtonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC7C RID: 117884 RVA: 0x008FC51C File Offset: 0x008FA71C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_historyMaxFloorText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_historyMaxFloorText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC7D RID: 117885 RVA: 0x008FC574 File Offset: 0x008FA774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_historyMaxFloorText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Text historyMaxFloorText;
			LuaObject.checkType<Text>(l, 2, out historyMaxFloorText);
			climbTowerUIController.m_luaExportHelper.m_historyMaxFloorText = historyMaxFloorText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC7E RID: 117886 RVA: 0x008FC5D0 File Offset: 0x008FA7D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_raidMaxFloorText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_raidMaxFloorText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC7F RID: 117887 RVA: 0x008FC628 File Offset: 0x008FA828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raidMaxFloorText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Text raidMaxFloorText;
			LuaObject.checkType<Text>(l, 2, out raidMaxFloorText);
			climbTowerUIController.m_luaExportHelper.m_raidMaxFloorText = raidMaxFloorText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC80 RID: 117888 RVA: 0x008FC684 File Offset: 0x008FA884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bigFloorNameText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_bigFloorNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC81 RID: 117889 RVA: 0x008FC6DC File Offset: 0x008FA8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigFloorNameText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Text bigFloorNameText;
			LuaObject.checkType<Text>(l, 2, out bigFloorNameText);
			climbTowerUIController.m_luaExportHelper.m_bigFloorNameText = bigFloorNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC82 RID: 117890 RVA: 0x008FC738 File Offset: 0x008FA938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_blackCoverUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_blackCoverUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC83 RID: 117891 RVA: 0x008FC790 File Offset: 0x008FA990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_blackCoverUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			CommonUIStateController blackCoverUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out blackCoverUIStateController);
			climbTowerUIController.m_luaExportHelper.m_blackCoverUIStateController = blackCoverUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC84 RID: 117892 RVA: 0x008FC7EC File Offset: 0x008FA9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_floor0FloorGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_floor0FloorGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC85 RID: 117893 RVA: 0x008FC844 File Offset: 0x008FAA44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_floor0FloorGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			GameObject floor0FloorGameObject;
			LuaObject.checkType<GameObject>(l, 2, out floor0FloorGameObject);
			climbTowerUIController.m_luaExportHelper.m_floor0FloorGameObject = floor0FloorGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC86 RID: 117894 RVA: 0x008FC8A0 File Offset: 0x008FAAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_floor1FloorGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_floor1FloorGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC87 RID: 117895 RVA: 0x008FC8F8 File Offset: 0x008FAAF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_floor1FloorGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			GameObject floor1FloorGameObject;
			LuaObject.checkType<GameObject>(l, 2, out floor1FloorGameObject);
			climbTowerUIController.m_luaExportHelper.m_floor1FloorGameObject = floor1FloorGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC88 RID: 117896 RVA: 0x008FC954 File Offset: 0x008FAB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_floor2FloorGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_floor2FloorGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC89 RID: 117897 RVA: 0x008FC9AC File Offset: 0x008FABAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_floor2FloorGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			GameObject floor2FloorGameObject;
			LuaObject.checkType<GameObject>(l, 2, out floor2FloorGameObject);
			climbTowerUIController.m_luaExportHelper.m_floor2FloorGameObject = floor2FloorGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC8A RID: 117898 RVA: 0x008FCA08 File Offset: 0x008FAC08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_floor3FloorGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_floor3FloorGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC8B RID: 117899 RVA: 0x008FCA60 File Offset: 0x008FAC60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_floor3FloorGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			GameObject floor3FloorGameObject;
			LuaObject.checkType<GameObject>(l, 2, out floor3FloorGameObject);
			climbTowerUIController.m_luaExportHelper.m_floor3FloorGameObject = floor3FloorGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC8C RID: 117900 RVA: 0x008FCABC File Offset: 0x008FACBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_floor4FloorGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_floor4FloorGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC8D RID: 117901 RVA: 0x008FCB14 File Offset: 0x008FAD14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_floor4FloorGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			GameObject floor4FloorGameObject;
			LuaObject.checkType<GameObject>(l, 2, out floor4FloorGameObject);
			climbTowerUIController.m_luaExportHelper.m_floor4FloorGameObject = floor4FloorGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC8E RID: 117902 RVA: 0x008FCB70 File Offset: 0x008FAD70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_progressSlider(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_progressSlider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC8F RID: 117903 RVA: 0x008FCBC8 File Offset: 0x008FADC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_progressSlider(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Slider progressSlider;
			LuaObject.checkType<Slider>(l, 2, out progressSlider);
			climbTowerUIController.m_luaExportHelper.m_progressSlider = progressSlider;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC90 RID: 117904 RVA: 0x008FCC24 File Offset: 0x008FAE24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_progressInfoText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_progressInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC91 RID: 117905 RVA: 0x008FCC7C File Offset: 0x008FAE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressInfoText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Text progressInfoText;
			LuaObject.checkType<Text>(l, 2, out progressInfoText);
			climbTowerUIController.m_luaExportHelper.m_progressInfoText = progressInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC92 RID: 117906 RVA: 0x008FCCD8 File Offset: 0x008FAED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_flushTimeText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_flushTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC93 RID: 117907 RVA: 0x008FCD30 File Offset: 0x008FAF30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_flushTimeText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Text flushTimeText;
			LuaObject.checkType<Text>(l, 2, out flushTimeText);
			climbTowerUIController.m_luaExportHelper.m_flushTimeText = flushTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC94 RID: 117908 RVA: 0x008FCD8C File Offset: 0x008FAF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardPreviewUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_rewardPreviewUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC95 RID: 117909 RVA: 0x008FCDE4 File Offset: 0x008FAFE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rewardPreviewUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			CommonUIStateController rewardPreviewUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out rewardPreviewUIStateController);
			climbTowerUIController.m_luaExportHelper.m_rewardPreviewUIStateController = rewardPreviewUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC96 RID: 117910 RVA: 0x008FCE40 File Offset: 0x008FB040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardPreviewBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_rewardPreviewBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC97 RID: 117911 RVA: 0x008FCE98 File Offset: 0x008FB098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardPreviewBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Button rewardPreviewBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out rewardPreviewBackgroundButton);
			climbTowerUIController.m_luaExportHelper.m_rewardPreviewBackgroundButton = rewardPreviewBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC98 RID: 117912 RVA: 0x008FCEF4 File Offset: 0x008FB0F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rewardPreviewScollRect(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_rewardPreviewScollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC99 RID: 117913 RVA: 0x008FCF4C File Offset: 0x008FB14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rewardPreviewScollRect(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			ScrollRect rewardPreviewScollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out rewardPreviewScollRect);
			climbTowerUIController.m_luaExportHelper.m_rewardPreviewScollRect = rewardPreviewScollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC9A RID: 117914 RVA: 0x008FCFA8 File Offset: 0x008FB1A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_raidPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_raidPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC9B RID: 117915 RVA: 0x008FD000 File Offset: 0x008FB200
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_raidPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			CommonUIStateController raidPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out raidPanelUIStateController);
			climbTowerUIController.m_luaExportHelper.m_raidPanelUIStateController = raidPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC9C RID: 117916 RVA: 0x008FD05C File Offset: 0x008FB25C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidPanelNowEnergyText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_raidPanelNowEnergyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC9D RID: 117917 RVA: 0x008FD0B4 File Offset: 0x008FB2B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_raidPanelNowEnergyText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Text raidPanelNowEnergyText;
			LuaObject.checkType<Text>(l, 2, out raidPanelNowEnergyText);
			climbTowerUIController.m_luaExportHelper.m_raidPanelNowEnergyText = raidPanelNowEnergyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC9E RID: 117918 RVA: 0x008FD110 File Offset: 0x008FB310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidPanelNeedEnergyText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_raidPanelNeedEnergyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC9F RID: 117919 RVA: 0x008FD168 File Offset: 0x008FB368
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_raidPanelNeedEnergyText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Text raidPanelNeedEnergyText;
			LuaObject.checkType<Text>(l, 2, out raidPanelNeedEnergyText);
			climbTowerUIController.m_luaExportHelper.m_raidPanelNeedEnergyText = raidPanelNeedEnergyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCA0 RID: 117920 RVA: 0x008FD1C4 File Offset: 0x008FB3C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidPanelText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_raidPanelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCA1 RID: 117921 RVA: 0x008FD21C File Offset: 0x008FB41C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raidPanelText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Text raidPanelText;
			LuaObject.checkType<Text>(l, 2, out raidPanelText);
			climbTowerUIController.m_luaExportHelper.m_raidPanelText = raidPanelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCA2 RID: 117922 RVA: 0x008FD278 File Offset: 0x008FB478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_raidPanelConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCA3 RID: 117923 RVA: 0x008FD2D0 File Offset: 0x008FB4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raidPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Button raidPanelConfirmButton;
			LuaObject.checkType<Button>(l, 2, out raidPanelConfirmButton);
			climbTowerUIController.m_luaExportHelper.m_raidPanelConfirmButton = raidPanelConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCA4 RID: 117924 RVA: 0x008FD32C File Offset: 0x008FB52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raidPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_raidPanelCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCA5 RID: 117925 RVA: 0x008FD384 File Offset: 0x008FB584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raidPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			Button raidPanelCancelButton;
			LuaObject.checkType<Button>(l, 2, out raidPanelCancelButton);
			climbTowerUIController.m_luaExportHelper.m_raidPanelCancelButton = raidPanelCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCA6 RID: 117926 RVA: 0x008FD3E0 File Offset: 0x008FB5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCA7 RID: 117927 RVA: 0x008FD438 File Offset: 0x008FB638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			climbTowerUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCA8 RID: 117928 RVA: 0x008FD494 File Offset: 0x008FB694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_rewardItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCA9 RID: 117929 RVA: 0x008FD4EC File Offset: 0x008FB6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			GameObject rewardItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out rewardItemPrefab);
			climbTowerUIController.m_luaExportHelper.m_rewardItemPrefab = rewardItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCAA RID: 117930 RVA: 0x008FD548 File Offset: 0x008FB748
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_climbTowerFloorItemUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerUIController.m_luaExportHelper.m_climbTowerFloorItemUIControllers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCAB RID: 117931 RVA: 0x008FD5A0 File Offset: 0x008FB7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_climbTowerFloorItemUIControllers(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerUIController climbTowerUIController = (ClimbTowerUIController)LuaObject.checkSelf(l);
			ClimbTowerFloorItemUIController[] climbTowerFloorItemUIControllers;
			LuaObject.checkArray<ClimbTowerFloorItemUIController>(l, 2, out climbTowerFloorItemUIControllers);
			climbTowerUIController.m_luaExportHelper.m_climbTowerFloorItemUIControllers = climbTowerFloorItemUIControllers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCAC RID: 117932 RVA: 0x008FD5FC File Offset: 0x008FB7FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ClimbTowerUIController");
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.SetNextFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.SetClearAllFloors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.ShowClearEffectBegin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.ShowClearEffectEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.SetProgress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.SetCurrentTowerFloor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.SetTowerFloor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.ShowRaidButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.SetRaidTowerFloor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.ShowRewardPreview);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.ShowRaidPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.Co_ShowClearEffectBegin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.HideRewardPreview);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.HideRaidPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.OnRaidButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.OnShowRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.OnRewardPreviewCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.OnRaidPanelConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.OnRaidPanelCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.ClimbTowerFloorItemUIController_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callDele_EventOnShowRaid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__clearDele_EventOnShowRaid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callDele_EventOnShowLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__clearDele_EventOnShowLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__callDele_EventOnConfirmRaid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.__clearDele_EventOnConfirmRaid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache2F);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache30, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache31, true);
		string name3 = "EventOnShowRaid";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_EventOnShowRaid);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache32, true);
		string name4 = "EventOnShowLevelInfo";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_EventOnShowLevelInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache33, true);
		string name5 = "EventOnConfirmRaid";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_EventOnConfirmRaid);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache34, true);
		string name6 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_uiStateController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache36, true);
		string name7 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_returnButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache38, true);
		string name8 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_helpButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3A, true);
		string name9 = "m_showRewardButton";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_showRewardButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_showRewardButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3C, true);
		string name10 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_startButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3E, true);
		string name11 = "m_clearUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_clearUIStateController);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_clearUIStateController);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache40, true);
		string name12 = "m_raidButton";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_raidButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_raidButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache42, true);
		string name13 = "m_raidButtonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_raidButtonUIStateController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_raidButtonUIStateController);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache44, true);
		string name14 = "m_historyMaxFloorText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_historyMaxFloorText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_historyMaxFloorText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache46, true);
		string name15 = "m_raidMaxFloorText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_raidMaxFloorText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_raidMaxFloorText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache48, true);
		string name16 = "m_bigFloorNameText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_bigFloorNameText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_bigFloorNameText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4A, true);
		string name17 = "m_blackCoverUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_blackCoverUIStateController);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_blackCoverUIStateController);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4C, true);
		string name18 = "m_floor0FloorGameObject";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_floor0FloorGameObject);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_floor0FloorGameObject);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4E, true);
		string name19 = "m_floor1FloorGameObject";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_floor1FloorGameObject);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_floor1FloorGameObject);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache50, true);
		string name20 = "m_floor2FloorGameObject";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_floor2FloorGameObject);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_floor2FloorGameObject);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache52, true);
		string name21 = "m_floor3FloorGameObject";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_floor3FloorGameObject);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_floor3FloorGameObject);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache54, true);
		string name22 = "m_floor4FloorGameObject";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_floor4FloorGameObject);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_floor4FloorGameObject);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache56, true);
		string name23 = "m_progressSlider";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_progressSlider);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_progressSlider);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache58, true);
		string name24 = "m_progressInfoText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_progressInfoText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_progressInfoText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5A, true);
		string name25 = "m_flushTimeText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_flushTimeText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_flushTimeText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5C, true);
		string name26 = "m_rewardPreviewUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_rewardPreviewUIStateController);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_rewardPreviewUIStateController);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5E, true);
		string name27 = "m_rewardPreviewBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_rewardPreviewBackgroundButton);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_rewardPreviewBackgroundButton);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache60, true);
		string name28 = "m_rewardPreviewScollRect";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_rewardPreviewScollRect);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_rewardPreviewScollRect);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache62, true);
		string name29 = "m_raidPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_raidPanelUIStateController);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_raidPanelUIStateController);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache64, true);
		string name30 = "m_raidPanelNowEnergyText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_raidPanelNowEnergyText);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_raidPanelNowEnergyText);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache66, true);
		string name31 = "m_raidPanelNeedEnergyText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_raidPanelNeedEnergyText);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_raidPanelNeedEnergyText);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache68, true);
		string name32 = "m_raidPanelText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_raidPanelText);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_raidPanelText);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6A, true);
		string name33 = "m_raidPanelConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_raidPanelConfirmButton);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_raidPanelConfirmButton);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6C, true);
		string name34 = "m_raidPanelCancelButton";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_raidPanelCancelButton);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_raidPanelCancelButton);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6E, true);
		string name35 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache70, true);
		string name36 = "m_rewardItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_rewardItemPrefab);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_rewardItemPrefab);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache72, true);
		string name37 = "m_climbTowerFloorItemUIControllers";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.get_m_climbTowerFloorItemUIControllers);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.set_m_climbTowerFloorItemUIControllers);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.<>f__mg$cache74, true);
		LuaObject.createTypeMetatable(l, null, typeof(ClimbTowerUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012E1F RID: 77343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012E20 RID: 77344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012E21 RID: 77345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012E22 RID: 77346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012E23 RID: 77347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012E24 RID: 77348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012E25 RID: 77349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012E26 RID: 77350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012E27 RID: 77351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012E28 RID: 77352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012E29 RID: 77353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012E2A RID: 77354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012E2B RID: 77355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012E2C RID: 77356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012E2D RID: 77357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012E2E RID: 77358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012E2F RID: 77359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012E30 RID: 77360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012E31 RID: 77361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012E32 RID: 77362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012E33 RID: 77363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012E34 RID: 77364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012E35 RID: 77365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012E36 RID: 77366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012E37 RID: 77367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012E38 RID: 77368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012E39 RID: 77369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012E3A RID: 77370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012E3B RID: 77371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012E3C RID: 77372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012E3D RID: 77373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012E3E RID: 77374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012E3F RID: 77375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012E40 RID: 77376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012E41 RID: 77377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012E42 RID: 77378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012E43 RID: 77379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012E44 RID: 77380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012E45 RID: 77381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012E46 RID: 77382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012E47 RID: 77383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012E48 RID: 77384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012E49 RID: 77385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012E4A RID: 77386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012E4B RID: 77387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012E4C RID: 77388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012E4D RID: 77389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012E4E RID: 77390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012E4F RID: 77391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012E50 RID: 77392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012E51 RID: 77393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012E52 RID: 77394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012E53 RID: 77395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012E54 RID: 77396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012E55 RID: 77397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012E56 RID: 77398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012E57 RID: 77399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012E58 RID: 77400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04012E59 RID: 77401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012E5A RID: 77402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04012E5B RID: 77403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04012E5C RID: 77404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04012E5D RID: 77405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04012E5E RID: 77406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04012E5F RID: 77407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04012E60 RID: 77408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04012E61 RID: 77409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04012E62 RID: 77410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04012E63 RID: 77411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04012E64 RID: 77412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04012E65 RID: 77413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04012E66 RID: 77414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04012E67 RID: 77415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04012E68 RID: 77416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04012E69 RID: 77417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04012E6A RID: 77418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04012E6B RID: 77419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04012E6C RID: 77420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04012E6D RID: 77421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04012E6E RID: 77422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04012E6F RID: 77423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04012E70 RID: 77424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04012E71 RID: 77425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04012E72 RID: 77426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04012E73 RID: 77427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04012E74 RID: 77428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04012E75 RID: 77429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04012E76 RID: 77430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04012E77 RID: 77431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04012E78 RID: 77432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04012E79 RID: 77433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04012E7A RID: 77434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04012E7B RID: 77435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04012E7C RID: 77436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04012E7D RID: 77437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04012E7E RID: 77438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04012E7F RID: 77439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04012E80 RID: 77440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04012E81 RID: 77441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04012E82 RID: 77442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04012E83 RID: 77443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04012E84 RID: 77444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04012E85 RID: 77445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04012E86 RID: 77446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04012E87 RID: 77447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04012E88 RID: 77448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04012E89 RID: 77449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04012E8A RID: 77450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04012E8B RID: 77451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04012E8C RID: 77452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04012E8D RID: 77453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04012E8E RID: 77454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04012E8F RID: 77455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04012E90 RID: 77456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04012E91 RID: 77457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04012E92 RID: 77458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04012E93 RID: 77459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;
}
